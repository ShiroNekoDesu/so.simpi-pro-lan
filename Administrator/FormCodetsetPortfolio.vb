Imports simpi.globalutilities
Imports simpi.Codeset
Imports simpi.MasterPortfolio
Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities.GlobalString
Imports Microsoft.Office.Interop

Public Class FormCodetsetPortfolio
    Dim objCodeset As New CodesetPortfolioField
    Dim objPortfolioCodeset As New PortfolioCodeset
    Dim objPortfolio As New MasterPortfolio

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
                PrintExcel(DBGCodeset)
        End Select
    End Sub

    Private Sub FormCodetsetPortfolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        objCodeset.UserAccess = objAccess
        objPortfolioCodeset.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        DBGCodeset.FetchRowStyles = True
    End Sub

    Private Sub btnSearchCodeset_Click(sender As Object, e As EventArgs) Handles btnSearchCodeset.Click
        CodeSearch()
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CodeSearch()
        End If
    End Sub

    Private Sub CodeSearch()
        Dim form As New FormSelectCodesetPortfolio
        form.lblCode = lblCodeset
        form.lblDescription = lblDescription
        form.Show()
        form.MdiParent = MDISO
        lblCodeset.Text = ""
        lblDescription.Text = ""
        objCodeset.Clear()
    End Sub

    Private Sub CodeLoad()
        If lblCodeset.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.LoadCode(lblCodeset.Text)
            If objCodeset.ErrID = 0 Then lblDescription.Text = objCodeset.GetFieldDescription
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CodesetLoad()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            CodesetLoad()
        End If
    End Sub

    Private Sub CodesetLoad()
        Dim dtPortfolio As New DataTable
        objPortfolio.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtPortfolio = objPortfolio.Search(objMasterSimpi, strKeyword, 0, 0, 0, 0, 0)
        If objPortfolio.ErrID = 0 Then
            Dim dtCodeset As New DataTable
            objCodeset.Clear()
            objCodeset.LoadCode(lblCodeset.Text)
            If objCodeset.ErrID <> 0 Then
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            objPortfolioCodeset.Clear()
            dtCodeset = objPortfolioCodeset.Search(objMasterSimpi, objCodeset.GetFieldID, txtKeyword.Text)
            Dim query = From p In dtPortfolio.AsEnumerable
                        Group Join c In dtCodeset.AsEnumerable On c.Field(Of Integer)("PortfolioID") Equals
                                   p.Field(Of Integer)("PortfolioID") Into pc = Group
                        Let c = pc.FirstOrDefault
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             Data = If(c Is Nothing, Nothing, c.Field(Of String)("FieldData"))

            With DBGCodeset
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGCodeset.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGCodeset.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CodesetClear()
    End Sub

    Private Sub DBGCodeset_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGCodeset.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub CodesetClear()
        btnCodesetAdd.Enabled = False
        btnCodesetRemove.Enabled = False
        lblCode.Text = ""
        lblName.Text = ""
        txtCodesetData.Text = ""
    End Sub

    Private Sub DBGCodeset_Click(sender As Object, e As EventArgs) Handles DBGCodeset.Click
        If DBGCodeset.RowCount > 0 Then DBGCodeset.MarqueeStyle = MarqueeEnum.HighlightRow
    End Sub

    Private Sub DBGCodeset_DoubleClick(sender As Object, e As EventArgs) Handles DBGCodeset.DoubleClick
        CodesetSelect()
    End Sub

    Private Sub CodesetSelect()
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                lblCode.Text = .Columns("Code").Text
                lblName.Text = .Columns("Name").Text
                txtCodesetData.Text = .Columns("Data").Text
                If txtCodesetData.Text.Trim <> "" Then
                    btnCodesetRemove.Enabled = True
                    btnCodesetAdd.Enabled = False
                Else
                    btnCodesetAdd.Enabled = True
                    btnCodesetRemove.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub btnCodesetAdd_Click(sender As Object, e As EventArgs) Handles btnCodesetAdd.Click
        CodesetAdd()
    End Sub

    Private Sub CodesetAdd()
        If lblCode.Text.Trim <> "" And objCodeset.GetFieldID > 0 Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblCode.Text)
            If objPortfolio.ErrID = 0 Then
                objPortfolioCodeset.Add(objPortfolio, objCodeset.GetFieldID, txtCodesetData.Text)
                If objPortfolioCodeset.ErrID = 0 Then
                    CodesetLoad()
                Else
                    ExceptionMessage.Show(objPortfolioCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCodesetRemove_Click(sender As Object, e As EventArgs) Handles btnCodesetRemove.Click
        CodesetRemove()
    End Sub

    Private Sub CodesetRemove()
        If lblCode.Text.Trim <> "" And objCodeset.GetFieldID > 0 Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblCode.Text)
            If objPortfolio.ErrID = 0 Then
                objPortfolioCodeset.Remove(objPortfolio, objCodeset.GetFieldID)
                If objPortfolioCodeset.ErrID = 0 Then
                    CodesetLoad()
                Else
                    ExceptionMessage.Show(objPortfolioCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


End Class