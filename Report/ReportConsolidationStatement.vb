Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.CoreData
Imports simpi.ParameterTA
Imports simpi.ParameterTA.ParameterTA
Imports Microsoft.Office.Interop

Public Class ReportConsolidationStatement
    Dim objPortfolio As New simpi.MasterPortfolio.MasterPortfolio
    Dim objSimpi As New simpi.MasterSimpi.MasterSimpi
    Dim objCapital As New TransactionCapital
    Dim objNAV As New PortfolioNAV
    Dim objUnit As New PositionCapital
    Dim objClient As New simpi.MasterClient.MasterClient

    Dim dtTransaction As New DataTable
    Dim saldoUnit As Double = 0

    Private Sub ReportAccountStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetComboInitAll(New ParameterTransactionTrxType1, cmbType, "TrxTypeID", "TrxTypeCode")
        GetParameterTATrxType1()

        objPortfolio.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        objCapital.UserAccess = objAccess
        objClient.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objUnit.UserAccess = objAccess

        DBGTransaction.FetchRowStyles = True
        dtFrom.Value = Now.AddMonths(-1)
        dtTo.Value = Now
    End Sub

    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectMasterPortfolioNormal
        form.lblCode = lblPortfolioCode
        form.lblName = lblPortfolioName
        form.lblSimpiEmail = lblSimpiEmail
        form.lblSimpiName = lblSimpiName
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblSimpiEmail.Text = ""
        lblSimpiName.Text = ""
        objPortfolio.Clear()
    End Sub

    Private Sub lblSimpiEmail_TextChanged(sender As Object, e As EventArgs) Handles lblSimpiEmail.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objSimpi.Clear()
            objSimpi.Load(lblSimpiEmail.Text)
            If objSimpi.ErrID = 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objSimpi, lblPortfolioCode.Text)
                If objPortfolio.ErrID <> 0 Then ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        ClientScreen()
    End Sub

    Private Sub ClientScreen()
        Dim form As New FormSelectMasterClient
        form.lblCode = lblClientCode
        form.lblName = lblClientName
        form.Show()
        If IsMdiChild Then form.MdiParent = MDISO
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
        If objPortfolio.GetPortfolioID > 0 And objClient.GetClientID > 0 Then
            objNAV.Clear()
            objNAV.LoadBefore(objPortfolio, dtFrom.Value)
            If objNAV.ErrID = 0 Then
                objUnit.Clear()
                objUnit.Load(objPortfolio, objClient, objNAV.GetPositionDate)
                If objUnit.ErrID = 0 Then saldoUnit = objUnit.GetUnitBalance Else saldoUnit = 0
            Else
                saldoUnit = 0
            End If
            lblBalance.Text = saldoUnit.ToString("n4")

            objCapital.Clear()
            dtTransaction = objCapital.Search(objPortfolio, objClient, dtFrom.Value, dtTo.Value)
            DBGTransaction.Columns.Clear()
            If objCapital.ErrID = 0 Then DisplayTransaction() Else ExceptionMessage.Show(objCapital.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ExceptionMessage.Show(objError.Message(81) & " master portfolio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        DisplayTransaction()
    End Sub

    Private Sub DisplayTransaction()
        If dtTransaction IsNot Nothing And dtTransaction.Rows.Count > 0 Then
            saldoUnit = CDbl(lblBalance.Text)
            If cmbType.SelectedValue < 1 Then
                DisplayAll()
            Else
                DisplayType()
            End If
        End If
    End Sub

    Private Sub DisplayAll()
        Dim query = From u In dtTransaction.AsEnumerable
                    Join s In dtParameterTATrxType1.AsEnumerable On
                              u.Field(Of Integer)("TrxType1") Equals s.Field(Of Integer)("TrxTypeID")
                    Select Tanggal = u.Field(Of Date)("TrxDate"), NAVDate = u.Field(Of Date)("NAVDate"),
                           Type = s.Field(Of String)("TrxTypeCode"),
                           Description = u.Field(Of String)("TrxDescription"),
                           Amount = u.Field(Of Decimal)("TrxAmount"),
                           Unit = u.Field(Of Decimal)("TrxUnit"),
                           Gross = u.Field(Of Decimal)("TrxAmount"),
                           Net = IIf(u.Field(Of Integer)("TrxType1") = 1,
                                    (u.Field(Of Decimal)("TrxAmount") / (1 + u.Field(Of Decimal)("SellingFeePercentage"))),
                                 IIf(u.Field(Of Integer)("TrxType1") = 2,
                                    ((1 - u.Field(Of Decimal)("RedemptionFeePercentage")) * u.Field(Of Decimal)("TrxAmount")),
                                     u.Field(Of Decimal)("TrxAmount"))),
                           Price = u.Field(Of Decimal)("TrxPrice"),
                           Balance = RunningBalance(saldoUnit, u.Field(Of Integer)("TrxType1"), u.Field(Of Decimal)("TrxUnit")),
                           AvgCost = u.Field(Of Decimal)("AverageCost"),
                           UnrlPL = u.Field(Of Decimal)("TrxPrice") - u.Field(Of Decimal)("AverageCost"),
                           RealPL = IIf(u.Field(Of Integer)("TrxType1") = 2,
                                        u.Field(Of Decimal)("TrxPrice") - (u.Field(Of Decimal)("TrxCost") / u.Field(Of Decimal)("TrxUnit")), 0)
        With DBGTransaction
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = query.ToList

            .Columns("Tanggal").NumberFormat = "dd-MMM-yyyy"
            .Columns("NAVDate").NumberFormat = "dd-MMM-yyyy"
            .Columns("Amount").NumberFormat = "n2"
            .Columns("Unit").NumberFormat = "n4"
            .Columns("Gross").NumberFormat = "n2"
            .Columns("Net").NumberFormat = "n2"
            .Columns("Price").NumberFormat = "n4"
            .Columns("Balance").NumberFormat = "n2"
            .Columns("AvgCost").NumberFormat = "n4"
            .Columns("UnrlPL").NumberFormat = "n4"
            .Columns("RealPL").NumberFormat = "n4"

            .Splits(0).DisplayColumns("Tanggal").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("NAVDate").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Type").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Amount").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Gross").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Net").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Price").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Balance").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("AvgCost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("UnrlPL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("RealPL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Description").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

            .Splits(0).DisplayColumns("Tanggal").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("NAVDate").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Type").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Amount").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Gross").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Net").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Balance").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("AvgCost").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("UnrlPL").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("RealPL").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Description").Style.HorizontalAlignment = AlignHorzEnum.Near

            .Columns("Tanggal").Caption = "Date"
            .Columns("NAVDate").Caption = "NAV"
            .Columns("AvgCost").Caption = "Average Cost"
            .Columns("UnrlPL").Caption = "Unreal. PL"
            .Columns("RealPL").Caption = "Realized PL"

            For Each column As C1DisplayColumn In DBGTransaction.Splits(0).DisplayColumns
                column.AutoSize()
            Next
        End With
    End Sub

    Private Sub DisplayType()
        Dim query = From u In dtTransaction.AsEnumerable
                    Join s In dtParameterTATrxType1.AsEnumerable On
                          u.Field(Of Integer)("TrxType1") Equals
                          s.Field(Of Integer)("TrxTypeID")
                    Where u.Field(Of Integer)("TrxType1") = cmbType.SelectedValue
                    Select Tanggal = u.Field(Of Date)("TrxDate"), NAVDate = u.Field(Of Date)("NAVDate"),
                           Type = s.Field(Of String)("TrxTypeCode"),
                           Description = u.Field(Of String)("TrxDescription"),
                           Amount = u.Field(Of Decimal)("TrxAmount"),
                           Unit = u.Field(Of Decimal)("TrxUnit"),
                           Gross = u.Field(Of Decimal)("TrxAmount"),
                           Net = IIf(u.Field(Of Integer)("TrxType1") = 1,
                                    (u.Field(Of Decimal)("TrxAmount") / (1 + u.Field(Of Decimal)("SellingFeePercentage"))),
                                 IIf(u.Field(Of Integer)("TrxType1") = 2,
                                    ((1 - u.Field(Of Decimal)("RedemptionFeePercentage")) * u.Field(Of Decimal)("TrxAmount")),
                                     u.Field(Of Decimal)("TrxAmount"))),
                           Price = u.Field(Of Decimal)("TrxPrice"),
                           Balance = RunningBalance(saldoUnit, u.Field(Of Integer)("TrxType1"), u.Field(Of Decimal)("TrxUnit")),
                           AvgCost = u.Field(Of Decimal)("AverageCost"),
                           UnrlPL = u.Field(Of Decimal)("TrxPrice") - u.Field(Of Decimal)("AverageCost"),
                           RealPL = IIf(u.Field(Of Integer)("TrxType1") = 2,
                                     u.Field(Of Decimal)("TrxPrice") - (u.Field(Of Decimal)("TrxCost") / u.Field(Of Decimal)("TrxUnit")),
                                     0)

        With DBGTransaction
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = query.ToList

            .Columns("Tanggal").NumberFormat = "dd-MMM-yyyy"
            .Columns("NAVDate").NumberFormat = "dd-MMM-yyyy"
            .Columns("Amount").NumberFormat = "n2"
            .Columns("Unit").NumberFormat = "n4"
            .Columns("Gross").NumberFormat = "n2"
            .Columns("Net").NumberFormat = "n2"
            .Columns("Price").NumberFormat = "n4"
            .Columns("Balance").NumberFormat = "n2"
            .Columns("AvgCost").NumberFormat = "n4"
            .Columns("UnrlPL").NumberFormat = "n4"
            .Columns("RealPL").NumberFormat = "n4"

            .Splits(0).DisplayColumns("Tanggal").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("NAVDate").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Type").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Amount").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Gross").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Net").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Price").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Balance").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("AvgCost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("UnrlPL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("RealPL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Description").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

            .Splits(0).DisplayColumns("Tanggal").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("NAVDate").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Type").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Amount").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Gross").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Net").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Balance").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("AvgCost").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("UnrlPL").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("RealPL").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Description").Style.HorizontalAlignment = AlignHorzEnum.Near

            .Columns("Tanggal").Caption = "Date"
            .Columns("NAVDate").Caption = "NAV"
            .Columns("AvgCost").Caption = "Average Cost"
            .Columns("UnrlPL").Caption = "Unreal. PL"
            .Columns("RealPL").Caption = "Realized PL"

            For Each column As C1DisplayColumn In DBGTransaction.Splits(0).DisplayColumns
                column.AutoSize()
            Next
        End With
    End Sub

    Private Sub DBGTransaction_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGTransaction.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGTransaction.Click
        With DBGTransaction
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        PrintExcel()
    End Sub

    Private Sub PrintExcel()
        If DBGTransaction.RowCount > 0 Then
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
            xlsWorkSheet.Range("B2:M4").Interior.Pattern = Excel.Constants.xlSolid
            xlsWorkSheet.Range("B2:M4").Interior.PatternColorIndex = Excel.Constants.xlAutomatic
            xlsWorkSheet.Range("B2:M4").Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorLight2
            xlsWorkSheet.Range("B2:M4").Interior.TintAndShade = 0.799981688894314
            xlsWorkSheet.Range("B2:M4").Interior.PatternTintAndShade = 0

            xlsWorkSheet.Range("B3").FormulaR1C1 = "Account Statement"
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

            xlsWorkSheet.Range("B6").FormulaR1C1 = "Unitholder name:"
            xlsWorkSheet.Range("B6").Font.Bold = True
            xlsWorkSheet.Range("B6:C6").Merge()
            xlsWorkSheet.Range("B6:C6").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B6:C6").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B7").FormulaR1C1 = "CIF:"
            xlsWorkSheet.Range("B7").Font.Bold = True
            xlsWorkSheet.Range("B7:C7").Merge()
            xlsWorkSheet.Range("B7:C7").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B7:C7").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B8").FormulaR1C1 = "Investment selection:"
            xlsWorkSheet.Range("B8").Font.Bold = True
            xlsWorkSheet.Range("B8:C8").Merge()
            xlsWorkSheet.Range("B8:C8").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B8:C8").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B9").FormulaR1C1 = "Period:"
            xlsWorkSheet.Range("B9").Font.Bold = True
            xlsWorkSheet.Range("B9:C9").Merge()
            xlsWorkSheet.Range("B9:C9").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B9:C9").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("B10").FormulaR1C1 = "Transaction:"
            xlsWorkSheet.Range("B10").Font.Bold = True
            xlsWorkSheet.Range("B10:C10").Merge()
            xlsWorkSheet.Range("B10:C10").HorizontalAlignment = Excel.Constants.xlRight
            xlsWorkSheet.Range("B10:C10").VerticalAlignment = Excel.Constants.xlBottom

            xlsWorkSheet.Range("D6").FormulaR1C1 = lblClientName.Text
            xlsWorkSheet.Range("D7").FormulaR1C1 = lblClientCode.Text
            xlsWorkSheet.Range("D8").FormulaR1C1 = lblPortfolioName.Text
            xlsWorkSheet.Range("D9").FormulaR1C1 = dtFrom.Value.ToString("dd-MMM-yyyy") & " to " & dtTo.Value.ToString("dd-MMM-yyyy")
            xlsWorkSheet.Range("D10").FormulaR1C1 = cmbType.Text

            xlsWorkSheet.Rows("11:11").RowHeight = 4.5

            Dim startRow As Integer = 13
            xlsWorkSheet.Cells(startRow - 1, 2) = "Date"
            xlsWorkSheet.Cells(startRow - 1, 3) = "Type"
            xlsWorkSheet.Cells(startRow - 1, 4) = "Description"
            xlsWorkSheet.Cells(startRow - 1, 5) = "Transaction Value"
            xlsWorkSheet.Cells(startRow - 1, 6) = "Unit(s)"
            xlsWorkSheet.Cells(startRow - 1, 7) = "Gross"
            xlsWorkSheet.Cells(startRow - 1, 8) = "Net"
            xlsWorkSheet.Cells(startRow - 1, 9) = "Unit Price"
            xlsWorkSheet.Cells(startRow - 1, 10) = "Balance (Units)"
            xlsWorkSheet.Cells(startRow - 1, 11) = "Avg. Cost"
            xlsWorkSheet.Cells(startRow - 1, 12) = "Unr. PL"
            xlsWorkSheet.Cells(startRow - 1, 13) = "Real. PL"

            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).Font.Bold = True
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).HorizontalAlignment = Excel.Constants.xlCenter
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).Interior.Pattern = Excel.Constants.xlSolid
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).Interior.PatternColorIndex = Excel.Constants.xlAutomatic
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorLight2
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).Interior.TintAndShade = 0.799981688894314
            xlsWorkSheet.Range(xlsWorkSheet.Cells(startRow - 1, 2), xlsWorkSheet.Cells(startRow - 1, 13)).Interior.PatternTintAndShade = 0

            For i = 0 To DBGTransaction.RowCount - 1
                DBGTransaction.Row = i
                xlsWorkSheet.Cells(i + startRow, 2) = DBGTransaction.Columns("Date").Text
                xlsWorkSheet.Cells(i + startRow, 3) = DBGTransaction.Columns("Type").Text
                xlsWorkSheet.Cells(i + startRow, 4) = DBGTransaction.Columns("Description").Text
                xlsWorkSheet.Cells(i + startRow, 5) = DBGTransaction.Columns("Amount").Text
                xlsWorkSheet.Cells(i + startRow, 6) = DBGTransaction.Columns("Unit").Text
                xlsWorkSheet.Cells(i + startRow, 7) = DBGTransaction.Columns("Gross").Text
                xlsWorkSheet.Cells(i + startRow, 8) = DBGTransaction.Columns("Net").Text
                xlsWorkSheet.Cells(i + startRow, 9) = DBGTransaction.Columns("Price").Text
                xlsWorkSheet.Cells(i + startRow, 10) = DBGTransaction.Columns("Balance").Text
                xlsWorkSheet.Cells(i + startRow, 11) = DBGTransaction.Columns("AvgCost").Text
                xlsWorkSheet.Cells(i + startRow, 12) = DBGTransaction.Columns("UnrlPL").Text
                xlsWorkSheet.Cells(i + startRow, 13) = DBGTransaction.Columns("RealPL").Text

            Next

            xlsWorkSheet.Columns("B:M").EntireColumn.AutoFit

            'xlsWorkBook.Close()
            'xls.Quit()
        End If
    End Sub

End Class