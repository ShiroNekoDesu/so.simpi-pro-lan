Imports System.IO
Imports Microsoft.Office.Interop
Imports simpi.GlobalUtilities
Imports simpi.globalutilities.GlobalDate
Imports simpi.CoreData
Imports simpi.CoreOverride
Imports simpi.MasterSecurities
Imports simpi.ParameterSecurities
Imports simpi.MasterPortfolio
Imports simpi.MarketInstrument
Imports C1.Win.C1FlexGrid

Public Class FormEODOverrideSecurities2
    Dim objPortfolio As New MasterPortfolio
    Dim objSecurities As New MarketInstrument
    Dim objBond As New MarketInstrumentBond
    Dim objMTM As New PortfolioMTM
    Dim objPosition As New PositionSecurities
    Dim objOverride As New OverrideSecurities
    Dim fundCode As String = ""
    Dim iSecurities As Integer = 1
    Dim isID As Boolean = False
    Dim dtPosition As New DataTable
    Dim no As Integer = 0

    Private Sub FormOverrideSecurities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        GetParameterInstrumentType()
        GetComboInit(New ParameterExternalSystem, cmbExternalPortfolio, "SystemID", "SystemCode")
        GetComboInit(New ParameterExternalSystem, cmbExternalSecurities, "SystemID", "SystemCode")
        GetComboInitAll(New ParameterInstrumentType, cmbType, "TypeID", "TypeCode")
        objPortfolio.UserAccess = objAccess
        objSecurities.UserAccess = objAccess
        objBond.UserAccess = objAccess
        objPosition.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        fgManual.DrawMode = DrawModeEnum.OwnerDraw

    End Sub

