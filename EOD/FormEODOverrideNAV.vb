Imports C1.Win.C1TrueDBGrid
Imports System.IO
Imports Microsoft.Office.Interop
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalDate
Imports simpi.CoreData
Imports simpi.CoreOverride
Imports simpi.MasterSecurities
Imports simpi.MasterPortfolio
Imports simpi.MasterSimpi

Public Class FormEODOverrideNAV
    Dim objPortfolio As New MasterPortfolio
    Dim objSimpi As New MasterSimpi
    Dim objNAV As New PortfolioNAV
    Dim objBefore As New PortfolioNAV
    Dim objOverride As New OverrideNAV
    Dim objCodeset As New PortfolioCodeset
    Dim objMTM As New PortfolioMTM

    Dim nav, unit, price As Double
    Dim NAVUnit, Units, Equities, FI, Cash, TD, charges, othersAsset, aum As Double

    Private Sub csMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles csMenu.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Detach"
                MdiParent = Nothing
                e.ClickedItem.Text = "Attach"
            Case "Attach"
                e.ClickedItem.Text = "Detach"
                MdiParent = MDISO
            Case "Close"
                Close()
            Case "Export"
                PrintExcel(DBGFund)
        End Select
    End Sub

    Private Sub FormEODOverrideNAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        GetPortfolioMaster()
        GetComboInit(New ParameterExternalSystem, cmbExternal, "SystemID", "SystemCode")
        GetParameterPortfolioAssetType()
        GetParameterCountry()
        objPortfolio.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objBefore.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        objCodeset.UserAccess = objAccess
        dtAs.Value = Now
        DBGFund.FetchRowStyles = True
    End Sub

