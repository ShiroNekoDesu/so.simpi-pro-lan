Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSecurities
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectMarket
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblName As C1.Win.C1InputPanel.InputLabel
    Public lblType As C1.Win.C1InputPanel.InputLabel
    Dim objMarket As New ParameterMarket

    Private Sub FormSelectBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objMarket.UserAccess = objAccess
        btnSelect.Enabled = False
        DBGMarket.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        MarketSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            MarketSearch()
        End If
    End Sub

    Private Sub MarketSearch()
        Dim tbl As New DataTable
        objMarket.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objMarket.Search(strKeyword)
        If objMarket.ErrID = 0 Then
            Dim query = From m In tbl.AsEnumerable
                        Select ID = m.Field(Of Integer)("MarketID"),
                               Code = m.Field(Of String)("MarketCode"),
                              Name = m.Field(Of String)("MarketName")
            With DBGMarket
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGMarket.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGMarket.Columns.Clear()
            ExceptionMessage.Show(objMarket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGBank_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGMarket.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGMarket.Click
        With DBGMarket
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGBank_DoubleClick(sender As Object, e As EventArgs) Handles DBGMarket.DoubleClick
        BankSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        BankSelect()
    End Sub

    Private Sub BankSelect()
        With DBGMarket
            If .RowCount > 0 Then
                lblCode.Text = .Columns("code").Text
                lblName.Text = .Columns("Name").Text
                If rbMid.Checked Then
                    lblType.Text = 1
                ElseIf rbBid.Checked Then
                    lblType.Text = 2
                ElseIf rbOffer.Checked Then
                    lblType.Text = 3
                End If
            End If
        End With
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub


End Class