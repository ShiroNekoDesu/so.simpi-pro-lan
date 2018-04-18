Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.CoreData
Imports Microsoft.Office.Interop

Public Class ReportConsolidationValuation
    Dim objCapital As New PositionCapital
    Dim objClient As New simpi.MasterClient.MasterClient
    Dim dtFund As New DataTable
    Dim no As Integer = 0

    Private Sub ReportAccountValuation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterCountry()
        objCapital.UserAccess = objAccess
        objClient.UserAccess = objAccess
        DBGFund.FetchRowStyles = True
        dtAs.Value = Now
    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        ClientScreen()
    End Sub

    Private Sub ClientScreen()
        Dim form As New FormSelectMasterClient
        form.lblCode = lblClientCode
        form.lblName = lblClientName
        form.Show()
        If IsMdiChild Then
            form.MdiParent = MDISO
        End If
        lblClientCode.Text = ""
        lblClientName.Text = ""
        objClient.Clear()
    End Sub

    Private Sub lblClientCode_TextChanged(sender As Object, e As EventArgs) Handles lblClientCode.TextChanged
        ClientLoad()
    End Sub

    Private Sub ClientLoad()
        If lblClientCode.Text.Trim <> "" Then
            objClient.Clear()
            objClient.Load(objMasterSimpi, lblClientCode.Text)
            If objClient.ErrID = 0 Then
                lblSalesCode.Text = objClient.GetMasterSales.GetSalesCode
                lblSalesName.Text = objClient.GetMasterSales.GetSimpiUser.GetUserName
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DataSearch()
    End Sub

    Private Sub DataSearch()
        If objClient.GetClientID > 0 Then
            objCapital.Clear()
            dtFund = objCapital.Search(objClient, dtAs.Value, "")
            DBGFund.Columns.Clear()
            If objCapital.ErrID = 0 Then
                DisplayFund()
            Else
                ExceptionMessage.Show(objCapital.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExceptionMessage.Show(objError.Message(81) & " master portfolio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function increment() As Integer
        no += 1
        Return no
    End Function

    Private Sub DisplayFund()
        If dtFund IsNot Nothing And dtFund.Rows.Count > 0 Then
            no = 0
            Dim query = From u In dtFund.AsEnumerable
                        Join s In dtParameterCountry.AsEnumerable On
                                  u.Field(Of Integer)("PortfolioCcyID") Equals
                                  s.Field(Of Integer)("CountryID")
                        Select No = increment(),
                               Fund = u.Field(Of String)("PortfolioCode"),
                               Name = u.Field(Of String)("PortfolioNameShort"),
                               Unit = u.Field(Of Decimal)("UnitBalance"),
                               Ccy = s.Field(Of String)("Ccy"),
                               Price = u.Field(Of Decimal)("UnitPrice"),
                               AvgCost = u.Field(Of Decimal)("CostPrice"),
                               Value = u.Field(Of Decimal)("UnitValue"),
                               TotalCost = u.Field(Of Decimal)("CostTotal"),
                               UnrlPL = u.Field(Of Decimal)("UnitValue") - u.Field(Of Decimal)("CostTotal")
            With DBGFund
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Unit").NumberFormat = "n4"
                .Columns("Price").NumberFormat = "n4"
                .Columns("AvgCost").NumberFormat = "n4"
                .Columns("Value").NumberFormat = "n2"
                .Columns("TotalCost").NumberFormat = "n2"
                .Columns("UnrlPL").NumberFormat = "n2"

                .Splits(0).DisplayColumns("No").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Fund").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Name").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Ccy").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Price").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("AvgCost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Value").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("TotalCost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("UnrlPL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

                .Splits(0).DisplayColumns("No").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Fund").Style.HorizontalAlignment = AlignHorzEnum.Near
                .Splits(0).DisplayColumns("Name").Style.HorizontalAlignment = AlignHorzEnum.Near
                .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("AvgCost").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Value").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("TotalCost").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("UnrlPL").Style.HorizontalAlignment = AlignHorzEnum.Far

                .Columns("TotalCost").Caption = "Total Cost"
                .Columns("AvgCost").Caption = "Average Cost"
                .Columns("UnrlPL").Caption = "Unreal. PL"


                For Each column As C1DisplayColumn In DBGFund.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        End If
    End Sub

    Private Sub DBGFund_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGFund.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFund.Click
        With DBGFund
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        PrintExcel()
    End Sub

    Private Sub PrintExcel()
        If DBGFund.RowCount > 0 Then
            Dim xls As Excel.Application
            Dim xlsWorkBook As Excel.Workbook
            Dim xlsWorkSheet As Excel.Worksheet

            xls = New Excel.Application
            xls.Visible = True
            xlsWorkBook = xls.Workbooks.Add
            xlsWorkSheet = xlsWorkBook.Sheets("sheet1")
            xls.ActiveWindow.DisplayGridlines = False
            xlsWorkSheet.Rows("1:1").RowHeight = 4.5
            'xlsWorkSheet.Rows("2:2").RowHeight = 4.5
            xlsWorkSheet.Rows("5:5").RowHeight = 4.5
            xlsWorkSheet.Columns("A:A").ColumnWidth = 1.71
            xlsWorkSheet.Range("B2:K4").Interior.Pattern = Excel.Constants.xlSolid
            xlsWorkSheet.Range("B2:K4").Interior.PatternColorIndex = Excel.Constants.xlAutomatic
            xlsWorkSheet.Range("B2:K4").Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorLight2
            xlsWorkSheet.Range("B2:K4").Interior.TintAndShade = 0.799981688894314
            xlsWorkSheet.Range("B2:K4").Interior.PatternTintAndShade = 0

            xlsWorkSheet.Range("B3").FormulaR1C1 = "Account Valuation"
            xlsWorkSheet.Range("B3").Font.Name = "Arial"
            xlsWorkSheet.Range("B3").Font.Size = 16
            xlsWorkSheet.Range("B3").Font.Strikethrough = False
            xlsWorkSheet.Range("B3").Font.Superscript = False
            xlsWorkSheet.Range("B3").Font.Subscript = False
            xlsWorkSheet.Range("B3").Font.OutlineFont = False
            xlsWorkSheet.Range("B3").Font.Shadow = False
            xlsWorkSheet.Range("B3").Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone
            xlsWorkSheet.Range("B3").Font.ThemeColor = Excel.XlThemeColor.xlThemeColorLight1
            xlsWorkSheet.Range("B3").Font.TintAndShade = 0
            xlsWorkSheet.Range("B3").Font.ThemeFont = Excel.XlThemeFont.xlThemeFontNone
            xlsWorkSheet.Range("B3").Font.Bold = True
            xlsWorkSheet.Range("B3:D3").Merge()
            xlsWorkSheet.Range("B3:D3").HorizontalAlignment = Excel.Constants.xlLeft
            xlsWorkSheet.Range("B3:D3").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B6").FormulaR1C1 = "Unitholder:"
            xlsWorkSheet.Range("B6").Font.Bold = True
            xlsWorkSheet.Range("B6:C6").Merge()
            xlsWorkSheet.Range("B6:C6").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B6:C6").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B7").FormulaR1C1 = "CIF:"
            xlsWorkSheet.Range("B7").Font.Bold = True
            xlsWorkSheet.Range("B7:C7").Merge()
            xlsWorkSheet.Range("B7:C7").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B7:C7").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B8").FormulaR1C1 = "As of:"
            xlsWorkSheet.Range("B8").Font.Bold = True
            xlsWorkSheet.Range("B8:C8").Merge()
            xlsWorkSheet.Range("B8:C8").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B8:C8").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("D6").FormulaR1C1 = lblClientName.Text
            xlsWorkSheet.Range("D7").FormulaR1C1 = lblClientCode.Text
            xlsWorkSheet.Range("D8").FormulaR1C1 = dtAs.Value.ToString("dd-MMM-yyyy")

            xlsWorkSheet.Rows("9:9").RowHeight = 4.5

            Dim startRow As Integer = 11
            xlsWorkSheet.Cells(startRow - 1, 2) = "No"
            xlsWorkSheet.Cells(startRow - 1, 3) = "Fund"
            xlsWorkSheet.Cells(startRow - 1, 4) = "Name"
            xlsWorkSheet.Cells(startRow - 1, 5) = "Unit"
            xlsWorkSheet.Cells(startRow - 1, 6) = "Ccy"
            xlsWorkSheet.Cells(startRow - 1, 7) = "Price"
            xlsWorkSheet.Cells(startRow - 1, 8) = "AvgCost"
            xlsWorkSheet.Cells(startRow - 1, 9) = "Value"
            xlsWorkSheet.Cells(startRow - 1, 10) = "TotalCost"
            xlsWorkSheet.Cells(startRow - 1, 11) = "Unr. PL"

            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).Font.Bold = True
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).HorizontalAlignment = Excel.Constants.xlCenter
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).Interior.Pattern = Excel.Constants.xlSolid
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).Interior.PatternColorIndex = Excel.Constants.xlAutomatic
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorLight2
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).Interior.TintAndShade = 0.799981688894314
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 11)).Interior.PatternTintAndShade = 0

            For i = 0 To DBGFund.RowCount - 1
                DBGFund.Row = i
                xlsWorkSheet.Cells(i + startRow, 2) = DBGFund.Columns("No").Text
                xlsWorkSheet.Cells(i + startRow, 3) = DBGFund.Columns("Fund").Text
                xlsWorkSheet.Cells(i + startRow, 4) = DBGFund.Columns("Name").Text
                xlsWorkSheet.Cells(i + startRow, 5) = DBGFund.Columns("Unit").Text
                xlsWorkSheet.Cells(i + startRow, 6) = DBGFund.Columns("Ccy").Text
                xlsWorkSheet.Cells(i + startRow, 7) = DBGFund.Columns("Price").Text
                xlsWorkSheet.Cells(i + startRow, 8) = DBGFund.Columns("AvgCost").Text
                xlsWorkSheet.Cells(i + startRow, 9) = DBGFund.Columns("Value").Text
                xlsWorkSheet.Cells(i + startRow, 10) = DBGFund.Columns("TotalCost").Text
                xlsWorkSheet.Cells(i + startRow, 11) = DBGFund.Columns("UnrlPL").Text
            Next

            xlsWorkSheet.Columns("B:K").EntireColumn.AutoFit

            'xlsWorkBook.Close()
            'xls.Quit()
        End If
    End Sub
End Class