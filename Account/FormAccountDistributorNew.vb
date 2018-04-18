Imports simpi.globalutilities
Imports simpi.MasterSecurities
Imports simpi.ParameterClient

Public Class FormAccountDistributorNew
    Public CallerForm As FormAccountMaintenance
    Dim objSales As New simpi.MasterSales.MasterSales
    Dim objClient As New simpi.MasterClient.MasterClientDistributor

    Private Sub FormAccountDistributorNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        lblSimpiID.Text = objMasterSimpi.GetSimpiID
        lblSimpiName.Text = objMasterSimpi.GetSimpiName

        GetComboInit(New ParameterCountry, cmbAddressCountry, "CountryID", "CountryName")
        cmbAddressCountry.SelectedIndex = -1
        GetComboInit(New ParameterCountry, cmbValuation, "CountryID", "Ccy")
        GetComboInit(New ParameterXRate, cmbXRate, "XRateID", "XRateCode")
        GetComboInit(New ParameterBusinessActivity, cmbBusinessActivity, "ActivityID", "ActivityCode")
        GetComboInit(New ParameterBusinessType, cmbBusinessType, "TypeID", "TypeCode")

        objSales.UserAccess = objAccess
        objClient.UserAccess = objAccess
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub


#Region "sales"
    Private Sub btnSearchSales_Click(sender As Object, e As EventArgs) Handles btnSearchSales.Click
        SalesSearch()
    End Sub

    Private Sub SalesSearch()
        Dim form As New FormSelectMasterSales
        form.Show()
        form.lblSalesCode = lblSalesCode
        form.lblSalesName = lblSalesName
        form.MdiParent = MDISO
        lblSalesCode.Text = ""
        lblSalesName.Text = ""
        lblSalesHead.Text = ""
        objSales.Clear()
    End Sub

    Private Sub lblSalesCode_TextChanged(sender As Object, e As EventArgs) Handles lblSalesCode.TextChanged
        SalesLoad()
    End Sub

    Private Sub SalesLoad()
        If lblSalesCode.Text.Trim <> "" Then
            objSales.Clear()
            objSales.Load(objMasterSimpi, lblSalesCode.Text)
            If objSales.ErrID = 0 Then
                lblSalesHead.Text = objSales.GetTreeParentCode
            Else
                ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        clientname
    End Sub

    Private Sub ClientName()
        lblName.Text = txtName.Text
    End Sub

#Region "address"
    Private Sub txtAddressStreet_TextChanged(sender As Object, e As EventArgs) Handles txtAddressStreet.TextChanged
        ClientAddress()
    End Sub

    Private Sub txtAddressCity_TextChanged(sender As Object, e As EventArgs) Handles txtAddressCity.TextChanged
        ClientAddress()
    End Sub

    Private Sub txtAddressState_TextChanged(sender As Object, e As EventArgs) Handles txtAddressState.TextChanged
        ClientAddress()
    End Sub

    Private Sub txtAddressPostal_TextChanged(sender As Object, e As EventArgs) Handles txtAddressPostal.TextChanged
        ClientAddress()
    End Sub

    Private Sub cmbAddressCountry_TextChanged(sender As Object, e As EventArgs) Handles cmbAddressCountry.TextChanged
        ClientAddress()
    End Sub

    Private Sub ClientAddress()
        lblCorrespondenceAddress.Text = txtAddressStreet.Text.Trim & " " & txtAddressCity.Text.Trim & " " &
                       txtAddressState.Text.Trim & " " & cmbAddressCountry.Text.Trim & " " & txtAddressPostal.Text.Trim
    End Sub

#End Region

#Region "save"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Function _check() As Boolean
        If objSales.GetSalesID = 0 Then
            ExceptionMessage.Show(objError.Message(81) & " master sales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbValuation.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " client valuation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbXRate.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " client exchange currency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbAddressCountry.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " address country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbBusinessActivity.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " business activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbBusinessType.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " business type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub DataSave()
        If _check() Then
            objClient.Clear()
            objClient.Add(objMasterSimpi, objSales, txtName.Text, cmbValuation.SelectedValue, 1, cmbXRate.SelectedValue,
                          IIf(rbLocal.Checked, "L"c, "F"c), txtAddressStreet.Text, txtAddressCity.Text,
                          txtAddressState.Text, cmbAddressCountry.SelectedValue, txtAddressPostal.Text, txtPhone.Text,
                          txtEmail.Text, txtContactPerson.Text, txtSignatureRule.Text, txtTaxID.Text,
                          cmbBusinessType.SelectedValue, cmbBusinessActivity.SelectedValue)
            If objClient.ErrID = 0 Then
                CallerForm.ClientSearch()
                Close()
            Else
                ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

End Class