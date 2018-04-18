Imports C1.Win.C1TrueDBGrid
Imports simpi.MarketCompany
Imports simpi.MasterSecurities
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectMarketCompany
    Public lblID As C1.Win.C1InputPanel.InputLabel
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblName As C1.Win.C1InputPanel.InputLabel
    Dim objCompany As New MarketCompany

    Private Sub FormSelectBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetComboInitAll(New ParameterCountry, cmbCountry, "CountryID", "CountryName")
        btnSelect.Enabled = False
        DBGCompany.FetchRowStyles = True
        objCompany.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        CompanySearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then CompanySearch()
    End Sub

    Private Sub CompanySearch()
        Dim tbl As New DataTable
        objCompany.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objCompany.Search(IIf(cmbCountry.SelectedIndex = -1, 0, cmbCountry.SelectedValue), -1, strKeyword)
        If objCompany.ErrID = 0 Then
            Dim query = From b In tbl.AsEnumerable
                        Select ID = b.Field(Of Integer)("CompanyID"),
                            Country = b.Field(Of String)("CountryName"),
                            Code = b.Field(Of String)("CompanyCode"),
                            Name = b.Field(Of String)("CompanyName")
            With DBGCompany
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGCompany.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGCompany.Columns.Clear()
            ExceptionMessage.Show(objCompany.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGBank_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGCompany.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGCompany.Click
        With DBGCompany
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGBank_DoubleClick(sender As Object, e As EventArgs) Handles DBGCompany.DoubleClick
        CompanySelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        CompanySelect()
    End Sub

    Private Sub CompanySelect()
        With DBGCompany
            If .RowCount > 0 Then
                lblID.Text = .Columns("ID").Text
                lblCode.Text = .Columns("Code").Text
                lblName.Text = .Columns("Name").Text
            End If
        End With
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class