Imports C1.Win.C1TrueDBGrid
Imports simpi.ParameterSimpi
Imports simpi.SimpiMaster
Imports simpi.ParameterClient
Imports simpi.globalutilities
Imports simpi.SystemLog
Imports simpi.globalutilities.GlobalString

Public Class FormMasterSimpi
    Dim objTicket As New SimpiTicket
    Dim objLog As New SystemLog
    Dim objTerminal As New SimpiTerminal
    Dim objRisk As New ParameterClientRisk
    Dim objSimpiRisk As New SimpiRiskLevel
    Dim objKYC As New SimpiKYC

    Dim FieldID As Integer = 0
    Dim RiskID As Integer = 0

    Private Sub FormAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBGBilling.FetchRowStyles = True
        DBGTicket.FetchRowStyles = True
        DBGLog.FetchRowStyles = True
        DBGRisk.FetchRowStyles = True
        DBGQuestion.FetchRowStyles = True
        DBGKYCApply.FetchRowStyles = True
        DBGKYCAvailable.FetchRowStyles = True
        DBGTerminal.FetchRowStyles = True
        DBGSession.FetchRowStyles = True

        objTicket.UserAccess = objAccess
        objLog.UserAccess = objAccess
        objTerminal.UserAccess = objAccess
        objRisk.UserAccess = objAccess
        objSimpiRisk.UserAccess = objAccess
        objKYC.UserAccess = objAccess

        GetMasterSimpi()
        GetComboInitAll(New ParameterTicketType, cmbTicketType, "TypeID", "TypeCode")
        GetComboInitAll(New ParameterTicketStatus, cmbTicketStatus, "StatusID", "StatusCode")
        GetComboInit(New ParameterClientType, cmbClientType, "TypeID", "TypeCode")
        GetComboInit(New ParameterClientType, cmbClientTypeKYC, "TypeID", "TypeCode")
        cmbClientType.SelectedIndex = -1
        cmbTicketType.SelectedValue = 0
        cmbTicketStatus.SelectedValue = 0

        dtTicketFrom.Value = DateAdd(DateInterval.Day, -30, Now)
        dtTicketTo.Value = Now
        dtLogFrom.Value = Now.AddDays(-1)
        dtLogTo.Value = Now

        ProfileLoad()
    End Sub

    Private Sub ProfileLoad()
        If objSimpi.GetSimpiID > 0 Then
            lblID.Text = objSimpi.GetSimpiID
            lblType.Text = objSimpi.GetSimpiType.GetTypeCode
            lblStatus.Text = objSimpi.GetSimpiStatus.GetStatusCode
            lblName.Text = objSimpi.GetSimpiName
            lblShortname.Text = objSimpi.GetSimpiNameshort
            lblAddress.Text = objSimpi.GetSimpiAddress
            lblPIC.Text = objSimpi.GetSimpiContact
            lblEmail.Text = objSimpi.GetSimpiEmail
            lblPhone.Text = objSimpi.GetSimpiPhone
            lblUserLogin.Text = objSimpi.GetAdminLogin
            lblUserInitial.Text = objSimpi.GetAdminInitial
            lblUserStatus.Text = objSimpi.GetAdminStatus
            lblUserName.Text = objSimpi.GetAdminName
            lblUserTitle.Text = objSimpi.GetAdminTitle
            lblCreditCcy.Text = objSimpi.GetCreditCcy.GetCcy
            lblCreditAmount.Text = objSimpi.GetCreditAmount.ToString("n2")
            lblValid.Text = objSimpi.GetValidDate.ToString("dd-MMM-yyyy")
            lblGrace.Text = objSimpi.GetGracePeriod.ToString("dd-MMM-yyyy")
            lblBilling.Text = objSimpi.GetBillingType.GetTypeCode

            TerminalSearch()
            SessionSearch()
            GetSimpiCodesetField()
            RiskLoad()
        End If
    End Sub

