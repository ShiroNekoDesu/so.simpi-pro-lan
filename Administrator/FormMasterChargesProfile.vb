Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.ParameterFA
Imports simpi.MasterPortfolio
Imports simpi.CoreBilling

Public Class FormMasterChargesProfile
    Public CallerForm As FormMasterCharges
    Public objPortfolio As MasterPortfolio
    Public FeeID As Integer
    Dim objManagement As New FundSetting
    Dim objFee As New ParameterCharges

    Public Sub FormLoad()
        PortfolioLoad()
        objFee.UserAccess = objAccess
        objFee.LoadID(FeeID)
        If objFee.ErrID = 0 Then
            lblFeeCode.Text = objFee.GetFeeCode
            lblFeeName.Text = objFee.GetFeeDescription
        End If
        GetComboInit(New ParameterCharges, cmbVAT, "FeeID", "FeeCode")
        GetComboInit(New ParameterCharges, cmbIncomeTax, "FeeID", "FeeCode")
        FeeLoad()
    End Sub

    Private Sub PortfolioLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            lblPortfolioID.Text = objPortfolio.GetPortfolioID
            lblPortfolioCode.Text = objPortfolio.GetPortfolioCode
            lblPortfolioType.Text = objPortfolio.GetPortfolioType.GetTypeCode
            lblPortfolioShortname.Text = objPortfolio.GetPortfolioNameShort
            lblPortfolioStatus.Text = objPortfolio.GetPortfolioStatus.GetStatusCode
            lblPortfolioName.Text = objPortfolio.GetPortfolioNameFull
            lblCcy.Text = objPortfolio.GetPortfolioCcy.GetCcy
        Else
            Close()
        End If
    End Sub

    Private Sub FeeLoad()
        objManagement.UserAccess = objAccess
        objManagement.Load(objPortfolio, FeeID)
        If objManagement.ErrID = 0 Then
            If objManagement.IsChargesAccrualBasis Then rbBasisAccrual.Checked = True Else rbBasisCash.Checked = True
            If objManagement.IsChargesAccrualDaily Then rbAccualDaily.Checked = True Else rbAccrualMonthly.Checked = True
            If objManagement.IsChargesPaymentMonthly Then rbPaymentMonthly.Checked = True Else rbPaymentQuarterly.Checked = True
            If objManagement.IsChargesFixedAmount Then
                rbCalculationFixedAmount.Checked = True
            ElseIf objManagement.IsChargesFlatRate Then
                rbCalculationFlatRate.Checked = True
            ElseIf objManagement.IsChargesTiering Then
                rbCalculationTiering.Checked = True
            ElseIf objManagement.IsChargesLayering Then
                rbCalculationLayering.Checked = True
            End If
            If objManagement.IsChargesAUMT1 Then
                rbAUMT1.Checked = True
            ElseIf objManagement.IsChargesAUMCost Then
                rbAUMCost.Checked = True
            ElseIf objManagement.IsChargesAUMEOM Then
                rbAUMEndOfMonth.Checked = True
            ElseIf objManagement.IsChargesAUMAverageDaily Then
                rbAUMAverageDaily.Checked = True
            ElseIf objManagement.IsChargesAUMAverageMonthly Then
                rbAUMAverageMonthly.Checked = True
            End If
            If objManagement.GetFlagCapital = "Y" Then chkAUMCapital.Checked = True Else chkAUMCapital.Checked = False
            txtFlatAmount.Text = objManagement.GetFixedAmount.ToString("n2")
            txtFlatRate.Text = objManagement.GetFlatRate.ToString("n5")
            If objManagement.GetBaseDays.Trim.ToUpper = "365" Then rb365.Checked = True Else rbActual.Checked = True
            cmbVAT.Text = objManagement.GetVATFee.GetFeeCode
            If objManagement.IsChargesVATAccrual Then rbFeeAccrual.Checked = True Else rbFeePayment.Checked = True
            txtVAT.Text = objManagement.GetVATRate.ToString("n5")
            cmbIncomeTax.Text = objManagement.GetIncomeTaxFee.GetFeeCode
            txtIncomeTax.Text = objManagement.GetIncomeTaxRate.ToString("n5")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim typeAUM, typeCalculation As Byte
        If rbAUMT1.Checked Then
            typeAUM = 1
        ElseIf rbAUMCost.Checked Then
            typeAUM = 2
        ElseIf rbAUMEndOfMonth.Checked Then
            typeAUM = 3
        ElseIf rbAUMAverageDaily.Checked Then
            typeAUM = 4
        ElseIf rbAUMAverageMonthly.Checked Then
            typeAUM = 5
        Else
            typeAUM = 0
        End If
        If rbCalculationFixedAmount.Checked Then
            typeCalculation = 1
        ElseIf rbCalculationFlatRate.Checked Then
            typeCalculation = 2
        ElseIf rbCalculationTiering.Checked Then
            typeCalculation = 3
        ElseIf rbCalculationLayering.Checked Then
            typeCalculation = 4
        Else
            typeCalculation = 0
        End If
        objManagement.Clear()
        objManagement.Add(objPortfolio, FeeID, IIf(rbAccualDaily.Checked, 1, 2), typeAUM,
                          IIf(rbBasisAccrual.Checked, 1, 2), typeCalculation,
                          IIf(rbPaymentMonthly.Checked, 1, 2),
                          IIf(IsNumeric(txtFlatAmount.Text), txtFlatAmount.Text, 0),
                          IIf(IsNumeric(txtFlatRate.Text), txtFlatRate.Text, 0),
                          IIf(chkAUMCapital.Checked, "Y", "N"),
                          IIf(cmbVAT.SelectedIndex = -1, 1, cmbVAT.SelectedValue),
                          IIf(rbFeeAccrual.Checked, 1, 2), IIf(IsNumeric(txtVAT.Text), txtVAT.Text, 0),
                          IIf(cmbIncomeTax.SelectedIndex = -1, 1, cmbIncomeTax.SelectedValue),
                          IIf(IsNumeric(txtIncomeTax.Text), txtIncomeTax.Text, 0), IIf(rb365.Checked, "365", "ACTUAL"))
        If objManagement.ErrID = 0 Then
            CallerForm.FeeSearch()
            Close()
        Else
            ExceptionMessage.Show(objManagement.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        objManagement.Clear()
        objManagement.Remove(objPortfolio, FeeID)
        If objManagement.ErrID = 0 Then
            CallerForm.FeeSearch()
            Close()
        Else
            ExceptionMessage.Show(objManagement.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class