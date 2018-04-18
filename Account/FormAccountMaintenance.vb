Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterClient
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString
Imports Microsoft.Office.Interop

Public Class FormAccountMaintenance
    Dim objClient As New MasterClient
    Dim objIndividual As New MasterClientIndividu
    Dim objInstitusi As New MasterClientInstitution
    Dim objDistributor As New MasterClientDistributor

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
                PrintExcel(DBGClient)
        End Select
    End Sub

    Private Sub FormAccountManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterClientType()
        GetParameterClientStatus()
        GetParameterClientRisk()

        objClient.UserAccess = objAccess
        objIndividual.UserAccess = objAccess
        objInstitusi.UserAccess = objAccess
        objDistributor.UserAccess = objAccess
        btnProfile.Enabled = False
        DBGClient.FetchRowStyles = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ClientSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then ClientSearch()
    End Sub

    Public Sub ClientSearch()
        Dim dtClient As New DataTable
        objClient.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtClient = objClient.Search(objMasterSimpi, strKeyword, 0, 0, 0, 0)
        If objClient.ErrID = 0 Then
            Dim query = From p In dtClient.AsEnumerable
                        Join c In dtParameterClientType.AsEnumerable On
                               p.Field(Of Integer)("TypeID") Equals c.Field(Of Integer)("TypeID")
                        Join s In dtParameterClientStatus.AsEnumerable On
                               p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Join a In dtParameterClientRisk.AsEnumerable On
                               p.Field(Of Integer)("RiskID") Equals a.Field(Of Integer)("RiskID")
                        Select
                             ID = p.Field(Of Integer)("ClientID"),
                             Sales = p.Field(Of String)("SalesCode") & " " & p.Field(Of String)("SalesName"),
                             Code = p.Field(Of String)("ClientCode"),
                             Name = p.Field(Of String)("ClientName"),
                             Type = c.Field(Of String)("TypeCode"),
                             Risk = a.Field(Of String)("RiskCode"),
                             Status = s.Field(Of String)("StatusCode")

            With DBGClient
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGClient.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGClient.Columns.Clear()
            ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DBGClient_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGClient.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGClient.Click
        With DBGClient
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfile.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGClient_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGClient.DoubleClick
        ClientProfile()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ClientProfile()
    End Sub

    Private Sub btnAddDistributor_Click(sender As Object, e As EventArgs) Handles btnAddDistributor.Click
        Dim frm As New FormAccountDistributorNew
        frm.CallerForm = Me
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddIndividual_Click(sender As Object, e As EventArgs) Handles btnAddIndividual.Click
        Dim frm As New FormAccountIndividualNew
        frm.CallerForm = Me
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddInstitutional_Click(sender As Object, e As EventArgs) Handles btnAddInstitutional.Click
        Dim frm As New FormAccountInstitutionalNew
        frm.CallerForm = Me
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub ClientProfile()
        With DBGClient
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objClient.Clear()
                objClient.Load(objMasterSimpi, .Columns("Code").Text)
                If objClient.ErrID = 0 Then
                    If objClient.IsIndividu Then
                        objIndividual.Clear()
                        objIndividual.Load(objMasterSimpi, .Columns("Code").Text)
                        If objIndividual.ErrID <> 0 Then ExceptionMessage.Show(objIndividual.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dim frm As New FormAccountIndividualProfile
                        frm.Show()
                        frm.objClient = objIndividual
                        frm.ClientLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objClient.IsInstitution Then
                        objInstitusi.Clear()
                        objInstitusi.Load(objMasterSimpi, .Columns("Code").Text)
                        If objInstitusi.ErrID <> 0 Then ExceptionMessage.Show(objInstitusi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dim frm As New FormAccountInstitutionalProfile
                        frm.Show()
                        frm.objClient = objInstitusi
                        frm.ClientLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objClient.IsDistributor Then
                        objDistributor.Clear()
                        objDistributor.Load(objMasterSimpi, .Columns("Code").Text)
                        If objDistributor.ErrID <> 0 Then ExceptionMessage.Show(objDistributor.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dim frm As New FormAccountDistributorProfile
                        frm.Show()
                        frm.objClient = objDistributor
                        frm.ClientLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objClient.IsIndividuSubAccount Then
                        ExceptionMessage.Show(objError.Message(109), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf objClient.IsInstitutionSubAccount Then
                        ExceptionMessage.Show(objError.Message(110), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf objClient.IsIndividuNominee Or objClient.IsInstitutionNominee Then
                        ExceptionMessage.Show(objError.Message(111), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf objClient.IsInternal Then
                        ExceptionMessage.Show(objError.Message(112), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExceptionMessage.Show(objClient.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

End Class