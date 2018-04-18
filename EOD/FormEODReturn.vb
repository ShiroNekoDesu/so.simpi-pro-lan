Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSecurities
Imports simpi.CoreData
Imports simpi.globalutilities

Public Class FormEODReturn
    Dim objPortfolio As New simpi.MasterPortfolio.MasterPortfolio
    Dim objMTM As New PortfolioMTM
    Dim objNAV As New PortfolioNAV
    Dim objReturn As New PortfolioReturn
    Dim PortfolioID As Integer()

    Private Sub FormEODReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPortfolio.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        objReturn.UserAccess = objAccess
        GetComboInitAll(New ParameterCountry, cmbCcy, "CountryID", "Ccy")
        cmbCcy.Text = "IDR"
        DBGPortfolio.FetchRowStyles = True
        btnProfile.Enabled = False

        GetMasterSimpi()
        GetParameterCountry()
    End Sub

    Private Sub cmbCcy_ChangeCommitted(sender As Object, e As EventArgs) Handles cmbCcy.ChangeCommitted
        CcySelected()
    End Sub

    Private Sub CcySelected()
        If cmbCcy.SelectedValue > 0 Then 
            dtValuation.Value = objAccess.GetUserDate(cmbCcy.SelectedValue)
        Else
            dtValuation.Value = objAccess.GetUserDate()
        End If
        dtNext.Value = dtValuation.Value.AddDays(1)
        DBGPortfolio.Columns.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ReturnLoad()
    End Sub

    Public Sub ReturnLoad()
        Dim dtPortfolio As New DataTable
        Dim dtNAV As New DataTable
        Dim dtMTM As New DataTable
        Dim dtReturn As New DataTable
        Dim CcyID As Integer
        If cmbCcy.SelectedValue > 0 Then CcyID = cmbCcy.SelectedValue Else CcyID = 0
        objPortfolio.Clear()
        dtPortfolio = objPortfolio.Search(txtKeyword.Text.Trim, 0, 0, 0, 0, CcyID)
        If objPortfolio.ErrID = 0 Then
            If dtPortfolio.Rows.Count > 0 Then
                objNAV.Clear()
                objMTM.Clear()
                objReturn.Clear()
                PortfolioID = (From t In dtPortfolio.AsEnumerable Select PortfolioID = t.Field(Of Integer)("PortfolioID")).ToArray
                dtNAV = objNAV.Search(PortfolioID, dtValuation.Value)
                dtMTM = objMTM.Search(PortfolioID, dtValuation.Value)
                dtReturn = objReturn.Search(PortfolioID, dtValuation.Value)
                Dim query = From p In dtPortfolio.AsEnumerable Join c In dtParameterCountry.AsEnumerable
                                 On p.Field(Of Integer)("CcyID") Equals c.Field(Of Integer)("CountryID")
                            Group Join n In dtNAV.AsEnumerable
                                On p.Field(Of Integer)("PortfolioID") Equals n.Field(Of Integer)("PortfolioID")
                                Into pn = Group Let n = pn.FirstOrDefault
                            Select
                                ID = p.Field(Of Integer)("PortfolioID"),
                                Code = p.Field(Of String)("PortfolioCode"),
                                Name = p.Field(Of String)("PortfolioNameShort"),
                                Ccy = c.Field(Of String)("Ccy"),
                                Inception = p.Field(Of Date)("InceptionDate"),
                                NAV = If(n Is Nothing, "", n.Field(Of Decimal)("NAV")),
                                Price = If(n Is Nothing, "", n.Field(Of Decimal)("NAVperUnit"))

                Dim query2 = From q In query Group Join m In dtMTM.AsEnumerable
                                  On q.ID Equals m.Field(Of Integer)("PortfolioID")
                                  Into qm = Group Let m = qm.FirstOrDefault
                             Select ID = q.ID, Code = q.Code,
                                    Name = q.Name, Ccy = q.Ccy, Inception = q.Inception, NAV = q.NAV,
                                    Price = q.Price, MTM = If(m Is Nothing, "", m.Field(Of Date)("PositionDate"))

                Dim query3 = From q In query2 Group Join r In dtReturn.AsEnumerable
                                  On q.ID Equals r.Field(Of Integer)("PortfolioID")
                                  Into qr = Group Let r = qr.FirstOrDefault
                             Select ID = q.ID, Code = q.Code,
                                    Name = q.Name, Ccy = q.Ccy, Inception = q.Inception, NAV = q.NAV, Price = q.Price,
                                    MTM = q.MTM, rDate = If(r Is Nothing, "", r.Field(Of Date)("PositionDate"))

                With DBGPortfolio
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query3.ToList

                    .Columns("Inception").NumberFormat = "dd-MMM-yyyy"
                    .Columns("MTM").NumberFormat = "dd-MMM-yyyy"
                    .Columns("rDate").NumberFormat = "dd-MMM-yyyy"
                    .Columns("NAV").NumberFormat = "n2"
                    .Columns("Price").NumberFormat = "n5"

                    .Splits(0).DisplayColumns("Inception").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("Ccy").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("MTM").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("NAV").Style.HorizontalAlignment = AlignHorzEnum.Far
                    .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far

                    .Columns("Price").Caption = "NAV/Unit"
                    .Columns("MTM").Caption = "MTM"
                    .Columns("rDate").Caption = "Return"

                    For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                        column.AutoSize()
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
        NAVLoad()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        NAVLoad()
    End Sub

    Private Sub NAVLoad()
        With DBGPortfolio
            If .RowCount > 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    objNAV.Clear()
                    objNAV.LoadAt(objPortfolio, dtValuation.Value)
                    If objNAV.ErrID = 0 Then
                        Dim form As New FormEODReturnProfile
                        If IsMdiChild Then
                            form.MdiParent = MDISO
                        End If
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