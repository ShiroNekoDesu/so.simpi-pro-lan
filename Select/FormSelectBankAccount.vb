Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.MasterSimpi
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectBankAccount
    Public lblBankName As C1.Win.C1InputPanel.InputLabel
    Public lblBankCode As C1.Win.C1InputPanel.InputLabel
    Public lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Public lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Public lblAccountNo As C1.Win.C1InputPanel.InputLabel
    Public objSimpi As MasterSimpi
    Dim objAccount As New PortfolioBankAccount

    Private Sub FormSelectSimpiPortfolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If objSimpi.GetSimpiID > 0 Then
            objAccount.UserAccess = objAccess
            btnSelect.Enabled = False
            DBGAccount.FetchRowStyles = True
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        AccountSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then AccountSearch()
    End Sub

    Private Sub AccountSearch()
        Dim dtAccount As New DataTable
        objAccount.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtAccount = objAccount.SearchAccount(objSimpi, 0, strKeyword)
        If objAccount.ErrID = 0 Then
            Dim query = From p In dtAccount.AsEnumerable
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Shortname = p.Field(Of String)("PortfolioNameshort"),
                             Bank = p.Field(Of String)("CompanyCode"),
                             BankName = p.Field(Of String)("CompanyName"),
                             Branch = p.Field(Of String)("OfficeName"),
                             AccountNo = p.Field(Of String)("AccountNo"),
                             AccountName = p.Field(Of String)("AccountName")

            With DBGAccount
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGAccount.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGAccount.Columns.Clear()
            ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DBGPortfolio_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGAccount.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGPortfolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAccount.Click
        If DBGAccount.RowCount > 0 Then
            DBGAccount.MarqueeStyle = MarqueeEnum.HighlightRow
            btnSelect.Enabled = True
        End If
    End Sub

    Private Sub DBGAccount_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAccount.DoubleClick
        PortfolioSelect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        PortfolioSelect()
    End Sub

    Private Sub PortfolioSelect()
        With DBGAccount
            If .RowCount > 0 Then
                lblBankCode.Text = .Columns("Bank").Text
                lblBankName.Text = .Columns("BankName").Text
                lblAccountNo.Text = .Columns("AccountNo").Text
                lblPortfolioCode.Text = .Columns("Code").Text
                lblPortfolioName.Text = .Columns("Shortname").Text
                Close()
            End If
        End With
    End Sub

End Class