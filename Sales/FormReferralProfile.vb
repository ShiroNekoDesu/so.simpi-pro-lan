Imports simpi.MasterReferral

Public Class FormReferralProfile
    Public CallerForm As FormReferralMaintenance
    Public objReferral As MasterReferral

    Public Sub ReferralLoad()
        If objReferral.GetReferralID > 0 Then
            lblSimpiName.Text = objReferral.GetSimpiUser.GetMasterSimpi.GetSimpiName
            lblReferralCode.Text = objReferral.GetReferralCode
            lblReferralName.Text = objReferral.GetSimpiUser.GetUserName
            lblStatus.Text = objReferral.GetSimpiUser.GetUserStatus.GetStatusCode
            lblTaxID.Text = objReferral.GetTaxID
            lblAddress.Text = objReferral.GetCorrespondenceAddress
            lblPhone.Text = objReferral.GetCorrespondencePhone
            lblEmail.Text = objReferral.GetCorrespondenceEmail

            GetMasterSimpi()
            GetParameterClientStatus()
        Else
            Close()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ReferralEdit()
    End Sub

    Private Sub ReferralEdit()
        Dim frm As New FormReferralEdit
        frm.Show()
        frm.objReferral = objReferral
        frm.ReferralLoad()
        frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

End Class