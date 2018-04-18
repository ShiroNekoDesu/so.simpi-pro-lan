Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSecurities
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectBenchmarkClass
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblDescription As C1.Win.C1InputPanel.InputLabel
    Dim objClass As New ParameterBenchmarkClass

    Private Sub FormSelectBenchmarkClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSelect.Enabled = False
        DBGClass.FetchRowStyles = True
        objClass.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ClassSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then ClassSearch()
    End Sub

    Private Sub ClassSearch()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        objClass.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objClass.Search(strKeyword)
        If objClass.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("class", True, "ClassID", "ClassCode", "ClassName")
            With tbl2
                .Columns("ClassID").ColumnName = "ID"
                .Columns("ClassCode").ColumnName = "Code"
                .Columns("ClassName").ColumnName = "Benchmark"
            End With
            With DBGClass
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                For Each column As C1DisplayColumn In DBGClass.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGClass.Columns.Clear()
            ExceptionMessage.Show(objClass.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGClass_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGClass.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGClass.Click
        If DBGClass.RowCount > 0 Then
            DBGClass.MarqueeStyle = MarqueeEnum.HighlightRow
            btnSelect.Enabled = True
        End If
    End Sub

    Private Sub DBGClass_DoubleClick(sender As Object, e As EventArgs) Handles DBGClass.DoubleClick
        ClassSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        ClassSelect()
    End Sub

    Private Sub ClassSelect()
        With DBGClass
            If .RowCount > 0 Then
                lblCode.Text = .Columns("Code").Text
                lblDescription.Text = .Columns("Benchmark").Text
            End If
        End With
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class