Imports simpi.GlobalUtilities
Imports simpi.MasterReferral

Public Class FormReferralEdit
    Public CallerForm As FormReferralMaintenance
    Public objReferral As MasterReferral

    Public Sub ReferralLoad()
        If objReferral.GetReferralID = 0 Then
            Close()
        Else
            lblUserLogin.Text = objReferral.GetSimpiUser.GetUserLogin
            lblUserName.Text = objReferral.GetSimpiUser.GetUserName
            txtReferralCode.Text = objReferral.GetReferralCode
            txtTaxID.Text = objReferral.GetTaxID
            txtAddress.Text = objReferral.GetCorrespondenceAddress
            txtPhone.Text = objReferral.GetCorrespondencePhone
            txtEmail.Text = objReferral.GetCorrespondenceEmail
        End If
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        DataSaveProfile()
    End Sub

    Public Sub DataSaveProfile()
        objReferral.Edit(txtAddress.Text, txtPhone.Text, txtEmail.Text, txtTaxID.Text)
        If objReferral.ErrID = 0 Then
            If CallerForm.IsHandleCreated Then CallerForm.ReferralSearch()
            Close()
        Else
            ExceptionMessage.Show(objReferral.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSaveCode_Click(sender As Object, e As EventArgs) Handles btnSaveCode.Click
        DataSaveCode()
    End Sub

    Public Sub DataSaveCode()
        objReferral.SetCode(txtReferralCode.Text)
        If objReferral.ErrID = 0 Then
            If CallerForm.IsHandleCreated Then CallerForm.ReferralSearch()
            Close()
        Else
            ExceptionMessage.Show(objReferral.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class