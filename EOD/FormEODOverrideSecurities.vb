Imports System.IO
Imports Microsoft.Office.Interop
Imports simpi.GlobalUtilities
Imports simpi.GlobalUtilities.GlobalDate
Imports simpi.CoreData
Imports simpi.CoreOverride
Imports simpi.MasterSecurities
Imports simpi.ParameterSecurities
Imports simpi.ParameterSecurities.ParameterSecurities
Imports simpi.MasterPortfolio
Imports simpi.MarketInstrument
Imports simpi.MarketDatabase
Imports C1.Win.C1FlexGrid

Public Class FormEODOverrideSecurities
    Dim objPortfolio As New MasterPortfolio
    Dim objSecurities As New MarketInstrument
    Dim objBond As New MarketInstrumentBond
    Dim objMTM As New PortfolioMTM
    Dim objPosition As New PositionSecurities
    Dim objPricing As New PortfolioPricing
    Dim objPrice As New MarketPrice
    Dim objOverride As New OverrideSecurities

    Dim dtPosition As New DataTable
    Dim no As Integer
    Dim qty, price, accrued As Double

    Private Sub FormEODOverrideSecurities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        GetParameterInstrumentType()
        GetComboInit(New ParameterExternalSystem, cmbExternalPortfolio, "SystemID", "SystemCode")
        GetComboInit(New ParameterExternalSystem, cmbExternalSecurities, "SystemID", "SystemCode")
        GetComboInitAll(New ParameterInstrumentType, cmbType, "TypeID", "TypeCode")
        objPortfolio.UserAccess = objAccess
        objSecurities.UserAccess = objAccess
        objBond.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objPosition.UserAccess = objAccess
        objPricing.UserAccess = objAccess
        objPrice.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        fgManual.DrawMode = DrawModeEnum.OwnerDraw
    End Sub

