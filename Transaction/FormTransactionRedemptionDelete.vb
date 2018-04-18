Imports simpi.CoreCapital
Imports simpi.CoreData
Imports simpi.globalutilities

Public Class FormTransactionRedemptionDelete
    Public CallerForm As FormTransactionRedemption
    Public objRedemption As TransactionCapital
    Dim objCapital As New ProcessCapital
    Dim objNAV As New PortfolioNAV
    Dim objPosition As New PositionCapital

    Public Sub RedemptionLoad()
        If objRedemption.TrxID = 0 Then
            Close()
        Else
            'lblPortfolioCode.Text = objRedemption.GetMasterPortfolio.GetPortfolioCode
            'lblPortfolioName.Text = objRedemption.GetMasterPortfolio.GetPortfolioNameFull
            'lblSimpiName.Text = objRedemption.GetMasterPortfolio.GetMasterSimpi.GetSimpiName
            'lblPortfolioCcy.Text = objRedemption.GetMasterPortfolio.GetPortfolioCcy.GetCcy

            'objCapital.GetMasterPortfolio = objRedemption.GetMasterPortfolio
            lblNAVDate.Text = objCapital.GetDateNAV.ToString("dd-MMM-yyyy")
            lblPrice.Text = objCapital.GetUnitPrice.ToString("n4")
            lblTransactionDate.Text = objCapital.GetDateTransaction.ToString("dd-MMM-yyyy")
            '   objNAV.LoadAt(objRedemption.GetMasterPortfolio, objCapital.GetDateTransaction)
            If objNAV.ErrID = 0 Then
                lblNAV.Text = objNAV.GetNAV.ToString("n2")
                lblTotalUnits.Text = objNAV.GetTotalUnit.ToString("n2")
            Else
                lblNAV.Text = "0.00"
                lblTotalUnits.Text = "0.0000"
            End If

            'lblClientCode.Text = objRedemption.GetMasterClient.GetClientCode
            'lblClientName.Text = objRedemption.GetMasterClient.GetClientName
            'lblSalesCode.Text = objRedemption.GetMasterSales.GetSalesCode
            'lblSalesName.Text = objRedemption.GetMasterSales.GetSimpiUser.GetUserName

            lblAmount.Text = objRedemption.GetTrxAmount.ToString("n2")
            lblRedemptionFee.Text = objRedemption.GetRedemptionFeePercentage.ToString("n5")
            lblRedemptionFeeAmount.Text = objRedemption.GetRedemptionFeeAmount.ToString("n2")
            lblNetAmount.Text = objRedemption.GetSubscriptionNet.ToString("n2")
            lblUnit.Text = objRedemption.GetTrxUnit.ToString("n5")

            'lblNotes.Text = objRedemption.get 
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnAcq_Click(sender As Object, e As EventArgs) 

    End Sub
End Class