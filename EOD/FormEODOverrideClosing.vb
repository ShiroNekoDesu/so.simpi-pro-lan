Imports simpi.globalutilities
Imports simpi.MasterSimpi
Imports simpi.MasterPortfolio
Imports simpi.MasterClient
Imports simpi.CoreData
Imports simpi.CoreClosing

Public Class FormEODOverrideClosing
    Dim objSimpi As New MasterSimpi
    Dim objPortfolio As New MasterPortfolio
    Dim objClient As New MasterClient
    Dim objEOD As New ProcessEOD
    Dim objCapital As New PositionCapital
    Dim objNAV As New PortfolioNAV
    Dim objMTM As New PortfolioMTM

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
                PrintExcel(fgExcel)
        End Select
    End Sub

    Private Sub FormEODOverrideClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetClientMaster()
        GetSalesMaster()
        objSimpi.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        objClient.UserAccess = objAccess
        objEOD.UserAccess = objAccess
        objCapital.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objMTM.UserAccess = objAccess
        dtNext.Value = Now
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
        initExcel()
        lblAsOf.Text = ""
        lblPrice.Text = ""
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
                If objPortfolio.ErrID = 0 Then
                    objMTM.Clear()
                    objMTM.LoadEnd(objPortfolio)
                    If objMTM.ErrID = 0 Then
                        lblAsOf.Text = objMTM.GetNextDate.ToString("dd-MMM-yyyy")
                        dtNext.Value = objMTM.GetNextDate.AddDays(1)
                        objNAV.LoadAt(objPortfolio, objMTM.GetNextDate)
                        lblNAV.Text = objNAV.GetNAV.ToString("n0")
                        lblUnits.Text = objNAV.GetTotalUnit.ToString("n0")
                        lblPrice.Text = objNAV.GetNAVPerUnit.ToString("n4")
                        ClientLoad()
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub initExcel()
        With fgExcel
            .Rows.Count = 1
            .Cols.Count = 8
            .ExtendLastCol = False
            fgExcel(0, 0) = "ID"
            fgExcel(0, 1) = "CIF"
            fgExcel(0, 2) = "Name"
            fgExcel(0, 3) = "Sales"
            fgExcel(0, 4) = "Unit"
            fgExcel(0, 5) = "Value"
            fgExcel(0, 6) = "S"
            fgExcel(0, 7) = "ErrMsg"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub ClientLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            initExcel()
            Dim tbl As New DataTable
            objCapital.Clear()
            tbl = objCapital.Search(objPortfolio, objMTM.GetNextDate)
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                Dim query = From n In tbl.AsEnumerable
                            Join c In dtClientMaster
                                 On n.Field(Of Integer)("ClientID") Equals c.Field(Of Integer)("ClientID")
                            Join s In dtSalesMaster
                                 On s.Field(Of Integer)("SalesID") Equals c.Field(Of Integer)("SalesID")
                            Select ID = n.Field(Of Integer)("ClientID"),
                                   CIF = c.Field(Of String)("ClientCode"),
                                   Name = c.Field(Of String)("ClientName"),
                                   Sales = s.Field(Of String)("SalesCode"),
                                   Unit = n.Field(Of Decimal)("UnitBalance"),
                                   Value = n.Field(Of Decimal)("UnitValue")
                For Each item In query
                    fgExcel.Rows.Add()
                    fgExcel(fgExcel.Rows.Count - 1, 0) = item.ID
                    fgExcel(fgExcel.Rows.Count - 1, 1) = item.CIF
                    fgExcel(fgExcel.Rows.Count - 1, 2) = item.Name
                    fgExcel(fgExcel.Rows.Count - 1, 3) = item.Sales
                    fgExcel(fgExcel.Rows.Count - 1, 4) = item.Unit.ToString("n4")
                    fgExcel(fgExcel.Rows.Count - 1, 5) = item.Value.ToString("n2")
                    fgExcel(fgExcel.Rows.Count - 1, 6) = ""
                    fgExcel(fgExcel.Rows.Count - 1, 7) = ""
                Next
                lblRows.Text = fgExcel.Rows.Count - 1
                fgExcel.AutoSizeCols()
            End If
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        DataSave()
    End Sub

    Private Sub DataSave()
        If objPortfolio.GetPortfolioID > 0 Then
            Cursor = Cursors.WaitCursor
            objEOD.endofday(objPortfolio, dtNext.Value)
            If objEOD.ErrID = 0 Then
                ExceptionMessage.Show("End of day finished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Cursor = Cursors.Default
        End If
    End Sub


End Class