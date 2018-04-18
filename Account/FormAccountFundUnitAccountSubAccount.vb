Imports System.IO
Imports simpi.globalutilities
Imports simpi.MasterClient
Imports simpi.MasterSales
Imports simpi.globalutilities.GlobalString

Public Class FormAccountFundUnitAccountSubAccount
    Dim objClientKYC As New ClientKYC

    Dim objSales As New MasterSales
    Dim objClient As New MasterClient

    Dim objDistributor As New MasterClient
    Dim objDistributorIndividu As New MasterClientIndividu
    Dim objDistributorIndividuSub As New MasterClientIndividuSub
    Dim objDistributorInstitution As New MasterClientInstitution
    Dim objDistributorInstitutionSub As New MasterClientInstitutionSub

    Dim SID, saCode, ClientName, ClientCode, fundAccount As String

    Private Sub FormFundUnitAccountSubAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        lblSalesInternal.Text = objMasterSimpi.GetCodeset(8)

        objClientKYC.UserAccess = objAccess

        objClient.UserAccess = objAccess
        objSales.UserAccess = objAccess

        objDistributor.UserAccess = objAccess
        objDistributorIndividu.UserAccess = objAccess
        objDistributorIndividuSub.UserAccess = objAccess
        objDistributorInstitution.UserAccess = objAccess
        objDistributorInstitutionSub.UserAccess = objAccess
    End Sub

    Private Sub setButton(ByVal buttonState As Boolean)
        btnBrowse.Enabled = buttonState
        btnRead.Enabled = buttonState
        txtFilename.Enabled = buttonState
        btnProcess.Enabled = buttonState
        btnCopyDirect.Enabled = buttonState
        btnCopyDistributor.Enabled = buttonState
        btnUpdate.Enabled = buttonState
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
            fgExcel.AutoSizeCols()
            getClient()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        getClient()
    End Sub

    Private Sub getClient()
        Cursor = Cursors.WaitCursor
        GetClientKYCUpdate()
        GetSalesCodeset()
        lblClientKYC.Text = (From r In dtClientKYC.AsEnumerable
                             Select r.Field(Of Integer)("ClientID")).Count
        lblClientNo.Text = (From r In dtClientKYC.AsEnumerable
                            Select r.Field(Of Integer)("ClientID")).Distinct.Count
        Cursor = Cursors.Default
    End Sub

#End Region

