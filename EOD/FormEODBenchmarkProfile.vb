Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalDate
Imports simpi.ParameterPortfolio
Imports simpi.MasterSecurities

Public Class FormEODBenchmarkProfile
    Public CallerForm As FormEODBenchmark
    Public objPosition As simpi.CoreData.PortfolioBenchmark
    Public objPortfolio As simpi.MasterPortfolio.MasterPortfolio
    Dim objEOD As New simpi.CoreClosing.ProcessEOD
    Dim objBenchmark As New simpi.MasterPortfolio.PortfolioBenchmark
    Dim objClass As New ParameterBenchmarkClass
    Dim dateBenchmark As Date

    Public Sub FormLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            lblPortfolioCode.Text = objPortfolio.GetPortfolioCode
            lblPortfolioName.Text = objPortfolio.GetPortfolioNameFull
            lblPortfolioCcy.Text = objPortfolio.GetPortfolioCcy.GetCcy
            lblInception.Text = objPortfolio.GetInceptionDate.ToString("dd-MMMM-yyyy")

            dateBenchmark = objPosition.GetPositionDate
            lblValuation.Text = dateBenchmark.ToString("dd-MMMM-yyyy")
            lblValue.Text = objPosition.GetBenchmarkValue.ToString("n2")
            lblAdjustment.Text = objPosition.GetBenchmarkAdjustment.ToString("n2")

            objEOD.UserAccess = objAccess
            objBenchmark.UserAccess = objAccess
            objClass.UserAccess = objAccess
            DBGBenchmark.FetchRowStyles = True
            BenchmarkLoad()
            PositionLoad()
        Else
            Close()
        End If
    End Sub

    Private Sub BenchmarkLoad()
        objBenchmark.Clear()
        objBenchmark.Load(objPortfolio, dateBenchmark)
        If objBenchmark.ErrID = 0 Then
            lblType.Text = objBenchmark.GetBenchmarkType.GetBenchmarkTypeCode
            If ParameterPortfolio.IsBenchmarkTypeBenchmark(objBenchmark.GetBenchmarkType.GetBenchmarkTypeID) Then
                lblBenchmark.Text = objBenchmark.GetBenchmarkClass.GetClassCode
                lblDescription.Text = objBenchmark.GetBenchmarkClass.GetClassName
                CompositionLoad()
            Else
                lblBenchmark.Text = objBenchmark.GetBenchmarkPortfolio.GetPortfolioCode
                lblDescription.Text = objBenchmark.GetBenchmarkPortfolio.GetPortfolioNameShort
                DBGBenchmark.Columns.Clear()
            End If
        Else
            ExceptionMessage.Show(objBenchmark.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CompositionLoad()
        objClass.Clear()
        objClass.LoadCode(lblBenchmark.Text)
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        tbl = objClass.Benchmark_Composition()
        If objClass.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("company", True, "BenchmarkID", "BenchmarkCode", "BenchmarkName", "BenchmarkPercentage")
            With tbl2
                .Columns("BenchmarkID").ColumnName = "ID"
                .Columns("BenchmarkCode").ColumnName = "Benchmark"
                .Columns("BenchmarkName").ColumnName = "Name"
                .Columns("BenchmarkPercentage").ColumnName = "Percentage"
            End With
            With DBGBenchmark
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2
                Dim No, Benchmark, Name, Percentage As C1DisplayColumn
                No = .Splits(0).DisplayColumns("ID")
                Benchmark = .Splits(0).DisplayColumns("Benchmark")
                Name = .Splits(0).DisplayColumns("Name")
                Percentage = .Splits(0).DisplayColumns("Percentage")
                No.Width = 35
                Benchmark.Width = 150
                Name.Width = 450
                Percentage.Width = 75
            End With
        Else
            ExceptionMessage.Show(objClass.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGBenchmark_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBenchmark.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub PositionLoad()
        With fgReturn
            .Cols.Fixed = 0
            .Rows.Fixed = 1
            .ExtendLastCol = False
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .Cols.Count = 3
            .Rows.Count = 1

            .Cols(0).Width = 50
            .Cols(1).Width = 85
            .Cols(2).Width = 100

            .Cols(0).Caption = "Period"
            .Cols(1).Caption = "Date"
            .Cols(2).Caption = "Return"
            If objPosition.ErrID = 0 Then
                .AddItem("1D" + vbTab + GenerateDate(dateBenchmark, "D", 1).ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr1D * 100).ToString("n3"))
                .AddItem("MTD" + vbTab + GenerateDate(dateBenchmark, "MTD").ToString("dd-MMM-yyyy") + vbTab + (objPosition.GetrMTD * 100).ToString("n3"))
                .AddItem("1Mo" + vbTab + GenerateDate(dateBenchmark, "M", 1, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr1Mo * 100).ToString("n3"))
                .AddItem("3Mo" + vbTab + GenerateDate(dateBenchmark, "M", 3, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr3Mo * 100).ToString("n3"))
                .AddItem("6Mo" + vbTab + GenerateDate(dateBenchmark, "M", 6, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr6Mo * 100).ToString("n3"))
                .AddItem("YTD" + vbTab + GenerateDate(dateBenchmark, "YTD").ToString("dd-MMM-yyyy") + vbTab + (objPosition.GetrYTD * 100).ToString("n3"))
                .AddItem("1Y" + vbTab + GenerateDate(dateBenchmark, "Y", 1, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr1Y * 100).ToString("n3"))
                .AddItem("2Y" + vbTab + GenerateDate(dateBenchmark, "Y", 2, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr2Y * 100).ToString("n3"))
                .AddItem("3Y" + vbTab + GenerateDate(dateBenchmark, "Y", 3, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr3Y * 100).ToString("n3"))
                .AddItem("5Y" + vbTab + GenerateDate(dateBenchmark, "Y", 5, "A").ToString("dd-MMM-yyyy") + vbTab + (objPosition.Getr5Y * 100).ToString("n3"))
                btnDelete.Enabled = True
                btnGenerate.Enabled = False
            Else
                .AddItem("1D" + vbTab + GenerateDate(dateBenchmark, "D", 1).ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("MTD" + vbTab + GenerateDate(dateBenchmark, "MTD").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("1Mo" + vbTab + GenerateDate(dateBenchmark, "M", 1, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("3Mo" + vbTab + GenerateDate(dateBenchmark, "M", 3, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("6Mo" + vbTab + GenerateDate(dateBenchmark, "M", 6, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("YTD" + vbTab + GenerateDate(dateBenchmark, "YTD").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("1Y" + vbTab + GenerateDate(dateBenchmark, "Y", 1, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("2Y" + vbTab + GenerateDate(dateBenchmark, "Y", 2, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("3Y" + vbTab + GenerateDate(dateBenchmark, "Y", 3, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("5Y" + vbTab + GenerateDate(dateBenchmark, "Y", 5, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                btnDelete.Enabled = False
                btnGenerate.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        '    BenchmarkGenerate()
    End Sub

    'Private Sub BenchmarkGenerate()
    '    objEOD.return_generate(objPortfolio)
    '    If objEOD.ErrID = 0 Then
    '        PositionLoad()
    '        CallerForm.BenchmarkLoad()
    '    Else
    '        ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'BenchmarkRemove()
    End Sub

    'Private Sub BenchmarkRemove()
    '    objEOD.return_delete(objPortfolio)
    '    If objEOD.ErrID = 0 Then
    '        CallerForm.BenchmarkLoad()
    '        PositionLoad()
    '    Else
    '        ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class