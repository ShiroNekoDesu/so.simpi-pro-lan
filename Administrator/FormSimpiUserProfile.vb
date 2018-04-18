Imports C1.Win.C1TrueDBGrid
Imports simpi.SystemSecurity
Imports simpi.globalutilities
Imports simpi.MasterPortfolio
Imports simpi.ParameterPortfolio
Imports simpi.SimpiMaster
Imports simpi.SystemLog
Imports simpi.globalutilities.GlobalString

Public Class FormSimpiUserProfile
    Public objUser As SimpiUser
    Public CallerForm As FormSimpiUser
    Dim objMasterUser As New simpi.MasterSimpi.SimpiUser
    Dim objSharingSimpi As New simpi.MasterSimpi.MasterSimpi
    Dim objLog As New SystemLog
    Dim objApps As New SystemApplication
    Dim objMenu As New SystemMenu
    Dim objReport As New SystemReport
    Dim objPortfolio As New MasterPortfolio

    Public Sub UserLoad()
        If objUser.GetUserID > 0 Then
            lblIDUser.Text = objUser.GetUserID
            lblLoginUser.Text = objUser.GetUserLogin
            lblStatusUser.Text = objUser.GetUserStatus.GetStatusCode
            lblUserLogin.Text = objUser.GetUserLogin
            lblUserID.Text = objUser.GetUserID
            lblUserInitial.Text = objUser.GetUserInitial
            lblUserName.Text = objUser.GetUserName
            lblUserStatus.Text = objUser.GetUserStatus.GetStatusCode
            lblUserTitle.Text = objUser.GetUserTitle

            dtFrom.Value = Now.AddDays(-30)
            dtTo.Value = Now
            DBGLog.FetchRowStyles = True
            DBGApplication.FetchRowStyles = True
            DBGMenu.FetchRowStyles = True
            DBGReport.FetchRowStyles = True
            DBGPortfolioSimpi.FetchRowStyles = True
            DBGPortfolioSharing.FetchRowStyles = True

            objLog.UserAccess = objAccess
            objApps.UserAccess = objAccess
            objMenu.UserAccess = objAccess
            objReport.UserAccess = objAccess
            objPortfolio.UserAccess = objAccess
            objSharingSimpi.UserAccess = objAccess
            objMasterUser.UserAccess = objAccess
            objMasterUser.Load(objUser.GetUserLogin)

            GetMasterSimpi()
            GetParameterCountry()
            GetParameterPortfolioStatus()
            GetParameterPortfolioAssetType()
            GetParameterPortfolioType()

            UserApplication()
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearchLog_Click(sender As Object, e As EventArgs) Handles btnSearchLog.Click
        UserLog()
    End Sub

    Private Sub txtKeywordLog_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordLog.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserLog()
        End If
    End Sub

    Private Sub UserLog()
        Dim tbl As New DataTable
        objLog.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeywordLog.Text, IIf(rbNone1.Checked, rbNone1.Text, IIf(rbAnd1.Checked, rbAnd1.Text, IIf(rbOr1.Checked, rbOr1.Text, rbCombine1.Text))))
        tbl = objLog.LogSearch(objMasterUser, 0, "", dtFrom.Value, dtTo.Value, strKeyword, "", "")
        If objLog.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                             ID = t.Field(Of Long)("LogID"),
                             Apps = t.Field(Of String)("AppsCode"),
                             Server = t.Field(Of Date)("LogDate"),
                             Terminal = t.Field(Of String)("AppsTerminal"),
                             Description = t.Field(Of String)("LogDescription")

            With DBGLog
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Server").NumberFormat = "dd-MMM-yyyy hh:mm"

                For Each column As C1DisplayColumn In DBGLog.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGLog.Columns.Clear()
            ExceptionMessage.Show(objLog.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DBGLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGLog.Click
        With DBGLog
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UserEdit()
    End Sub

    Private Sub UserEdit()
        Dim frm As New FormSimpiUserEdit
        frm.Show()
        frm.objUser = objUser
        frm.UserLoad()
        frm.CallerForm = CallerForm
        frm.MdiParent = mdiso
        Close()
    End Sub

    Public Sub UserApplication()
        Dim tbl As New DataTable
        tbl = objUser.Application_SearchApps()
        If objUser.ErrID = 0 Then
            Dim query = From a In tbl.AsEnumerable
                        Select
                            ID = a.Field(Of Integer)("AppsID"),
                            Code = a.Field(Of String)("AppsCode"),
                            Name = a.Field(Of String)("AppsName"),
                            IsPublic = IIf(a.Field(Of SByte)("IsPublic") = 0, "N", "Y")

            With DBGApplication
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGApplication.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGApplication.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DBGMenu.Columns.Clear()
        DBGReport.Columns.Clear()
        btnAddApplication.Enabled = True
        btnRemoveApplication.Enabled = False
        btnAddMenu.Enabled = False
        btnRemoveMenu.Enabled = False
        btnAddReport.Enabled = False
        btnRemoveReport.Enabled = False
    End Sub

    Private Sub DBGApplication_Click(sender As Object, e As EventArgs) Handles DBGApplication.Click
        With DBGApplication
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnRemoveApplication.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGApplication_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGApplication.DoubleClick
        With DBGApplication
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objApps.Clear()
                objApps.LoadCode(.Columns("Code").Text)
                If objApps.ErrID = 0 Then
                    ApplicationMenu()
                    ApplicationReport()
                Else
                    DBGMenu.Columns.Clear()
                    DBGReport.Columns.Clear()
                    ExceptionMessage.Show(objApps.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnAddApplication_Click(sender As Object, e As EventArgs) Handles btnAddApplication.Click
        ApplicationAdd()
    End Sub

    Private Sub btnRemoveApplication_Click(sender As Object, e As EventArgs) Handles btnRemoveApplication.Click
        ApplicationRemove()
    End Sub

    Private Sub ApplicationAdd()
        If objUser.ErrID = 0 Then
            Dim frm As New FormSimpiUserProfileApplication
            frm.Show()
            frm.objUser = objUser
            frm.ApplicationLoad()
            frm.CallerForm = Me
            frm.MdiParent = mdiso
        End If
    End Sub

    Private Sub ApplicationRemove()
        With DBGApplication
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objApps.Clear()
                objApps.LoadCode(.Columns("Code").Text)
                If objApps.ErrID = 0 Then
                    objUser.Application_Remove(objApps)
                    If objUser.ErrID = 0 Then
                        UserApplication()
                    Else
                        ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objApps.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Public Sub ApplicationMenu()
        If objApps.GetAppsID > 0 Then
            DBGApplication.MarqueeStyle = MarqueeEnum.HighlightRow
            Dim tbl As New DataTable
            tbl = objUser.Menu_SearchMenu(objApps)
            If objUser.ErrID = 0 Then
                Dim query = From a In tbl.AsEnumerable
                            Select
                            ID = a.Field(Of Integer)("MenuID"),
                            Code = a.Field(Of String)("MenuCode"),
                            Name = a.Field(Of String)("MenuName")

                With DBGMenu
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    For Each column As C1DisplayColumn In DBGMenu.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGMenu.Columns.Clear()
                ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        btnAddMenu.Enabled = True
        btnRemoveMenu.Enabled = False
    End Sub

    Private Sub btnAddMenu_Click(sender As Object, e As EventArgs) Handles btnAddMenu.Click
        MenuAdd()
    End Sub

    Private Sub btnRemoveMenu_Click(sender As Object, e As EventArgs) Handles btnRemoveMenu.Click
        MenuRemove()
    End Sub

    Private Sub MenuAdd()
        If objUser.ErrID = 0 And DBGApplication.RowCount > 0 Then
            Dim frm As New FormSimpiUserProfileMenu
            frm.Show()
            frm.objApps = objApps
            frm.objUser = objUser
            frm.MenuLoad()
            frm.CallerForm = Me
            frm.MdiParent = mdiso
        End If
    End Sub

    Private Sub DBGMenu_Click(sender As Object, e As EventArgs) Handles DBGMenu.Click
        With DBGMenu
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnRemoveMenu.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGMenu_DoubleClick(sender As Object, e As EventArgs) Handles DBGMenu.DoubleClick
        MenuRemove()
    End Sub

    Private Sub MenuRemove()
        If DBGMenu.RowCount > 0 Then
            objMenu.Clear()
            objMenu.LoadCode(objApps, DBGMenu.Columns("Code").Text)
            If objMenu.ErrID = 0 Then
                objUser.Menu_Remove(objMenu)
                If objUser.ErrID = 0 Then
                    ApplicationMenu()
                Else
                    ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objMenu.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Public Sub ApplicationReport()
        If objApps.GetAppsID > 0 Then
            DBGApplication.MarqueeStyle = MarqueeEnum.HighlightRow
            Dim tbl As New DataTable
            tbl = objUser.Report_SearchReport(objApps)
            If objUser.ErrID = 0 Then
                Dim query = From a In tbl.AsEnumerable
                            Select
                            ID = a.Field(Of Integer)("ReportID"),
                            Code = a.Field(Of String)("ReportCode"),
                            Name = a.Field(Of String)("ReportName")

                With DBGReport
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    For Each column As C1DisplayColumn In DBGReport.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGReport.Columns.Clear()
                ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
        btnAddReport.Enabled = True
        btnRemoveReport.Enabled = False
    End Sub

    Private Sub btnAddReport_Click(sender As Object, e As EventArgs) Handles btnAddReport.Click
        ReportAdd()
    End Sub

    Private Sub btnRemoveReport_Click(sender As Object, e As EventArgs) Handles btnRemoveReport.Click
        ReportRemove()
    End Sub

    Private Sub ReportAdd()
        If objUser.ErrID = 0 And DBGApplication.RowCount > 0 Then
            Dim frm As New FormSimpiUserProfileReport
            frm.Show()
            frm.objApps = objApps
            frm.objUser = objUser
            frm.ReportLoad()
            frm.CallerForm = Me
            frm.MdiParent = mdiso
        End If
    End Sub

    Private Sub DBGReport_Click(sender As Object, e As EventArgs) Handles DBGReport.Click
        With DBGReport
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnRemoveReport.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGReport_DoubleClick(sender As Object, e As EventArgs) Handles DBGReport.DoubleClick
        ReportRemove()
    End Sub

    Private Sub ReportRemove()
        If DBGReport.RowCount > 0 Then
            objReport.Clear()
            objReport.LoadCode(objApps, DBGReport.Columns("Code").Text)
            If objReport.ErrID = 0 Then
                objUser.Report_Remove(objReport)
                If objUser.ErrID = 0 Then
                    ApplicationMenu()
                Else
                    ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objReport.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSimpiSearch()
    End Sub

    Private Sub txtKeywordPortfolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordPortfolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            PortfolioSimpiSearch()
        End If
    End Sub

    Public Sub PortfolioSimpiSearch()
        Dim dtPortfolio As New DataTable
        Dim strKeyword As String = SQLKeyword(txtKeywordPortfolio.Text, IIf(rbNone2.Checked, rbNone2.Text, IIf(rbAnd2.Checked, rbAnd2.Text, IIf(rbOr2.Checked, rbOr2.Text, rbCombine2.Text))))
        dtPortfolio = objUser.Portfolio_SearchSimpi(strKeyword)
        If objUser.ErrID = 0 Then
            Dim query = From p In dtPortfolio.AsEnumerable
                        Join c In dtParameterCountry.AsEnumerable On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                        Join s In dtParameterPortfolioStatus.AsEnumerable On p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Join a In dtParameterPortfolioAsset.AsEnumerable On p.Field(Of Integer)("AssetTypeID") Equals a.Field(Of Integer)("AssetTypeID")
                        Join l In dtParameterPortfolioType.AsEnumerable On p.Field(Of Integer)("TypeID") Equals l.Field(Of Integer)("TypeID")
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             Ccy = c.Field(Of String)("Ccy"),
                             Asset = a.Field(Of String)("AssetTypeCode"),
                             Level = l.Field(Of String)("TypeCode"),
                             Status = s.Field(Of String)("StatusCode"),
                             Access = ParameterPortfolio.PortfolioAccess(p.Field(Of SByte)("IsTrade"))

            With DBGPortfolioSimpi
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGPortfolioSimpi.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGPortfolioSimpi.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnAddPortfolio.Enabled = True
        btnRemovePortfolio.Enabled = False
    End Sub

    Private Sub btnAddPortfolio_Click(sender As Object, e As EventArgs) Handles btnAddPortfolio.Click
        PortfolioAdd()
    End Sub

    Private Sub btnRemovePortfolio_Click(sender As Object, e As EventArgs) Handles btnRemovePortfolio.Click
        PortfolioRemove()
    End Sub

    Private Sub PortfolioAdd()
        If objUser.ErrID = 0 Then
            Dim frm As New FormSimpiUserProfilePortfolioSimpi
            frm.Show()
            frm.objUser = objUser
            frm.PortfolioLoad()
            frm.CallerForm = Me
            frm.MdiParent = MDISO
        End If
    End Sub

    Private Sub DBGPortfolioSimpi_Click(sender As Object, e As EventArgs) Handles DBGPortfolioSimpi.Click
        With DBGPortfolioSimpi
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnRemovePortfolio.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGPortfolioSimpi_DoubleClick(sender As Object, e As EventArgs) Handles DBGPortfolioSimpi.DoubleClick
        PortfolioRemove()
    End Sub

    Private Sub PortfolioRemove()
        If DBGPortfolioSimpi.RowCount > 0 Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, DBGPortfolioSimpi.Columns("Code").Text)
            If objPortfolio.ErrID = 0 Then
                objPortfolio.User_Remove(objMasterUser)
                If objPortfolio.ErrID = 0 Then
                    PortfolioSimpiSearch()
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearchPortfolioSharing_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolioSharing.Click
        PortfolioSharingSearch()
    End Sub

    Private Sub txtKeywordPortfolioSharing_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordPortfolioSharing.KeyDown
        If e.KeyCode = Keys.Enter Then
            PortfolioSharingSearch()
        End If
    End Sub

    Private Sub PortfolioSharingSearch()
        Dim dtPortfolio As New DataTable
        Dim strKeyword As String = SQLKeyword(txtKeywordPortfolioSharing.Text, IIf(rbNone3.Checked, rbNone3.Text, IIf(rbAnd3.Checked, rbAnd3.Text, IIf(rbOr3.Checked, rbOr3.Text, rbCombine3.Text))))
        dtPortfolio = objUser.Portfolio_SearchSharing(strKeyword)
        If objUser.ErrID = 0 Then
            Dim query = From p In dtPortfolio.AsEnumerable
                        Join c In dtParameterCountry.AsEnumerable On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                        Join s In dtParameterPortfolioStatus.AsEnumerable On p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Join a In dtParameterPortfolioAsset.AsEnumerable On p.Field(Of Integer)("AssetTypeID") Equals a.Field(Of Integer)("AssetTypeID")
                        Join l In dtParameterPortfolioType.AsEnumerable On p.Field(Of Integer)("TypeID") Equals l.Field(Of Integer)("TypeID")
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             simpi = p.Field(Of String)("simpiName"),
                             simpiEmail = p.Field(Of String)("simpiEmail"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             Ccy = c.Field(Of String)("Ccy"),
                             Asset = a.Field(Of String)("AssetTypeCode"),
                             Level = l.Field(Of String)("TypeCode"),
                             Status = s.Field(Of String)("StatusCode"),
                             Access = ParameterPortfolio.PortfolioAccess(p.Field(Of SByte)("IsTrade"))

            With DBGPortfolioSharing
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGPortfolioSharing.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then
                        column.Visible = False
                    Else
                        column.AutoSize()
                    End If
                Next

            End With
        Else
            DBGPortfolioSharing.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnAddPortfolioSharing.Enabled = True
        btnRemovePortfolioSharing.Enabled = False
    End Sub

    Private Sub btnAddPortfolioSharing_Click(sender As Object, e As EventArgs) Handles btnAddPortfolioSharing.Click
        PortfolioSharingAdd()
    End Sub

    Private Sub btnRemovePortfolioSharing_Click(sender As Object, e As EventArgs) Handles btnRemovePortfolioSharing.Click
        PortfolioSharingRemove()
    End Sub

    Private Sub PortfolioSharingAdd()
        If objUser.ErrID = 0 Then
            Dim frm As New FormSimpiUserProfilePortfolioSharing
            frm.Show()
            frm.objUser = objUser
            frm.PortfolioLoad()
            frm.CallerForm = Me
            frm.MdiParent = MDISO
        End If
    End Sub

    Private Sub DBGPortfolioSharing_Click(sender As Object, e As EventArgs) Handles DBGPortfolioSharing.Click
        With DBGPortfolioSharing
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnRemovePortfolio.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGPortfolioSharing_DoubleClick(sender As Object, e As EventArgs) Handles DBGPortfolioSharing.DoubleClick
        PortfolioSharingRemove()
    End Sub

    Private Sub PortfolioSharingRemove()
        If DBGPortfolioSharing.RowCount > 0 Then
            objSharingSimpi.Clear()
            objSharingSimpi.Load(DBGPortfolioSharing.Columns("simpiEmail").Text)
            If objSharingSimpi.ErrID = 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objSharingSimpi, DBGPortfolioSharing.Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objPortfolio.User_Remove(objMasterUser)
                    If objPortfolio.ErrID = 0 Then
                        PortfolioSharingSearch()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objSharingSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DBGLog_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGLog.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGApplication_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGApplication.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGMenu_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGMenu.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGReport_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGReport.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGPortfolioSimpi_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGPortfolioSimpi.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGPortfolioSharing_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGPortfolioSharing.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

End Class