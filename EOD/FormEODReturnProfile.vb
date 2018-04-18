Imports simpi.CoreData
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalDate
Imports simpi.MasterPortfolio
Imports simpi.CoreClosing

Public Class FormEODReturnProfile
    Public CallerForm As FormEODReturn
    Public objNAV As PortfolioNAV
    Public objPortfolio As MasterPortfolio
    Dim objEOD As New ProcessEOD
    Dim objReturn As New PortfolioReturn
    Dim dateReturn As Date

    Public Sub FormLoad()
        If objNAV.ErrID = 0 And objPortfolio.GetPortfolioID > 0 Then
            lblPortfolioCode.Text = objPortfolio.GetPortfolioCode
            lblPortfolioName.Text = objPortfolio.GetPortfolioNameFull
            lblPortfolioCcy.Text = objPortfolio.GetPortfolioCcy.GetCcy
            lblInception.Text = objPortfolio.GetInceptionDate.ToString("dd-MMMM-yyyy")
            dateReturn = objNAV.GetPositionDate
            lblValuation.Text = dateReturn.ToString("dd-MMMM-yyyy")
            lblNAV.Text = objNAV.GetNAV.ToString("n0")
            lblNAVPerUnit.Text = objNAV.GetNAVPerUnit.ToString("n5")
            lblUnit.Text = objNAV.GetTotalUnit.ToString("n0")

            objEOD.UserAccess = objAccess
            objReturn.UserAccess = objAccess
            ReturnLoad()
        Else
            Close()
        End If
    End Sub

    Private Sub ReturnLoad()
        objReturn.Clear()
        objReturn.LoadAt(objPortfolio, dateReturn)
        With fgReturn
            .Cols.Fixed = 0
            .Rows.Fixed = 1
            .ExtendLastCol = False
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .Cols.Count = 3
            .Rows.Count = 1

            .Cols(0).Width = 50
            .Cols(1).Width = 85
            .Cols(2).Width = 100

            .Cols(0).Caption = "Period"
            .Cols(1).Caption = "Date"
            .Cols(2).Caption = "Return"
            If objReturn.ErrID = 0 Then
                .AddItem("1D" + vbTab + GenerateDate(dateReturn, "D", 1).ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr1D * 100).ToString("n3"))
                .AddItem("MTD" + vbTab + GenerateDate(dateReturn, "MTD").ToString("dd-MMM-yyyy") + vbTab + (objReturn.GetrMTD * 100).ToString("n3"))
                .AddItem("1Mo" + vbTab + GenerateDate(dateReturn, "M", 1, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr1Mo * 100).ToString("n3"))
                .AddItem("3Mo" + vbTab + GenerateDate(dateReturn, "M", 3, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr3Mo * 100).ToString("n3"))
                .AddItem("6Mo" + vbTab + GenerateDate(dateReturn, "M", 6, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr6Mo * 100).ToString("n3"))
                .AddItem("YTD" + vbTab + GenerateDate(dateReturn, "YTD").ToString("dd-MMM-yyyy") + vbTab + (objReturn.GetrYTD * 100).ToString("n3"))
                .AddItem("1Y" + vbTab + GenerateDate(dateReturn, "Y", 1, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr1Y * 100).ToString("n3"))
                .AddItem("2Y" + vbTab + GenerateDate(dateReturn, "Y", 2, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr2Y * 100).ToString("n3"))
                .AddItem("3Y" + vbTab + GenerateDate(dateReturn, "Y", 3, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr3Y * 100).ToString("n3"))
                .AddItem("5Y" + vbTab + GenerateDate(dateReturn, "Y", 5, "A").ToString("dd-MMM-yyyy") + vbTab + (objReturn.Getr5Y * 100).ToString("n3"))
                .AddItem("Inception" + vbTab + objPortfolio.GetInceptionDate.ToString("dd-MMM-yyyy") + vbTab + (objReturn.GetrInception * 100).ToString("n3"))
                btnDelete.Enabled = True
                btnGenerate.Enabled = False
            Else
                .AddItem("1D" + vbTab + GenerateDate(dateReturn, "D", 1).ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("MTD" + vbTab + GenerateDate(dateReturn, "MTD").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("1Mo" + vbTab + GenerateDate(dateReturn, "M", 1, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("3Mo" + vbTab + GenerateDate(dateReturn, "M", 3, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("6Mo" + vbTab + GenerateDate(dateReturn, "M", 6, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("YTD" + vbTab + GenerateDate(dateReturn, "YTD").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("1Y" + vbTab + GenerateDate(dateReturn, "Y", 1, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("2Y" + vbTab + GenerateDate(dateReturn, "Y", 2, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("3Y" + vbTab + GenerateDate(dateReturn, "Y", 3, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("5Y" + vbTab + GenerateDate(dateReturn, "Y", 5, "A").ToString("dd-MMM-yyyy") + vbTab + "")
                .AddItem("Inception" + vbTab + objPortfolio.GetInceptionDate.ToString("dd-MMM-yyyy") + vbTab + "")
                btnDelete.Enabled = False
                btnGenerate.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ReturnGenerate()
    End Sub

    Private Sub ReturnGenerate()
        objEOD.return_generate(objPortfolio, dateReturn)
        If objEOD.ErrID = 0 Then
            CallerForm.ReturnLoad()
            Close()
        Else
            ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ReturnRemove()
    End Sub

    Private Sub ReturnRemove()
        objEOD.return_delete(objPortfolio, dateReturn)
        If objEOD.ErrID = 0 Then
            CallerForm.ReturnLoad()
            Close()
        Else
            ExceptionMessage.Show(objEOD.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class