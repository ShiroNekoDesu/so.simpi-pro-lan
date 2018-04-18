Imports simpi.MasterClient
Imports simpi.ParameterClient
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString
Imports C1.Win.C1FlexGrid
Imports Microsoft.Office.Interop

Public Class FormAccountKYC
    Dim objClient As New MasterClient
    Dim dtKYC As New DataTable
    Dim objClientKYC As New ClientKYC

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
                PrintExcel(fgKYC)
        End Select
    End Sub

    Private Sub FormAccountKYC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterClientStatus()
        GetComboInit(New ParameterClientType, cmbClientType, "TypeID", "TypeCode")
        objClient.UserAccess = objAccess
        objClientKYC.UserAccess = objAccess
        kycInit()
        fgKYC.KeyActionEnter = KeyActionEnum.None
        fgKYC.DrawMode = DrawModeEnum.OwnerDraw
    End Sub

    Private Sub kycInit()
        dtKYC.Columns.Add("ID", GetType(Integer))
        dtKYC.Columns.Add("Sales", GetType(String))
        dtKYC.Columns.Add("Code", GetType(String))
        dtKYC.Columns.Add("Client", GetType(String))
        dtKYC.Columns.Add("Status", GetType(String))
        dtKYC.Columns.Add("KYCData", GetType(String))
    End Sub

    Private Sub btnSearchKYC_Click(sender As Object, e As EventArgs) Handles btnSearchKYC.Click
        FieldSearch()
    End Sub

    Private Sub FieldSearch()
        Dim form As New FormSelectClientKYC
        form.lblCode = lblKYCCode
        form.lblDescription = lblKYCDescription
        form.ClientType = cmbClientType.SelectedValue
        form.lblClientType.Text = cmbClientType.Text
        form.lblID = lblKYCID
        form.Show()
        form.MdiParent = MDISO
        lblKYCID.Text = ""
        lblKYCCode.Text = ""
        lblKYCDescription.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ClientSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then ClientSearch()
    End Sub

    Public Sub ClientSearch()
        If lblKYCID.Text.Trim <> "" Then
            Dim dtClient As New DataTable
            objClient.Clear()
            Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
            dtClient = objClient.Search(objMasterSimpi, strKeyword, cmbClientType.SelectedValue)
            If objClient.ErrID = 0 Then
                Dim tbl As New DataTable
                dtKYC.Clear()
                objClientKYC.Clear()
                tbl = objClientKYC.Search(objMasterSimpi, CInt(lblKYCID.Text), txtKeyword.Text, cmbClientType.SelectedValue)
                Dim query = From p In dtClient.AsEnumerable
                            Join s In dtParameterClientStatus.AsEnumerable On
                                   p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                            Group Join t In tbl.AsEnumerable On p.Field(Of Integer)("ClientID") Equals
                                       t.Field(Of Integer)("ClientID") Into esc = Group Let t = esc.FirstOrDefault
                            Select
                                 ID = p.Field(Of Integer)("ClientID"),
                                 Sales = p.Field(Of String)("SalesCode"),
                                 Code = p.Field(Of String)("ClientCode"),
                                 Name = p.Field(Of String)("ClientName"),
                                 Status = s.Field(Of String)("StatusCode"),
                                 KYCData = If(t Is Nothing, "", t.Field(Of String)("kycAnswer"))

                For Each item In query
                    Dim dr As DataRow = dtKYC.NewRow()
                    dr("ID") = item.ID
                    dr("Sales") = item.Sales
                    dr("Code") = item.Code
                    dr("Client") = item.Name
                    dr("Status") = item.Status
                    dr("KYCData") = item.KYCData
                    dtKYC.Rows.Add(dr)
                Next

                fgKYC.DataSource = dtKYC
                fgKYC.AutoSizeCols()
            Else
                fgKYC.DataSource = Nothing
            End If
        End If

    End Sub

    Private Sub fgKYC_BeforeEdit(sender As Object, e As RowColEventArgs) Handles fgKYC.BeforeEdit
        If e.Col = 0 Or e.Col = 1 Or e.Col = 2 Or e.Col = 3 Or e.Col = 4 Then e.Cancel = True Else e.Cancel = False
    End Sub

    Private Sub fgKYC_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles fgKYC.PreviewKeyDown
        Select Case (e.KeyCode)
            Case Keys.Down, Keys.Up
                e.IsInputKey = True
        End Select
    End Sub

    Private Sub fgKYC_KeyUp(sender As Object, e As KeyEventArgs) Handles fgKYC.KeyUp
        If e.KeyCode = Keys.Enter And fgKYC.Col = 5 Then
            DataSave()
        ElseIf e.KeyCode = Keys.Delete And
            Not (fgKYC.Col = 0 Or fgKYC.Col = 1 Or fgKYC.Col = 2 Or fgKYC.Col = 3 Or fgKYC.Col = 4) Then
            fgKYC(fgKYC.Row, fgKYC.Col) = ""
        End If
    End Sub

    Private Sub fgKYC_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles fgKYC.OwnerDrawCell
        Dim s As CellStyle = fgKYC.Styles.Add("RowStyle")
        s.BackColor = Color.LemonChiffon
        If e.Row > 0 And e.Row Mod 2 = 0 Then fgKYC.Rows(e.Row).Style = fgKYC.Styles("RowStyle")
    End Sub

    Private Sub DataSave()
        If lblKYCID.Text.Trim <> "" And fgKYC.Row > 0 Then
            objClient.Clear()
            objClient.Load(objMasterSimpi, fgKYC(fgKYC.Row, 2))
            If objClient.ErrID = 0 Then
                objClientKYC.Clear()
                If fgKYC(fgKYC.Row, 5).ToString.Trim <> "" Then
                    objClientKYC.Add(objClient, lblKYCID.Text, fgKYC(fgKYC.Row, 5))
                    If objClientKYC.ErrID = 0 Then ClientSearch() Else ExceptionMessage.Show(objClientKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    objClientKYC.Remove(objClient, lblKYCID.Text)
                    If objClientKYC.ErrID = 0 Then ClientSearch() Else ExceptionMessage.Show(objClientKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class