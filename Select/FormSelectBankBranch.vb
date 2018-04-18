Imports C1.Win.C1TrueDBGrid
Imports simpi.MarketCompany
Imports simpi.MasterSecurities
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectBankBranch
    Public lblID As C1.Win.C1InputPanel.InputLabel
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblName As C1.Win.C1InputPanel.InputLabel
    Dim objOffice As New MarketCompanyOffice

    Private Sub FormSelectBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetComboInitAll(New ParameterCountry, cmbCountry, "CountryID", "CountryName")
        btnSelect.Enabled = False
        DBGBank.FetchRowStyles = True
        objOffice.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        BankSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then BankSearch()
    End Sub

    Private Sub txtKeywordCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeywordCity.KeyDown
        If e.KeyCode = Keys.Enter Then BankSearch()
    End Sub

    Private Sub BankSearch()
        Dim tbl As New DataTable
        objOffice.Clear()
        Dim strKeyword1 As String = SQLKeyword(txtKeywordCity.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        Dim strKeyword2 As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objOffice.Search(lblBankCode.Text, IIf(cmbCountry.SelectedIndex = -1, 0, cmbCountry.SelectedValue), strKeyword1, strKeyword2)
        If objOffice.ErrID = 0 Then
            Dim query = From b In tbl.AsEnumerable
                        Select ID = b.Field(Of Integer)("OfficeID"),
                            Country = b.Field(Of String)("CountryName"),
                            City = b.Field(Of String)("OfficeCity"),
                            Branch = b.Field(Of String)("OfficeCode"),
                            Name = b.Field(Of String)("OfficeName"),
                            Address = b.Field(Of String)("OfficeAddress")
            With DBGBank
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                Dim ID, Country, City, Branch, Name, Address As C1DisplayColumn
                ID = .Splits(0).DisplayColumns("ID")
                Country = .Splits(0).DisplayColumns("Country")
                City = .Splits(0).DisplayColumns("City")
                Branch = .Splits(0).DisplayColumns("Branch")
                Name = .Splits(0).DisplayColumns("Name")
                Address = .Splits(0).DisplayColumns("Address")

                ID.Width = 35
                Country.Width = 75
                City.Width = 100
                Branch.Width = 150
                Name.Width = 175
                Address.Width = 200

                For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                    column.Style.WrapText = True
                    .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                Next

            End With
        Else
            DBGBank.Columns.Clear()
            ExceptionMessage.Show(objOffice.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGBank_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBank.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBank.Click
        If DBGBank.RowCount > 0 Then
            DBGBank.MarqueeStyle = MarqueeEnum.HighlightRow
            btnSelect.Enabled = True
        End If
    End Sub

    Private Sub DBGBank_DoubleClick(sender As Object, e As EventArgs) Handles DBGBank.DoubleClick
        BankSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        BankSelect()
    End Sub

    Private Sub BankSelect()
        With DBGBank
            If .RowCount > 0 Then
                lblID.Text = .Columns("ID").Text
                lblCode.Text = .Columns("Branch").Text
                lblName.Text = .Columns("Name").Text
            End If
        End With
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class