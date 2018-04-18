Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.ParameterFA
Imports simpi.ParameterPortfolio
Imports simpi.globalutilities
Imports simpi.CoreData
Imports simpi.CoreBilling

Public Class FormEODOverrideCharges
    Dim objPortfolio As New MasterPortfolio

    Dim objSetting As New FundSetting
    Dim objAccrual As New FundAccrual
    Dim objProcess As New ProcessAccrual
    Dim objMTM As New PortfolioMTM
    Dim objNAV As New PortfolioNAV

    Private Sub csMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles csMenu.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Detach"
                MdiParent = Nothing
                e.ClickedItem.Text = "Attach"
            Case "Attach"
                e.ClickedItem.Text = "Detach"
                MdiParent = MDISO
            Case "Close"
                Close()
            Case "Export"
                PrintExcel(DBGAccrual)
        End Select
    End Sub

    Private Sub FormEODOverrideCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetPortfolioMaster()
        GetParameterCountry()
        GetComboInit(New ParameterCharges, cmbFee, "FeeID", "FeeCode")
        objPortfolio.UserAccess = objAccess
        objSetting.UserAccess = objAccess
        objAccrual.UserAccess = objAccess
        objProcess.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        DBGAccrual.FetchRowStyles = True
        DBGDaily.FetchRowStyles = True
        dtAs.Value = Now
        objPortfolio.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        AccrualSearch()
    End Sub

    Public Sub AccrualSearch()
        If cmbFee.SelectedIndex <> -1 Then
            Dim dtAccrual As New DataTable
            If dtPortfolioMaster IsNot Nothing AndAlso dtPortfolioMaster.Rows.Count > 0 Then
                objAccrual.Clear()
                dtAccrual = objAccrual.Search(objMasterSimpi, cmbFee.SelectedValue, dtAs.Value, "")
                Dim query = From p In dtPortfolioMaster.AsEnumerable
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

                lblTotalAccrual.Text = (From q In query Select q.Accrual).Sum.ToString("n0")

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
                        If column.Name.Trim = "PortfolioID" Then column.Visible = False Else column.AutoSize()
                    Next
                    .Columns("AUMDate").Caption = "Date"

                End With
            Else
                DBGAccrual.Columns.Clear()
            End If
            AccrualClear()
        End If
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
        txtCurrent.Text = ""
        txtLast.Text = ""
        txtPayment.Text = ""
        lblMovement.Text = ""
        lblNet.Text = ""
        lblDaily.Text = ""
        DBGDaily.Columns.Clear()
        btnSaveAccrual.Enabled = False
        btnRemoveAccrual.Enabled = False
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

    Private Sub btnSaveAccrual_Click(sender As Object, e As EventArgs) Handles btnSaveAccrual.Click
        AccrualSave()
    End Sub

    Private Sub AccrualSave()
        If IsDate(lblNAVDate.Text) Then
            objProcess.Clear()
            objProcess.accrual_daily(objPortfolio, cmbFee.SelectedValue, CDate(lblNAVDate.Text))
            If objProcess.ErrID = 0 Then AccrualSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveAccrual_Click(sender As Object, e As EventArgs) Handles btnRemoveAccrual.Click
        AccrualRemove()
    End Sub

    Private Sub AccrualRemove()
        If IsNumeric(lblAccrualID.Text) Then
            objProcess.Clear()
            objProcess.accrual_daily_reverse(objPortfolio, CInt(lblAccrualID.Text))
            If objProcess.ErrID = 0 Then AccrualSearch() Else ExceptionMessage.Show(objProcess.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtCurrent_TextChanged(sender As Object, e As EventArgs) Handles txtCurrent.TextChanged
        calculateAccrual
    End Sub

    Private Sub txtLast_TextChanged(sender As Object, e As EventArgs) Handles txtLast.TextChanged
        calculateAccrual
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        CalculateAccrual()
    End Sub

    Private Sub lblAccrualDays_TextChanged(sender As Object, e As EventArgs) Handles lblAccrualDays.TextChanged
        calculateAccrual
    End Sub

    Private Sub CalculateAccrual()
        Dim last, current, accrual, net, payment As Double
        Dim days As Integer
        Double.TryParse(txtCurrent.Text, current)
        Double.TryParse(txtLast.Text, last)
        Double.TryParse(txtPayment.Text, payment)
        Integer.TryParse(lblAccrualDays.Text, days)
        accrual = current - (last - payment)
        lblMovement.Text = accrual.ToString("n2")
        net = accrual / 1.1
        lblNet.Text = net.ToString("n2")
        If days = 0 Then lblDaily.Text = "0" Else lblDaily.Text = (net / days).ToString("n2")
    End Sub


End Class