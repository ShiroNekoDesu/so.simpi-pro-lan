Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.GlobalException

Public Class FormSelectSimpiPortfolio
    Public txtPortfolioCode As C1.Win.C1InputPanel.InputTextBox
    Public lblPortfolioName As C1.Win.C1InputPanel.InputLabel

    Private Sub FormSelectSimpiPortfolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        lblID.Text = objSimpi.GetSimpiID
        lblType.Text = objSimpi.GetSimpiType.GetTypeCode
        lblName.Text = objSimpi.GetSimpiNameshort
        lblStatus.Text = objSimpi.GetSimpiStatus.GetStatusCode
        btnSelect.Enabled = False
        DBGPortfolio.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PortfolioSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            PortfolioSearch()
        End If
    End Sub

    Private Sub PortfolioSearch()
        GetParameterCountry("")
        GetParameterPortfolioStatus("")
        GetParameterPortfolioType("")

        Dim dtPortfolio As New DataTable
        Dim objPortfolio As New MasterPortfolio
        objPortfolio.UserAccess = objAccess
        dtPortfolio = objPortfolio.Search(objMasterSimpi, txtKeyword.Text)
        If objPortfolio.ErrID = 0 Then
            Dim query = From p In dtPortfolio.AsEnumerable
                        Join c In dtCountry.AsEnumerable On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                        Join s In dtPortfolioStatus.AsEnumerable On p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Join l In dtPortfolioType.AsEnumerable On p.Field(Of Integer)("TypeID") Equals l.Field(Of Integer)("TypeID")
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Shortname = p.Field(Of String)("PortfolioNameshort"),
                             Ccy = c.Field(Of String)("Ccy"),
                             Status = s.Field(Of String)("StatusCode"),
                             Level = l.Field(Of String)("TypeCode")

            With DBGPortfolio
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGPortfolio.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGPortfolio.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DBGPortfolio_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGPortfolio.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGPortfolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolio.Click
        With DBGPortfolio
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGSimpi_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolio.DoubleClick
        PortfolioSelect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        PortfolioSelect()
    End Sub

    Private Sub PortfolioSelect()
        With DBGPortfolio
            If .RowCount > 0 Then
                txtPortfolioCode.Text = .Columns("Code").Text
                lblPortfolioName.Text = .Columns("Shortname").Text
                Close()
            End If
        End With
    End Sub

End Class