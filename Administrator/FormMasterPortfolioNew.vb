Imports simpi.GlobalUtilities.GlobalRegEx
Imports simpi.GlobalUtilities
Imports simpi.MasterSecurities
Imports simpi.MasterPortfolio
Imports simpi.MasterSimpi
Imports simpi.ParameterPortfolio
Imports simpi.ParameterSecurities

Public Class FormMasterPortfolioNew
    Public CallerForm As FormMasterPortfolio
    Dim objBenchmarkClass As New ParameterBenchmarkClass
    Dim objPortfolio As New MasterPortfolio
    Dim objPM As New SimpiUser
    Dim objBenchmarkSimpi As New MasterSimpi
    Dim objBenchmark As New MasterPortfolio

    Private Sub FormMasterPortfolioNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        lblID.Text = objSimpi.GetSimpiID
        lblType.Text = objSimpi.GetSimpiType.GetTypeCode
        lblStatus.Text = objSimpi.GetSimpiStatus.GetStatusCode
        lblName.Text = objSimpi.GetSimpiName

        objBenchmarkClass.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        objPM.UserAccess = objAccess
        objBenchmarkSimpi.UserAccess = objAccess
        objBenchmark.UserAccess = objAccess

        GetComboInit(New ParameterPortfolioType, cmbPortfolioType, "TypeID", "TypeCode")
        GetComboInit(New ParameterPortfolioReturn, cmbPortfolioReturn, "ReturnID", "ReturnCode")
        GetComboInit(New ParameterPortfolioDays, cmbPortfolioDays, "DaysID", "DaysCode")
        GetComboInit(New ParameterPortfolioAccount, cmbPortfolioAccount, "AccountID", "AccountCode")
        GetComboInit(New ParameterCountry, cmbCcy, "CountryID", "Ccy")
        GetComboInit(New ParameterPortfolioBenchmarkType, cmbBenchmarkType, "BenchmarkTypeID", "BenchmarkTypeCode")
        GetComboInit(New ParameterPortfolioAssetType, cmbAssetType, "AssetTypeID", "AssetTypeCode")
        GetComboInit(New ParameterSectorClass, cmbSectorClass, "ClassID", "ClassCode")
        GetComboInit(New ParameterInventoryMethod, cmbInventory, "InventoryID", "InventoryCode")
        GetComboInit(New ParameterCostMethod, cmbCost, "CostID", "CostCode")
        GetComboInit(New ParameterFITaxMethod, cmbTax, "TaxID", "TaxCode")
        GetComboInit(New ParameterPortfolioOverrideType, cmbOverrideType, "OverrideTypeID", "OverrideTypeCode")
        GetComboInit(New ParameterPortfolioTransactionApply, cmbApply, "ApplyID", "ApplyCode")
        GetComboDatatable(GetSimpiUser(""), cmbPM, "UserLogin", "UserInitial", False)
    End Sub

    Private Sub cmbBenchmarkType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBenchmarkType.SelectedIndexChanged
        BenchmarkType()
    End Sub

    Private Sub BenchmarkType()
        If cmbBenchmarkType.SelectedValue = 1 Then
            lblBenchmarkPortfolioCode.Text = ""
            lblBenchmarkPortfolioName.Text = ""
            lblBenchmarkSimpiEmail.Text = ""
            lblBenchmarkSimpiName.Text = ""
        ElseIf cmbBenchmarkType.SelectedValue = 2 Then
            lblBenchmarkCode.Text = ""
            lblBenchmarkName.Text = ""
        End If
    End Sub

    Private Sub btnSearchBenchmark_Click(sender As Object, e As EventArgs) Handles btnSearchBenchmark.Click
        BenchmarkSearch()
    End Sub

    Private Sub BenchmarkSearch()
        Dim form As New FormSelectBenchmarkClass
        form.Show()
        form.lblCode = lblBenchmarkCode
        form.lblDescription = lblBenchmarkName
        form.MdiParent = mdiso
        lblBenchmarkCode.Text = ""
        lblBenchmarkName.Text = ""
    End Sub

    Private Sub btnSearchBenchmarkPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchBenchmarkPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectMasterPortfolio
        form.Show()
        form.lblCode = lblBenchmarkPortfolioCode
        form.lblName = lblBenchmarkPortfolioName
        form.lblSimpiEmail = lblBenchmarkSimpiEmail
        form.lblSimpiName = lblBenchmarkSimpiName
        form.MdiParent = mdiso
        lblBenchmarkPortfolioCode.Text = ""
        lblBenchmarkPortfolioName.Text = ""
        lblBenchmarkSimpiEmail.Text = ""
        lblBenchmarkSimpiName.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If _check() Then
            If cmbBenchmarkType.SelectedValue = 1 Then
                If _saveBenchmark() Then
                    If objPortfolio.ErrID = 0 Then
                        CallerForm.PortfolioSearch()
                        Close()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            ElseIf cmbBenchmarkType.SelectedValue = 2 Then
                If _savePortfolio() Then
                    If objPortfolio.ErrID = 0 Then
                        CallerForm.PortfolioSearch()
                        Close()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Function _savePortfolio() As Boolean
        objBenchmarkSimpi.Load(lblBenchmarkSimpiEmail.Text)
        If objBenchmarkSimpi.ErrID <> 0 Then
            ExceptionMessage.Show(objBenchmarkSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        objBenchmark.LoadCode(objBenchmarkSimpi, lblBenchmarkPortfolioCode.Text)
        If objBenchmark.ErrID = 0 Then
            objPortfolio.Add(objMasterSimpi, objPM, txtCode.Text, txtShortname.Text, txtName.Text,
                             dtInception.Value, cmbCcy.SelectedValue, txtPrice.Text, cmbPortfolioType.SelectedValue,
                             cmbPortfolioAccount.SelectedValue, cmbAssetType.SelectedValue, cmbSectorClass.SelectedValue,
                             cmbPortfolioDays.SelectedValue, cmbPortfolioReturn.SelectedValue, cmbCost.SelectedValue,
                             cmbInventory.SelectedValue, cmbTax.SelectedValue, cmbApply.SelectedValue,
                             cmbOverrideType.SelectedValue, objBenchmark)
        Else
            ExceptionMessage.Show(objError.Message(81) & " master portfolio as benchmark", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function _saveBenchmark() As Boolean
        objBenchmarkClass.LoadCode(lblBenchmarkCode.Text)
        If objBenchmarkClass.ErrID <> 0 Then
            ExceptionMessage.Show(objBenchmarkClass.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        objPortfolio.Add(objMasterSimpi, objPM, txtCode.Text, txtShortname.Text, txtName.Text,
                         dtInception.Value, cmbCcy.SelectedValue, txtPrice.Text, cmbPortfolioType.SelectedValue,
                         cmbPortfolioAccount.SelectedValue, cmbAssetType.SelectedValue, cmbSectorClass.SelectedValue,
                         cmbPortfolioDays.SelectedValue, cmbPortfolioReturn.SelectedValue, cmbCost.SelectedValue,
                         cmbInventory.SelectedValue, cmbTax.SelectedValue, cmbApply.SelectedValue,
                         cmbOverrideType.SelectedValue, objBenchmarkClass.GetClassID)
        Return True
    End Function

    Private Function _check() As Boolean
        If cmbPM.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " portfolio manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        Else
            objPM.Clear()
            objPM.Load(cmbPM.SelectedValue)
            If objPM.ErrID > 0 Then
                ExceptionMessage.Show(objPM.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
                Exit Function
            End If
        End If
        If cmbPortfolioType.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " portfolio type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
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
        If cmbPortfolioDays.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " portfolio days", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbPortfolioReturn.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " portfolio return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        Dim strMsg As String = ""
        strMsg = Format_Decimal(txtPrice.Text)
        If strMsg.Trim <> "" Then
            ExceptionMessage.Show(strMsg)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class