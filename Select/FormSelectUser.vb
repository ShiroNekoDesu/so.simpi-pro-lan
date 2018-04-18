Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSelectUser
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblName As C1.Win.C1InputPanel.InputLabel
    Dim objUser As New simpi.MasterSimpi.SimpiUser

    Private Sub FormSelectMasterSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterUserStatus("")
        lblSimpiID.Text = objSimpi.GetSimpiID
        lblSimpiType.Text = objSimpi.GetSimpiType.GetTypeCode
        lblSimpiName.Text = objSimpi.GetSimpiNameshort
        lblSimpiStatus.Text = objSimpi.GetSimpiStatus.GetStatusCode
        objUser.UserAccess = objAccess
        btnSelect.Enabled = False
        DBGUser.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        UserSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserSearch()
        End If
    End Sub

    Private Sub UserSearch()
        Dim tbl As New DataTable
        objUser.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objUser.Search(objMasterSimpi, strKeyword)
        If objUser.ErrID = 0 Then
            Dim query = From p In tbl.AsEnumerable
                        Join s In dtUserStatus.AsEnumerable On
                                  p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Select
                             ID = p.Field(Of Integer)("UserID"),
                             User = p.Field(Of String)("UserLogin"),
                             Name = p.Field(Of String)("UserName"),
                             Status = s.Field(Of String)("StatusCode")

            With DBGUser
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGUser.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGUser.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGSales_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGUser.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUser.Click
        With DBGUser
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGSales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUser.DoubleClick
        UserSelect()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        UserSelect()
    End Sub

    Private Sub UserSelect()
        With DBGUser
            If .RowCount > 0 Then
                lblCode.Text = .Columns("User").Text
                lblName.Text = .Columns("Name").Text
                Close()
            End If
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class