Imports simpi.globalutilities
Imports simpi.MasterSales

Public Class FormSalesEdit
    Public CallerForm As FormSalesMaintenance
    Public objSales As MasterSales

    Public Sub SalesLoad()
        If objSales.GetSalesID = 0 Then
            Close()
        Else
            lblHeadCode.Text = objSales.GetTreeParentCode
            lblHeadName.Text = objSales.GetTreeParentName
            lblSalesLevel.Text = objSales.GetTreeLevel
            lblUserLogin.Text = objSales.GetSimpiUser.GetUserLogin
            lblUserName.Text = objSales.GetSimpiUser.GetUserName
            txtSalesCode.Text = objSales.GetSalesCode
            txtTaxID.Text = objSales.GetTaxID
            txtAddress.Text = objSales.GetCorrespondenceAddress
            txtPhone.Text = objSales.GetCorrespondencePhone
            txtEmail.Text = objSales.GetCorrespondenceEmail
            txtLicenseNo.Text = objSales.GetLicenseNo
            dtExpired.Value = objSales.GetLicenseExpired
            txtLicenseIssuer.Text = objSales.GetLicenseIssuer
        End If
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        DataSaveProfile()
    End Sub

    Public Sub DataSaveProfile()
        objSales.Edit(txtAddress.Text, txtPhone.Text, txtEmail.Text,
                      txtTaxID.Text, txtLicenseNo.Text, dtExpired.Value, txtLicenseIssuer.Text)
        If objSales.ErrID = 0 Then
            If CallerForm.IsHandleCreated Then
                CallerForm.SalesSearch()
            End If
            Close()
        Else
            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSaveCode_Click(sender As Object, e As EventArgs) Handles btnSaveCode.Click
        DataSaveCode()
    End Sub

    Public Sub DataSaveCode()
        objSales.SetCode(txtSalesCode.Text)
        If objSales.ErrID = 0 Then
            If CallerForm.IsHandleCreated Then
                CallerForm.SalesSearch()
            End If
            Close()
        Else
            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class