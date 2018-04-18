Imports simpi.MasterSimpi
Imports simpi.MasterSales
Imports simpi.globalutilities

Public Class FormSalesNew
    Public CallerForm As FormSalesMaintenance
    Public objSales As MasterSales
    Dim objUser As New SimpiUser

    Public Sub SalesLoad()
        GetMasterSimpi()
        objUser.UserAccess = objAccess
        dtExpired.Value = Now
        If objSales.GetSalesID > 0 Then
            lblHeadCode.Text = objSales.GetSalesCode
            lblHeadName.Text = objSales.GetSimpiUser.GetUserName
            lblSalesLevel.Text = objSales.GetTreeLevel
        Else
            lblHeadCode.Text = ""
            lblHeadName.Text = ""
            lblSalesLevel.Text = ""
        End If
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
            If objSales.GetSalesID = 0 Then
                objSales.AddHead(objMasterSimpi, objUser, txtSalesCode.Text, txtAddress.Text, txtPhone.Text,
                         txtEmail.Text, txtTaxID.Text, txtLicenseNo.Text, dtExpired.Value, txtLicenseIssuer.Text)
            Else
                objSales.AddSales(objUser, txtSalesCode.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text,
                                  txtTaxID.Text, txtLicenseNo.Text, dtExpired.Value, txtLicenseIssuer.Text)
            End If
            If objSales.ErrID = 0 Then
                If CallerForm.IsHandleCreated Then CallerForm.SalesSearch()
                Close()
            Else
                ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class