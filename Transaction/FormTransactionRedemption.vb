Imports simpi.CoreData
Imports simpi.CoreCapital
Imports simpi.GlobalUtilities
Imports C1.Win.C1TrueDBGrid
Imports simpi.ParameterTA.ParameterTA

Public Class FormTransactionRedemption
    Dim objPortfolio As New simpi.MasterPortfolio.MasterPortfolio
    Dim objNAV As New PortfolioNAV
    Dim objCapital As New ProcessCapital
    Dim objTrx As New TransactionCapital

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
                PrintExcel(DBGRedemption)
        End Select
    End Sub

    Private Sub FormTransactionRedemption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetClientMaster()
        objPortfolio.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objCapital.UserAccess = objAccess
        objTrx.UserAccess = objAccess
        DBGRedemption.FetchRowStyles = True
    End Sub

    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectMasterPortfolioNormal
        form.lblCode = lblPortfolioCode
        form.lblName = lblPortfolioName
        form.lblSimpiEmail = lblSimpiEmail
        form.lblSimpiName = lblSimpiName
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblSimpiEmail.Text = ""
        lblSimpiName.Text = ""
        objPortfolio.Clear()
    End Sub

    Private Sub lblPortfolioName_TextChanged(sender As Object, e As EventArgs) Handles lblPortfolioName.TextChanged
        NAVLoad()
    End Sub

    Private Sub NAVLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblPortfolioCode.Text)
            If objPortfolio.ErrID <> 0 Then
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            objCapital.GetMasterPortfolio = objPortfolio
            lblNAVDate.Text = objCapital.GetDateNAV.ToString("dd-MMM-yyyy")
            lblPrice.Text = objCapital.GetUnitPrice.ToString("n4")
            lblTransactionDate.Text = objCapital.GetDateTransaction.ToString("dd-MMM-yyyy")
            objNAV.LoadAt(objPortfolio, objCapital.GetDateTransaction)
            If objNAV.ErrID = 0 Then
                lblNAV.Text = objNAV.GetNAV.ToString("n2")
                lblTotalUnits.Text = objNAV.GetTotalUnit.ToString("n2")
            Else
                lblNAV.Text = "0.00"
                lblTotalUnits.Text = "0.0000"
            End If
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RedemptionSearch()
    End Sub

    Public Sub RedemptionSearch()
        If objPortfolio.GetPortfolioID > 0 Then
            Dim tbl As New DataTable
            objTrx.Clear()
            tbl = objTrx.Search(objPortfolio, dtFrom.Value, dtTo.Value)
            If objCapital.ErrID = 0 Then
                Dim query = From p In tbl.AsEnumerable Join c In dtClientMaster.AsEnumerable
                                   On p.Field(Of Integer)("ClientID") Equals c.Field(Of Integer)("ClientID")
                            Where p.Field(Of Integer)("TrxType1") = SetRedemption()
                            Select
                                     ID = p.Field(Of Long)("TrxID"),
                                     TrxDate = p.Field(Of Date)("TrxDate"),
                                     Client = c.Field(Of String)("ClientName"),
                                     Amount = p.Field(Of Decimal)("TrxAmount"),
                                     Price = p.Field(Of Decimal)("TrxPrice"),
                                     Unit = p.Field(Of Decimal)("TrxUnit")
                With DBGRedemption
                    .AllowAddNew = False
                    .AllowDelete = False
                    .AllowUpdate = False
                    .Style.WrapText = False
                    .Columns.Clear()
                    .DataSource = query.ToList

                    .Columns("TrxDate").NumberFormat = "dd-MMM-yyyy"
                    .Columns("Amount").NumberFormat = "n2"
                    .Columns("Price").NumberFormat = "n5"
                    .Columns("Unit").NumberFormat = "n5"

                    .Splits(0).DisplayColumns("TrxDate").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("Type").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .Splits(0).DisplayColumns("Amount").Style.HorizontalAlignment = AlignHorzEnum.Far
                    .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
                    .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far

                    Dim ID, TrxDate, Client, Amount, Price, Unit As C1DisplayColumn
                    ID = .Splits(0).DisplayColumns("ID")
                    TrxDate = .Splits(0).DisplayColumns("TrxDate")
                    Client = .Splits(0).DisplayColumns("Client")
                    Amount = .Splits(0).DisplayColumns("Amount")
                    Price = .Splits(0).DisplayColumns("Price")
                    Unit = .Splits(0).DisplayColumns("Unit")

                    ID.Width = 35
                    TrxDate.Width = 75
                    Client.Width = 250
                    Amount.Width = 100
                    Price.Width = 85
                    Unit.Width = 100

                    For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                        column.Style.WrapText = True
                        .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                    Next

                End With
            Else
                DBGRedemption.Columns.Clear()
                ExceptionMessage.Show(objCapital.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DBGRedemption_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGRedemption.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGRedemption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGRedemption.Click
        With DBGRedemption
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        TrxAdd()
    End Sub

    Private Sub TrxAdd()
        If objPortfolio.GetPortfolioID > 0 Then
            If objPortfolio.User_Access() = 1 Then
                Dim frm As New FormTransactionRedemptionNew
                frm.Left = 0
                frm.Top = 30
                frm.MdiParent = Me
                frm.MdiParent = MDISO
                frm.Show()
            Else
                ExceptionMessage.Show(objError.Message(90), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        TrxDelete()
    End Sub

    Private Sub TrxDelete()
        With DBGRedemption
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objTrx.Clear()
                objTrx.Load(objMasterSimpi, .Columns("ID").Text)
                If objTrx.ErrID = 0 Then
                    Dim frm As New FormTransactionRedemptionDelete
                    frm.Show()
                    frm.objRedemption = objTrx
                    frm.RedemptionLoad()
                    frm.CallerForm = Me
                    frm.MdiParent = MDISO
                Else
                    ExceptionMessage.Show(objTrx.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub



End Class