Imports C1.Win.C1TrueDBGrid
Imports simpi.SystemSecurity
Imports simpi.globalutilities
Imports simpi.SimpiMaster

Public Class FormSimpiUserProfileApplication
    Public objUser As SimpiUser
    Public CallerForm As FormSimpiUserProfile
    Dim objApps As New SystemApplication

    Public Sub ApplicationLoad()
        If objUser.GetUserID > 0 Then
            lblIDUser.Text = objUser.GetUserID
            lblLoginUser.Text = objUser.GetUserLogin
            lblStatusUser.Text = objUser.GetUserStatus.GetStatusCode

            btnAdd.Enabled = False
            DBGApplication.FetchRowStyles = True
            objApps.UserAccess = objAccess
            ApplicationSearch()
        Else
            Close()
        End If
    End Sub

    Private Sub ApplicationSearch()
        Dim tbl As New DataTable
        tbl = objUser.Application_SearchAppsAvailable()
        If objUser.ErrID = 0 Then
            Dim query = From a In tbl.AsEnumerable
                        Select
                            ID = a.Field(Of Integer)("AppsID"),
                            Code = a.Field(Of String)("AppsCode"),
                            Name = a.Field(Of String)("AppsName"),
                            IsPublic = IIf(a.Field(Of SByte)("IsPublic") = 0, "N", "Y")

            With DBGApplication
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGApplication.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGApplication.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DBGApplication_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGApplication.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGApplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGApplication.Click
        With DBGApplication
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnAdd.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGApplication_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGApplication.DoubleClick
        ApplicationAdd()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ApplicationAdd()
    End Sub

    Private Sub ApplicationAdd()
        With DBGApplication
            If .RowCount > 0 Then
                objApps.Clear()
                objApps.LoadCode(.Columns("Code").Text)
                If objApps.ErrID = 0 Then
                    objUser.Application_Add(objApps)
                    If objUser.ErrID = 0 Then
                        CallerForm.UserApplication()
                        Close()
                    Else
                        ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objApps.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

End Class