Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.ParameterPortfolio
Imports simpi.MasterSimpi
Imports simpi.globalutilities

Public Class FormMasterPortfolioIndex
    Public CallerForm As FormMasterPortfolio
    Public objPortfolio As MasterPortfolio
    Dim objUser As New SimpiUser
    Dim objCodeset As New PortfolioCodeset
    Dim FieldID As Integer = 0

    Public Sub PortfolioLoad()
        If objPortfolio.ErrID = 0 Then
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

            If objPortfolio.IsPending Then
                btnEdit.Enabled = True
                btnActivate.Enabled = True
                btnSuspend.Enabled = False
                btnClose.Enabled = False
            ElseIf objPortfolio.IsActive Then
                btnEdit.Enabled = True
                btnActivate.Enabled = False
                btnSuspend.Enabled = True
                btnClose.Enabled = True
            ElseIf objPortfolio.IsSuspend Then
                btnEdit.Enabled = True
                btnActivate.Enabled = True
                btnSuspend.Enabled = False
                btnClose.Enabled = False
            ElseIf objPortfolio.IsClose Then
                btnEdit.Enabled = False
                btnActivate.Enabled = False
                btnSuspend.Enabled = False
                btnClose.Enabled = False
            End If

            objUser.UserAccess = objAccess
            objCodeset.UserAccess = objAccess
            DBGUser.FetchRowStyles = True
            DBGUserSharing.FetchRowStyles = True
            DBGCodeset.FetchRowStyles = True

            GetParameterPortfolioCodesetField()
        Else
            Close()
        End If
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        PortfolioActivate()
    End Sub

    Private Sub btnSuspend_Click(sender As Object, e As EventArgs) Handles btnSuspend.Click
        PortfolioSuspend()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        PortfolioClose()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        PortfolioEdit()
    End Sub

    Private Sub PortfolioEdit()
        Dim frm As New FormMasterPortfolioEdit
        frm.objPortfolio = objPortfolio
        frm.PortfolioLoad()
        frm.Show()
        frm.MdiParent = mdiso
        frm.CallerForm = CallerForm
        Me.Close()
    End Sub

    Private Sub PortfolioSuspend()
        objPortfolio.SetSuspend()
        If objPortfolio.ErrID = 0 Then
            CallerForm.PortfolioSearch()
            Close()
        Else
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PortfolioClose()
        If ExceptionMessage.Show(objError.Message(87), "Info", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            objPortfolio.SetClose()
            If objPortfolio.ErrID = 0 Then
                CallerForm.PortfolioSearch()
                Close()
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub PortfolioActivate()
        objPortfolio.SetActive()
        If objPortfolio.ErrID = 0 Then
            CallerForm.PortfolioSearch()
            Close()
        Else
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#Region "codeset"
    Private Sub btnSearchCodeset_Click(sender As Object, e As EventArgs) Handles btnSearchCodeset.Click
        CodesetLoad()
    End Sub

    Private Sub txtKeywordCodeset_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordCodeset.KeyDown
        If e.KeyCode = Keys.Enter Then
            CodesetLoad()
        End If
    End Sub

    Private Sub CodesetLoad()
        Dim dtField As New DataTable
        objCodeset.Clear()
        dtField = objCodeset.Search(objPortfolio, txtKeywordCodeset.Text)
        If dtParameterPortfolioCodeset IsNot Nothing AndAlso dtParameterPortfolioCodeset.Rows.Count > 0 Then
            Dim query = From c In dtParameterPortfolioCodeset.AsEnumerable
                        Group Join f In dtField.AsEnumerable On c.Field(Of Integer)("FieldID") Equals f.Field(Of Integer)("FieldID") Into cf = Group
                        Let f = cf.FirstOrDefault
                        Select
                                ID = c.Field(Of Integer)("FieldID"),
                                Field = c.Field(Of String)("FieldCode"),
                                Data = If(f Is Nothing, Nothing, f.Field(Of String)("FieldData"))

            With DBGCodeset
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGCodeset.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGCodeset.Columns.Clear()
        End If
        CodesetClear()
    End Sub

    Private Sub DBGCodeset_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGCodeset.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub CodesetClear()
        btnCodesetAdd.Enabled = False
        btnCodesetRemove.Enabled = False
        lblCodesetField.Text = ""
        txtCodesetData.Text = ""
        FieldID = 0
    End Sub

    Private Sub DBGCodeset_Click(sender As Object, e As EventArgs) Handles DBGCodeset.Click
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGCodeset_DoubleClick(sender As Object, e As EventArgs) Handles DBGCodeset.DoubleClick
        CodesetSelect()
    End Sub

    Private Sub CodesetSelect()
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                FieldID = .Columns("ID").Text
                lblCodesetField.Text = .Columns("Field").Text
                txtCodesetData.Text = .Columns("Data").Text
                If txtCodesetData.Text.Trim <> "" Then
                    btnCodesetRemove.Enabled = True
                    btnCodesetAdd.Enabled = False
                Else
                    btnCodesetAdd.Enabled = True
                    btnCodesetRemove.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub btnCodesetAdd_Click(sender As Object, e As EventArgs) Handles btnCodesetAdd.Click
        CodesetAdd()
    End Sub

    Private Sub CodesetAdd()
        If lblCodesetField.Text.Trim <> "" And txtCodesetData.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.Add(objPortfolio, FieldID, txtCodesetData.Text)
            If objCodeset.ErrID = 0 Then
                CodesetLoad()
            Else
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCodesetRemove_Click(sender As Object, e As EventArgs) Handles btnCodesetRemove.Click
        CodesetRemove()
    End Sub

    Private Sub CodesetRemove()
        If lblCodesetField.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.Remove(objPortfolio, lblCodesetField.Text)
            If objCodeset.ErrID = 0 Then
                CodesetLoad()
            Else
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region

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
        tbl = objPortfolio.User_SearchSimpi(txtKeywordUser.Text)
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

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs)
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

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs)
        UserAdd()
    End Sub

    Private Sub UserAdd()
        If objPortfolio.GetPortfolioID > 0 Then
            Dim frm As New FormMasterPortfolioAddSimpi
            frm.Left = 0
            frm.Top = 30
            frm.Show()
            frm.objPortfolio = objPortfolio
            frm.PortfolioLoad()
            frm.MdiParent = mdiso
        End If
    End Sub

