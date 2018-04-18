Imports simpi.globalutilities
Imports simpi.SimpiMaster
Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities.GlobalString

Public Class FormCodesetSimpi
    Dim objCodeset As New SimpiCodeset
    Dim FieldID As Integer = 0

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

    Private Sub FormCodesetSimpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSimpiCodesetField()
        objCodeset.UserAccess = objAccess
        DBGCodeset.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CodesetLoad()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then CodesetLoad()
    End Sub

    Private Sub CodesetLoad()
        Dim dtField As New DataTable
        objCodeset.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtField = objCodeset.Search(strKeyword)
        If dtSimpiCodeset IsNot Nothing AndAlso dtSimpiCodeset.Rows.Count > 0 Then
            Dim query = From c In dtSimpiCodeset.AsEnumerable
                        Group Join f In dtField.AsEnumerable On c.Field(Of Integer)("FieldID") Equals
                            f.Field(Of Integer)("FieldID") Into cf = Group
                        Let f = cf.FirstOrDefault
                        Select
                                ID = c.Field(Of Integer)("FieldID"),
                                Field = c.Field(Of String)("FieldCode"),
                                Data = If(f Is Nothing, Nothing, f.Field(Of String)("FieldData"))

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
        End If
        CodesetClear()
    End Sub

    Private Sub DBGCodeset_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGCodeset.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub CodesetClear()
        btnCodesetAdd.Enabled = False
        btnCodesetRemove.Enabled = False
        txtCodesetField.Text = ""
        txtCodesetData.Text = ""
        FieldID = 0
    End Sub

    Private Sub DBGCodeset_Click(sender As Object, e As EventArgs) Handles DBGCodeset.Click
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGCodeset_DoubleClick(sender As Object, e As EventArgs) Handles DBGCodeset.DoubleClick
        CodesetSelect()
    End Sub

    Private Sub CodesetSelect()
        With DBGCodeset
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                FieldID = .Columns("ID").Text
                txtCodesetField.Text = .Columns("Field").Text
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
        If txtCodesetField.Text.Trim <> "" And txtCodesetData.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.Add(FieldID, txtCodesetData.Text)
            If objCodeset.ErrID = 0 Then
                CodesetLoad()
            Else
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCodesetRemove_Click(sender As Object, e As EventArgs) Handles btnCodesetRemove.Click
        CodesetRemove()
    End Sub

    Private Sub CodesetRemove()
        If txtCodesetField.Text.Trim <> "" Then
            objCodeset.Clear()
            objCodeset.Remove(txtCodesetField.Text)
            If objCodeset.ErrID = 0 Then
                CodesetLoad()
            Else
                ExceptionMessage.Show(objCodeset.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class