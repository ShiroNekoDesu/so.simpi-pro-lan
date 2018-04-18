Imports C1.Win.C1TrueDBGrid
Imports simpi.GlobalUtilities
Imports simpi.MasterReferral
Imports simpi.MasterSimpi

Public Class FormReferralMaintenance
    Dim objReferral As New MasterReferral
    Dim objSimpi As New MasterSimpi

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
                PrintExcel(DBGReferral)
        End Select
    End Sub

    Private Sub FormReferralMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterClientStatus()
        objReferral.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        DBGReferral.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ReferralSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then ReferralSearch()
    End Sub

    Public Sub ReferralSearch()
        Dim tbl As New DataTable
        objReferral.Clear()
        tbl = objReferral.SearchAll(objMasterSimpi, txtKeyword.Text)
        If objReferral.ErrID = 0 Then
            Dim query = From p In tbl.AsEnumerable Join s In dtParameterClientStatus.AsEnumerable On
                             p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Select
                             ID = p.Field(Of Integer)("SalesID"),
                             Code = p.Field(Of String)("SalesCode"),
                             Name = p.Field(Of String)("UserName"),
                             simpi = p.Field(Of String)("simpiName"),
                             simpiEmail = p.Field(Of String)("simpiEmail"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGReferral
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGReferral.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then
                        column.Visible = False
                    Else
                        column.AutoSize()
                    End If
                Next

            End With
        Else
            DBGReferral.Columns.Clear()
            ExceptionMessage.Show(objReferral.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnProfile.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub DBGSales_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGReferral.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReferral.Click
        If DBGReferral.RowCount > 0 Then
            DBGReferral.MarqueeStyle = MarqueeEnum.HighlightRow
            btnProfile.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ReferralNew()
    End Sub

    Private Sub ReferralNew()
        Dim frm As New FormReferralNew
        frm.Show()
        frm.CallerForm = Me
        frm.MdiParent = MDISO
    End Sub

    Private Sub DBGSales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGReferral.DoubleClick
        ReferralProfile()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ReferralProfile()
    End Sub

    Private Sub ReferralProfile()
        With DBGReferral
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objSimpi.Clear()
                objSimpi.Load(.Columns("simpiEmail").Text)
                If objSimpi.ErrID = 0 Then
                    objReferral.Clear()
                    objReferral.Load(objMasterSimpi, .Columns("Code").Text)
                    If objReferral.ErrID = 0 Then
                        Dim frm As New FormReferralProfile
                        frm.Show()
                        frm.objReferral = objReferral
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    Else
                        ExceptionMessage.Show(objReferral.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End With
    End Sub


End Class