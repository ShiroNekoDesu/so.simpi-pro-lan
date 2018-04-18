Imports simpi.GlobalUtilities
Imports simpi.CoreData
Imports simpi.MasterPortfolio

Public Class ReportProductFocusEQ
    Dim objPortfolio As New MasterPortfolio
    Dim objNAV As New PortfolioNAV

    Private Sub ReportProductFocusEQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetInstrumentUser()
        GetParameterInstrumentType()
        dtAs.Value = Now

        objPortfolio.UserAccess = objAccess
        objNAV.UserAccess = objAccess

        DBGPerformance.FetchRowStyles = True
        DBGHolding.FetchRowStyles = True
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

    Private Sub lblSimpiEmail_TextChanged(sender As Object, e As EventArgs) Handles lblSimpiEmail.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objPortfolio.Clear()
            objPortfolio.LoadCode(objMasterSimpi, lblPortfolioCode.Text)
            If objPortfolio.ErrID = 0 Then

            Else
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DataLoad()
        DataDisplay()
    End Sub

    Private Sub DataLoad()
        If objPortfolio.GetPortfolioID > 0 Then
            objNAV.Clear()
            objNAV.LoadAt(objPortfolio, dtAs.Value)

        End If
    End Sub

    Private Sub DataDisplay()
        If objNAV.GetNAV > 0 Then

        End If
    End Sub

End Class