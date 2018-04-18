Imports simpi.GlobalException
Imports simpi.MasterSimpi
Imports simpi.MasterPortfolio
Imports simpi.MasterClient
Imports simpi.CoreData
Imports simpi.CoreClosing
Imports simpi.CoreOverride

Public Class FormEODOverrideClosing2
    Dim objSimpi As New MasterSimpi
    Dim objPortfolio As New MasterPortfolio
    Dim objClient As New MasterClient
    Dim objCapital As New PositionCapital
    Dim objNAV As New PortfolioNAV
    Dim objOverride As New OverrideCapital

    Private Sub FormEODOverrideClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        objSimpi.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        objClient.UserAccess = objAccess
        objCapital.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        objOverride.UserAccess = objAccess
        dtAs.Value = Now
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
                If objPortfolio.ErrID <> 0 Then
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ClientLoad()
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
            objNAV.Clear()
            objNAV.LoadAt(objPortfolio, dtAs.Value)
            lblPrice.Text = objNAV.GetNAVPerUnit.ToString("n4")
            initExcel()
            Dim tbl As New DataTable
            objCapital.Clear()
            tbl = objCapital.Search(objPortfolio, dtAs.Value, "")
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                Dim query = From n In tbl.AsEnumerable
                            Select ID = n.Field(Of Integer)("ClientID"),
                                   CIF = n.Field(Of String)("ClientCode"),
                                   Name = n.Field(Of String)("ClientName"),
                                   Sales = n.Field(Of String)("SalesCode"),
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
        btnSearch.Enabled = False
        btnRun.Enabled = False
        bwRun.RunWorkerAsync()
    End Sub

    Private Sub bwRun_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        DataSave
    End Sub

    Private Sub bwRun_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        btnSearch.Enabled = True
        btnRun.Enabled = True
    End Sub

    Private Sub DataSave()
        If objPortfolio.GetPortfolioID > 0 Then
            pbNAV.Value = 100
            For i = 1 To fgExcel.Rows.Count - 1
                objClient.Clear()
                objClient.Load(objMasterSimpi, fgExcel(i, 1))
                If objClient.ErrID = 0 Then
                    objOverride.Clear()
                    objOverride.endofday(objPortfolio, objClient, CDate(dtAs.Value))
                    If objOverride.ErrID = 0 Then
                        fgExcel(i, 6) = "DONE"
                        fgExcel(i, 7) = ""
                    Else
                        fgExcel(i, 6) = "ERROR"
                        fgExcel(i, 7) = objOverride.ErrMsg
                    End If
                Else
                    fgExcel(i, 6) = "ERROR"
                    fgExcel(i, 7) = objClient.ErrMsg
                End If
            Next
            pbNAV.Value = 0
            fgExcel.AutoSizeCols()
        End If
    End Sub

End Class