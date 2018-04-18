Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.MasterSecurities
Imports simpi.ParameterClient
Imports simpi.MasterClient
Imports simpi.MasterPortfolio
Imports simpi.MasterSimpi

Public Class FormAccountDistributorProfile
    Public CallerForm As FormAccountMaintenance
    Public objClient As MasterClientDistributor
    Dim objMasterClient As New MasterClient
    Dim objNominee As New MasterClientDistributorNominee
    Dim objOfficer As New ClientOfficer
    Dim objDocument As New ClientDocument
    Dim objBank As New FundDistributor
    Dim objPortfolio As New MasterPortfolio
    Dim objFundSimpi As New MasterSimpi

    Public Sub ClientLoad()
        If objClient.GetClientID = 0 Then
            Close()
        Else
            GetComboInit(New ParameterCountry, cmbAccountCcy, "CountryID", "Ccy")
            GetComboInit(New ParameterDocumentType, cmbDocumentType, "TypeID", "TypeCode")
            GetComboInit(New ParameterReligion, cmbOfficerReligion, "ReligionID", "ReligionCode")
            GetParameterCountry()
            GetParameterClientStatus()
            GetParameterClientReligion()
            GetParameterClientDocumentType()

            objMasterClient.UserAccess = objAccess
            objNominee.UserAccess = objAccess
            objOfficer.UserAccess = objAccess
            objDocument.UserAccess = objAccess
            objBank.UserAccess = objAccess
            objPortfolio.UserAccess = objAccess
            objFundSimpi.UserAccess = objAccess

            DBGBank.FetchRowStyles = True
            DBGSubAccount.FetchRowStyles = True
            DBGOfficer.FetchRowStyles = True
            DBGDocument.FetchRowStyles = True

            lblSimpiID.Text = objClient.GetMasterSimpi.GetSimpiID
            lblSimpiName.Text = objClient.GetMasterSimpi.GetSimpiName
            lblSalesCode.Text = objClient.GetMasterSales.GetSalesCode
            lblSalesName.Text = objClient.GetMasterSales.GetSimpiUser.GetUserName
            lblSalesHead.Text = objClient.GetMasterSales.GetTreeParentCode
            lblCode.Text = objClient.GetClientCode
            lblName.Text = objClient.GetClientName
            lblStatus.Text = objClient.GetClientStatus.GetStatusCode
            lblCorrespondenceAddress.Text = objClient.GetCorrespondenceAddress & " " &
                   objClient.GetCorrespondenceCity & " " & objClient.GetCorrespondenceProvince & " " &
                   objClient.GetCorrespondenceCountry.GetCountryName & " " & objClient.GetCorrespondencePostal
            lblCorrespondencePhone.Text = objClient.GetCorrespondencePhone
            lblCorrespondenceEmail.Text = objClient.GetCorrespondenceEmail
            lblValuation.Text = objClient.GetClientCcy.GetCcy
            lblXRate.Text = objClient.GetClientXRate.GetXRateCode

            lblTaxID.Text = objClient.GetTaxID
            lblBusinessActivity.Text = objClient.GetBusinessActivity.GetActivityCode
            lblBusinessType.Text = objClient.GetBusinessType.GetTypeCode
            If objClient.GetLocalForeign = "L"c Then
                rbLocal.Checked = True
            Else
                rbForegin.Checked = True
            End If
            lblAddressStreet.Text = objClient.GetCorrespondenceAddress
            lblAddressCity.Text = objClient.GetCorrespondenceCity
            lblAddressState.Text = objClient.GetCorrespondenceProvince
            lblAddressCountry.Text = objClient.GetCorrespondenceCountry.GetCountryName
            lblAddressPostal.Text = objClient.GetCorrespondencePostal
            lblPhone.Text = objClient.GetCorrespondencePhone
            lblEmail.Text = objClient.GetCorrespondenceEmail
            lblContactPerson.Text = objClient.GetContactPerson
            lblSignatureRule.Text = objClient.GetSignatureRule

            objMasterClient.Clear()
            objMasterClient.Load(objClient.GetMasterSimpi, objClient.GetClientCode)
            BankLoad()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ClientEdit()
    End Sub

    Private Sub ClientEdit()
        Dim frm As New FormAccountDistributorEdit
        frm.Show()
        frm.objClient = objClient
        frm.ClientLoad()
        frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

