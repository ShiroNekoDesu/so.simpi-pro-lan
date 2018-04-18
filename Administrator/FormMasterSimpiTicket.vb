Imports C1.Win.C1TrueDBGrid
Imports simpi.SimpiMaster
Imports simpi.ParameterSimpi
Imports simpi.globalutilities
Imports Microsoft.Office.Interop

Public Class FormMasterSimpiTicket
    Public objTicket As SimpiTicket
    Public CallerForm As FormMasterSimpi

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
                PrintExcel(DBGFollowUp)
        End Select
    End Sub

    Public Sub TicketLoad()
        If objTicket.GetTicketID > 0 Then
            lblUserID.Text = objTicket.GetSimpiUser.GetUserID
            lblUserName.Text = objTicket.GetSimpiUser.GetUserName
            lblUserLogin.Text = objTicket.GetSimpiUser.GetUserLogin

            lblTicketID.Text = objTicket.GetTicketID
            lblTicketDate.Text = objTicket.GetTicketDate.ToString("dd-MMM-yyyy hh:nn")
            lblTicketType.Text = objTicket.GetTicketType.GetTypeCode
            lblTicketStatus.Text = objTicket.GetTicketStatus.GetStatusCode
            lblTicketDescription.Text = objTicket.GetTicketDescription
            GetComboInit(New ParameterTicketStatus, cmbStatus, "StatusID", "StatusCode")
            DBGFollowUp.FetchRowStyles = True
            FollowUpLoad()
        Else
            ExceptionMessage.Show(objTicket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
    End Sub

    Private Sub DBGFollowUp_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGFollowUp.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGFollowUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFollowUp.Click
        If DBGFollowUp.RowCount > 0 Then DBGFollowUp.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub FollowUpLoad()
        Dim tbl As New DataTable
        Dim tbl2 As New DataTable
        tbl = objTicket.FollowUp_Search(objTicket.GetTicketID)
        If objTicket.ErrID = 0 Then
            tbl2 = tbl.DefaultView.ToTable("ticket", True, "FollowUpNo", "FollowUpDate", "UserName", "FollowUpDescription")
            With tbl2
                .Columns("FollowUpNo").ColumnName = "No"
                .Columns("FollowUpDate").ColumnName = "Date"
                .Columns.Add("FollowUp")
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i)("FollowUp") = "DESCRIPTION: " & .Rows(i)("FollowUpDescription") & Environment.NewLine &
                                           "USER: " & .Rows(i)("UserName") & Environment.NewLine & "-"
                Next
                .Columns.Remove("UserName")
                .Columns.Remove("FollowUpDescription")
            End With

            With DBGFollowUp
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl2

                Dim no, dt, tiket As C1DisplayColumn
                no = .Splits(0).DisplayColumns("No")
                dt = .Splits(0).DisplayColumns("Date")
                tiket = .Splits(0).DisplayColumns("FollowUp")

                no.Width = 35
                dt.Width = 120
                tiket.Width = 550

                .Splits(0).DisplayColumns(0).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns(1).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns(2).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

                .Splits(0).DisplayColumns(0).Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns(1).Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns(2).Style.HorizontalAlignment = AlignHorzEnum.Near

                .Splits(0).DisplayColumns(2).Style.WrapText = True

                .Columns("Date").NumberFormat = "dd-MMM-yyyy hh:mm"

                DBGFollowUp.SuspendLayout()
                For i As Integer = 0 To DBGFollowUp.Splits(0).Rows.Count - 1
                    DBGFollowUp.Splits(0).Rows(i).AutoSize()
                Next
                DBGFollowUp.ResumeLayout(True)

            End With
        Else
            DBGFollowUp.Columns.Clear()
            ExceptionMessage.Show(objTicket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        FollowUpSave()
    End Sub

    Private Sub FollowUpSave()
        If cmbStatus.SelectedIndex <> -1 Then
            objTicket.FollowUp_Add(objTicket.GetTicketID, cmbStatus.SelectedValue, txtDescription.Text)
            If objTicket.ErrID = 0 Then
                CallerForm.TicketSearch()
                Close()
            Else
                ExceptionMessage.Show(objTicket.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmbCancel_Click(sender As Object, e As EventArgs) Handles cmbCancel.Click
        Close()
    End Sub

End Class