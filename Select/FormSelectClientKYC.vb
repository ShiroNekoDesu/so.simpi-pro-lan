Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.SimpiMaster
Imports simpi.globalutilities.GlobalString

Public Class FormSelectClientKYC
    Public lblID As C1.Win.C1InputPanel.InputLabel
    Public lblCode As C1.Win.C1InputPanel.InputLabel
    Public lblDescription As C1.Win.C1InputPanel.InputLabel
    Public ClientType As Integer
    Dim objKYC As New SimpiKYC

    Private Sub FormMarketSecurities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objKYC.UserAccess = objAccess
        btnSelect.Enabled = False
        DBGKYC.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        KYCSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            KYCSearch()
        End If
    End Sub

    Public Sub KYCSearch()
        Dim tbl As New DataTable
        objKYC.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        tbl = objKYC.SearchApply(ClientType, strKeyword)
        If objKYC.ErrID = 0 Then
            With tbl
                .Columns("kycID").ColumnName = "ID"
                .Columns("kycCode").ColumnName = "Field"
                .Columns("kycDescription").ColumnName = "Description"
            End With

            With DBGKYC
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = tbl

                For Each column As C1DisplayColumn In DBGKYC.Splits(0).DisplayColumns
                    column.AutoSize()
                Next
            End With
        Else
            ExceptionMessage.Show(objKYC.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGKYC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGKYC.Click
        With DBGKYC
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnSelect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGKYC_DoubleClick(sender As Object, e As EventArgs) Handles DBGKYC.DoubleClick
        KYCSelect()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        KYCSelect()
    End Sub

    Private Sub KYCSelect()
        With DBGKYC
            If .RowCount > 0 Then
                lblID.Text = .Columns("ID").Text
                lblCode.Text = .Columns("Field").Text
                lblDescription.Text = .Columns("Description").Text
            End If
        End With
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DBGInstrument_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGKYC.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

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