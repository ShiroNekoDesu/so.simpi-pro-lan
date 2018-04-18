Imports C1.Win.C1TrueDBGrid
Imports simpi.SystemSecurity
Imports simpi.globalutilities
Imports simpi.SimpiMaster

Public Class FormSimpiUserProfileMenu
    Public objUser As SimpiUser
    Public objApps As SystemApplication
    Public CallerForm As FormSimpiUserProfile
    Dim objMenu As New SystemMenu

    Public Sub MenuLoad()
        If objUser.GetUserID > 0 Then
            lblIDUser.Text = objUser.GetUserID
            lblLoginUser.Text = objUser.GetUserLogin
            lblStatusUser.Text = objUser.GetUserStatus.GetStatusCode

            lblAppsID.Text = objApps.GetAppsID
            lblAppsCode.Text = objApps.GetAppsCode
            lblAppsName.Text = objApps.GetAppsName

            btnAdd.Enabled = False
            DBGMenu.FetchRowStyles = True
            objMenu.UserAccess = objAccess
            MenuSearch()
        Else
            Close()
        End If
    End Sub

    Private Sub MenuSearch()
        Dim tbl As New DataTable
        tbl = objUser.Menu_SearchMenuAvailable(objApps)
        If objUser.ErrID = 0 Then
            Dim query = From a In tbl.AsEnumerable
                        Select
                            ID = a.Field(Of Integer)("MenuID"),
                            Code = a.Field(Of String)("MenuCode"),
                            Name = a.Field(Of String)("MenuName")

            With DBGMenu
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGMenu.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGMenu.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DBGMenu_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGMenu.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGMenu.Click
        With DBGMenu
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnAdd.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGMenu_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGMenu.DoubleClick
        MenuAdd()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MenuAdd()
    End Sub

    Private Sub MenuAdd()
        With DBGMenu
            If .RowCount > 0 Then
                objMenu.Clear()
                objMenu.LoadCode(objApps, .Columns("Code").Text)
                If objMenu.ErrID = 0 Then
                    objUser.Menu_Add(objMenu)
                    If objUser.ErrID = 0 Then
                        CallerForm.ApplicationMenu()
                        Close()
                    Else
                        ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objMenu.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

End Class