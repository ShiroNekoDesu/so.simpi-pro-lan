Imports simpi.GlobalUtilities
Imports simpi.SimpiLogin

Public Class MDISO
    Public UserPassword As String = ""
    Public UserLogin As String = ""
    Public UserConnection As String = ""
    Public DatabaseType As String = ""
    Dim objLogin As New UserLogin


#Region "windows"
    Private Sub fileExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileExit.Click
        ApplicationExit()
    End Sub

    Private Sub fileWindowsCascade_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileWindowsCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub fileWindowsTileVertical_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileWindowsTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub fileWindowsTileHorizontal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileWindowsTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub fileWindowsArrangeAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileWindowsArrangeAll.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub fileWindowsCloseAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fileWindowsCloseAll.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        ApplicationExit()
    End Sub

#End Region
    Public Sub server_connect()
        lblStatus.Text = "LOCAL CONNECTION"
        lblStatus.ForeColor = Color.Green
        logon()
    End Sub

#Region "application access"
    Private Sub logon()
        If objLogin.Logon(UserConnection, DatabaseType, UserLogin, UserPassword, AppsCode, AppsVersion) Then
            If objLogin.ErrID = 0 Then
                objAccess.DatabaseConnection = UserConnection
                objAccess.DatabaseType = DatabaseType
                objAccess.GetSimpiLogin = objLogin
                lblUser.Text = "Master Simpi: " & objAccess.GetSimpiName.ToString() + ", UserName: " + objAccess.GetUserName.ToString() +
                               " | " + objAccess.GetUserTitle.ToString()
                lblAsOf.Text = "As of: " + objAccess.GetServerDate().ToString("dd-MMM-yyyy")
                lblVersion.Text = "version: " & AppsVersion
                lblTerminal.Text = "terminal: " & AppsTerminal
                objError.Clear()
                objError.UserAccess = objAccess
                cipLogin.Visible = False
                msMenu.Enabled = True
                tsbUserProfile.Enabled = True
            Else
                ExceptionMessage.Show(objLogin.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cipLogin.Visible = True
                txtUserLogin.Focus()
            End If
        Else
            ExceptionMessage.Show(objLogin.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cipLogin.Visible = True
            txtUserLogin.Focus()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        logon2()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Return Then
            logon2()
        End If
    End Sub

    Private Sub logon2()
        UserLogin = txtUserLogin.Text
        UserPassword = txtPassword.Text
        If objLogin.Logon(UserConnection, DatabaseType, UserLogin, UserPassword, AppsCode, AppsVersion) Then
            If objLogin.ErrID = 0 Then
                objAccess.DatabaseConnection = UserConnection
                objAccess.DatabaseType = DatabaseType
                objAccess.GetSimpiLogin = objLogin
                lblUser.Text = "Master Simpi: " & objAccess.GetSimpiName.ToString() + ", UserName: " + objAccess.GetUserName.ToString() +
                               " | " + objAccess.GetUserTitle.ToString()
                lblAsOf.Text = "As of: " + objAccess.GetServerDate().ToString("dd-MMM-yyyy")
                lblVersion.Text = "version: " & AppsVersion
                lblTerminal.Text = "terminal: " & AppsTerminal
                objError.Clear()
                objError.UserAccess = objAccess
                cipLogin.Visible = False
                msMenu.Enabled = True
                tsbUserProfile.Enabled = True
            Else
                ExceptionMessage.Show(objLogin.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserLogin.Focus()
            End If
        Else
            ExceptionMessage.Show(objLogin.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserLogin.Focus()
        End If
    End Sub

    Private Sub ApplicationExit()
        objAccess.Logout()
        Application.Exit()
    End Sub

#End Region

    Private Sub MenuCheck(ByVal strMenu As String)
        'If Not objAccess.AccessMenu(strMenu) Then
        '    Throw New Exception("System detect user: " & objAccess.GetUserName & " did not had access to menu: " & strMenu)
        'End If
    End Sub

    Private Sub tsbUserProfile_Click(sender As Object, e As EventArgs) Handles tsbUserProfile.Click
        Dim frm As New FormProfileUser
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = Me
        frm.Show()
    End Sub

#Region "Account"
    Private Sub amMaintenance_Click(sender As Object, e As EventArgs) Handles amMaintenance.Click
        Try
            'MenuCheck("Account Maintenance")
            Dim frm As New FormAccountMaintenance
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub amKYC_Click(sender As Object, e As EventArgs) Handles amKYC.Click
        Try
            'MenuCheck("Account KYC")
            Dim frm As New FormAccountKYC
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub amGenerateKYCIndividual_Click(sender As Object, e As EventArgs) Handles amGenerateKYCIndividual.Click

    End Sub

    Private Sub amGenerateKYCInstitutional_Click(sender As Object, e As EventArgs) Handles amGenerateKYCInstitutional.Click

    End Sub

    Private Sub amUploadFundSubAccount_Click(sender As Object, e As EventArgs) Handles amUploadFundSubAccount.Click
        Try
            'MenuCheck("Account Maintenance")
            Dim frm As New FormAccountFundUnitAccountSubAccount
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub amUploadKYCIndividual_Click(sender As Object, e As EventArgs) Handles amUploadKYCIndividual.Click
        Try
            'MenuCheck("Account Maintenance")
            Dim frm As New FormAccountCurrentKYCIndividual
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub amUploadKYCInstitutional_Click(sender As Object, e As EventArgs) Handles amUploadKYCInstitutional.Click
        Try
            'MenuCheck("Account Maintenance")
            Dim frm As New FormAccountCurrentKYCInstitutional
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "sales"
    Private Sub SalesMaintenance_Click(sender As Object, e As EventArgs) Handles smSalesMaintenance.Click
        Try
            'MenuCheck("Sales Maintenance")
            Dim frm As New FormSalesMaintenance
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub smSalesCodeset_Click(sender As Object, e As EventArgs) Handles smSalesCodeset.Click
        Try
            'MenuCheck("Sales Codeset")
            Dim frm As New FormSalesCodeset
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "order"
    Private Sub SubscriptionForm_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Subscription Form")
            Dim frm As New FormSubscriptionForm
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubscriptionSalesDistributor_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Subscription Bank")
            Dim frm As New FormSubscriptionBank
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubscriptionDiscretionary_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Subscription KPD")
            Dim frm As New FormSubscriptionKPD
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubscriptionSettlementManual_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Subscription Settle")
            Dim frm As New FormSubscriptionSettle
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubscriptionSettlementFile_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Subscription Settle BK")
            Dim frm As New FormSubscriptionSettleBK
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub RedemptionForm_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Redemption Form")
            Dim frm As New FormRedemptionForm
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub RedemptionSalesDistributor_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Redemption Bank")
            Dim frm As New FormRedemptionBank
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub RedemptionDiscretionary_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Redemption KPD")
            Dim frm As New FormRedemptionKPD
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub RedemptionSettlementManual_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Redemption Settle")
            Dim frm As New FormRedemptionSettle
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub RedemptionSettlementFile_Click(sender As Object, e As EventArgs)
        Try
            'MenuCheck("Redemption Settle BK")
            Dim frm As New FormRedemptionSettleBK
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "transaction"

    Private Sub tmUploadUnitAllocation_Click(sender As Object, e As EventArgs) Handles tmUploadUnitAllocation.Click
        Try
            'MenuCheck("Report Account Statement")
            Dim frm As New FormTransactionUnitAllocation
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub tmUnitAccountBalanceReconcile_Click(sender As Object, e As EventArgs) Handles tmUnitAccountBalanceReconcile.Click
        Try
            'MenuCheck("Report Account Statement")
            Dim frm As New FormTransactionUnitAccountBalanceReconcile
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "distribution"

#End Region

#Region "eod"
    Private Sub eodChargesAccrual_Click(sender As Object, e As EventArgs) Handles eodChargesAccrual.Click
        Try
            'MenuCheck("EOD Charges Accrual")
            Dim frm As New FormEODOverrideCharges
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodOverrideDividend_Click(sender As Object, e As EventArgs) Handles eodOverrideDividend.Click
        Try
            'MenuCheck("EOD Charges Accrual")
            Dim frm As New FormEODOverrideDividendCash
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodPortfolioNAV_Click(sender As Object, e As EventArgs) Handles eodPortfolioNAV.Click
        Try
            'MenuCheck("EOD Override NAV")
            Dim frm As New FormEODOverrideNAV
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodOverrideClosing_Click(sender As Object, e As EventArgs) Handles eodOverrideClosing.Click
        Try
            'MenuCheck("EOD Override NAV")
            Dim frm As New FormEODOverrideClosing
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodOverrideSecurities_Click(sender As Object, e As EventArgs) Handles eodOverrideSecurities.Click
        Try
            'MenuCheck("EOD Override NAV")
            Dim frm As New FormEODOverrideSecurities
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodOverrideBank_Click(sender As Object, e As EventArgs) Handles eodOverrideBank.Click
        Try
            'MenuCheck("EOD Override NAV")
            Dim frm As New FormEODOverrideBank
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodOverrideReturn_Click(sender As Object, e As EventArgs) Handles eodOverrideReturn.Click
        Try
            'MenuCheck("EOD Override NAV")
            Dim frm As New FormEODReturn
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub eodGenerateBenchmark_Click(sender As Object, e As EventArgs) Handles eodOverrideBenchmark.Click
        Try
            'MenuCheck("EOD Override NAV")
            Dim frm As New FormEODBenchmark
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub


#End Region

#Region "compliance"

#End Region

#Region "admin"
    Private Sub admSimpiProfile_Click(sender As Object, e As EventArgs) Handles admSimpiProfile.Click
        Try
            'MenuCheck("Simpi Profile")
            Dim frm As New FormMasterSimpi
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub admSimpiUser_Click(sender As Object, e As EventArgs) Handles admSimpiUser.Click
        Try
            'MenuCheck("Simpi User")
            Dim frm As New FormSimpiUser
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub admSimpiCredit_Click(sender As Object, e As EventArgs) Handles admSimpiCredit.Click

    End Sub

    Private Sub admPortfolio_Click(sender As Object, e As EventArgs) Handles admPortfolio.Click
        Try
            'MenuCheck("Master Portfolio")
            Dim frm As New FormMasterPortfolio
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub admCharges_Click(sender As Object, e As EventArgs) Handles admCharges.Click
        Try
            'MenuCheck("Master Charges")
            Dim frm As New FormMasterCharges
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub admCodesetSimpi_Click(sender As Object, e As EventArgs) Handles admCodesetSimpi.Click
        Try
            'MenuCheck("Codeset Simpi")
            Dim frm As New FormCodesetSimpi
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub admCodesetPortfolio_Click(sender As Object, e As EventArgs) Handles admCodesetPortfolio.Click
        Try
            'MenuCheck("Codeset Portfolio")
            Dim frm As New FormCodetsetPortfolio
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub admUpdate_Click(sender As Object, e As EventArgs) Handles admUpdate.Click
        Try
            'MenuCheck("Codeset Portfolio")
            Dim frm As New FormMasterUpdate
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "report"
    Private Sub reportAccountStatement_Click(sender As Object, e As EventArgs) Handles reportAccountStatement.Click
        Try
            'MenuCheck("Report Account Statement")
            Dim frm As New ReportAccountStatement
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportFactSheet_Click(sender As Object, e As EventArgs) Handles reportFactSheet.Click
        Try
            'MenuCheck("Report Account Valuation")
            Dim frm As New ReportAccountFactSheet
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportAccountValuation_Click(sender As Object, e As EventArgs) Handles reportAccountValuation.Click
        Try
            'MenuCheck("Report Account Valuation")
            Dim frm As New ReportAccountValuation
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportAccountManagementFee_Click(sender As Object, e As EventArgs) Handles reportAccountManagementFee.Click
        Try
            'MenuCheck("Report Account Valuation")
            Dim frm As New ReportAccountFee
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub


    Private Sub reportFundAUM_Click(sender As Object, e As EventArgs) Handles reportFundAUM.Click
        Try
            'MenuCheck("Report Fund AUM")
            Dim frm As New ReportFundNAV
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportFundOutstanding_Click(sender As Object, e As EventArgs) Handles reportFundOutstanding.Click
        Try
            'MenuCheck("Report Fund Outstanding")
            Dim frm As New ReportFundOutstanding
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportFundTransaction_Click(sender As Object, e As EventArgs) Handles reportFundTransaction.Click
        Try
            'MenuCheck("Report Fund Outstanding")
            Dim frm As New ReportFundTransaction
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportFundManagementFee_Click(sender As Object, e As EventArgs) Handles reportFundManagementFee.Click
        Try
            'MenuCheck("Report Fund Management Fee")
            Dim frm As New ReportManagementFee
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportSalesAUM_Click(sender As Object, e As EventArgs) Handles reportSalesAUM.Click
        Try
            'MenuCheck("Report Sales AUM")
            'Dim frm As New ReportSalesAUM
            'frm.Left = 0
            'frm.Top = 30
            'frm.MdiParent = Me
            'frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportSalesTransaction_Click(sender As Object, e As EventArgs) Handles reportSalesTransaction.Click
        Try
            'MenuCheck("Report Sales Transaction")
            'Dim frm As New ReportSalesTransaction
            'frm.Left = 0
            'frm.Top = 30
            'frm.MdiParent = Me
            'frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub reportTransactionInquiry_Click(sender As Object, e As EventArgs) Handles reportTransactionInquiry.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportInquiryTransaction
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetEQ_Click(sender As Object, e As EventArgs) Handles mcFundSheetEQ.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetEQ
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetEQGlobal_Click(sender As Object, e As EventArgs) Handles mcFundSheetEQGlobal.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetEQGlobal
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetShariahGlobal_Click(sender As Object, e As EventArgs) Handles mcFundSheetShariahGlobal.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetEQSyariah
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetCPF_Click(sender As Object, e As EventArgs) Handles mcFundSheetCPF.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetCPF
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetKPD_Click(sender As Object, e As EventArgs) Handles mcFundSheetKPD.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetKPD
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetEQSector_Click(sender As Object, e As EventArgs) Handles mcFundSheetEQSector.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetSectorEQ
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetFISector_Click(sender As Object, e As EventArgs) Handles mcFundSheetFISector.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetSectorFI
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcFundSheetDividend_Click(sender As Object, e As EventArgs) Handles mcFundSheetDividend.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportFundSheetDividend
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcProductFocusEQ_Click(sender As Object, e As EventArgs) Handles mcProductFocusEQ.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportProductFocusEQ
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcProductFocusFI_Click(sender As Object, e As EventArgs) Handles mcProductFocusFI.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportProductFocusFI
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcProductFocusMM_Click(sender As Object, e As EventArgs) Handles mcProductFocusMM.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportProductFocusMM
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcHoldingEQ_Click(sender As Object, e As EventArgs) Handles mcHoldingEQ.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportHoldingEQ
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcHoldingFI_Click(sender As Object, e As EventArgs) Handles mcHoldingFI.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportHoldingFI
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

    Private Sub mcHoldingMM_Click(sender As Object, e As EventArgs) Handles mcHoldingMM.Click
        Try
            'MenuCheck("Report Transaction Inquiry")
            Dim frm As New ReportHoldingTD
            frm.Left = 0
            frm.Top = 30
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class
