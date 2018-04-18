Imports simpi.globalutilities
Imports simpi.MasterSecurities
Imports simpi.MasterPortfolio
Imports simpi.ParameterPortfolio
Imports simpi.ParameterSecurities

Public Class FormMasterPortfolioEdit
    Public CallerForm As FormMasterPortfolio
    Public objPortfolio As MasterPortfolio

    Public Sub PortfolioLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            GetComboInit(New ParameterPortfolioAccount, cmbPortfolioAccount, "AccountID", "AccountCode")
            GetComboInit(New ParameterPortfolioAssetType, cmbAssetType, "AssetTypeID", "AssetTypeCode")
            GetComboInit(New ParameterSectorClass, cmbSectorClass, "ClassID", "ClassCode")
            GetComboInit(New ParameterInventoryMethod, cmbInventory, "InventoryID", "InventoryCode")
            GetComboInit(New ParameterCostMethod, cmbCost, "CostID", "CostCode")
            GetComboInit(New ParameterFITaxMethod, cmbTax, "TaxID", "TaxCode")
            GetComboInit(New ParameterPortfolioOverrideType, cmbOverrideType, "OverrideTypeID", "OverrideTypeCode")
            GetComboInit(New ParameterPortfolioTransactionApply, cmbApply, "ApplyID", "ApplyCode")

            lblID.Text = objPortfolio.GetMasterSimpi.GetSimpiID
            lblType.Text = objPortfolio.GetMasterSimpi.GetSimpiType.GetTypeCode
            lblStatus.Text = objPortfolio.GetMasterSimpi.GetSimpiStatus.GetStatusCode
            lblName.Text = objPortfolio.GetMasterSimpi.GetSimpiName
            txtShortname.Text = objPortfolio.GetPortfolioNameShort
            txtPortfolioCode.Text = objPortfolio.GetPortfolioCode
            txtName.Text = objPortfolio.GetPortfolioNameFull
            cmbPortfolioAccount.Text = objPortfolio.GetPortfolioAccount.GetAccountCode
            cmbCost.Text = objPortfolio.GetPortfolioCost.GetCostCode
            cmbAssetType.Text = objPortfolio.GetAssetType.GetAssetTypeCode
            cmbInventory.Text = objPortfolio.GetPortfolioInventory.GetInventoryCode
            cmbSectorClass.Text = objPortfolio.GetPortfolioSector.GetClassCode
            cmbTax.Text = objPortfolio.GetPortfolioTaxMethod.GetTaxCode
            cmbApply.Text = objPortfolio.GetPortfolioTransactionApply.GetApplyCode
            cmbOverrideType.Text = objPortfolio.GetPortfolioOverride.GetOverrideTypeCode
        Else
            Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If _check Then
            objPortfolio.Edit(txtPortfolioCode.Text, txtShortname.Text, txtName.Text,
                         cmbPortfolioAccount.SelectedValue, cmbAssetType.SelectedValue, cmbSectorClass.SelectedValue,
                         cmbCost.SelectedValue, cmbInventory.SelectedValue, cmbTax.SelectedValue,
                         cmbApply.SelectedValue, cmbOverrideType.SelectedValue)
            If objPortfolio.ErrID = 0 Then
                CallerForm.PortfolioSearch()
                Close()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function _check() As Boolean
        If cmbPortfolioAccount.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " portfolio account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbAssetType.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " portfolio asset type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbSectorClass.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " sector classification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbCost.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " cost method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbInventory.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " inventory method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbTax.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " fixed income tax method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbApply.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " transaction apply setting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbOverrideType.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " override setting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

End Class