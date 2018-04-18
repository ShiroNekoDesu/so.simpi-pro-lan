Imports simpi.SystemLog
Imports Microsoft.Office.Interop

Public Class FormMasterSimpiLog
    Public objLog As SystemLog
    Public LogID As Long

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
                PrintExcel(DBGSQL)
        End Select
    End Sub

    Public Sub LogProfile()
        If objLog.ErrID = 0 Then
            GetMasterSimpi()
            txtLogID.Text = LogID
            txtLogDate.Text = objLog.GetLogDate.ToString("dd-MMM-yy HH:mm:ss")
            txtContent.Text = objLog.GetLogContent
            txtDescription.Text = objLog.GetLogDescription
            txtAppsID.Text = objLog.GetAppsID
            txtApplication.Text = objLog.GetAppsName
            txtAppsDate.Text = objLog.GetAppsDate.ToString("dd-MMM-yy HH:mm:ss")
            txtTerminal.Text = objLog.GetAppsTerminal
            txtSimpiID.Text = objLog.GetSimpiID
            txtSimpiName.Text = objLog.GetSimpiName
            txtUserID.Text = objLog.GetUserID
            txtUserLogin.Text = objLog.GetUserName
            LogSQL()
        End If
    End Sub

    Private Sub LogSQL()
        Dim tbl As New DataTable
        tbl = objLog.LogSQL(objMasterSimpi, LogID)
        If objLog.ErrID = 0 Then
            tbl.Columns("LogSQL").ColumnName = "SQL"
            With DBGSQL
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl

                Dim SQL As C1.Win.C1TrueDBGrid.C1DisplayColumn
                SQL = .Splits(0).DisplayColumns("SQL")

                SQL.Width = 800
            End With
        End If
    End Sub




End Class