Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.ParameterPortfolio
Imports simpi.MasterSimpi
Imports simpi.globalutilities

Public Class FormMasterPortfolioSharing
    Public CallerForm As FormMasterPortfolio
    Public objPortfolio As MasterPortfolio
    Dim objUser As New SimpiUser

    Public Sub PortfolioLoad()
        If objPortfolio.GetPortfolioID > 0 Then
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

            GetMasterSimpi()
            objUser.UserAccess = objAccess
            DBGUser.FetchRowStyles = True
        Else
            Close()
        End If
    End Sub

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
        tbl = objPortfolio.User_SearchSharing(objMasterSimpi, txtKeywordUser.Text)
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
            Dim frm As New FormMasterPortfolioSharingAdd
            frm.Left = 0
            frm.Top = 30
            frm.Show()
            frm.objPortfolio = objPortfolio
            frm.PortfolioLoad()
            frm.MdiParent = mdiso
        End If
    End Sub

#End Region

End Class