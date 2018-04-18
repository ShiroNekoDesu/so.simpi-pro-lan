Imports simpi.globalutilities

Public Class FormAccountDistributorNomineeAdd
    Public CallerForm As FormAccountDistributorProfile
    Public objParent As simpi.MasterClient.MasterClientDistributor
    Dim objClient As New simpi.MasterClient.MasterClientDistributorNominee

    Public Sub ParentLoad()
        If objParent.GetClientID = 0 Then
            Close()
        Else
            lblSimpiID.Text = objParent.GetMasterSimpi.GetSimpiID
            lblSimpiName.Text = objParent.GetMasterSimpi.GetSimpiName
            lblSalesCode.Text = objParent.GetMasterSales.GetSalesCode
            lblSalesName.Text = objParent.GetMasterSales.GetSimpiUser.GetUserName
            lblSalesHead.Text = objParent.GetMasterSales.GetTreeParentCode
            lblCode.Text = objParent.GetClientCode
            lblName.Text = objParent.GetClientName
            lblStatus.Text = objParent.GetClientStatus.GetStatusCode
            lblRiskCode.Text = objParent.GetClientRiskLevel.GetRiskCode
            lblCorrespondenceAddress.Text = objParent.GetCorrespondenceAddress & " " &
                   objParent.GetCorrespondenceCity & " " & objParent.GetCorrespondenceProvince & " " &
                   objParent.GetCorrespondenceCountry.GetCountryName & " " & objParent.GetCorrespondencePostal
            lblCorrespondencePhone.Text = objParent.GetCorrespondencePhone
            lblCorrespondenceEmail.Text = objParent.GetCorrespondenceEmail
            lblValuation.Text = objParent.GetClientCcy.GetCcy
            lblXRate.Text = objParent.GetClientXRate.GetXRateCode

            objClient.UserAccess = objAccess
        End If
    End Sub

    Private Sub txtSubName_TextChanged(sender As Object, e As EventArgs) Handles txtNomineeName.TextChanged
        ClientName()
    End Sub

    Private Sub ClientName()
        lblNameSub.Text = txtNomineeName.Text.Trim
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Function _check() As Boolean
        If txtNomineeID.Text.Trim = "" Then
            ExceptionMessage.Show(objError.Message(81) & " NomineeID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If txtNomineeName.Text.Trim = "" Then
            ExceptionMessage.Show(objError.Message(81) & " nominee name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub DataSave()
        If _check() Then
            objClient.Clear()
            objClient.Add(objParent, lblNameSub.Text,
                          txtNomineeID.Text, txtNomineeName.Text, IIf(rbIndividu.Checked, 1, 2))
            If objClient.ErrID = 0 Then
                CallerForm.SubAccountSearch()
                Close()
            Else
                ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class