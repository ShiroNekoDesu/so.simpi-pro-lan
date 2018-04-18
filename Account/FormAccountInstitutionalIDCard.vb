Imports simpi.globalutilities
Imports simpi.ParameterClient
Imports simpi.MasterClient

Public Class FormAccountInstitutionalIDCard
    Public objOfficer As ClientOfficer

    Public Sub IDCardLoad()
        GetComboInit(New ParameterIDCardType, cmbIDCardType, "TypeID", "TypeCode")
        cmbIDCardType.Text = objOfficer.GetIDCardType.GetTypeCode
        txtIDCardNo.Text = objOfficer.GetIDCardNo
        txtIDCardIssuer.Text = objOfficer.GetIDCardIssuer
        dtIDCardExpired.Value = objOfficer.GetIDCardExpired
        chkIDCardIsExpired.Checked = objOfficer.GetIDCardIsExpired
    End Sub

    Private Sub btnSaveIDCard_Click(sender As Object, e As EventArgs) Handles btnSaveIDCard.Click
        IDCardSave
    End Sub

    Private Sub IDCardSave()
        If cmbIDCardType.SelectedIndex <> -1 Then
            objOfficer.SetIDCard(cmbIDCardType.SelectedValue, txtIDCardNo.Text, txtIDCardIssuer.Text,
                                IIf(chkIDCardIsExpired.Checked, 1, 0), dtIDCardExpired.Value)
            If objOfficer.ErrID = 0 Then
                Close()
            Else
                ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class