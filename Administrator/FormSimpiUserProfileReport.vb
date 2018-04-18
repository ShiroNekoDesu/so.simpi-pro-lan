Imports C1.Win.C1TrueDBGrid
Imports simpi.SystemSecurity
Imports simpi.globalutilities
Imports simpi.SimpiMaster

Public Class FormSimpiUserProfileReport
    Public objUser As SimpiUser
    Public objApps As SystemApplication
    Public CallerForm As FormSimpiUserProfile
    Dim objReport As New SystemReport

    Public Sub ReportLoad()
        If objUser.GetUserID > 0 Then
            lblIDUser.Text = objUser.GetUserID
            lblLoginUser.Text = objUser.GetUserLogin
            lblStatusUser.Text = objUser.GetUserStatus.GetStatusCode

            lblAppsID.Text = objApps.GetAppsID
            lblAppsCode.Text = objApps.GetAppsCode
            lblAppsName.Text = objApps.GetAppsName

            btnAdd.Enabled = False
            DBGReport.FetchRowStyles = True
            objReport.UserAccess = objAccess

            ReportSearch()
        Else
            Close()
        End If
    End Sub

    Private Sub ReportSearch()
        Dim tbl As New DataTable
        tbl = objUser.Report_SearchReportAvailable(objApps)
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

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DBGReport_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGReport.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReport.Click
        With DBGReport
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnAdd.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGReport_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReport.DoubleClick
        ReportAdd()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ReportAdd()
    End Sub

    Private Sub ReportAdd()
        With DBGReport
            If .RowCount > 0 Then
                objReport.Clear()
                objReport.LoadCode(objApps, .Columns("Code").Text)
                If objReport.ErrID = 0 Then
                    objUser.Report_Add(objReport)
                    If objUser.ErrID = 0 Then
                        CallerForm.ApplicationReport()
                        Close()
                    Else
                        ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objReport.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub
End Class