Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSecurities
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectBenchmark
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblDescription As C1.Win.C1InputPanel.InputLabel
    Dim objBenchmark As New ParameterBenchmark

    Private Sub FormSelectBenchmark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSelect.Enabled = False
        DBGBenchmark.FetchRowStyles = True
        objBenchmark.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        BenchmarkSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BenchmarkSearch()
        End If
    End Sub

    Private Sub BenchmarkSearch()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        objBenchmark.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objBenchmark.Search(0, strKeyword)
        If objBenchmark.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("company", True, "BenchmarkID", "BenchmarkCode", "BenchmarkName", "BenchmarkTypeCode", "BenchmarkCalculationCode", "BenchmarkDays")
            With tbl2
                .Columns("BenchmarkID").ColumnName = "ID"
                .Columns("BenchmarkCode").ColumnName = "Code"
                .Columns("BenchmarkName").ColumnName = "Name"
                .Columns("BenchmarkTypeCode").ColumnName = "Type"
                .Columns("BenchmarkCalculationCode").ColumnName = "Calculation"
                .Columns("BenchmarkDays").ColumnName = "Days"

            End With
            With DBGBenchmark
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                Dim No, Code, Name, Type, Calculation, Days As C1DisplayColumn
                No = .Splits(0).DisplayColumns("ID")
                Code = .Splits(0).DisplayColumns("Code")
                Name = .Splits(0).DisplayColumns("Name")
                Type = .Splits(0).DisplayColumns("Type")
                Calculation = .Splits(0).DisplayColumns("Calculation")
                Days = .Splits(0).DisplayColumns("Days")

                No.Width = 35
                Code.Width = 100
                Name.Width = 375
                Type.Width = 85
                Calculation.Width = 85
                Days.Width = 35
            End With
        Else
            DBGBenchmark.Columns.Clear()
            ExceptionMessage.Show(objBenchmark.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGBenchmark_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBenchmark.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGBenchmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBenchmark.Click
        With DBGBenchmark
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGBenchmark_DoubleClick(sender As Object, e As EventArgs) Handles DBGBenchmark.DoubleClick
        BenchmarkSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        BenchmarkSelect()
    End Sub

    Private Sub BenchmarkSelect()
        With DBGBenchmark
            If .RowCount > 0 Then
                lblCode.Text = .Columns("Code").Text
                lblDescription.Text = .Columns("Name").Text
            End If
        End With
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class