#Region "process"
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        setButton(False)
        bwProcess.RunWorkerAsync()
    End Sub

    Private Sub bwProcess_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwProcess.DoWork
        initDirect()
        initDistributor()
        DataProcess()
    End Sub

    Private Sub bwProcess_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwProcess.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Sub initDirect()
        With fgDirect
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDirect(0, 0) = "No"
            fgDirect(0, 1) = "S"
            fgDirect(0, 2) = "Error Msg"
            fgDirect(0, 3) = "ID"
            fgDirect(0, 4) = "CIF"
            fgDirect(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
        With fgDirectNotFound
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDirectNotFound(0, 0) = "No"
            fgDirectNotFound(0, 1) = "S"
            fgDirectNotFound(0, 2) = "Error Msg"
            fgDirectNotFound(0, 3) = "ID"
            fgDirectNotFound(0, 4) = "CIF"
            fgDirectNotFound(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub initDistributor()
        With fgDistributor
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDistributor(0, 0) = "No"
            fgDistributor(0, 1) = "S"
            fgDistributor(0, 2) = "Error Msg"
            fgDistributor(0, 3) = "ID"
            fgDistributor(0, 4) = "CIF"
            fgDistributor(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
        With fgDistributorNotFound
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDistributorNotFound(0, 0) = "No"
            fgDistributorNotFound(0, 1) = "S"
            fgDistributorNotFound(0, 2) = "Error Msg"
            fgDistributorNotFound(0, 3) = "ID"
            fgDistributorNotFound(0, 4) = "CIF"
            fgDistributorNotFound(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub DataProcess()
        With fgExcel
            If .Rows.Count > 1 And lblKYCID.Text <> "" And lblFundAccountID.Text <> "" And lblSACodesetID.Text <> "" And lblSalesInternal.Text <> "" Then
                Dim rowKYC(), rowFundAccount(), rowSales() As DataRow
                pbNAV.Value = 100
                lblDirectRows.Text = "0"
                lblDirectNotFound.Text = "0"
                lblDirectFound.Text = "0"
                lblDistributorRow.Text = "0"
                lblDistributorNotFound.Text = "0"
                lblDistributorFound.Text = "0"
                lblDistributorSubAccount.Text = "0"
                For i = 1 To .Rows.Count - 1
                    ClientName = ""
                    If Not IsNothing(fgExcel(i, 3)) Then If fgExcel(i, 3).ToString.Trim <> "" Then ClientName = fgExcel(i, 3).ToString.Trim
                    saCode = ""
                    If Not IsNothing(fgExcel(i, 12)) Then If fgExcel(i, 12).ToString.Trim <> "" Then saCode = fgExcel(i, 12).ToString.Trim
                    SID = ""
                    If Not IsNothing(fgExcel(i, 4)) Then If fgExcel(i, 4).ToString.Trim <> "" Then SID = fgExcel(i, 4).ToString.Trim
                    rowKYC = dtClientKYC.Select("kycAnswer = '" & SQLFix(SID) & "' And kycID = " & Str(CInt(lblKYCID.Text)))
                    If rowKYC.Length = 0 Then
                        If saCode = lblSalesInternal.Text.Trim Then
                            fgDirectNotFound.Rows.Add()
                            fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 0) = fgDirectNotFound.Rows.Count - 1
                            fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 1) = "NOT FOUND"
                            fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 2) = "SID"
                            fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 3) = SID
                            fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 5) = ClientName
                            lblDirectRows.Text = CInt(lblDirectRows.Text) + 1
                            lblDirectNotFound.Text = CInt(lblDirectNotFound.Text) + 1
                        Else
                            fgDistributorNotFound.Rows.Add()
                            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 0) = fgDistributorNotFound.Rows.Count - 1
                            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 1) = "NOT FOUND"
                            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 2) = "SID"
                            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 3) = SID
                            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 5) = ClientName
                            lblDistributorRow.Text = CInt(lblDistributorRow.Text) + 1
                            lblDistributorNotFound.Text = CInt(lblDistributorNotFound.Text) + 1
                        End If
                    Else
                        fundAccount = ""
                        If Not IsNothing(fgExcel(i, 2)) Then If fgExcel(i, 2).ToString.Trim <> "" Then fundAccount = fgExcel(i, 2).ToString.Trim
                        rowFundAccount = dtClientKYC.Select("kycAnswer = '" & SQLFix(fundAccount) & "' And kycID = " & Str(CInt(lblFundAccountID.Text)))
                        If rowFundAccount.Length = 0 Then
                            If saCode = lblSalesInternal.Text.Trim Then
                                fgDirectNotFound.Rows.Add()
                                fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 0) = fgDirectNotFound.Rows.Count - 1
                                fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 1) = "NOT EXISTS"
                                fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 2) = "FUND ACCOUNT"
                                fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 3) = fundAccount
                                fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 4) = ""
                                fgDirectNotFound(fgDirectNotFound.Rows.Count - 1, 5) = ClientName
                                lblDirectRows.Text = CInt(lblDirectRows.Text) + 1
                                lblDirectNotFound.Text = CInt(lblDirectNotFound.Text) + 1
                            Else
                                rowSales = dtSalesCodeset.Select("FieldData = '" & SQLFix(saCode) & "' And FieldID = " & Str(CInt(lblSACodesetID.Text)))
                                If rowSales.Length = 0 Then
                                    fgDistributorNotFound.Rows.Add()
                                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 0) = fgDistributorNotFound.Rows.Count - 1
                                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 1) = "DISTRIBUTOR"
                                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 2) = objClient.ErrMsg
                                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 3) = fundAccount
                                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 4) = ""
                                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 5) = ClientName
                                    lblDistributorNotFound.Text = CInt(lblDistributorNotFound.Text) + 1
                                Else
                                    _distributor(i, rowSales(0)("SalesCode"))
                                End If
                                lblDistributorRow.Text = CInt(lblDistributorRow.Text) + 1
                            End If
                        Else
                            If saCode = lblSalesInternal.Text.Trim Then
                                fgDirect.Rows.Add()
                                fgDirect(fgDirect.Rows.Count - 1, 0) = fgDirect.Rows.Count - 1
                                fgDirect(fgDirect.Rows.Count - 1, 1) = "EXISTS"
                                fgDirect(fgDirect.Rows.Count - 1, 2) = "FUND ACCOUNT"
                                fgDirect(fgDirect.Rows.Count - 1, 3) = fundAccount
                                fgDirect(fgDirect.Rows.Count - 1, 4) = rowFundAccount(0)("ClientCode")
                                fgDirect(fgDirect.Rows.Count - 1, 5) = ClientName
                                lblDirectRows.Text = CInt(lblDirectRows.Text) + 1
                                lblDirectFound.Text = CInt(lblDirectFound.Text) + 1
                            Else
                                fgDistributor.Rows.Add()
                                fgDistributor(fgDistributor.Rows.Count - 1, 0) = fgDistributor.Rows.Count - 1
                                fgDistributor(fgDistributor.Rows.Count - 1, 1) = "EXISTS"
                                fgDistributor(fgDistributor.Rows.Count - 1, 2) = "FUND ACCOUNT"
                                fgDistributor(fgDistributor.Rows.Count - 1, 3) = fundAccount
                                fgDistributor(fgDistributor.Rows.Count - 1, 4) = rowFundAccount(0)("ClientCode")
                                fgDistributor(fgDistributor.Rows.Count - 1, 5) = rowFundAccount(0)("ClientName")
                                lblDistributorRow.Text = CInt(lblDistributorRow.Text) + 1
                                lblDistributorFound.Text = CInt(lblDistributorFound.Text) + 1
                            End If
                        End If
                    End If

                    If pbNAV.Value = 1 Then pbNAV.Value = 100 Else pbNAV.Value -= 1
                Next
                fgDirect.AutoSizeCols()
                fgDirectNotFound.AutoSizeCols()
                fgDistributor.AutoSizeCols()
                fgDistributorNotFound.AutoSizeCols()
                pbNAV.Value = 0
            End If
        End With
    End Sub

    Private Sub _distributor(ByVal iRow As Integer, ByVal SalesCode As String)
        objSales.Clear()
        objSales.Load(objMasterSimpi, SalesCode)
        objClient.Clear()
        objClient.LoadDistributor(objMasterSimpi, objSales, CInt(lblKYCID.Text), SID)
        If objClient.ErrID = 0 Then
            If objClient.GetClientName.Trim.ToUpper = ClientName.Trim.ToUpper Then
                objClientKYC.Add(objClient, CInt(lblFundAccountID.Text), fundAccount) 'Fund Account
                fgDistributor.Rows.Add()
                fgDistributor(fgDistributor.Rows.Count - 1, 0) = fgDistributor.Rows.Count - 1
                fgDistributor(fgDistributor.Rows.Count - 1, 1) = "SET"
                fgDistributor(fgDistributor.Rows.Count - 1, 2) = "FUND ACCOUNT"
                fgDistributor(fgDistributor.Rows.Count - 1, 3) = fundAccount
                fgDistributor(fgDistributor.Rows.Count - 1, 4) = objClient.GetClientCode
                fgDistributor(fgDistributor.Rows.Count - 1, 5) = ClientName
                lblDistributorFound.Text = CInt(lblDistributorFound.Text) + 1
            Else
                objClient.Clear()
                objClient.LoadInternal(objMasterSimpi, CInt(lblKYCID.Text), SID)
                If objClient.IsIndividu Then
                    objDistributorIndividu.Clear()
                    objDistributorIndividu.Load(objMasterSimpi, objClient.GetClientCode)

                    objDistributorIndividuSub.Clear()
                    objDistributorIndividuSub.Add(objDistributorIndividu, objSales, ClientName, ClientName, "", "")
                    lblDistributorSubAccount.Text = CInt(lblDistributorSubAccount.Text) + 1

                    objDistributor.Clear()
                    objDistributor.Load(objMasterSimpi, objDistributorIndividuSub.GetClientCode)

                    objClientKYC.Add(objDistributor, CInt(lblKYCID.Text), SID) 'SID
                    objClientKYC.Add(objDistributor, CInt(lblFundAccountID.Text), fundAccount) 'Fund Account
                    fgDistributorNotFound.Rows.Add()
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 0) = fgDistributorNotFound.Rows.Count - 1
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 1) = "NEW"
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 2) = "SUB ACCOUNT"
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 3) = fundAccount
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 4) = objDistributor.GetClientCode
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 5) = ClientName
                ElseIf objClient.IsInstitution Then
                    objDistributorInstitution.Clear()
                    objDistributorInstitution.Load(objMasterSimpi, objClient.GetClientCode)

                    objDistributorInstitutionSub.Add(objDistributorInstitution, objSales, ClientName,
                                objDistributorInstitution.GetClientCcy.GetCountryID, objDistributorInstitution.GetClientXRate.GetXRateID,
                                objDistributorInstitution.GetLocalForeign, objDistributorInstitution.GetSignatureRule, objDistributorInstitution.GetTaxID,
                                objDistributorInstitution.GetBusinessType.GetTypeID, objDistributorInstitution.GetBusinessActivity.GetActivityID, ClientName, "")
                    lblDistributorSubAccount.Text = CInt(lblDistributorSubAccount.Text) + 1

                    objDistributor.Clear()
                    objDistributor.Load(objMasterSimpi, objDistributorInstitutionSub.GetClientCode)

                    objClientKYC.Add(objDistributor, CInt(lblKYCID.Text), SID) 'SID
                    objClientKYC.Add(objDistributor, CInt(lblFundAccountID.Text), fundAccount) 'Fund Account
                    fgDistributorNotFound.Rows.Add()
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 0) = fgDistributorNotFound.Rows.Count - 1
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 1) = "NEW"
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 2) = "SUB ACCOUNT"
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 3) = fundAccount
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 4) = objDistributor.GetClientCode
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 5) = ClientName
                End If
            End If
        Else
            fgDistributorNotFound.Rows.Add()
            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 0) = fgDistributorNotFound.Rows.Count - 1
            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 1) = "DISTRIBUTOR CLIENT"
            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 2) = objClient.ErrMsg
            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 3) = fundAccount
            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 4) = ""
            fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 5) = ClientName
            lblDistributorNotFound.Text = CInt(lblDistributorNotFound.Text) + 1
        End If
    End Sub

    Private Sub btnCopyDirect_Click(sender As Object, e As EventArgs) Handles btnCopyDirect.Click
        Dim myText As String = ""
        For i As Integer = fgDirectNotFound.Rows.Fixed To fgDirectNotFound.Rows.Count - 1
            For j As Integer = fgDirectNotFound.Cols.Fixed To fgDirectNotFound.Cols.Count - 1
                myText = myText & fgDirectNotFound(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Sub btnCopyDistributor_Click(sender As Object, e As EventArgs) Handles btnCopyDistributor.Click
        Dim myText As String = ""
        For i As Integer = fgDistributorNotFound.Rows.Fixed To fgDistributorNotFound.Rows.Count - 1
            For j As Integer = fgDistributorNotFound.Cols.Fixed To fgDistributorNotFound.Cols.Count - 1
                myText = myText & fgDistributorNotFound(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

#End Region

End Class