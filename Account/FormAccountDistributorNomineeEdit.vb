Imports simpi.globalutilities

Public Class FormAccountDistributorNomineeEdit
    Public CallerForm As FormAccountDistributorProfile
    Public objClient As simpi.MasterClient.MasterClientDistributorNominee

    Public Sub ClientLoad()
        'parent
        lblSimpiID.Text = objClient.GetClientParent.GetMasterSimpi.GetSimpiID
        lblSimpiName.Text = objClient.GetClientParent.GetMasterSimpi.GetSimpiName
        lblSalesCode.Text = objClient.GetClientParent.GetMasterSales.GetSalesCode
        lblSalesName.Text = objClient.GetClientParent.GetMasterSales.GetSimpiUser.GetUserName
        lblSalesHead.Text = objClient.GetClientParent.GetMasterSales.GetTreeParentCode
        lblCode.Text = objClient.GetClientParent.GetClientCode
        lblName.Text = objClient.GetClientParent.GetClientName
        lblStatus.Text = objClient.GetClientParent.GetClientStatus.GetStatusCode
        lblRiskCode.Text = objClient.GetClientParent.GetClientRiskLevel.GetRiskCode
        lblCorrespondenceAddress.Text = objClient.GetCorrespondenceAddress & " " &
               objClient.GetCorrespondenceCity & " " & objClient.GetCorrespondenceProvince & " " &
               objClient.GetCorrespondenceCountry.GetCountryName & " " & objClient.GetCorrespondencePostal
        lblCorrespondencePhone.Text = objClient.GetClientParent.GetCorrespondencePhone
        lblCorrespondenceEmail.Text = objClient.GetClientParent.GetCorrespondenceEmail

        'sub
        lblCIFSub.Text = objClient.GetClientCode
        lblNameSub.Text = objClient.GetClientName
        txtNomineeID.Text = objClient.GetNomineeID
        txtNomineeName.Text = objClient.GetNomineeName
        If objClient.GetNomineeType = 1 Then
            rbIndividu.Checked = False
        Else
            rbInstitusi.Checked = True
        End If
        lblValuation.Text = objClient.GetClientCcy.GetCcy
        lblXRate.Text = objClient.GetClientXRate.GetXRateCode
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
            objClient.Edit(lblNameSub.Text, txtNomineeID.Text, txtNomineeName.Text, IIf(rbIndividu.Checked, 1, 2))
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