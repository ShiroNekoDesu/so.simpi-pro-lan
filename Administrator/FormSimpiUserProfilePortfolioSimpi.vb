Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterPortfolio
Imports simpi.SimpiMaster
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString

Public Class FormSimpiUserProfilePortfolioSimpi
    Public objUser As SimpiUser
    Public CallerForm As FormSimpiUserProfile
    Dim objMasterUser As New simpi.MasterSimpi.SimpiUser
    Dim objPortfolio As New MasterPortfolio

    Public Sub PortfolioLoad()
        If objUser.GetUserID > 0 Then
            lblID.Text = objUser.GetMasterSimpi.GetSimpiID
            lblType.Text = objUser.GetMasterSimpi.GetSimpiType.GetTypeCode
            lblStatus.Text = objUser.GetMasterSimpi.GetSimpiStatus.GetStatusCode
            lblName.Text = objUser.GetMasterSimpi.GetSimpiName
            lblIDUser.Text = objUser.GetUserID
            lblLoginUser.Text = objUser.GetUserLogin
            lblStatusUser.Text = objUser.GetUserStatus.GetStatusCode

            objPortfolio.UserAccess = objAccess
            objMasterUser.UserAccess = objAccess
            objMasterUser.Load(objUser.GetUserLogin)

            GetMasterSimpi()
            GetParameterCountry()
            GetParameterPortfolioStatus()
            GetParameterPortfolioAssetType()
            GetParameterPortfolioType()

            btnAdd.Enabled = False
            DBGPortfolio.FetchRowStyles = True
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PortfolioSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            PortfolioSearch()
        End If
    End Sub

    Private Sub PortfolioSearch()
        Dim dtPortfolio As New DataTable
        Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
        dtPortfolio = objUser.Portfolio_SearchAvailable(strKeyword)
        If objUser.ErrID = 0 Then
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
                             Asset = a.Field(Of String)("AssetTypeCode"),
                             Level = l.Field(Of String)("TypeCode"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGPortfolio
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGPortfolio.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            DBGPortfolio.Columns.Clear()
            ExceptionMessage.Show(objUser.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DBGPortfolio_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGPortfolio.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGPortfolio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolio.Click
        With DBGPortfolio
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnAdd.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGPortfolio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGPortfolio.DoubleClick
        portfolioAdd()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        PortfolioAdd()
    End Sub

    Private Sub PortfolioAdd()
        With DBGPortfolio
            If .RowCount > 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objPortfolio.User_Add(objMasterUser, IIf(rbTrade.Checked, 1, IIf(rbDetail.Checked, 2, 3)))
                    If objPortfolio.ErrID = 0 Then
                        CallerForm.PortfolioSimpiSearch()
                        Close()
                    Else
                        ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub


End Class