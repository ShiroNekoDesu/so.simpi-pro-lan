Imports simpi.GlobalUtilities
Imports simpi.CoreData
Imports simpi.MasterPortfolio
Imports simpi.GlobalConnection

Public Class ReportFundSheetCPF
    Dim objPortfolio As New MasterPortfolio
    Dim objNAV As New PortfolioNAV
    Public pdfLayout As New pdfColor
    Dim reportSection As String = "Report Fund Sheet CPF"
    Public Property frm As ReportFundSheetCPF
    Private Sub ReportSetting()
        Dim frm As New ReportFundSheetCPFSetting
        frm.frm = Me
        frm.Show()
        frm.FormLoad()
    End Sub

#Region "pdf"
    Structure pdfColor
        Public layoutType As String
        Public Header_R As Integer
        Public Header_G As Integer
        Public Header_B As Integer
        Public Header As String

        Public Title_R As Integer
        Public Title_G As Integer
        Public Title_B As Integer
        Public Title As String

        Public HeaderLine_R As Integer
        Public HeaderLine_G As Integer
        Public HeaderLine_B As Integer

        Public NAB_R As Integer
        Public NAB_G As Integer
        Public NAB_B As Integer
        Public NAB As String

        Public ChartTitle_R As Integer
        Public ChartTitle_G As Integer
        Public ChartTitle_B As Integer
        Public ChartTitle As String

        Public SummaryLine_R As Integer
        Public SummaryLine_G As Integer
        Public SummaryLine_B As Integer
        Public SummaryItems_R As Integer
        Public SummaryItems_G As Integer
        Public SummaryItems_B As Integer
        Public SummaryItemsTanggalLaporan As String
        Public SummaryItemsBankKustodian As String
        Public SummaryItemsTanggalPeluncuran As String
        Public SummaryItemstanggalJatuhTempo As String
        Public SummaryItemsTotalAUM As String
        Public SummaryItemsMataUang As String
        Public SummaryItemsImbalJasaManajerInvestasi As String
        Public SummaryItemsImbalJasaBankKustodian As String
        Public SummaryItemsBiayaPembelian As String
        Public SummaryItemsBiayaPenjualanKembali As String
        Public SummaryItemsBiayaPengalihan As String
        Public SummaryItemsNote As String

        Public Subtitle_R As Integer
        Public Subtitle_G As Integer
        Public Subtitle_B As Integer
        Public Subtitle As String

        Public TanggalPenting_R As Integer
        Public TanggalPenting_G As Integer
        Public TanggalPenting_B As Integer
        Public TanggalPenting As String
        Public PembagianDividendTerakhir As String
        Public PembagianDividendBerikutnya As String
        Public UnderlyingAsset As String

        Public TanggalPentingLine_R As Integer
        Public TanggalPentingLine_G As Integer
        Public TanggalPentingLine_B As Integer

        Public TableHeader_R As Integer
        Public TableHeader_G As Integer
        Public TableHeader_B As Integer
        Public TableHeader As String

        Public TableTitle_R As Integer
        Public TableTitle_G As Integer
        Public TableTitle_B As Integer
        Public Table1Bln As String
        Public Table3Bln As String
        Public Table6Bln As String
        Public Table1Thn As String
        Public TableDariAwalTahun As String
        Public TableSejakPembentukan As String
        Public TableIndikasiRateDividenTetap As String

        Public FooterTitle1_R As Integer
        Public FooterTitle1_G As Integer
        Public FooterTitle1_B As Integer
        Public Footer1 As String

        Public FooterTitle2_R As Integer
        Public FooterTitle2_G As Integer
        Public FooterTitle2_B As Integer
        Public Footer2 As String

        Public TableLine_R As Integer
        Public TableLine_G As Integer
        Public TableLine_B As Integer

    End Structure

    Public Sub pdfColorDefault()
        pdfLayout.layoutType = "DEFAULT"
        pdfLayout.Header_R = 0
        pdfLayout.Header_G = 0
        pdfLayout.Header_B = 205
        pdfLayout.Header = "Fund Fact Sheet"

        pdfLayout.Title_R = 0
        pdfLayout.Title_G = 0
        pdfLayout.Title_B = 205
        pdfLayout.Title = "Mandiri Protected Growth Dollar 3 "

        pdfLayout.ChartTitle_R = 0
        pdfLayout.ChartTitle_G = 0
        pdfLayout.ChartTitle_B = 205
        pdfLayout.ChartTitle = "kinerja Reksa Dana "

        pdfLayout.HeaderLine_R = 255
        pdfLayout.HeaderLine_G = 255
        pdfLayout.HeaderLine_B = 0

        pdfLayout.NAB_R = 0
        pdfLayout.NAB_G = 0
        pdfLayout.NAB_B = 205
        pdfLayout.NAB = "NAB/Unit "

        pdfLayout.SummaryLine_R = 255
        pdfLayout.SummaryLine_G = 255
        pdfLayout.SummaryLine_B = 0

        pdfLayout.SummaryItems_R = 0
        pdfLayout.SummaryItems_G = 0
        pdfLayout.SummaryItems_B = 205
        pdfLayout.SummaryItemsTanggalLaporan = "Tanggal Laporan : "
        pdfLayout.SummaryItemsBankKustodian = "Bank Kustodian : "
        pdfLayout.SummaryItemsTanggalPeluncuran = "Tanggal Peluncuran : "
        pdfLayout.SummaryItemstanggalJatuhTempo = "Tanggal Jatuh Tempo : "
        pdfLayout.SummaryItemsTotalAUM = "Total AUM : "
        pdfLayout.SummaryItemsMataUang = "Mata Uang : "
        pdfLayout.SummaryItemsImbalJasaManajerInvestasi = "Imbal Jasa Manajer Investasi : "
        pdfLayout.SummaryItemsImbalJasaBankKustodian = "Imbal Jasa Bank Kustodian: "
        pdfLayout.SummaryItemsBiayaPembelian = "Biaya Pembelian : "
        pdfLayout.SummaryItemsBiayaPenjualanKembali = "Biaya Penjualan Kembali : "
        pdfLayout.SummaryItemsBiayaPengalihan = "Biaya Pengaliah : "
        pdfLayout.SummaryItemsNote = "Note :: "

        pdfLayout.Subtitle_R = 0
        pdfLayout.Subtitle_G = 0
        pdfLayout.Subtitle_B = 205
        pdfLayout.Subtitle = "Kebijakan Investasi "

        pdfLayout.TanggalPenting_R = 0
        pdfLayout.TanggalPenting_G = 0
        pdfLayout.TanggalPenting_B = 205
        pdfLayout.TanggalPenting = "Tanggal Penting"
        pdfLayout.PembagianDividendTerakhir = "Pembagian Devidend Terakhir"
        pdfLayout.PembagianDividendBerikutnya = "Pembagian Devidend Berikutnya"
        pdfLayout.UnderlyingAsset = "Underlying Asset"

        pdfLayout.TanggalPentingLine_R = 255
        pdfLayout.TanggalPentingLine_G = 255
        pdfLayout.TanggalPentingLine_B = 0


        pdfLayout.TableHeader_R = 0
        pdfLayout.TableHeader_G = 0
        pdfLayout.TableHeader_B = 205
        pdfLayout.TableHeader = "Kinerja Historis (%)"

        pdfLayout.TableTitle_R = 0
        pdfLayout.TableTitle_G = 0
        pdfLayout.TableTitle_B = 205
        pdfLayout.Table1Bln = "1 Bulan"
        pdfLayout.Table3Bln = "3 Bulan"
        pdfLayout.Table6Bln = "6 Bulan"
        pdfLayout.Table1Thn = "1 Tahun"
        pdfLayout.TableDariAwalTahun = "Dari Awal Tahun"
        pdfLayout.TableSejakPembentukan = "Sejak Pembentukan"
        pdfLayout.TableIndikasiRateDividenTetap = "Indikasi Rate Dividen Tetap"

        pdfLayout.FooterTitle1_R = 0
        pdfLayout.FooterTitle1_G = 0
        pdfLayout.FooterTitle1_B = 205
        pdfLayout.Footer1 = "Tujuan Investasi"

        pdfLayout.FooterTitle2_R = 0
        pdfLayout.FooterTitle2_G = 0
        pdfLayout.FooterTitle2_B = 205
        pdfLayout.Footer2 = "Tentang Mandiri Investasi"

        pdfLayout.TableLine_R = 255
        pdfLayout.TableLine_G = 255
        pdfLayout.TableLine_B = 0

    End Sub
    Public Sub pdfSetting()
        Try
            Dim strFile As String = simpiFile("simpi.ini")
            If GlobalFileWindows.FileExists(strFile) Then
                Dim file As New GlobalINI(strFile)
                Dim iniType As String = file.GetString(reportSection, "LAYOUT", "")
                If iniType = "" Or iniType = "DEFAULT" Then
                    pdfColorDefault()
                Else
                    pdfLayout.layoutType = iniType
                    pdfLayout.Header_R = file.GetInteger(reportSection, iniType & " Header R", 0)
                    pdfLayout.Header_G = file.GetInteger(reportSection, iniType & " Header G", 0)
                    pdfLayout.Header_B = file.GetInteger(reportSection, iniType & " Header B", 0)
                    pdfLayout.Header = file.GetString(reportSection, iniType & " Header", "")

                    pdfLayout.Title_R = file.GetInteger(reportSection, iniType & " Title R", 0)
                    pdfLayout.Title_G = file.GetInteger(reportSection, iniType & " Title G", 0)
                    pdfLayout.Title_B = file.GetInteger(reportSection, iniType & " Title B", 0)
                    pdfLayout.Title = file.GetString(reportSection, iniType & " Title", "")

                    pdfLayout.HeaderLine_R = file.GetInteger(reportSection, iniType & " Header Line R", 0)
                    pdfLayout.HeaderLine_G = file.GetInteger(reportSection, iniType & " Header Line G", 0)
                    pdfLayout.HeaderLine_B = file.GetInteger(reportSection, iniType & " Header Line B", 0)

                    pdfLayout.NAB_R = file.GetInteger(reportSection, iniType & " NAB R", 0)
                    pdfLayout.NAB_G = file.GetInteger(reportSection, iniType & " NAB G", 0)
                    pdfLayout.NAB_B = file.GetInteger(reportSection, iniType & " NAB B", 0)
                    pdfLayout.NAB = file.GetString(reportSection, iniType & " NAB", "")

                    pdfLayout.SummaryLine_R = file.GetInteger(reportSection, iniType & " Summary Line R", 0)
                    pdfLayout.SummaryLine_G = file.GetInteger(reportSection, iniType & " Summary Line G", 0)
                    pdfLayout.SummaryLine_B = file.GetInteger(reportSection, iniType & " Summary Line B", 0)

                    pdfLayout.SummaryItems_R = file.GetInteger(reportSection, iniType & " Summary Items R", 0)
                    pdfLayout.SummaryItems_G = file.GetInteger(reportSection, iniType & " Summary Items G", 0)
                    pdfLayout.SummaryItems_B = file.GetInteger(reportSection, iniType & " Summary Items B", 0)
                    pdfLayout.SummaryItemsTanggalLaporan = file.GetString(reportSection, iniType & " Summary Items Tanggal Laporan", "")
                    pdfLayout.SummaryItemsBankKustodian = file.GetString(reportSection, iniType & " Summary Items Bank Kustodian", "")
                    pdfLayout.SummaryItemsTanggalPeluncuran = file.GetString(reportSection, iniType & " Summary Items Tanggal Peluncuran", "")
                    pdfLayout.SummaryItemstanggalJatuhTempo = file.GetString(reportSection, iniType & " Summary Items Tanggal Jatuh Tempo", "")
                    pdfLayout.SummaryItemsTotalAUM = file.GetString(reportSection, iniType & " Summary Items Total AUM", "")
                    pdfLayout.SummaryItemsMataUang = file.GetString(reportSection, iniType & " Summary Items Mata Uang", "")
                    pdfLayout.SummaryItemsImbalJasaManajerInvestasi = file.GetString(reportSection, iniType & " Summary Items Imbal Jasa Manajer Investasi", "")
                    pdfLayout.SummaryItemsImbalJasaBankKustodian = file.GetString(reportSection, iniType & " Summary Items Imbal Jasa Bank Kustodian", "")
                    pdfLayout.SummaryItemsBiayaPembelian = file.GetString(reportSection, iniType & " Summary Items Biaya Pembelian", "")
                    pdfLayout.SummaryItemsBiayaPenjualanKembali = file.GetString(reportSection, iniType & " Summary Items Biaya Penjualan Kembali", "")
                    pdfLayout.SummaryItemsBiayaPengalihan = file.GetString(reportSection, iniType & "Summary Items Biaya Pengalihan", "")
                    pdfLayout.SummaryItemsNote = file.GetString(reportSection, iniType & " Summary Items Note", "")

                    pdfLayout.Subtitle_R = file.GetInteger(reportSection, iniType & " Sub Title R", 0)
                    pdfLayout.Subtitle_G = file.GetInteger(reportSection, iniType & " Sub Title G", 0)
                    pdfLayout.Subtitle_B = file.GetInteger(reportSection, iniType & " Sub Title B", 0)
                    pdfLayout.Subtitle = file.GetString(reportSection, iniType & " Sub Title", "")

                    pdfLayout.TanggalPenting_R = file.GetInteger(reportSection, iniType & " Tanggal Penting R", 0)
                    pdfLayout.TanggalPenting_G = file.GetInteger(reportSection, iniType & " Tanggal Penting G", 0)
                    pdfLayout.TanggalPenting_B = file.GetInteger(reportSection, iniType & " Tanggal Penting B", 0)
                    pdfLayout.TanggalPenting = file.GetString(reportSection, iniType & " Tanggal Penting", "")
                    pdfLayout.PembagianDividendTerakhir = file.GetString(reportSection, iniType & " Pembagian Dividend Terakhir", "")
                    pdfLayout.PembagianDividendBerikutnya = file.GetString(reportSection, iniType & " Pembagian Dividend Berikutnya", "")
                    pdfLayout.UnderlyingAsset = file.GetString(reportSection, iniType & " Underlying Asset", "")

                    pdfLayout.TanggalPentingLine_R = file.GetInteger(reportSection, iniType & " Tanggal Penting Line R", 0)
                    pdfLayout.TanggalPentingLine_G = file.GetInteger(reportSection, iniType & " Tanggal Penting Line G", 0)
                    pdfLayout.TanggalPentingLine_B = file.GetInteger(reportSection, iniType & " Tanggal Penting Line B", 0)

                    pdfLayout.TableHeader_R = file.GetInteger(reportSection, iniType & " Pie Title 1 R", 0)
                    pdfLayout.TableHeader_G = file.GetInteger(reportSection, iniType & " Pie Title 1 G", 0)
                    pdfLayout.TableHeader_B = file.GetInteger(reportSection, iniType & " Pie Title 1 B", 0)
                    pdfLayout.TableHeader = file.GetString(reportSection, iniType & " Table Header", "")

                    pdfLayout.TableTitle_R = file.GetInteger(reportSection, iniType & " Pie Border 1 R", 0)
                    pdfLayout.TableTitle_G = file.GetInteger(reportSection, iniType & " Pie Border 1 G", 0)
                    pdfLayout.TableTitle_B = file.GetInteger(reportSection, iniType & " Pie Border 1 B", 0)
                    pdfLayout.Table1Bln = file.GetString(reportSection, iniType & " Table Title 1 Bln", "")
                    pdfLayout.Table3Bln = file.GetString(reportSection, iniType & " Table Title 3 Bln", "")
                    pdfLayout.Table6Bln = file.GetString(reportSection, iniType & " Table Title 6 Bln", "")
                    pdfLayout.Table1Thn = file.GetString(reportSection, iniType & " Table Title 1 Tahun", "")
                    pdfLayout.TableDariAwalTahun = file.GetString(reportSection, iniType & " Table Title Dari Awal Tahun", "")
                    pdfLayout.TableSejakPembentukan = file.GetString(reportSection, iniType & " Table Title Sejak Pembukuan", "")
                    pdfLayout.TableIndikasiRateDividenTetap = file.GetString(reportSection, iniType & " Table Title Indikasi Rate Dividen Tetap", "")

                    pdfLayout.FooterTitle1_R = file.GetInteger(reportSection, iniType & " Footer Title 1 R", 0)
                    pdfLayout.FooterTitle1_G = file.GetInteger(reportSection, iniType & " Footer Title 1 G", 0)
                    pdfLayout.FooterTitle1_B = file.GetInteger(reportSection, iniType & " Footer Title 1 B", 0)
                    pdfLayout.Footer1 = file.GetString(reportSection, iniType & " Footer Title 1", "")

                    pdfLayout.FooterTitle2_R = file.GetInteger(reportSection, iniType & " Footer Title 2 R", 0)
                    pdfLayout.FooterTitle2_G = file.GetInteger(reportSection, iniType & " Footer Title 2 G", 0)
                    pdfLayout.FooterTitle2_B = file.GetInteger(reportSection, iniType & " Footer Title 2 B", 0)
                    pdfLayout.Footer2 = file.GetString(reportSection, iniType & " Footer Title 2", "")

                    pdfLayout.TableLine_R = file.GetInteger(reportSection, iniType & " Table Line R", 0)
                    pdfLayout.TableLine_G = file.GetInteger(reportSection, iniType & " Table Line G", 0)
                    pdfLayout.TableLine_B = file.GetInteger(reportSection, iniType & " Table Line B", 0)
                End If
            Else
                pdfColorDefault()
            End If
        Catch ex As Exception
            pdfColorDefault()
        End Try
    End Sub
