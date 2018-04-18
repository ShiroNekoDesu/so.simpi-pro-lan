Imports simpi.GlobalCore

Public Class FormBondCalculator
    Private Sub rbPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbPrice.SelectedIndexChanged
        optionSelect()
    End Sub

    Private Sub rbYTM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbYTM.SelectedIndexChanged
        optionSelect()
    End Sub

    Private Sub optionSelect()
        If rbPrice.Checked Then
            txtPrice.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtYield.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtPrice.Text = ""
            lblPriceTitle.Text = "YTM: "
        Else
            txtPrice.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
            txtYield.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            txtPrice.Text = ""
            lblPriceTitle.Text = "Price: "
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If rbPrice.Checked Then calculateYTM() Else calculatePrice()
    End Sub

    Private Sub calculateYTM()
        Dim coupon, price As Double
        Dim freq As Integer
        Double.TryParse(txtCoupon.Text, coupon)
        Double.TryParse(txtPrice.Text, price)
        Int32.TryParse(txtFrequency.Text, freq)
        lblPriceValue.Text = (GlobalBond.Yield_Maturity(objError, dtSettlement.Value, dtMaturity.Value,
                             coupon / 100, price / 100, freq, cmbDIM.Text, cmbDIY.Text) * 100).ToString("n2")
        lblDuration.Text = GlobalBond.Duration_Modified(objError, dtSettlement.Value, dtMaturity.Value,
                           coupon / 100, price / 100, freq, cmbDIM.Text, cmbDIY.Text).ToString("n2")
    End Sub

    Private Sub calculatePrice()
        Dim coupon, yield As Double
        Dim freq As Integer
        Double.TryParse(txtCoupon.Text, coupon)
        Double.TryParse(txtYield.Text, yield)
        Int32.TryParse(txtFrequency.Text, freq)
        lblPriceValue.Text = (GlobalBond.Price_Yield(objError, dtSettlement.Value, dtMaturity.Value,
                             coupon / 100, yield / 100, freq, cmbDIM.Text, cmbDIY.Text) * 100).ToString("n2")
        lblDuration.Text = GlobalBond.Duration_Modified(objError, dtSettlement.Value, dtMaturity.Value,
                             coupon / 100, CDbl(lblPriceValue.Text) / 100, freq, cmbDIM.Text, cmbDIY.Text).ToString("n2")
    End Sub

End Class
