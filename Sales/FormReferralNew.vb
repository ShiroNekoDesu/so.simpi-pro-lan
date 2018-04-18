Imports simpi.MasterSimpi
Imports simpi.MasterReferral
Imports simpi.GlobalUtilities

Public Class FormReferralNew
    Public CallerForm As FormReferralMaintenance
    Dim objUser As New SimpiUser
    Dim objReferral As New MasterReferral

    Private Sub FormReferralNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        objUser.UserAccess = objAccess
        objReferral.UserAccess = objAccess
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        UserSearch()
    End Sub

    Private Sub UserSearch()
        Dim form As New FormSelectUser
        form.Show()
        form.lblCode = lblUserLogin
        form.lblName = lblUserName
        form.MdiParent = MDISO
        lblUserLogin.Text = ""
        lblUserName.Text = ""
        objUser.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        objUser.Clear()
        objUser.Load(lblUserLogin.Text)
        If objUser.ErrID = 0 Then
            objReferral.Add(objMasterSimpi, objUser, txtReferralCode.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, txtTaxID.Text)
            If objReferral.ErrID = 0 Then
                If CallerForm.IsHandleCreated Then CallerForm.ReferralSearch()
                Close()
            Else
                ExceptionMessage.Show(objReferral.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class