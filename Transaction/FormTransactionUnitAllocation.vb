Imports System.IO
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalDate
Imports simpi.MasterPortfolio
Imports simpi.MasterClient
Imports simpi.MasterSecurities
Imports simpi.ParameterTA.ParameterTA
Imports simpi.CoreOverride
Imports simpi.CoreData

Public Class FormTransactionUnitAllocation
    Dim objPortfolio As New MasterPortfolio
    Dim objClientKYC As New ClientKYC
    Dim objOverride As New OverrideCapital
    Dim objNAV As New PortfolioNAV
    Dim objMTM As New PortfolioMTM

    Private Sub FormTransactionUnitAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        lblSalesInternal.Text = objMasterSimpi.GetCodeset(8)

        GetComboInit(New ParameterExternalSystem, cmbExternalPortfolio, "SystemID", "SystemCode")
        objPortfolio.UserAccess = objAccess
        objClientKYC.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objMTM.UserAccess = objAccess
    End Sub

    Private Sub setButton(ByVal buttonState As Boolean)
        btnBrowse.Enabled = buttonState
        btnRead.Enabled = buttonState
        txtFilename.Enabled = buttonState
        btnProcess.Enabled = buttonState
        cmbExternalPortfolio.Enabled = buttonState
    End Sub

#Region "read"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenExcel()
    End Sub

    Private Sub txtFilename_Click(sender As Object, e As EventArgs) Handles txtFilename.Click
        OpenExcel()
    End Sub

    Private Sub txtFilename_TextChanged(sender As Object, e As EventArgs) Handles txtFilename.TextChanged
        If txtFilename.Text.Trim <> "" Then btnRead.Enabled = True Else btnRead.Enabled = False
    End Sub

    Private Sub OpenExcel()
        Dim myStream As Stream = Nothing
        Dim ofd As New OpenFileDialog()
        Dim fileReader As StreamReader = Nothing
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then txtFilename.Text = ofd.FileName
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        lblRows.Text = ""
        setButton(False)
        bwExcel.RunWorkerAsync()
    End Sub

    Private Sub bwExcel_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwExcel.DoWork
        ReadExcel()
    End Sub

    Private Sub bwExcel_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwExcel.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Function FileValidation() As Boolean
        If Trim(txtFilename.Text) = "" Then
            ExceptionMessage.Show(objError.Message(81) & " filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Trim(txtSheet.Text) = "" Then
            ExceptionMessage.Show(objError.Message(81) & " sheet name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Not IsNumeric(txtRowStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " start row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Not IsNumeric(txtColStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " start col", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Not IsNumeric(txtColNo.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " number of cols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        FileValidation = True
    End Function

    Private Sub ReadExcel()
        If Not FileValidation() Then Exit Sub
        Try
            fgExcel.LoadExcel(txtFilename.Text, Trim(txtSheet.Text), C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            lblRows.Text = fgExcel.Rows.Count - 1
            lblAsOf.Text = ConvertToDate(fgExcel(fgExcel.Rows.Count - 1, 1), "YMD").ToString("dd-MMM-yyyy")
            fgExcel.AutoSizeCols()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "process"
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        setButton(False)
        bwRun.RunWorkerAsync()
    End Sub

    Private Sub bwRun_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        DataProcess()
    End Sub

    Private Sub bwRun_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Sub initTransaction()
        With fgTransaction
            .Rows.Count = 1
            .Cols.Count = 12
            .ExtendLastCol = False
            fgTransaction(0, 0) = "No"
            fgTransaction(0, 1) = "Status"
            fgTransaction(0, 2) = "Error Msg"
            fgTransaction(0, 3) = "Fund"
            fgTransaction(0, 4) = "Name"
            fgTransaction(0, 5) = "FundAccount"
            fgTransaction(0, 6) = "Client"
            fgTransaction(0, 7) = "Type"
            fgTransaction(0, 8) = "Amount"
            fgTransaction(0, 9) = "Net"
            fgTransaction(0, 10) = "NAV"
            fgTransaction(0, 11) = "Unit"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub DataProcess()
        If fgExcel.Rows.Count > 0 And cmbExternalPortfolio.SelectedIndex <> -1 Then
            Dim trxAmount, trxPrice, trxFee, trxUnit As Double
            Dim portfolioCode, fundAccount, trxType As String

            pbNAV.Value = 100
            lblSucced.Text = "0"
            lblFailed.Text = "0"
            lblSubscriptionAccount.Text = "0"
            lblSubscriptionAmount.Text = "0"
            lblRedemptionAccount.Text = "0"
            lblRedemptionAmount.Text = "0"
            initTransaction()
            For i = 1 To fgExcel.Rows.Count - 1
                fgTransaction.Rows.Add()
                fgTransaction(fgTransaction.Rows.Count - 1, 0) = fgTransaction.Rows.Count - 1

                portfolioCode = ""
                If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then portfolioCode = fgExcel(i, 6).ToString.Trim
                objPortfolio.Clear()
                objPortfolio.ExternalID_Load(objMasterSimpi, cmbExternalPortfolio.SelectedValue, portfolioCode)
                If objPortfolio.ErrID = 0 Then
                    objMTM.Clear()
                    objMTM.LoadEnd(objPortfolio)
                    If objMTM.GetPositionDate.Date <> CDate(lblAsOf.Text).Date Then
                        fgTransaction(fgTransaction.Rows.Count - 1, 1) = "ERROR"
                        fgTransaction(fgTransaction.Rows.Count - 1, 2) = "As of transaction different with last portfolio mark to market"
                        lblFailed.Text = CInt(lblFailed.Text) + 1
                    Else
                        fgTransaction(fgTransaction.Rows.Count - 1, 3) = portfolioCode
                        fgTransaction(fgTransaction.Rows.Count - 1, 4) = objPortfolio.GetPortfolioNameShort

                        fundAccount = ""
                        If Not IsNothing(fgExcel(i, 3)) Then If fgExcel(i, 3).ToString.Trim <> "" Then fundAccount = fgExcel(i, 3).ToString.Trim
                        objClientKYC.Clear()
                        objClientKYC.Load(objMasterSimpi, CInt(lblFundAccountID.Text), fundAccount)
                        If objClientKYC.ErrID = 0 Then
                            trxType = ""
                            If Not IsNothing(fgExcel(i, 2)) Then If fgExcel(i, 2).ToString.Trim <> "" Then trxType = fgExcel(i, 2).ToString.Trim
                            fgTransaction(fgTransaction.Rows.Count - 1, 5) = fundAccount
                            fgTransaction(fgTransaction.Rows.Count - 1, 6) = objClientKYC.GetMasterClient.GetClientName
                            fgTransaction(fgTransaction.Rows.Count - 1, 7) = trxType

                            trxAmount = 0
                            trxPrice = 0
                            trxFee = 0
                            trxUnit = 0
                            If Not IsNothing(fgExcel(i, 17)) Then If fgExcel(i, 17).ToString.Trim <> "" Then Double.TryParse(fgExcel(i, 17), trxAmount)
                            If Not IsNothing(fgExcel(i, 18)) Then If fgExcel(i, 18).ToString.Trim <> "" Then Double.TryParse(fgExcel(i, 18), trxFee)
                            If Not IsNothing(fgExcel(i, 15)) Then If fgExcel(i, 15).ToString.Trim <> "" Then Double.TryParse(fgExcel(i, 15), trxUnit)
                            If Not IsNothing(fgExcel(i, 16)) Then If fgExcel(i, 16).ToString.Trim <> "" Then Double.TryParse(fgExcel(i, 16), trxPrice)
                            If trxAmount = 0 Then
                                If trxPrice = 0 Then
                                    objNAV.Clear()
                                    objNAV.LoadAt(objPortfolio, CDate(lblAsOf.Text))
                                    If objNAV.ErrID = 0 Then trxPrice = objNAV.GetNAVPerUnit
                                End If
                                trxAmount = trxUnit * trxPrice
                            End If
                            fgTransaction(fgTransaction.Rows.Count - 1, 8) = trxAmount
                            fgTransaction(fgTransaction.Rows.Count - 1, 9) = trxAmount - trxFee
                            fgTransaction(fgTransaction.Rows.Count - 1, 10) = trxPrice
                            fgTransaction(fgTransaction.Rows.Count - 1, 11) = trxUnit

                            objOverride.Clear()
                            If IsSubscription(trxType) Then
                                If trxFee > 0 Then trxFee = trxFee / (trxAmount - trxFee)
                                objOverride.subscription(objPortfolio, objClientKYC.GetMasterClient, CDate(lblAsOf.Text), trxAmount, trxFee)
                                If objOverride.ErrID = 0 Then
                                    fgTransaction(fgTransaction.Rows.Count - 1, 1) = "DONE"
                                    fgTransaction(fgTransaction.Rows.Count - 1, 2) = ""
                                    lblSucced.Text = CInt(lblSucced.Text) + 1
                                    lblSubscriptionAccount.Text = CInt(lblSubscriptionAccount.Text) + 1
                                    lblSubscriptionAmount.Text = (CDbl(lblSubscriptionAmount.Text) + trxAmount).ToString("n0")
                                Else
                                    fgTransaction(fgTransaction.Rows.Count - 1, 1) = "ERROR"
                                    fgTransaction(fgTransaction.Rows.Count - 1, 2) = objOverride.ErrMsg
                                    lblFailed.Text = CInt(lblFailed.Text) + 1
                                End If
                            ElseIf IsRedemption(trxType) Then
                                If trxFee > 0 Then trxFee = trxFee / trxAmount
                                objOverride.redemption(objPortfolio, objClientKYC.GetMasterClient, CDate(lblAsOf.Text), trxAmount, trxFee)
                                If objOverride.ErrID = 0 Then
                                    fgTransaction(fgTransaction.Rows.Count - 1, 1) = "DONE"
                                    fgTransaction(fgTransaction.Rows.Count - 1, 2) = ""
                                    lblSucced.Text = CInt(lblSucced.Text) + 1
                                    lblRedemptionAccount.Text = CInt(lblRedemptionAccount.Text) + 1
                                    lblRedemptionAmount.Text = (CDbl(lblRedemptionAmount.Text) + trxAmount).ToString("n0")
                                Else
                                    fgTransaction(fgTransaction.Rows.Count - 1, 1) = "ERROR"
                                    fgTransaction(fgTransaction.Rows.Count - 1, 2) = objOverride.ErrMsg
                                    lblFailed.Text = CInt(lblFailed.Text) + 1
                                End If
                            Else
                                fgTransaction(fgTransaction.Rows.Count - 1, 1) = "ERROR"
                                fgTransaction(fgTransaction.Rows.Count - 1, 2) = objOverride.ErrMsg
                                lblFailed.Text = CInt(lblFailed.Text) + 1
                            End If

                        Else
                            fgTransaction(fgTransaction.Rows.Count - 1, 1) = "ERROR"
                            fgTransaction(fgTransaction.Rows.Count - 1, 2) = objClientKYC.ErrMsg
                            lblFailed.Text = CInt(lblFailed.Text) + 1
                        End If
                    End If
                Else
                    fgTransaction(fgTransaction.Rows.Count - 1, 1) = "ERROR"
                    fgTransaction(fgTransaction.Rows.Count - 1, 2) = objPortfolio.ErrMsg
                    lblFailed.Text = CInt(lblFailed.Text) + 1
                End If
                If pbNAV.Value = 1 Then pbNAV.Value = 100 Else pbNAV.Value -= 1
            Next
            pbNAV.Value = 0
            fgTransaction.AutoSizeCols()
        End If
    End Sub

#End Region

End Class