#Region "terminal"
    Private Sub TerminalSearch()
        Dim tbl As New DataTable
        objTerminal.Clear()
        tbl = objTerminal.Search()
        If objTerminal.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                         ID = t.Field(Of Long)("TerminalID"),
                         MACAddress = t.Field(Of String)("MACAddress"),
                         IPAddress = t.Field(Of String)("IPAddress"),
                         ComputerName = t.Field(Of String)("ComputerName")

            With DBGTerminal
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList
                For Each column As C1DisplayColumn In DBGTerminal.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            ExceptionMessage.Show(objTerminal.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        TerminalClear()
    End Sub

    Private Sub DBGTerminal_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGTerminal.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub TerminalClear()
        txtMACAddress.Text = ""
        txtIPAddress.Text = ""
        txtComputerName.Text = ""
    End Sub

    Private Sub DBGTerminal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGTerminal.Click
        With DBGTerminal
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGTerminal_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DBGTerminal.MouseDoubleClick
        TerminaSelect()
    End Sub

    Private Sub TerminaSelect()
        With DBGTerminal
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                txtMACAddress.Text = .Columns("MACAddress").Text
                txtIPAddress.Text = .Columns("IPAddress").Text
                txtComputerName.Text = .Columns("ComputerName").Text
                btnRemoveTerminal.Enabled = True
                btnAddTerminal.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnAddTerminal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTerminal.Click
        TerminalNew()
    End Sub

    Private Sub TerminalNew()
        objTerminal.Clear()
        objTerminal.Add(txtMACAddress.Text, txtIPAddress.Text, txtComputerName.Text)
        If objTerminal.ErrID = 0 Then
            TerminalSearch()
        Else
            ExceptionMessage.Show(objTerminal.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveTerminal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTerminal.Click
        TerminalRemove()
    End Sub

    Private Sub TerminalRemove()
        objTerminal.Clear()
        objTerminal.Load(txtMACAddress.Text)
        If objTerminal.ErrID = 0 Then
            objTerminal.Remove()
            If objTerminal.ErrID = 0 Then
                TerminalSearch()
            Else
                ExceptionMessage.Show(objTerminal.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExceptionMessage.Show(objTerminal.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SessionSearch()
        Dim tbl As New DataTable
        objTerminal.Clear()
        tbl = objTerminal.Session_Search()
        If objTerminal.ErrID = 0 Then
            Dim query = From t In tbl.AsEnumerable
                        Select
                             ID = t.Field(Of Integer)("UserID"),
                             User = t.Field(Of String)("UserLogin"),
                             LogTime = t.Field(Of Date)("LogTime"),
                             MACAddress = t.Field(Of String)("MACAddress"),
                             IPAddress = t.Field(Of String)("IPAddress"),
                             ComputerName = t.Field(Of String)("ComputerName")

            With DBGSession
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGSession.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            DBGSession.Columns.Clear()
        End If
        btnClearSession.Enabled = False
    End Sub

    Private Sub DBGSession_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGSession.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSession.Click
        With DBGSession
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnClearSession.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnClearSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSession.Click
        SessionRemove()
    End Sub

    Private Sub SessionRemove()
        With DBGSession
            If .RowCount > 0 Then
                objUser.Clear()
                objUser.Load(.Columns("User").Text)
                objTerminal.Session_Remove(objUser, .Columns("MACAddress").Text)
                If objTerminal.ErrID = 0 Then
                    SessionSearch()
                Else
                    ExceptionMessage.Show(objTerminal.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

#End Region

#Region "contact us"
    Private Sub cmdTicketCancel_Click(sender As Object, e As EventArgs) Handles cmdTicketCancel.Click
        txtTicketDescription.Text = ""
        cmbTicketType.SelectedValue = 0
    End Sub

    Private Sub cmdTicketSubmit_Click(sender As Object, e As EventArgs) Handles cmdTicketSubmit.Click
        If cmbTicketType.SelectedIndex <> -1 Then
            objTicket.Clear()
            objTicket.Add(cmbTicketType.SelectedValue, txtTicketDescription.Text)
            If objTicket.ErrID = 0 Then
                txtTicketDescription.Text = ""
                cmbTicketType.SelectedValue = 0
                TicketSearch()
            Else
                ExceptionMessage.Show(objTicket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmdTicketSearch_Click(sender As Object, e As EventArgs) Handles cmdTicketSearch.Click
        TicketSearch()
    End Sub

    Public Sub TicketSearch()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        objTicket.Clear()
        tbl = objTicket.Search(dtLogFrom.Value, dtLogTo.Value,
                               IIf(cmbTicketType.SelectedIndex = -1, 0, cmbTicketType.SelectedValue),
                               IIf(cmbTicketStatus.SelectedIndex = -1, 0, cmbTicketStatus.SelectedValue))
        If objTicket.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("ticket", True, "TicketID", "TicketDate", "UserName", "StatusCode", "TicketDescription")
            With tbl2
                .Columns("TicketDate").ColumnName = "Date"
                .Columns("TicketID").ColumnName = "ID"
                .Columns.Add("Ticket")
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i)("Ticket") = "DESCRIPTION: " & Environment.NewLine &
                                         .Rows(i)("TicketDescription") & Environment.NewLine &
                                         "USER: " & .Rows(i)("UserName") & Environment.NewLine &
                                         "STATUS: " & .Rows(i)("StatusCode") & Environment.NewLine & "-"
                Next
                .Columns.Remove("UserName")
                .Columns.Remove("StatusCode")
                .Columns.Remove("TicketDescription")
                .Columns("ID").SetOrdinal(0)
                .Columns("Date").SetOrdinal(1)
                .Columns("Ticket").SetOrdinal(2)
            End With

            With DBGTicket
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                Dim dt, tiket, id As C1DisplayColumn
                id = .Splits(0).DisplayColumns("ID")
                dt = .Splits(0).DisplayColumns("Date")
                tiket = .Splits(0).DisplayColumns("Ticket")

                id.Width = 50
                dt.Width = 120
                tiket.Width = 450

                .Splits(0).DisplayColumns(0).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns(1).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns(2).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

                .Splits(0).DisplayColumns(0).Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns(1).Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns(2).Style.HorizontalAlignment = AlignHorzEnum.Near

                .Splits(0).DisplayColumns(2).Style.WrapText = True

                .Columns("Date").NumberFormat = "dd-MMM-yyyy hh:mm"

                DBGTicket.SuspendLayout()
                For i As Integer = 0 To DBGTicket.Splits(0).Rows.Count - 1
                    DBGTicket.Splits(0).Rows(i).AutoSize()
                Next
                DBGTicket.ResumeLayout(True)

            End With
        Else
            ExceptionMessage.Show(objTicket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGTicket_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGTicket.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGTicket.Click
        With DBGTicket
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGTicket_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGTicket.DoubleClick
        TicketProfile()
    End Sub

    Private Sub TicketProfile()
        With DBGTicket
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objTicket.Clear()
                objTicket.Load(.Columns("ID").Text)
                If objTicket.ErrID = 0 Then
                    Dim frm As New FormMasterSimpiTicket
                    frm.objTicket = objTicket
                    frm.TicketLoad()
                    frm.Show()
                    frm.CallerForm = Me
                    frm.MdiParent = MDISO
                Else
                    ExceptionMessage.Show(objTicket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End With
    End Sub

#End Region

#Region "simpi log"
    Private Sub btnLogSearch_Click(sender As Object, e As EventArgs) Handles btnLogSearch.Click
        SystemLog()
    End Sub

    Private Sub SystemLog()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        objLog.Clear()
        Dim strKeyword As String = SQLKeyword(txtLogKeyword.Text, IIf(rbNone2.Checked, rbNone2.Text, IIf(rbAnd2.Checked, rbAnd2.Text, IIf(rbOr2.Checked, rbOr2.Text, rbCombine2.Text))))
        tbl = objLog.LogSearch(objMasterSimpi, "", 0, "", dtLogFrom.Value, dtLogTo.Value, strKeyword, "", "")
        If objLog.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("log", True, "LogID", "LogDate", "UserLogin", "LogDescription", "AppsCode", "AppsTerminal", "AppsDate")
            With tbl2
                .Columns.Add("Activity")
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i)("Activity") = "DESCRIPTION: " &
                                   Environment.NewLine & .Rows(i)("LogDescription") &
                                   Environment.NewLine & "APPLICATION: " & .Rows(i)("AppsCode") &
                                   Environment.NewLine & "TERMINAL: " & .Rows(i)("AppsTerminal") &
                                   Environment.NewLine & " "
                Next
                .Columns.Remove("LogDescription")
                .Columns.Remove("AppsCode")
                .Columns.Remove("AppsTerminal")
                .Columns.Remove("AppsDate")
            End With

            With DBGLog
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                .Columns("LogDate").NumberFormat = "dd-MMM-yyyy hh:mm:ss"

                .Splits(0).DisplayColumns("LogID").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("LogDate").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("UserLogin").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Activity").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

                .Splits(0).DisplayColumns("LogID").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("LogDate").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("UserLogin").Style.HorizontalAlignment = AlignHorzEnum.Near
                .Splits(0).DisplayColumns("Activity").Style.HorizontalAlignment = AlignHorzEnum.Near

                .Splits(0).DisplayColumns("LogID").Width = 35
                .Splits(0).DisplayColumns("LogDate").Width = 125
                .Splits(0).DisplayColumns("UserLogin").Width = 150
                .Splits(0).DisplayColumns("Activity").Width = 425

                .Columns("LogDate").Caption = "Date"
                .Columns("UserLogin").Caption = "User"

                DBGLog.SuspendLayout()
                For i As Integer = 0 To DBGLog.Splits(0).Rows.Count - 1
                    DBGLog.Splits(0).Rows(i).AutoSize()
                Next
                DBGLog.ResumeLayout(True)

            End With
        Else
            DBGLog.Columns.Clear()
            ExceptionMessage.Show(objLog.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DBGLog_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGLog.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGLog.Click
        With DBGLog
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGLog_DoubleClick(sender As Object, e As EventArgs) Handles DBGLog.DoubleClick
        LogProfile()
    End Sub

    Private Sub LogProfile()
        With DBGLog
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objLog.Clear()
                objLog.LogLoad(objMasterSimpi, .Columns("LogID").Text)
                If objLog.ErrID = 0 Then
                    Dim frm As New FormMasterSimpiLog
                    frm.objLog = objLog
                    frm.LogID = .Columns("LogID").Text
                    frm.LogProfile()
                    frm.MdiParent = MDISO
                    frm.Show()
                Else
                    ExceptionMessage.Show(objLog.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

#End Region

#Region "risk level"
    Private Sub RiskLoad()
        Dim tblRisk As New DataTable
        Dim tblSimpi As New DataTable
        objRisk.Clear()
        objSimpiRisk.Clear()
        tblRisk = objRisk.Search("")
        tblSimpi = objSimpiRisk.Search()
        If tblRisk IsNot Nothing AndAlso tblRisk.Rows.Count > 0 Then
            Dim query = From c In tblRisk.AsEnumerable
                        Group Join f In tblSimpi.AsEnumerable On c.Field(Of Integer)("RiskID") Equals
                            f.Field(Of Integer)("RiskID") Into cf = Group
                        Let f = cf.FirstOrDefault
                        Order By If(f Is Nothing, c.Field(Of Integer)("RiskID"), f.Field(Of Integer)("MaximumValue")) Ascending
                        Select
                                ID = c.Field(Of Integer)("RiskID"),
                                RiskLevel = c.Field(Of String)("RiskCode"),
                                MaxValue = If(f Is Nothing, Nothing, f.Field(Of Integer)("MaximumValue"))

            With DBGRisk
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGRisk.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGRisk.Columns.Clear()
        End If
        RiskClear()
    End Sub

    Private Sub DBGRisk_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGRisk.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub RiskClear()
        btnSetRiskLevel.Enabled = False
        lblRiskLevel.Text = ""
        txtMaximumValue.Text = ""
        DBGQuestion.Columns.Clear()
        RiskID = 0
    End Sub

    Private Sub DBGRisk_Click(sender As Object, e As EventArgs) Handles DBGRisk.Click
        With DBGRisk
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGRisk_DoubleClick(sender As Object, e As EventArgs) Handles DBGRisk.DoubleClick
        RiskSelect()
    End Sub

    Private Sub RiskSelect()
        With DBGRisk
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                RiskID = .Columns("ID").Text
                lblRiskLevel.Text = .Columns("RiskLevel").Text
                txtMaximumValue.Text = .Columns("MaxValue").Text
                btnSetRiskLevel.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnSetRiskLevel_Click(sender As Object, e As EventArgs) Handles btnSetRiskLevel.Click
        RiskAdd()
    End Sub

    Private Sub RiskAdd()
        If lblRiskLevel.Text.Trim <> "" And IsNumeric(txtMaximumValue.Text) Then
            objSimpiRisk.Load(RiskID)
            If objSimpiRisk.ErrID = 0 Then
                objSimpiRisk.Remove(RiskID)
            Else
                objSimpiRisk.Add(RiskID, txtMaximumValue.Text)
            End If
            If objSimpiRisk.ErrID = 0 Then
                RiskLoad()
            Else
                ExceptionMessage.Show(objSimpiRisk.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmbClientType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientType.SelectedIndexChanged
        RiskQuestionSearch()
    End Sub

    Public Sub RiskQuestionSearch()
        If cmbClientType.SelectedIndex <> -1 Then
            Dim tbl As New DataTable
            tbl = objSimpiRisk.Question_Search(cmbClientType.SelectedValue)
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                Dim query = From c In tbl.AsEnumerable
                            Order By c.Field(Of Integer)("QuestionNo") Ascending
                            Select
                                    No = c.Field(Of Integer)("QuestionNo"),
                                    Question = c.Field(Of String)("QuestionText")

                With DBGQuestion
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    For Each column As C1DisplayColumn In DBGQuestion.Splits(0).DisplayColumns
                        column.AutoSize()
                    Next

                End With
            Else
                DBGQuestion.Columns.Clear()
            End If
        End If
    End Sub

    Private Sub DBGQuestion_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGQuestion.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub btnAddQuestion_Click(sender As Object, e As EventArgs) Handles btnAddQuestion.Click
        QuestionAdd()
    End Sub

    Private Sub QuestionAdd()
        Dim frm As New FormMasterSimpiRiskLevel
        frm.Show()
        frm.objSimpiRisk = objSimpiRisk
        frm.TypeID = cmbClientType.SelectedValue
        frm.QuestionNew()
        frm.CallerForm = Me
        frm.MdiParent = MDISO
    End Sub

    Private Sub DBGQuestion_Click(sender As Object, e As EventArgs) Handles DBGQuestion.Click
        With DBGQuestion
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGQuestion_DoubleClick(sender As Object, e As EventArgs) Handles DBGQuestion.DoubleClick
        QuestionSelect()
    End Sub

    Private Sub btnProfileQuestion_Click(sender As Object, e As EventArgs) Handles btnProfileQuestion.Click
        QuestionSelect()
    End Sub

    Private Sub QuestionSelect()
        With DBGQuestion
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                Dim frm As New FormMasterSimpiRiskLevel
                frm.Show()
                frm.objSimpiRisk = objSimpiRisk
                frm.TypeID = cmbClientType.SelectedValue
                frm.txtQuestionNo.Text = .Columns("No").Text
                frm.txtQuestionText.Text = .Columns("Question").Text
                frm.QuestionOld()
                frm.MdiParent = MDISO
            End If
        End With
    End Sub

    Private Sub btnRemoveQuestion_Click(sender As Object, e As EventArgs) Handles btnRemoveQuestion.Click
        QuestionRemove()
    End Sub

    Private Sub QuestionRemove()
        With DBGQuestion
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objSimpiRisk.Question_Remove(cmbClientType.SelectedValue, .Columns("No").Text)
                If objSimpiRisk.ErrID = 0 Then
                    RiskQuestionSearch()
                Else
                    ExceptionMessage.Show(objSimpiRisk.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

#End Region

#Region "kyc field"
    Private Sub cmbClientTypeKYC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientTypeKYC.SelectedIndexChanged
        KYCApply()
        KYCAvailable()
    End Sub

    Private Sub btnSearchKYCApply_Click(sender As Object, e As EventArgs) Handles btnSearchKYCApply.Click
        KYCApply()
    End Sub

    Private Sub txtKeywordKYCApply_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordKYCApply.KeyDown
        If e.KeyCode = Keys.Enter Then
            KYCApply()
        End If
    End Sub

    Private Sub KYCApply()
        Dim tbl As New DataTable
        objKYC.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeywordKYCApply.Text, IIf(rbNone2.Checked, rbNone2.Text, IIf(rbAnd2.Checked, rbAnd2.Text, IIf(rbOr2.Checked, rbOr2.Text, rbCombine2.Text))))
        tbl = objKYC.SearchApply(cmbClientTypeKYC.SelectedValue, strKeyword)
        If objKYC.ErrID = 0 Then
            With tbl
                .Columns("kycID").ColumnName = "ID"
                .Columns("kycCode").ColumnName = "Field"
                .Columns("kycDescription").ColumnName = "Description"
            End With

            With DBGKYCApply
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl

                For Each column As C1DisplayColumn In DBGKYCApply.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            ExceptionMessage.Show(objKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveKYC_Click(sender As Object, e As EventArgs) Handles btnRemoveKYC.Click
        KYCRemove()
    End Sub

    Private Sub KYCRemove()
        With DBGKYCApply
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objKYC.Clear()
                objKYC.Remove(cmbClientTypeKYC.SelectedValue, .Columns("ID").Text)
                If objKYC.ErrID = 0 Then
                    KYCApply()
                    KYCAvailable()
                Else
                    ExceptionMessage.Show(objKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub DBGKYCApply_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGKYCApply.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGKYCApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGKYCApply.Click
        With DBGKYCApply
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGKYCApply_DoubleClick(sender As Object, e As EventArgs) Handles DBGKYCApply.DoubleClick
        KYCRemove()
    End Sub

    Private Sub btnSearchKYCAvailable_Click(sender As Object, e As EventArgs) Handles btnSearchKYCAvailable.Click
        KYCAvailable()
    End Sub

    Private Sub txtKeywordKYCAvailable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordKYCAvailable.KeyDown
        If e.KeyCode = Keys.Enter Then
            KYCAvailable()
        End If
    End Sub

    Private Sub KYCAvailable()
        Dim tbl As New DataTable
        objKYC.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeywordKYCAvailable.Text, IIf(rbNone1.Checked, rbNone1.Text, IIf(rbAnd1.Checked, rbAnd1.Text, IIf(rbOr1.Checked, rbOr1.Text, rbCombine1.Text))))
        tbl = objKYC.SearchAvailable(cmbClientTypeKYC.SelectedValue, strKeyword)
        If objKYC.ErrID = 0 Then
            With tbl
                .Columns("kycID").ColumnName = "ID"
                .Columns("kycCode").ColumnName = "Field"
                .Columns("kycDescription").ColumnName = "Description"
            End With

            With DBGKYCAvailable
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl

                For Each column As C1DisplayColumn In DBGKYCAvailable.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            ExceptionMessage.Show(objKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAddKYC_Click(sender As Object, e As EventArgs) Handles btnAddKYC.Click
        KYCAdd()
    End Sub

    Private Sub KYCAdd()
        With DBGKYCAvailable
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objKYC.Clear()
                objKYC.Add(cmbClientTypeKYC.SelectedValue, .Columns("ID").Text)
                If objKYC.ErrID = 0 Then
                    KYCApply()
                    KYCAvailable()
                Else
                    ExceptionMessage.Show(objKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub DBGKYCAvailable_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGKYCAvailable.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGKYCAvailable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGKYCAvailable.Click
        With DBGKYCAvailable
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGKYCAvailable_DoubleClick(sender As Object, e As EventArgs) Handles DBGKYCAvailable.DoubleClick
        KYCAdd()
    End Sub

#End Region

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
        End Select
    End Sub

End Class