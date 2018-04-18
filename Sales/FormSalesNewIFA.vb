Imports simpi.MasterSimpi
Imports simpi.MasterSales
Imports simpi.globalutilities

Public Class FormSalesNewIFA
    Public CallerForm As FormSalesMaintenance
    Public objSales As MasterSales
    Dim objSimpi As New MasterSimpi
    Dim objUser As New SimpiUser

    Public Sub SalesLoad()
        If objSales.GetSalesID > 0 Then
            objSimpi.UserAccess = objAccess
            objUser.UserAccess = objAccess
            lblHeadCode.Text = objSales.GetSalesCode
            lblHeadName.Text = objSales.GetSimpiUser.GetUserName
            lblSalesLevel.Text = objSales.GetTreeLevel
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        IFASearch()
    End Sub

    Private Sub IFASearch()
        Dim form As New FormSelectMasterSimpiIFA
        form.Show()
        form.lblSimpiEmail = lblSimpiEmail
        form.lblSimpiName = lblSimpiName
        form.MdiParent = MDISO
        lblSimpiEmail.Text = ""
        lblSimpiName.Text = ""
        objSimpi.Clear()
    End Sub

    Private Sub lblSimpiName_TextChanged(sender As Object, e As EventArgs) Handles lblSimpiName.TextChanged
        IFALoad()
    End Sub

    Private Sub IFALoad()
        If lblSimpiEmail.Text.Trim <> "" Then
            objSimpi.Clear()
            objSimpi.Load(lblSimpiEmail.Text)
            If objSimpi.ErrID = 0 Then
                lblUserLogin.Text = objSimpi.GetHeadLogin
                lblUserName.Text = objSimpi.GetHeadName
                txtTaxID.Text = objSimpi.GetHeadTaxID
                txtAddress.Text = objSimpi.GetHeadAddress
                txtPhone.Text = objSimpi.GetHeadPhone
                txtEmail.Text = objSimpi.GetHeadEmail
                txtLicenseNo.Text = objSimpi.GetHeadLicenseNo
                dtExpired.Text = objSimpi.GetHeadLicenseExpired
                txtLicenseIssuer.Text = objSimpi.GetHeadLicenseIssuer
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        objUser.Clear()
        objUser.Load(lblUserLogin.Text)
        If objUser.ErrID = 0 Then
            objSales.AddSales(objUser, txtSalesCode.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text,
                             txtTaxID.Text, txtLicenseNo.Text, dtExpired.Value, txtLicenseIssuer.Text)
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