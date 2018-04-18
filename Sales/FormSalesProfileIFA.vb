Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSales
Imports simpi.globalutilities

Public Class FormSalesProfileIFA
    Public CallerForm As FormSalesMaintenance
    Public objSales As MasterSales

    Public Sub SalesLoad()
        If objSales.GetSalesID > 0 Then
            lblSimpiName.Text = objSales.GetSimpiUser.GetMasterSimpi.GetSimpiName
            lblHeadCode.Text = objSales.GetTreeParentCode
            lblHeadName.Text = objSales.GetTreeParentName
            lblSalesLevel.Text = objSales.GetTreeLevel
            lblSalesCode.Text = objSales.GetSalesCode
            lblSalesName.Text = objSales.GetSimpiUser.GetUserName
            lblStatus.Text = objSales.GetSimpiUser.GetUserStatus.GetStatusCode
            lblTaxID.Text = objSales.GetTaxID
            lblLicenseNo.Text = objSales.GetLicenseNo
            lblLicenseExpired.Text = objSales.GetLicenseExpired.ToString("dd-MMM-yyyy")
            lblAddress.Text = objSales.GetCorrespondenceAddress
            lblPhone.Text = objSales.GetCorrespondencePhone
            lblEmail.Text = objSales.GetCorrespondenceEmail
            lblSalesSpan.Text = "0"
        Else
            Close()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SalesEdit()
    End Sub

    Private Sub SalesEdit()
        Dim frm As New FormSalesEditIFA
        frm.Show()
        frm.objSales = objSales
        frm.SalesLoad()
        frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

    Private Sub btnAddReferral_Click(sender As Object, e As EventArgs) Handles btnAddReferral.Click
        Dim frm As New FormSalesFeeReferral
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddSharing_Click(sender As Object, e As EventArgs) Handles btnAddSharing.Click
        Dim frm As New FormSalesFeeSharing
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddMulti_Click(sender As Object, e As EventArgs) Handles btnAddMulti.Click
        Dim frm As New FormSalesFeeMulti
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddSubscription_Click(sender As Object, e As EventArgs) Handles btnAddSubscription.Click
        Dim frm As New FormSalesFeeIncentive
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddSellingFee_Click(sender As Object, e As EventArgs) Handles btnAddSellingFee.Click
        Dim frm As New FormSalesFeeSelling
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

End Class