Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.ParameterFA
Imports simpi.ParameterPortfolio
Imports simpi.GlobalException
Imports simpi.GlobalDate.GlobalDate
Imports simpi.CoreData
Imports simpi.CoreBilling

Public Class FormEODChargesAccrual
    Dim objSetting As New FundSetting
    Dim objAccrual As New FundAccrual
    Dim objExpense As New PositionExpenseCharges
    Dim objProcess As New ProcessAccrual
    Dim objPortfolio As New MasterPortfolio
    Dim objFee As New ParameterCharges
    Dim objNAV As New PortfolioNAV
    Dim objMTM As New PortfolioMTM
    Dim dtPortfolio As New DataTable
    Dim dtYTD As New DataTable
    Dim ytdDate As Date

    Private Sub FormEODManagementFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterCountry("")
        GetComboInit(New ParameterCharges, cmbFee, "FeeID", "FeeCode", False)
        objSetting.UserAccess = objAccess
        objAccrual.UserAccess = objAccess
        objProcess.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        objFee.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objExpense.UserAccess = objAccess
        DBGAccrual.FetchRowStyles = True
        DBGDaily.FetchRowStyles = True
        dtAs.Value = Now
        objPortfolio.Clear()
        dtPortfolio = objPortfolio.Search(objMasterSimpi, "", ParameterPortfolio.SetPortfolio, 0, 0, ParameterPortfolio.SetActive)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        AccrualSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then AccrualSearch()
    End Sub

