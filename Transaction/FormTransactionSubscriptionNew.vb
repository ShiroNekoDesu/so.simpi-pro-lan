Imports simpi.MasterPortfolio
Imports simpi.CoreCapital
Imports simpi.CoreData
Imports simpi.globalutilities

Public Class FormTransactionSubscriptionNew
    Public CallerForm As FormTransactionSubscription
    Public objPortfolio As MasterPortfolio
    Dim objCapital As New ProcessCapital
    Dim objNAV As New PortfolioNAV
    Dim objSales As New simpi.MasterSales.MasterSales
    Dim objClient As New simpi.MasterClient.MasterClient
    Dim objAccount As New PortfolioBankAccount
    Dim objPosition As New PositionCapital

    Private Sub FormTransactionSubscriptionNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ClientScreen()
        Dim form As New FormSelectMasterClient
        form.lblCode = lblClientCode
        form.lblName = lblClientName
        form.Show()
        If IsMdiChild Then form.MdiParent = MDISO
        lblClientCode.Text = ""
        lblClientName.Text = ""
    End Sub

    Private Sub lblClientCode_TextChanged(sender As Object, e As EventArgs) Handles lblClientCode.TextChanged
        ClientLoad
    End Sub

    Private Sub ClientLoad()
        If lblClientCode.Text.Trim <> "" Then
            objClient.Clear()
            objClient.Load(objMasterSimpi, lblClientCode.Text)
            If objClient.ErrID = 0 Then
                lblSalesCode.Text = objClient.GetMasterSales.GetSalesCode
                lblSalesName.Text = objClient.GetMasterSales.GetSimpiUser.GetUserName
            End If
        End If
    End Sub

    Private Sub btnAcq_Click(sender As Object, e As EventArgs) Handles btnAcq.Click
        PositionLoad()
    End Sub

    Private Sub PositionLoad()
        If objClient.ErrID = 0 Then
            objPosition.Clear()
            objPosition.LoadAt(objPortfolio, objClient, objCapital.GetDateTransaction)
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
        End If
    End Sub

    Private Sub btnSearchSales_Click(sender As Object, e As EventArgs) Handles btnSearchSales.Click
        SalesScreen()
    End Sub

    Private Sub SalesScreen()
        Dim form As New FormSelectMasterSales
        form.lblSalesCode = lblSalesCode
        form.lblSalesName = lblSalesName
        form.Show()
        If IsMdiChild Then form.MdiParent = MDISO
    End Sub

    Private Sub lblSalesCode_TextChanged(sender As Object, e As EventArgs) Handles lblSalesCode.TextChanged
        SalesLoad()
    End Sub

    Private Sub SalesLoad()
        objSales.Clear()
        objSales.Load(objMasterSimpi, lblSalesCode.Text)
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

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        CalculateUnit()
    End Sub

    Private Sub txtSellingFee_TextChanged(sender As Object, e As EventArgs) Handles txtSellingFee.TextChanged
        CalculateUnit()
    End Sub

    Private Sub CalculateUnit()
        Dim tmp As Double = 0
        Double.TryParse(txtAmount.Text, tmp)
        objCapital.GetTrxAmount = tmp
        Double.TryParse(txtSellingFee.Text, tmp)
        objCapital.GetSellingFeePercentage = tmp / 100
        lblSellingFeeAmount.Text = objCapital.SellingFeeAmount.ToString("n2")
        lblNetAmount.Text = objCapital.SubscriptionNet.ToString("n2")
        lblUnit.Text = objCapital.SubscriptionUnit.ToString("n4")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If objClient.GetClientID = 0 Then
            ExceptionMessage.Show(objError.Message(81) & " master client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If objSales.GetSalesID = 0 Then
            ExceptionMessage.Show(objError.Message(81) & " master sales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If objAccount.GetAccountID = 0 Then
            ExceptionMessage.Show(objError.Message(81) & " bank account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        objCapital.subscription_cash(objSales, objClient, objAccount, txtNotes.Text)
        If objCapital.ErrID = 0 Then
            CallerForm.SubscriptionSearch()
            Close()
        Else
            ExceptionMessage.Show(objCapital.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub


End Class