Imports simpi.globalutilities
Imports simpi.MasterSimpi
Imports simpi.MasterPortfolio
Imports simpi.CoreData
Imports simpi.CoreOverride

Public Class FormEODOverrideDividendCash
    Dim objSimpi As New MasterSimpi
    Dim objPortfolio As New MasterPortfolio
    Dim objOverride As New OverrideCapital
    Dim objMTM As New PortfolioMTM
    Dim objNAV As New PortfolioNAV
    Dim objPosition As New PositionCapital
    Dim dividendRate As Double = 0

    Private Sub FormEODOverrideDividendCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objSimpi.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objPosition.UserAccess = objAccess
        dtPayment.Value = Now
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

    Private Sub lblSimpiEmail_TextChanged(sender As Object, e As EventArgs) Handles lblSimpiEmail.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objSimpi.Clear()
            objSimpi.Load(lblSimpiEmail.Text)
            If objSimpi.ErrID = 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objSimpi, lblPortfolioCode.Text)
                If objPortfolio.ErrID <> 0 Then ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub GridInit()
        With fgExcel
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgExcel(0, 0) = "ID"
            fgExcel(0, 1) = "CIF"
            fgExcel(0, 2) = "Name"
            fgExcel(0, 3) = "Units"
            fgExcel(0, 4) = "Price"
            fgExcel(0, 5) = "Value"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        GridLoad()
    End Sub

    Private Sub GridLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            objMTM.Clear()
            objMTM.NextAt(objPortfolio, dtPayment.Value)
            If objMTM.ErrID = 0 Then
                objNAV.Clear()
                objNAV.LoadAt(objPortfolio, objMTM.GetPositionDate)
                If objNAV.ErrID = 0 Then
                    lblPrice.Text = objNAV.GetNAVPerUnit.ToString("n4")
                    lblNAVDate.Text = objNAV.GetPositionDate.ToString("dd-MMM-yyyy")
                Else
                    lblPrice.Text = 0.ToString("n4")
                    lblNAVDate.Text = ""
                End If
                GridInit()
                Dim dtClient As New DataTable
                objPosition.Clear()
                dtClient = objPosition.Search(objPortfolio, objMTM.GetPositionDate)
                If dtClient IsNot Nothing AndAlso dtClient.Rows.Count > 0 Then
                    Dim query = From n In dtClient.AsEnumerable
                                Select ID = n.Field(Of Integer)("ClientID"),
                                       CIF = n.Field(Of String)("ClientCode"),
                                       Name = n.Field(Of String)("ClientName"),
                                       Units = n.Field(Of Decimal)("UnitBalance"),
                                       Price = n.Field(Of Decimal)("UnitPrice"),
                                       Value = n.Field(Of Decimal)("UnitValue")
                    lblUnits.Text = (From q In query Select u = q.Units).Sum.ToString("n4")
                    lblNAV.Text = (From q In query Select u = q.Value).Sum.ToString("n0")
                    lblRows.Text = query.Count

                    For Each item In query
                        fgExcel.Rows.Add()
                        fgExcel(fgExcel.Rows.Count - 1, 0) = item.ID
                        fgExcel(fgExcel.Rows.Count - 1, 1) = item.CIF
                        fgExcel(fgExcel.Rows.Count - 1, 2) = item.Name
                        fgExcel(fgExcel.Rows.Count - 1, 3) = item.Units.ToString("n4")
                        fgExcel(fgExcel.Rows.Count - 1, 4) = item.Price.ToString("n4")
                        fgExcel(fgExcel.Rows.Count - 1, 5) = item.Value.ToString("n2")
                    Next
                    fgExcel.AutoSizeCols()
                End If
            Else
                ExceptionMessage.Show(objMTM.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        dividendAmount
    End Sub

    Private Sub dividendAmount()
        Double.TryParse(txtRate.Text, dividendRate)
        lblDividendAmount.Text = (dividendRate * CDbl(lblUnits.Text)).ToString("n2")
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        DataRun()
    End Sub

    Private Sub DataRun()
        If fgExcel.Rows.Count > 0 And objPortfolio.GetPortfolioID > 0 Then
            Double.TryParse(txtRate.Text, dividendRate)
            objOverride.Clear()
            Cursor = Cursors.WaitCursor
            objOverride.dividend_cash(objPortfolio, objNAV.GetPositionDate, dividendRate)
            Cursor = Cursors.Default
            If objOverride.ErrID = 0 Then
                Close()
            Else
                ExceptionMessage.Show(objOverride.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class