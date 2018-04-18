Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.MasterPortfolio
Imports simpi.MasterSimpi
Imports simpi.globalutilities.GlobalString
Imports Microsoft.Office.Interop

Public Class FormMasterPortfolio
    Dim objPortfolio As New MasterPortfolio
    Dim objSharingSimpi As New MasterSimpi

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
            Case "Export Portfolio"
                PrintExcel(DBGPortfolio)
            Case "Export Sharing"
                PrintExcel(DBGPortfolioSharing)
        End Select
    End Sub

    Private Sub FormMasterPortfolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetParameterCountry()
        GetParameterPortfolioStatus()
        GetParameterPortfolioAssetType()
        GetParameterPortfolioType()

        objPortfolio.UserAccess = objAccess
        objSharingSimpi.UserAccess = objAccess

        DBGPortfolio.FetchRowStyles = True
        DBGPortfolioSharing.FetchRowStyles = True
    End Sub

#Region "simpi"
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PortfolioSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            PortfolioSearch()
        End If
    End Sub

    Public Sub PortfolioSearch()
        Dim dtPortfolio As New DataTable
        objPortfolio.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone1.Checked, rbNone1.Text, IIf(rbAnd1.Checked, rbAnd1.Text, IIf(rbOr1.Checked, rbOr1.Text, rbCombine1.Text))))
        dtPortfolio = objPortfolio.Search(objMasterSimpi, strKeyword)
        If objPortfolio.ErrID = 0 Then
            Dim query = From p In dtPortfolio.AsEnumerable
                        Join c In dtParameterCountry.AsEnumerable On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                        Join s In dtParameterPortfolioStatus.AsEnumerable On p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Join a In dtParameterPortfolioAsset.AsEnumerable On p.Field(Of Integer)("AssetTypeID") Equals a.Field(Of Integer)("AssetTypeID")
                        Join l In dtParameterPortfolioType.AsEnumerable On p.Field(Of Integer)("TypeID") Equals l.Field(Of Integer)("TypeID")
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             Ccy = c.Field(Of String)("Ccy"),
                             Inception = p.Field(Of Date)("InceptionDate"),
                             Type = l.Field(Of String)("TypeCode"),
                             Asset = a.Field(Of String)("AssetTypeCode"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGPortfolio
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("Inception").NumberFormat = "dd-MMM-yyyy"

                For Each column As C1DisplayColumn In DBGPortfolio.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGPortfolio.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnProfile.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub DBGPortfolio_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGPortfolio.FetchRowStyle
        If e.Row Mod 2 = 0 Then e.CellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub DBGPortfolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolio.Click
        With DBGPortfolio
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfile.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGPortfolio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolio.DoubleClick
        PortfolioProfile()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        PortfolioNew()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        PortfolioProfile()
    End Sub

    Private Sub PortfolioProfile()
        With DBGPortfolio
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    If objPortfolio.IsPortfolio Then
                        Dim frm As New FormMasterPortfolioProfile
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsBenchmarkFund Then
                        Dim frm As New FormMasterPortfolioBenchmark
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsFundOnFund Then
                        Dim frm As New FormMasterPortfolioFund
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsIndexFund Then
                        Dim frm As New FormMasterPortfolioIndex
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsModelFund Then
                        Dim frm As New FormMasterPortfolioModel
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsMultiCurrencyFund Then
                        Dim frm As New FormMasterPortfolioMulti
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsSimulationFund Then
                        Dim frm As New FormMasterPortfolioSimulation
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsSubPortfolio Then
                        Dim frm As New FormMasterPortfolioSub
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    ElseIf objPortfolio.IsUmbrellaFund Then
                        Dim frm As New FormMasterPortfolioUmbrella
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub PortfolioNew()
        Dim frm As New FormMasterPortfolioNew
        frm.Show()
        frm.CallerForm = Me
        frm.MdiParent = MDISO
    End Sub

#End Region

#Region "sharing"
    Private Sub btnSearchSharing_Click(sender As Object, e As EventArgs) Handles btnSearchSharing.Click
        PortfolioSearchSharing()
    End Sub

    Private Sub txtKeywordSharing_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeywordSharing.KeyDown
        If e.KeyCode = Keys.Enter Then
            PortfolioSearchSharing()
        End If
    End Sub

    Public Sub PortfolioSearchSharing()
        Dim dtPortfolio As New DataTable
        objPortfolio.Clear()
        Dim strKeyword As String = SQLKeyword(txtKeywordSharing.Text, IIf(rbNone2.Checked, rbNone2.Text, IIf(rbAnd2.Checked, rbAnd2.Text, IIf(rbOr2.Checked, rbOr2.Text, rbCombine2.Text))))
        dtPortfolio = objPortfolio.SearchSharing(objMasterSimpi, strKeyword)
        If objPortfolio.ErrID = 0 Then
            Dim query = From p In dtPortfolio.AsEnumerable
                        Join c In dtParameterCountry.AsEnumerable On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                        Join s In dtParameterPortfolioStatus.AsEnumerable On p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Join a In dtParameterPortfolioAsset.AsEnumerable On p.Field(Of Integer)("AssetTypeID") Equals a.Field(Of Integer)("AssetTypeID")
                        Join l In dtParameterPortfolioType.AsEnumerable On p.Field(Of Integer)("TypeID") Equals l.Field(Of Integer)("TypeID")
                        Select
                             ID = p.Field(Of Integer)("PortfolioID"),
                             simpi = p.Field(Of String)("simpiName"),
                             simpiEmail = p.Field(Of String)("simpiEmail"),
                             Code = p.Field(Of String)("PortfolioCode"),
                             Name = p.Field(Of String)("PortfolioNameshort"),
                             Ccy = c.Field(Of String)("Ccy"),
                             Type = l.Field(Of String)("TypeCode"),
                             Asset = a.Field(Of String)("AssetTypeCode"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGPortfolioSharing
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGPortfolioSharing.Splits(0).DisplayColumns
                    If column.Name.Trim = "simpiEmail" Then
                        column.Visible = False
                    Else
                        column.AutoSize()
                    End If
                Next

            End With
        Else
            DBGPortfolioSharing.Columns.Clear()
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnProfileSharing.Enabled = False
    End Sub

    Private Sub DBGPortfolioSharing_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGPortfolioSharing.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGPortfolioSharing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolioSharing.Click
        With DBGPortfolioSharing
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfileSharing.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGPortfolioSharing_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolioSharing.DoubleClick
        PortfolioSharingProfile()
    End Sub

    Private Sub btnProfileSharing_Click(sender As Object, e As EventArgs) Handles btnProfileSharing.Click
        PortfolioSharingProfile()
    End Sub

    Private Sub PortfolioSharingProfile()
        With DBGPortfolioSharing
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objSharingSimpi.Clear()
                objSharingSimpi.Load(.Columns("simpiEmail").Text)
                If objSharingSimpi.ErrID = 0 Then
                    objPortfolio.Clear()
                    objPortfolio.LoadCode(objSharingSimpi, .Columns("Code").Text)
                    If objPortfolio.ErrID = 0 Then
                        Dim frm As New FormMasterPortfolioSharing
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.PortfolioLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objSharingSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End With
    End Sub

#End Region


End Class