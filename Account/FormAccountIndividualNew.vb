﻿Imports C1.Win.C1FlexGrid
Imports simpi.globalutilities
Imports simpi.MasterSecurities
Imports simpi.ParameterClient
Imports simpi.MasterSimpi
Imports simpi.MasterSales
Imports simpi.MasterClient
Imports simpi.globalutilities.GlobalString

Public Class FormAccountIndividualNew
    Public CallerForm As FormAccountMaintenance
    Dim objSales As New MasterSales
    Dim objClient As New MasterClientIndividu
    Dim objMasterClient As New MasterClient
    Dim objKYC As New SimpiKYC
    Dim objRisk As New SimpiRiskLevel
    Dim tblRisk As New DataTable
    Dim tblKYC As New DataTable
    Dim objClientKYC As New ClientKYC
    Dim objClientRisk As New ClientQuestioner
    Dim isKYC As Boolean = True
    Dim isRisk As Boolean = True

    Private Sub FormAccountIndividualNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        lblSimpiID.Text = objMasterSimpi.GetSimpiID
        lblSimpiName.Text = objMasterSimpi.GetSimpiName

        GetComboGender(cmbGender)
        GetComboInit(New ParameterReligion, cmbReligion, "ReligionID", "ReligionCode")
        GetComboInit(New ParameterCountry, cmbNationality, "CountryID", "Nationality")
        GetComboInit(New ParameterCountry, cmbAddressCountry, "CountryID", "CountryName")
        cmbAddressCountry.SelectedIndex = -1
        GetComboInit(New ParameterCountry, cmbValuation, "CountryID", "Ccy")
        GetComboInit(New ParameterXRate, cmbXRate, "XRateID", "XRateCode")
        GetComboInit(New ParameterEducationLevel, cmbEducation, "LevelID", "LevelCode")
        GetComboInit(New ParameterMaritalStatus, cmbMarital, "StatusID", "StatusCode")
        GetComboInit(New ParameterOccupation, cmbOccupation, "OccupationID", "OccupationCode")
        GetComboInit(New ParameterBusinessActivity, cmbOfficeBusinessActivity, "ActivityID", "ActivityCode")
        GetComboInit(New ParameterCountry, cmbAccountCcy, "CountryID", "Ccy")
        GetComboInit(New ParameterIDCardType, cmbIDCardType, "TypeID", "TypeCode")
        dtSpouseBirth.Value = Now
        dtIDCardExpired.Value = Now

        objSales.UserAccess = objAccess
        objClient.UserAccess = objAccess
        objRisk.UserAccess = objAccess
        objKYC.UserAccess = objAccess
        objMasterClient.UserAccess = objAccess
        objClientKYC.UserAccess = objAccess
        objClientRisk.UserAccess = objAccess

        fgRisk.DrawMode = DrawModeEnum.OwnerDraw
        fgKYC.DrawMode = DrawModeEnum.OwnerDraw
        fgKYCAnswer.DrawMode = DrawModeEnum.OwnerDraw

        RiskLoad()
        GetSimpiKYCField(1)
        KYCLoad()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