#End Region

    Private Sub ReportFundSheetCPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetInstrumentUser()
        GetParameterInstrumentType()
        dtAs.Value = Now

        objPortfolio.UserAccess = objAccess
        objNAV.UserAccess = objAccess
        pdfSetting()

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

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        pdfSetting()
        Dim strFile As String = ""
        Dim strLayout As String = ""
        Dim myBrush As New SolidBrush(Color.FromArgb(0, 61, 121))
        Dim detailBrush As New SolidBrush(Color.Black)
        Dim headerBrush As New SolidBrush(Color.White)
        Dim koordX As Single = 40, koordY As Single = 35
        Dim fontType = "Calibri", fontSize = 8
        Dim layout = Image.FromFile("D:\simpiPRO\so.simpi-pro\bin\Debug\Template\portrait.jpg")
        With C1PdfDocument1
            .Clear()
            .PaperKind = Printing.PaperKind.A4
            Dim rc As RectangleF = .PageRectangle
            Dim sf As New StringFormat()
            sf.Alignment = StringAlignment.Center
            .DrawImage(layout, rc)
            rc = New RectangleF(koordX, koordY, 150, fontSize)
            .DrawStringRtf("{\b " & pdfLayout.Header & ",} Februari 2018 ", New Font(fontType, 10), New SolidBrush(Color.FromArgb(pdfLayout.Header_R, pdfLayout.Header_G, pdfLayout.Header_B)), rc)
            koordY += 12
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.HeaderLine_R, pdfLayout.HeaderLine_G, pdfLayout.HeaderLine_B)), New PointF(koordX, koordY), New PointF(koordX + 300, koordY))
            koordY += 6
            rc = New RectangleF(koordX, koordY, 300, fontSize)
            .DrawStringRtf("{\b " + pdfLayout.Title + "}", New Font(fontType, 20), New SolidBrush(Color.FromArgb(pdfLayout.Title_R, pdfLayout.Title_G, pdfLayout.Title_B)), rc)
            .DrawString("Reksa Dana Terproteksi", New Font(fontType, 10), New SolidBrush(Color.FromArgb(pdfLayout.Title_R, pdfLayout.Title_G, pdfLayout.Title_B)), New PointF(koordX, koordY + 20))
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.SummaryLine_R, pdfLayout.SummaryLine_G, pdfLayout.SummaryLine_B)), New PointF(koordX + 145, koordY + 50), New PointF(koordX + 145, koordY + 500))

            .DrawString(pdfLayout.NAB + "USD 0.99", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.NAB_R, pdfLayout.NAB_G, pdfLayout.NAB_B)), New PointF(koordX, koordY + 50))
            .DrawString(pdfLayout.SummaryItemsTanggalLaporan, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 65))
            .DrawString("28-Februari-2018", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 75))
            .DrawString(pdfLayout.SummaryItemsBankKustodian, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 90))
            .DrawString("DBS Indonesia", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 100))
            .DrawString(pdfLayout.SummaryItemsTanggalPeluncuran, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 115))
            .DrawString("12-Agustus-2016", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 125))
            .DrawString(pdfLayout.SummaryItemstanggalJatuhTempo, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 140))
            .DrawString("12-Agustus-2021", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 150))
            .DrawString(pdfLayout.SummaryItemsTotalAUM, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 165))
            .DrawString("USD 4,52 Juta", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 175))
            .DrawString(pdfLayout.SummaryItemsMataUang, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 190))
            .DrawString("US Dollar (USD)", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 200))
            .DrawString(pdfLayout.SummaryItemsImbalJasaManajerInvestasi, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 215))
            .DrawString("Maks 4.00% p.a.", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 225))
            .DrawString(pdfLayout.SummaryItemsImbalJasaBankKustodian, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 240))
            .DrawString("Maks 0,15% p.a.", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 250))
            .DrawString(pdfLayout.SummaryItemsBiayaPembelian, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 265))
            .DrawString("-", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 280))
            .DrawString(pdfLayout.SummaryItemsBiayaPenjualanKembali, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 295))
            .DrawString("Maks 2.00%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 305))
            .DrawString(pdfLayout.SummaryItemsBiayaPengalihan, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 320))
            .DrawString("-", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 330))
            .DrawString(pdfLayout.SummaryItemsNote, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), New PointF(koordX, koordY + 345))
            Dim rc2 As New Rectangle(koordX, koordY + 355, 145, koordY + 375)
            Dim text = "*formulir pencairan lebih awal harus diterima oleh agen penjualan paling lambat T-5 dari tanggal pencairan lebih awal"
            .DrawString(text, New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.SummaryItems_R, pdfLayout.SummaryItems_G, pdfLayout.SummaryItems_B)), rc2)
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.SummaryLine_R, pdfLayout.SummaryLine_G, pdfLayout.SummaryLine_B)), New PointF(koordX, koordY + 510), New PointF(koordX + 500, koordY + 510))
            'belum ada di setting
            .DrawString(pdfLayout.Footer1, New Font(fontType, 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.FooterTitle1_R, pdfLayout.FooterTitle1_G, pdfLayout.FooterTitle1_B)), New PointF(koordX, koordY + 520))
            text = "REKSA DANA MANDIRI GROWTH DOLLAR 3 bertujuan untuk memberikan proteksi sebesar minimum 100%(seratus persen) terhadap pokok Investasi atas Unit Penyertaan pada tanggal jatuh tempo serta memberikan pemegamngan unit penyertaan potensi imbal hasil yang tetap dari efek bersifat utang yang diterbitkan oleh pemerintah republik indonesia dan/atau korporasi berbadan hukum indonesia yang telah dijual dalam penawaran umum dan/atau diperdangangkan di bursa efek baik dalam maupun di luar negeri yang sudah mendapat peringkat dari perusahaan pemeringkatan efek yang terdaftar di OJK dan masuk dalam kategori layak investasi (investment grade),dalam dedominasi dollar amerika serikat,yang diivenstasikan pada tanggal emisi"
            Dim rc6 As New Rectangle(koordX, koordY + 540, 500, koordY + 20)
            .DrawString(text, New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.FooterTitle1_R, pdfLayout.FooterTitle1_G, pdfLayout.FooterTitle1_B)), rc6)
            .DrawString(pdfLayout.Footer2, New Font(fontType, 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.FooterTitle2_R, pdfLayout.FooterTitle2_G, pdfLayout.FooterTitle2_B)), New PointF(koordX, koordY + 600))
            text = "PT Mandiri manajemen investasi(Mandiri investasi) merupakan anak perusahan dari PT Mandiri serkuritas yang didirikan pada tanggal 28 desember 2004.PT Mandiri sekuritas sendiri adalah perusahaan sekuritas terkemuka di indonesia dan merupakan anak perusahaan dari PT Bank Mandiri (Persero) Tbk, Bank terbesar milik negara. Mandiri Investasi dan/atau pendahulunya telah mengelola portofolio investasi sejak tahun 1993, Mandiri Investasi adalah Manajer Investasi terbesar di Indonesia dengan total dana kelola sebesar Rp 51,47 Triliun (per 28 Februari 2018)"
            Dim rc7 As New Rectangle(koordX, koordY + 620, 500, koordY + 20)
            .DrawString(text, New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.FooterTitle2_R, pdfLayout.FooterTitle2_G, pdfLayout.FooterTitle2_B)), rc7)


            koordX += 150
            .DrawString(pdfLayout.Subtitle, New Font(fontType, 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.Subtitle_R, pdfLayout.Subtitle_G, pdfLayout.Subtitle_B)), New PointF(koordX + 20, koordY + 50))
            .DrawString("Warrant", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.Subtitle_R, pdfLayout.Subtitle_G, pdfLayout.Subtitle_B)), New PointF(koordX + 20, koordY + 70))
            .DrawString(": 0%-30%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.Subtitle_R, pdfLayout.Subtitle_G, pdfLayout.Subtitle_B)), New PointF(koordX + 200, koordY + 70))
            .DrawString("Surat utang Pemerintah Indonesia", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.Subtitle_R, pdfLayout.Subtitle_G, pdfLayout.Subtitle_B)), New PointF(koordX + 20, koordY + 80))
            .DrawString(": 70%-100%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.Subtitle_R, pdfLayout.Subtitle_G, pdfLayout.Subtitle_B)), New PointF(koordX + 200, koordY + 80))
            .DrawString("Kierja Reksa Dana", New Font(fontType, 12, FontStyle.Bold), myBrush, New PointF(koordX + 20, koordY + 100))
            .DrawString(pdfLayout.TanggalPenting, New Font(fontType, 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), New PointF(koordX, koordY + 345))
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.TanggalPentingLine_R, pdfLayout.TanggalPentingLine_G, pdfLayout.TanggalPentingLine_B)), New PointF(koordX, koordY + 360), New PointF(koordX + 170, koordY + 360))
            .DrawString(pdfLayout.PembagianDividendTerakhir, New Font(fontType, 10, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), New PointF(koordX + 20, koordY + 370))
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.TanggalPentingLine_R, pdfLayout.TanggalPentingLine_G, pdfLayout.TanggalPentingLine_B)), New PointF(koordX + 20, koordY + 385), New PointF(koordX + 170, koordY + 385))
            .DrawString("29 September 2017", New Font(fontType, 10), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), New PointF(koordX + 50, koordY + 385))
            .DrawString(pdfLayout.PembagianDividendBerikutnya, New Font(fontType, 10, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), New PointF(koordX + 20, koordY + 400))
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.TanggalPentingLine_R, pdfLayout.TanggalPentingLine_G, pdfLayout.TanggalPentingLine_B)), New PointF(koordX + 20, koordY + 415), New PointF(koordX + 170, koordY + 415))
            .DrawString("29 Maret 2018", New Font(fontType, 10), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), New PointF(koordX + 60, koordY + 415))
            .DrawString(pdfLayout.UnderlyingAsset, New Font(fontType, 10, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), New PointF(koordX + 60, koordY + 430))
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.TanggalPentingLine_R, pdfLayout.TanggalPentingLine_G, pdfLayout.TanggalPentingLine_B)), New PointF(koordX + 20, koordY + 445), New PointF(koordX + 170, koordY + 445))
            text = "Obligasi Sukuk Dollar Pemerintah Indonesia (INDOIS21) berdenominasi Dollar Amerika Serikat"
            Dim rc3 As New Rectangle(koordX + 20, koordY + 450, 145, koordY + 430)
            .DrawString(text, New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TanggalPenting_R, pdfLayout.TanggalPenting_G, pdfLayout.TanggalPenting_B)), rc3, sf)

            koordX += 200
            .DrawString(pdfLayout.TableHeader, New Font(fontType, 12, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableHeader_R, pdfLayout.TableHeader_G, pdfLayout.TableHeader_B)), New PointF(koordX, koordY + 345))
            .DrawLine(New Pen(Color.FromArgb(pdfLayout.TableLine_R, pdfLayout.TableLine_G, pdfLayout.TableLine_B)), New PointF(koordX, koordY + 360), New PointF(koordX + 140, koordY + 360))
            .DrawString(pdfLayout.Table1Bln, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 40, koordY + 370))
            .DrawString(pdfLayout.Table3Bln, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 90, koordY + 370))
            .DrawString("MPGD 3 :", New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX, koordY + 380))
            .DrawString("-2,03%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 40, koordY + 380))
            .DrawString("-1,73%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 90, koordY + 380))
            .DrawString(pdfLayout.Table6Bln, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 40, koordY + 400))
            .DrawString(pdfLayout.Table1Thn, New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 90, koordY + 400))
            .DrawString("MPGD 3 :", New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX, koordY + 410))
            .DrawString("-2,32%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 40, koordY + 410))
            .DrawString("2,56%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 90, koordY + 410))

            Dim rc4 As New Rectangle(koordX + 35, koordY + 435, 30, koordY + 20)
            Dim rc5 As New Rectangle(koordX + 80, koordY + 435, 40, koordY + 20)
            .DrawString(pdfLayout.TableDariAwalTahun, New Font(fontType, 6, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), rc4, sf)
            .DrawString(pdfLayout.TableSejakPembentukan, New Font(fontType, 6, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), rc5, sf)
            .DrawString("MPGD 3 :", New Font(fontType, 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX, koordY + 450))
            .DrawString("-2,44%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 40, koordY + 450))
            .DrawString("1,74%", New Font(fontType, 8), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 90, koordY + 450))
            .DrawString(pdfLayout.TableIndikasiRateDividenTetap, New Font(fontType, 6, FontStyle.Bold), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX, koordY + 470))
            .DrawString("1,25% p.a", New Font(fontType, 6), New SolidBrush(Color.FromArgb(pdfLayout.TableTitle_R, pdfLayout.TableTitle_G, pdfLayout.TableTitle_B)), New PointF(koordX + 90, koordY + 470))

            .Save("D:/Dummy.pdf")
            Process.Start("D:/Dummy.pdf")

        End With
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        ReportSetting()
    End Sub
End Class