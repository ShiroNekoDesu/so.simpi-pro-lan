Imports simpi.globalutilities
Imports simpi.SimpiMaster

Public Class FormSimpiUserEdit
    Public CallerForm As FormSimpiUser
    Public objUser As SimpiUser

    Public Sub UserLoad()
        If objUser.GetUserID > 0 Then
            lblID.Text = objUser.GetMasterSimpi.GetSimpiID
            lblType.Text = objUser.GetMasterSimpi.GetSimpiType.GetTypeCode
            lblName.Text = objUser.GetMasterSimpi.GetSimpiName
            lblStatus.Text = objSimpi.GetSimpiStatus.GetStatusCode
            lblUserLogin.Text = objUser.GetUserLogin
            txtUserName.Text = objUser.GetUserName
            txtUserTitle.Text = objUser.GetUserTitle
            txtUserInitial.Text = objUser.GetUserInitial
        Else
            Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UserSave()
    End Sub

    Private Sub UserSave()
        objUser.Edit(txtUserName.Text, txtUserTitle.Text, txtUserInitial.Text)
        If objUser.ErrID = 0 Then
            CallerForm.UserSearch()
            Close()
        Else
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class