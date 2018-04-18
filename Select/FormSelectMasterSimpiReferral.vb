Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.MasterSimpi
Imports simpi.globalutilities.GlobalString
Imports simpi.ParameterSimpi.ParameterSimpi

Public Class FormSelectMasterSimpiReferral
    Public lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Public lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Dim objSimpi As New MasterSimpi

    Private Sub FormSelectMasterSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objSimpi.UserAccess = objAccess
        btnSelect.Enabled = False
        DBGSimpi.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SimpiSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpiSearch()
        End If
    End Sub

    Private Sub SimpiSearch()
        Dim dtSimpi As New DataTable
        objSimpi.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtSimpi = objSimpi.Search(strKeyword, SetRefferal, -1)
        If objSimpi.ErrID = 0 Then
            Dim query = From p In dtSimpi.AsEnumerable
                        Select ID = p.Field(Of Integer)("simpiID"),
                               simpiEmail = p.Field(Of String)("simpiEmail"),
                               simpi = p.Field(Of String)("simpiName"),
                               UserLogin = p.Field(Of String)("AdminLogin"),
                               Name = p.Field(Of String)("AdminName"),
                               Status = p.Field(Of String)("AdminStatus")
            With DBGSimpi
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGSimpi.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then
                        column.Visible = False
                    Else
                        column.AutoSize()
                    End If
                Next

            End With
        Else
            DBGSimpi.Columns.Clear()
            ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGSales_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGSimpi.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSimpi.Click
        With DBGSimpi
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGSales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSimpi.DoubleClick
        SalesSelect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        SalesSelect()
    End Sub

    Private Sub SalesSelect()
        With DBGSimpi
            If .RowCount > 0 Then
                lblSimpiEmail.Text = .Columns("simpiEmail").Text
                lblSimpiName.Text = .Columns("simpi").Text
                Close()
            End If
        End With
    End Sub

End Class