#End Region

#Region "sharing user"
    Private Sub btnSearchUserSharing_Click(sender As Object, e As EventArgs) Handles btnSearchUserSharing.Click
        UserSharingSearch()
    End Sub

    Private Sub btnSearchUserSharing_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSearchUserSharing.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserSharingSearch()
        End If
    End Sub

    Public Sub UserSharingSearch()
        Dim tbl As New DataTable
        tbl = objPortfolio.User_SearchSharingAdmin(txtKeywordUserSharing.Text)
        If objPortfolio.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                             ID = t.Field(Of Integer)("simpiID"),
                             simpi = t.Field(Of String)("simpiName"),
                             Administrator = t.Field(Of String)("UserLogin"),
                             Name = t.Field(Of String)("UserName"),
                             Access = ParameterPortfolio.PortfolioAccess(t.Field(Of SByte)("IsTrade"))
            With DBGUserSharing
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGUserSharing.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            DBGUserSharing.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGUserSharing_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGUserSharing.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGUserSharing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUserSharing.Click
        With DBGUserSharing
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGUserSharing_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGUserSharing.DoubleClick
        UserSharingRemove()
    End Sub

    Private Sub btnRemoveUserSharing_Click_1(sender As Object, e As EventArgs)
        UserSharingRemove()
    End Sub

    Private Sub UserSharingRemove()
        With DBGUserSharing
            If .RowCount > 0 Then
                objUser.Clear()
                objUser.Load(.Columns("Administrator").Text)
                If objUser.ErrID = 0 Then
                    objPortfolio.User_Remove(objUser)
                    If objPortfolio.ErrID = 0 Then
                        UserSharingSearch()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnAddUserSharing_Click(sender As Object, e As EventArgs)
        UserSharingAdd()
    End Sub

    Private Sub UserSharingAdd()
        If objPortfolio.GetPortfolioID > 0 Then
            Dim frm As New FormMasterPortfolioAddSharing
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