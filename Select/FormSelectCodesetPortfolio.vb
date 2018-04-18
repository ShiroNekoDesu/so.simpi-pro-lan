Imports C1.Win.C1TrueDBGrid
Imports simpi.Codeset
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectCodesetPortfolio
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblDescription As C1.Win.C1InputPanel.InputLabel
    Dim objCodeset As New CodesetPortfolioField

    Private Sub FormSelectCodesetPortfolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSelect.Enabled = False
        DBGCodeset.FetchRowStyles = True
        objCodeset.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        CodeSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            CodeSearch()
        End If
    End Sub

    Private Sub CodeSearch()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        objCodeset.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objCodeset.Search(strKeyword)
        If objCodeset.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("codeset", True, "FieldID", "FieldCode", "FieldDescription")
            With tbl2
                .Columns("FieldID").ColumnName = "ID"
                .Columns("FieldCode").ColumnName = "Code"
                .Columns("FieldDescription").ColumnName = "Description"
            End With
            With DBGCodeset
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                For Each column As C1DisplayColumn In DBGCodeset.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGCodeset.Columns.Clear()
            ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGCodeset_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGCodeset.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGCodeset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGCodeset.Click
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGCodeset_DoubleClick(sender As Object, e As EventArgs) Handles DBGCodeset.DoubleClick
        CodeSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        CodeSelect()
    End Sub

    Private Sub CodeSelect()
        With DBGCodeset
            If .RowCount > 0 Then
                lblCode.Text = .Columns("Code").Text
                lblDescription.Text = .Columns("Description").Text
            End If
        End With
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class