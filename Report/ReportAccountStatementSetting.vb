Imports simpi.globalconnection
Imports simpi.GlobalUtilities

Public Class ReportAccountStatementSetting
    Public frm As ReportAccountStatement
    Dim reportSection As String = "REPORT ACCOUNT HOLDER ACCOUNT STATEMENT"

    Public Sub FormLoad()
        If frm.pdfLayout.layoutType = "DEFAULT" Then
            rbDefault.Checked = True
        ElseIf frm.pdfLayout.layoutType = "OPTION1" Then
            rbOption1.Checked = True
        Else
            rbOption2.Checked = True
        End If
    End Sub

    Private Sub rbDefault_CheckedChanged(sender As Object, e As EventArgs) Handles rbDefault.CheckedChanged
        iniCheck()
    End Sub

    Private Sub rbOption1_CheckedChanged(sender As Object, e As EventArgs) Handles rbOption1.CheckedChanged
        iniCheck()
    End Sub

    Private Sub rbOption2_CheckedChanged(sender As Object, e As EventArgs) Handles rbOption2.CheckedChanged
        iniCheck()
    End Sub

    Private Sub iniCheck()
        If rbDefault.Checked Then
            iniLoad("DEFAULT")
        ElseIf rbOption1.Checked Then
            iniLoad("OPTION1")
        ElseIf rbOption2.Checked Then
            iniLoad("OPTION2")
        End If
    End Sub

    Private Sub iniLoad(ByVal iniType As String)
        Try
            If iniType.Trim = "DEFAULT" Then
                _default()
            Else
                Dim strFile As String = simpiFile("simpi.ini")
                If GlobalFileWindows.FileExists(strFile) Then
                    Dim r, g, b As Integer
                    Dim file As New GlobalINI(strFile)
                    r = file.GetInteger(reportSection, iniType & " Report Title R", 0)
                    g = file.GetInteger(reportSection, iniType & " Report Title G", 0)
                    b = file.GetInteger(reportSection, iniType & " Report Title B", 0)
                    ReportTitle_R.Text = RGBWrite("R", r)
                    ReportTitle_G.Text = RGBWrite("G", g)
                    ReportTitle_B.Text = RGBWrite("B", b)
                    txtColorReportTitle.BackColor = Color.FromArgb(r, g, b)
                    txtReportTitle.Text = file.GetString(reportSection, iniType & " Report Title", "")

                    r = file.GetInteger(reportSection, iniType & " Client R", 0)
                    g = file.GetInteger(reportSection, iniType & " Client G", 0)
                    b = file.GetInteger(reportSection, iniType & " Client B", 0)
                    Client_R.Text = RGBWrite("R", r)
                    Client_G.Text = RGBWrite("G", g)
                    Client_B.Text = RGBWrite("B", b)
                    txtColorClient.BackColor = Color.FromArgb(r, g, b)
                    txtPeriod.Text = file.GetString(reportSection, iniType & " Period", "")

                    r = file.GetInteger(reportSection, iniType & " NAV/Unit R", 0)
                    g = file.GetInteger(reportSection, iniType & " NAV/Unit G", 0)
                    b = file.GetInteger(reportSection, iniType & " NAV/Unit B", 0)
                    NAVUnit_R.Text = RGBWrite("R", r)
                    NAVUnit_G.Text = RGBWrite("G", g)
                    NAVUnit_B.Text = RGBWrite("B", b)
                    txtColorNAVUnit.BackColor = Color.FromArgb(r, g, b)
                    txtNAVUnit.Text = file.GetString(reportSection, iniType & " NAV/Unit", "")

                    r = file.GetInteger(reportSection, iniType & " Report Line R", 0)
                    g = file.GetInteger(reportSection, iniType & " Report Line G", 0)
                    b = file.GetInteger(reportSection, iniType & " Report Line B", 0)
                    ReportLine_R.Text = RGBWrite("R", r)
                    ReportLine_G.Text = RGBWrite("G", g)
                    ReportLine_B.Text = RGBWrite("B", b)
                    txtColorReportLine.BackColor = Color.FromArgb(r, g, b)

                    r = file.GetInteger(reportSection, iniType & " Portfolio R", 0)
                    g = file.GetInteger(reportSection, iniType & " Portfolio G", 0)
                    b = file.GetInteger(reportSection, iniType & " Portfolio B", 0)
                    Portfolio_R.Text = RGBWrite("R", r)
                    Portfolio_G.Text = RGBWrite("G", g)
                    Portfolio_B.Text = RGBWrite("B", b)
                    txtColorPortfolio.BackColor = Color.FromArgb(r, g, b)

                    r = file.GetInteger(reportSection, iniType & " Summary R", 0)
                    g = file.GetInteger(reportSection, iniType & " Summary G", 0)
                    b = file.GetInteger(reportSection, iniType & " Summary B", 0)
                    Summary_R.Text = RGBWrite("R", r)
                    Summary_G.Text = RGBWrite("G", g)
                    Summary_B.Text = RGBWrite("B", b)
                    txtColorSummary.BackColor = Color.FromArgb(r, g, b)
                    txtSummary.Text = file.GetString(reportSection, iniType & " Summary", "")

                    r = file.GetInteger(reportSection, iniType & " Summary Line R", 0)
                    g = file.GetInteger(reportSection, iniType & " Summary Line G", 0)
                    b = file.GetInteger(reportSection, iniType & " Summary Line B", 0)
                    SummaryLine_R.Text = RGBWrite("R", r)
                    SummaryLine_G.Text = RGBWrite("G", g)
                    SummaryLine_B.Text = RGBWrite("B", b)
                    txtColorSummaryLine.BackColor = Color.FromArgb(r, g, b)

                    r = file.GetInteger(reportSection, iniType & " Summary Items R", 0)
                    g = file.GetInteger(reportSection, iniType & " Summary Items G", 0)
                    b = file.GetInteger(reportSection, iniType & " Summary Items B", 0)
                    SummaryItems_R.Text = RGBWrite("R", r)
                    SummaryItems_G.Text = RGBWrite("G", g)
                    SummaryItems_B.Text = RGBWrite("B", b)
                    txtColorSummaryItems.BackColor = Color.FromArgb(r, g, b)
                    txtSummaryItemsTotalRedemption.Text = file.GetString(reportSection, iniType & " Summary Items Total Redemption", "")
                    txtSummaryItemsAcqCost.Text = file.GetString(reportSection, iniType & " Summary Items Acq Cost", "")
                    txtSummaryItemsRedemptionPL.Text = file.GetString(reportSection, iniType & " Summary Items Redemption PL", "")
                    txtSummaryItemsDividend.Text = file.GetString(reportSection, iniType & " Summary Items Dividend", "")
                    txtSummaryItemsRealizedPL.Text = file.GetString(reportSection, iniType & " Summary Items Realized PL", "")
                    txtSummaryItemsLastInvestmentValue.Text = file.GetString(reportSection, iniType & " Summary Items Last Investment Value", "")
                    txtSummaryItemsLastAcqCost.Text = file.GetString(reportSection, iniType & " Summary Items Last Acq Cost", "")
                    txtSummaryItemsUnrealizedPL.Text = file.GetString(reportSection, iniType & " Summary Items Unrealized PL", "")

                    r = file.GetInteger(reportSection, iniType & " Chart Title R", 0)
                    b = file.GetInteger(reportSection, iniType & " Chart Title G", 0)
                    g = file.GetInteger(reportSection, iniType & " Chart Title B", 0)
                    ChartTitle_R.Text = RGBWrite("R", r)
                    ChartTitle_G.Text = RGBWrite("B", b)
                    ChartTitle_B.Text = RGBWrite("G", g)
                    txtColorChartTitle.BackColor = Color.FromArgb(r, b, g)
                    txtInvestmentGrowth.Text = file.GetString(reportSection, iniType & " Investment Growth", "")

                    r = file.GetInteger(reportSection, iniType & " Chart Border R", 0)
                    g = file.GetInteger(reportSection, iniType & " Chart Border G", 0)
                    b = file.GetInteger(reportSection, iniType & " Chart Border B", 0)
                    ChartBorder_R.Text = RGBWrite("R", r)
                    ChartBorder_G.Text = RGBWrite("G", g)
                    ChartBorder_B.Text = RGBWrite("B", b)
                    txtColorChartBorder.BackColor = Color.FromArgb(r, g, b)
                    If file.GetBoolean(reportSection, iniType & " Chart Border", False) Then chkChartBorder.Checked = True Else chkChartBorder.Checked = False

                    r = file.GetInteger(reportSection, iniType & " Chart Line R", 0)
                    g = file.GetInteger(reportSection, iniType & " Chart Line G", 0)
                    b = file.GetInteger(reportSection, iniType & " Chart Line B", 0)
                    ChartLine_R.Text = RGBWrite("R", r)
                    ChartLine_G.Text = RGBWrite("G", g)
                    ChartLine_B.Text = RGBWrite("B", b)
                    txtColorChartLine.BackColor = Color.FromArgb(r, g, b)
                    txtChartLabel.Text = file.GetString(reportSection, iniType & " Chart Label", "")

                    r = file.GetInteger(reportSection, iniType & " Table Header R", 0)
                    g = file.GetInteger(reportSection, iniType & " Table Header G", 0)
                    b = file.GetInteger(reportSection, iniType & " Table Header B", 0)
                    TableHeader_R.Text = RGBWrite("R", r)
                    TableHeader_G.Text = RGBWrite("G", g)
                    TableHeader_B.Text = RGBWrite("B", b)
                    txtColorTableHeader.BackColor = Color.FromArgb(r, g, b)

                    r = file.GetInteger(reportSection, iniType & " Table Line R", 0)
                    g = file.GetInteger(reportSection, iniType & " Table Line G", 0)
                    b = file.GetInteger(reportSection, iniType & " Table Line B", 0)
                    TableLine_R.Text = RGBWrite("R", r)
                    TableLine_G.Text = RGBWrite("G", g)
                    TableLine_B.Text = RGBWrite("B", b)
                    txtColorTableLine.BackColor = Color.FromArgb(r, g, b)

                    r = file.GetInteger(reportSection, iniType & " Table Items R", 0)
                    g = file.GetInteger(reportSection, iniType & " Table Items G", 0)
                    b = file.GetInteger(reportSection, iniType & " Table Items B", 0)
                    TableItems_R.Text = RGBWrite("R", r)
                    TableItems_G.Text = RGBWrite("G", g)
                    TableItems_B.Text = RGBWrite("B", b)
                    txtColorTableItems.BackColor = Color.FromArgb(r, g, b)

                    r = file.GetInteger(reportSection, iniType & " Table Title R", 0)
                    g = file.GetInteger(reportSection, iniType & " Table Title G", 0)
                    b = file.GetInteger(reportSection, iniType & " Table Title B", 0)
                    TableTitle_R.Text = RGBWrite("R", r)
                    TableTitle_G.Text = RGBWrite("G", g)
                    TableTitle_B.Text = RGBWrite("B", b)
                    txtColorTableTitle.BackColor = Color.FromArgb(r, g, b)
                    txtTableTanggal.Text = file.GetString(reportSection, iniType & " Table Tanggal", "")
                    txtTableDate.Text = file.GetString(reportSection, iniType & " Table Date", "")
                    txtTableUraian.Text = file.GetString(reportSection, iniType & " Table Uraian", "")
                    txtTableDescription.Text = file.GetString(reportSection, iniType & " Table Description", "")
                    txtTableNilaiTransaksi.Text = file.GetString(reportSection, iniType & " Table Nilai Transaksi", "")
                    txtTableGross.Text = file.GetString(reportSection, iniType & " Table Gross", "")
                    txtTableNet.Text = file.GetString(reportSection, iniType & " Table Net", "")
                    txtTableHargaUP.Text = file.GetString(reportSection, iniType & " Table Harga/UP", "")
                    txtTableNAVUnit.Text = file.GetString(reportSection, iniType & " Table NAV/Unit", "")
                    txtTableUnitPenyertaan.Text = file.GetString(reportSection, iniType & " Table Unit Penyertaan", "")
                    txtTableBiayaPerolehan.Text = file.GetString(reportSection, iniType & " Table Biaya Perolehan", "")
                    txtTableAcqCost.Text = file.GetString(reportSection, iniType & " Table Acq. Cost", "")
                    txtTableLRRealisasi.Text = file.GetString(reportSection, iniType & " Table L/R Realisasi", "")
                    txtTableRealizedPL.Text = file.GetString(reportSection, iniType & " Table Realized P/L", "")
                    txtTableSaldoUP.Text = file.GetString(reportSection, iniType & " Table Saldo (UP)", "")
                    txtTableBalanceUnit.Text = file.GetString(reportSection, iniType & " Table Balance (Unit)", "")
                End If
            End If
        Catch ex As Exception
            _default()
        End Try
    End Sub

    Private Sub _default()
        With frm.pdfLayout
            frm.pdfColorDefault()
            ReportTitle_R.Text = "R: " & .ReportTitle_R
            ReportTitle_G.Text = "G: " & .ReportTitle_G
            ReportTitle_B.Text = "B: " & .ReportTitle_B
            txtColorReportTitle.BackColor = Color.FromArgb(.ReportTitle_R, .ReportTitle_G, .ReportTitle_B)
            txtReportTitle.Text = .ReportTitle
            Client_R.Text = "R: " & .Client_R
            Client_G.Text = "G: " & .Client_G
            Client_B.Text = "B: " & .Client_B
            txtColorClient.BackColor = Color.FromArgb(.Client_R, .Client_G, .Client_B)
            txtPeriod.Text = .Period
            NAVUnit_R.Text = "R: " & .NAVUnit_R
            NAVUnit_G.Text = "G: " & .NAVUnit_G
            NAVUnit_B.Text = "B: " & .NAVUnit_B
            txtColorNAVUnit.BackColor = Color.FromArgb(.NAVUnit_R, .NAVUnit_G, .NAVUnit_B)
            txtNAVUnit.Text = .NAVUnit
            ReportLine_R.Text = "R: " & .ReportLine_R
            ReportLine_G.Text = "G: " & .ReportLine_G
            ReportLine_B.Text = "B: " & .ReportLine_B
            txtColorReportLine.BackColor = Color.FromArgb(.ReportLine_R, .ReportLine_G, .ReportLine_B)
            Portfolio_R.Text = "R: " & .Portfolio_R
            Portfolio_G.Text = "G: " & .Portfolio_G
            Portfolio_B.Text = "B: " & .Portfolio_B
            txtColorPortfolio.BackColor = Color.FromArgb(.Portfolio_R, .Portfolio_G, .Portfolio_B)
            Summary_R.Text = "R: " & .Summary_R
            Summary_G.Text = "G: " & .Summary_G
            Summary_B.Text = "B: " & .Summary_B
            txtColorSummary.BackColor = Color.FromArgb(.Summary_R, .Summary_G, .Summary_B)
            txtSummary.Text = .Summary
            SummaryLine_R.Text = "R: " & .SummaryLine_R
            SummaryLine_G.Text = "G: " & .SummaryLine_G
            SummaryLine_B.Text = "B: " & .SummaryLine_B
            txtColorSummaryLine.BackColor = Color.FromArgb(.SummaryLine_R, .SummaryLine_G, .SummaryLine_B)
            SummaryItems_R.Text = "R: " & .SummaryItems_R
            SummaryItems_G.Text = "G: " & .SummaryItems_G
            SummaryItems_B.Text = "B: " & .SummaryItems_B
            txtColorSummaryItems.BackColor = Color.FromArgb(.SummaryItems_R, .SummaryItems_G, .SummaryItems_B)
            txtSummaryItemsTotalRedemption.Text = .SummaryItemsTotalRedemption
            txtSummaryItemsAcqCost.Text = .SummaryItemsAcqCost
            txtSummaryItemsRedemptionPL.Text = .SummaryItemsRedemptionPL
            txtSummaryItemsDividend.Text = .SummaryItemsDividend
            txtSummaryItemsRealizedPL.Text = .SummaryItemsRealizedPL
            txtSummaryItemsLastInvestmentValue.Text = .SummaryItemsLastInvestmentValue
            txtSummaryItemsLastAcqCost.Text = .SummaryItemsLastAcqCost
            txtSummaryItemsUnrealizedPL.Text = .SummaryItemsUnrealizedPL
            ChartTitle_R.Text = "R: " & .ChartTitle_R
            ChartTitle_G.Text = "G: " & .ChartTitle_G
            ChartTitle_B.Text = "B: " & .ChartTitle_B
            txtColorChartTitle.BackColor = Color.FromArgb(.ChartTitle_R, .ChartTitle_G, .ChartTitle_B)
            txtInvestmentGrowth.Text = .InvestmentGrowth
            ChartBorder_R.Text = "R: " & .ChartBorder_R
            ChartBorder_G.Text = "G: " & .ChartBorder_G
            ChartBorder_B.Text = "B: " & .ChartBorder_B
            txtColorChartBorder.BackColor = Color.FromArgb(.ChartBorder_R, .ChartBorder_G, .ChartBorder_B)
            chkChartBorder.Checked = .ChartBorder
            ChartLine_R.Text = "R: " & .ChartLine_R
            ChartLine_G.Text = "G: " & .ChartLine_G
            ChartLine_B.Text = "B: " & .ChartLine_B
            txtColorChartLine.BackColor = Color.FromArgb(.ChartLine_R, .ChartLine_G, .ChartLine_B)
            txtChartLabel.Text = .ChartLabel
            TableHeader_R.Text = "R: " & .TableHeader_R
            TableHeader_G.Text = "G: " & .TableHeader_G
            TableHeader_B.Text = "B: " & .TableHeader_B
            txtColorTableHeader.BackColor = Color.FromArgb(.TableHeader_R, .TableHeader_G, .TableHeader_B)
            TableLine_R.Text = "R: " & .TableLine_R
            TableLine_G.Text = "G: " & .TableLine_G
            TableLine_B.Text = "B: " & .TableLine_B
            txtColorTableLine.BackColor = Color.FromArgb(.TableLine_R, .TableLine_G, .TableLine_B)
            TableItems_R.Text = "R: " & .TableItems_R
            TableItems_G.Text = "G: " & .TableItems_G
            TableItems_B.Text = "B: " & .TableItems_B
            txtColorTableItems.BackColor = Color.FromArgb(.TableItems_R, .TableItems_G, .TableItems_B)
            TableTitle_R.Text = "R: " & .TableTitle_R
            TableTitle_G.Text = "G: " & .TableTitle_G
            TableTitle_B.Text = "B: " & .TableTitle_B
            txtColorTableTitle.BackColor = Color.FromArgb(.TableTitle_R, .TableTitle_G, .TableTitle_B)
            txtTableTanggal.Text = .TableTitleTanggal
            txtTableDate.Text = .TableTitleDate
            txtTableUraian.Text = .TableTitleUraian
            txtTableDescription.Text = .TableTitleDescription
            txtTableNilaiTransaksi.Text = .TableTitleNilaiTransaksi
            txtTableGross.Text = .TableTitleGross
            txtTableNet.Text = .TableTitleNet
            txtTableHargaUP.Text = .TableTitleHargaUP
            txtTableNAVUnit.Text = .TableTitleNAVUnit
            txtTableUnitPenyertaan.Text = .TableTitleUnitPenyertaan
            txtTableBiayaPerolehan.Text = .TableTitleBiayaPerolehan
            txtTableAcqCost.Text = .TableTitleAcqCost
            txtTableLRRealisasi.Text = .TableTitleLRRealisasi
            txtTableRealizedPL.Text = .TableTitleRealizedPL
            txtTableSaldoUP.Text = .TableTitleSaldoUP
            txtTableBalanceUnit.Text = .TableTitleBalanceUnit
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rbDefault.Checked Then
            iniSave("DEFAULT")
        ElseIf rbOption1.Checked Then
            iniSave("OPTION1")
        ElseIf rbOption2.Checked Then
            iniSave("OPTION2")
        End If
    End Sub

    Private Sub iniSave(ByVal iniType As String)
        Try
            Dim strFile As String = simpiFile("simpi.ini")
            Dim file As New GlobalINI(strFile)
            file.WriteString(reportSection, "LAYOUT", iniType)
            If iniType.Trim <> "DEFAULT" Then
                file.WriteInteger(reportSection, iniType & " Report Title R", RGBRead(ReportTitle_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Report Title G", RGBRead(ReportTitle_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Report Title B", RGBRead(ReportTitle_B.Text.Trim))
                file.WriteString(reportSection, iniType & " Report Title", txtReportTitle.Text.Trim)

                file.WriteInteger(reportSection, iniType & " Client R", RGBRead(Client_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Client G", RGBRead(Client_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Client B", RGBRead(Client_B.Text.Trim))
                file.WriteString(reportSection, iniType & " period", txtPeriod.Text.Trim)

                file.WriteInteger(reportSection, iniType & " NAV/Unit R", RGBRead(NAVUnit_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " NAV/Unit G", RGBRead(NAVUnit_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " NAV/Unit B", RGBRead(NAVUnit_B.Text.Trim))
                file.WriteString(reportSection, iniType & " NAV/Unit", txtNAVUnit.Text.Trim)

                file.WriteInteger(reportSection, iniType & " Report Line R", RGBRead(ReportLine_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Report Line G", RGBRead(ReportLine_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Report Line B", RGBRead(ReportLine_B.Text.Trim))

                file.WriteInteger(reportSection, iniType & " Portfolio R", RGBRead(Portfolio_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Portfolio G", RGBRead(Portfolio_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Portfolio B", RGBRead(Portfolio_B.Text.Trim))

                file.WriteInteger(reportSection, iniType & " Summary R", RGBRead(Summary_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Summary G", RGBRead(Summary_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Summary B", RGBRead(Summary_B.Text.Trim))
                file.WriteString(reportSection, iniType & " Summary", txtSummary.Text.Trim)

                file.WriteInteger(reportSection, iniType & " Summary Line R", RGBRead(SummaryLine_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Summary Line G", RGBRead(SummaryLine_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Summary Line B", RGBRead(SummaryLine_B.Text.Trim))

                file.WriteInteger(reportSection, iniType & " Summary Items R", RGBRead(SummaryItems_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Summary Items G", RGBRead(SummaryItems_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Summary Items B", RGBRead(SummaryItems_B.Text.Trim))
                file.WriteString(reportSection, iniType & " Summary Items Total Redemption", txtSummaryItemsTotalRedemption.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Acq Cost", txtSummaryItemsAcqCost.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Redemption PL", txtSummaryItemsRedemptionPL.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Dividend", txtSummaryItemsDividend.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Realized PL", txtSummaryItemsRealizedPL.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Last Investment Value", txtSummaryItemsLastInvestmentValue.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Last Acq Cost", txtSummaryItemsLastAcqCost.Text.Trim)
                file.WriteString(reportSection, iniType & " Summary Items Unrealized PL", txtSummaryItemsUnrealizedPL.Text.Trim)

                file.WriteInteger(reportSection, iniType & " Chart Title R", RGBRead(ChartTitle_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Chart Title G", RGBRead(ChartTitle_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Chart Title B", RGBRead(ChartTitle_B.Text.Trim))
                file.WriteString(reportSection, iniType & " Investment Growth", txtInvestmentGrowth.Text.Trim)

                file.WriteInteger(reportSection, iniType & " Chart Border R", RGBRead(ChartBorder_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Chart Border G", RGBRead(ChartBorder_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Chart Border B", RGBRead(ChartBorder_B.Text.Trim))
                file.WriteBoolean(reportSection, iniType & " Chart Border", chkChartBorder.Checked)

                file.WriteInteger(reportSection, iniType & " Chart Line R", RGBRead(ChartLine_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Chart Line G", RGBRead(ChartLine_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Chart Line B", RGBRead(ChartLine_B.Text.Trim))
                file.WriteString(reportSection, iniType & " Chart Label", txtChartLabel.Text.Trim)

                file.WriteInteger(reportSection, iniType & " Table Header R", RGBRead(TableHeader_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Header G", RGBRead(TableHeader_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Header B", RGBRead(TableHeader_B.Text.Trim))

                file.WriteInteger(reportSection, iniType & " Table Line R", RGBRead(TableLine_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Line G", RGBRead(TableLine_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Line B", RGBRead(TableLine_B.Text.Trim))

                file.WriteInteger(reportSection, iniType & " Table Items R", RGBRead(TableItems_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Items G", RGBRead(TableItems_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Items B", RGBRead(TableItems_B.Text.Trim))

                file.WriteInteger(reportSection, iniType & " Table Title R", RGBRead(TableTitle_R.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Title G", RGBRead(TableTitle_G.Text.Trim))
                file.WriteInteger(reportSection, iniType & " Table Title B", RGBRead(TableTitle_B.Text.Trim))
                file.WriteString(reportSection, iniType & " Table Tanggal", txtTableTanggal.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Date", txtTableTanggal.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Uraian", txtTableUraian.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Description", txtTableDescription.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Nilai Transaksi", txtTableNilaiTransaksi.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Gross", txtTableGross.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Net", txtTableNet.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Harga/UP", txtTableHargaUP.Text.Trim)
                file.WriteString(reportSection, iniType & " Table NAV/Unit", txtTableNAVUnit.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Unit Penyertaan", txtTableUnitPenyertaan.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Biaya Perolehan", txtTableBiayaPerolehan.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Acq. Cost", txtTableAcqCost.Text.Trim)
                file.WriteString(reportSection, iniType & " Table L/R Realisasi", txtTableLRRealisasi.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Realized P/L", txtTableRealizedPL.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Saldo (UP)", txtTableSaldoUP.Text.Trim)
                file.WriteString(reportSection, iniType & " Table Balance (Unit)", txtTableBalanceUnit.Text.Trim)
            End If

            Close()
        Catch ex As Exception
            ExceptionMessage.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#Region "setting"
    Private Sub colorSet()
        If cd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If rbReportTitle.Checked Then
                txtColorReportTitle.BackColor = cd.Color
                ReportTitle_R.Text = RGBWrite("R", cd.Color.R)
                ReportTitle_G.Text = RGBWrite("G", cd.Color.G)
                ReportTitle_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbReportLine.Checked Then
                txtColorReportLine.BackColor = cd.Color
                ReportLine_R.Text = RGBWrite("R", cd.Color.R)
                ReportLine_G.Text = RGBWrite("G", cd.Color.G)
                ReportLine_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbClient.Checked Then
                txtColorClient.BackColor = cd.Color
                Client_R.Text = RGBWrite("R", cd.Color.R)
                Client_G.Text = RGBWrite("G", cd.Color.G)
                Client_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbNAVUnit.Checked Then
                txtColorNAVUnit.BackColor = cd.Color
                NAVUnit_R.Text = RGBWrite("R", cd.Color.R)
                NAVUnit_G.Text = RGBWrite("G", cd.Color.G)
                NAVUnit_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbPortfolio.Checked Then
                txtColorPortfolio.BackColor = cd.Color
                Portfolio_R.Text = RGBWrite("R", cd.Color.R)
                Portfolio_G.Text = RGBWrite("G", cd.Color.G)
                Portfolio_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbSummary.Checked Then
                txtColorSummary.BackColor = cd.Color
                Summary_R.Text = RGBWrite("R", cd.Color.R)
                Summary_G.Text = RGBWrite("G", cd.Color.G)
                Summary_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbSummaryLine.Checked Then
                txtColorSummaryLine.BackColor = cd.Color
                SummaryLine_R.Text = RGBWrite("R", cd.Color.R)
                SummaryLine_G.Text = RGBWrite("G", cd.Color.G)
                SummaryLine_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbSummaryItems.Checked Then
                txtColorSummaryItems.BackColor = cd.Color
                SummaryItems_R.Text = RGBWrite("R", cd.Color.R)
                SummaryItems_G.Text = RGBWrite("G", cd.Color.G)
                SummaryItems_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbChartTitle.Checked Then
                txtColorChartTitle.BackColor = cd.Color
                ChartTitle_R.Text = RGBWrite("R", cd.Color.R)
                ChartTitle_G.Text = RGBWrite("G", cd.Color.G)
                ChartTitle_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbChartBorder.Checked Then
                txtColorChartBorder.BackColor = cd.Color
                ChartBorder_R.Text = RGBWrite("R", cd.Color.R)
                ChartBorder_G.Text = RGBWrite("G", cd.Color.G)
                ChartBorder_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbChartLine.Checked Then
                txtColorChartLine.BackColor = cd.Color
                ChartLine_R.Text = RGBWrite("R", cd.Color.R)
                ChartLine_G.Text = RGBWrite("G", cd.Color.G)
                ChartLine_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbTableHeader.Checked Then
                txtColorTableHeader.BackColor = cd.Color
                TableHeader_R.Text = RGBWrite("R", cd.Color.R)
                TableHeader_G.Text = RGBWrite("G", cd.Color.G)
                TableHeader_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbTableLine.Checked Then
                txtColorTableLine.BackColor = cd.Color
                TableLine_R.Text = RGBWrite("R", cd.Color.R)
                TableLine_G.Text = RGBWrite("G", cd.Color.G)
                TableLine_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbTableItems.Checked Then
                txtColorTableItems.BackColor = cd.Color
                TableItems_R.Text = RGBWrite("R", cd.Color.R)
                TableItems_G.Text = RGBWrite("G", cd.Color.G)
                TableItems_B.Text = RGBWrite("B", cd.Color.B)
            ElseIf rbTableTitle.Checked Then
                txtColorTableTitle.BackColor = cd.Color
                TableTitle_R.Text = RGBWrite("R", cd.Color.R)
                TableTitle_G.Text = RGBWrite("G", cd.Color.G)
                TableTitle_B.Text = RGBWrite("B", cd.Color.B)
            End If
        End If
    End Sub

    Private Sub rbReportTitle_Click(sender As Object, e As EventArgs) Handles rbReportTitle.Click
        colorSet()
    End Sub

    Private Sub rbClient_Click(sender As Object, e As EventArgs) Handles rbClient.Click
        colorSet()
    End Sub

    Private Sub rbNAVUnit_Click(sender As Object, e As EventArgs) Handles rbNAVUnit.Click
        colorSet()
    End Sub

    Private Sub rbPortfolio_Click(sender As Object, e As EventArgs) Handles rbPortfolio.Click
        colorSet()
    End Sub

    Private Sub rbSummary_Click(sender As Object, e As EventArgs) Handles rbSummary.Click
        colorSet()
    End Sub

    Private Sub rbSummaryLine_Click(sender As Object, e As EventArgs) Handles rbSummaryLine.Click
        colorSet()
    End Sub

    Private Sub rbSummaryItems_Click(sender As Object, e As EventArgs) Handles rbSummaryItems.Click
        colorSet()
    End Sub

    Private Sub rbChartTitle_Click(sender As Object, e As EventArgs) Handles rbChartTitle.Click
        colorSet()
    End Sub

    Private Sub rbChartBorder_Click(sender As Object, e As EventArgs) Handles rbChartBorder.Click
        colorSet()
    End Sub

    Private Sub chkChartBorder_Click(sender As Object, e As EventArgs) Handles chkChartBorder.Click
        If chkChartBorder.Checked Then chkChartBorder.Text = "Y" Else chkChartBorder.Text = "N"
    End Sub

    Private Sub rbChartLine_Click(sender As Object, e As EventArgs) Handles rbChartLine.Click
        colorSet()
    End Sub

    Private Sub rbTableHeader_Click(sender As Object, e As EventArgs) Handles rbTableHeader.Click
        colorSet()
    End Sub

    Private Sub rbTableLine_Click(sender As Object, e As EventArgs) Handles rbTableLine.Click
        colorSet()
    End Sub

    Private Sub rbTableItems_Click(sender As Object, e As EventArgs) Handles rbTableItems.Click
        colorSet()
    End Sub

    Private Sub rbTableTitle_Click(sender As Object, e As EventArgs) Handles rbTableTitle.Click
        colorSet()
    End Sub

    Private Sub rbReportLine_Click(sender As Object, e As EventArgs) Handles rbReportLine.Click
        colorSet()
    End Sub

    Private Sub rbReportTitle_CheckedChanged(sender As Object, e As EventArgs) Handles rbReportTitle.CheckedChanged

    End Sub

#End Region

End Class