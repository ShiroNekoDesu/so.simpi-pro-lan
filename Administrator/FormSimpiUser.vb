Imports C1.Win.C1TrueDBGrid
Imports simpi.SimpiMaster
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString
Imports Microsoft.Office.Interop

Public Class FormSimpiUser
    Dim objUser As New SimpiUser

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
            Case "Export"
                PrintExcel(DBGUser)
        End Select
    End Sub

    Private Sub FormSimpiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objUser.UserAccess = objAccess
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

    Public Sub UserSearch()
        Dim tbl As New DataTable
        objUser.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objUser.Search(strKeyword)
        If objUser.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                             ID = t.Field(Of Integer)("UserID"),
                             UserLogin = t.Field(Of String)("UserLogin"),
                             Name = t.Field(Of String)("UserName"),
                             Initial = t.Field(Of String)("UserInitial"),
                             Title = t.Field(Of String)("UserTitle"),
                             Status = t.Field(Of String)("StatusCode")
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
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnAdd.Enabled = True
        btnProfile.Enabled = False
    End Sub

    Private Sub DBGUser_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGUser.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGUser_Click(sender As Object, e As EventArgs) Handles DBGUser.Click
        With DBGUser
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfile.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGUser_DoubleClick(sender As Object, e As EventArgs) Handles DBGUser.DoubleClick
        SimpiProfile()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        SimpiProfile()
    End Sub

    Private Sub SimpiProfile()
        With DBGUser
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objUser.Clear()
                objUser.Load(.Columns("UserLogin").Text)
                If objUser.ErrID = 0 Then
                    Dim frm As New FormSimpiUserProfile
                    frm.Show()
                    frm.objUser = objUser
                    frm.UserLoad()
                    frm.CallerForm = Me
                    frm.MdiParent = MDISO
                Else
                    ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        simpiNew()
    End Sub

    Private Sub simpiNew()
        Dim frm As New FormSimpiUserNew
        frm.Show()
        frm.CallerForm = Me
        frm.MdiParent = mdiso
    End Sub


End Class