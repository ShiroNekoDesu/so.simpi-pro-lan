﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportAccountStatement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportAccountStatement))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchClient = New C1.Win.C1InputPanel.InputButton()
        Me.lblClientCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.dtTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnExcel = New C1.Win.C1InputPanel.InputButton()
        Me.btnPDF = New C1.Win.C1InputPanel.InputButton()
        Me.btnEmail = New C1.Win.C1InputPanel.InputButton()
        Me.btnSetting = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBalance = New C1.Win.C1InputPanel.InputLabel()
        Me.c1pdf = New C1.C1Pdf.C1PdfDocument()
        Me.C1SplitContainer2 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.DBGTransaction = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1SplitterPanel4 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblRedemptionTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemption = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemptionCostTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemptionCost = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblPLRedemptionTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPLRedemption = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDividendTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDividend = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator4 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblPLRealizedTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPLRealized = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator3 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblLastValueTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastValue = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastCostTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastCost = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator5 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblPLUnrealizedTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPLUnrealized = New C1.Win.C1InputPanel.InputLabel()
        Me.C1SplitterPanel5 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.chartNAV = New C1.Win.C1Chart.C1Chart()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbType = New C1.Win.C1InputPanel.InputComboBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer2.SuspendLayout()
        Me.C1SplitterPanel3.SuspendLayout()
        CType(Me.DBGTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel4.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel5.SuspendLayout()
        CType(Me.chartNAV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.btnSearchClient)
        Me.C1InputPanel1.Items.Add(Me.lblClientCode)
        Me.C1InputPanel1.Items.Add(Me.lblClientName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.btnSearchPortfolio)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel1.Items.Add(Me.lblSalesName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtFrom)
        Me.C1InputPanel1.Items.Add(Me.dtTo)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.btnExcel)
        Me.C1InputPanel1.Items.Add(Me.btnPDF)
        Me.C1InputPanel1.Items.Add(Me.btnEmail)
        Me.C1InputPanel1.Items.Add(Me.btnSetting)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblBalance)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1235, 106)
        Me.C1InputPanel1.TabIndex = 4
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "TRANSACTION FILTER"
        '
        'InputLabel10
        '
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Client: "
        Me.InputLabel10.Width = 75
        '
        'btnSearchClient
        '
        Me.btnSearchClient.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchClient.Image = CType(resources.GetObject("btnSearchClient.Image"), System.Drawing.Image)
        Me.btnSearchClient.Name = "btnSearchClient"
        Me.btnSearchClient.ToolTipText = "Search master client"
        '
        'lblClientCode
        '
        Me.lblClientCode.Name = "lblClientCode"
        Me.lblClientCode.Width = 130
        '
        'lblClientName
        '
        Me.lblClientName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Width = 738
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Fund: "
        Me.InputLabel9.Width = 75
        '
        'btnSearchPortfolio
        '
        Me.btnSearchPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchPortfolio.Image = CType(resources.GetObject("btnSearchPortfolio.Image"), System.Drawing.Image)
        Me.btnSearchPortfolio.Name = "btnSearchPortfolio"
        Me.btnSearchPortfolio.ToolTipText = "Search master portfolio"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 130
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 738
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiName.Width = 1
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Sales Agent: "
        Me.InputLabel5.Width = 75
        '
        'lblSalesCode
        '
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Width = 100
        '
        'lblSalesName
        '
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Width = 500
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "From date: "
        Me.InputLabel1.Width = 65
        '
        'dtFrom
        '
        Me.dtFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtFrom.Name = "dtFrom"
        '
        'dtTo
        '
        Me.dtTo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtTo.Name = "dtTo"
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ToolTipText = "Display client investment information"
        '
        'btnExcel
        '
        Me.btnExcel.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.ToolTipText = "Export transaction to excel"
        '
        'btnPDF
        '
        Me.btnPDF.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.ToolTipText = "Generate pdf report"
        '
        'btnEmail
        '
        Me.btnEmail.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.ToolTipText = "Send to email with excel or pdf attachment"
        '
        'btnSetting
        '
        Me.btnSetting.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.ToolTipText = "Set pdf layout reporting"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Beginning Unit Balance: "
        Me.InputLabel3.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputLabel3.Width = 1
        '
        'lblBalance
        '
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblBalance.Width = 100
        '
        'c1pdf
        '
        Me.c1pdf.RotateAngle = 0!
        Me.c1pdf.UniqueFontsPerPage = False
        Me.c1pdf.UseFastTextOut = False
        Me.c1pdf.UseFileCaching = False
        '
        'C1SplitContainer2
        '
        Me.C1SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer2.BorderWidth = 1
        Me.C1SplitContainer2.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer2.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer2.Location = New System.Drawing.Point(0, 106)
        Me.C1SplitContainer2.Name = "C1SplitContainer2"
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel4)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel5)
        Me.C1SplitContainer2.Size = New System.Drawing.Size(1235, 420)
        Me.C1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.SplitterWidth = 1
        Me.C1SplitContainer2.TabIndex = 13
        Me.C1SplitContainer2.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.C1SplitContainer2.UseParentVisualStyle = False
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.Controls.Add(Me.DBGTransaction)
        Me.C1SplitterPanel3.Controls.Add(Me.C1InputPanel3)
        Me.C1SplitterPanel3.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Bottom
        Me.C1SplitterPanel3.Height = 206
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(1, 234)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(1233, 185)
        Me.C1SplitterPanel3.SizeRatio = 49.4R
        Me.C1SplitterPanel3.TabIndex = 0
        Me.C1SplitterPanel3.Text = "Transaction History"
        '
        'DBGTransaction
        '
        Me.DBGTransaction.BackColor = System.Drawing.Color.White
        Me.DBGTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGTransaction.CaptionHeight = 17
        Me.DBGTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGTransaction.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTransaction.Images.Add(CType(resources.GetObject("DBGTransaction.Images"), System.Drawing.Image))
        Me.DBGTransaction.Location = New System.Drawing.Point(0, 32)
        Me.DBGTransaction.Name = "DBGTransaction"
        Me.DBGTransaction.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTransaction.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTransaction.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTransaction.PrintInfo.PageSettings = CType(resources.GetObject("DBGTransaction.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTransaction.PropBag = resources.GetString("DBGTransaction.PropBag")
        Me.DBGTransaction.RecordSelectors = False
        Me.DBGTransaction.RowHeight = 15
        Me.DBGTransaction.Size = New System.Drawing.Size(1233, 152)
        Me.DBGTransaction.TabIndex = 12
        '
        'C1SplitterPanel4
        '
        Me.C1SplitterPanel4.Controls.Add(Me.C1InputPanel2)
        Me.C1SplitterPanel4.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel4.Location = New System.Drawing.Point(1, 22)
        Me.C1SplitterPanel4.Name = "C1SplitterPanel4"
        Me.C1SplitterPanel4.Size = New System.Drawing.Size(304, 190)
        Me.C1SplitterPanel4.SizeRatio = 24.667R
        Me.C1SplitterPanel4.TabIndex = 1
        Me.C1SplitterPanel4.Text = "Summary"
        Me.C1SplitterPanel4.Width = 304
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BackColor = System.Drawing.Color.White
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.lblRedemptionTitle)
        Me.C1InputPanel2.Items.Add(Me.lblRedemption)
        Me.C1InputPanel2.Items.Add(Me.lblRedemptionCostTitle)
        Me.C1InputPanel2.Items.Add(Me.lblRedemptionCost)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel2.Items.Add(Me.lblPLRedemptionTitle)
        Me.C1InputPanel2.Items.Add(Me.lblPLRedemption)
        Me.C1InputPanel2.Items.Add(Me.lblDividendTitle)
        Me.C1InputPanel2.Items.Add(Me.lblDividend)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator4)
        Me.C1InputPanel2.Items.Add(Me.lblPLRealizedTitle)
        Me.C1InputPanel2.Items.Add(Me.lblPLRealized)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator3)
        Me.C1InputPanel2.Items.Add(Me.lblLastValueTitle)
        Me.C1InputPanel2.Items.Add(Me.lblLastValue)
        Me.C1InputPanel2.Items.Add(Me.lblLastCostTitle)
        Me.C1InputPanel2.Items.Add(Me.lblLastCost)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator5)
        Me.C1InputPanel2.Items.Add(Me.lblPLUnrealizedTitle)
        Me.C1InputPanel2.Items.Add(Me.lblPLUnrealized)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(304, 190)
        Me.C1InputPanel2.TabIndex = 21
        '
        'lblRedemptionTitle
        '
        Me.lblRedemptionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedemptionTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedemptionTitle.Name = "lblRedemptionTitle"
        Me.lblRedemptionTitle.Text = "Total Redemption: "
        Me.lblRedemptionTitle.Width = 150
        '
        'lblRedemption
        '
        Me.lblRedemption.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRedemption.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedemption.Name = "lblRedemption"
        Me.lblRedemption.Width = 127
        '
        'lblRedemptionCostTitle
        '
        Me.lblRedemptionCostTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedemptionCostTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedemptionCostTitle.Name = "lblRedemptionCostTitle"
        Me.lblRedemptionCostTitle.Text = "Acq. Cost: "
        Me.lblRedemptionCostTitle.Width = 150
        '
        'lblRedemptionCost
        '
        Me.lblRedemptionCost.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRedemptionCost.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedemptionCost.Name = "lblRedemptionCost"
        Me.lblRedemptionCost.Width = 127
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Height = 2
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 280
        '
        'lblPLRedemptionTitle
        '
        Me.lblPLRedemptionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLRedemptionTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPLRedemptionTitle.Name = "lblPLRedemptionTitle"
        Me.lblPLRedemptionTitle.Text = "Redemption P/L: "
        Me.lblPLRedemptionTitle.Width = 150
        '
        'lblPLRedemption
        '
        Me.lblPLRedemption.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPLRedemption.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPLRedemption.Name = "lblPLRedemption"
        Me.lblPLRedemption.Width = 127
        '
        'lblDividendTitle
        '
        Me.lblDividendTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDividendTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDividendTitle.Name = "lblDividendTitle"
        Me.lblDividendTitle.Text = "Dividend: "
        Me.lblDividendTitle.Width = 150
        '
        'lblDividend
        '
        Me.lblDividend.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDividend.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDividend.Name = "lblDividend"
        Me.lblDividend.Width = 127
        '
        'InputSeparator4
        '
        Me.InputSeparator4.Name = "InputSeparator4"
        Me.InputSeparator4.Width = 280
        '
        'lblPLRealizedTitle
        '
        Me.lblPLRealizedTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLRealizedTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPLRealizedTitle.Name = "lblPLRealizedTitle"
        Me.lblPLRealizedTitle.Text = "Realized P/L: "
        Me.lblPLRealizedTitle.Width = 150
        '
        'lblPLRealized
        '
        Me.lblPLRealized.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPLRealized.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPLRealized.Name = "lblPLRealized"
        Me.lblPLRealized.Width = 127
        '
        'InputSeparator3
        '
        Me.InputSeparator3.Height = 26
        Me.InputSeparator3.Name = "InputSeparator3"
        Me.InputSeparator3.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputSeparator3.Width = 280
        '
        'lblLastValueTitle
        '
        Me.lblLastValueTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastValueTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblLastValueTitle.Name = "lblLastValueTitle"
        Me.lblLastValueTitle.Text = "Last Investment Value: "
        Me.lblLastValueTitle.Width = 150
        '
        'lblLastValue
        '
        Me.lblLastValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblLastValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblLastValue.Name = "lblLastValue"
        Me.lblLastValue.Width = 127
        '
        'lblLastCostTitle
        '
        Me.lblLastCostTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastCostTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblLastCostTitle.Name = "lblLastCostTitle"
        Me.lblLastCostTitle.Text = "Acq. Cost: "
        Me.lblLastCostTitle.Width = 150
        '
        'lblLastCost
        '
        Me.lblLastCost.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblLastCost.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblLastCost.Name = "lblLastCost"
        Me.lblLastCost.Width = 127
        '
        'InputSeparator5
        '
        Me.InputSeparator5.Name = "InputSeparator5"
        Me.InputSeparator5.Width = 280
        '
        'lblPLUnrealizedTitle
        '
        Me.lblPLUnrealizedTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLUnrealizedTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPLUnrealizedTitle.Name = "lblPLUnrealizedTitle"
        Me.lblPLUnrealizedTitle.Text = "Unrealized P/L: "
        Me.lblPLUnrealizedTitle.Width = 150
        '
        'lblPLUnrealized
        '
        Me.lblPLUnrealized.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPLUnrealized.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPLUnrealized.Name = "lblPLUnrealized"
        Me.lblPLUnrealized.Width = 127
        '
        'C1SplitterPanel5
        '
        Me.C1SplitterPanel5.BackColor = System.Drawing.Color.White
        Me.C1SplitterPanel5.Controls.Add(Me.chartNAV)
        Me.C1SplitterPanel5.Height = 211
        Me.C1SplitterPanel5.Location = New System.Drawing.Point(306, 22)
        Me.C1SplitterPanel5.Name = "C1SplitterPanel5"
        Me.C1SplitterPanel5.Size = New System.Drawing.Size(928, 190)
        Me.C1SplitterPanel5.TabIndex = 2
        Me.C1SplitterPanel5.Text = "Investment Growth"
        '
        'chartNAV
        '
        Me.chartNAV.BackColor = System.Drawing.Color.White
        Me.chartNAV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartNAV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.chartNAV.Location = New System.Drawing.Point(0, 0)
        Me.chartNAV.Name = "chartNAV"
        Me.chartNAV.PropBag = resources.GetString("chartNAV.PropBag")
        Me.chartNAV.Size = New System.Drawing.Size(928, 190)
        Me.chartNAV.TabIndex = 16
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputLabel4)
        Me.C1InputPanel3.Items.Add(Me.cmbType)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(1233, 32)
        Me.C1InputPanel3.TabIndex = 13
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Transaction Type: "
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Width = 150
        '
        'ReportAccountStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 526)
        Me.Controls.Add(Me.C1SplitContainer2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportAccountStatement"
        Me.Text = "REPORT: Account Statement"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer2.ResumeLayout(False)
        Me.C1SplitterPanel3.ResumeLayout(False)
        CType(Me.DBGTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel4.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel5.ResumeLayout(False)
        CType(Me.chartNAV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dtTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnSearchClient As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblClientCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnExcel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnPDF As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBalance As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnEmail As C1.Win.C1InputPanel.InputButton
    Friend WithEvents c1pdf As C1.C1Pdf.C1PdfDocument
    Friend WithEvents C1SplitContainer2 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents DBGTransaction As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1SplitterPanel4 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents lblRedemptionCostTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemptionCost As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDividendTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDividend As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemptionTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemption As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents lblLastValueTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator3 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents lblPLRealizedTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPLRealized As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPLRedemptionTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPLRedemption As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator4 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents C1SplitterPanel5 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents chartNAV As C1.Win.C1Chart.C1Chart
    Friend WithEvents lblPLUnrealizedTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPLUnrealized As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator5 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents lblLastCostTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastCost As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSetting As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbType As C1.Win.C1InputPanel.InputComboBox
End Class