#Region "manual entry"
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        DisplayNAV
    End Sub

    Private Sub DisplayNAV()
        Dim dtNAV As New DataTable
        objNAV.Clear()
        dtNAV = objNAV.Search((From p In dtPortfolioMaster Select p.Field(Of Integer)("PortfolioID")).Distinct.ToArray, dtAs.Value)
        If dtNAV IsNot Nothing AndAlso dtNAV.Rows.Count > 0 Then
            Dim query = From d In dtNAV.AsEnumerable
                        Join p In dtPortfolioMaster.AsEnumerable
                               On d.Field(Of Integer)("PortfolioID") Equals p.Field(Of Integer)("PortfolioID")
                        Join a In dtParameterPortfolioAsset.AsEnumerable
                               On p.Field(Of Integer)("AssetTypeID") Equals a.Field(Of Integer)("AssetTypeID")
                        Join c In dtParameterCountry.AsEnumerable
                               On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                        Select ID = p.Field(Of Integer)("PortfolioID"),
                               simpiEmail = p.Field(Of String)("simpiEmail"),
                               Code = p.Field(Of String)("PortfolioCode"),
                               Name = p.Field(Of String)("PortfolioNameshort"),
                               AssetType = a.Field(Of String)("AssetTypeCode"),
                               Ccy = c.Field(Of String)("Ccy"),
                               NAV = d.Field(Of Decimal)("NAV"),
                               Price = d.Field(Of Decimal)("NAVperUnit"),
                               Unit = d.Field(Of Decimal)("TotalUnit")

            lblTotalNAV.Text = (From q In query Select q.NAV).Sum.ToString("n0")
            lblTotalUnit.Text = (From q In query Select q.Unit).Sum.ToString("n0")
            lblAveragePrice.Text = (From q In query Select q.Price).Average.ToString("n4")

            With DBGFund
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Unit").NumberFormat = "n4"
                .Columns("Price").NumberFormat = "n4"
                .Columns("NAV").NumberFormat = "n2"

                .Splits(0).DisplayColumns("ID").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Code").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Name").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("AssetType").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Ccy").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Price").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("NAV").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

                .Splits(0).DisplayColumns("ID").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Code").Style.HorizontalAlignment = AlignHorzEnum.Near
                .Splits(0).DisplayColumns("Name").Style.HorizontalAlignment = AlignHorzEnum.Near
                .Splits(0).DisplayColumns("AssetType").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("NAV").Style.HorizontalAlignment = AlignHorzEnum.Far

                .Columns("AssetType").Caption = "Type"
                .Columns("Price").Caption = "NAV/Unit"

                For Each column As C1DisplayColumn In DBGFund.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then column.Visible = False Else column.AutoSize()
                Next

            End With
        Else
            DBGFund.Columns.Clear()
        End If
    End Sub

    Private Sub DBGFund_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGFund.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGFund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFund.Click
        If DBGFund.RowCount > 0 Then DBGFund.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGFund_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFund.DoubleClick
        NAVProfile()
    End Sub

    Private Sub NAVProfile()
        With DBGFund
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                If .Columns("simpiEmail").Text.Trim <> "" And .Columns("Code").Text.Trim <> "" Then
                    objSimpi.Clear()
                    objSimpi.Load(.Columns("simpiEmail").Text)
                    If objSimpi.ErrID <> 0 Then
                        ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    objPortfolio.Clear()
                    objPortfolio.LoadCode(objSimpi, .Columns("Code").Text)
                    If objPortfolio.ErrID <> 0 Then
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    lblPortfolioID.Text = .Columns("ID").Text
                    lblSimpiEmail.Text = .Columns("simpiEmail").Text
                    lblPortfolioCode.Text = .Columns("Code").Text
                    lblPortfolioName.Text = .Columns("Name").Text
                    txtNAV.Text = .Columns("NAV").Text
                    txtUnits.Text = .Columns("Unit").Text
                    txtNAVUnit.Text = .Columns("Price").Text

                    objNAV.Clear()
                    objNAV.LoadBefore(objPortfolio, dtAs.Value)
                    If objNAV.ErrID = 0 Then
                        lblNAVBefore.Text = objNAV.GetNAV.ToString("n2")
                        lblPersen.Text = ((CDbl(.Columns("NAV").Text) / objNAV.GetNAV - 1) * 100).ToString("n2")
                        Double.TryParse(lblPersen.Text, price)
                        If price < 0 Then
                            lblPersen.ForeColor = Color.Red
                        ElseIf price > 0 Then
                            lblPersen.ForeColor = Color.Green
                        End If
                        lblUnit.Text = objNAV.GetTotalUnit
                        lblPrice.Text = objNAV.GetNAVPerUnit
                        Double.TryParse(txtUnits.Text, unit)
                        lblSubs.Text = ((unit - objNAV.GetTotalUnit) * objNAV.GetNAVPerUnit).ToString("n2")
                    Else
                        lblNAVBefore.Text = 0.ToString("n2")
                        lblPersen.Text = ""
                    End If
                Else
                    ClearNAV()
                End If
            End If
        End With
    End Sub

    Private Sub txtNAV_TextChanged(sender As Object, e As EventArgs) Handles txtNAV.TextChanged
        priceCalculate()
    End Sub

    Private Sub txtUnits_TextChanged(sender As Object, e As EventArgs) Handles txtUnits.TextChanged
        priceCalculate()
    End Sub

    Friend Function _roundUnitPrice(ByVal NAVPerUnit As Double) As Double
        If objPortfolio.GetPortfolioID > 0 Then
            objCodeset.Clear()
            Dim tmp = objCodeset.GetCodeset(objPortfolio, "UNIT PRICE DIGIT")
            If objCodeset.ErrID <> 0 Then Return Math.Round(NAVPerUnit, 4) Else Return Math.Round(NAVPerUnit, CInt(tmp))
        Else
            Return NAVPerUnit
        End If
    End Function

    Private Sub priceCalculate()
        Double.TryParse(txtNAV.Text, nav)
        Double.TryParse(txtUnits.Text, unit)
        Double.TryParse(lblNAVBefore.Text, price)
        If unit = 0 Then
            txtNAVUnit.Text = "0"
        Else
            txtNAVUnit.Text = _roundUnitPrice(nav / unit).ToString("n4")
            If price = 0 Then lblPersen.Text = "" Else lblPersen.Text = ((nav / price - 1) * 100).ToString("n2")
            Double.TryParse(lblPersen.Text, price)
            If price < 0 Then
                lblPersen.ForeColor = Color.Red
            ElseIf price > 0 Then
                lblPersen.ForeColor = Color.Green
            End If
            Double.TryParse(txtUnits.Text, unit)
            Double.TryParse(lblUnit.Text, nav)
            Double.TryParse(lblPrice.Text, price)
            lblSubs.Text = ((unit - nav) * price).ToString("n2")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Double.TryParse(txtNAV.Text, nav)
        Double.TryParse(txtUnits.Text, unit)
        Double.TryParse(txtNAVUnit.Text, price)

        If objPortfolio.GetPortfolioID > 0 And nav > 0 Then
            Dim lastUnit, lastPrice As Double
            objBefore.Clear()
            objBefore.LoadBefore(objPortfolio, dtAs.Value)
            If objBefore.ErrID = 0 Then
                lastUnit = objBefore.GetTotalUnit
                lastPrice = objBefore.GetNAVPerUnit
            Else
                lastUnit = 0
                lastPrice = 0
            End If

            objOverride.Clear()
            If lastUnit = unit Then 'no capital changes
                objOverride.override(objPortfolio, nav, unit, 0, price, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            Else 'there's capital changes
                objOverride.override(objPortfolio, nav, unit, 0, price, (lastUnit - unit) * lastPrice, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            End If
            If objOverride.ErrID = 0 Then
                DisplayNAV()
                ClearNAV()
            Else
                ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ClearNAV()
        txtNAV.Text = ""
        txtUnits.Text = ""
        txtNAVUnit.Text = ""
        lblSimpiEmail.Text = ""
        lblPortfolioID.Text = ""
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        objPortfolio.Clear()
        objSimpi.Clear()
        lblPersen.Text = ""
        lblNAVBefore.Text = ""
        lblSubs.Text = ""
        lblPrice.Text = ""
        lblUnit.Text = ""
    End Sub

#End Region

#Region "file upload"
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
        lblSucceed.Text = "0"
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ResetField()
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        btnRun.Enabled = False
        txtFilename.Enabled = False
        bwExcel.RunWorkerAsync()
    End Sub

    Private Sub bwExcel_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwExcel.DoWork
        ReadExcel()
    End Sub

    Private Sub bwExcel_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwExcel.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        btnRun.Enabled = True
        txtFilename.Enabled = True
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
                pbNAV.Value = 0
                inR = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                While Not inR Is Nothing
                    If inR.ToString.Trim = "" Then Exit While
                    fgExcel.Rows.Add()
                    fgExcel(fgExcel.Rows.Count - 1, 0) = fgExcel.Rows.Count - 1
                    For i = 0 To colNo
                        inC = .Range(.Cells(rowStart, colStart + i), .Cells(rowStart, colStart + i)).Value
                        If Not inC Is Nothing Then fgExcel(fgExcel.Rows.Count - 1, i + 3) = inC
                    Next
                    rowStart += 1
                    inR = .Range(.Cells(rowStart, 1), .Cells(rowStart, 1)).Value
                    If pbNAV.Value = 100 Then pbNAV.Value = 0 Else pbNAV.Value += 1
                    lblRows.Text = fgExcel.Rows.Count - 1
                End While
                pbNAV.Value = 100
                If fgExcel.Rows.Count > 0 Then lblDate.Text = ConvertToDate(fgExcel(fgExcel.Rows.Count - 1, 4), "YMD").ToString("dd-MMM-yyyy")
                lblRows.Text = fgExcel.Rows.Count - 1
                fgExcel.AutoSizeCols()
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
            .Cols.Count = 17
            .ExtendLastCol = False
            fgExcel(0, 0) = "No"
            fgExcel(0, 1) = "Portfolio"
            fgExcel(0, 2) = "Error Msg"
            fgExcel(0, 3) = "Code"
            fgExcel(0, 4) = "Date"
            fgExcel(0, 5) = "NAV"
            fgExcel(0, 6) = "NAV/Unit"
            fgExcel(0, 7) = "Units"
            fgExcel(0, 8) = "Equities"
            fgExcel(0, 9) = "FI_Corp"
            fgExcel(0, 10) = "FI_Govt"
            fgExcel(0, 11) = "Liq_Cash"
            fgExcel(0, 12) = "Liq_TD"
            fgExcel(0, 13) = "Mgt_Fee"
            fgExcel(0, 14) = "Cus_Fee"
            fgExcel(0, 15) = "Aud_Fee"
            fgExcel(0, 16) = "Total_Asset"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        lblFailed.Text = "0"
        lblSucceed.Text = "0"
        btnBrowse.Enabled = False
        btnRead.Enabled = False
        btnRun.Enabled = False
        txtFilename.Enabled = False
        bwRun.RunWorkerAsync()
    End Sub

    Private Sub bwRun_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        NAVRun()
    End Sub

    Private Sub bwRun_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        btnBrowse.Enabled = True
        btnRead.Enabled = True
        btnRun.Enabled = True
        txtFilename.Enabled = True
    End Sub

    Private Sub NAVRun()
        With fgExcel
            If .Rows.Count > 0 And cmbExternal.SelectedIndex <> -1 Then
                pbNAV.Value = 100
                aum = 0
                For i = 1 To .Rows.Count - 1
                    objPortfolio.Clear()
                    objPortfolio.ExternalID_Load(objMasterSimpi, cmbExternal.SelectedValue, fgExcel(i, 3))
                    If objPortfolio.ErrID = 0 Then
                        If IsNumeric(fgExcel(i, 5)) Then nav = CDbl(fgExcel(i, 5)) Else nav = 0
                        If IsNumeric(fgExcel(i, 6)) Then NAVUnit = CDbl(fgExcel(i, 6)) Else NAVUnit = 0
                        If IsNumeric(fgExcel(i, 7)) Then Units = CDbl(fgExcel(i, 7)) Else Units = 0
                        If IsNumeric(fgExcel(i, 8)) Then Equities = CDbl(fgExcel(i, 8)) Else Equities = 0
                        If IsNumeric(fgExcel(i, 9)) Then FI = CDbl(fgExcel(i, 9)) Else FI = 0
                        If IsNumeric(fgExcel(i, 10)) Then FI += CDbl(fgExcel(i, 10))
                        If IsNumeric(fgExcel(i, 11)) Then Cash = CDbl(fgExcel(i, 11)) Else Cash = 0
                        If IsNumeric(fgExcel(i, 12)) Then TD = CDbl(fgExcel(i, 12)) Else TD = 0
                        If IsNumeric(fgExcel(i, 13)) Then charges = CDbl(fgExcel(i, 13)) Else charges = 0
                        If IsNumeric(fgExcel(i, 14)) Then charges += CDbl(fgExcel(i, 14))
                        If IsNumeric(fgExcel(i, 15)) Then charges += CDbl(fgExcel(i, 15))
                        If charges < 0 Then charges = -1 * charges
                        If IsNumeric(fgExcel(i, 16)) Then othersAsset = CDbl(fgExcel(i, 16)) Else othersAsset = 0
                        othersAsset -= (Equities + FI + Cash + TD)

                        objOverride.Clear()
                        objOverride.override(objPortfolio, nav, Units, 0, NAVUnit, 0, 0, Equities, FI, 0, 0, 0, Cash, 0, TD, 0,
                                             0, othersAsset, 0, 0, charges, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                        If objOverride.ErrID = 0 Then
                            fgExcel(i, 1) = objPortfolio.GetPortfolioCode
                            objNAV.Clear()
                            objNAV.LoadEnd(objPortfolio)
                            If objNAV.ErrID = 0 Then
                                fgExcel(i, 2) = ""
                                fgExcel(i, 4) = objNAV.GetPositionDate.ToString("dd-MMM-yyyy")
                                aum += nav
                                lblSucceed.Text = CInt(lblSucceed.Text) + 1
                            Else
                                fgExcel(i, 1) = "ERROR"
                                fgExcel(i, 2) = objNAV.ErrMsg
                                lblFailed.Text = CInt(lblFailed.Text) + 1
                            End If
                        Else
                            fgExcel(i, 1) = "ERROR"
                            fgExcel(i, 2) = objOverride.ErrMsg
                            lblFailed.Text = CInt(lblFailed.Text) + 1
                        End If
                    Else
                        fgExcel(i, 1) = "ERROR"
                        fgExcel(i, 2) = objPortfolio.ErrMsg
                        lblFailed.Text = CInt(lblFailed.Text) + 1
                    End If
                    If pbNAV.Value = 1 Then pbNAV.Value = 100 Else pbNAV.Value -= 1
                Next
                pbNAV.Value = 0
                fgExcel.AutoSizeCols()
                lblAUM.Text = aum.ToString("n2")
            End If
        End With
    End Sub
#End Region

End Class