#Region "override manual"
    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectSimpiPortfolioNormal
        form.lblCode = lblPortfolioCodeManual
        form.lblName = lblPortfolioNameManual
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCodeManual.Text = ""
        lblPortfolioNameManual.Text = ""
        objPortfolio.Clear()
        clearSecurities()
        clearManual()
    End Sub

    Private Sub clearSecurities()
        lblSecuritiesCode.Text = ""
        lblSecuritiesName.Text = ""
        lblMaturity.Text = ""
        lblType.Text = ""
        txtQty.Text = ""
        txtPrice.Text = ""
        txtCost.Text = ""
        txtAccruedCoupon.Text = ""
        lblMarketValue.Text = ""
        lblTotalValue.Text = ""
        lblTTM.Text = ""
        lblYTM.Text = ""
        lblYieldEffective.Text = ""
        lblModifiedDuration.Text = ""
    End Sub

    Private Sub clearManual()
        initManual()
        txtSummaryQty.Text = ""
        txtSummaryCost.Text = ""
        txtSummaryValue.Text = ""
        txtSummaryAccrued.Text = ""
        txtSummaryTotal.Text = ""
    End Sub

    Private Sub initManual()
        With fgManual
            .Rows.Count = 1
            .Cols.Count = 13
            .ExtendLastCol = False
            fgManual(0, 0) = "No"
            fgManual(0, 1) = "ID"
            fgManual(0, 2) = "Code"
            fgManual(0, 3) = "Name"
            fgManual(0, 4) = "Type"
            fgManual(0, 5) = "Qty"
            fgManual(0, 6) = "Price"
            fgManual(0, 7) = "Cost"
            fgManual(0, 8) = "Value"
            fgManual(0, 9) = "Accrued"
            fgManual(0, 10) = "Total"
            fgManual(0, 11) = "TypeID"
            fgManual(0, 12) = "CompanyID"
            .AllowResizing = AllowResizingEnum.Columns
            .SelectionMode = SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub lblPortfolioNameManual_TextChanged(sender As Object, e As EventArgs) Handles lblPortfolioNameManual.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCodeManual.Text.Trim <> "" Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblPortfolioCodeManual.Text)
            If objPortfolio.ErrID = 0 Then
                objMTM.Clear()
                objMTM.LoadEnd(objPortfolio)
                dtAs.Value = objMTM.GetNextDate
                GetInstrumentCcy(objPortfolio.GetPortfolioCcy.GetCountryID)
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DataSecurities()
    End Sub

    Private Sub DataSecurities()
        If objPortfolio.GetPortfolioID > 0 Then
            objPosition.Clear()
            dtPosition = objPosition.Search(objPortfolio, dtAs.Value)
            clearSecurities()
            clearManual()
            no = 0
            DisplaySecurities()
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        DisplaySecurities()
    End Sub

    Private Function _no() As Integer
        no += 1
        Return no
    End Function

    Private Sub DisplaySecurities()
        initManual()
        If dtPosition IsNot Nothing AndAlso dtPosition.Rows.Count > 0 Then
            If cmbType.SelectedIndex = -1 Or cmbType.Text.Trim.ToUpper = "ALL" Then
                _displayall()
            Else
                _displaytype()
            End If
        End If
    End Sub

    Private Sub _displayall()
        Dim query = From p In dtPosition.AsEnumerable
                    Join i In dtInstrumentCcy.AsEnumerable
                           On p.Field(Of Long)("SecuritiesID") Equals i.Field(Of Long)("SecuritiesID")
                    Join t In dtParameterInstrumentType.AsEnumerable
                           On t.Field(Of Integer)("TypeID") Equals i.Field(Of Integer)("TypeID")
                    Select _no(), ID = p.Field(Of Long)("SecuritiesID"),
                                   Code = i.Field(Of String)("SecuritiesCode"),
                                   Name = i.Field(Of String)("SecuritiesNameFull"),
                                   Type = t.Field(Of String)("TypeCode"),
                                   TypeID = i.Field(Of Integer)("TypeID"),
                                   CompanyID = i.Field(Of Integer)("CompanyID"),
                                   Qty = p.Field(Of Decimal)("Qty"),
                                   Price = p.Field(Of Decimal)("MarketPrice"),
                                   Cost = p.Field(Of Decimal)("CostPrice"),
                                   Value = p.Field(Of Decimal)("MarketValue"),
                                   Accrued = p.Field(Of Decimal)("AccruedInterest"),
                                   Total = p.Field(Of Decimal)("TotalValue")
        txtSummaryQty.Text = (From q In query Select q.Qty).Sum.ToString("n2")
        txtSummaryCost.Text = (From q In query Select q.Qty * q.Cost).Sum.ToString("n2")
        txtSummaryValue.Text = (From q In query Select q.Value).Sum.ToString("n2")
        txtSummaryAccrued.Text = (From q In query Select q.Accrued).Sum.ToString("n2")
        txtSummaryTotal.Text = (From q In query Select q.Total).Sum.ToString("n2")

        For Each item In query
            fgManual.Rows.Add()
            fgManual(fgManual.Rows.Count - 1, 0) = item._no
            fgManual(fgManual.Rows.Count - 1, 1) = item.ID
            fgManual(fgManual.Rows.Count - 1, 2) = item.Code
            fgManual(fgManual.Rows.Count - 1, 3) = item.Name
            fgManual(fgManual.Rows.Count - 1, 4) = item.Type
            fgManual(fgManual.Rows.Count - 1, 5) = item.Qty.ToString("n2")
            If IsFI(item.TypeID) Then
                fgManual(fgManual.Rows.Count - 1, 6) = (item.Price * 100).ToString("n4")
                fgManual(fgManual.Rows.Count - 1, 7) = (item.Cost * 100).ToString("n4")
            Else
                fgManual(fgManual.Rows.Count - 1, 6) = item.Price.ToString("n4")
                fgManual(fgManual.Rows.Count - 1, 7) = item.Cost.ToString("n4")
            End If
            fgManual(fgManual.Rows.Count - 1, 8) = item.Value.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 9) = item.Accrued.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 10) = item.Total.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 11) = item.TypeID
            fgManual(fgManual.Rows.Count - 1, 12) = item.CompanyID
        Next
        fgManual.AutoSizeCols()
        fgManual.Cols(11).Width = 0
        fgManual.Cols(12).Width = 0
    End Sub

    Private Sub _displaytype()
        Dim query = From p In dtPosition.AsEnumerable
                    Join i In dtInstrumentCcy.AsEnumerable
                           On p.Field(Of Long)("SecuritiesID") Equals i.Field(Of Long)("SecuritiesID")
                    Join t In dtParameterInstrumentType.AsEnumerable
                           On t.Field(Of Integer)("TypeID") Equals i.Field(Of Integer)("TypeID")
                    Where t.Field(Of Integer)("TypeID") = cmbType.SelectedValue
                    Select _no(), ID = p.Field(Of Long)("SecuritiesID"),
                                   Code = i.Field(Of String)("SecuritiesCode"),
                                   Name = i.Field(Of String)("SecuritiesNameFull"),
                                   Type = t.Field(Of String)("TypeCode"),
                                   TypeID = i.Field(Of Integer)("TypeID"),
                                   CompanyID = i.Field(Of Integer)("CompanyID"),
                                   Qty = p.Field(Of Decimal)("Qty"),
                                   Price = p.Field(Of Decimal)("MarketPrice"),
                                   Cost = p.Field(Of Decimal)("CostPrice"),
                                   Value = p.Field(Of Decimal)("MarketValue"),
                                   Accrued = p.Field(Of Decimal)("AccruedInterest"),
                                   Total = p.Field(Of Decimal)("TotalValue")
        txtSummaryQty.Text = (From q In query Select q.Qty).Sum.ToString("n2")
        txtSummaryCost.Text = (From q In query Select q.Qty * q.Cost).Sum.ToString("n2")
        txtSummaryValue.Text = (From q In query Select q.Value).Sum.ToString("n2")
        txtSummaryAccrued.Text = (From q In query Select q.Accrued).Sum.ToString("n2")
        txtSummaryTotal.Text = (From q In query Select q.Total).Sum.ToString("n2")

        For Each item In query
            fgManual.Rows.Add()
            fgManual(fgManual.Rows.Count - 1, 0) = item._no
            fgManual(fgManual.Rows.Count - 1, 1) = item.ID
            fgManual(fgManual.Rows.Count - 1, 2) = item.Code
            fgManual(fgManual.Rows.Count - 1, 3) = item.Name
            fgManual(fgManual.Rows.Count - 1, 4) = item.Type
            fgManual(fgManual.Rows.Count - 1, 5) = item.Qty.ToString("n2")
            If IsFI(item.TypeID) Then
                fgManual(fgManual.Rows.Count - 1, 6) = (item.Price * 100).ToString("n4")
                fgManual(fgManual.Rows.Count - 1, 7) = (item.Cost * 100).ToString("n4")
            Else
                fgManual(fgManual.Rows.Count - 1, 6) = item.Price.ToString("n4")
                fgManual(fgManual.Rows.Count - 1, 7) = item.Cost.ToString("n4")
            End If
            fgManual(fgManual.Rows.Count - 1, 8) = item.Value.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 9) = item.Accrued.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 10) = item.Total.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 11) = item.TypeID
            fgManual(fgManual.Rows.Count - 1, 12) = item.CompanyID
        Next
        fgManual.AutoSizeCols()
        fgManual.Cols(11).Width = 0
        fgManual.Cols(12).Width = 0

    End Sub

    Private Sub fgManual_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgManual.OwnerDrawCell
        Dim s As CellStyle = fgManual.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgManual.Rows(e.Row).Style = fgManual.Styles("RowStyle")
    End Sub

    Private Sub fgManual_DoubleClick(sender As Object, e As EventArgs) Handles fgManual.DoubleClick
        With fgManual
            If .Rows.Count > 1 AndAlso .Row > 0 Then
                lblSecuritiesCode.Text = fgManual(.Row, 2)
                lblTypeID.Text = fgManual(.Row, 11)
                lblCompanyID.Text = fgManual(.Row, 12)
                lblSecuritiesName.Text = fgManual(.Row, 3)
                If Not IsEQ(fgManual(.Row, 11)) Then txtPrice.Text = fgManual(.Row, 6)
                txtQty.Text = fgManual(.Row, 5)
                txtCost.Text = fgManual(.Row, 7)
                txtAccruedCoupon.Text = fgManual(.Row, 9)
            End If
        End With
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        _marketvalue()
        _accrued()
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        _marketvalue()
        _ytm()
        _yieldeffective()
        _mduration()
    End Sub

    Private Sub txtAccruedCoupon_TextChanged(sender As Object, e As EventArgs) Handles txtAccruedCoupon.TextChanged
        _totalvalue()
    End Sub

    Private Sub _accrued()
        Double.TryParse(txtQty.Text, qty)
        If objSecurities.IsFI Then
            txtAccruedCoupon.Text = objBond.Coupon_Acrrued(qty, dtAs.Value).ToString("n2")
        Else
            txtAccruedCoupon.Text = ""
        End If
    End Sub

    Private Sub _marketvalue()
        Double.TryParse(txtQty.Text, qty)
        Double.TryParse(txtPrice.Text, price)
        If objSecurities.IsFI Then
            lblMarketValue.Text = (qty * price / 100).ToString("n2")
        Else
            lblMarketValue.Text = (qty * price).ToString("n2")
        End If
        _totalvalue()
    End Sub

    Private Sub _totalvalue()
        Double.TryParse(lblMarketValue.Text, qty)
        Double.TryParse(txtAccruedCoupon.Text, price)
        lblTotalValue.Text = (qty + price).ToString("n2")
    End Sub

    Private Sub _ttm()
        If objSecurities.IsFI Then
            lblMaturity.Text = objBond.GetDateMaturity.ToString("dd-MMM-yyyy")
            lblTTM.Text = (CalculateDays(dtAs.Value, objBond.GetDateMaturity, "A") / BaseDays("A", dtAs.Value)).ToString("n5")
        Else
            lblTTM.Text = ""
        End If
    End Sub

    Private Sub _ytm()
        Double.TryParse(txtPrice.Text, price)
        If objSecurities.IsFI Then
            lblYTM.Text = (objBond.Yield_YTM(price / 100, dtAs.Value) * 100).ToString("n5")
        Else
            lblYTM.Text = ""
        End If
    End Sub

    Private Sub _yieldeffective()
        Double.TryParse(txtPrice.Text, price)
        If objSecurities.IsFI Then
            lblYieldEffective.Text = (objBond.Yield_Current(price / 100) * 100).ToString("n5")
        Else
            lblYieldEffective.Text = ""
        End If
    End Sub

    Private Sub _mduration()
        Double.TryParse(txtPrice.Text, price)
        If objSecurities.IsFI Then
            lblModifiedDuration.Text = objBond.Duration_Modified(price / 100, dtAs.Value).ToString("n5")
        Else
            lblModifiedDuration.Text = ""
        End If
    End Sub

    Private Sub btnSearchSecurities_Click(sender As Object, e As EventArgs) Handles btnSearchSecurities.Click
        SecuritiesSearch()
    End Sub

    Private Sub SecuritiesSearch()
        Dim form As New FormSelectSecurities
        form.lblCode = lblSecuritiesCode
        form.lblName = lblSecuritiesName
        form.lblType = lblType
        form.lblTypeID = lblTypeID
        form.lblCompany = lblCompany
        form.lblCompanyID = lblCompanyID
        form.Show()
        form.MdiParent = MDISO
        lblSecuritiesCode.Text = ""
        lblSecuritiesName.Text = ""
        lblType.Text = ""
        lblTypeID.Text = ""
        lblCompany.Text = ""
        lblCompanyID.Text = ""
        objSecurities.Clear()
        objBond.Clear()
        clearSecurities()
    End Sub

    Private Sub lblSecuritiesName_TextChanged(sender As Object, e As EventArgs) Handles lblSecuritiesName.TextChanged
        Securitiesload()
    End Sub

    Private Sub Securitiesload()
        If lblSecuritiesName.Text.Trim <> "" Then
            objSecurities.Clear()
            objSecurities.Load3(lblCompanyID.Text, lblTypeID.Text, lblSecuritiesCode.Text)
            If objSecurities.ErrID = 0 Then
                If objSecurities.IsFI Then
                    txtAccruedCoupon.ReadOnly = False
                    objBond.Clear()
                    objBond.Load2(lblCompanyID.Text, lblSecuritiesCode.Text)
                    If objBond.ErrID = 0 Then _ttm() Else ExceptionMessage.Show(objBond.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf objSecurities.IsEQ Then
                    txtAccruedCoupon.ReadOnly = True
                    objPrice.Clear()
                    objPrice.LoadLast(1, objSecurities.GetSecuritiesID, dtAs.Value)
                    txtPrice.Text = objPrice.GetMarketPrice().ToString("n4")
                Else
                    txtAccruedCoupon.ReadOnly = True
                End If
            Else
                ExceptionMessage.Show(objSecurities.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If objPortfolio.GetPortfolioID > 0 And objSecurities.GetSecuritiesID > 0 Then
            If Not IsNumeric(txtQty.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            If Not IsNumeric(txtPrice.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Not IsNumeric(txtCost.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If txtAccruedCoupon.Text.Trim = "" Then
                txtAccruedCoupon.Text = "0"
            ElseIf Not IsNumeric(txtAccruedCoupon.Text) Then
                ExceptionMessage.Show(objError.Message(81) & " securities coupon accrued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            objOverride.Clear()
            If objSecurities.IsFI Then
                objOverride.override(objPortfolio, objSecurities, dtAs.Value, CDbl(txtQty.Text), CDbl(txtPrice.Text),
                                     CDbl(txtCost.Text), CDbl(txtAccruedCoupon.Text), CDbl(lblYTM.Text),
                                     CDbl(lblYieldEffective.Text), CDbl(lblModifiedDuration.Text), 0, CInt(lblTTM.Text))
            Else
                objOverride.override(objPortfolio, objSecurities, dtAs.Value, CDbl(txtQty.Text), CDbl(txtPrice.Text),
                                     CDbl(txtCost.Text), 0, 0, 0, 0, 0, 0)
            End If
            If objOverride.ErrID = 0 Then
                DataSecurities()
            Else
                ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        DataRemove()
    End Sub

    Private Sub DataRemove()
        If objPortfolio.GetPortfolioID > 0 And objSecurities.GetSecuritiesID > 0 Then
            objOverride.Clear()
            objOverride.override_remove(objPortfolio, objSecurities, dtAs.Value)
            If objOverride.ErrID = 0 Then DataSecurities() Else ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "override scb"

#End Region

#Region "override x.d.1"

#End Region

End Class