Imports simpi.SimpiMaster
Imports simpi.globalutilities

Public Class FormSimpiUserNew
    Public CallerForm As FormSimpiUser
    Dim objUser As New SimpiUser

    Private Sub FormSimpiUserNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        lblID.Text = objSimpi.GetSimpiID
        lblType.Text = objSimpi.GetSimpiType.GetTypeCode
        lblName.Text = objSimpi.GetSimpiName
        lblStatus.Text = objSimpi.GetSimpiStatus.GetStatusCode
        objUser.UserAccess = objAccess
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UserSave()
    End Sub

    Private Sub UserSave()
        objUser.Clear()
        objUser.Add(txtUserLogin.Text, txtUserName.Text, txtUserTitle.Text, txtUserInitial.Text)
        If objUser.ErrID = 0 Then
            CallerForm.UserSearch()
            Close()
        Else
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class