#Region "file scb"
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
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchSecurities.Enabled = False
        btnProfile.Enabled = False
        btnAdd.Enabled = False
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
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchSecurities.Enabled = True
        btnProfile.Enabled = True
        btnAdd.Enabled = True
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
                initPortfolio()
                initSecurities()
                isID = False
                pbExcel.Value = 0
                inR = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                While Not inR Is Nothing
                    If inR.ToString.Trim = "" Then Exit While
                    fgExcel.Rows.Add()
                    fgExcel(fgExcel.Rows.Count - 1, 0) = fgExcel.Rows.Count - 1
                    For i = 0 To colNo
                        inC = .Range(.Cells(rowStart, colStart + i), .Cells(rowStart, colStart + i)).Value
                        If Not inC Is Nothing Then fgExcel(fgExcel.Rows.Count - 1, i + 1) = inC
                    Next
                    If fundCode.Trim.ToUpper = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value.ToString.Trim.ToUpper Then
                        iSecurities += 1
                    Else
                        If fundCode = "" Then
                            fundCode = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                            fgPortfolio.Rows.Add()
                            fgPortfolio(fgPortfolio.Rows.Count - 1, 0) = fgPortfolio.Rows.Count - 1
                            fgPortfolio(fgPortfolio.Rows.Count - 1, 1) = fundCode
                        Else
                            fgPortfolio(fgPortfolio.Rows.Count - 1, 4) = iSecurities
                            iSecurities = 1
                            lblPortfolio.Text = fgPortfolio.Rows.Count - 1

                            fundCode = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                            fgPortfolio.Rows.Add()
                            fgPortfolio(fgPortfolio.Rows.Count - 1, 0) = fgPortfolio.Rows.Count - 1
                            fgPortfolio(fgPortfolio.Rows.Count - 1, 1) = fundCode
                        End If
                    End If
                    rowStart += 1
                    inR = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                    If pbExcel.Value = 100 Then pbExcel.Value = 0 Else pbExcel.Value += 1
                    lblRows.Text = fgExcel.Rows.Count - 1
                End While
                fgPortfolio(fgPortfolio.Rows.Count - 1, 4) = iSecurities
                lblPortfolio.Text = fgPortfolio.Rows.Count - 1
                pbExcel.Value = 100
                If fgExcel.Rows.Count > 0 Then lblDate.Text = ConvertToDate(fgExcel(fgExcel.Rows.Count - 1, 2), "YMD").ToString("dd-MMM-yyyy")
                lblRows.Text = fgExcel.Rows.Count - 1
                fgExcel.AutoSizeCols()
                fgPortfolio.AutoSizeCols()
                isID = True
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
            .Cols.Count = 9
            .ExtendLastCol = False
            fgExcel(0, 0) = "No"
            fgExcel(0, 1) = "Fund Code"
            fgExcel(0, 2) = "Date"
            fgExcel(0, 3) = "Code"
            fgExcel(0, 4) = "Name"
            fgExcel(0, 5) = "ISIN"
            fgExcel(0, 6) = "Qty"
            fgExcel(0, 7) = "Price"
            fgExcel(0, 8) = "Accrued"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub initPortfolio()
        With fgPortfolio
            .Rows.Count = 1
            .Cols.Count = 5
            .ExtendLastCol = False
            fgPortfolio(0, 0) = "No"
            fgPortfolio(0, 1) = "Fund Code"
            fgPortfolio(0, 2) = "Code"
            fgPortfolio(0, 3) = "Name"
            fgPortfolio(0, 4) = "Number of securities"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub initSecurities()
        With fgSecurities
            .Rows.Count = 1
            .Cols.Count = 9
            .ExtendLastCol = False
            fgSecurities(0, 0) = "No"
            fgSecurities(0, 1) = "Fund"
            fgSecurities(0, 2) = "Msg"
            fgSecurities(0, 3) = "Code"
            fgSecurities(0, 4) = "Name"
            fgSecurities(0, 5) = "ISIN"
            fgSecurities(0, 6) = "Qty"
            fgSecurities(0, 7) = "Price"
            fgSecurities(0, 8) = "Accrued"
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
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchSecurities.Enabled = False
        btnProfile.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        bwID.RunWorkerAsync()
    End Sub

    Private Sub bwID_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwID.DoWork
        PortfolioID()
    End Sub

    Private Sub bwID_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwID.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchSecurities.Enabled = True
        btnProfile.Enabled = True
        btnAdd.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub PortfolioID()
        With fgPortfolio
            If .Rows.Count > 0 And cmbExternalPortfolio.SelectedIndex <> -1 And isID Then
                pbData.Value = 0
                For i = 1 To .Rows.Count - 1
                    objPortfolio.Clear()
                    objPortfolio.ExternalID_Load(objMasterSimpi, cmbExternalPortfolio.SelectedValue, fgPortfolio(i, 1))
                    If objPortfolio.ErrID = 0 Then
                        fgPortfolio(i, 2) = objPortfolio.GetPortfolioCode
                        fgPortfolio(i, 3) = objPortfolio.GetPortfolioNameShort
                    Else
                        fgPortfolio(i, 2) = "ERROR"
                        fgPortfolio(i, 3) = objPortfolio.ErrMsg
                    End If
                    If pbData.Value = 100 Then pbData.Value = 0 Else pbData.Value += 1
                Next
                pbData.Value = 100
                .AutoSizeCols()
            End If
        End With
    End Sub

    Private Sub fgPortfolio_DoubleClick(sender As Object, e As EventArgs) Handles fgPortfolio.DoubleClick
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        txtFilename.Enabled = False
        cmbExternalPortfolio.Enabled = False
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchSecurities.Enabled = False
        btnProfile.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        bwRead.RunWorkerAsync()
    End Sub

    Private Sub bwRead_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwRead.DoWork
        SecuritiesSelect()
    End Sub

    Private Sub bwRead_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwRead.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchSecurities.Enabled = True
        btnProfile.Enabled = True
        btnAdd.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub SecuritiesSelect()
        If fgPortfolio.Row > 0 Then
            If fgPortfolio(fgPortfolio.Row, 2) = "" Or fgPortfolio(fgPortfolio.Row, 2) = "ERROR" Then
                lblPortfolioCode.Text = ""
                lblPortfolioName.Text = ""
                initSecurities()
                pbData.Value = 0
                ExceptionMessage.Show(objError.Message(81) & " master portfolio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lblPortfolioCode.Text = fgPortfolio(fgPortfolio.Row, 2)
                lblPortfolioName.Text = fgPortfolio(fgPortfolio.Row, 3)
                initSecurities()
                pbData.Value = 0
                For i = 1 To fgExcel.Rows.Count - 1
                    If fgExcel(i, 1).ToString.Trim.ToUpper = fgPortfolio(fgPortfolio.Row, 1).ToString.Trim.ToUpper Then
                        fgSecurities.Rows.Add()
                        fgSecurities(fgSecurities.Rows.Count - 1, 0) = fgSecurities.Rows.Count - 1
                        fgSecurities(fgSecurities.Rows.Count - 1, 1) = fgExcel(i, 1)
                        fgSecurities(fgSecurities.Rows.Count - 1, 3) = fgExcel(i, 3)
                        fgSecurities(fgSecurities.Rows.Count - 1, 4) = fgExcel(i, 4)
                        fgSecurities(fgSecurities.Rows.Count - 1, 5) = fgExcel(i, 5)
                        fgSecurities(fgSecurities.Rows.Count - 1, 6) = fgExcel(i, 6)
                        fgSecurities(fgSecurities.Rows.Count - 1, 7) = fgExcel(i, 7)
                        fgSecurities(fgSecurities.Rows.Count - 1, 8) = fgExcel(i, 8)
                    End If
                    If pbData.Value = 100 Then pbData.Value = 0 Else pbData.Value += 1
                Next
                pbData.Value = 100
                fgSecurities.AutoSizeCols()
            End If
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        txtFilename.Enabled = False
        cmbExternalPortfolio.Enabled = False
        btnRun.Enabled = False
        btnSearchPortfolio.Enabled = False
        btnSearchSecurities.Enabled = False
        btnProfile.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        bwRun.RunWorkerAsync()
    End Sub

    Private Sub bwRun_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        SecuritiesSave()
    End Sub

    Private Sub bwRun_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        txtFilename.Enabled = True
        cmbExternalPortfolio.Enabled = True
        btnRun.Enabled = True
        btnSearchPortfolio.Enabled = True
        btnSearchSecurities.Enabled = True
        btnProfile.Enabled = True
        btnAdd.Enabled = True
        btnRemove.Enabled = True
    End Sub

    Private Sub SecuritiesSave()
        If lblPortfolioCode.Text.Trim <> "" And fgSecurities.Rows.Count > 1 Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblPortfolioCode.Text)
            If objPortfolio.ErrID = 0 Then
                pbData.Value = 0
                lblRecords.Text = "0"
                lblFailed.Text = "0"
                For i = 1 To fgSecurities.Rows.Count - 1
                    objOverride.Clear()
                    objOverride.override(objPortfolio, cmbExternalSecurities.SelectedValue, fgSecurities(i, 5),
                                         fgSecurities(i, 6), fgSecurities(i, 7), fgSecurities(i, 8))
                    If objOverride.ErrID = 0 Then
                        fgSecurities(i, 1) = ""
                        fgSecurities(i, 2) = ""
                    Else
                        fgSecurities(i, 1) = "ERROR"
                        fgSecurities(i, 2) = objOverride.ErrMsg
                        lblFailed.Text = CInt(lblFailed.Text) + 1
                    End If
                    If pbData.Value = 100 Then pbData.Value = 0 Else pbData.Value += 1
                    lblRecords.Text = CInt(lblRecords.Text) + 1
                Next
                pbData.Value = 100
                fgSecurities.AutoSizeCols()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "manual"
    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectSimpiPortfolioNormal
        form.lblCode = lblPortfolioCodeManual
        form.lblName = lblPortfolioNameManual
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCodeManual.Text = ""
        lblPortfolioNameManual.Text = ""
        objPortfolio.Clear()
        SecuritiesClear()
    End Sub

    Private Sub SecuritiesClear()
        lblSecuritiesCode.Text = ""
        lblSecuritiesName.Text = ""
        lblType.Text = ""
        txtQty.Text = ""
        txtPrice.Text = ""
        txtCost.Text = ""
        txtAccruedCoupon.Text = ""
        lblMarketValue.Text = ""
        lblTotalValue.Text = ""
        lblTTM.Text = ""
        lblYTM.Text = ""
        lblYieldEffective.Text = ""
        lblModifiedDuration.Text = ""
    End Sub

    Private Sub lblPortfolioNameManual_TextChanged(sender As Object, e As EventArgs) Handles lblPortfolioNameManual.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCodeManual.Text.Trim <> "" Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblPortfolioCodeManual.Text)
            If objPortfolio.ErrID = 0 Then
                objMTM.Clear()
                objMTM.LoadEnd(objPortfolio)
                dtAs.Value = objMTM.GetNextDate
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        DataSecurities()
    End Sub

    Private Sub DataSecurities()
        If objPortfolio.GetPortfolioID > 0 Then
            GetInstrumentUserUpdate()
            objPosition.Clear()
            dtPosition = objPosition.Search(objPortfolio, dtAs.Value)
            DisplaySecurities()
            SecuritiesClear()
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.SelectedIndex <> -1 AndAlso dtPosition IsNot Nothing AndAlso dtPosition.Rows.Count > 1 Then DisplaySecurities()
    End Sub

    Private Sub initManual()
        With fgManual
            .Rows.Count = 1
            .Cols.Count = 13
            .ExtendLastCol = False
            fgManual(0, 0) = "No"
            fgManual(0, 1) = "ID"
            fgManual(0, 2) = "Code"
            fgManual(0, 3) = "Name"
            fgManual(0, 4) = "Type"
            fgManual(0, 5) = "Qty"
            fgManual(0, 6) = "Price"
            fgManual(0, 7) = "Cost"
            fgManual(0, 8) = "Value"
            fgManual(0, 9) = "Accrued"
            fgManual(0, 10) = "Total"
            fgManual(0, 11) = "TypeID"
            fgManual(0, 12) = "CompanyID"
            .AllowResizing = AllowResizingEnum.Columns
            .SelectionMode = SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Function _no() As Integer
        no += 1
        Return no
    End Function

    Private Sub DisplaySecurities()
        initManual()
        If dtPosition IsNot Nothing AndAlso dtPosition.Rows.Count > 0 Then
            Dim query = From p In dtPosition.AsEnumerable
                        Join i In dtInstrumentUser.AsEnumerable
                               On p.Field(Of Long)("SecuritiesID") Equals i.Field(Of Long)("SecuritiesID")
                        Join t In dtParameterInstrumentType.AsEnumerable
                               On t.Field(Of Integer)("TypeID") Equals i.Field(Of Integer)("TypeID")
                        Select _no(), ID = p.Field(Of Long)("SecuritiesID"),
                               Code = i.Field(Of String)("SecuritiesCode"),
                               Name = i.Field(Of String)("SecuritiesNameFull"),
                               Type = t.Field(Of String)("TypeCode"),
                               TypeID = i.Field(Of Integer)("TypeID"),
                               CompanyID = i.Field(Of Integer)("CompanyID"),
                               Qty = p.Field(Of Decimal)("Qty"),
                               Price = p.Field(Of Decimal)("MarketPrice"),
                               Cost = p.Field(Of Decimal)("CostPrice"),
                               Value = p.Field(Of Decimal)("MarketValue"),
                               Accrued = p.Field(Of Decimal)("AccruedInterest"),
                               Total = p.Field(Of Decimal)("TotalValue")

            For Each item In query
                fgManual.Rows.Add()
                fgManual(fgManual.Rows.Count - 1, 0) = item._no
                fgManual(fgManual.Rows.Count - 1, 1) = item.ID
                fgManual(fgManual.Rows.Count - 1, 2) = item.Code
                fgManual(fgManual.Rows.Count - 1, 3) = item.Name
                fgManual(fgManual.Rows.Count - 1, 4) = item.Type
                fgManual(fgManual.Rows.Count - 1, 5) = item.Qty.ToString("n2")
                fgManual(fgManual.Rows.Count - 1, 6) = item.Price.ToString("n4")
                fgManual(fgManual.Rows.Count - 1, 7) = item.Cost.ToString("n4")
                fgManual(fgManual.Rows.Count - 1, 8) = item.Value.ToString("n2")
                fgManual(fgManual.Rows.Count - 1, 9) = item.Accrued.ToString("n2")
                fgManual(fgManual.Rows.Count - 1, 10) = item.Total.ToString("n2")
                fgManual(fgManual.Rows.Count - 1, 11) = item.TypeID
                fgManual(fgManual.Rows.Count - 1, 12) = item.CompanyID
            Next

            fgManual.AutoSizeCols()

        End If
    End Sub

    Private Sub fgPrice_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgManual.OwnerDrawCell
        Dim s As CellStyle = fgManual.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgManual.Rows(e.Row).Style = fgManual.Styles("RowStyle")
    End Sub

    Private Sub fgManual_DoubleClick(sender As Object, e As EventArgs) Handles fgManual.DoubleClick
        With fgManual
            If .Rows.Count > 1 AndAlso .Row > 0 Then
                lblSecuritiesCode.Text = fgManual(.Row, 2)
                lblTypeID.Text = fgManual(.Row, 11)
                lblCompanyID.Text = fgManual(.Row, 12)
                lblSecuritiesName.Text = fgManual(.Row, 3)
                txtQty.Text = fgManual(.Row, 5)
                txtPrice.Text = fgManual(.Row, 6)
                txtCost.Text = fgManual(.Row, 7)
                txtAccruedCoupon.Text = fgManual(.Row, 9)
            End If
        End With
    End Sub

    Private Sub btnSearchSecurities_Click(sender As Object, e As EventArgs) Handles btnSearchSecurities.Click
        SecuritiesSearch()
    End Sub

    Private Sub SecuritiesSearch()
        Dim form As New FormSelectSecurities
        form.lblCode = lblSecuritiesCode
        form.lblName = lblSecuritiesName
        form.lblType = lblType
        form.lblTypeID = lblTypeID
        form.lblCompany = lblCompany
        form.lblCompanyID = lblCompanyID
        form.Show()
        form.MdiParent = MDISO
        lblSecuritiesCode.Text = ""
        lblSecuritiesName.Text = ""
        lblType.Text = ""
        lblTypeID.Text = ""
        lblCompany.Text = ""
        lblCompanyID.Text = ""
        objSecurities.Clear()
        objBond.Clear()
        SecuritiesClear()
    End Sub

    Private Sub lblSecuritiesName_TextChanged(sender As Object, e As EventArgs) Handles lblSecuritiesName.TextChanged
        Securitiesload()
    End Sub

    Private Sub Securitiesload()
        If lblSecuritiesName.Text.Trim <> "" Then
            objSecurities.Clear()
            objSecurities.Load3(lblCompanyID.Text, lblTypeID.Text, lblSecuritiesCode.Text)
            If objSecurities.ErrID = 0 Then
                If objSecurities.IsFI Then
                    txtAccruedCoupon.ReadOnly = False
                    objBond.Clear()
                    objBond.Load2(lblCompanyID.Text, lblSecuritiesCode.Text)
                    If objBond.ErrID = 0 Then _ttm() Else ExceptionMessage.Show(objBond.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    txtAccruedCoupon.ReadOnly = True
                End If
            Else
                ExceptionMessage.Show(objSecurities.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        _marketvalue()
        _totalvalue()
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        _marketvalue()
        _totalvalue()
        _ytm()
        _yieldeffective()
        _mduration()
    End Sub

    Private Sub txtAccruedCoupon_TextChanged(sender As Object, e As EventArgs) Handles txtAccruedCoupon.TextChanged
        _totalvalue()
    End Sub

    Private Sub _marketvalue()
        If IsNumeric(txtQty.Text) And IsNumeric(txtPrice.Text) Then
            If objSecurities.IsFI Then
                lblMarketValue.Text = (CDbl(txtQty.Text) * CDbl(txtPrice.Text) / 100).ToString("n2")
                txtAccruedCoupon.Text = objBond.Coupon_Acrrued(CDbl(txtQty.Text), dtAs.Value).ToString("n2")
            Else
                lblMarketValue.Text = (CDbl(txtQty.Text) * CDbl(txtPrice.Text)).ToString("n2")
            End If
        Else
            lblMarketValue.Text = ""
        End If
    End Sub

    Private Sub _totalvalue()
        If IsNumeric(lblMarketValue.Text) Then
            lblTotalValue.Text = lblMarketValue.Text
        End If
        If IsNumeric(txtAccruedCoupon.Text) Then
            lblTotalValue.Text = (CDbl(lblTotalValue.Text) + CDbl(txtAccruedCoupon.Text)).ToString("n2")
        End If
    End Sub

    Private Sub _ttm()
        If objSecurities.IsFI Then
            lblTTM.Text = (CalculateDays(dtAs.Value, objBond.GetDateMaturity, "A") / BaseDays("A", dtAs.Value)).ToString("n3")
        Else
            lblTTM.Text = ""
        End If
    End Sub

    Private Sub _ytm()
        If objSecurities.IsFI And IsNumeric(txtPrice.Text) Then
            lblYTM.Text = objBond.Yield_YTM(CDbl(txtPrice.Text) / 100, dtAs.Value).ToString("p5")
        Else
            lblYTM.Text = ""
        End If
    End Sub

    Private Sub _yieldeffective()
        If objSecurities.IsFI And IsNumeric(txtPrice.Text) Then
            lblYieldEffective.Text = objBond.Yield_Current(CDbl(txtPrice.Text) / 100).ToString("p5")
        Else
            lblYieldEffective.Text = ""
        End If
    End Sub

    Private Sub _mduration()
        If objSecurities.IsFI And IsNumeric(txtPrice.Text) Then
            lblModifiedDuration.Text = objBond.Duration_Modified(CDbl(txtPrice.Text) / 100, dtAs.Value).ToString("p5")
        Else
            lblModifiedDuration.Text = ""
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If objPortfolio.GetPortfolioID > 0 And objSecurities.GetSecuritiesID > 0 Then
            If Not IsNumeric(txtQty.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            If Not IsNumeric(txtPrice.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If txtAccruedCoupon.Text.Trim = "" Then
                txtAccruedCoupon.Text = "0"
            ElseIf Not IsNumeric(txtAccruedCoupon.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities coupon accrued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            objOverride.Clear()
            objOverride.override(objPortfolio, objSecurities, CDbl(txtQty.Text), CDbl(txtPrice.Text), CDbl(txtAccruedCoupon.Text))
            If objOverride.ErrID = 0 Then
                DataSecurities()
            Else
                ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        DataRemove()
    End Sub

    Private Sub DataRemove()
        If objPortfolio.GetPortfolioID > 0 And objSecurities.GetSecuritiesID > 0 Then
            objOverride.Clear()
            objOverride.override_remove(objPortfolio, objSecurities)
            If objOverride.ErrID = 0 Then DataSecurities() Else ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub fgExcel_Click(sender As Object, e As EventArgs) Handles fgExcel.Click

    End Sub

    Private Sub pbExcel_Click(sender As Object, e As EventArgs) Handles pbExcel.Click

    End Sub

    Private Sub C1InputPanel1_Click(sender As Object, e As EventArgs) Handles C1InputPanel1.Click

    End Sub

#End Region

End Class