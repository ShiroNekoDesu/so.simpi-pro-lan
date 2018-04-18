Imports C1.Win.C1TrueDBGrid
Imports simpi.CoreData
Imports simpi.CoreClosing
Imports simpi.MasterPortfolio
Imports simpi.GlobalException
Imports simpi.GlobalDate.GlobalDate

Public Class FormEODClosingProfile
    Public CallerForm As FormEODClosing
    Public objNAV As PortfolioNAV
    Public objPortfolio As MasterPortfolio
    Dim objEOD As New ProcessEOD
    Dim objChargesPayable As New TransactionPayableCharges
    Dim objOthersPayable As New TransactionPayableOthers
    Dim objChargesExpense As New TransactionExpenseCharges
    Dim objOthersExpense As New TransactionExpenseOthers
    Dim ytdDate As Date

    Dim objPayable As New PositionPayableCharges
    Dim objExpense As New PositionExpenseCharges

    Public Sub FormLoad()
        If objNAV.ErrID = 0 Then
            lblPortfolioCode.Text = objPortfolio.GetPortfolioCode
            lblPortfolioName.Text = objPortfolio.GetPortfolioNameFull
            lblSimpiName.Text = objPortfolio.GetMasterSimpi.GetSimpiName
            lblPortfolioCcy.Text = objPortfolio.GetPortfolioCcy.GetCcy
            lblInception.Text = objPortfolio.GetInceptionDate.ToString("dd-MMMM-yyyy")
            lblValuation.Text = objNAV.GetPositionDate.ToString("dd-MMMM-yyyy")
            lblNAV.Text = objNAV.GetNAV.ToString("n0")
            lblNAVPerUnit.Text = objNAV.GetNAVPerUnit.ToString("n5")
            lblUnit.Text = objNAV.GetTotalUnit.ToString("n0")
            ytdDate = DateBOY(objNAV.GetPositionDate)

            DBGSecurities.FetchRowStyles = True
            DBGBankAccount.FetchRowStyles = True
            DBGBankDeposit.FetchRowStyles = True
            DBGChargesAccrual.FetchRowStyles = True
            DBGChargesTransaction.FetchRowStyles = True
            DBGExpenseYTD.FetchRowStyles = True

            objEOD.UserAccess = objAccess
            objChargesPayable.UserAccess = objAccess
            objOthersPayable.UserAccess = objAccess
            objChargesExpense.UserAccess = objAccess
            objOthersExpense.UserAccess = objAccess
            objPayable.UserAccess = objAccess
            objExpense.UserAccess = objAccess

            GetParameterCountry("")
            GetParameterInstrumentType("")
            GetParameterCharges("")

            NAVLoad()
            LastLoad()
            MTMLoad()
            SecuritiesLoad()
            CashLoad()
            DepositLoad()
            ChargesLoad()
        Else
            Close()
        End If
    End Sub

    Private Sub NAVLoad()
        lblEQ.Text = objNAV.GetAssetEQValue.ToString("n0")
        lblEQNAV.Text = objNAV.GetPercentageEQValueNAV.ToString("p2")
        lblEQAsset.Text = objNAV.GetPercentageEQValueAsset.ToString("p2")
        lblFI.Text = (objNAV.GetAssetFIValue + objNAV.GetAssetFIAccrued).ToString("n0")
        lblFINAV.Text = (objNAV.GetPercentageFIValueNAV + objNAV.GetPercentageFIAccruedNAV).ToString("p2")
        lblFIAsset.Text = (objNAV.GetPercentageFIValueAsset + objNAV.GetPercentageFIAccruedAsset).ToString("p2")
        lblFund.Text = objNAV.GetAssetFundValue.ToString("n0")
        lblFundNAV.Text = objNAV.GetPercentageFundValueNAV.ToString("p2")
        lblFundAsset.Text = objNAV.GetPercentageFundValueAsset.ToString("p2")
        lblCash.Text = (objNAV.GetAssetCAValue + objNAV.GetAssetCAAccrued).ToString("n0")
        lblCashNAV.Text = (objNAV.GetPercentageCAValueNAV + objNAV.GetPercentageCAAccruedNAV).ToString("p2")
        lblCashAsset.Text = (objNAV.GetPercentageCAValueAsset + objNAV.GetPercentageCAAccruedAsset).ToString("p2")
        lblTD.Text = (objNAV.GetAssetTDValue + objNAV.GetAssetTDAccrued).ToString("n0")
        lblTDNAV.Text = (objNAV.GetPercentageTDValueNAV + objNAV.GetPercentageTDAccruedNAV).ToString("p2")
        lblTDAsset.Text = (objNAV.GetPercentageTDValueAsset + objNAV.GetPercentageTDAccruedAsset).ToString("p2")

        lblOthers.Text = (objNAV.GetAsset - objNAV.GetAssetEQValue - objNAV.GetAssetFIValue - objNAV.GetAssetFIAccrued -
                          objNAV.GetAssetFundValue - objNAV.GetAssetCAValue - objNAV.GetAssetCAAccrued -
                          objNAV.GetAssetTDValue - objNAV.GetAssetTDAccrued).ToString("n0")
        lblOthersNAV.Text = SetPercentage(CDbl(lblOthers.Text), objNAV.GetNAV)
        lblOthersAsset.Text = SetPercentage(CDbl(lblOthers.Text), objNAV.GetAsset)

        lblAsset.Text = objNAV.GetAsset.ToString("n0")
        lblAssetNAV.Text = objNAV.GetPercentageAssetNAV.ToString("p2")
        lblTradingSettlement.Text = (objNAV.GetAssetReceivableTrading - objNAV.GetPayableTrading).ToString("n0")
        lblTradingSettlementNAV.Text = (objNAV.GetPercentageReceivableTradingNAV - objNAV.GetPercentagePayableTradingNAV).ToString("p2")
        lblPayableCharges.Text = objNAV.GetPayableCharges.ToString("n0")
        lblPayableChargesNAV.Text = objNAV.GetPercentagePayableChargesNAV.ToString("p2")
        lblPayableOthers.Text = objNAV.GetPayableOthers.ToString("n0")
        lblPayableOthersNAV.Text = objNAV.GetPercentagePayableOthersNAV.ToString("p2")

        lblSubscription.Text = objNAV.GetCapitalSubscriptionValue.ToString("n0")
        lblSubscriptionNAV.Text = objNAV.GetPercentageSubscriptionValueNAV.ToString("p2")
        lblRedemption.Text = objNAV.GetCapitalRedemptionValue.ToString("n0")
        lblRedemptionNAV.Text = objNAV.GetPercentageRedemptionValueNAV.ToString("p2")
        lblDividend.Text = objNAV.GetCapitalDividendValue.ToString("n0")
        lblDividendNAV.Text = objNAV.GetPercentageDividendValueNAV.ToString("p2")
        lblDailyPL.Text = objNAV.GetDailyPL.ToString("n0")

    End Sub

    Private Function SetPercentage(ByVal u As Double, ByVal b As Double) As String
        Dim s As String = 0.ToString("p2")
        If b <> 0 Then
            s = (u / b).ToString("p2")
        End If
        Return s
    End Function

    Private Sub LastLoad()
        Dim objLast As New PortfolioNAV
        objLast.UserAccess = objAccess
        objLast.LoadBefore(objPortfolio, objNAV.GetPositionDate)
        If objLast.ErrID = 0 Then
            lblValuationLast.Text = objLast.GetPositionDate.ToString("dd-MMMM-yyyy")
            lblNAVLast.Text = objLast.GetNAV.ToString("n0")
            lblNAVPerUnitLast.Text = objLast.GetNAVPerUnit.ToString("n5")
            lblUnitLast.Text = objLast.GetTotalUnit.ToString("n0")

            lblEQLast.Text = objLast.GetAssetEQValue.ToString("n0")
            lblEQLastNAV.Text = objLast.GetPercentageEQValueNAV.ToString("p2")
            lblEQLastAsset.Text = objLast.GetPercentageEQValueAsset.ToString("p2")
            lblFILast.Text = (objLast.GetAssetFIValue + objLast.GetAssetFIAccrued).ToString("n0")
            lblFILastNAV.Text = (objLast.GetPercentageFIValueNAV + objLast.GetPercentageFIAccruedNAV).ToString("p2")
            lblFILastAsset.Text = (objLast.GetPercentageFIValueAsset + objLast.GetPercentageFIAccruedAsset).ToString("p2")
            lblFundLast.Text = objLast.GetAssetFundValue.ToString("n0")
            lblFundLastNAV.Text = objLast.GetPercentageFundValueNAV.ToString("p2")
            lblFundLastAsset.Text = objLast.GetPercentageFundValueAsset.ToString("p2")
            lblCashLast.Text = (objLast.GetAssetCAValue + objLast.GetAssetCAAccrued).ToString("n0")
            lblCashLastNAV.Text = (objLast.GetPercentageCAValueNAV + objLast.GetPercentageCAAccruedNAV).ToString("p2")
            lblCashLastAsset.Text = (objLast.GetPercentageCAValueAsset + objLast.GetPercentageCAAccruedAsset).ToString("p2")
            lblTDLast.Text = (objLast.GetAssetTDValue + objLast.GetAssetTDAccrued).ToString("n0")
            lblTDLastNAV.Text = (objLast.GetPercentageTDValueNAV + objLast.GetPercentageTDAccruedNAV).ToString("p2")
            lblTDLastAsset.Text = (objLast.GetPercentageTDValueAsset + objLast.GetPercentageTDAccruedAsset).ToString("p2")

            lblOthersLast.Text = (objLast.GetAsset - objLast.GetAssetEQValue - objLast.GetAssetFIValue - objLast.GetAssetFIAccrued -
                              objLast.GetAssetFundValue - objLast.GetAssetCAValue - objLast.GetAssetCAAccrued -
                              objLast.GetAssetTDValue - objLast.GetAssetTDAccrued).ToString("n0")
            lblOthersLastNAV.Text = SetPercentage(CDbl(lblOthersLast.Text), objLast.GetNAV)
            lblOthersLastAsset.Text = SetPercentage(CDbl(lblOthersLast.Text), objLast.GetAsset)

            lblAssetLast.Text = objLast.GetAsset.ToString("n0")
            lblAssetLastNAV.Text = objLast.GetPercentageAssetNAV.ToString("p2")
            lblTradingSettlementLast.Text = (objLast.GetAssetReceivableTrading - objLast.GetPayableTrading).ToString("n0")
            lblTradingSettlementLastNAV.Text = (objLast.GetPercentageReceivableTradingNAV - objLast.GetPercentagePayableTradingNAV).ToString("p2")
            lblPayableChargesLast.Text = objLast.GetPayableCharges.ToString("n0")
            lblPayableChargesLastNAV.Text = objLast.GetPercentagePayableChargesNAV.ToString("p2")
            lblPayableOthersLast.Text = objLast.GetPayableOthers.ToString("n0")
            lblPayableOthersLastNAV.Text = objLast.GetPercentagePayableOthersNAV.ToString("p2")

            lblNAVDiff.Text = (objNAV.GetNAV - objLast.GetNAV).ToString("n0")
            lblNAVDiffPercent.Text = SetPercentage(CDbl(lblNAVDiff.Text), objLast.GetNAV)

            lblNAVPerUnitDiff.Text = (objNAV.GetNAVPerUnit - objLast.GetNAVPerUnit).ToString("n5")
            lblNAVPerUnitDiffPercent.Text = SetPercentage(CDbl(lblNAVPerUnitDiff.Text), objLast.GetNAVPerUnit)

            lblUnitDiff.Text = (objNAV.GetTotalUnit - objLast.GetTotalUnit).ToString("n0")
            lblUnitDiffPercent.Text = SetPercentage(CDbl(lblUnitDiff.Text), objLast.GetTotalUnit)

            lblDailyPLNAV.Text = SetPercentage(CDbl(lblDailyPL.Text), objLast.GetNAV)
            lblDailyPLAsset.Text = SetPercentage(CDbl(lblDailyPL.Text), objLast.GetAsset)

        Else
            lblValuationLast.Text = ""
            lblNAVLast.Text = 0.ToString("n0")
            lblNAVPerUnitLast.Text = 0.ToString("n5")
            lblUnitLast.Text = 0.ToString("n0")

            lblEQLast.Text = 0.ToString("n0")
            lblEQLastNAV.Text = 0.ToString("p2")
            lblEQLastAsset.Text = 0.ToString("p2")
            lblFILast.Text = 0.ToString("n0")
            lblFILastNAV.Text = 0.ToString("p2")
            lblFILastAsset.Text = 0.ToString("p2")
            lblFundLast.Text = 0.ToString("n0")
            lblFundLastNAV.Text = 0.ToString("p2")
            lblFundLastAsset.Text = 0.ToString("p2")
            lblCashLast.Text = 0.ToString("n0")
            lblCashLastNAV.Text = 0.ToString("p2")
            lblCashLastAsset.Text = 0.ToString("p2")
            lblTDLast.Text = 0.ToString("n0")
            lblTDLastNAV.Text = 0.ToString("p2")
            lblTDLastAsset.Text = 0.ToString("p2")

            lblOthersLast.Text = 0.ToString("n0")
            lblOthersLastNAV.Text = 0.ToString("p2")
            lblOthersLastAsset.Text = 0.ToString("p2")

            lblAssetLast.Text = 0.ToString("n0")
            lblAssetLastNAV.Text = 0.ToString("p2")
            lblTradingSettlementLast.Text = 0.ToString("n0")
            lblTradingSettlementLastNAV.Text = 0.ToString("p2")
            lblPayableChargesLast.Text = 0.ToString("n0")
            lblPayableChargesLastNAV.Text = 0.ToString("p2")
            lblPayableOthersLast.Text = 0.ToString("n0")
            lblPayableOthersLastNAV.Text = 0.ToString("p2")

            lblNAVDiff.Text = ""
            lblNAVDiffPercent.Text = ""

            lblNAVPerUnitDiff.Text = ""
            lblNAVPerUnitDiffPercent.Text = ""

            lblUnitDiff.Text = ""
            lblUnitDiffPercent.Text = ""

            lblDailyPLNAV.Text = ""
            lblDailyPLAsset.Text = ""

        End If
    End Sub

    Private Sub MTMLoad()
        Dim objMTM As New PortfolioMTM
        objMTM.UserAccess = objAccess
        objMTM.LoadAt(objPortfolio, objNAV.GetPositionDate)
        If objMTM.ErrID = 0 Then
            dtNext.Value = objMTM.GetNextDate
            dtNext.Enabled = False
            btnGenerate.Enabled = False
            btnReverse.Enabled = True
        Else
            dtNext.Value = objNAV.GetPositionDate.AddDays(1)
            dtNext.Enabled = True
            btnGenerate.Enabled = True
            btnReverse.Enabled = False
        End If
    End Sub

    Private Function SetPrice(ByVal TypeID As Integer, ByVal price As Double) As String
        Dim s As String = ""
        If TypeID = 1 Then
            s = price.ToString("p2")
        Else
            s = price.ToString("n0")
        End If
        Return s
    End Function

    Private Sub SecuritiesLoad()
        Dim dtSecurities As New DataTable
        Dim objSecurities As New PositionSecurities
        objSecurities.UserAccess = objAccess
        dtSecurities = objSecurities.Search(objPortfolio, objNAV.GetPositionDate, "", 0, 0, 0, 0, "")
        If objSecurities.ErrID = 0 Then
            Dim query = From s In dtSecurities.AsEnumerable
                        Join c In dtCountry.AsEnumerable
                            On s.Field(Of Integer)("SecuritiesCcyID") Equals c.Field(Of Integer)("CountryID")
                        Join t In dtInstrumentType.AsEnumerable
                            On s.Field(Of Integer)("SecuritiesTypeID") Equals t.Field(Of Integer)("TypeID")
                        Select
                                 ID = s.Field(Of Long)("SecuritiesID"),
                                 Code = s.Field(Of String)("SecuritiesCode"),
                                 Name = s.Field(Of String)("SecuritiesNameShort"),
                                 TypeCode = t.Field(Of String)("TypeCode"),
                                 Ccy = c.Field(Of String)("Ccy"),
                                 Qty = s.Field(Of Decimal)("Qty"),
                                 Price = SetPrice(t.Field(Of Integer)("TypeID"), s.Field(Of Decimal)("MarketPrice")),
                                 Accrued = s.Field(Of Decimal)("AccruedInterest"),
                                 Total = s.Field(Of Decimal)("TotalValue"),
                                 NAV = SetPercentage(s.Field(Of Decimal)("TotalValue"), objNAV.GetNAV),
                                 Asset = SetPercentage(s.Field(Of Decimal)("TotalValue"), objNAV.GetAsset)
            With DBGSecurities
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Qty").NumberFormat = "n0"
                .Columns("Accrued").NumberFormat = "n0"
                .Columns("Total").NumberFormat = "n0"

                .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                '.Splits(0).DisplayColumns("isPrivate").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Qty").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Accrued").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Total").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("NAV").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Asset").Style.HorizontalAlignment = AlignHorzEnum.Far

                .Columns("TypeCode").Caption = "Type"
                '.Columns("isPrivate").Caption = "Pvt"

                For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                    column.AutoSize()
                    .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                Next

            End With
        Else
            DBGSecurities.Columns.Clear()
        End If
    End Sub

    Private Sub DBGSecurities_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGSecurities.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGSecurities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSecurities.Click
        With DBGSecurities
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub CashLoad()
        Dim dtCash As New DataTable
        Dim objCash As New PositionBankAccount
        objCash.UserAccess = objAccess
        dtCash = objCash.Search(objPortfolio, objNAV.GetPositionDate, 0, 0)
        If objCash.ErrID = 0 Then
            Dim query = From s In dtCash.AsEnumerable Join c In dtCountry.AsEnumerable
                            On s.Field(Of Integer)("AccountCcyID") Equals c.Field(Of Integer)("CountryID")
                        Select
                                 ID = s.Field(Of Long)("AccountID"),
                                 Bank = s.Field(Of String)("CompanyName"),
                                 AccountNo = s.Field(Of String)("AccountNo"),
                                 Ccy = c.Field(Of String)("Ccy"),
                                 Balance = s.Field(Of Decimal)("AccountBalance"),
                                 Interest = s.Field(Of Decimal)("AccountInterest"),
                                 NAV = SetPercentage(s.Field(Of Decimal)("AccountBalance") + s.Field(Of Decimal)("AccountInterest"), objNAV.GetNAV),
                                 Asset = SetPercentage(s.Field(Of Decimal)("AccountBalance") + s.Field(Of Decimal)("AccountInterest"), objNAV.GetAsset)
            With DBGBankAccount
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Balance").NumberFormat = "n0"
                .Columns("Interest").NumberFormat = "n0"

                .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Balance").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Interest").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("NAV").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Asset").Style.HorizontalAlignment = AlignHorzEnum.Far

                For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                    column.AutoSize()
                    .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                Next

            End With
        Else
            DBGBankAccount.Columns.Clear()
        End If
    End Sub

    Private Sub DBGBankAccount_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBankAccount.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGBankAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBankAccount.Click
        With DBGBankAccount
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DepositLoad()
        Dim dtTD As New DataTable
        Dim objTD As New PositionBankDeposit
        objTD.UserAccess = objAccess
        dtTD = objTD.Search(objPortfolio, objNAV.GetPositionDate, 0, 0)
        If objTD.ErrID = 0 Then
            Dim query = From s In dtTD.AsEnumerable Join c In dtCountry.AsEnumerable
                            On s.Field(Of Integer)("TDCcyID") Equals c.Field(Of Integer)("CountryID")
                        Select
                                 ID = s.Field(Of Long)("TDID"),
                                 Bank = s.Field(Of String)("CompanyName"),
                                 Ccy = c.Field(Of String)("Ccy"),
                                 Nominal = s.Field(Of Decimal)("TDQty"),
                                 Term = s.Field(Of String)("TDTermCode"),
                                 DateStart = s.Field(Of Date)("DateStart"),
                                 Rate = s.Field(Of Decimal)("InterestRate"),
                                 NAV = SetPercentage(s.Field(Of Decimal)("TDQty") + s.Field(Of Decimal)("TDInterest"), objNAV.GetNAV),
                                 Asset = SetPercentage(s.Field(Of Decimal)("TDQty") + s.Field(Of Decimal)("TDInterest"), objNAV.GetAsset)
            With DBGBankDeposit
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Nominal").NumberFormat = "n0"
                .Columns("Rate").NumberFormat = "p2"
                .Columns("DateStart").NumberFormat = "dd-MMM-yy"

                .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Term").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("DateStart").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Nominal").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Rate").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("NAV").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Asset").Style.HorizontalAlignment = AlignHorzEnum.Far

                For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                    column.AutoSize()
                    .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                Next

            End With
        Else
            DBGBankDeposit.Columns.Clear()
        End If
    End Sub

    Private Sub DBGBankDeposit_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGBankDeposit.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGBankDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGBankDeposit.Click
        With DBGBankDeposit
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub ChargesLoad()
        Dim dtAccrual As New DataTable
        Dim dtExpense As New DataTable
        Dim balance As Double

        DBGChargesAccrual.Columns.Clear()
        dtAccrual.Columns.AddRange(New DataColumn() {New DataColumn("ID", GetType(Integer)),
                   New DataColumn("Charges", GetType(String)), New DataColumn("Balance", GetType(Decimal))})
        DBGExpenseYTD.Columns.Clear()
        dtExpense.Columns.AddRange(New DataColumn() {New DataColumn("ID", GetType(Integer)),
                   New DataColumn("Charges", GetType(String)), New DataColumn("Balance", GetType(Decimal))})
        For Each fee In dtCharges.AsEnumerable
            objPayable.Clear()
            balance = objPayable.GetPayableBalance(objPortfolio, fee.Field(Of Integer)("FeeID"), objNAV.GetPositionDate)
            dtAccrual.Rows.Add(fee.Field(Of Integer)("FeeID"), fee.Field(Of String)("FeeCode"), balance)

            objExpense.Clear()
            balance = objExpense.GetDailyExpense(objPortfolio, fee.Field(Of Integer)("FeeID"), ytdDate, objNAV.GetPositionDate)
            dtExpense.Rows.Add(fee.Field(Of Integer)("FeeID"), fee.Field(Of String)("FeeCode"), balance)
        Next
        balance = objNAV.GetPayableOthers
        dtAccrual.Rows.Add(0, "Others", balance)
        balance = objNAV.GetTotalExpenseOthers(objPortfolio, ytdDate, objNAV.GetPositionDate)
        dtExpense.Rows.Add(0, "Others", balance)

        With DBGChargesAccrual
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = dtAccrual

            .Columns("Balance").NumberFormat = "n0"

            .Splits(0).DisplayColumns("Balance").Style.HorizontalAlignment = AlignHorzEnum.Far

            For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                column.AutoSize()
                .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            Next

        End With

        With DBGExpenseYTD
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = dtExpense

            .Columns("Balance").NumberFormat = "n0"

            .Splits(0).DisplayColumns("Balance").Style.HorizontalAlignment = AlignHorzEnum.Far

            For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                column.AutoSize()
                .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            Next

        End With

    End Sub

    Private Sub DBGChargesAccrual_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGChargesAccrual.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGExpenseYTD_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGExpenseYTD.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGChargesTransaction_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGChargesTransaction.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGChargesAccrual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGChargesAccrual.Click
        With DBGChargesAccrual
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                DBGExpenseYTD.MarqueeStyle = MarqueeEnum.NoMarquee
            End If
        End With
    End Sub

    Private Sub DBGChargesAccrual_DoubleClick(sender As Object, e As EventArgs) Handles DBGChargesAccrual.DoubleClick
        With DBGChargesAccrual
            If .RowCount > 0 Then
                If .Columns("Charges").Text.Trim = "Others" Then
                    lblChargesTransaction.Text = "CHARGES & EXPENSE TRANSACTION HISTORY: PAYABLE OTHERS "
                    PayableOthersTransaction()
                Else
                    lblChargesTransaction.Text = "CHARGES & EXPENSE TRANSACTION HISTORY: PAYABLE " & .Columns("Charges").Text.ToUpper
                    PayableChargesTransaction(.Columns("ID").Text)
                End If
            End If
        End With
    End Sub

    Private Sub DBGExpenseYTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGExpenseYTD.Click
        With DBGExpenseYTD
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                DBGChargesAccrual.MarqueeStyle = MarqueeEnum.NoMarquee
            End If
        End With
    End Sub

    Private Sub DBGExpenseYTD_DoubleClick(sender As Object, e As EventArgs) Handles DBGExpenseYTD.DoubleClick
        With DBGExpenseYTD
            If .RowCount > 0 Then
                If .Columns("Charges").Text.Trim = "Others" Then
                    lblChargesTransaction.Text = "CHARGES & EXPENSE TRANSACTION HISTORY: EXPENSE OTHERS "
                    ExpenseOthersTransaction()
                Else
                    lblChargesTransaction.Text = "CHARGES & EXPENSE TRANSACTION HISTORY: EXPENSE " & .Columns("Charges").Text.ToUpper
                    ExpenseChargesTransaction(.Columns("ID").Text)
                End If
            End If
        End With
    End Sub

    Private Sub PayableChargesTransaction(ByVal FeeID As Integer)
        Dim dtTrx As New DataTable
        objChargesPayable.Clear()
        dtTrx = objChargesPayable.Search(objPortfolio, FeeID, ytdDate, objNAV.GetPositionDate)
        If objChargesPayable.ErrID = 0 Then
            TrxFill(dtTrx)
        Else
            DBGChargesTransaction.Columns.Clear()
        End If
    End Sub

    Private Sub ExpenseChargesTransaction(ByVal FeeID As Integer)
        Dim dtTrx As New DataTable
        objChargesExpense.Clear()
        dtTrx = objChargesExpense.Search(objPortfolio, FeeID, ytdDate, objNAV.GetPositionDate)
        If objChargesExpense.ErrID = 0 Then
            TrxFill(dtTrx)
        Else
            DBGChargesTransaction.Columns.Clear()
        End If
    End Sub

    Private Sub PayableOthersTransaction()
        Dim dtTrx As New DataTable
        objOthersPayable.Clear()
        dtTrx = objOthersPayable.Search(objPortfolio, ytdDate, objNAV.GetPositionDate)
        If objOthersPayable.ErrID = 0 Then
            TrxFill(dtTrx)
        Else
            DBGChargesTransaction.Columns.Clear()
        End If
    End Sub

    Private Sub ExpenseOthersTransaction()
        Dim dtTrx As New DataTable
        objOthersExpense.Clear()
        dtTrx = objOthersExpense.Search(objPortfolio, ytdDate, objNAV.GetPositionDate)
        If objOthersExpense.ErrID = 0 Then
            TrxFill(dtTrx)
        Else
            DBGChargesTransaction.Columns.Clear()
        End If
    End Sub

    Private Sub TrxFill(ByVal dtTrx As DataTable)
        Dim query = From s In dtTrx.AsEnumerable
                    Select
                     ID = s.Field(Of Long)("TrxID"), TrxDate = s.Field(Of Date)("TrxDate"), Description = s.Field(Of String)("TrxDescription"),
                     Debit = s.Field(Of Decimal)("TrxDebit"), Credit = s.Field(Of Decimal)("TrxCredit")
        With DBGChargesTransaction
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = query.ToList

            .Columns("Debit").NumberFormat = "n0"
            .Columns("Credit").NumberFormat = "n0"
            .Columns("TrxDate").NumberFormat = "dd-MMM-yy"

            .Splits(0).DisplayColumns("TrxDate").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Debit").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Credit").Style.HorizontalAlignment = AlignHorzEnum.Far

            .Columns("TrxDate").Caption = "Date"

            For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                column.AutoSize()
                .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            Next

        End With
    End Sub

    Private Sub DBGChargesTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGChargesTransaction.Click
        With DBGChargesTransaction
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        NAVGenerate()
    End Sub

    Private Sub NAVGenerate()
        objEOD.endofday(objPortfolio, dtNext.Value)
        If objEOD.ErrID = 0 Then
            CallerForm.MTMLoad()
            Close()
        Else
            ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        NAVReverse
    End Sub

    Private Sub NAVReverse()
        'objEOD.endofday_reverse(objPortfolio, dtNext.Value)
        'If objEOD.ErrID = 0 Then
        '    CallerForm.MTMLoad()
        '    Close()
        'Else
        '    ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

End Class