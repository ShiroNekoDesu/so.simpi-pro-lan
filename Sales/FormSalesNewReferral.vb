Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSimpi
Imports simpi.MasterSales
Imports simpi.globalutilities

Public Class FormSalesNewReferral
    Public CallerForm As FormSalesMaintenance
    Public objSales As MasterSales
    Dim objReferral As New MasterSales
    Dim objSimpi As New MasterSimpi
    Dim objUser As New SimpiUser
    Dim dtSalesTeam As New DataTable

    Public Sub SalesLoad()
        If objSales.GetSalesID > 0 Then
            objSimpi.UserAccess = objAccess
            objUser.UserAccess = objAccess
            objReferral.UserAccess = objAccess
            lblHeadCode.Text = objSales.GetSalesCode
            lblHeadName.Text = objSales.GetSimpiUser.GetUserName
            lblSalesLevel.Text = objSales.GetTreeLevel
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ReferralSearch()
    End Sub

    Private Sub ReferralSearch()
        Dim form As New FormSelectMasterSimpiReferral
        form.Show()
        form.lblSimpiEmail = lblSimpiEmail
        form.lblSimpiName = lblSimpiName
        form.MdiParent = MDISO
        lblSimpiEmail.Text = ""
        lblSimpiName.Text = ""
        objSimpi.Clear()
    End Sub

    Private Sub lblSimpiName_TextChanged(sender As Object, e As EventArgs) Handles lblSimpiName.TextChanged
        ReferralLoad()
    End Sub

    Private Sub ReferralLoad()
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
                dtLicenseExpired.Text = objSimpi.GetHeadLicenseExpired
                txtLicenseIssuer.Text = objSimpi.GetHeadLicenseIssuer
                objReferral.Clear()
                objReferral.Load(objSimpi, objSimpi.GetHeadCode)
                dtSalesTeam = objReferral.SearchAll("")
                DisplayTeam()
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DisplayTeam()
        If dtSalesTeam.Rows.Count > 0 Then
            lblNumberTeam.Text = dtSalesTeam.Rows.Count
            Dim query = From p In dtSalesTeam.AsEnumerable
                        Join s In dtParameterClientStatus.AsEnumerable On
                                  p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Select
                             ID = p.Field(Of Integer)("SalesID"),
                             Name = p.Field(Of String)("UserName"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGTeam
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGTeam.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            lblNumberTeam.Text = "0"
            DBGTeam.Columns.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If Not IsNumeric(txtNumberStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " sales code starting number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not IsNumeric(txtNumberLength.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " sales code length number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'objSales.AddSales(dtSalesTeam, txtPrefix.Text.Trim, CInt(txtNumberStart.Text), CInt(txtNumberLength.Text))
        If objSales.ErrID = 0 Then
            If CallerForm.IsHandleCreated Then CallerForm.SalesSearch()
            Close()
        Else
            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class