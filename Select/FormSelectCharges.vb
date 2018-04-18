Imports C1.Win.C1TrueDBGrid
Imports simpi.ParameterFA
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectCharges
    Public lblFeeCode As C1.Win.C1InputPanel.InputLabel
    Public lblFeeDescription As C1.Win.C1InputPanel.InputLabel
    Dim objFee As New ParameterCharges

    Private Sub FormSelectParameterCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objFee.UserAccess = objAccess
        btnSelect.Enabled = False
        DBGFee.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FeeSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then FeeSearch()
    End Sub

    Private Sub FeeSearch()
        Dim dtFee As New DataTable
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtFee = objFee.Search(strKeyword)
        If objFee.ErrID = 0 Then
            Dim query = From p In dtFee.AsEnumerable
                        Select
                             ID = p.Field(Of Integer)("FeeID"),
                             Code = p.Field(Of String)("FeeCode"),
                             Description = p.Field(Of String)("FeeDescription")

            With DBGFee
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGFee.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGFee.Columns.Clear()
            ExceptionMessage.Show(objFee.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DBGFee_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGFee.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFee.Click
        If DBGFee.RowCount > 0 Then
            DBGFee.MarqueeStyle = MarqueeEnum.HighlightRow
            btnSelect.Enabled = True
        End If
    End Sub

    Private Sub DBGSimpi_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFee.DoubleClick
        FeeSelect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        FeeSelect()
    End Sub

    Private Sub FeeSelect()
        With DBGFee
            If .RowCount > 0 Then
                lblFeeCode.Text = .Columns("Code").Text
                lblFeeDescription.Text = .Columns("Description").Text
                Close()
            End If
        End With
    End Sub

End Class