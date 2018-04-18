Imports simpi.CoreCapital
Imports simpi.CoreData
Imports simpi.globalutilities

Public Class FormTransactionSubscriptionDelete
    Public CallerForm As FormTransactionSubscription
    Public objSubscription As TransactionCapital
    Dim objCapital As New ProcessCapital
    Dim objNAV As New PortfolioNAV
    Dim objPosition As New PositionCapital

    Public Sub SubscriptionLoad()
        If objSubscription.TrxID = 0 Then
            Close()
        Else
            'lblPortfolioCode.Text = objSubscription.GetMasterPortfolio.GetPortfolioCode
            'lblPortfolioName.Text = objSubscription.GetMasterPortfolio.GetPortfolioNameFull
            'lblSimpiName.Text = objSubscription.GetMasterPortfolio.GetMasterSimpi.GetSimpiName
            'lblPortfolioCcy.Text = objSubscription.GetMasterPortfolio.GetPortfolioCcy.GetCcy

            ' objCapital.GetMasterPortfolio = objSubscription.GetMasterPortfolio
            lblNAVDate.Text = objCapital.GetDateNAV.ToString("dd-MMM-yyyy")
            lblPrice.Text = objCapital.GetUnitPrice.ToString("n4")
            lblTransactionDate.Text = objCapital.GetDateTransaction.ToString("dd-MMM-yyyy")
            ' objNAV.LoadAt(objSubscription.GetMasterPortfolio, objCapital.GetDateTransaction)
            If objNAV.ErrID = 0 Then
                lblNAV.Text = objNAV.GetNAV.ToString("n2")
                lblTotalUnits.Text = objNAV.GetTotalUnit.ToString("n2")
            Else
                lblNAV.Text = "0.00"
                lblTotalUnits.Text = "0.0000"
            End If

            'lblClientCode.Text = objSubscription.GetMasterClient.GetClientCode
            'lblClientName.Text = objSubscription.GetMasterClient.GetClientName
            'lblSalesCode.Text = objSubscription.GetMasterSales.GetSalesCode
            'lblSalesName.Text = objSubscription.GetMasterSales.GetSimpiUser.GetUserName

            lblAmount.Text = objSubscription.GetTrxAmount.ToString("n2")
            lblSellingFee.Text = objSubscription.GetSellingFeePercentage.ToString("n5")
            lblSellingFeeAmount.Text = objSubscription.GetSellingFeeAmount.ToString("n2")
            lblNetAmount.Text = objSubscription.GetSubscriptionNet.ToString("n2")
            lblUnit.Text = objSubscription.GetTrxUnit.ToString("n5")

            'lblNotes.Text = objSubscription.get 
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class