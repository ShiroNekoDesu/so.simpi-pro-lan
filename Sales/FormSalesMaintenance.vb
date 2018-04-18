Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.MasterSales
Imports simpi.MasterSimpi

Public Class FormSalesMaintenance
    Dim objSales As New MasterSales
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
                PrintExcel(DBGSales)
        End Select
    End Sub

    Private Sub FormSalesMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterClientStatus()
        objSales.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        DBGSales.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SalesSearch
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            SalesSearch()
        End If
    End Sub

    Public Sub SalesSearch()
        Dim tbl As New DataTable
        objSales.Clear()
        tbl = objSales.SearchAll(objMasterSimpi, txtKeyword.Text)
        If objSales.ErrID = 0 Then
            Dim query = From p In tbl.AsEnumerable
                        Join s In dtParameterClientStatus.AsEnumerable On
                                  p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Select
                             ID = p.Field(Of Integer)("SalesID"),
                             Code = p.Field(Of String)("SalesCode"),
                             Name = p.Field(Of String)("UserName"),
                             simpi = p.Field(Of String)("simpiName"),
                             simpiEmail = p.Field(Of String)("simpiEmail"),
                             Head = p.Field(Of String)("TreeParentCode"),
                             License = p.Field(Of String)("LicenseNo"),
                             Expired = p.Field(Of Date)("LicenseExpired"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGSales
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGSales.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then
                        column.Visible = False
                    Else
                        column.AutoSize()
                    End If
                Next

            End With
        Else
            DBGSales.Columns.Clear()
            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnProfile.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub DBGSales_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGSales.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSales.Click
        With DBGSales
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfile.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SalesNew()
    End Sub

    Private Sub SalesNew()
        Dim frm As New FormSalesNew
        frm.Show()
        objSales.Clear()
        frm.objSales = objSales
        frm.SalesLoad()
        frm.CallerForm = Me
        frm.MdiParent = MDISO
    End Sub

    Private Sub DBGSales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGSales.DoubleClick
        SalesProfile()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        SalesProfile()
    End Sub

    Private Sub SalesProfile()
        With DBGSales
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objSimpi.Clear()
                objSimpi.Load(.Columns("simpiEmail").Text)
                If objSimpi.ErrID = 0 Then
                    If objSimpi.IsIFA Then
                        objSales.Clear()
                        objSales.Load(objMasterSimpi, .Columns("Code").Text)
                        If objSales.ErrID = 0 Then
                            Dim frm As New FormSalesProfileIFA
                            frm.Show()
                            frm.objSales = objSales
                            frm.SalesLoad()
                            frm.CallerForm = Me
                            frm.MdiParent = MDISO
                        Else
                            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    ElseIf objSimpi.IsRefferal Then
                        objSales.Clear()
                        objSales.Load(objMasterSimpi, .Columns("Code").Text)
                        If objSales.ErrID = 0 Then
                            Dim frm As New FormSalesProfileReferral
                            frm.Show()
                            frm.objSales = objSales
                            frm.SalesLoad()
                            frm.CallerForm = Me
                            frm.MdiParent = MDISO
                        Else
                            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        objSales.Clear()
                        objSales.Load(objMasterSimpi, .Columns("Code").Text)
                        If objSales.ErrID = 0 Then
                            Dim frm As New FormSalesProfile
                            frm.Show()
                            frm.objSales = objSales
                            frm.SalesLoad()
                            frm.CallerForm = Me
                            frm.MdiParent = MDISO
                        Else
                            ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End With
    End Sub


End Class