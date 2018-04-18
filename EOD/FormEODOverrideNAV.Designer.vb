<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODOverrideNAV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideNAV))
        Me.btnLoad = New C1.Win.C1InputPanel.InputButton()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTotalNAV = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTotalUnit = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAveragePrice = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsOf = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblPortfolioID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNAV = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVBefore = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubs = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUnits = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNAVUnit = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPersen = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPrice = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUnit = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.DBGFund = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel53 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternal = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel54 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSucceed = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel56 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pbNAV = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnBrowse = New C1.Win.C1InputPanel.InputButton()
        Me.txtFilename = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSheet = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRowStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel50 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnRead = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.bwRun = New System.ComponentModel.BackgroundWorker()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGFund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "As Of: "
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "NAV PERIOD"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.dtAs)
        Me.C1InputPanel2.Items.Add(Me.btnLoad)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.lblTotalNAV)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.lblTotalUnit)
        Me.C1InputPanel2.Items.Add(Me.InputLabel11)
        Me.C1InputPanel2.Items.Add(Me.lblAveragePrice)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(901, 58)
        Me.C1InputPanel2.TabIndex = 16
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Total NAV: "
        '
        'lblTotalNAV
        '
        Me.lblTotalNAV.Name = "lblTotalNAV"
        Me.lblTotalNAV.Width = 130
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Total Units: "
        '
        'lblTotalUnit
        '
        Me.lblTotalUnit.Name = "lblTotalUnit"
        Me.lblTotalUnit.Width = 130
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Average NAV/Units: "
        '
        'lblAveragePrice
        '
        Me.lblAveragePrice.Name = "lblAveragePrice"
        Me.lblAveragePrice.Width = 100
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Next: "
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "NAV/Unit: "
        '
        'lblAsOf
        '
        Me.lblAsOf.Name = "lblAsOf"
        Me.lblAsOf.Width = 100
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 926
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.White
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioID)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.txtNAV)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblNAVBefore)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.lblSubs)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.txtUnits)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.txtNAVUnit)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.lblPersen)
        Me.C1InputPanel1.Items.Add(Me.lblPrice)
        Me.C1InputPanel1.Items.Add(Me.lblUnit)
        Me.C1InputPanel1.Items.Add(Me.btnSave)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 353)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(901, 112)
        Me.C1InputPanel1.TabIndex = 22
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "NAV PORTFOLIO"
        '
        'lblPortfolioID
        '
        Me.lblPortfolioID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblPortfolioID.Name = "lblPortfolioID"
        Me.lblPortfolioID.Width = 50
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 707
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Height = 1
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "NAV"
        Me.InputLabel7.Width = 75
        '
        'txtNAV
        '
        Me.txtNAV.Name = "txtNAV"
        Me.txtNAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNAV.Width = 150
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Before"
        Me.InputLabel3.Width = 75
        '
        'lblNAVBefore
        '
        Me.lblNAVBefore.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNAVBefore.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblNAVBefore.Name = "lblNAVBefore"
        Me.lblNAVBefore.Width = 147
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Subs/Reds"
        Me.InputLabel6.Width = 75
        '
        'lblSubs
        '
        Me.lblSubs.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSubs.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSubs.Name = "lblSubs"
        Me.lblSubs.Width = 147
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Units"
        Me.InputLabel9.Width = 60
        '
        'txtUnits
        '
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUnits.Width = 150
        '
        'InputLabel10
        '
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "NAV/Unit"
        Me.InputLabel10.Width = 60
        '
        'txtNAVUnit
        '
        Me.txtNAVUnit.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtNAVUnit.Name = "txtNAVUnit"
        Me.txtNAVUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNAVUnit.Width = 150
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "%"
        Me.InputLabel12.Width = 50
        '
        'lblPersen
        '
        Me.lblPersen.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblPersen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersen.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblPersen.Name = "lblPersen"
        Me.lblPersen.Width = 50
        '
        'lblPrice
        '
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblPrice.Width = 5
        '
        'lblUnit
        '
        Me.lblUnit.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblUnit.Width = 5
        '
        'btnSave
        '
        Me.btnSave.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSave.Height = 35
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "SAVE"
        Me.btnSave.Width = 100
        '
        'DBGFund
        '
        Me.DBGFund.BackColor = System.Drawing.Color.White
        Me.DBGFund.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGFund.CaptionHeight = 17
        Me.DBGFund.ContextMenuStrip = Me.csMenu
        Me.DBGFund.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGFund.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGFund.Images.Add(CType(resources.GetObject("DBGFund.Images"), System.Drawing.Image))
        Me.DBGFund.Location = New System.Drawing.Point(0, 58)
        Me.DBGFund.Name = "DBGFund"
        Me.DBGFund.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGFund.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGFund.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGFund.PrintInfo.PageSettings = CType(resources.GetObject("DBGFund.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGFund.PropBag = resources.GetString("DBGFund.PropBag")
        Me.DBGFund.RecordSelectors = False
        Me.DBGFund.RowHeight = 15
        Me.DBGFund.Size = New System.Drawing.Size(901, 295)
        Me.DBGFund.TabIndex = 23
        '
        'csMenu
        '
        Me.csMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttachToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.csMenu.Name = "csMenu"
        Me.csMenu.Size = New System.Drawing.Size(112, 70)
        '
        'AttachToolStripMenuItem
        '
        Me.AttachToolStripMenuItem.Name = "AttachToolStripMenuItem"
        Me.AttachToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AttachToolStripMenuItem.Text = "Detach"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.Size = New System.Drawing.Size(903, 490)
        Me.C1DockingTab1.TabIndex = 24
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel1)
        Me.C1DockingTabPage1.Controls.Add(Me.DBGFund)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(901, 465)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "OVERRIDE MANUAL"
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage2.Controls.Add(Me.fgExcel)
        Me.C1DockingTabPage2.Controls.Add(Me.pbNAV)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(901, 465)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "OVERRIDE FILE SCB"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel5.Items.Add(Me.InputLabel53)
        Me.C1InputPanel5.Items.Add(Me.cmbExternal)
        Me.C1InputPanel5.Items.Add(Me.btnRun)
        Me.C1InputPanel5.Items.Add(Me.InputLabel54)
        Me.C1InputPanel5.Items.Add(Me.lblSucceed)
        Me.C1InputPanel5.Items.Add(Me.InputLabel56)
        Me.C1InputPanel5.Items.Add(Me.lblFailed)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 391)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(901, 75)
        Me.C1InputPanel5.TabIndex = 7
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "NAV UPLOAD"
        '
        'InputLabel53
        '
        Me.InputLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel53.Name = "InputLabel53"
        Me.InputLabel53.Text = "Portolio Identfiication: "
        Me.InputLabel53.Width = 125
        '
        'cmbExternal
        '
        Me.cmbExternal.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbExternal.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternal.Name = "cmbExternal"
        Me.cmbExternal.Width = 150
        '
        'btnRun
        '
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'InputLabel54
        '
        Me.InputLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel54.Name = "InputLabel54"
        Me.InputLabel54.Text = "Number of succeed(s): "
        Me.InputLabel54.Width = 135
        '
        'lblSucceed
        '
        Me.lblSucceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucceed.ForeColor = System.Drawing.Color.Red
        Me.lblSucceed.Name = "lblSucceed"
        Me.lblSucceed.Width = 45
        '
        'InputLabel56
        '
        Me.InputLabel56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel56.Name = "InputLabel56"
        Me.InputLabel56.Text = "Number of fail(s): "
        '
        'lblFailed
        '
        Me.lblFailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Width = 50
        '
        'fgExcel
        '
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgExcel.Location = New System.Drawing.Point(0, 151)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(901, 240)
        Me.fgExcel.StyleInfo = resources.GetString("fgExcel.StyleInfo")
        Me.fgExcel.TabIndex = 6
        '
        'pbNAV
        '
        Me.pbNAV.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbNAV.Location = New System.Drawing.Point(0, 128)
        Me.pbNAV.Name = "pbNAV"
        Me.pbNAV.Size = New System.Drawing.Size(901, 23)
        Me.pbNAV.TabIndex = 5
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel3.Items.Add(Me.InputLabel13)
        Me.C1InputPanel3.Items.Add(Me.btnBrowse)
        Me.C1InputPanel3.Items.Add(Me.txtFilename)
        Me.C1InputPanel3.Items.Add(Me.InputLabel24)
        Me.C1InputPanel3.Items.Add(Me.txtSheet)
        Me.C1InputPanel3.Items.Add(Me.InputLabel28)
        Me.C1InputPanel3.Items.Add(Me.txtRowStart)
        Me.C1InputPanel3.Items.Add(Me.InputLabel31)
        Me.C1InputPanel3.Items.Add(Me.txtColStart)
        Me.C1InputPanel3.Items.Add(Me.InputLabel50)
        Me.C1InputPanel3.Items.Add(Me.txtColNo)
        Me.C1InputPanel3.Items.Add(Me.btnRead)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel3.Items.Add(Me.InputLabel14)
        Me.C1InputPanel3.Items.Add(Me.lblDate)
        Me.C1InputPanel3.Items.Add(Me.InputLabel15)
        Me.C1InputPanel3.Items.Add(Me.lblRows)
        Me.C1InputPanel3.Items.Add(Me.InputLabel16)
        Me.C1InputPanel3.Items.Add(Me.lblAUM)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(901, 128)
        Me.C1InputPanel3.TabIndex = 2
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "FILE SELECTION"
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Filename: "
        Me.InputLabel13.Width = 75
        '
        'btnBrowse
        '
        Me.btnBrowse.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.Name = "btnBrowse"
        '
        'txtFilename
        '
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Text = "C:\"
        Me.txtFilename.Width = 779
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Worksheet: "
        Me.InputLabel24.Width = 169
        '
        'txtSheet
        '
        Me.txtSheet.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtSheet.Name = "txtSheet"
        Me.txtSheet.Text = "Sheet1"
        '
        'InputLabel28
        '
        Me.InputLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel28.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel28.Name = "InputLabel28"
        Me.InputLabel28.Text = "Start row: "
        '
        'txtRowStart
        '
        Me.txtRowStart.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtRowStart.Name = "txtRowStart"
        Me.txtRowStart.Text = "2"
        Me.txtRowStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRowStart.Width = 35
        '
        'InputLabel31
        '
        Me.InputLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel31.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel31.Name = "InputLabel31"
        Me.InputLabel31.Text = "Start col: "
        '
        'txtColStart
        '
        Me.txtColStart.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtColStart.Name = "txtColStart"
        Me.txtColStart.Text = "1"
        Me.txtColStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColStart.Width = 35
        '
        'InputLabel50
        '
        Me.InputLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel50.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel50.Name = "InputLabel50"
        Me.InputLabel50.Text = "No of col: "
        '
        'txtColNo
        '
        Me.txtColNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtColNo.Name = "txtColNo"
        Me.txtColNo.Text = "13"
        Me.txtColNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColNo.Width = 35
        '
        'btnRead
        '
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "SUMMARY"
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Date: "
        Me.InputLabel14.Width = 75
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Red
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Width = 100
        '
        'InputLabel15
        '
        Me.InputLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Number of rows: "
        '
        'lblRows
        '
        Me.lblRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRows.ForeColor = System.Drawing.Color.Red
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 35
        '
        'InputLabel16
        '
        Me.InputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "AUM: "
        Me.InputLabel16.Width = 58
        '
        'lblAUM
        '
        Me.lblAUM.Name = "lblAUM"
        Me.lblAUM.Width = 150
        '
        'bwExcel
        '
        '
        'bwRun
        '
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(901, 465)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "OVERRIDE FILE X.D.1"
        '
        'FormEODOverrideNAV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 490)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideNAV"
        Me.Text = "END OF DAY: Override NAV"
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGFund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoad As C1.Win.C1InputPanel.InputButton
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsOf As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNAV As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtUnits As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtNAVUnit As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGFund As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTotalNAV As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTotalUnit As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAveragePrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVBefore As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPersen As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubs As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUnit As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnBrowse As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtFilename As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSheet As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRowStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel50 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnRead As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents pbNAV As ProgressBar
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel53 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternal As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel54 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSucceed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel56 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
End Class