#Region "risk profile"
    Private Sub RiskLoad()
        tblRisk.Columns.Add("No", GetType(Integer))
        tblRisk.Columns.Add("Question", GetType(String))
        tblRisk.Columns.Add("Answer", GetType(String))
        tblRisk.Columns.Add("Value", GetType(Integer))

        Dim tbl As New DataTable
        tbl = objRisk.Question_Search(objMasterSimpi, 1)
        Dim query = From r In tbl.AsEnumerable
                    Select No = r.Field(Of Integer)("QuestionNo"),
                           Question = r.Field(Of String)("QuestionText")
        For Each item In query
            Dim dr As DataRow = tblRisk.NewRow()
            dr("No") = item.No
            dr("Question") = item.Question
            dr("Answer") = ""
            dr("Value") = 0
            tblRisk.Rows.Add(dr)
        Next

        RiskDisplay()
    End Sub

    Private Sub RiskDisplay()
        If tblRisk.Rows.Count > 0 Then
            fgRisk.DataSource = tblRisk
            fgRisk.AutoSizeCols()
        Else
            fgRisk.DataSource = Nothing
        End If
    End Sub

    Private Sub fgRisk_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgRisk.OwnerDrawCell
        Dim s As CellStyle = fgRisk.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgRisk.Rows(e.Row).Style = fgRisk.Styles("RowStyle")
    End Sub

    Private Sub fgRisk_BeforeEdit(sender As Object, e As RowColEventArgs) Handles fgRisk.BeforeEdit
        e.Cancel = True
    End Sub

    Private Sub fgRisk_DoubleClick(sender As Object, e As EventArgs) Handles fgRisk.DoubleClick
        RiskSelect()
    End Sub

    Private Sub RiskSelect()
        If fgRisk.Row > 0 Then
            lblRiskID.Text = fgRisk(fgRisk.Row, "No")
            lblRiskQuestion.Text = fgRisk(fgRisk.Row, "Question")
            AnswerClear()
            AnswerDisplay(CInt(fgRisk(fgRisk.Row, "No")), CInt(fgRisk(fgRisk.Row, "Value")))
        End If
    End Sub

    Private Sub AnswerDisplay(ByVal QuestionNo As Integer, ByVal AnswerValue As Integer)
        Dim tbl As New DataTable
        tbl = objRisk.Answer_Search(objMasterSimpi, ParameterClient.SetIndividu, QuestionNo)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            btnAnswerRisk.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            btnCancelRisk.Visibility = C1.Win.C1InputPanel.Visibility.Visible
            If tbl.Rows.Count > 0 Then
                rbRisk1.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk2.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk3.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk4.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk5.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk1.Text = CStr(GetNullData(tbl.Rows(0)("OptionText"), 0))
                lblRisk1.Text = CInt(GetNullData(tbl.Rows(0)("OptionValue"), 0))
                If AnswerValue = CInt(lblRisk1.Text) Then rbRisk1.Checked = True
            End If
            If tbl.Rows.Count > 1 Then
                rbRisk1.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk2.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk3.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk4.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk5.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk2.Text = CStr(GetNullData(tbl.Rows(1)("OptionText"), 0))
                lblRisk2.Text = CInt(GetNullData(tbl.Rows(1)("OptionValue"), 0))
                If AnswerValue = CInt(lblRisk2.Text) Then rbRisk2.Checked = True
            End If
            If tbl.Rows.Count > 2 Then
                rbRisk1.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk2.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk3.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk4.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk5.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk3.Text = CStr(GetNullData(tbl.Rows(2)("OptionText"), 0))
                lblRisk3.Text = CInt(GetNullData(tbl.Rows(2)("OptionValue"), 0))
                If AnswerValue = CInt(lblRisk3.Text) Then rbRisk3.Checked = True
            End If
            If tbl.Rows.Count > 3 Then
                rbRisk1.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk2.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk3.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk4.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk5.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
                rbRisk4.Text = CStr(GetNullData(tbl.Rows(3)("OptionText"), 0))
                lblRisk4.Text = CInt(GetNullData(tbl.Rows(3)("OptionValue"), 0))
                If AnswerValue = CInt(lblRisk4.Text) Then rbRisk4.Checked = True
            End If
            If tbl.Rows.Count > 4 Then
                rbRisk1.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk2.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk3.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk4.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk5.Visibility = C1.Win.C1InputPanel.Visibility.Visible
                rbRisk5.Text = CStr(GetNullData(tbl.Rows(4)("OptionText"), 0))
                lblRisk5.Text = CInt(GetNullData(tbl.Rows(4)("OptionValue"), 0))
                If AnswerValue = CInt(lblRisk5.Text) Then rbRisk5.Checked = True
            End If
        End If
    End Sub

    Private Sub AnswerClear()
        rbRisk1.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        rbRisk2.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        rbRisk3.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        rbRisk4.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        rbRisk5.Visibility = C1.Win.C1InputPanel.Visibility.Hidden

        rbRisk1.SelectedIndex = -1
        rbRisk2.SelectedIndex = -1
        rbRisk3.SelectedIndex = -1
        rbRisk4.SelectedIndex = -1
        rbRisk5.SelectedIndex = -1

        rbRisk1.Text = ""
        rbRisk2.Text = ""
        rbRisk3.Text = ""
        rbRisk4.Text = ""
        rbRisk5.Text = ""

        lblRisk1.Text = ""
        lblRisk2.Text = ""
        lblRisk3.Text = ""
        lblRisk4.Text = ""
        lblRisk5.Text = ""

        btnAnswerRisk.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        btnCancelRisk.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
    End Sub

    Private Sub btnAnswerRisk_Click(sender As Object, e As EventArgs) Handles btnAnswerRisk.Click
        RiskAnswer()
    End Sub

    Private Sub RiskAnswer()
        If lblRiskID.Text.Trim <> "" And (rbRisk1.Checked Or rbRisk2.Checked Or rbRisk3.Checked Or rbRisk4.Checked Or rbRisk5.Checked) Then
            Dim rowRisk() As DataRow = tblRisk.Select("No = " & Str(CInt(lblRiskID.Text)))
            If rbRisk1.Checked Then
                lblRiskScore.Text = CInt(lblRiskScore.Text) + CInt(lblRisk1.Text) - CInt(rowRisk(0)("Value"))
                rowRisk(0)("Answer") = rbRisk1.Text
                rowRisk(0)("Value") = lblRisk1.Text
            ElseIf rbRisk2.Checked Then
                lblRiskScore.Text = CInt(lblRiskScore.Text) + CInt(lblRisk2.Text) - CInt(rowRisk(0)("Value"))
                rowRisk(0)("Answer") = rbRisk2.Text
                rowRisk(0)("Value") = lblRisk2.Text
            ElseIf rbRisk3.Checked Then
                lblRiskScore.Text = CInt(lblRiskScore.Text) + CInt(lblRisk3.Text) - CInt(rowRisk(0)("Value"))
                rowRisk(0)("Answer") = rbRisk3.Text
                rowRisk(0)("Value") = lblRisk3.Text
            ElseIf rbRisk4.Checked Then
                lblRiskScore.Text = CInt(lblRiskScore.Text) + CInt(lblRisk4.Text) - CInt(rowRisk(0)("Value"))
                rowRisk(0)("Answer") = rbRisk4.Text
                rowRisk(0)("Value") = lblRisk4.Text
            ElseIf rbRisk5.Checked Then
                lblRiskScore.Text = CInt(lblRiskScore.Text) + CInt(lblRisk5.Text) - CInt(rowRisk(0)("Value"))
                rowRisk(0)("Answer") = rbRisk5.Text
                rowRisk(0)("Value") = lblRisk5.Text
            End If
            lblRiskCode.Text = objRisk.GetSimpiRiskLevel(objMasterSimpi, CInt(lblRiskScore.Text))
            lblRiskID.Text = ""
            lblRiskQuestion.Text = ""
            AnswerClear()
            RiskDisplay()
        End If
    End Sub

    Private Sub btnCancelRisk_Click(sender As Object, e As EventArgs) Handles btnCancelRisk.Click
        RiskCancel()
    End Sub

    Private Sub RiskCancel()
        If lblRiskID.Text.Trim <> "" Then
            Dim rowRisk() As DataRow = tblRisk.Select("No = " & Str(CInt(lblRiskID.Text)))
            lblRiskScore.Text = CInt(lblRiskScore.Text) - CInt(rowRisk(0)("Value"))
            rowRisk(0)("Answer") = ""
            rowRisk(0)("Value") = 0
            lblRiskCode.Text = objRisk.GetSimpiRiskLevel(objMasterSimpi, CInt(lblRiskScore.Text))
            lblRiskID.Text = ""
            lblRiskQuestion.Text = ""
            AnswerClear()
            RiskDisplay()
        End If
    End Sub

