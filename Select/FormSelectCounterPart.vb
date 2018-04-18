Imports C1.Win.C1TrueDBGrid
Imports simpi.MarketCompany
Imports simpi.MasterSecurities
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectCounterPart
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblName As C1.Win.C1InputPanel.InputLabel
    Dim objBroker As New MasterCounterPart

    Private Sub FormSelectBroker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetComboInitAll(New ParameterCountry, cmbCountry, "CountryID", "CountryName")
        btnSelect.Enabled = False
        DBGBroker.FetchRowStyles = True
        objBroker.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        BrokerSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BrokerSearch()
        End If
    End Sub

    Private Sub BrokerSearch()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        objBroker.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objBroker.Search(IIf(cmbCountry.SelectedIndex = -1, 0, cmbCountry.SelectedValue), strKeyword)
        If objBroker.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("company", True, "CompanyID", "CountryName", "BrokerCode", "CompanyCode", "CompanyName")
            With tbl2
                .Columns("CompanyID").ColumnName = "ID"
                .Columns("CountryName").ColumnName = "Country"
                .Columns("BrokerCode").ColumnName = "Broker"
                .Columns("CompanyCode").ColumnName = "Company"
                .Columns("CompanyName").ColumnName = "Name"
            End With
            With DBGBroker
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                For Each column As C1DisplayColumn In DBGBroker.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGBroker.Columns.Clear()
            ExceptionMessage.Show(objBroker.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGBroker_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBroker.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGBroker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBroker.Click
        With DBGBroker
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGBroker_DoubleClick(sender As Object, e As EventArgs) Handles DBGBroker.DoubleClick
        BankSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BankSelect()
    End Sub

    Private Sub BankSelect()
        With DBGBroker
            If .RowCount > 0 Then
                lblCode.Text = .Columns("Broker").Text
                lblName.Text = .Columns("Name").Text
            End If
        End With
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

End Class