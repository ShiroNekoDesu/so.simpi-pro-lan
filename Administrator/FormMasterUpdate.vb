Imports simpi.globalutilities

Public Class FormMasterUpdate

    Private Sub FormMasterUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLoad()
    End Sub

    Private Sub UpdateLoad()
        lblPortfolio.Text = dtPortfolioMaster.Rows.Count
        lblPortfolioBankAccount.Text = dtPortfolioBankAccount.Rows.Count
        lblPortfolioCodeset.Text = dtPortfolioCodeset.Rows.Count
        lblPortfolioExternalID.Text = dtPortfolioExternalID.Rows.Count

        lblPortfolioStatus.Text = dtParameterPortfolioStatus.Rows.Count
        lblPortfolioAsset.Text = dtParameterPortfolioAsset.Rows.Count
        lblPortfolioCharges.Text = dtParameterPortfolioFee.Rows.Count
        lblPortfolioType.Text = dtParameterPortfolioType.Rows.Count
        lblPortfolioPricing.Text = dtParameterPortfolioPricing.Rows.Count

        lblSales.Text = dtSalesMaster.Rows.Count
        lblSalesCodeset.Text = dtSalesCodeset.Rows.Count

        lblClient.Text = dtClientMaster.Rows.Count
        lblClientKYC.Text = dtClientKYC.Rows.Count
        lblClientStatus.Text = dtParameterClientStatus.Rows.Count
        lblClientDocument.Text = dtParameterClientDocumentType.Rows.Count
        lblClientReligion.Text = dtParameterClientReligion.Rows.Count
        lblClientType.Text = dtParameterClientType.Rows.Count
    End Sub

    Private Sub btnPortfolioAll_Click(sender As Object, e As EventArgs) Handles btnPortfolioAll.Click
        GetPortfolioMasterUpdate()
        GetPortfolioBankAccountUpdate()
        GetPortfolioCodetsetUpdate()
        GetPortfolioExternalIDUpdate()

        GetParameterPortfolioStatusUpdate()
        GetParameterPortfolioAssetTypeUpdate()
        GetParameterPortfolioFeeUpdate()
        GetParameterPortfolioTypeUpdate()
        GetParameterPortfolioPricingUpdate()
        ExceptionMessage.Show("Finished update all portfolio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolio_Click(sender As Object, e As EventArgs) Handles btnPortfolio.Click
        GetPortfolioMasterUpdate()
        ExceptionMessage.Show("Finished update master portfolio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioBankAccount_Click(sender As Object, e As EventArgs) Handles btnPortfolioBankAccount.Click
        GetPortfolioBankAccountUpdate()
        ExceptionMessage.Show("Finished update portfolio bank account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioStatus_Click(sender As Object, e As EventArgs) Handles btnPortfolioStatus.Click
        GetParameterPortfolioStatusUpdate()
        ExceptionMessage.Show("Finished update portfolio status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioAsset_Click(sender As Object, e As EventArgs) Handles btnPortfolioAsset.Click
        GetParameterPortfolioAssetTypeUpdate()
        ExceptionMessage.Show("Finished update portfolio asset type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioCharges_Click(sender As Object, e As EventArgs) Handles btnPortfolioCharges.Click
        GetParameterPortfolioFeeUpdate()
        ExceptionMessage.Show("Finished update portfolio charges", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioType_Click(sender As Object, e As EventArgs) Handles btnPortfolioType.Click
        GetParameterPortfolioTypeUpdate()
        ExceptionMessage.Show("Finished update portfolio type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioCodeset_Click(sender As Object, e As EventArgs) Handles btnPortfolioCodeset.Click
        GetPortfolioCodetsetUpdate()
        ExceptionMessage.Show("Finished update portfolio codeset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioPricing_Click(sender As Object, e As EventArgs) Handles btnPortfolioPricing.Click
        GetParameterPortfolioPricingUpdate()
        ExceptionMessage.Show("Finished update portfolio pricing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnPortfolioID_Click(sender As Object, e As EventArgs) Handles btnPortfolioID.Click
        GetPortfolioExternalIDUpdate()
        ExceptionMessage.Show("Finished update portfolio external identification", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnSalesAll_Click(sender As Object, e As EventArgs) Handles btnSalesAll.Click
        GetSalesMasterUpdate()
        GetSalesCodesetUpdate()
        ExceptionMessage.Show("Finished update all sales", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        GetSalesMasterUpdate()
        ExceptionMessage.Show("Finished update master sales", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnSalesCodeset_Click(sender As Object, e As EventArgs) Handles btnSalesCodeset.Click
        GetSalesCodesetUpdate()
        ExceptionMessage.Show("Finished update sales codeset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClientAll_Click(sender As Object, e As EventArgs) Handles btnClientAll.Click
        GetClientMasterUpdate()
        GetClientKYCUpdate()
        GetParameterClientStatusUpdate()
        GetParameterClientTypeUpdate()
        GetParameterClientReligionUpdate()
        GetParameterClientDocumentTypeUpdate()
        ExceptionMessage.Show("Finished update all client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClientKYC_Click(sender As Object, e As EventArgs) Handles btnClientKYC.Click
        GetClientKYCUpdate()
        ExceptionMessage.Show("Finished update client kyc", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        GetClientMasterUpdate()
        ExceptionMessage.Show("Finished update master client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClientStatus_Click(sender As Object, e As EventArgs) Handles btnClientStatus.Click
        GetParameterClientStatusUpdate()
        ExceptionMessage.Show("Finished update client status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClientType_Click(sender As Object, e As EventArgs) Handles btnClientType.Click
        GetParameterClientTypeUpdate()
        ExceptionMessage.Show("Finished update client type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClientReligion_Click(sender As Object, e As EventArgs) Handles btnClientReligion.Click
        GetParameterClientReligionUpdate()
        ExceptionMessage.Show("Finished update client religion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub

    Private Sub btnClientDocument_Click(sender As Object, e As EventArgs) Handles btnClientDocument.Click
        GetParameterClientDocumentTypeUpdate()
        ExceptionMessage.Show("Finished update client document", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateLoad()
    End Sub
End Class