#End Region

#Region "kyc"
    Private Sub KYCLoad()
        tblKYC.Columns.Add("ID", GetType(Integer))
        tblKYC.Columns.Add("KYC", GetType(String))
        tblKYC.Columns.Add("Answer", GetType(String))
        tblKYC.Columns.Add("Description", GetType(String))
        Dim query = From r In dtSimpiKYC.AsEnumerable
                    Select ID = r.Field(Of Integer)("kycID"),
                           KYC = r.Field(Of String)("kycCode"),
                           Description = r.Field(Of String)("kycDescription")
        For Each item In query
            Dim dr As DataRow = tblKYC.NewRow()
            dr("ID") = item.ID
            dr("KYC") = item.KYC
            dr("Answer") = ""
            dr("Description") = item.Description
            tblKYC.Rows.Add(dr)
        Next

        KYCDisplay()
    End Sub

    Private Sub KYCDisplay()
        If tblKYC.Rows.Count > 0 Then
            fgKYC.DataSource = tblKYC
            fgKYC.AutoSizeCols()
            fgKYC.Cols("Description").Width = 0
        Else
            fgKYC.DataSource = Nothing
        End If
    End Sub

    Private Sub fgKYC_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgKYC.OwnerDrawCell
        Dim s As CellStyle = fgKYC.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgKYC.Rows(e.Row).Style = fgKYC.Styles("RowStyle")
    End Sub

    Private Sub fgKYC_BeforeEdit(sender As Object, e As RowColEventArgs) Handles fgKYC.BeforeEdit
        e.Cancel = True
    End Sub

    Private Sub fgKYC_DoubleClick(sender As Object, e As EventArgs) Handles fgKYC.DoubleClick
        KYCSelect()
    End Sub

    Private Sub KYCSelect()
        If fgKYC.Row > 0 Then
            lblKYCID.Text = fgKYC(fgKYC.Row, "ID")
            lblKYCCode.Text = fgKYC(fgKYC.Row, "KYC")
            lblKYCDescription.Text = fgKYC(fgKYC.Row, "Description")
            txtKYCAnswer.Text = fgKYC(fgKYC.Row, "Answer")

            Dim tbl As New DataTable
            tbl = objKYC.Answer_Search(CInt(lblKYCID.Text))
            Dim query = From k In tbl.AsEnumerable
                        Select ID = k.Field(Of Integer)("AnswerID"), Answer = k.Field(Of String)("AnswerText")
            If tbl.Rows.Count > 0 Then
                fgKYCAnswer.DataSource = query.ToList
                fgKYCAnswer.AutoSizeCols()
            Else
                fgKYCAnswer.DataSource = Nothing
            End If
        End If
    End Sub

    Private Sub fgKYCAnswer_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgKYCAnswer.OwnerDrawCell
        Dim s As CellStyle = fgKYCAnswer.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgKYCAnswer.Rows(e.Row).Style = fgKYCAnswer.Styles("RowStyle")
    End Sub

    Private Sub fgKYCAnswer_BeforeEdit(sender As Object, e As RowColEventArgs) Handles fgKYCAnswer.BeforeEdit
        e.Cancel = True
    End Sub

    Private Sub fgKYCAnswer_DoubleClick(sender As Object, e As EventArgs) Handles fgKYCAnswer.DoubleClick
        KYCAnswerSelect()
    End Sub

    Private Sub KYCAnswerSelect()
        If fgKYCAnswer.Row > 0 Then txtKYCAnswer.Text = fgKYCAnswer(fgKYCAnswer.Row, "Answer")
    End Sub

    Private Sub btnAnswerKYC_Click(sender As Object, e As EventArgs) Handles btnAnswerKYC.Click
        KYCAnswer()
    End Sub

    Private Sub KYCAnswer()
        If lblKYCID.Text.Trim <> "" And txtKYCAnswer.Text.Trim <> "" Then
            Dim rowKYC() As DataRow = tblKYC.Select("ID = " & Str(CInt(lblKYCID.Text)))
            rowKYC(0)("Answer") = txtKYCAnswer.Text
            KYCClear()
            KYCDisplay()
        End If
    End Sub

    Private Sub btnCancelKYC_Click(sender As Object, e As EventArgs) Handles btnCancelKYC.Click
        KYCCancel()
    End Sub

    Private Sub KYCCancel()
        If lblKYCID.Text.Trim <> "" Then
            Dim rowKYC() As DataRow = tblKYC.Select("ID = " & Str(CInt(lblKYCID.Text)))
            rowKYC(0)("Answer") = ""
            KYCClear()
            KYCDisplay()
        End If
    End Sub

    Private Sub KYCClear()
        lblKYCID.Text = ""
        lblKYCCode.Text = ""
        lblKYCDescription.Text = ""
        txtKYCAnswer.Text = ""
        fgKYCAnswer.DataSource = Nothing
    End Sub

