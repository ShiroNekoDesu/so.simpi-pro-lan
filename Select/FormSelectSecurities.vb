Imports simpi.MarketInstrument
Imports simpi.MasterSecurities
Imports simpi.ParameterSecurities
Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectSecurities
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblName As C1.Win.C1InputPanel.InputLabel
    Public lblCompany As C1.Win.C1InputPanel.InputLabel
    Public lblCompanyID As C1.Win.C1InputPanel.InputLabel
    Public lblType As C1.Win.C1InputPanel.InputLabel
    Public lblTypeID As C1.Win.C1InputPanel.InputLabel

    Private Sub FormMarketSecurities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSelect.Enabled = False
        DBGInstrument.FetchRowStyles = True
        GetComboInit(New ParameterCountry, cmbCountry, "CountryID", "CountryName")
        cmbCountry.Text = "Indonesia"
        GetComboInitAll(New ParameterInstrumentType, cmbType, "TypeID", "TypeCode")
        txtKeyword.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SecuritiesLoad()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then SecuritiesLoad()
    End Sub

    Public Sub SecuritiesLoad()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        Dim objInstrument As New MarketInstrument
        objInstrument.Clear()
        objInstrument.UserAccess = objAccess
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objInstrument.Search(0, strKeyword, cmbCountry.SelectedValue,
                                   IIf(cmbType.SelectedIndex = -1, 0, cmbType.SelectedValue), 0, 0, 0)
        If objInstrument.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("company", True, "SecuritiesID", "CompanyID", "CompanyCode", "SecuritiesCode",
                       "SecuritiesNameShort", "TypeID", "TypeCode", "DateIssue", "SecuritiesCcy", "StatusCode")
            With tbl2
                .Columns("SecuritiesID").ColumnName = "ID"
                .Columns("CompanyID").ColumnName = "CompanyID"
                .Columns("CompanyCode").ColumnName = "Company"
                .Columns("SecuritiesCode").ColumnName = "Code"
                .Columns("SecuritiesNameShort").ColumnName = "Name"
                .Columns("TypeID").ColumnName = "TypeID"
                .Columns("TypeCode").ColumnName = "Type"
                .Columns("DateIssue").ColumnName = "Issue"
                .Columns("SecuritiesCcy").ColumnName = "Ccy"
                .Columns("StatusCode").ColumnName = "Status"
            End With
            With DBGInstrument
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2
                .Columns("Issue").NumberFormat = "dd-MMM-yy"

                Dim ID, CompanyID, Company, Code, Name, Issue, Ccy, TypeID, Type, Status As C1DisplayColumn
                ID = .Splits(0).DisplayColumns("ID")
                Company = .Splits(0).DisplayColumns("Company")
                CompanyID = .Splits(0).DisplayColumns("CompanyID")
                Code = .Splits(0).DisplayColumns("Code")
                Issue = .Splits(0).DisplayColumns("Issue")
                Ccy = .Splits(0).DisplayColumns("Ccy")
                Name = .Splits(0).DisplayColumns("Name")
                Type = .Splits(0).DisplayColumns("Type")
                TypeID = .Splits(0).DisplayColumns("TypeID")
                Status = .Splits(0).DisplayColumns("Status")

                ID.Width = 35
                CompanyID.Width = 50
                Company.Width = 85
                Code.Width = 100
                Type.Width = 40
                TypeID.Width = 50
                Name.Width = 500
                Issue.Width = 65
                Ccy.Width = 40
                Status.Width = 50

            End With
        Else
            ExceptionMessage.Show(objInstrument.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGInstrument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGInstrument.Click
        With DBGInstrument
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGInstrument_DoubleClick(sender As Object, e As EventArgs) Handles DBGInstrument.DoubleClick
        InstrumentSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        InstrumentSelect()
    End Sub

    Private Sub InstrumentSelect()
        With DBGInstrument
            If .RowCount > 0 Then
                lblCode.Text = .Columns("Code").Text
                lblCompany.Text = .Columns("Company").Text
                lblCompanyID.Text = .Columns("CompanyID").Text
                lblType.Text = .Columns("Type").Text
                lblTypeID.Text = .Columns("TypeID").Text
                lblName.Text = .Columns("Name").Text
            End If
        End With
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DBGInstrument_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGInstrument.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub csMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles csMenu.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Detach"
                MdiParent = Nothing
                e.ClickedItem.Text = "Attach"
            Case "Attach"
                e.ClickedItem.Text = "Detach"
                MdiParent = MDISO
            Case "Close"
                Close()
        End Select
    End Sub

End Class