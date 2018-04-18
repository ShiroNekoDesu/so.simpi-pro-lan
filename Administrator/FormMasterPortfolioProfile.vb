Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities.GlobalRegEx
Imports simpi.MasterPortfolio
Imports simpi.CoreCompliance
Imports simpi.MasterSimpi
Imports simpi.MasterSecurities
Imports simpi.ParameterSecurities
Imports simpi.ParameterBank.ParameterBank
Imports simpi.ParameterPortfolio
Imports simpi.ParameterFA
Imports simpi.MarketCompany
Imports simpi.globalutilities

Public Class FormMasterPortfolioProfile
    Public CallerForm As FormMasterPortfolio
    Public objPortfolio As MasterPortfolio
    Dim objClass As New ParameterBenchmarkClass
    Dim objBenchmark As New PortfolioBenchmark
    Dim objCodeset As New PortfolioCodeset
    Dim objAccount As New PortfolioBankAccount
    Dim objCharges As New PortfolioCharges
    Dim objCounterpart As New PortfolioCounterPart
    Dim objPricing As New PortfolioPricing
    Dim objPrice As New ParameterPortfolioPricing
    Dim objUser As New SimpiUser
    Dim objBenchmarkPortfolio As New MasterPortfolio
    Dim objBenchmarkSimpi As New MasterSimpi
    Dim objBroker As New MasterCounterPart
    Dim objOffice As New MarketCompanyOffice
    Dim objAssetAllocation As New PortfolioAssetAllocation
    Dim objBankAllocation As New PortfolioDeposit
    Dim objIssuerAllocation As New PortfolioCompany
    Dim objType As New ParameterInstrumentType

    Dim FieldID As Integer = 0
    Dim dtDIM As New DataTable
    Dim dtDIY As New DataTable
    Dim dtInterestAccrued As New DataTable

    Public Sub PortfolioLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            GetParameterExternalSystem()
            GetParameterBenchmarkClass()
            GetParameterCountry()
            GetParameterPortfolioCodesetField()
            GetComboInit(New ParameterPortfolioBenchmarkType, cmbBenchmarkType, "BenchmarkTypeID", "BenchmarkTypeCode")
            GetComboInit(New ParameterCharges, cmbCommission, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbLevy, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbVAT, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbWHT, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbSales, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbSellingFee, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbRedemptionFee, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbTaxNet, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbTaxGain, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbTaxCoupon, "FeeID", "FeeCode")
            GetComboInit(New ParameterCharges, cmbTaxInterest, "FeeID", "FeeCode")

            lblID.Text = objPortfolio.GetMasterSimpi.GetSimpiID
            lblType.Text = objPortfolio.GetMasterSimpi.GetSimpiType.GetTypeCode
            lblStatus.Text = objPortfolio.GetMasterSimpi.GetSimpiStatus.GetStatusCode
            lblName.Text = objPortfolio.GetMasterSimpi.GetSimpiName

            lblPortfolioID.Text = objPortfolio.GetPortfolioID
            lblPortfolioCode.Text = objPortfolio.GetPortfolioCode
            lblPortfolioType.Text = objPortfolio.GetPortfolioType.GetTypeCode
            lblPortfolioShortname.Text = objPortfolio.GetPortfolioNameShort
            lblPortfolioStatus.Text = objPortfolio.GetPortfolioStatus.GetStatusCode
            lblPortfolioName.Text = objPortfolio.GetPortfolioNameFull
            lblCcy.Text = objPortfolio.GetPortfolioCcy.GetCcy
            lblInceptionDate.Text = objPortfolio.GetInceptionDate.ToString("dd-MMM-yyyy")
            lblInceptionPrice.Text = objPortfolio.GetInceptionPrice.ToString("n4")
            lblInceptionAUM.Text = objPortfolio.GetInceptionAUM.ToString("n2")
            lblInceptionUnit.Text = objPortfolio.GetInceptionUnit.ToString("n4")
            lblBenchmarkType.Text = objPortfolio.GetPortfolioBenchmarkType.GetBenchmarkTypeCode
            If objPortfolio.GetPortfolioBenchmarkType.GetBenchmarkTypeID = 1 Then
                lblBenchmarkName.Text = objPortfolio.GetPortfolioBenchmarkClass.GetClassName
            Else
                lblBenchmarkName.Text = objPortfolio.GetPortfolioBenchmarkPortfolioName
            End If
            lblPM.Text = objPortfolio.GetPortfolioManager.GetUserInitial
            lblAssetType.Text = objPortfolio.GetAssetType.GetAssetTypeCode
            lblReturn.Text = objPortfolio.GetPortfolioReturn.GetReturnCode
            lblAccount.Text = objPortfolio.GetPortfolioAccount.GetAccountCode
            lblDays.Text = objPortfolio.GetPortfolioDays.GetDaysCode
            lblTax.Text = objPortfolio.GetPortfolioTaxMethod.GetTaxCode
            lblCost.Text = objPortfolio.GetPortfolioCost.GetCostCode
            lblInventory.Text = objPortfolio.GetPortfolioInventory.GetInventoryCode
            lblApply.Text = objPortfolio.GetPortfolioTransactionApply.GetApplyCode
            lblOverride.Text = objPortfolio.GetPortfolioOverride.GetOverrideTypeCode

            If objPortfolio.IsPending Then
                btnEdit.Enabled = True
                btnActivate.Enabled = True
                btnSuspend.Enabled = False
                btnClose.Enabled = False
            ElseIf objPortfolio.IsActive Then
                btnEdit.Enabled = True
                btnActivate.Enabled = False
                btnSuspend.Enabled = True
                btnClose.Enabled = True
            ElseIf objPortfolio.IsSuspend Then
                btnEdit.Enabled = True
                btnActivate.Enabled = True
                btnSuspend.Enabled = False
                btnClose.Enabled = False
            ElseIf objPortfolio.IsClose Then
                btnEdit.Enabled = False
                btnActivate.Enabled = False
                btnSuspend.Enabled = False
                btnClose.Enabled = False
            End If

            dtStart.Value = Now
            objPricing.UserAccess = objAccess
            objAccount.UserAccess = objAccess
            objCharges.UserAccess = objAccess
            objCounterpart.UserAccess = objAccess
            objCodeset.UserAccess = objAccess
            objUser.UserAccess = objAccess
            objBenchmark.UserAccess = objAccess
            objClass.UserAccess = objAccess
            objAccount.UserAccess = objAccess
            objBenchmarkPortfolio.UserAccess = objAccess
            objBenchmarkSimpi.UserAccess = objAccess
            objBroker.UserAccess = objAccess
            objOffice.UserAccess = objAccess
            objAssetAllocation.UserAccess = objAccess
            objBankAllocation.UserAccess = objAccess
            objIssuerAllocation.UserAccess = objAccess
            objType.UserAccess = objAccess
            GetComboInit(New ParameterInstrumentType, cmbType, "TypeID", "TypeCode")

            DBGUser.FetchRowStyles = True
            DBGCodeset.FetchRowStyles = True
            DBGBenchmark.FetchRowStyles = True
            DBGAccount.FetchRowStyles = True
            DBGEquity.FetchRowStyles = True
            DBGExternal.FetchRowStyles = True
            DBGUserSharing.FetchRowStyles = True
            DBGAllocation.FetchRowStyles = True
            DBGBankAllocation.FetchRowStyles = True
            DBGIssuerAllocation.FetchRowStyles = True

        Else
            Close()
        End If
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        PortfolioActivate()
    End Sub

    Private Sub btnSuspend_Click(sender As Object, e As EventArgs) Handles btnSuspend.Click
        PortfolioSuspend()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        PortfolioClose()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        PortfolioEdit()
    End Sub

    Private Sub PortfolioEdit()
        Dim frm As New FormMasterPortfolioEdit
        frm.objPortfolio = objPortfolio
        frm.PortfolioLoad()
        frm.Show()
        frm.CallerForm = CallerForm
        frm.MdiParent = mdiso
        Me.Close()
    End Sub

    Private Sub PortfolioSuspend()
        objPortfolio.SetSuspend()
        If objPortfolio.ErrID = 0 Then
            CallerForm.PortfolioSearch()
            Close()
        Else
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PortfolioClose()
        If ExceptionMessage.Show(objError.Message(87), "Info", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            objPortfolio.SetClose()
            If objPortfolio.ErrID = 0 Then
                CallerForm.PortfolioSearch()
                Close()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub PortfolioActivate()
        objPortfolio.SetActive()
        If objPortfolio.ErrID = 0 Then
            CallerForm.PortfolioSearch()
            Close()
        Else
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#Region "menu"

    Private Sub mnProfile_Click(sender As Object, e As EventArgs) Handles mnProfile.Click
        menuProfile()
    End Sub

    Private Sub menuProfile()
        cipProfile.Visible = True
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
    End Sub

    Private Sub mnTransactionCharges_Click(sender As Object, e As EventArgs) Handles mnTransactionCharges.Click
        menuTransactionCharges()
    End Sub

    Private Sub menuTransactionCharges()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = True
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
        EquitiesChargesLoad()
    End Sub

    Private Sub mnBankAccount_Click(sender As Object, e As EventArgs) Handles mnBankAccount.Click
        menuBankAccount()
    End Sub

    Private Sub menuBankAccount()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = True
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
        AccountLoad()
    End Sub

    Private Sub mnBenchmark_Click(sender As Object, e As EventArgs) Handles mnBenchmark.Click
        menuBenchmark()
    End Sub

    Private Sub menuBenchmark()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = True
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
        BenchmarkLoad()
    End Sub

    Private Sub mnCodeset_Click(sender As Object, e As EventArgs) Handles mnCodeset.Click
        menuCodeset()
    End Sub

    Private Sub menuCodeset()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = True
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
    End Sub

    Private Sub mnEquitiesCounterpart_Click(sender As Object, e As EventArgs) Handles mnEquitiesCounterpart.Click
        menuEquitiesCounterpart()
    End Sub

    Private Sub menuEquitiesCounterpart()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = True
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
        CounterpartLoad()
    End Sub

    Private Sub mnExternalID_Click(sender As Object, e As EventArgs) Handles mnExternalID.Click
        menuExternal()
    End Sub

    Private Sub menuExternal()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = True
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
    End Sub

    Private Sub mnAssetAllocation_Click(sender As Object, e As EventArgs) Handles mnAssetAllocation.Click
        menuAssetAllocation()
    End Sub

    Private Sub menuAssetAllocation()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = True
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
        assetAllocationLoad()
    End Sub

    Private Sub mnBankAllocation_Click(sender As Object, e As EventArgs) Handles mnBankAllocation.Click
        menuBankAllocation()
    End Sub

    Private Sub menuBankAllocation()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = True
        cscIssuerAllocation.Visible = False
        bankAllocationLoad()
    End Sub


    Private Sub mnIssuerAllocation_Click(sender As Object, e As EventArgs) Handles mnIssuerAllocation.Click
        menuIssuerAllocation()
    End Sub

    Private Sub menuIssuerAllocation()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = True
        issuerAllocationLoad()
    End Sub

    Private Sub mnUserSharing_Click(sender As Object, e As EventArgs) Handles mnUserSharing.Click
        menuUserSharing()
    End Sub

    Private Sub menuUserSharing()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = True
        cscUserSimpi.Visible = False
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
    End Sub

    Private Sub mnUserSimpi_Click(sender As Object, e As EventArgs) Handles mnUserSimpi.Click
        menuUserSimpi()
    End Sub

    Private Sub menuUserSimpi()
        cipProfile.Visible = False
        cipTransactionCharges.Visible = False
        cscAssetAllocation.Visible = False
        cscBankAccount.Visible = False
        cscBenchmark.Visible = False
        cscCodeset.Visible = False
        cscEquitiesCounterpart.Visible = False
        cscExternal.Visible = False
        cscUserSharing.Visible = False
        cscUserSimpi.Visible = True
        cscBankAllocation.Visible = False
        cscIssuerAllocation.Visible = False
    End Sub

#End Region

#Region "codeset"
    Private Sub btnSearchCodeset_Click(sender As Object, e As EventArgs) Handles btnSearchCodeset.Click
        CodesetLoad()
    End Sub

    Private Sub txtKeywordCodeset_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordCodeset.KeyDown
        If e.KeyCode = Keys.Enter Then
            CodesetLoad()
        End If
    End Sub

    Private Sub CodesetLoad()
        Dim dtField As New DataTable
        objCodeset.Clear()
        dtField = objCodeset.Search(objPortfolio, txtKeywordCodeset.Text)
        If dtParameterPortfolioCodeset IsNot Nothing AndAlso dtParameterPortfolioCodeset.Rows.Count > 0 Then
            Dim query = From c In dtParameterPortfolioCodeset.AsEnumerable
                        Group Join f In dtField.AsEnumerable On
                            c.Field(Of Integer)("FieldID") Equals f.Field(Of Integer)("FieldID") Into cf = Group
                        Let f = cf.FirstOrDefault
                        Select
                                ID = c.Field(Of Integer)("FieldID"),
                                Field = c.Field(Of String)("FieldCode"),
                                Data = If(f Is Nothing, Nothing, f.Field(Of String)("FieldData"))

            With DBGCodeset
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGCodeset.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGCodeset.Columns.Clear()
        End If
        CodesetClear()
    End Sub

    Private Sub CodesetClear()
        btnCodesetAdd.Enabled = False
        btnCodesetRemove.Enabled = False
        lblCodesetField.Text = ""
        txtCodesetData.Text = ""
        FieldID = 0
    End Sub

    Private Sub DBGCodeset_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGCodeset.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGCodeset_Click(sender As Object, e As EventArgs) Handles DBGCodeset.Click
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGCodeset_DoubleClick(sender As Object, e As EventArgs) Handles DBGCodeset.DoubleClick
        CodesetSelect()
    End Sub

    Private Sub CodesetSelect()
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                FieldID = .Columns("ID").Text
                lblCodesetField.Text = .Columns("Field").Text
                txtCodesetData.Text = .Columns("Data").Text
                If txtCodesetData.Text.Trim <> "" Then
                    btnCodesetRemove.Enabled = True
                    btnCodesetAdd.Enabled = False
                Else
                    btnCodesetAdd.Enabled = True
                    btnCodesetRemove.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub btnCodesetAdd_Click(sender As Object, e As EventArgs) Handles btnCodesetAdd.Click
        CodesetAdd()
    End Sub

    Private Sub CodesetAdd()
        If lblCodesetField.Text.Trim <> "" And txtCodesetData.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.Add(objPortfolio, FieldID, txtCodesetData.Text)
            If objCodeset.ErrID = 0 Then
                CodesetLoad()
            Else
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCodesetRemove_Click(sender As Object, e As EventArgs) Handles btnCodesetRemove.Click
        CodesetRemove()
    End Sub

    Private Sub CodesetRemove()
        If lblCodesetField.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.Remove(objPortfolio, lblCodesetField.Text)
            If objCodeset.ErrID = 0 Then
                CodesetLoad()
            Else
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "simpi user"
    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click
        UserSearch()
    End Sub

    Private Sub txtKeywordUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserSearch()
        End If
    End Sub

    Public Sub UserSearch()
        Dim tbl As New DataTable
        tbl = objPortfolio.User_SearchSimpi(txtKeywordUser.Text)
        If objPortfolio.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                             ID = t.Field(Of Integer)("UserID"),
                             UserLogin = t.Field(Of String)("UserLogin"),
                             Name = t.Field(Of String)("UserName"),
                             Status = t.Field(Of String)("StatusCode"),
                             Access = ParameterPortfolio.PortfolioAccess(t.Field(Of SByte)("IsTrade"))
            With DBGUser
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGUser.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            DBGUser.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGUser_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGUser.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUser.Click
        With DBGUser
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGUser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUser.DoubleClick
        UserRemove()
    End Sub

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click
        UserRemove()
    End Sub

    Private Sub UserRemove()
        With DBGUser
            If .RowCount > 0 Then
                objUser.Clear()
                objUser.Load(.Columns("UserLogin").Text)
                If objUser.ErrID = 0 Then
                    objPortfolio.User_Remove(objUser)
                    If objPortfolio.ErrID = 0 Then
                        UserSearch()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        UserAdd()
    End Sub

    Private Sub UserAdd()
        If objPortfolio.GetPortfolioID > 0 Then
            Dim frm As New FormMasterPortfolioAddSimpi
            frm.Left = 0
            frm.Top = 30
            frm.Show()
            frm.objPortfolio = objPortfolio
            frm.PortfolioLoad()
            frm.MdiParent = mdiso
        End If
    End Sub

#End Region

#Region "sharing user"
    Private Sub btnSearchUserSharing_Click(sender As Object, e As EventArgs) Handles btnSearchUserSharing.Click
        UserSharingSearch()
    End Sub

    Private Sub btnSearchUserSharing_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSearchUserSharing.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserSharingSearch()
        End If
    End Sub

    Public Sub UserSharingSearch()
        Dim tbl As New DataTable
        tbl = objPortfolio.User_SearchSharingAdmin(txtKeywordUserSharing.Text)
        If objPortfolio.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                             ID = t.Field(Of Integer)("simpiID"),
                             simpi = t.Field(Of String)("simpiName"),
                             Administrator = t.Field(Of String)("UserLogin"),
                             Name = t.Field(Of String)("UserName"),
                             Access = ParameterPortfolio.PortfolioAccess(t.Field(Of SByte)("IsTrade"))
            With DBGUserSharing
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGUserSharing.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            DBGUserSharing.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGUserSharing_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGUserSharing.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGUserSharing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUserSharing.Click
        With DBGUserSharing
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGUserSharing_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUserSharing.DoubleClick
        UserSharingRemove()
    End Sub

    Private Sub btnRemoveUserSharing_Click(sender As Object, e As EventArgs) Handles btnRemoveUserSharing.Click
        UserSharingRemove()
    End Sub

    Private Sub UserSharingRemove()
        With DBGUserSharing
            If .RowCount > 0 Then
                objUser.Clear()
                objUser.Load(.Columns("Administrator").Text)
                If objUser.ErrID = 0 Then
                    objPortfolio.User_Remove(objUser)
                    If objPortfolio.ErrID = 0 Then
                        UserSharingSearch()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnAddUserSharing_Click(sender As Object, e As EventArgs) Handles btnAddUserSharing.Click
        UserSharingAdd()
    End Sub

    Private Sub UserSharingAdd()
        If objPortfolio.GetPortfolioID > 0 Then
            Dim frm As New FormMasterPortfolioAddSharing
            frm.Left = 0
            frm.Top = 30
            frm.Show()
            frm.objPortfolio = objPortfolio
            frm.PortfolioLoad()
            frm.MdiParent = mdiso
        End If
    End Sub

#End Region

#Region "benchmark"
    Private Sub BenchmarkLoad()
        Dim dtBenchmark As New DataTable
        Dim dtPortfolio As New DataTable
        Dim tbl2 As New DataTable
        objBenchmark.Clear()
        dtBenchmark = objBenchmark.SearchBenchmark(objPortfolio)
        If objBenchmark.ErrID <> 0 Then
            ExceptionMessage.Show(objBenchmark.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        dtPortfolio = objBenchmark.SearchPortfolio(objPortfolio)
        If objBenchmark.ErrID <> 0 Then
            ExceptionMessage.Show(objBenchmark.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        dtBenchmark.Merge(dtPortfolio)
        dtBenchmark.DefaultView.Sort = "DateStart ASC"
        tbl2 = dtBenchmark.DefaultView.ToTable("benchmark", True, "DateStart", "BenchmarkTypeCode",
                                               "ClassCode", "simpiName", "simpiEmail", "PortfolioCode")
        With tbl2
            .Columns("DateStart").ColumnName = "Date"
            .Columns("BenchmarkTypeCode").ColumnName = "Type"
            .Columns("ClassCode").ColumnName = "Benchmark"
            .Columns("simpiName").ColumnName = "simpi"
            .Columns("simpiEmail").ColumnName = "simpiEmail"
            .Columns("PortfolioCode").ColumnName = "Portfolio"
        End With

        With DBGBenchmark
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Columns.Clear()
            .DataSource = tbl2

            .Columns("Date").NumberFormat = "dd-MMM-yyyy"

            For Each column As C1DisplayColumn In DBGBenchmark.Splits(0).DisplayColumns
                If column.Name.Trim = "simpiEmail" Then
                    column.Visible = False
                Else
                    column.AutoSize()
                End If
            Next

        End With
        BenchmarkClear()
    End Sub

    Private Sub BenchmarkClear()
        lblBenchmarkClassCode.Text = ""
        lblBenchmarkClassName.Text = ""
        lblBenchmarkPortfolioCode.Text = ""
        lblBenchmarkPortfolioName.Text = ""
        lblBenchmarkSimpiEmail.Text = ""
        lblBenchmarkSimpiName.Text = ""
        btnBenchmarkRemove.Enabled = False
        btnBenchmarkNew.Enabled = True
    End Sub

    Private Sub btnSearchBenchmark_Click(sender As Object, e As EventArgs) Handles btnSearchBenchmarkPortfolio.Click
        BenchmarkPortfolioSearch()
    End Sub

    Private Sub BenchmarkPortfolioSearch()
        Dim form As New FormSelectMasterPortfolio
        form.Show()
        form.lblCode = lblBenchmarkPortfolioCode
        form.lblName = lblBenchmarkPortfolioName
        form.lblSimpiEmail = lblBenchmarkSimpiEmail
        form.lblSimpiName = lblBenchmarkSimpiName
        form.MdiParent = mdiso
    End Sub

    Private Sub btnSearchBenchmarkClass_Click(sender As Object, e As EventArgs) Handles btnSearchBenchmarkClass.Click
        BenchmarkSearch()
    End Sub

    Private Sub BenchmarkSearch()
        Dim form As New FormSelectBenchmarkClass
        form.Show()
        form.lblCode = lblBenchmarkClassCode
        form.lblDescription = lblBenchmarkClassName
        form.MdiParent = mdiso
    End Sub

    Private Sub DBGBenchmark_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBenchmark.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGBenchmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBenchmark.Click
        With DBGBenchmark
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGBenchmark_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBenchmark.DoubleClick
        BenchmarkSelect()
    End Sub

    Private Sub BenchmarkSelect()
        With DBGBenchmark
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                cmbBenchmarkType.Text = .Columns("Type").Text.Trim.ToUpper
                If cmbBenchmarkType.SelectedValue = 1 Then
                    lblBenchmarkClassCode.Text = .Columns("Benchmark").Text
                    objClass.Clear()
                    objClass.LoadCode(.Columns("Benchmark").Text)
                    If objClass.ErrID <> 0 Then
                        lblBenchmarkClassName.Text = ""
                        ExceptionMessage.Show(objClass.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lblBenchmarkClassName.Text = objClass.GetClassName
                    End If
                    lblBenchmarkPortfolioCode.Text = ""
                    lblBenchmarkPortfolioName.Text = ""
                    lblBenchmarkSimpiEmail.Text = ""
                    lblBenchmarkSimpiName.Text = ""
                Else
                    lblBenchmarkClassCode.Text = ""
                    lblBenchmarkClassName.Text = ""
                    lblBenchmarkPortfolioCode.Text = .Columns("Portfolio").Text
                    lblBenchmarkSimpiEmail.Text = .Columns("simpiEmail").Text
                    lblBenchmarkSimpiName.Text = .Columns("simpi").Text

                    objBenchmarkSimpi.Clear()
                    objBenchmarkSimpi.Load(lblBenchmarkSimpiEmail.Text)
                    If objBenchmarkSimpi.ErrID <> 0 Then
                        ExceptionMessage.Show(objBenchmarkSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    objBenchmarkPortfolio.Clear()
                    objBenchmarkPortfolio.LoadCode(objBenchmarkSimpi, lblBenchmarkPortfolioCode.Text)
                    If objBenchmarkPortfolio.ErrID <> 0 Then
                        ExceptionMessage.Show(objBenchmarkPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    lblBenchmarkPortfolioCode.Text = objBenchmarkPortfolio.GetPortfolioCode
                    lblBenchmarkPortfolioName.Text = objBenchmarkPortfolio.GetPortfolioNameShort
                End If
                dtStart.Value = .Columns("Date").Text
                btnBenchmarkRemove.Enabled = True
                btnBenchmarkNew.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnBenchmarkAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBenchmarkNew.Click
        BenchmarkAdd()
    End Sub

    Private Sub BenchmarkAdd()
        If cmbBenchmarkType.SelectedValue = 1 Then
            If lblBenchmarkClassCode.Text.Trim = "" Then
                ExceptionMessage.Show(objError.Message(81) & " benchmark class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objClass.Clear()
            objClass.LoadCode(lblBenchmarkClassCode.Text)
            If objClass.ErrID <> 0 Then
                ExceptionMessage.Show(objClass.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objBenchmark.Clear()
            objBenchmark.Add(objPortfolio, objClass.GetClassID, dtStart.Value)

        ElseIf cmbBenchmarkType.SelectedValue = 2 Then
            objBenchmarkSimpi.Clear()
            objBenchmarkSimpi.Load(lblBenchmarkSimpiEmail.Text)
            If objBenchmarkSimpi.ErrID <> 0 Then
                ExceptionMessage.Show(objBenchmarkSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objBenchmarkPortfolio.Clear()
            objBenchmarkPortfolio.LoadCode(objBenchmarkSimpi, lblBenchmarkPortfolioCode.Text)
            If objBenchmarkPortfolio.ErrID <> 0 Then
                ExceptionMessage.Show(objBenchmarkPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objBenchmark.Clear()
            objBenchmark.Add(objPortfolio, objBenchmarkPortfolio, dtStart.Value)

        End If
        If objBenchmark.ErrID = 0 Then
            BenchmarkLoad()
        Else
            ExceptionMessage.Show(objBenchmark.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBenchmarkRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBenchmarkRemove.Click
        BenchmarkRemove()
    End Sub

    Private Sub BenchmarkRemove()
        objBenchmark.Clear()
        objBenchmark.Remove(objPortfolio, dtStart.Value)
        If objBenchmark.ErrID = 0 Then
            BenchmarkLoad()
        Else
            ExceptionMessage.Show(objBenchmark.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "external identification"
    Private Sub btnSearchExternal_Click(sender As Object, e As EventArgs) Handles btnSearchExternal.Click
        ExternalLoad()
    End Sub

    Private Sub txtKeywordExternal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordExternal.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExternalLoad()
        End If
    End Sub

    Private Sub ExternalLoad()
        Dim tbl As New DataTable
        tbl = objPortfolio.ExternalID_Search()
        If dtParameterExternalSystem IsNot Nothing AndAlso dtParameterExternalSystem.Rows.Count > 0 Then
            Dim query = From c In dtParameterExternalSystem.AsEnumerable
                        Where c.Field(Of String)("SystemCode").Contains(txtKeywordExternal.Text.Trim)
                        Group Join f In tbl.AsEnumerable On c.Field(Of Integer)("SystemID") Equals
                            f.Field(Of Integer)("SystemID") Into cf = Group
                        Let f = cf.FirstOrDefault
                        Select
                                ID = c.Field(Of Integer)("SystemID"),
                                System = c.Field(Of String)("SystemCode"),
                                ExternalID = If(f Is Nothing, Nothing, f.Field(Of String)("PortfolioExternalCode"))
            With DBGExternal
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGExternal.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            DBGExternal.Columns.Clear()
        End If
        ExternalClear()
    End Sub

    Private Sub ExternalClear()
        lblSystemID.Text = ""
        lblSystem.Text = ""
        txtExternalID.Text = ""
        btnExternalRemove.Enabled = False
        btnExternalAdd.Enabled = False
    End Sub

    Private Sub btnExternalAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExternalAdd.Click
        ExternalAdd()
    End Sub

    Private Sub btnExternalRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExternalRemove.Click
        ExternalRemove()
    End Sub

    Private Sub DBGExternal_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGExternal.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGExternal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGExternal.Click
        With DBGExternal
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGExternal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBGExternal.DoubleClick
        ExternalSelect()
    End Sub

    Private Sub ExternalGet()
        If lblSystemID.Text.Trim <> "" Then
            txtExternalID.Text = objPortfolio.ExternalID_Get(lblSystemID.Text)
            If txtExternalID.Text <> "" Then
                btnExternalRemove.Enabled = True
                btnExternalAdd.Enabled = False
            Else
                btnExternalAdd.Enabled = True
                btnExternalRemove.Enabled = False
            End If
        End If
    End Sub

    Private Sub ExternalSelect()
        With DBGExternal
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblSystemID.Text = .Columns("ID").Text
                lblSystem.Text = .Columns("System").Text
                txtExternalID.Text = .Columns("ExternalID").Text
                If txtExternalID.Text <> "" Then
                    btnExternalRemove.Enabled = True
                    btnExternalAdd.Enabled = False
                Else
                    btnExternalAdd.Enabled = True
                    btnExternalRemove.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub ExternalAdd()
        If lblSystemID.Text.Trim <> "" And txtExternalID.Text.Trim <> "" Then
            objPortfolio.ExternalID_Add(lblSystemID.Text, txtExternalID.Text)
            If objPortfolio.ErrID = 0 Then
                ExternalLoad()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ExternalRemove()
        If lblSystemID.Text.Trim <> "" Then
            objPortfolio.ExternalID_Remove(lblSystemID.Text)
            If objPortfolio.ErrID = 0 Then
                ExternalLoad()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "bank account"
    Private Sub AccountLoad()
        Dim dtAccount As New DataTable
        objAccount.Clear()
        dtAccount = objAccount.SearchAccount(objPortfolio, 0, "")
        If objAccount.ErrID = 0 Then
            Dim query = From acc In dtAccount.AsEnumerable
                        Join ccy In dtParameterCountry.AsEnumerable On
                            acc.Field(Of Integer)("AccountCcyID") Equals ccy.Field(Of Integer)("CountryID")
                        Select
                             ID = acc.Field(Of Integer)("CompanyID"),
                             Bank = acc.Field(Of String)("CompanyName"),
                             Branch = acc.Field(Of String)("OfficeName"),
                             AccountNo = acc.Field(Of String)("AccountNo"),
                             Name = acc.Field(Of String)("AccountName")
            With DBGAccount
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList
                .AllowRowSizing = RowSizingEnum.IndividualRows

                'For Each C As C1DisplayColumn In .Splits(0).DisplayColumns
                '    C.Style.WrapText = True
                'Next

                'For i As Integer = 0 To .Splits(0).Rows.Count - 1
                '    .Splits(0).Rows(i).AutoSize()
                'Next

                Dim ID, Bank, Branch, No, Name As C1DisplayColumn
                ID = .Splits(0).DisplayColumns("ID")
                Bank = .Splits(0).DisplayColumns("Bank")
                Branch = .Splits(0).DisplayColumns("Branch")
                No = .Splits(0).DisplayColumns("AccountNo")
                Name = .Splits(0).DisplayColumns("Name")

                ID.Width = 37
                Bank.Width = 200
                Branch.Width = 200
                No.Width = 120
                Name.Width = 200

            End With
            AccountClear()
            btnBankNew.Text = "ADD"
            btnBankEdit.Text = "EDIT"
            AccountTxt(False)
            btnBankEdit.Enabled = False
        Else
            ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AccountClear()
        objAccount.Clear()
        lblBankCode.Text = ""
        lblBankName.Text = ""
        lblBranchID.Text = ""
        lblBranchCode.Text = ""
        lblBranchName.Text = ""
        txtAccountNo.Text = ""
        txtAccountName.Text = ""
    End Sub

    Private Sub AccountTxt(ByVal bControl As Boolean)
        btnBankSearch.Enabled = bControl
        btnBranchSearch.Enabled = bControl
        txtAccountNo.Enabled = bControl
        txtAccountName.Enabled = bControl
        btnBankSearch.Enabled = bControl
    End Sub

    Private Sub DBGAccount_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGAccount.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAccount.Click
        With DBGAccount
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGAccount_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAccount.DoubleClick
        AccountSelect()
    End Sub

    Private Sub AccountSelect()
        With DBGAccount
            If .RowCount > 0 Then
                objAccount.Clear()
                objAccount.Load(objPortfolio.GetMasterSimpi, CInt(.Columns("ID").Text), .Columns("AccountNo").Text)
                If objAccount.ErrID = 0 Then
                    lblBankCode.Text = objAccount.GetCompanyOffice.GetMarketCompany.GetCompanyCode
                    lblBankName.Text = objAccount.GetCompanyOffice.GetMarketCompany.GetCompanyName
                    lblBranchID.Text = objAccount.GetCompanyOffice.GetOfficeID
                    lblBranchCode.Text = objAccount.GetCompanyOffice.GetOfficeCode
                    lblBranchName.Text = objAccount.GetCompanyOffice.GetOfficeName
                    txtAccountNo.Text = objAccount.GetAccountNo
                    txtAccountName.Text = objAccount.GetAccountName
                    AccountTxt(True)
                    btnBankSearch.Enabled = False
                    btnBankNew.Text = "SAVE"
                    btnBankEdit.Text = "CANCEL"
                    btnBankEdit.Enabled = True
                Else
                    ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnBankSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBankSearch.Click
        BankSearch()
    End Sub

    Private Sub BankSearch()
        Dim frm As New FormSelectBank
        frm.Show()
        frm.lblID = lblBankID
        frm.lblCode = lblBankCode
        frm.lblName = lblBankName
        frm.MdiParent = mdiso
    End Sub

    Private Sub btnBranchSearch_Click(sender As Object, e As EventArgs) Handles btnBranchSearch.Click
        BranchSearch()
    End Sub

    Private Sub BranchSearch()
        If lblBankCode.Text.Trim <> "" Then
            Dim frm As New FormSelectBankBranch
            frm.lblBankCode.Text = lblBankCode.Text
            frm.lblBankName.Text = lblBankName.Text
            frm.Show()
            frm.lblID = lblBranchID
            frm.lblCode = lblBranchCode
            frm.lblName = lblBranchName
            frm.MdiParent = mdiso
        End If
    End Sub

    Private Sub btnBankNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBankNew.Click
        AccountNew()
    End Sub

    Private Sub AccountNew()
        If btnBankNew.Text.ToUpper = "ADD" Then
            AccountClear()
            AccountTxt(True)
            btnBankNew.Text = "SAVE"
            btnBankEdit.Text = "CANCEL"
            btnBankEdit.Enabled = True
        ElseIf btnBankNew.Text.ToUpper = "SAVE" Then
            AccountSave()
        End If
    End Sub

    Private Sub AccountSave()
        If lblBranchCode.Text.Trim = "" Then
            ExceptionMessage.Show(objError.Message(81) & " bank branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If objAccount.GetAccountID = 0 Then
            objAccount.Add(objPortfolio, lblBranchID.Text, txtAccountNo.Text, txtAccountName.Text,
                           objPortfolio.GetPortfolioCcy.GetCountryID, 1, 1, SetAccruedNone)
        Else
            objAccount.Edit(lblBranchID.Text, txtAccountNo.Text, txtAccountName.Text,
                            objPortfolio.GetPortfolioCcy.GetCountryID, 1, 1, SetAccruedNone)
        End If
        If objAccount.ErrID = 0 Then
            AccountLoad()
        Else
            ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBankEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBankEdit.Click
        AccountCancel()
    End Sub

    Private Sub AccountCancel()
        If btnBankEdit.Text.ToUpper = "EDIT" Then
            btnBankNew.Text = "SAVE"
            btnBankEdit.Text = "CANCEL"
            AccountSelect()
        Else
            btnBankNew.Text = "ADD"
            btnBankEdit.Text = "EDIT"
            AccountTxt(False)
            AccountClear()
            btnBankEdit.Enabled = False
        End If
    End Sub

#End Region

#Region "equity broker & portfolio charges"
    Private Sub EquitiesChargesLoad()
        objCharges.Clear()
        objCharges.Load(objPortfolio)
        If objCharges.ErrID = 0 Then
            cmbCommission.Text = objCharges.GetEQCommFee.GetFeeCode
            cmbLevy.Text = objCharges.GetEQLevyFee.GetFeeCode
            cmbVAT.Text = objCharges.GetEQVATFee.GetFeeCode
            cmbWHT.Text = objCharges.GetEQWHTFee.GetFeeCode
            cmbSales.Text = objCharges.GetEQSalesFee.GetFeeCode
            cmbSellingFee.Text = objCharges.GetFundSellingFee.GetFeeCode
            cmbRedemptionFee.Text = objCharges.GetFundRedemptionFee.GetFeeCode
            cmbTaxCoupon.Text = objCharges.GetFITaxCouponFee.GetFeeCode
            cmbTaxGain.Text = objCharges.GetFITaxGainFee.GetFeeCode
            cmbTaxNet.Text = objCharges.GetFITaxNetFee.GetFeeCode
            txtTaxNet.Text = objCharges.GetFITaxNetPercent.ToString("n3")
            txtTaxGain.Text = objCharges.GetFITaxGainPercent.ToString("n3")
            txtTaxCoupon.Text = objCharges.GetFITaxCouponPercent.ToString("n3")
            cmbTaxInterest.Text = objCharges.GetDepositTax.GetFeeCode
            txtTaxInterest.Text = objCharges.GetDepositTaxRate.ToString("n3")
        Else
            cmbCommission.SelectedIndex = -1
            cmbLevy.SelectedIndex = -1
            cmbVAT.SelectedIndex = -1
            cmbWHT.SelectedIndex = -1
            cmbSales.SelectedIndex = -1
            cmbSellingFee.SelectedIndex = -1
            cmbRedemptionFee.SelectedIndex = -1
            cmbTaxCoupon.SelectedIndex = -1
            cmbTaxGain.SelectedIndex = -1
            cmbTaxNet.SelectedIndex = -1
            txtTaxNet.Text = 0.ToString("n3")
            txtTaxGain.Text = 0.ToString("n3")
            txtTaxCoupon.Text = 0.ToString("n3")
            cmbTaxInterest.SelectedIndex = -1
            txtTaxInterest.Text = 0.ToString("n3")
        End If
    End Sub

    Private Sub CounterpartLoad()
        Dim dtParameterFACharges As New DataTable
        Dim tbl2 As New DataTable
        objCharges.Clear()
        dtParameterFACharges = objCounterpart.Search(objPortfolio, 0)
        If objCharges.ErrID = 0 Then
            Dim query = From r In dtParameterFACharges.AsEnumerable
                        Select
                                 ID = r.Field(Of Integer)("CompanyID"),
                                 Broker = r.Field(Of String)("BrokerCode"),
                                 Company = r.Field(Of String)("CompanyCode"),
                                 Name = r.Field(Of String)("CompanyName"),
                                 Commission = r.Field(Of Decimal)("EQCommPercent") * 100,
                                 VAT = r.Field(Of Decimal)("EQVATPercent") * 100,
                                 WHT = r.Field(Of Decimal)("EQWHTPercent") * 100,
                                 Levy = r.Field(Of Decimal)("EQLevyPercent") * 100,
                                 Sales = r.Field(Of Decimal)("EQSalesPercent") * 100
            With DBGEquity
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Commission").NumberFormat = "n5"
                .Columns("VAT").NumberFormat = "n5"
                .Columns("WHT").NumberFormat = "n5"
                .Columns("Levy").NumberFormat = "n5"
                .Columns("Sales").NumberFormat = "n5"

                .Splits(0).DisplayColumns("ID").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Commission").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("VAT").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("WHT").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Levy").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Sales").Style.HorizontalAlignment = AlignHorzEnum.Far

                For Each column As C1DisplayColumn In DBGEquity.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            ExceptionMessage.Show(objCharges.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        EquitiesChargesClear()
    End Sub

    Private Sub btnEQChargesSave_Click(sender As Object, e As EventArgs) Handles btnEQChargesSave.Click
        EquitiesChargesSave()
    End Sub

    Private Sub EquitiesChargesSave()
        If cmbCommission.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " commission charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbLevy.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " levy charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbVAT.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " vat charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbWHT.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " wht charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbSales.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " sales tax charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbSales.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " sales tax charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbSellingFee.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " selling fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbRedemptionFee.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " redemption fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbTaxCoupon.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " bond coupon holding tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbTaxGain.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " bond gain tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbTaxNet.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " bond net tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cmbTaxInterest.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " deposit tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim net, gain, coupon, interest As Double
        Double.TryParse(txtTaxNet.Text, net)
        Double.TryParse(txtTaxGain.Text, gain)
        Double.TryParse(txtTaxCoupon.Text, coupon)
        Double.TryParse(txtTaxInterest.Text, interest)

        objCharges.Clear()
        objCharges.Load(objPortfolio)
        If objCharges.ErrID = 0 Then objCharges.Remove(objPortfolio)
        objCharges.Add(objPortfolio, cmbCommission.SelectedValue, cmbLevy.SelectedValue,
                       cmbVAT.SelectedValue, cmbWHT.SelectedValue, cmbSales.SelectedValue, cmbSellingFee.SelectedValue,
                       cmbRedemptionFee.SelectedValue, cmbTaxNet.SelectedValue, cmbTaxGain.SelectedValue,
                       cmbTaxCoupon.SelectedValue, net, gain, coupon, cmbTaxInterest.SelectedValue, interest)
        If objCharges.ErrID = 0 Then
            EquitiesChargesLoad()
            ExceptionMessage.Show("Save record done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ExceptionMessage.Show(objCharges.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEQChargesRemove_Click(sender As Object, e As EventArgs) Handles btnEQChargesRemove.Click
        EquitiesChargesRemove()
    End Sub

    Private Sub EquitiesChargesRemove()
        objCharges.Clear()
        objCharges.Remove(objPortfolio)
        If objCharges.ErrID = 0 Then
            EquitiesChargesLoad()
        Else
            ExceptionMessage.Show(objCharges.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EquitiesChargesClear()
        objCharges.Clear()
        lblBrokerCode.Text = ""
        lblBrokerCompanyName.Text = ""
        txtBrokerCommission.Text = ""
        txtBrokerLevy.Text = ""
        txtBrokerVAT.Text = ""
        txtBrokerWHT.Text = ""
        txtBrokerSales.Text = ""
        btnEquitiesChargesRemove.Enabled = False
        btnEquitiesChargesAdd.Enabled = True
    End Sub

    Private Sub DBGEquity_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGEquity.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGEquity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGEquity.Click
        DBGEquity.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGEquity_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGEquity.DoubleClick
        EquitiesChargesSelect()
    End Sub

    Private Sub EquitiesChargesSelect()
        With DBGEquity
            If .RowCount > 0 Then
                lblBrokerCode.Text = .Columns("Broker").Text
                lblBrokerCompanyName.Text = .Columns("Name").Text
                txtBrokerCommission.Text = .Columns("Commission").Text
                txtBrokerLevy.Text = .Columns("Levy").Text
                txtBrokerVAT.Text = .Columns("VAT").Text
                txtBrokerWHT.Text = .Columns("WHT").Text
                txtBrokerSales.Text = .Columns("Sales").Text
                btnEquitiesChargesRemove.Enabled = True
                btnEquitiesChargesAdd.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnSearchEQChargesSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEQCharges.Click
        BrokerSearch()
    End Sub

    Private Sub BrokerSearch()
        Dim frm As New FormSelectCounterPart
        frm.Show()
        frm.lblCode = lblBrokerCode
        frm.lblName = lblBrokerCompanyName
        frm.MdiParent = mdiso
    End Sub

    Private Sub btnEquitiesChargesAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquitiesChargesAdd.Click
        CounterpartAdd()
    End Sub

    Private Sub CounterpartAdd()
        If lblBrokerCode.Text.Trim <> "" Then
            Dim strMsg As String = ""
            objBroker.Clear()
            objBroker.LoadCounterPart(lblBrokerCode.Text)
            If objBroker.ErrID = 0 Then
                strMsg = Format_Decimal(txtBrokerCommission.Text)
                If strMsg.Trim <> "" Then
                    ExceptionMessage.Show(strMsg)
                    Exit Sub
                End If
                strMsg = Format_Decimal(txtBrokerLevy.Text)
                If strMsg.Trim <> "" Then
                    ExceptionMessage.Show(strMsg)
                    Exit Sub
                End If
                strMsg = Format_Decimal(txtBrokerVAT.Text)
                If strMsg.Trim <> "" Then
                    ExceptionMessage.Show(strMsg)
                    Exit Sub
                End If
                strMsg = Format_Decimal(txtBrokerWHT.Text)
                If strMsg.Trim <> "" Then
                    ExceptionMessage.Show(strMsg)
                    Exit Sub
                End If
                strMsg = Format_Decimal(txtBrokerSales.Text)
                If strMsg.Trim <> "" Then
                    ExceptionMessage.Show(strMsg)
                    Exit Sub
                End If
                objCounterpart.Clear()
                objCounterpart.Add(objPortfolio, objBroker.GetMarketCompany.GetCompanyID,
                               txtBrokerCommission.Text, txtBrokerLevy.Text, txtBrokerVAT.Text,
                               txtBrokerWHT.Text, txtBrokerSales.Text)
                If objCounterpart.ErrID = 0 Then
                    CounterpartLoad()
                Else
                    ExceptionMessage.Show(objCounterpart.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objBroker.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnEquitiesChargesRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquitiesChargesRemove.Click
        CounterpartRemove()
    End Sub

    Private Sub CounterpartRemove()
        If objPortfolio.GetPortfolioID > 0 And lblBrokerCode.Text.Trim <> "" Then
            objCounterpart.Clear()
            objCounterpart.Remove(objPortfolio, lblBrokerCode.Text)
            If objCounterpart.ErrID = 0 Then
                CounterpartLoad()
            Else
                ExceptionMessage.Show(objCounterpart.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "asset allocation"
    Private Sub AssetAllocationLoad()
        Dim tbl As New DataTable
        objAssetAllocation.Clear()
        tbl = objAssetAllocation.Search(objPortfolio)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Dim query = From a In tbl.AsEnumerable
                        Select
                                ID = a.Field(Of Integer)("TypeID"),
                                Type = a.Field(Of String)("TypeCode"),
                                Cash = IIf(a.Field(Of SByte)("IncludeCash") = 0, "N", "Y"),
                                Accrual = IIf(a.Field(Of SByte)("IncludeAccrual") = 0, "N", "Y"),
                                MinAllocation = a.Field(Of Decimal)("MinAllocation") * 100,
                                MaxAllocation = a.Field(Of Decimal)("MaxAllocation") * 100,
                                TTM = a.Field(Of Integer)("TTM")

            With DBGAllocation
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("MinAllocation").NumberFormat = "n2"
                .Columns("MaxAllocation").NumberFormat = "n2"
                .Columns("TTM").NumberFormat = "n0"

                For Each column As C1DisplayColumn In DBGAllocation.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGAllocation.Columns.Clear()
        End If
        AssetAllocationClear()
    End Sub

    Private Sub DBGAllocation_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGAllocation.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGAllocation_Click(sender As Object, e As EventArgs) Handles DBGAllocation.Click
        If DBGAllocation.RowCount > 0 Then DBGAllocation.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGAllocation_DoubleClick(sender As Object, e As EventArgs) Handles DBGAllocation.DoubleClick
        AssetAllocationSelect()
    End Sub

    Private Sub AssetAllocationSelect()
        With DBGAllocation
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                cmbType.Text = .Columns("Type").Text
                txtAllocationMin.Text = .Columns("MinAllocation").Text
                txtAllocationMax.Text = .Columns("MaxAllocation").Text
                txtAllocationTTM.Text = .Columns("TTM").Text
                If .Columns("Cash").Text.Trim = "Y" Then chkAllocationCash.Checked = True Else chkAllocationCash.Checked = False
                If .Columns("Accrual").Text.Trim = "Y" Then chkFIAccrual.Checked = True Else chkFIAccrual.Checked = False
                btnAllocationRemove.Enabled = True
                btnAllocationAdd.Enabled = False
            End If
        End With
    End Sub

    Private Sub AssetAllocationClear()
        btnAllocationAdd.Enabled = True
        btnAllocationRemove.Enabled = False
        cmbType.SelectedIndex = -1
        lblTypeName.Text = ""
        txtAllocationMin.Text = ""
        txtAllocationMax.Text = ""
        txtAllocationTTM.Text = ""
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        TypeLoad()
    End Sub

    Private Sub TypeLoad()
        If cmbType.SelectedIndex <> -1 Then
            objType.Clear()
            objType.LoadCode(cmbType.Text)
            If objType.ErrID = 0 Then
                lblTypeName.Text = objType.GetTypeDescription
            Else
                ExceptionMessage.Show(objType.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnAllocationAdd_Click(sender As Object, e As EventArgs) Handles btnAllocationAdd.Click
        AssetAllocationAdd()
    End Sub

    Private Sub AssetAllocationAdd()
        If objPortfolio.GetPortfolioID > 0 And cmbType.SelectedIndex <> -1 Then
            If Not IsNumeric(txtAllocationMin.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " minimum allocation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not IsNumeric(txtAllocationMax.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " maximum allocation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim ttm As Integer = 0
            If IsNumeric(txtAllocationTTM.Text) Then
                ttm = CInt(txtAllocationTTM.Text)
            End If
            objAssetAllocation.Add(objPortfolio, cmbType.SelectedValue, IIf(chkAllocationCash.Checked, True, False),
                              IIf(chkFIAccrual.Checked, True, False), CDbl(txtAllocationMin.Text),
                              CDbl(txtAllocationMax.Text), ttm)
            If objAssetAllocation.ErrID = 0 Then
                AssetAllocationLoad()
            Else
                ExceptionMessage.Show(objAssetAllocation.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnAllocationRemove_Click(sender As Object, e As EventArgs) Handles btnAllocationRemove.Click
        AssetAllocationRemove()
    End Sub

    Private Sub AssetAllocationRemove()
        If objPortfolio.GetPortfolioID > 0 And cmbType.SelectedIndex <> -1 Then
            objAssetAllocation.Remove(objPortfolio, cmbType.SelectedValue, IIf(chkAllocationCash.Checked, 1, 0))
            If objAssetAllocation.ErrID = 0 Then
                AssetAllocationLoad()
            Else
                ExceptionMessage.Show(objAssetAllocation.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "bank allocation"
    Private Sub BankAllocationLoad()
        Dim tbl As New DataTable
        objBankAllocation.Clear()
        tbl = objBankAllocation.Search(objPortfolio)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Dim query = From a In tbl.AsEnumerable
                        Select
                                ID = a.Field(Of Integer)("CompanyID"),
                                Code = a.Field(Of String)("CompanyCode"),
                                Name = a.Field(Of String)("CompanyName"),
                                MaxAllocation = a.Field(Of Decimal)("MaxAllocation") * 100

            With DBGBankAllocation
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("MaxAllocation").NumberFormat = "n2"

                For Each column As C1DisplayColumn In DBGBankAllocation.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGBankAllocation.Columns.Clear()
        End If
        BankAllocationClear()
    End Sub

    Private Sub DBGBankAllocation_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBankAllocation.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGBankAllocation_Click(sender As Object, e As EventArgs) Handles DBGBankAllocation.Click
        If DBGBankAllocation.RowCount > 0 Then DBGBankAllocation.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGBankAllocation_DoubleClick(sender As Object, e As EventArgs) Handles DBGBankAllocation.DoubleClick
        bankAllocationSelect()
    End Sub

    Private Sub BankAllocationSelect()
        With DBGBankAllocation
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblBankAllocationID.Text = .Columns("ID").Text
                lblBankAllocationCode.Text = .Columns("Code").Text
                lblBankAllocationName.Text = .Columns("Name").Text
                txtMaxBankAllocation.Text = .Columns("MaxAllocation").Text
                btnRemoveBankAllocation.Enabled = True
                btnAddBankAllocation.Enabled = False
            End If
        End With
    End Sub

    Private Sub BankAllocationClear()
        btnAddBankAllocation.Enabled = True
        btnRemoveBankAllocation.Enabled = False
        lblBankAllocationID.Text = ""
        lblBankAllocationCode.Text = ""
        lblBankAllocationName.Text = ""
        txtMaxBankAllocation.Text = ""
    End Sub

    Private Sub btnBankAllocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBankAllocation.Click
        BankAllocationSearch()
    End Sub

    Private Sub BankAllocationSearch()
        Dim frm As New FormSelectBank
        frm.Show()
        frm.lblID = lblBankAllocationID
        frm.lblCode = lblBankAllocationCode
        frm.lblName = lblBankAllocationName
        frm.MdiParent = mdiso
    End Sub

    Private Sub btnBankAllocationAdd_Click(sender As Object, e As EventArgs) Handles btnAddBankAllocation.Click
        BankAllocationAdd()
    End Sub

    Private Sub BankAllocationAdd()
        If objPortfolio.GetPortfolioID > 0 And lblBankAllocationID.Text <> "" Then
            If Not IsNumeric(txtMaxBankAllocation.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " bank maximum allocation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objBankAllocation.Add(objPortfolio, CInt(lblBankAllocationID.Text), CDbl(txtMaxBankAllocation.Text))
            If objBankAllocation.ErrID = 0 Then
                BankAllocationLoad()
            Else
                ExceptionMessage.Show(objBankAllocation.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnRemoveBankAllocation_Click(sender As Object, e As EventArgs) Handles btnRemoveBankAllocation.Click, btnAllocationRemove.Click
        BankAllocationRemove()
    End Sub

    Private Sub BankAllocationRemove()
        If objPortfolio.GetPortfolioID > 0 And lblBankAllocationID.Text <> "" Then
            objBankAllocation.Remove(objPortfolio, CInt(lblBankAllocationID.Text))
            If objBankAllocation.ErrID = 0 Then
                BankAllocationLoad()
            Else
                ExceptionMessage.Show(objBankAllocation.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "issuer allocation"
    Private Sub IssuerAllocationLoad()
        Dim tbl As New DataTable
        objIssuerAllocation.Clear()
        tbl = objIssuerAllocation.Search(objPortfolio)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Dim query = From a In tbl.AsEnumerable
                        Select
                                ID = a.Field(Of Integer)("CompanyID"),
                                Code = a.Field(Of String)("CompanyCode"),
                                Name = a.Field(Of String)("CompanyName"),
                                MaxAllocation = a.Field(Of Decimal)("MaxAllocation") * 100

            With DBGIssuerAllocation
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("MaxAllocation").NumberFormat = "n2"

                For Each column As C1DisplayColumn In DBGIssuerAllocation.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGIssuerAllocation.Columns.Clear()
        End If
        IssuerAllocationClear()
    End Sub

    Private Sub DBGIssuerAllocation_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGIssuerAllocation.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGIssuerAllocation_Click(sender As Object, e As EventArgs) Handles DBGIssuerAllocation.Click
        If DBGIssuerAllocation.RowCount > 0 Then DBGIssuerAllocation.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGIssuerAllocation_DoubleClick(sender As Object, e As EventArgs) Handles DBGIssuerAllocation.DoubleClick
        IssuerAllocationSelect()
    End Sub

    Private Sub IssuerAllocationSelect()
        With DBGIssuerAllocation
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblIssuerAllocationID.Text = .Columns("ID").Text
                lblIssuerAllocationCode.Text = .Columns("Code").Text
                lblIssuerAllocationName.Text = .Columns("Name").Text
                txtMaxIssuerAllocation.Text = .Columns("MaxAllocation").Text
                btnRemoveIssuerAllocation.Enabled = True
                btnAddIssuerAllocation.Enabled = False
            End If
        End With
    End Sub

    Private Sub IssuerAllocationClear()
        btnAddIssuerAllocation.Enabled = True
        btnRemoveIssuerAllocation.Enabled = False
        lblIssuerAllocationID.Text = ""
        lblIssuerAllocationCode.Text = ""
        lblIssuerAllocationName.Text = ""
        txtMaxIssuerAllocation.Text = ""
    End Sub

    Private Sub btnIssuerAllocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssuerAllocation.Click
        IssuerAllocationSearch()
    End Sub

    Private Sub IssuerAllocationSearch()
        Dim frm As New FormSelectMarketCompany
        frm.Show()
        frm.lblID = lblIssuerAllocationID
        frm.lblCode = lblIssuerAllocationCode
        frm.lblName = lblIssuerAllocationName
        frm.MdiParent = mdiso
    End Sub

    Private Sub btnAddIssuerAllocation_Click(sender As Object, e As EventArgs) Handles btnAddIssuerAllocation.Click
        IssuerAllocationAdd()
    End Sub

    Private Sub IssuerAllocationAdd()
        If objPortfolio.GetPortfolioID > 0 And lblIssuerAllocationID.Text <> "" Then
            If Not IsNumeric(txtMaxIssuerAllocation.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " issuer maximum allocation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objIssuerAllocation.Add(objPortfolio, CInt(lblIssuerAllocationID.Text), CDbl(txtMaxIssuerAllocation.Text))
            If objIssuerAllocation.ErrID = 0 Then
                IssuerAllocationLoad()
            Else
                ExceptionMessage.Show(objIssuerAllocation.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnRemoveIssuerAllocation_Click(sender As Object, e As EventArgs) Handles btnRemoveIssuerAllocation.Click
        IssuerAllocationRemove()
    End Sub

    Private Sub IssuerAllocationRemove()
        If objPortfolio.GetPortfolioID > 0 And lblIssuerAllocationID.Text <> "" Then
            objIssuerAllocation.Remove(objPortfolio, CInt(lblIssuerAllocationID.Text))
            If objIssuerAllocation.ErrID = 0 Then
                IssuerAllocationLoad()
            Else
                ExceptionMessage.Show(objIssuerAllocation.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

End Class