#End Region

#Region "sales"
    Private Sub btnSearchSales_Click(sender As Object, e As EventArgs) Handles btnSearchSales.Click
        SalesSearch()
    End Sub

    Private Sub SalesSearch()
        Dim form As New FormSelectMasterSales
        form.Show()
        form.lblSalesCode = lblSalesCode
        form.lblSalesName = lblSalesName
        form.MdiParent = MDISO
    End Sub

    Private Sub lblSalesCode_TextChanged(sender As Object, e As EventArgs) Handles lblSalesCode.TextChanged
        SalesLoad()
    End Sub

    Private Sub SalesLoad()
        If lblSalesCode.Text.Trim <> "" Then
            objSales.Clear()
            objSales.Load(objMasterSimpi, lblSalesCode.Text)
            If objSales.ErrID = 0 Then
                lblSalesHead.Text = objSales.GetTreeParentCode
            Else
                ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

#Region "name"
    Private Sub txtNameFirst_TextChanged(sender As Object, e As EventArgs) Handles txtNameFirst.TextChanged
        ClientName()
    End Sub

    Private Sub txtNameMiddle_TextChanged(sender As Object, e As EventArgs) Handles txtNameMiddle.TextChanged
        ClientName()
    End Sub

    Private Sub txtNameLast_TextChanged(sender As Object, e As EventArgs) Handles txtNameLast.TextChanged
        ClientName()
    End Sub

    Private Sub txtTitleFirst_TextChanged(sender As Object, e As EventArgs) Handles txtTitleFirst.TextChanged
        ClientName()
    End Sub

    Private Sub txtTitleLast_TextChanged(sender As Object, e As EventArgs) Handles txtTitleLast.TextChanged
        ClientName()
    End Sub

    Private Sub ClientName()
        txtName.Text = txtTitleFirst.Text.Trim & " " & txtNameFirst.Text.Trim & " " &
                       txtNameMiddle.Text.Trim & " " & txtNameLast.Text.Trim & " " & txtTitleLast.Text.Trim

    End Sub

