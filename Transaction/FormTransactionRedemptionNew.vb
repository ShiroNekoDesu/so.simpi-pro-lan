Imports simpi.MasterPortfolio
Imports simpi.CoreCapital
Imports simpi.CoreData
Imports simpi.globalutilities

Public Class FormTransactionRedemptionNew
    Public CallerForm As FormTransactionRedemption
    Public objPortfolio As simpi.MasterPortfolio.MasterPortfolio
    Dim objCapital As New ProcessCapital
    Dim objNAV As New PortfolioNAV
    Dim objSales As New simpi.MasterSales.MasterSales
    Dim objClient As New simpi.MasterClient.MasterClient
    Dim objAccount As New PortfolioBankAccount
    Dim objPosition As New PositionCapital

    Private Sub FormTransactionRedemptionNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If objPortfolio.GetPortfolioID = 0 Then
            Close()
        Else
            objSales.UserAccess = objAccess
            objClient.UserAccess = objAccess
            objAccount.UserAccess = objAccess
            objCapital.UserAccess = objAccess
            objNAV.UserAccess = objAccess
            objPosition.UserAccess = objAccess

            lblPortfolioCode.Text = objPortfolio.GetPortfolioCode
            lblPortfolioName.Text = objPortfolio.GetPortfolioNameFull
            lblSimpiName.Text = objPortfolio.GetMasterSimpi.GetSimpiName
            lblPortfolioCcy.Text = objPortfolio.GetPortfolioCcy.GetCcy

            objCapital.GetMasterPortfolio = objPortfolio
            lblNAVDate.Text = objCapital.GetDateNAV.ToString("dd-MMM-yyyy")
            lblPrice.Text = objCapital.GetUnitPrice.ToString("n4")
            lblTransactionDate.Text = objCapital.GetDateTransaction.ToString("dd-MMM-yyyy")
            objNAV.LoadAt(objPortfolio, objCapital.GetDateTransaction)
            If objNAV.ErrID = 0 Then
                lblNAV.Text = objNAV.GetNAV.ToString("n2")
                lblTotalUnits.Text = objNAV.GetTotalUnit.ToString("n2")
            Else
                lblNAV.Text = "0.00"
                lblTotalUnits.Text = "0.0000"
            End If
            GetMasterSimpi()
            PortfolioAccountSearch()
        End If
    End Sub

    Private Sub PortfolioAccountSearch()
        Dim tbl As New DataTable
        objAccount.Clear()
        tbl = objAccount.SearchAccount(objPortfolio, 0, "")
        cmbBankAccount.Items.Clear()
        cmbBankAccount.DataSource = Nothing
        If objAccount.ErrID = 0 Then
            Dim query = From es In tbl.AsEnumerable
                        Select BankID = es.Field(Of Integer)("CompanyID"),
                               Account = es.Field(Of String)("CompanyName") & " | " & es.Field(Of String)("AccountNo")
            RemoveHandler cmbBankAccount.ChangeCommitted, AddressOf cmbBankAccount_ChangeCommitted
            cmbBankAccount.DataSource = query.ToList
            cmbBankAccount.DisplayMember = "Account"
            cmbBankAccount.ValueMember = "BankID"
            AddHandler cmbBankAccount.ChangeCommitted, AddressOf cmbBankAccount_ChangeCommitted
            cmbBankAccount.SelectedIndex = -1
        Else
            ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearchClient_Click(sender As Object, e As EventArgs) Handles btnSearchClient.Click
        ClientScreen()
    End Sub

    Private Sub ClientSales()
        objClient.Load(objMasterSimpi, lblClientCode.Text)
        If objClient.ErrID = 0 Then
            lblSalesCode.Text = objClient.GetMasterSales.GetSalesCode
            lblSalesName.Text = objClient.GetMasterSales.GetSimpiUser.GetUserName
        End If
    End Sub

    Private Sub ClientScreen()
        Dim form As New FormSelectMasterClient
        form.lblCode = lblClientCode
        form.lblName = lblClientName
        form.Show()
        If IsMdiChild Then
            form.MdiParent = MDISO
        End If
    End Sub

    Private Sub lblClientName_TextChanged(sender As Object, e As EventArgs) Handles lblClientName.TextChanged
        ClientSales()
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        CheckAll()
    End Sub

    Private Sub CheckAll()
        If chkAll.Checked Then
            PositionLoad()
            If objPosition.ErrID = 0 Then
                txtUnit.Text = objPosition.GetUnitBalance
                txtUnit.Enabled = False
            Else
                ExceptionMessage.Show(objPosition.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                chkAll.Checked = False
            End If
        Else
            txtUnit.Enabled = True
        End If
    End Sub

    Private Sub btnAcq_Click(sender As Object, e As EventArgs) Handles btnAcq.Click
        AcqLoad()
    End Sub

    Private Sub AcqLoad()
        PositionLoad()
        If objPosition.ErrID = 0 Then
            Dim form As New FormTransactionCapitalAcquisition
            form.objPosition = objPosition
            form.DataLoad()
            form.Show()
            If IsMdiChild Then
                form.MdiParent = MDISO
            End If
        Else
            ExceptionMessage.Show(objPosition.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PositionLoad()
        If lblClientName.Text <> "" Then
            objClient.Load(objMasterSimpi, lblClientCode.Text)
            If objClient.ErrID = 0 Then
                objPosition.Clear()
                objPosition.LoadAt(objPortfolio, objClient, objCapital.GetDateTransaction)
            Else
                ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmbBankAccount_ChangeCommitted(sender As Object, e As EventArgs) Handles cmbBankAccount.ChangeCommitted
        PortfolioAccountLoad()
    End Sub

    Private Sub PortfolioAccountLoad()
        If cmbBankAccount.SelectedIndex <> -1 Then
            Dim BankID As Integer = cmbBankAccount.SelectedValue
            objAccount.Clear()
            objAccount.Load(objPortfolio.GetMasterSimpi, BankID, AccountSplit)
            If objAccount.ErrID = 0 Then
                lblAccountName.Text = objAccount.GetAccountName
                lblAccountCcy.Text = objAccount.GetAccountCcy.GetCcy
            Else
                ExceptionMessage.Show(objAccount.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function AccountSplit() As String
        Dim parts As String() = cmbBankAccount.Text.Split(New Char() {"|"c})
        Return parts(1).Trim
    End Function

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        CalculateAmount()
    End Sub

    Private Sub txtRedemptionFee_TextChanged(sender As Object, e As EventArgs) Handles txtRedemptionFee.TextChanged
        CalculateAmount()
    End Sub

    Private Sub CalculateAmount()
        Dim tmp As Double = 0
        Double.TryParse(txtRedemptionFee.Text, tmp)
        objCapital.GetRedemptionFeePercentage = tmp / 100
        Double.TryParse(txtUnit.Text, tmp)
        lblAmount.Text = objCapital.RedemptionAmount(tmp).ToString("n2")
        lblRedemptionFeeAmount.Text = objCapital.RedemptionFeeAmount().ToString("n2")
        lblNetAmount.Text = objCapital.RedemptionNetAmountByUnit(tmp).ToString("n2")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If cmbBankAccount.SelectedIndex = -1 Then
            ExceptionMessage.Show(objError.Message(1) & " bank account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        objClient.Load(objMasterSimpi, lblClientCode.Text)
        If objClient.ErrID <> 0 Then
            ExceptionMessage.Show(objClient.ErrMsg)
            Exit Sub
        End If

        objAccount.Clear()
        objAccount.Load(objPortfolio.GetMasterSimpi, cmbBankAccount.SelectedValue, AccountSplit)
        If objAccount.ErrID <> 0 Then
            ExceptionMessage.Show(objAccount.ErrMsg)
            Exit Sub
        End If

        objCapital.redemption(objClient, objAccount, dtPayment.Value, txtNotes.Text)
        If objCapital.ErrID = 0 Then
            CallerForm.redemptionsearch
            Close()
        Else
            ExceptionMessage.Show(objCapital.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class