#Region "accrual daily"
    Public Sub AccrualSearch()
        If cmbFee.SelectedIndex <> -1 Then
            Dim dtAccrual As New DataTable
            If dtPortfolio IsNot Nothing AndAlso dtPortfolio.Rows.Count > 0 Then
                objAccrual.Clear()
                dtAccrual = objAccrual.Search(objMasterSimpi, cmbFee.SelectedValue, dtAs.Value, txtKeyword.Text)
                Dim query = From p In dtPortfolio.AsEnumerable
                            Group Join a In dtAccrual.AsEnumerable On
                                  p.Field(Of Integer)("PortfolioID") Equals a.Field(Of Integer)("PortfolioID")
                            Into pa = Group Let a = pa.FirstOrDefault
                            Select
                             ID = If(a Is Nothing, 0, a.Field(Of Integer)("AccrualID")),
                             PortfolioID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             AUMDate = If(a Is Nothing, "", a.Field(Of Date)("AUMDate")),
                             AUM = If(a Is Nothing, 0, a.Field(Of Decimal)("AUMValue")),
                             Days = If(a Is Nothing, 0, a.Field(Of Integer)("AccrualDays")),
                             Rate = If(a Is Nothing, 0, a.Field(Of Decimal)("FlatRate") * 100),
                             Accrual = If(a Is Nothing, 0, a.Field(Of Decimal)("AccrualValue")),
                             VAT = If(a Is Nothing, 0, a.Field(Of Decimal)("AccrualVAT"))
                With DBGAccrual
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    .Columns("AUMDate").NumberFormat = "dd-MMM-yyyy"
                    .Columns("AUM").NumberFormat = "n2"
                    .Columns("Rate").NumberFormat = "n5"
                    .Columns("Accrual").NumberFormat = "n2"
                    .Columns("VAT").NumberFormat = "n2"

                    For Each column As C1DisplayColumn In DBGAccrual.Splits(0).DisplayColumns
                        If column.Name.Trim = "PortfolioID" Then
                            column.Visible = False
                        Else
                            column.AutoSize()
                        End If
                    Next

                    .Columns("AUMDate").Caption = "Date"

                End With
            Else
                DBGAccrual.Columns.Clear()
            End If
            AccrualClear()
        End If
    End Sub

    Private Sub DBGAccrual_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGAccrual.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGAccrual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAccrual.Click
        If DBGAccrual.RowCount > 0 Then DBGAccrual.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGAccrual_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAccrual.DoubleClick
        AccrualProfile()
    End Sub

    Private Sub AccrualProfile()
        With DBGAccrual
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblPortfolioID.Text = .Columns("PortfolioID").Text
                lblPortfolioCode.Text = .Columns("Code").Text
                lblPortfolioName.Text = .Columns("Name").Text
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objAccrual.Clear()
                    objAccrual.Load(objPortfolio, cmbFee.SelectedValue, dtAs.Value)
                    If objAccrual.ErrID = 0 Then
                        lblTypeCalculation.Text = ParameterFA.SetChargesCalculationType(objAccrual.GetTypeCalculation)
                        lblTypeAUM.Text = ParameterFA.SetChargesAUMType(objAccrual.GetTypeAUM)
                        lblFlatRate.Text = objAccrual.GetFlatRate.ToString("n5")
                        lblVATRate.Text = objAccrual.GetVATRate.ToString("n0")
                        If objAccrual.GetVATRate > 0 Then
                            lblVATType.Text = ParameterFA.SetChargesAccrualVAT(CByte(1))
                        Else
                            lblVATType.Text = ParameterFA.SetChargesAccrualVAT(CByte(2))
                        End If
                        lblBaseDays.Text = objAccrual.GetBaseDays
                        lblNAVDate.Text = objAccrual.GetAUMDate.ToString("dd-MMM-yyyy")
                        lblAccrualAUM.Text = objAccrual.GetAUMValue.ToString("n2")
                        lblAccrualDays.Text = objAccrual.GetAccrualDays
                        lblAccrualValue.Text = objAccrual.GetAccrualValue.ToString("n2")
                        lblAccrualVAT.Text = objAccrual.GetAccrualVAT.ToString("n2")
                        lblAccrualTotal.Text = (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT).ToString("n2")
                        lblAccrualID.Text = .Columns("ID").Text
                        DailyLoad()
                        btnSaveAccrual.Enabled = False
                        btnRemoveAccrual.Enabled = True
                    Else
                        objSetting.Clear()
                        objSetting.Load(objPortfolio, cmbFee.SelectedValue)
                        If objSetting.ErrID = 0 Then
                            lblTypeCalculation.Text = ParameterFA.SetChargesCalculationType(objSetting.GetTypeCalculation)
                            lblTypeAUM.Text = ParameterFA.SetChargesAUMType(objSetting.GetTypeAUM)
                            lblFlatRate.Text = objSetting.GetFlatRate.ToString("n5")
                            lblVATRate.Text = objSetting.GetVATRate.ToString("n0")
                            lblVATType.Text = ParameterFA.SetChargesAccrualVAT(objSetting.GetVATType)
                            lblBaseDays.Text = objSetting.GetBaseDays
                            objMTM.Clear()
                            objMTM.NextAt(objPortfolio, dtAs.Value)
                            If objMTM.ErrID = 0 Then
                                objNAV.Clear()
                                objNAV.LoadAt(objPortfolio, objMTM.GetPositionDate)
                                If objNAV.ErrID = 0 Then
                                    lblNAVDate.Text = objNAV.GetPositionDate.ToString("dd-MMM-yyyy")
                                    lblAccrualAUM.Text = objNAV.GetNAV.ToString("n2")
                                    lblAccrualDays.Text = DateDiff(DateInterval.Day, objNAV.GetPositionDate, objMTM.GetNextDate)
                                    lblAccrualValue.Text = ""
                                    lblAccrualVAT.Text = ""
                                    lblAccrualTotal.Text = ""
                                    btnSaveAccrual.Enabled = True
                                    btnRemoveAccrual.Enabled = False
                                Else
                                    lblNAVDate.Text = ""
                                    lblAccrualAUM.Text = ""
                                    lblAccrualDays.Text = ""
                                    lblAccrualValue.Text = ""
                                    lblAccrualVAT.Text = ""
                                    lblAccrualTotal.Text = ""
                                    btnSaveAccrual.Enabled = False
                                    btnRemoveAccrual.Enabled = False
                                    ExceptionMessage.Show(objNAV.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                lblNAVDate.Text = ""
                                lblAccrualAUM.Text = ""
                                lblAccrualDays.Text = ""
                                lblAccrualValue.Text = ""
                                lblAccrualVAT.Text = ""
                                lblAccrualTotal.Text = ""
                                btnSaveAccrual.Enabled = False
                                btnRemoveAccrual.Enabled = False
                                ExceptionMessage.Show(objMTM.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            ExceptionMessage.Show(objSetting.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub DailyLoad()
        Dim tbl As New DataTable
        tbl = objAccrual.Daily_Search()
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Dim query = From d In tbl.AsEnumerable
                        Select AccrualDate = d.Field(Of Date)("AccrualDate"),
                               AccrualDaily = d.Field(Of Decimal)("AccrualDaily")
            With DBGDaily
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("AccrualDate").NumberFormat = "dd-MMM-yyyy"
                .Columns("AccrualDaily").NumberFormat = "n2"

                For Each column As C1DisplayColumn In DBGDaily.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

                .Columns("AccrualDate").Caption = "Date"
                .Columns("AccrualDaily").Caption = "Accrual"

            End With
        Else
            DBGDaily.Columns.Clear()
        End If
    End Sub

    Private Sub DBGDaily_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGDaily.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub AccrualClear()
        lblPortfolioID.Text = ""
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblTypeCalculation.Text = ""
        lblTypeAUM.Text = ""
        lblFlatRate.Text = ""
        lblVATRate.Text = ""
        lblVATType.Text = ""
        lblBaseDays.Text = ""
        lblNAVDate.Text = ""
        lblAccrualAUM.Text = ""
        lblAccrualDays.Text = ""
        lblAccrualValue.Text = ""
        lblAccrualVAT.Text = ""
        lblAccrualTotal.Text = ""
        lblAccrualID.Text = ""
        DBGDaily.Columns.Clear()
        btnSaveAccrual.Enabled = False
        btnRemoveAccrual.Enabled = False
    End Sub

    Private Sub btnSaveAccrual_Click(sender As Object, e As EventArgs) Handles btnSaveAccrual.Click
        AccrualSave()
    End Sub

    Private Sub AccrualSave()
        If IsDate(lblNAVDate.Text) Then
            objProcess.Clear()
            objProcess.accrual_daily(objPortfolio, cmbFee.SelectedValue, lblNAVDate.Text)
            If objProcess.ErrID = 0 Then AccrualSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveAccrual_Click(sender As Object, e As EventArgs) Handles btnRemoveAccrual.Click
        AccrualRemove()
    End Sub

    Private Sub AccrualRemove()
        If IsNumeric(lblAccrualID.Text) Then
            objProcess.Clear()
            objProcess.accrual_daily_reverse(objPortfolio, lblAccrualID.Text)
            If objProcess.ErrID = 0 Then AccrualSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "reconcile daily"
    Public Sub ReconcileAccrualSearch()
        If cmbFee.SelectedIndex <> -1 Then
            Dim dtAccrual As New DataTable
            If dtPortfolio IsNot Nothing AndAlso dtPortfolio.Rows.Count > 0 Then
                objAccrual.Clear()
                dtAccrual = objAccrual.Search(objMasterSimpi, cmbFee.SelectedValue, dtAs.Value, txtKeyword.Text)
                Dim query = From p In dtPortfolio.AsEnumerable
                            Group Join a In dtAccrual.AsEnumerable On
                                  p.Field(Of Integer)("PortfolioID") Equals a.Field(Of Integer)("PortfolioID")
                            Into pa = Group Let a = pa.FirstOrDefault
                            Select
                             ID = If(a Is Nothing, 0, a.Field(Of Integer)("AccrualID")),
                             PortfolioID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             AUMDate = If(a Is Nothing, "", a.Field(Of Date)("AUMDate")),
                             AUM = If(a Is Nothing, 0, a.Field(Of Decimal)("AUMValue")),
                             Days = If(a Is Nothing, 0, a.Field(Of Integer)("AccrualDays")),
                             Rate = If(a Is Nothing, 0, a.Field(Of Decimal)("FlatRate") * 100),
                             Accrual = If(a Is Nothing, 0, a.Field(Of Decimal)("AccrualValue")),
                             VAT = If(a Is Nothing, 0, a.Field(Of Decimal)("AccrualVAT"))
                With DBGReconcileAccrual
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    .Columns("AUMDate").NumberFormat = "dd-MMM-yyyy"
                    .Columns("AUM").NumberFormat = "n2"
                    .Columns("Rate").NumberFormat = "n5"
                    .Columns("Accrual").NumberFormat = "n2"
                    .Columns("VAT").NumberFormat = "n2"

                    For Each column As C1DisplayColumn In DBGReconcileAccrual.Splits(0).DisplayColumns
                        If column.Name.Trim = "PortfolioID" Then
                            column.Visible = False
                        Else
                            column.AutoSize()
                        End If
                    Next

                    .Columns("AUMDate").Caption = "Date"

                End With
            Else
                DBGReconcileAccrual.Columns.Clear()
            End If
            ReconcileAccrualClear()
        End If
    End Sub

    Private Sub DBGReconcileAccrual_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGReconcileAccrual.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGReconcileAccrual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReconcileAccrual.Click
        If DBGReconcileAccrual.RowCount > 0 Then DBGReconcileAccrual.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGReconcileAccrual_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReconcileAccrual.DoubleClick
        ReconcileAccrualProfile()
    End Sub

    Private Sub ReconcileAccrualClear()
        lblPortfolioID.Text = ""
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblLastAmount.Text = ""
        lblLastAUM.Text = ""
        lblLastBeforeVAT.Text = ""
        lblLastDaily.Text = ""
        lblLastDate.Text = ""
        lblLastRate.Text = ""
        lblLastVAT.Text = ""
        lblAsAUM.Text = ""
        lblAsBeforeVAT.Text = ""
        lblAsDaily.Text = ""
        lblAsDay.Text = ""
        lblAsDate.Text = ""
        lblAsRate.Text = ""
        lblAsVAT.Text = ""
        lblReconcileAccrualID.Text = ""
        txtAsAmount.Text = ""
        txtAsAmount.ReadOnly = False
        btnSaveReconcileAccrual.Enabled = False
        btnRemoveReconcileAccrual.Enabled = False
    End Sub

    Private Sub ReconcileAccrualProfile()
        With DBGReconcileAccrual
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblPortfolioID.Text = .Columns("PortfolioID").Text
                lblPortfolioCode.Text = .Columns("Code").Text
                lblPortfolioName.Text = .Columns("Name").Text
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objSetting.Clear()
                    objSetting.Load(objPortfolio, cmbFee.SelectedValue)
                    If objSetting.ErrID = 0 Then
                        lblParameter.Text = objSetting.GetFlatRate.ToString("n5")
                        lblReconcileAccrualID.Text = .Columns("ID").Text
                        ReconcileAccrualLast()
                        ReconcileAccrualAs()
                    Else
                        ExceptionMessage.Show(objSetting.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub ReconcileAccrualLast()
        objAccrual.Clear()
        objAccrual.LoadBefore(objPortfolio, cmbFee.SelectedValue, dtAs.Value)
        If objAccrual.ErrID = 0 Then
            lblLastDate.Text = objAccrual.GetAccrualDate.ToString("dd-MMM-yyyy")
            lblLastAmount.Text = (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT).ToString("n2")
            lblLastDay.Text = objAccrual.GetAccrualDays
            lblLastDaily.Text = (IIf(objAccrual.GetAccrualDays = 0, 0, (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT) / objAccrual.GetAccrualDays)).ToString("n2")
            lblLastVAT.Text = objAccrual.GetAccrualVAT.ToString("n2")
            lblLastBeforeVAT.Text = objAccrual.GetAccrualValue.ToString("n2")
            lblLastAUM.Text = objAccrual.GetAUMValue.ToString("n2")
            lblLastRate.Text = objAccrual.GetFlatRate.ToString("n5")
        End If
    End Sub

    Private Sub ReconcileAccrualAs()
        objAccrual.Clear()
        objAccrual.Load(objPortfolio, cmbFee.SelectedValue, dtAs.Value)
        If objAccrual.ErrID = 0 Then
            lblAsDate.Text = objAccrual.GetAccrualDate.ToString("dd-MMM-yyyy")
            txtAsAmount.Text = (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT).ToString("n2")
            lblAsDay.Text = objAccrual.GetAccrualDays
            lblAsDaily.Text = (IIf(objAccrual.GetAccrualDays = 0, 0, (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT) / objAccrual.GetAccrualDays)).ToString("n2")
            lblAsVAT.Text = objAccrual.GetAccrualVAT.ToString("n2")
            lblAsBeforeVAT.Text = objAccrual.GetAccrualValue.ToString("n2")
            lblAsAUM.Text = objAccrual.GetAUMValue.ToString("n2")
            lblAsRate.Text = objAccrual.GetFlatRate.ToString("n5")
            txtAsAmount.ReadOnly = True
            btnSaveReconcileAccrual.Enabled = False
            btnRemoveReconcileAccrual.Enabled = True
        Else
            lblAsDate.Text = dtAs.Value.ToString("dd-MMM-yyyy")
            If lblLastDate.Text.Trim = "" Then lblLastDate.Text = objPortfolio.GetInceptionDate
            lblAsDay.Text = CalculateDays(CDate(lblLastDate.Text), dtAs.Value, "A")
            objNAV.Clear()
            objNAV.LoadAt(objPortfolio, lblLastDate.Text)
            If objNAV.ErrID = 0 Then
                lblAsAUM.Text = objNAV.GetNAV.ToString("n2")
            Else
                lblAsAUM.Text = "0.00"
            End If
            txtAsAmount.ReadOnly = False
            btnSaveReconcileAccrual.Enabled = True
            btnRemoveReconcileAccrual.Enabled = False
        End If
    End Sub

    Private Sub txtAsAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAsAmount.TextChanged
        ReconcileAccrualCalculate
    End Sub

    Private Sub ReconcileAccrualCalculate()
        If IsNumeric(txtAsAmount.Text) Then
            lblAsDaily.Text = (IIf(CInt(lblAsDay.Text) = 0, 0, CDbl(txtAsAmount.Text) / CInt(lblAsDay.Text))).ToString("n2")
            If ParameterFA.IsChargesVATPayment(objSetting.GetVATType) Then
                lblAsBeforeVAT.Text = txtAsAmount.Text
                lblAsVAT.Text = "0.00"
            Else
                lblAsBeforeVAT.Text = (CDbl(txtAsAmount.Text) / (1 + (objSetting.GetVATRate / 100))).ToString("n2")
                lblAsVAT.Text = (CDbl(txtAsAmount.Text) - CDbl(lblAsBeforeVAT.Text)).ToString("n2")
            End If
            If CDbl(lblAsAUM.Text) = 0 Then
                lblAsRate.Text = "0.00000"
            Else
                lblAsRate.Text = (CDbl(lblAsBeforeVAT.Text) / CDbl(lblAsAUM.Text) * BaseDays(objSetting.GetBaseDays, dtAs.Value) * 100).ToString("n5")
            End If
        Else
            lblAsDaily.Text = ""
            lblAsBeforeVAT.Text = ""
            lblAsVAT.Text = ""
            lblAsRate.Text = ""
        End If
    End Sub

    Private Sub btnSaveReconcileAccrual_Click(sender As Object, e As EventArgs) Handles btnSaveReconcileAccrual.Click
        ReconcileAccrualSave()
    End Sub

    Private Sub ReconcileAccrualSave()
        If lblAsRate.Text.Trim <> "" Then
            objProcess.Clear()
            objProcess.accrual_reconcile(objPortfolio, cmbFee.SelectedValue, lblLastDate.Text, lblAsAUM.Text,
                                         lblAsDate.Text, lblAsDay.Text, lblAsRate.Text, lblAsBeforeVAT.Text, lblAsVAT.Text)
            If objProcess.ErrID = 0 Then ReconcileAccrualSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveReconcileAccrual_Click(sender As Object, e As EventArgs) Handles btnRemoveReconcileAccrual.Click
        ReconcileAccrualRemove()
    End Sub

    Private Sub ReconcileAccrualRemove()
        If IsNumeric(lblReconcileAccrualID.Text) Then
            objProcess.Clear()
            objProcess.accrual_daily_reverse(objPortfolio, lblReconcileAccrualID.Text)
            If objProcess.ErrID = 0 Then ReconcileAccrualSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "reconcile ytd"
    Private Sub _ytdDate()
        ytdDate = New Date(dtAs.Value.Year, 1, 1)
    End Sub

    Public Sub ReconcileYTDSearch()
        If cmbFee.SelectedIndex <> -1 Then
            If dtPortfolio IsNot Nothing AndAlso dtPortfolio.Rows.Count > 0 Then
                objAccrual.Clear()
                dtYTD.Clear()
                dtYTD = objExpense.Search(cmbFee.SelectedValue, ytdDate, dtAs.Value, txtKeyword.Text)
                Dim query = From a In dtYTD.AsEnumerable
                            Group By key = New With {Key .PortfolioID = a.Field(Of Integer)("PortfolioID")}
                            Into Group Select New With {
                                 .PortfolioID = key.PortfolioID,
                                 .YTDExpense = Group.Sum(Function(r) r.Field(Of Decimal)("DailyExpense"))
                                 }

                Dim query2 = From p In dtPortfolio.AsEnumerable
                             Join c In dtCountry.AsEnumerable On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                             Group Join a In query On p.Field(Of Integer)("PortfolioID") Equals a.PortfolioID
                             Into pa = Group Let a = pa.FirstOrDefault
                             Select
                                ID = p.Field(Of String)("PortfolioID"),
                                Code = p.Field(Of String)("PortfolioCode"),
                                Name = p.Field(Of String)("PortfolioNameshort"),
                                Ccy = c.Field(Of String)("Ccy"),
                                YTD = If(a Is Nothing, 0, a.YTDExpense)

                With DBGReconcileYTD
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    .Columns("YTD").NumberFormat = "n2"

                    For Each column As C1DisplayColumn In DBGReconcileYTD.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGReconcileYTD.Columns.Clear()
            End If
            ReconcileYTDClear()
        End If
    End Sub

    Private Sub DBGReconcileYTD_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGReconcileYTD.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGReconcileYTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReconcileYTD.Click
        If DBGReconcileYTD.RowCount > 0 Then DBGReconcileYTD.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGReconcileYTD_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReconcileYTD.DoubleClick
        ReconcileYTDProfile()
    End Sub

    Private Sub ReconcileYTDClear()
        lblPortfolioID.Text = ""
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblYTDLast.Text = ""
        lblYTDLastAmount.Text = ""
        lblYTDLastAUM.Text = ""
        lblYTDLastBeforeVAT.Text = ""
        lblYTDLastDaily.Text = ""
        lblYTDLastDate.Text = ""
        lblYTDLastRate.Text = ""
        lblYTDLastVAT.Text = ""
        lblYTDAsAmount.Text = ""
        lblYTDAsAUM.Text = ""
        lblYTDAsBeforeVAT.Text = ""
        lblYTDAsDaily.Text = ""
        lblYTDAsDay.Text = ""
        lblYTDAsDate.Text = ""
        lblYTDAsRate.Text = ""
        lblYTDAsVAT.Text = ""
        txtYTDAs.Text = ""
        lblReconcileYTDID.Text = ""
        txtYTDAs.ReadOnly = False
        btnSaveReconcileAccrual.Enabled = False
        btnRemoveReconcileAccrual.Enabled = False
    End Sub

    Private Sub ReconcileYTDProfile()
        With DBGReconcileYTD
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblPortfolioID.Text = .Columns("ID").Text
                lblPortfolioCode.Text = .Columns("Code").Text
                lblPortfolioName.Text = .Columns("Name").Text
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objSetting.Clear()
                    objSetting.Load(objPortfolio, cmbFee.SelectedValue)
                    If objSetting.ErrID = 0 Then
                        lblYTDParameter.Text = objSetting.GetFlatRate.ToString("n5")
                        ReconcileYTDLast()
                        ReconcileYTDAs()
                    Else
                        ExceptionMessage.Show(objSetting.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub ReconcileYTDLast()
        objAccrual.Clear()
        objAccrual.LoadBefore(objPortfolio, cmbFee.SelectedValue, dtAs.Value)
        If objAccrual.ErrID = 0 Then
            lblYTDLastDate.Text = objAccrual.GetAccrualDate.ToString("dd-MMM-yyyy")
            lblYTDLast.Text = (From p In dtYTD.AsEnumerable
                               Where p.Field(Of Integer)("PortfolioID") = CInt(lblPortfolioID.Text) And
                                     p.Field(Of Date)("PositionDate") <= CDate(lblYTDLastDate.Text)
                               Select fee = p.Field(Of Decimal)("DailyExpense")).Sum().ToString("n2")
            lblYTDLastAmount.Text = (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT).ToString("n2")
            lblYTDLastDay.Text = objAccrual.GetAccrualDays
            lblYTDLastDaily.Text = (IIf(objAccrual.GetAccrualDays = 0, 0, (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT) / objAccrual.GetAccrualDays)).ToString("n2")
            lblYTDLastVAT.Text = objAccrual.GetAccrualVAT.ToString("n2")
            lblYTDLastBeforeVAT.Text = objAccrual.GetAccrualValue.ToString("n2")
            lblYTDLastAUM.Text = objAccrual.GetAUMValue.ToString("n2")
            lblYTDLastRate.Text = objAccrual.GetFlatRate.ToString("n5")
        End If
    End Sub

    Private Sub ReconcileYTDAs()
        objAccrual.Clear()
        objAccrual.Load(objPortfolio, cmbFee.SelectedValue, dtAs.Value)
        If objAccrual.ErrID = 0 Then
            lblYTDAsDate.Text = objAccrual.GetAccrualDate.ToString("dd-MMM-yyyy")
            txtYTDAs.Text = (From p In dtYTD.AsEnumerable
                             Where p.Field(Of Integer)("PortfolioID") = CInt(lblPortfolioID.Text)
                             Select fee = p.Field(Of Decimal)("DailyExpense")).Sum().ToString("n2")
            lblYTDAsAmount.Text = (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT).ToString("n2")
            lblYTDAsDay.Text = objAccrual.GetAccrualDays
            lblYTDAsDaily.Text = (IIf(objAccrual.GetAccrualDays = 0, 0, (objAccrual.GetAccrualValue + objAccrual.GetAccrualVAT) / objAccrual.GetAccrualDays)).ToString("n2")
            lblYTDAsVAT.Text = objAccrual.GetAccrualVAT.ToString("n2")
            lblYTDAsBeforeVAT.Text = objAccrual.GetAccrualValue.ToString("n2")
            lblYTDAsAUM.Text = objAccrual.GetAUMValue.ToString("n2")
            lblYTDAsRate.Text = objAccrual.GetFlatRate.ToString("n5")
            lblReconcileYTDID.Text = objAccrual.GetAccrualID
            txtYTDAs.ReadOnly = True
            btnSaveReconcileYTD.Enabled = False
            btnRemoveReconcileYTD.Enabled = True
        Else
            lblYTDAsDate.Text = dtAs.Value.ToString("dd-MMM-yyyy")
            If lblYTDLastDate.Text.Trim = "" Then lblYTDLastDate.Text = objPortfolio.GetInceptionDate
            lblYTDAsDay.Text = CalculateDays(CDate(lblYTDLastDate.Text), dtAs.Value, "A")
            objNAV.Clear()
            objNAV.LoadAt(objPortfolio, lblYTDLastDate.Text)
            If objNAV.ErrID = 0 Then
                lblYTDAsAUM.Text = objNAV.GetNAV.ToString("n2")
            Else
                lblYTDAsAUM.Text = "0.00"
            End If
            lblReconcileYTDID.Text = ""
            txtYTDAs.ReadOnly = False
            btnSaveReconcileYTD.Enabled = True
            btnRemoveReconcileYTD.Enabled = False
        End If
    End Sub

    Private Sub txtYTDAs_TextChanged(sender As Object, e As EventArgs) Handles txtYTDAs.TextChanged
        ReconcileYTDCalculate()
    End Sub

    Private Sub ReconcileYTDCalculate()
        If IsNumeric(txtYTDAs.Text) Then
            lblYTDAsAmount.Text = IIf(lblYTDLast.Text.Trim = "", txtYTDAs.Text, (CDbl(txtYTDAs.Text) - CDbl(lblYTDLast.Text)).ToString("n2"))
            lblYTDAsDaily.Text = (IIf(CInt(lblYTDAsDay.Text) = 0, 0, CDbl(lblYTDAsAmount.Text) / CInt(lblYTDAsDay.Text))).ToString("n2")
            If ParameterFA.IsChargesVATPayment(objSetting.GetVATType) Then
                lblYTDAsBeforeVAT.Text = lblYTDAsAmount.Text
                lblYTDAsVAT.Text = "0.00"
            Else
                lblYTDAsBeforeVAT.Text = (CDbl(lblYTDAsAmount.Text) / (1 + (objSetting.GetVATRate / 100))).ToString("n2")
                lblYTDAsVAT.Text = (CDbl(lblYTDAsAmount.Text) - CDbl(lblYTDAsBeforeVAT.Text)).ToString("n2")
            End If
            If CDbl(lblYTDAsAUM.Text) = 0 Then
                lblYTDAsRate.Text = "0.00000"
            Else
                lblYTDAsRate.Text = (CDbl(lblYTDAsBeforeVAT.Text) / CDbl(lblYTDAsAUM.Text) * BaseDays(objSetting.GetBaseDays, dtAs.Value) * 100).ToString("n5")
            End If
        Else
            lblYTDAsAmount.Text = ""
            lblYTDAsDaily.Text = ""
            lblYTDAsBeforeVAT.Text = ""
            lblYTDAsVAT.Text = ""
            lblYTDAsRate.Text = ""
        End If
    End Sub

    Private Sub btnSaveReconcileYTD_Click(sender As Object, e As EventArgs) Handles btnSaveReconcileYTD.Click
        ReconcileYTDSave()
    End Sub

    Private Sub ReconcileYTDSave()
        If lblYTDAsRate.Text.Trim <> "" Then
            objProcess.Clear()
            objProcess.accrual_reconcile(objPortfolio, cmbFee.SelectedValue, lblYTDLastDate.Text, lblYTDAsAUM.Text,
                       lblYTDAsDate.Text, lblYTDAsDay.Text, lblYTDAsRate.Text, lblYTDAsBeforeVAT.Text, lblYTDAsVAT.Text)
            If objProcess.ErrID = 0 Then ReconcileYTDSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveReconcileYTD_Click(sender As Object, e As EventArgs) Handles btnRemoveReconcileYTD.Click
        ReconcileYTDRemove()
    End Sub

    Private Sub ReconcileYTDRemove()
        If IsNumeric(lblReconcileYTDID.Text) Then
            objProcess.Clear()
            objProcess.accrual_daily_reverse(objPortfolio, lblReconcileYTDID.Text)
            If objProcess.ErrID = 0 Then ReconcileYTDSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

End Class