#End Region

#Region "address"
    Private Sub txtAddressStreet_TextChanged(sender As Object, e As EventArgs) Handles txtAddressStreet.TextChanged
        ClientAddress()
    End Sub

    Private Sub txtAddressCity_TextChanged(sender As Object, e As EventArgs) Handles txtAddressCity.TextChanged
        ClientAddress()
    End Sub

    Private Sub txtAddressState_TextChanged(sender As Object, e As EventArgs) Handles txtAddressState.TextChanged
        ClientAddress()
    End Sub

    Private Sub txtAddressPostal_TextChanged(sender As Object, e As EventArgs) Handles txtAddressPostal.TextChanged
        ClientAddress()
    End Sub

    Private Sub cmbAddressCountry_TextChanged(sender As Object, e As EventArgs) Handles cmbAddressCountry.TextChanged
        ClientAddress()
    End Sub

    Private Sub ClientAddress()
        lblCorrespondenceAddress.Text = txtAddressStreet.Text.Trim & " " & txtAddressCity.Text.Trim & " " &
                       txtAddressState.Text.Trim & " " & cmbAddressCountry.Text.Trim & " " & txtAddressPostal.Text.Trim
    End Sub

#End Region

#Region "save"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Function _check() As Boolean
        If objSales.GetSalesID = 0 Then
            ExceptionMessage.Show(objError.Message(81) & " master sales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbValuation.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " client valuation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbXRate.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " client exchange currency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbAddressCountry.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " address country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbGender.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbNationality.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " nationality", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbEducation.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " education level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbOccupation.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " occupation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbReligion.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " religion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbOfficeBusinessActivity.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " business activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbMarital.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " marital status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbIDCardType.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " IDCard type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If txtBankName.Text.Trim = "" Then
            ExceptionMessage.Show(objError.Message(81) & " bank name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If txtAccountNo.Text.Trim = "" Then
            ExceptionMessage.Show(objError.Message(81) & " account no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If
        If cmbAccountCcy.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(81) & " account currenncy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub DataSave()
        If _check() Then
            objClient.Clear()
            objClient.Add(objMasterSimpi, objSales, txtName.Text, cmbValuation.SelectedValue,
                          objRisk.GetSimpiRiskLevelID(objMasterSimpi, lblRiskScore.Text), cmbXRate.SelectedValue,
                          IIf(rbLocal.Checked, "L"c, "F"c), txtAddressStreet.Text, txtAddressCity.Text,
                          txtAddressState.Text, cmbAddressCountry.SelectedValue, txtAddressPostal.Text, txtPhone.Text,
                          txtEmail.Text, txtNameFirst.Text, txtNameMiddle.Text, txtNameLast.Text, txtTitleFirst.Text,
                          txtTitleLast.Text, txtBirthPlace.Text, dtBirth.Value, txtMMN.Text, txtTaxID.Text,
                          cmbGender.Text, cmbNationality.SelectedValue, cmbReligion.SelectedValue, cmbEducation.SelectedValue,
                          cmbOccupation.SelectedValue, txtOfficeName.Text, txtOfficeAddress.Text, txtOfficePhone.Text,
                          cmbOfficeBusinessActivity.SelectedValue, cmbMarital.SelectedValue, txtSpouseName.Text,
                          IIf(chkSpouseBirth.Checked, dtSpouseBirth.Value.ToString("dd-MMM-yyyy"), ""),
                          cmbIDCardType.SelectedValue, txtIDCardNo.Text, txtIDCardIssuer.Text,
                          IIf(chkIDCardIsExpired.Checked, 1, 0), dtIDCardExpired.Value)
            If objClient.ErrID = 0 Then
                objMasterClient.Clear()
                objMasterClient.Load(objMasterSimpi, objClient.GetClientCode)
                _saveBank()
                _saveKYC()
                _saveRisk()
                'dms IDCard
                'dms signature
                CallerForm.ClientSearch()
                Close()
            Else
                ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub _saveBank()
        Dim objBank As New ClientBankAccount
        objBank.UserAccess = objAccess
        objBank.Add(objMasterClient, txtBankName.Text, txtBankBranch.Text, txtAccountNo.Text,
                    txtAccountName.Text, txtAccountNotes.Text, cmbAccountCcy.SelectedValue)
        If objBank.ErrID <> 0 Then ExceptionMessage.Show(objBank.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub _saveKYC()
        Dim kycID As Integer = 0
        Dim kycAnswer As String = ""
        If tblKYC.Rows.Count > 0 Then
            For i = 0 To tblKYC.Rows.Count - 1
                kycID = CInt(GetNullData(tblKYC.Rows(i)("ID"), 1))
                kycAnswer = CStr(GetNullData(tblKYC.Rows(i)("Answer"), 0))
                If kycAnswer.Trim <> "" Then objClientKYC.Add(objMasterClient, kycID, kycAnswer)
            Next
        End If
    End Sub

    Private Sub _saveRisk()
        If tblRisk.Rows.Count > 0 Then
            objClientRisk.Add(objMasterClient)
            For i = 0 To tblRisk.Rows.Count - 1
                If CStr(GetNullData(tblRisk.Rows(i)("Answer"), 0)).Trim <> "" Then
                    objClientRisk.Answer_Insert(CInt(GetNullData(tblRisk.Rows(i)("No"), 1)), CStr(GetNullData(tblRisk.Rows(i)("Question"), 0)),
                                                CStr(GetNullData(tblRisk.Rows(i)("Answer"), 0)), CInt(GetNullData(tblRisk.Rows(i)("Value"), 1)))
                End If
            Next
        End If
    End Sub

    Private Sub chkSpouseBirth_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpouseBirth.CheckedChanged
        If chkSpouseBirth.Checked Then chkSpouseBirth.Text = "Y" Else chkSpouseBirth.Text = "N"
    End Sub

    Private Sub chkIDCardIsExpired_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDCardIsExpired.CheckedChanged
        If chkIDCardIsExpired.Checked Then chkIDCardIsExpired.Text = "Y" Else chkIDCardIsExpired.Text = "N"
    End Sub

#End Region

End Class