Imports System.IO
Imports Microsoft.Office.Interop
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalDate
Imports simpi.CoreData
Imports simpi.CoreOverride
Imports simpi.MasterSecurities
Imports simpi.MasterPortfolio
Imports simpi.MarketCompany

Public Class FormEODOverrideBank2
    Dim objPortfolio As New MasterPortfolio
    Dim objCompany As New MarketCompany
    Dim objMTM As New PortfolioMTM
    Dim objCash As New PositionBank 'PositionBankAccount
    Dim objTD As New PositionBank 'PositionBankDeposit
    Dim objOverride As New OverrideBank
    Dim isPortfolio, isBank As Boolean

    Private Sub FormOverrideSecurities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        GetComboInit(New ParameterExternalSystem, cmbExternalPortfolio, "SystemID", "SystemCode")
        GetComboInit(New ParameterExternalSystem, cmbExternalBank, "SystemID", "SystemCode")
        objPortfolio.UserAccess = objAccess
        objCompany.UserAccess = objAccess
        objCash.UserAccess = objAccess
        objTD.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objOverride.UserAccess = objAccess
    End Sub

#Region "file"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenExcel()
    End Sub

    Private Sub txtFilename_Click(sender As Object, e As EventArgs) Handles txtFilename.Click
        OpenExcel()
    End Sub

    Private Sub txtFilename_TextChanged(sender As Object, e As EventArgs) Handles txtFilename.TextChanged
        If txtFilename.Text <> "" Then btnRead.Enabled = True Else btnRead.Enabled = False
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

    Private Sub ResetField()
        lblRows.Text = ""
        lblFailed.Text = "0"
        lblDate.Text = ""
        lblRecords.Text = "0"
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ResetField()
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        txtFilename.Enabled = False
        cmbExternalPortfolio.Enabled = False
        cmbExternalBank.Enabled = False
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchBank.Enabled = False
        btnSearchPosition.Enabled = False
        btnSave.Enabled = False
        btnRemove.Enabled = False
        bwExcel.RunWorkerAsync()
    End Sub

    Private Sub bwExcel_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwExcel.DoWork
        ReadExcel()
    End Sub

    Private Sub bwExcel_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwExcel.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        cmbExternalBank.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchBank.Enabled = True
        btnSearchPosition.Enabled = True
        btnSave.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Function FileValidation() As Boolean
        If Trim(txtFilename.Text) = "" Then
            ExceptionMessage.Show(objError.Message(81) & " filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If Trim(txtSheet.Text) = "" Then
            ExceptionMessage.Show(objError.Message(81) & " sheet name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If Not IsNumeric(txtRowStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " start row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If Not IsNumeric(txtColStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " start col", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If Not IsNumeric(txtColNo.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " number of cols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub ReadExcel()
        Dim ObjExcelApp As Excel.Application
        Dim ObjExcelWorkBook As Excel.Workbook
        Dim ObjExcelWorkSheet As Excel.Worksheet
        Dim rowStart, colStart, colNo As Integer
        Dim inR, inC As String
        If Not FileValidation() Then Exit Sub
        Try
            ObjExcelApp = CType(CreateObject("Excel.Application"), Excel.Application)
            ObjExcelWorkBook = ObjExcelApp.Workbooks.Open(txtFilename.Text)
            ObjExcelWorkSheet = CType(ObjExcelWorkBook.Sheets(Trim(txtSheet.Text)), Excel.Worksheet)
            With ObjExcelWorkSheet
                rowStart = CInt(txtRowStart.Text)
                colStart = CInt(txtColStart.Text)
                colNo = CInt(txtColNo.Text)
                initExcel()
                initBank()
                isPortfolio = False
                isBank = False
                pbExcel.Value = 0
                inR = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                While Not inR Is Nothing
                    If inR.ToString.Trim = "" Then Exit While
                    fgExcel.Rows.Add()
                    fgExcel(fgExcel.Rows.Count - 1, 0) = fgExcel.Rows.Count - 1

                    fgBank.Rows.Add()
                    fgBank(fgBank.Rows.Count - 1, 0) = fgBank.Rows.Count - 1

                    For i = 0 To colNo
                        inC = .Range(.Cells(rowStart, colStart + i), .Cells(rowStart, colStart + i)).Value
                        If Not inC Is Nothing Then
                            fgExcel(fgExcel.Rows.Count - 1, i + 1) = inC

                            If i = 0 Then fgBank(fgBank.Rows.Count - 1, 1) = inC
                            If i = 2 Then fgBank(fgBank.Rows.Count - 1, 6) = inC
                            If i = 3 Then fgBank(fgBank.Rows.Count - 1, 9) = inC
                            If i = 4 Then fgBank(fgBank.Rows.Count - 1, 8) = inC
                            If i = 5 Then fgBank(fgBank.Rows.Count - 1, 10) = IIf(inC.Trim = "", "", ConvertToDate(inC.Trim, "YMD").ToString("dd-MMM-yyyy"))
                            If i = 6 Then fgBank(fgBank.Rows.Count - 1, 11) = IIf(inC.Trim = "", "", ConvertToDate(inC.Trim, "YMD").ToString("dd-MMM-yyyy"))
                            If i = 7 Then fgBank(fgBank.Rows.Count - 1, 12) = inC
                            If i = 8 Then fgBank(fgBank.Rows.Count - 1, 5) = _bank(inC)
                        End If
                    Next
                    rowStart += 1
                    inR = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                    If pbExcel.Value = 100 Then pbExcel.Value = 0 Else pbExcel.Value += 1
                    lblRows.Text = fgExcel.Rows.Count - 1
                    isPortfolio = True
                    isBank = True
                End While
                pbExcel.Value = 100
                If fgExcel.Rows.Count > 0 Then lblDate.Text = ConvertToDate(fgExcel(fgExcel.Rows.Count - 1, 2), "YMD").ToString("dd-MMM-yyyy")
                lblRows.Text = fgExcel.Rows.Count - 1
                lblRecords.Text = fgBank.Rows.Count - 1
                fgExcel.AutoSizeCols()
                fgBank.AutoSizeCols()
            End With
            ObjExcelWorkBook.Close()
            ObjExcelApp.Quit()
            releaseObject(ObjExcelApp)
            releaseObject(ObjExcelWorkBook)
            releaseObject(ObjExcelWorkSheet)
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function _bank(ByVal strBank As String) As String
        Dim str As String = strBank
        str = strBank.Replace("Time Deposit at ", "")
        str = str.Replace("Overnight at ", "")
        Return str
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub initExcel()
        With fgExcel
            .Rows.Count = 1
            .Cols.Count = 10
            .ExtendLastCol = False
            fgExcel(0, 0) = "No"
            fgExcel(0, 1) = "Fund Code"
            fgExcel(0, 2) = "Date"
            fgExcel(0, 3) = "Type"
            fgExcel(0, 4) = "Balance"
            fgExcel(0, 5) = "Account No"
            fgExcel(0, 6) = "Start Date"
            fgExcel(0, 7) = "End Date"
            fgExcel(0, 8) = "Rate"
            fgExcel(0, 9) = "Remarks"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub initBank()
        With fgBank
            .Rows.Count = 1
            .Cols.Count = 13
            .ExtendLastCol = False
            fgBank(0, 0) = "No"
            fgBank(0, 1) = "Fund"
            fgBank(0, 2) = "Msg"
            fgBank(0, 3) = "Code"
            fgBank(0, 4) = "Name"
            fgBank(0, 5) = "Bank"
            fgBank(0, 6) = "Type"
            fgBank(0, 7) = "Company"
            fgBank(0, 8) = "AccountNo"
            fgBank(0, 9) = "Balance"
            fgBank(0, 10) = "Start"
            fgBank(0, 11) = "End"
            fgBank(0, 12) = "Rate"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
            lblRecords.Text = "0"
            lblFailed.Text = "0"
        End With
    End Sub

    Private Sub cmbExternalPortfolio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExternalPortfolio.SelectedIndexChanged
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        txtFilename.Enabled = False
        cmbExternalPortfolio.Enabled = False
        cmbExternalBank.Enabled = False
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchBank.Enabled = False
        btnSearchPosition.Enabled = False
        btnSave.Enabled = False
        btnRemove.Enabled = False
        bwPortfolio.RunWorkerAsync()
    End Sub

    Private Sub bwPortfolio_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwPortfolio.DoWork
        PortfolioID()
    End Sub

    Private Sub bwPortfolio_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwPortfolio.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        cmbExternalBank.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchBank.Enabled = True
        btnSearchPosition.Enabled = True
        btnSave.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub PortfolioID()
        With fgBank
            If .Rows.Count > 0 And cmbExternalPortfolio.SelectedIndex <> -1 And isPortfolio Then
                pbData.Value = 0
                For i = 1 To .Rows.Count - 1
                    objPortfolio.Clear()
                    objPortfolio.ExternalID_Load(objMasterSimpi, cmbExternalPortfolio.SelectedValue, fgBank(i, 1))
                    If objPortfolio.ErrID = 0 Then
                        fgBank(i, 2) = ""
                        fgBank(i, 3) = objPortfolio.GetPortfolioCode
                        fgBank(i, 4) = objPortfolio.GetPortfolioNameShort
                    Else
                        fgBank(i, 2) = objPortfolio.ErrMsg
                        fgBank(i, 3) = "ERROR"
                        fgBank(i, 4) = ""
                    End If
                    If pbData.Value = 100 Then pbData.Value = 0 Else pbData.Value += 1
                Next
                pbData.Value = 100
                .AutoSizeCols()
            End If
        End With
    End Sub

    Private Sub cmbExternalBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExternalBank.SelectedIndexChanged
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        txtFilename.Enabled = False
        cmbExternalPortfolio.Enabled = False
        cmbExternalBank.Enabled = False
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchBank.Enabled = False
        btnSearchPosition.Enabled = False
        btnSave.Enabled = False
        btnRemove.Enabled = False
        bwBank.RunWorkerAsync()
    End Sub

    Private Sub bwBank_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwBank.DoWork
        BankID()
    End Sub

    Private Sub bwBank_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwBank.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        cmbExternalBank.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchBank.Enabled = True
        btnSearchPosition.Enabled = True
        btnSave.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub BankID()
        With fgBank
            If .Rows.Count > 0 And cmbExternalBank.SelectedIndex <> -1 And isBank Then
                pbData.Value = 0
                For i = 1 To .Rows.Count - 1
                    objCompany.Clear()
                    objCompany.ExternalID_LoadCompany(cmbExternalBank.SelectedValue, fgBank(i, 5))
                    If objCompany.ErrID = 0 Then
                        fgBank(i, 2) = ""
                        fgBank(i, 7) = objCompany.GetCompanyCode
                    Else
                        fgBank(i, 2) = objCompany.ErrMsg
                        fgBank(i, 7) = "ERROR"
                    End If
                    If pbData.Value = 100 Then pbData.Value = 0 Else pbData.Value += 1
                Next
                pbData.Value = 100
                .AutoSizeCols()
            End If
        End With
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        txtFilename.Enabled = False
        cmbExternalPortfolio.Enabled = False
        cmbExternalBank.Enabled = False
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchBank.Enabled = False
        btnSearchPosition.Enabled = False
        btnSave.Enabled = False
        btnRemove.Enabled = False
        bwRun.RunWorkerAsync()
    End Sub

    Private Sub bwRun_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        BankSave()
    End Sub

    Private Sub bwRun_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        cmbExternalBank.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchBank.Enabled = True
        btnSearchPosition.Enabled = True
        btnSave.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub BankSave()
        If txtKeywordCash.Text.Trim <> "" And txtKeywordTD.Text.Trim <> "" And fgBank.Rows.Count > 1 Then
            pbData.Value = 0
            lblRecords.Text = "0"
            lblFailed.Text = "0"
            For i = 1 To fgBank.Rows.Count - 1
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, fgBank(i, 3))
                If objPortfolio.ErrID = 0 Then
                    objOverride.Clear()
                    If fgBank(i, 6).ToString.Trim.ToString = txtKeywordCash.Text.Trim.ToUpper Then
                        objOverride.override_cash(objPortfolio, fgBank(i, 9), fgBank(i, 8).ToString.Trim & fgBank(i, 3).ToString.Trim,
                                                  cmbExternalBank.SelectedValue, fgBank(i, 5))
                    ElseIf fgBank(i, 6).ToString.Trim.ToString = txtKeywordTD.Text.Trim.ToUpper Then
                        objOverride.override_deposit(objPortfolio, fgBank(i, 9), fgBank(i, 8), fgBank(i, 10), fgBank(i, 11),
                                                     fgBank(i, 12), cmbExternalBank.SelectedValue, fgBank(i, 5))
                    End If
                    If objOverride.ErrID = 0 Then
                        fgBank(i, 1) = ""
                        fgBank(i, 2) = ""
                    Else
                        fgBank(i, 1) = "ERROR"
                        fgBank(i, 2) = objOverride.ErrMsg
                        lblFailed.Text = CInt(lblFailed.Text) + 1
                    End If
                Else
                    fgBank(i, 1) = "ERROR"
                    fgBank(i, 2) = objPortfolio.ErrMsg
                    lblFailed.Text = CInt(lblFailed.Text) + 1
                End If

                If pbData.Value = 100 Then pbData.Value = 0 Else pbData.Value += 1
                lblRecords.Text = CInt(lblRecords.Text) + 1
            Next
            pbData.Value = 100
            fgBank.AutoSizeCols()
        End If
    End Sub

#End Region

#Region "manual"
    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectSimpiPortfolioNormal
        form.lblCode = lblPortfolioCode
        form.lblName = lblPortfolioName
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        objPortfolio.Clear()
    End Sub

    Private Sub lblPortfolioName_TextChanged(sender As Object, e As EventArgs) Handles lblPortfolioName.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblPortfolioCode.Text)
            If objPortfolio.ErrID = 0 Then
                objMTM.Clear()
                objMTM.LoadEnd(objPortfolio)
                dtAs.Value = objMTM.GetNextDate
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearchPosition_Click(sender As Object, e As EventArgs) Handles btnSearchPosition.Click
        DisplayBank
    End Sub

    Private Sub DisplayBank()

    End Sub

#End Region

End Class