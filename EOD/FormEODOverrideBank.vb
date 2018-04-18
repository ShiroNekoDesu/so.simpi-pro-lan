Imports System.IO
Imports Microsoft.Office.Interop
Imports simpi.GlobalUtilities
Imports simpi.CoreData
Imports simpi.CoreOverride
Imports simpi.MasterPortfolio
Imports simpi.MarketCompany
Imports simpi.ParameterBank.ParameterBank
Imports C1.Win.C1FlexGrid

Public Class FormEODOverrideBank
    Dim objPortfolio As New MasterPortfolio
    Dim objAccount As New PortfolioBankAccount
    Dim objPosition As New PositionBank
    Dim objMTM As New PortfolioMTM
    Dim objOverride As New OverrideBank
    Dim objOffice As New MarketCompanyOffice
    Dim dtPosition As New DataTable
    Dim dtAccount As New DataTable
    Dim no As Integer
    Dim qty, interest As Double

    Private Sub FormEODOverrideBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        GetParameterBankTDTerm()
        objPortfolio.UserAccess = objAccess
        objAccount.UserAccess = objAccess
        objPosition.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        objOffice.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        dtMaturity.Value = Now
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
        clearBank()
        clearManual()
    End Sub

    Private Sub clearBank()
        lblCompanyCode.Text = ""
        lblCompanyName.Text = ""
        lblCompanyID.Text = ""
        cmbBankAccount.SelectedIndex = -1
        lblAccountID.Text = ""
        txtNominal.Text = ""
        txtInterest.Text = ""
        txtRate.Text = ""
    End Sub

    Private Sub clearManual()
        initManual()
        txtSummaryQty.Text = ""
        txtSummaryAccrued.Text = ""
        txtSummaryTotal.Text = ""
    End Sub

    Private Sub initManual()
        With fgManual
            .Rows.Count = 1
            .Cols.Count = 11
            .ExtendLastCol = False
            fgManual(0, 0) = "No"
            fgManual(0, 1) = "ID"
            fgManual(0, 2) = "Bank"
            fgManual(0, 3) = "Name"
            fgManual(0, 4) = "Type"
            fgManual(0, 5) = "AccountNo"
            fgManual(0, 6) = "Nominal"
            fgManual(0, 7) = "Interest"
            fgManual(0, 8) = "Maturity"
            fgManual(0, 9) = "Rate"
            fgManual(0, 10) = "TypeID"
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
                PortfolioAccountSearch()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub PortfolioAccountSearch()
        Dim tbl As New DataTable
        objAccount.Clear()
        tbl = objAccount.SearchAccount(objPortfolio)
        cmbBankAccount.Items.Clear()
        cmbBankAccount.DataSource = Nothing
        If objAccount.ErrID = 0 Then
            Dim query = From es In tbl.AsEnumerable
                        Select BankID = es.Field(Of Integer)("CompanyID"),
                               Account = es.Field(Of String)("CompanyName") & " | " & es.Field(Of String)("AccountNo")
            cmbBankAccount.DataSource = query.ToList
            cmbBankAccount.DisplayMember = "Account"
            cmbBankAccount.ValueMember = "BankID"
            cmbBankAccount.SelectedIndex = -1
        Else
            ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DataBank()
    End Sub

    Private Sub DataBank()
        If objPortfolio.GetPortfolioID > 0 Then
            objPosition.Clear()
            dtPosition = objPosition.Search(objPortfolio, dtAs.Value)
            objAccount.Clear()
            dtAccount = objAccount.SearchAll(objPortfolio)
            clearBank()
            clearManual()
            DisplayBank()
        End If
    End Sub

    Private Sub rbAll_Click(sender As Object, e As EventArgs) Handles rbAll.Click
        DisplayBank()
    End Sub

    Private Sub rbCash_Click(sender As Object, e As EventArgs) Handles rbCash.Click
        DisplayBank()
    End Sub

    Private Sub rbTD_Click(sender As Object, e As EventArgs) Handles rbTD.Click
        DisplayBank()
    End Sub

    Private Function _no() As Integer
        no += 1
        Return no
    End Function

    Private Sub DisplayBank()
        initManual()
        If dtPosition IsNot Nothing AndAlso dtPosition.Rows.Count > 0 Then
            If rbAll.Checked Then
                _displayall()
            ElseIf rbCash.Checked Then
                _displaycash
            Else
                _displaytd
            End If
        End If
    End Sub

    Private Sub _displayall()
        Dim query = From p In dtPosition.AsEnumerable
                    Join a In dtAccount.AsEnumerable
                         On p.Field(Of Long)("AccountID") Equals a.Field(Of Long)("AccountID")
                    Group Join t In dtParameterBankTDTerm.AsEnumerable
                         On t.Field(Of Integer)("TDTermID") Equals a.Field(Of Integer)("TDTermID") Into pat = Group Let t = pat.FirstOrDefault
                    Select _no(), ID = p.Field(Of Long)("AccountID"),
                                  Bank = a.Field(Of String)("CompanyCode"),
                                  Name = a.Field(Of String)("CompanyName"),
                                  Type = If(t Is Nothing, "", t.Field(Of String)("TDTermCode")),
                                  TypeID = a.Field(Of Integer)("TDTypeID"),
                                  AccountNo = a.Field(Of String)("AccountNo"),
                                  Maturity = a.Field(Of Date)("DateEnd"),
                                  Rate = a.Field(Of Decimal)("InterestRate") * 100,
                                  Nominal = p.Field(Of Decimal)("AccountBalance"),
                                  Interest = p.Field(Of Decimal)("AccountInterest")
        txtSummaryQty.Text = (From q In query Select q.Nominal).Sum.ToString("n2")
        txtSummaryAccrued.Text = (From q In query Select q.Interest).Sum.ToString("n2")
        txtSummaryTotal.Text = (CDbl(txtSummaryQty.Text) + CDbl(txtSummaryAccrued.Text)).ToString("n2")

        For Each item In query
            fgManual.Rows.Add()
            fgManual(fgManual.Rows.Count - 1, 0) = item._no
            fgManual(fgManual.Rows.Count - 1, 1) = item.ID
            fgManual(fgManual.Rows.Count - 1, 2) = item.Bank
            fgManual(fgManual.Rows.Count - 1, 3) = item.Name
            fgManual(fgManual.Rows.Count - 1, 4) = item.Type
            fgManual(fgManual.Rows.Count - 1, 5) = item.AccountNo
            fgManual(fgManual.Rows.Count - 1, 6) = item.Nominal.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 7) = item.Interest.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 8) = item.Maturity.ToString("dd-MMM-yy")
            fgManual(fgManual.Rows.Count - 1, 9) = CDbl(item.Rate).ToString("n5")
            fgManual(fgManual.Rows.Count - 1, 10) = item.TypeID
        Next
        fgManual.AutoSizeCols()
        fgManual.Cols(10).Width = 0
    End Sub

    Private Sub _displaycash()
        Dim query = From p In dtPosition.AsEnumerable
                    Join a In dtAccount.AsEnumerable
                         On p.Field(Of Long)("AccountID") Equals a.Field(Of Long)("AccountID")
                    Group Join t In dtParameterBankTDTerm.AsEnumerable
                         On t.Field(Of Integer)("TDTermID") Equals a.Field(Of Integer)("TDTermID") Into pat = Group Let t = pat.FirstOrDefault
                    Where a.Field(Of Integer)("TDTypeID") = SetBankAccount()
                    Select _no(), ID = p.Field(Of Long)("AccountID"),
                                  Bank = a.Field(Of String)("CompanyCode"),
                                  Name = a.Field(Of String)("CompanyName"),
                                  Type = If(t Is Nothing, "", t.Field(Of String)("TDTermCode")),
                                  TypeID = a.Field(Of Integer)("TDTypeID"),
                                  AccountNo = a.Field(Of String)("AccountNo"),
                                  Maturity = a.Field(Of Date)("DateEnd"),
                                  Rate = a.Field(Of Decimal)("InterestRate") * 100,
                                  Nominal = p.Field(Of Decimal)("AccountBalance"),
                                  Interest = p.Field(Of Decimal)("AccountInterest")
        txtSummaryQty.Text = (From q In query Select q.Nominal).Sum.ToString("n2")
        txtSummaryAccrued.Text = (From q In query Select q.Interest).Sum.ToString("n2")
        txtSummaryTotal.Text = (CDbl(txtSummaryQty.Text) + CDbl(txtSummaryAccrued.Text)).ToString("n2")

        For Each item In query
            fgManual.Rows.Add()
            fgManual(fgManual.Rows.Count - 1, 0) = item._no
            fgManual(fgManual.Rows.Count - 1, 1) = item.ID
            fgManual(fgManual.Rows.Count - 1, 2) = item.Bank
            fgManual(fgManual.Rows.Count - 1, 3) = item.Name
            fgManual(fgManual.Rows.Count - 1, 4) = item.Type
            fgManual(fgManual.Rows.Count - 1, 5) = item.AccountNo
            fgManual(fgManual.Rows.Count - 1, 6) = item.Nominal.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 7) = item.Interest.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 8) = item.Maturity.ToString("dd-MMM-yy")
            fgManual(fgManual.Rows.Count - 1, 9) = CDbl(item.Rate).ToString("n5")
            fgManual(fgManual.Rows.Count - 1, 10) = item.TypeID
        Next
        fgManual.AutoSizeCols()
        fgManual.Cols(10).Width = 0
    End Sub

    Private Sub _displaytd()
        Dim query = From p In dtPosition.AsEnumerable
                    Join a In dtAccount.AsEnumerable
                         On p.Field(Of Long)("AccountID") Equals a.Field(Of Long)("AccountID")
                    Group Join t In dtParameterBankTDTerm.AsEnumerable
                         On t.Field(Of Integer)("TDTermID") Equals a.Field(Of Integer)("TDTermID") Into pat = Group Let t = pat.FirstOrDefault
                    Where a.Field(Of Integer)("TDTypeID") = SetBankDeposit() Or a.Field(Of Integer)("TDTypeID") = SetBankOnCall()
                    Select _no(), ID = p.Field(Of Long)("AccountID"),
                                  Bank = a.Field(Of String)("CompanyCode"),
                                  Name = a.Field(Of String)("CompanyName"),
                                  Type = If(t Is Nothing, "", t.Field(Of String)("TDTermCode")),
                                  TypeID = a.Field(Of Integer)("TDTypeID"),
                                  AccountNo = a.Field(Of String)("AccountNo"),
                                  Maturity = a.Field(Of Date)("DateEnd"),
                                  Rate = a.Field(Of Decimal)("InterestRate") * 100,
                                  Nominal = p.Field(Of Decimal)("AccountBalance"),
                                  Interest = p.Field(Of Decimal)("AccountInterest")
        txtSummaryQty.Text = (From q In query Select q.Nominal).Sum.ToString("n2")
        txtSummaryAccrued.Text = (From q In query Select q.Interest).Sum.ToString("n2")
        txtSummaryTotal.Text = (CDbl(txtSummaryQty.Text) + CDbl(txtSummaryAccrued.Text)).ToString("n2")

        For Each item In query
            fgManual.Rows.Add()
            fgManual(fgManual.Rows.Count - 1, 0) = item._no
            fgManual(fgManual.Rows.Count - 1, 1) = item.ID
            fgManual(fgManual.Rows.Count - 1, 2) = item.Bank
            fgManual(fgManual.Rows.Count - 1, 3) = item.Name
            fgManual(fgManual.Rows.Count - 1, 4) = item.Type
            fgManual(fgManual.Rows.Count - 1, 5) = item.AccountNo
            fgManual(fgManual.Rows.Count - 1, 6) = item.Nominal.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 7) = item.Interest.ToString("n2")
            fgManual(fgManual.Rows.Count - 1, 8) = item.Maturity.ToString("dd-MMM-yy")
            fgManual(fgManual.Rows.Count - 1, 9) = CDbl(item.Rate).ToString("n5")
            fgManual(fgManual.Rows.Count - 1, 10) = item.TypeID
        Next
        fgManual.AutoSizeCols()
        fgManual.Cols(10).Width = 0
    End Sub

    Private Sub fgManual_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgManual.OwnerDrawCell
        Dim s As CellStyle = fgManual.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgManual.Rows(e.Row).Style = fgManual.Styles("RowStyle")
    End Sub

    Private Sub fgManual_DoubleClick(sender As Object, e As EventArgs) Handles fgManual.DoubleClick
        With fgManual
            If .Rows.Count > 1 AndAlso .Row > 0 Then
                lblAccountID.Text = fgManual(.Row, 1)
                lblCompanyCode.Text = fgManual(.Row, 2)
                lblCompanyName.Text = fgManual(.Row, 3)
                cmbBankAccount.Text = fgManual(.Row, 3) & " | " & fgManual(.Row, 5)
                txtNominal.Text = fgManual(.Row, 6)
                txtInterest.Text = fgManual(.Row, 7)
                If IsBankAccount(fgManual(.Row, 10)) Then rbBankAccount.Checked = True Else rbDeposit.Checked = True
                bankSelect()
                dtMaturity.Value = CDate(fgManual(.Row, 8))
                txtRate.Text = fgManual(.Row, 9)
            End If
        End With
    End Sub

    Private Sub rbBankAccount_Click(sender As Object, e As EventArgs) Handles rbBankAccount.Click
        bankSelect()
    End Sub

    Private Sub rbDeposit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbDeposit.SelectedIndexChanged
        bankSelect()
    End Sub

    Private Sub bankSelect()
        If rbBankAccount.Checked Then
            cmbBankAccount.Enabled = True
            btnSearchBank.Enabled = False
            dtMaturity.Enabled = False
            txtRate.Enabled = False
            txtRate.Text = ""
        Else
            cmbBankAccount.Enabled = False
            btnSearchBank.Enabled = True
            dtMaturity.Enabled = True
            txtRate.Enabled = True
        End If
    End Sub

    Private Sub btnSearchBank_Click(sender As Object, e As EventArgs) Handles btnSearchBank.Click
        BankSearch()
    End Sub

    Private Sub BankSearch()
        Dim form As New FormSelectBank
        form.lblID = lblCompanyID
        form.lblCode = lblCompanyCode
        form.lblName = lblCompanyName
        form.Show()
        form.MdiParent = MDISO
        lblCompanyID.Text = ""
        lblCompanyCode.Text = ""
        lblCompanyName.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BankAdd()
    End Sub

    Private Sub BankAdd()
        If rbBankAccount.Checked Then _addCash() Else _addTD()
    End Sub

    Private Sub _addCash()
        If objPortfolio.GetPortfolioID > 0 And cmbBankAccount.SelectedIndex <> -1 Then
            Double.TryParse(txtNominal.Text, qty)
            Double.TryParse(txtInterest.Text, interest)
            objOverride.Clear()
            objOverride.override_cash(objPortfolio, CInt(cmbBankAccount.SelectedValue), AccountSplit, dtAs.Value, qty, interest)
            If objOverride.ErrID = 0 Then DataBank() Else ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub _addTD()
        If objPortfolio.GetPortfolioID > 0 Then
            Double.TryParse(txtNominal.Text, qty)
            Double.TryParse(txtInterest.Text, interest)
            objOverride.Clear()
            If IsNumeric(lblAccountID.Text) Then
                objOverride.override_deposit(objPortfolio, CLng(lblAccountID.Text), dtAs.Value, qty, interest)
            Else
                Dim rate As Double
                objOffice.Clear()
                Dim OfficeID As Integer() = objOffice.SearchID(CStr(lblCompanyCode.Text), 0, "", "")
                If OfficeID.Length = 0 Then OfficeID(0) = 0
                Double.TryParse(txtRate.Text, rate)
                objOverride.override_deposit(objPortfolio, dtAs.Value, qty, interest, OfficeID(0), dtMaturity.Value, rate)
            End If
            If objOverride.ErrID = 0 Then DataBank() Else ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        BankRemove()
    End Sub

    Private Sub BankRemove()
        If rbBankAccount.Checked Then _removeCash() Else _removeTD()
    End Sub

    Private Sub _removeCash()
        If objPortfolio.GetPortfolioID > 0 And cmbBankAccount.SelectedIndex <> -1 Then
            objOverride.Clear()
            objOverride.override_remove(objPortfolio, CInt(cmbBankAccount.SelectedValue), AccountSplit, dtAs.Value)
            If objOverride.ErrID = 0 Then DataBank() Else ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AccountSplit() As String
        Dim parts As String() = cmbBankAccount.Text.Split(New Char() {"|"c})
        Return parts(1).Trim
    End Function

    Private Sub _removeTD()
        If objPortfolio.GetPortfolioID > 0 And IsNumeric(lblAccountID.Text) Then
            objOverride.Clear()
            objOverride.override_remove(objPortfolio, CLng(lblAccountID.Text), dtAs.Value)
            If objOverride.ErrID = 0 Then DataBank() Else ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

End Class