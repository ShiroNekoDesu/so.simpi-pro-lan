Imports simpi.MasterSales
Imports simpi.globalutilities
Imports C1.Win.C1FlexGrid
Imports Microsoft.Office.Interop

Public Class FormSalesCodeset
    Dim objSales As New MasterSales
    Dim dtKYC As New DataTable
    Dim objSalesCodeset As New SalesCodeset

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
                PrintExcel(fgCodeset)
        End Select
    End Sub

    Private Sub FormAccountKYC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        objSales.UserAccess = objAccess
        objSalesCodeset.UserAccess = objAccess
        kycInit()
        fgCodeset.KeyActionEnter = KeyActionEnum.None
        fgCodeset.DrawMode = DrawModeEnum.OwnerDraw
    End Sub

    Private Sub kycInit()
        dtKYC.Columns.Add("ID", GetType(Integer))
        dtKYC.Columns.Add("Sales", GetType(String))
        dtKYC.Columns.Add("Name", GetType(String))
        dtKYC.Columns.Add("FieldData", GetType(String))
    End Sub

    Private Sub btnSearchKYC_Click(sender As Object, e As EventArgs) Handles btnSearchField.Click
        FieldSearch()
    End Sub

    Private Sub FieldSearch()
        Dim form As New FormSelectCodesetSales
        form.lblCode = lblCode
        form.lblDescription = lblDescription
        form.lblID = lblID
        form.Show()
        form.MdiParent = MDISO
        lblID.Text = ""
        lblCode.Text = ""
        lblDescription.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ClientSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then ClientSearch()
    End Sub

    Public Sub ClientSearch()
        If lblID.Text.Trim <> "" Then
            Dim dtClient As New DataTable
            objSales.Clear()
            dtClient = objSales.SearchAll(objMasterSimpi, txtKeyword.Text)
            If objSales.ErrID = 0 Then
                Dim tbl As New DataTable
                dtKYC.Clear()
                objSalesCodeset.Clear()
                tbl = objSalesCodeset.Search(objMasterSimpi, lblID.Text, txtKeyword.Text)
                Dim query = From p In dtClient.AsEnumerable
                            Group Join t In tbl.AsEnumerable On p.Field(Of Integer)("SalesID") Equals
                                       t.Field(Of Integer)("SalesID") Into esc = Group Let t = esc.FirstOrDefault
                            Select
                                 ID = p.Field(Of Integer)("SalesID"),
                                 Sales = p.Field(Of String)("SalesCode"),
                                 Name = p.Field(Of String)("UserName"),
                                 FieldData = If(t Is Nothing, "", t.Field(Of String)("FieldData"))

                For Each item In query
                    Dim dr As DataRow = dtKYC.NewRow()
                    dr("ID") = item.ID
                    dr("Sales") = item.Sales
                    dr("Name") = item.Name
                    dr("FieldData") = item.FieldData
                    dtKYC.Rows.Add(dr)
                Next

                fgCodeset.DataSource = dtKYC
                fgCodeset.AutoSizeCols()
            Else
                fgCodeset.DataSource = Nothing
            End If
        End If

    End Sub

    Private Sub fgCodeset_BeforeEdit(sender As Object, e As RowColEventArgs) Handles fgCodeset.BeforeEdit
        If e.Col = 0 Or e.Col = 1 Or e.Col = 2 Then e.Cancel = True Else e.Cancel = False
    End Sub

    Private Sub fgCodeset_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles fgCodeset.PreviewKeyDown
        Select Case (e.KeyCode)
            Case Keys.Down, Keys.Up
                e.IsInputKey = True
        End Select
    End Sub

    Private Sub fgCodeset_KeyUp(sender As Object, e As KeyEventArgs) Handles fgCodeset.KeyUp
        If e.KeyCode = Keys.Enter And fgCodeset.Col = 3 Then
            DataSave()
        ElseIf e.KeyCode = Keys.Delete And Not (fgCodeset.Col = 0 Or fgCodeset.Col = 1 Or fgCodeset.Col = 2) Then
            fgCodeset(fgCodeset.Row, fgCodeset.Col) = ""
        End If
    End Sub

    Private Sub fgKYC_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgCodeset.OwnerDrawCell
        Dim s As CellStyle
        s = fgCodeset.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgCodeset.Rows(e.Row).Style = fgCodeset.Styles("RowStyle")
    End Sub

    Private Sub DataSave()
        If lblID.Text.Trim <> "" Then
            objSales.Clear()
            objSales.Load(objMasterSimpi, fgCodeset(fgCodeset.Row, 1))
            If objSales.ErrID = 0 Then
                If fgCodeset(fgCodeset.Row, 3).ToString.Trim <> "" Then
                    objSalesCodeset.Clear()
                    objSalesCodeset.Add(objSales, lblID.Text, fgCodeset(fgCodeset.Row, 3))
                    If objSalesCodeset.ErrID = 0 Then ClientSearch() Else ExceptionMessage.Show(objSalesCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    objSalesCodeset.Clear()
                    objSalesCodeset.Remove(objSales, lblID.Text)
                    If objSalesCodeset.ErrID = 0 Then ClientSearch() Else ExceptionMessage.Show(objSalesCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub



End Class