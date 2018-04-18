Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSecurities
Imports simpi.MasterSimpi
Imports simpi.CoreData
Imports simpi.GlobalException

Public Class FormEODClosing
    Dim objPortfolio As New simpi.MasterPortfolio.MasterPortfolio
    Dim objNAV As New PortfolioNAV
    Dim objMTM As New PortfolioMTM
    Dim objSimpi As New MasterSimpi

    Private Sub FormGenerateNAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPortfolio.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        GetParameterCountry("")
        GetComboInit(New ParameterCountry, cmbCcy, "CountryID", "Ccy", True)
        cmbCcy.SelectedIndex = 0
        DBGPortfolio.FetchRowStyles = True
        btnProfile.Enabled = False
    End Sub

    Private Sub cmbCcy_ChangeCommitted(sender As Object, e As EventArgs) Handles cmbCcy.ChangeCommitted
        CcySelected()
    End Sub

    Private Sub CcySelected()
        If cmbCcy.SelectedValue > 0 Then dtValuation.Value = objAccess.GetUserDate(cmbCcy.SelectedValue) Else dtValuation.Value = objAccess.GetUserDate()
        dtNext.Value = dtValuation.Value.AddDays(1)
        DBGPortfolio.Columns.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        MTMLoad()
    End Sub

    Public Sub MTMLoad()
        Dim dtPortfolio As New DataTable
        Dim dtNAV As New DataTable
        Dim dtMTM As New DataTable
        Dim CcyID As Integer
        If cmbCcy.SelectedValue > 0 Then CcyID = cmbCcy.SelectedValue Else CcyID = 0
        objPortfolio.Clear()
        dtPortfolio = objPortfolio.Search(txtKeyword.Text.Trim, 1, 0, 0, 0, CcyID)
        If objPortfolio.ErrID = 0 Then
            If dtPortfolio.Rows.Count > 0 Then
                objNAV.Clear()
                objMTM.Clear()
                dtNAV = objNAV.Search(dtValuation.Value, txtKeyword.Text.Trim, 1, 0, 0, 0, CcyID)
                dtMTM = objMTM.Search(dtValuation.Value, txtKeyword.Text.Trim, 1, 0, 0, 0, CcyID)
                Dim query = From p In dtPortfolio.AsEnumerable Join c In dtCountry.AsEnumerable
                                 On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                            Group Join n In dtNAV.AsEnumerable
                                On p.Field(Of Integer)("PortfolioID") Equals n.Field(Of Integer)("PortfolioID")
                                Into pn = Group Let n = pn.FirstOrDefault
                            Select
                                ID = p.Field(Of Integer)("PortfolioID"),
                                simpiEmail = p.Field(Of String)("simpiEmail"),
                                simpi = p.Field(Of String)("simpiName"),
                                Code = p.Field(Of String)("PortfolioCode"),
                                Name = p.Field(Of String)("PortfolioNameShort"),
                                Ccy = c.Field(Of String)("Ccy"),
                                Inception = p.Field(Of Date)("InceptionDate"),
                                NAV = If(n Is Nothing, "", n?.Field(Of Decimal?)("NAV")),
                                Price = If(n Is Nothing, "", n?.Field(Of Decimal?)("NAVperUnit"))
                Dim query2 = From q In query Group Join m In dtMTM.AsEnumerable
                                  On q.ID Equals m.Field(Of Integer)("PortfolioID")
                                  Into qm = Group Let m = qm.FirstOrDefault
                             Select ID = q.ID, simpiEmail = q.simpiEmail, simpi = q.simpi, Code = q.Code,
                                    Name = q.Name, Ccy = q.Ccy, Inception = q.Inception, NAV = q.NAV,
                                    Price = q.Price, MTM = If(m Is Nothing, "", m?.Field(Of Date?)("NextDate"))

                With DBGPortfolio
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query2.ToList

                    .Columns("Inception").NumberFormat = "dd-MMM-yyyy"
                    .Columns("MTM").NumberFormat = "dd-MMM-yyyy"
                    .Columns("NAV").NumberFormat = "n2"
                    .Columns("Price").NumberFormat = "n5"

                    .Splits(0).DisplayColumns("Inception").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("MTM").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("NAV").Style.HorizontalAlignment = AlignHorzEnum.Far
                    .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far

                    .Columns("Price").Caption = "NAV/Unit"
                    .Columns("MTM").Caption = "Next"

                    For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                        If column.Name.Trim = "simpiEmail" Then
                            column.Visible = False
                        Else
                            column.AutoSize()
                        End If
                        .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                    Next

                End With

            Else
                DBGPortfolio.Columns.Clear()
            End If
        Else
            ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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
                btnProfile.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGPortfolio_DoubleClick(sender As Object, e As EventArgs) Handles DBGPortfolio.DoubleClick
        ClosingLoad()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ClosingLoad()
    End Sub

    Private Sub ClosingLoad()
        With DBGPortfolio
            If .RowCount > 0 Then
                objSimpi.Clear()
                objSimpi.Load(.Columns("simpiEmail").Text)
                If objSimpi.ErrID <> 0 Then
                    ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                objPortfolio.Clear()
                objPortfolio.LoadCode(objSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objNAV.Clear()
                    objNAV.LoadAt(objPortfolio, dtValuation.Value)
                    If objNAV.ErrID = 0 Then
                        Dim form As New FormEODClosingProfile
                        If IsMdiChild Then form.MdiParent = MDISO
                        form.objPortfolio = objPortfolio
                        form.objNAV = objNAV
                        form.FormLoad()
                        form.CallerForm = Me
                        form.Show()
                    Else
                        ExceptionMessage.Show(objNAV.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

End Class