#Region "distributor fund"
    Private Sub BankLoad()
        Dim tbl As New DataTable
        objBank.Clear()
        tbl = objBank.Search(objClient, "")
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Dim query = From b In tbl.AsEnumerable
                        Join c In dtParameterCountry.AsEnumerable On
                             c.Field(Of Integer)("CountryID") Equals b.Field(Of Integer)("AccountCcyID")
                        Select
                             Code = b.Field(Of String)("PortfolioCode"),
                             Portfolio = b.Field(Of String)("PortfolioNameshort"),
                             simpi = b.Field(Of String)("simpiName"),
                             simpiEmail = b.Field(Of String)("simpiEmail"),
                             Bank = b.Field(Of String)("BankName"),
                             Branch = b.Field(Of String)("BankBranch"),
                             AccountNo = b.Field(Of String)("AccountNo"),
                             Name = b.Field(Of String)("AccountName"),
                             Ccy = c.Field(Of String)("Ccy"),
                             Notes = b.Field(Of String)("AccountNotes")

            With DBGBank
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGBank.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then
                        column.Visible = False
                    ElseIf column.Name.Trim = "Portfolio" Then
                        column.Visible = False
                    Else
                        column.AutoSize()
                    End If
                Next

            End With
        Else
            DBGBank.Columns.Clear()
        End If
        BankClear()
    End Sub

    Private Sub DBGBank_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBank.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub BankClear()
        btnAddBank.Enabled = True
        btnRemoveBank.Enabled = False
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblPortfolioSimpiName.Text = ""
        lblPortfolioSimpiEmail.Text = ""
        txtBankName.Text = ""
        txtBankBranch.Text = ""
        txtAccountNo.Text = ""
        txtAccountName.Text = ""
        txtAccountNotes.Text = ""
        cmbAccountCcy.SelectedIndex = -1
    End Sub

    Private Sub DBGBank_Click(sender As Object, e As EventArgs) Handles DBGBank.Click
        With DBGBank
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGBank_DoubleClick(sender As Object, e As EventArgs) Handles DBGBank.DoubleClick
        BankSelect()
    End Sub

    Private Sub BankSelect()
        With DBGBank
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblPortfolioCode.Text = .Columns("Code").Text
                lblPortfolioName.Text = .Columns("Portfolio").Text
                lblPortfolioSimpiName.Text = .Columns("simpi").Text
                lblPortfolioSimpiEmail.Text = .Columns("simpiEmail").Text
                txtBankName.Text = .Columns("Bank").Text
                txtBankBranch.Text = .Columns("Branch").Text
                txtAccountNo.Text = .Columns("AccountNo").Text
                txtAccountName.Text = .Columns("Name").Text
                txtAccountNotes.Text = .Columns("Notes").Text
                cmbAccountCcy.Text = .Columns("Ccy").Text
                btnAddBank.Enabled = False
                btnRemoveBank.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnSearchFund_Click(sender As Object, e As EventArgs) Handles btnSearchFund.Click
        Dim form As New FormSelectMasterPortfolioNormal
        form.lblCode = lblPortfolioCode
        form.lblName = lblPortfolioName
        form.lblSimpiEmail = lblPortfolioSimpiEmail
        form.lblSimpiName = lblPortfolioSimpiName
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblPortfolioSimpiEmail.Text = ""
        lblPortfolioSimpiName.Text = ""
        objPortfolio.Clear()
    End Sub

    Private Sub lblSimpiEmail_TextChanged(sender As Object, e As EventArgs) Handles lblPortfolioSimpiEmail.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objFundSimpi.Clear()
            objFundSimpi.Load(lblPortfolioSimpiEmail.Text)
            If objSimpi.ErrID = 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objFundSimpi, lblPortfolioCode.Text)
                If objPortfolio.ErrID <> 0 Then
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub chkBreakdown_CheckedChanged(sender As Object, e As EventArgs) Handles chkBreakdown.CheckedChanged
        If chkBreakdown.Checked Then
            chkBreakdown.Text = "Y"
        Else
            chkBreakdown.Text = "N"
        End If
    End Sub

    Private Sub btnAddBank_Click(sender As Object, e As EventArgs) Handles btnAddBank.Click
        BankAdd()
    End Sub

    Private Sub BankAdd()
        If objPortfolio.GetPortfolioID > 0 And txtBankName.Text.Trim <> "" And
            txtAccountNo.Text.Trim <> "" And cmbAccountCcy.SelectedIndex <> -1 Then

            objBank.Add(objClient, objPortfolio, chkBreakdown.Text, txtBankName.Text, txtBankBranch.Text,
                        txtAccountNo.Text, txtAccountName.Text, txtAccountNotes.Text, cmbAccountCcy.SelectedValue)
            If objBank.ErrID = 0 Then
                BankLoad()
            Else
                ExceptionMessage.Show(objBank.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnRemoveBank_Click(sender As Object, e As EventArgs) Handles btnRemoveBank.Click
        BankRemove()
    End Sub

    Private Sub BankRemove()
        If objPortfolio.GetPortfolioID > 0 Then

            objBank.Remove(objClient, objPortfolio)
            If objBank.ErrID = 0 Then
                BankLoad()
            Else
                ExceptionMessage.Show(objBank.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

#End Region

#Region "nominee"
    Private Sub btnSearchSubAccount_Click(sender As Object, e As EventArgs) Handles btnSearchSubAccount.Click
        SubAccountSearch()
    End Sub

    Private Sub txtKeywordSubAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordSubAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            SubAccountSearch()
        End If
    End Sub

    Public Sub SubAccountSearch()
        Dim dtClient As New DataTable
        objNominee.Clear()
        dtClient = objNominee.Search(objClient, -1, txtKeywordSubAccount.Text)
        If objNominee.ErrID = 0 Then
            If dtClient IsNot Nothing AndAlso dtClient.Rows.Count > 0 Then
                Dim query = From p In dtClient.AsEnumerable
                            Join s In dtParameterClientStatus.AsEnumerable On
                                   p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                            Select
                                 ID = p.Field(Of Integer)("ClientID"),
                                 Code = p.Field(Of String)("ClientCode"),
                                 Name = p.Field(Of String)("ClientName"),
                                 NomineeID = p.Field(Of String)("NomineeID"),
                                 NomineeName = p.Field(Of String)("NomineeName"),
                                 Status = s.Field(Of String)("StatusCode")

                With DBGSubAccount
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    For Each column As C1DisplayColumn In DBGSubAccount.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGSubAccount.Columns.Clear()
            End If

        Else
            DBGSubAccount.Columns.Clear()
            ExceptionMessage.Show(objNominee.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnProfileSubAccount.Enabled = False
    End Sub

    Private Sub DBGSubAccount_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGSubAccount.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGSubAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSubAccount.Click
        With DBGSubAccount
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfileSubAccount.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGSubAccount_DoubleClick(sender As Object, e As EventArgs) Handles DBGSubAccount.DoubleClick
        SubAccountProfile()
    End Sub

    Private Sub SubAccountAdd()
        Dim frm As New FormAccountDistributorNomineeAdd
        frm.CallerForm = Me
        frm.objParent = objClient
        frm.ParentLoad()
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnProfileSubAccount_Click(sender As Object, e As EventArgs) Handles btnProfileSubAccount.Click
        SubAccountProfile()
        'SubAccountAdd()
    End Sub

    Private Sub SubAccountProfile()
        With DBGSubAccount
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objNominee.Clear()
                objNominee.Load(objClient.GetMasterSimpi, .Columns("Code").Text)
                Dim frm As New FormAccountDistributorNomineeProfile
                frm.Show()
                frm.objClient = objNominee
                frm.ClientLoad()
                frm.CallerForm = Me
                frm.MdiParent = MDISO
            End If
        End With
    End Sub

#End Region

#Region "officer"
    Private Sub btnSearchOfficer_Click(sender As Object, e As EventArgs) Handles btnSearchOfficer.Click
        OfficerSearch()
    End Sub

    Private Sub txtKeywordOfficer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordOfficer.KeyDown
        If e.KeyCode = Keys.Enter Then
            OfficerSearch()
        End If
    End Sub

    Public Sub OfficerSearch()
        Dim tbl As New DataTable
        objOfficer.Clear()
        tbl = objOfficer.Search(objMasterClient, txtKeywordOfficer.Text)
        If objOfficer.ErrID = 0 Then
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                Dim query = From p In tbl.AsEnumerable
                            Join s In dtParameterClientReligion.AsEnumerable On
                                   p.Field(Of Integer)("OfficerReligionID") Equals
                                   s.Field(Of Integer)("ReligionID")
                            Select
                                 Name = p.Field(Of String)("OfficerName"),
                                 Title = p.Field(Of String)("OfficerTitle"),
                                 Phone = p.Field(Of String)("OfficerPhone"),
                                 Email = p.Field(Of String)("OfficerEmail"),
                                 Birth = p.Field(Of String)("OfficerBirthDate"),
                                 Religion = s.Field(Of String)("ReligionCode"),
                                 Spouse = p.Field(Of String)("OfficerSpouseName"),
                                 SpouseBirth = p.Field(Of String)("OfficerSpouseBirthDate"),
                                 Anniversary = p.Field(Of String)("OfficerSpouseAnniversary")

                With DBGOfficer
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    For Each column As C1DisplayColumn In DBGOfficer.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGOfficer.Columns.Clear()
            End If

        Else
            DBGOfficer.Columns.Clear()
            ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        OfficerClear()
    End Sub

    Private Sub DBGOfficer_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGOfficer.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub OfficerClear()
        btnAddOfficer.Enabled = True
        btnRemoveOfficer.Enabled = False
        btnEditOfficer.Enabled = False
        txtOfficerName.Enabled = True
        txtOfficerName.Text = ""
        txtOfficerPhone.Text = ""
        txtOfficerEmail.Text = ""
        txtOfficerSpouseName.Text = ""
        txtOfficerTitle.Text = ""
        chkOfficerAnniversarry.Checked = False
        chkOfficerSpouseBirth.Checked = False
        cmbOfficerReligion.SelectedIndex = -1
    End Sub

    Private Sub DBGOfficer_Click(sender As Object, e As EventArgs) Handles DBGOfficer.Click
        With DBGOfficer
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGOfficer_DoubleClick(sender As Object, e As EventArgs) Handles DBGOfficer.DoubleClick
        OfficerSelect()
    End Sub

    Private Sub OfficerSelect()
        With DBGOfficer
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnAddOfficer.Enabled = False
                btnEditOfficer.Enabled = True
                btnRemoveOfficer.Enabled = True
                txtOfficerName.Enabled = False
                txtOfficerName.Text = .Columns("Name").Text
                txtOfficerPhone.Text = .Columns("Phone").Text
                txtOfficerEmail.Text = .Columns("Email").Text
                txtOfficerSpouseName.Text = .Columns("Spouse").Text
                txtOfficerTitle.Text = .Columns("Title").Text
                cmbOfficerReligion.Text = .Columns("Religion").Text
                If .Columns("Birth").Text.Trim <> "" Then
                    If IsDate(.Columns("Birth").Text.Trim) Then
                        dtOfficerBirth.Value = CDate(.Columns("Birth").Text)
                    End If
                End If

                chkOfficerSpouseBirth.Checked = False
                If .Columns("SpouseBirth").Text.Trim <> "" Then
                    If IsDate(.Columns("SpouseBirth").Text.Trim) Then
                        dtOfficerSpouseBirth.Value = CDate(.Columns("SpouseBirth").Text)
                        chkOfficerSpouseBirth.Checked = True
                    End If
                End If

                chkOfficerAnniversarry.Checked = False
                If .Columns("Anniversary").Text.Trim <> "" Then
                    If IsDate(.Columns("Anniversary").Text.Trim) Then
                        dtOfficerAnniversary.Value = CDate(.Columns("Anniversary").Text)
                        chkOfficerAnniversarry.Checked = True
                    End If
                End If

            End If
        End With
    End Sub

    Private Sub chkOfficerSpouseBirth_CheckedChanged(sender As Object, e As EventArgs) Handles chkOfficerSpouseBirth.CheckedChanged
        If chkOfficerSpouseBirth.Checked Then
            chkOfficerSpouseBirth.Text = "Y"
        Else
            chkOfficerSpouseBirth.Text = "N"
        End If
    End Sub

    Private Sub chkOfficerAnniversarry_CheckedChanged(sender As Object, e As EventArgs) Handles chkOfficerAnniversarry.CheckedChanged
        If chkOfficerAnniversarry.Checked Then
            chkOfficerAnniversarry.Text = "Y"
        Else
            chkOfficerAnniversarry.Text = "N"
        End If
    End Sub

    Private Sub btnAddOfficer_Click(sender As Object, e As EventArgs) Handles btnAddOfficer.Click
        OfficerAdd()
    End Sub

    Private Sub OfficerAdd()
        If txtOfficerName.Text.Trim <> "" And cmbOfficerReligion.SelectedIndex <> -1 Then
            objOfficer.Add(objMasterClient, txtOfficerName.Text, txtOfficerTitle.Text, txtOfficerEmail.Text,
                           txtOfficerPhone.Text, dtOfficerBirth.Value.ToString("dd-MMM-yyyy"),
                           cmbOfficerReligion.SelectedValue, txtOfficerSpouseName.Text,
                           IIf(chkOfficerSpouseBirth.Checked, dtOfficerSpouseBirth.Value.ToString("dd-MMM-yyyy"), ""),
                           IIf(chkOfficerAnniversarry.Checked, dtOfficerAnniversary.Value.ToString("dd-MMM-yyyy"), ""),
                           1, "", "", 1, Now)
            If objOfficer.ErrID = 0 Then
                OfficerSearch()
            Else
                ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnEditOfficer_Click(sender As Object, e As EventArgs) Handles btnEditOfficer.Click
        OfficerEdit()
    End Sub

    Private Sub OfficerEdit()
        If txtOfficerName.Text.Trim <> "" And cmbOfficerReligion.SelectedIndex <> -1 Then
            objOfficer.Load(objMasterClient, txtOfficerName.Text)
            If objOfficer.ErrID = 0 Then
                objOfficer.Edit(txtOfficerTitle.Text, txtOfficerEmail.Text, txtOfficerPhone.Text,
                   dtOfficerBirth.Value.ToString("dd-MMM-yyyy"), cmbOfficerReligion.SelectedValue, txtOfficerSpouseName.Text,
                   IIf(chkOfficerSpouseBirth.Checked, dtOfficerSpouseBirth.Value.ToString("dd-MMM-yyyy"), ""),
                   IIf(chkOfficerAnniversarry.Checked, dtOfficerAnniversary.Value.ToString("dd-MMM-yyyy"), ""))
                If objOfficer.ErrID = 0 Then
                    OfficerSearch()
                Else
                    ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub btnRemoveOfficer_Click(sender As Object, e As EventArgs) Handles btnRemoveOfficer.Click
        OfficerRemove()
    End Sub

    Private Sub OfficerRemove()
        If txtOfficerName.Text.Trim <> "" Then
            objOfficer.Load(objMasterClient, txtOfficerName.Text)
            If objOfficer.ErrID = 0 Then
                objOfficer.Remove()
                If objOfficer.ErrID = 0 Then
                    OfficerSearch()
                Else
                    ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnOfficerIDCard_Click(sender As Object, e As EventArgs) Handles btnOfficerIDCard.Click
        OfficerIDCard()
    End Sub

    Private Sub OfficerIDCard()
        If txtOfficerName.Text.Trim <> "" Then
            objOfficer.Load(objMasterClient, txtOfficerName.Text)
            If objOfficer.ErrID = 0 Then
                Dim frm As New FormAccountInstitutionalIDCard
                frm.objOfficer = objOfficer
                frm.IDCardLoad()
                frm.lblCode.Text = lblCode.Text
                frm.lblName.Text = lblName.Text
                frm.lblOfficerTitle.Text = objOfficer.GetOfficerTitle
                frm.lblOfficerName.Text = txtOfficerName.Text
                frm.MdiParent = MDISO
                frm.Show()
            Else
                ExceptionMessage.Show(objOfficer.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "document"
    Private Sub btnSearchDocument_Click(sender As Object, e As EventArgs) Handles btnSearchDocument.Click
        DocumentSearch()
    End Sub

    Private Sub txtKeywordDocument_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordDocument.KeyDown
        If e.KeyCode = Keys.Enter Then
            DocumentSearch()
        End If
    End Sub

    Public Sub DocumentSearch()
        Dim tbl As New DataTable
        objDocument.Clear()
        tbl = objDocument.Search(objMasterClient, txtKeywordDocument.Text)
        If objDocument.ErrID = 0 Then
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                Dim query = From p In tbl.AsEnumerable
                            Join s In dtParameterClientDocumentType.AsEnumerable On
                                   p.Field(Of Integer)("TypeID") Equals s.Field(Of Integer)("TypeID")
                            Select
                                 Type = s.Field(Of String)("TypeCode"),
                                 Issuer = p.Field(Of String)("DocumentIssuer"),
                                 No = p.Field(Of String)("DocumentNo"),
                                 Title = p.Field(Of String)("DocumentTitle"),
                                 IsExpired = IIf(p.Field(Of SByte)("DocumentIsExpired") = 0, "N", "Y"),
                                 Expiry = p.Field(Of Date)("DocumentExpired")

                With DBGDocument
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    .Columns("Expiry").NumberFormat = "dd-MMM-yyyy"

                    For Each column As C1DisplayColumn In DBGDocument.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGDocument.Columns.Clear()
            End If

        Else
            DBGDocument.Columns.Clear()
            ExceptionMessage.Show(objDocument.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DocumentClear()
    End Sub

    Private Sub DBGDocument_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGDocument.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DocumentClear()
        btnAddDocument.Enabled = True
        btnEditDocument.Enabled = False
        btnRemoveDocument.Enabled = False
        cmbDocumentType.Enabled = True
        txtDocumentIssuer.Text = ""
        txtDocumentNo.Text = ""
        txtDocumentTitle.Text = ""
        chkDocumentIsExpired.Checked = False
        cmbDocumentType.SelectedIndex = -1
    End Sub

    Private Sub DBGDocument_Click(sender As Object, e As EventArgs) Handles DBGDocument.Click
        With DBGDocument
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGDocument_DoubleClick(sender As Object, e As EventArgs) Handles DBGDocument.DoubleClick
        DocumentSelect()
    End Sub

    Private Sub DocumentSelect()
        With DBGDocument
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnAddDocument.Enabled = False
                btnEditDocument.Enabled = True
                btnRemoveDocument.Enabled = True
                cmbDocumentType.Enabled = False
                txtDocumentIssuer.Text = .Columns("Issuer").Text
                txtDocumentNo.Text = .Columns("No").Text
                txtDocumentTitle.Text = .Columns("Title").Text
                If .Columns("IsExpired").Text = "N" Then
                    chkDocumentIsExpired.Checked = False
                Else
                    chkDocumentIsExpired.Checked = True
                End If
                dtDocumentExpired.Value = .Columns("Expiry").Text
                cmbDocumentType.Text = .Columns("Type").Text
            End If
        End With
    End Sub

    Private Sub chkDocumentIsExpired_CheckedChanged(sender As Object, e As EventArgs) Handles chkDocumentIsExpired.CheckedChanged
        If chkDocumentIsExpired.Checked Then
            chkDocumentIsExpired.Text = "Y"
        Else
            chkDocumentIsExpired.Text = "N"
        End If
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        DocumentAdd()
    End Sub

    Private Sub DocumentAdd()
        If txtDocumentNo.Text.Trim <> "" And cmbDocumentType.SelectedIndex <> -1 Then
            objDocument.Add(objMasterClient, cmbDocumentType.SelectedValue, txtDocumentNo.Text,
                            txtDocumentTitle.Text, txtDocumentIssuer.Text,
                            IIf(chkDocumentIsExpired.Checked, 1, 0), dtDocumentExpired.Value)
            If objDocument.ErrID = 0 Then
                DocumentSearch()
            Else
                ExceptionMessage.Show(objDocument.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnEditDocument_Click(sender As Object, e As EventArgs) Handles btnEditDocument.Click
        DocumentEdit()
    End Sub

    Private Sub DocumentEdit()
        If txtDocumentNo.Text.Trim <> "" And cmbDocumentType.SelectedIndex <> -1 Then
            objDocument.Load(objMasterClient, cmbDocumentType.SelectedValue)
            If objDocument.ErrID = 0 Then
                objDocument.Edit(objMasterClient, cmbDocumentType.SelectedValue, txtDocumentNo.Text,
                            txtDocumentTitle.Text, txtDocumentIssuer.Text,
                            IIf(chkDocumentIsExpired.Checked, 1, 0), dtDocumentExpired.Value)
                If objDocument.ErrID = 0 Then
                    DocumentSearch()
                Else
                    ExceptionMessage.Show(objDocument.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objDocument.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub btnRemoveDocument_Click(sender As Object, e As EventArgs) Handles btnRemoveDocument.Click
        DocumentRemove()
    End Sub

    Private Sub DocumentRemove()
        If cmbDocumentType.SelectedIndex <> -1 Then
            objDocument.Remove(objMasterClient, cmbDocumentType.SelectedValue)
            If objDocument.ErrID = 0 Then
                DocumentSearch()
            Else
                ExceptionMessage.Show(objDocument.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

End Class