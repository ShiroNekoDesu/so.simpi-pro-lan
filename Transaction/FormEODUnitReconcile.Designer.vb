<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODUnitReconcile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODUnitReconcile))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pbExcel = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnBrowse = New C1.Win.C1InputPanel.InputButton()
        Me.txtFilename = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSheet = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRowStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnRead = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.DBGPortfolio = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgSecurities = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel49 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel50 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel51 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel53 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRecords = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel54 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel56 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNTA = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel58 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLA = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel60 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubs = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel62 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblReds = New C1.Win.C1InputPanel.InputLabel()
        Me.pbData = New System.Windows.Forms.ProgressBar()
        Me.fgPortfolio = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel55 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer2 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1TrueDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1SplitterPanel4 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1TrueDBGrid3 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel32 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel33 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel34 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel39 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel40 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel41 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel42 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel43 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel44 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel45 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel46 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel47 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel48 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1TrueDBGrid4 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel57 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSAName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputComboBox1 = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputDatePicker1 = New C1.Win.C1InputPanel.InputDatePicker()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.fgSecurities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage4.SuspendLayout()
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer2.SuspendLayout()
        Me.C1SplitterPanel3.SuspendLayout()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel4.SuspendLayout()
        CType(Me.C1TrueDBGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage5.SuspendLayout()
        CType(Me.C1TrueDBGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 74)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 4
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(904, 442)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.fgExcel)
        Me.C1DockingTabPage1.Controls.Add(Me.pbExcel)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel1)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(902, 417)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "FILE READ"
        '
        'fgExcel
        '
        Me.fgExcel.AllowEditing = False
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgExcel.Location = New System.Drawing.Point(0, 151)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(902, 266)
        Me.fgExcel.TabIndex = 8
        '
        'pbExcel
        '
        Me.pbExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbExcel.Location = New System.Drawing.Point(0, 128)
        Me.pbExcel.Name = "pbExcel"
        Me.pbExcel.Size = New System.Drawing.Size(902, 23)
        Me.pbExcel.TabIndex = 7
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.btnBrowse)
        Me.C1InputPanel1.Items.Add(Me.txtFilename)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.txtSheet)
        Me.C1InputPanel1.Items.Add(Me.InputLabel28)
        Me.C1InputPanel1.Items.Add(Me.txtRowStart)
        Me.C1InputPanel1.Items.Add(Me.InputLabel31)
        Me.C1InputPanel1.Items.Add(Me.txtColStart)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtColNo)
        Me.C1InputPanel1.Items.Add(Me.btnRead)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.lblDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel27)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(902, 128)
        Me.C1InputPanel1.TabIndex = 6
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "FILE SELECTION"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Filename: "
        Me.InputLabel1.Width = 75
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
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Worksheet: "
        Me.InputLabel2.Width = 169
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
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "No of col: "
        '
        'txtColNo
        '
        Me.txtColNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtColNo.Name = "txtColNo"
        Me.txtColNo.Text = "7"
        Me.txtColNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColNo.Width = 35
        '
        'btnRead
        '
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "SUMMARY"
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Date: "
        Me.InputLabel4.Width = 75
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Red
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Width = 100
        '
        'InputLabel27
        '
        Me.InputLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel27.Name = "InputLabel27"
        Me.InputLabel27.Text = "Number of rows: "
        '
        'lblRows
        '
        Me.lblRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRows.ForeColor = System.Drawing.Color.Red
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 35
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1SplitContainer1)
        Me.C1DockingTabPage2.Controls.Add(Me.ProgressBar1)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(902, 417)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.TabStop = False
        Me.C1DockingTabPage2.Text = "INSTITUTION"
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 80)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(902, 337)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 1
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.DBGPortfolio)
        Me.C1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(588, 316)
        Me.C1SplitterPanel1.SizeRatio = 65.261R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "FOUND"
        Me.C1SplitterPanel1.Width = 588
        '
        'DBGPortfolio
        '
        Me.DBGPortfolio.BackColor = System.Drawing.Color.White
        Me.DBGPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGPortfolio.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGPortfolio.Images.Add(CType(resources.GetObject("DBGPortfolio.Images"), System.Drawing.Image))
        Me.DBGPortfolio.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolio.Name = "DBGPortfolio"
        Me.DBGPortfolio.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolio.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGPortfolio.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGPortfolio.PrintInfo.PageSettings = CType(resources.GetObject("DBGPortfolio.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGPortfolio.PropBag = resources.GetString("DBGPortfolio.PropBag")
        Me.DBGPortfolio.RecordSelectors = False
        Me.DBGPortfolio.Size = New System.Drawing.Size(588, 410)
        Me.DBGPortfolio.TabIndex = 5
        Me.DBGPortfolio.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.C1TrueDBGrid1)
        Me.C1SplitterPanel2.Height = 337
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(589, 21)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(313, 316)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "NOT FOUND"
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.BackColor = System.Drawing.Color.White
        Me.C1TrueDBGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        Me.C1TrueDBGrid1.RecordSelectors = False
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(313, 410)
        Me.C1TrueDBGrid1.TabIndex = 5
        Me.C1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 57)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(902, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputButton1)
        Me.C1InputPanel3.Items.Add(Me.InputLabel8)
        Me.C1InputPanel3.Items.Add(Me.InputLabel10)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.InputLabel12)
        Me.C1InputPanel3.Items.Add(Me.InputLabel11)
        Me.C1InputPanel3.Items.Add(Me.InputLabel13)
        Me.C1InputPanel3.Items.Add(Me.InputLabel16)
        Me.C1InputPanel3.Items.Add(Me.InputLabel17)
        Me.C1InputPanel3.Items.Add(Me.InputLabel18)
        Me.C1InputPanel3.Items.Add(Me.InputLabel19)
        Me.C1InputPanel3.Items.Add(Me.InputLabel20)
        Me.C1InputPanel3.Items.Add(Me.InputLabel21)
        Me.C1InputPanel3.Items.Add(Me.InputLabel22)
        Me.C1InputPanel3.Items.Add(Me.InputLabel23)
        Me.C1InputPanel3.Items.Add(Me.InputLabel24)
        Me.C1InputPanel3.Items.Add(Me.InputLabel14)
        Me.C1InputPanel3.Items.Add(Me.InputLabel15)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(902, 57)
        Me.C1InputPanel3.TabIndex = 0
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton1.Height = 50
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "CHECK"
        Me.InputButton1.Width = 100
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Record(s): "
        Me.InputLabel8.Width = 75
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Width = 50
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Found: "
        Me.InputLabel9.Width = 75
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Width = 50
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Not Found: "
        Me.InputLabel11.Width = 75
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Width = 50
        '
        'InputLabel16
        '
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Width = 100
        '
        'InputLabel17
        '
        Me.InputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel17.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Unitholder"
        Me.InputLabel17.Width = 75
        '
        'InputLabel18
        '
        Me.InputLabel18.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Total Unit"
        Me.InputLabel18.Width = 75
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "Reconciled: "
        Me.InputLabel19.Width = 100
        '
        'InputLabel20
        '
        Me.InputLabel20.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Width = 75
        '
        'InputLabel21
        '
        Me.InputLabel21.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel21.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Width = 75
        '
        'InputLabel22
        '
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Not Reconcile: "
        Me.InputLabel22.Width = 100
        '
        'InputLabel23
        '
        Me.InputLabel23.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Width = 75
        '
        'InputLabel24
        '
        Me.InputLabel24.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel24.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Width = 75
        '
        'InputLabel14
        '
        Me.InputLabel14.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Unit difference tolerance"
        '
        'InputLabel15
        '
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Width = 140
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.fgSecurities)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel6)
        Me.C1DockingTabPage3.Controls.Add(Me.pbData)
        Me.C1DockingTabPage3.Controls.Add(Me.fgPortfolio)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel7)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(902, 417)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "DISTRIBUTOR"
        '
        'fgSecurities
        '
        Me.fgSecurities.AllowEditing = False
        Me.fgSecurities.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgSecurities.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgSecurities.Location = New System.Drawing.Point(0, 231)
        Me.fgSecurities.Name = "fgSecurities"
        Me.fgSecurities.Rows.DefaultSize = 19
        Me.fgSecurities.Size = New System.Drawing.Size(902, 205)
        Me.fgSecurities.TabIndex = 17
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.BorderThickness = 1
        Me.C1InputPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel6.Items.Add(Me.InputLabel49)
        Me.C1InputPanel6.Items.Add(Me.InputLabel50)
        Me.C1InputPanel6.Items.Add(Me.InputLabel51)
        Me.C1InputPanel6.Items.Add(Me.btnRun)
        Me.C1InputPanel6.Items.Add(Me.InputLabel53)
        Me.C1InputPanel6.Items.Add(Me.lblRecords)
        Me.C1InputPanel6.Items.Add(Me.InputLabel54)
        Me.C1InputPanel6.Items.Add(Me.lblFailed)
        Me.C1InputPanel6.Items.Add(Me.InputLabel56)
        Me.C1InputPanel6.Items.Add(Me.lblNTA)
        Me.C1InputPanel6.Items.Add(Me.InputLabel58)
        Me.C1InputPanel6.Items.Add(Me.lblLA)
        Me.C1InputPanel6.Items.Add(Me.InputLabel60)
        Me.C1InputPanel6.Items.Add(Me.lblSubs)
        Me.C1InputPanel6.Items.Add(Me.InputLabel62)
        Me.C1InputPanel6.Items.Add(Me.lblReds)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 161)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(902, 70)
        Me.C1InputPanel6.TabIndex = 15
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "DISTRIBUTOR UNITHOLDER"
        '
        'InputLabel49
        '
        Me.InputLabel49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel49.Name = "InputLabel49"
        Me.InputLabel49.Text = "Sales Distributor: "
        '
        'InputLabel50
        '
        Me.InputLabel50.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel50.Name = "InputLabel50"
        Me.InputLabel50.Width = 100
        '
        'InputLabel51
        '
        Me.InputLabel51.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel51.Name = "InputLabel51"
        Me.InputLabel51.Width = 430
        '
        'btnRun
        '
        Me.btnRun.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnRun.Height = 40
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Text = "CHECK"
        Me.btnRun.Width = 100
        '
        'InputLabel53
        '
        Me.InputLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel53.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel53.Name = "InputLabel53"
        Me.InputLabel53.Text = "Unitholder:"
        Me.InputLabel53.Width = 65
        '
        'lblRecords
        '
        Me.lblRecords.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Width = 45
        '
        'InputLabel54
        '
        Me.InputLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel54.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel54.Name = "InputLabel54"
        Me.InputLabel54.Text = "Unit(s):"
        Me.InputLabel54.Width = 65
        '
        'lblFailed
        '
        Me.lblFailed.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblFailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Width = 50
        '
        'InputLabel56
        '
        Me.InputLabel56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel56.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel56.Name = "InputLabel56"
        Me.InputLabel56.Text = "NTA: "
        Me.InputLabel56.Width = 35
        '
        'lblNTA
        '
        Me.lblNTA.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNTA.Name = "lblNTA"
        Me.lblNTA.Width = 50
        '
        'InputLabel58
        '
        Me.InputLabel58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel58.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel58.Name = "InputLabel58"
        Me.InputLabel58.Text = "LA: "
        Me.InputLabel58.Width = 35
        '
        'lblLA
        '
        Me.lblLA.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblLA.Name = "lblLA"
        Me.lblLA.Width = 50
        '
        'InputLabel60
        '
        Me.InputLabel60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel60.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel60.Name = "InputLabel60"
        Me.InputLabel60.Text = "Subs: "
        Me.InputLabel60.Width = 35
        '
        'lblSubs
        '
        Me.lblSubs.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSubs.Name = "lblSubs"
        Me.lblSubs.Width = 50
        '
        'InputLabel62
        '
        Me.InputLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel62.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel62.Name = "InputLabel62"
        Me.InputLabel62.Text = "Reds: "
        Me.InputLabel62.Width = 35
        '
        'lblReds
        '
        Me.lblReds.Name = "lblReds"
        Me.lblReds.Width = 50
        '
        'pbData
        '
        Me.pbData.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbData.Location = New System.Drawing.Point(0, 138)
        Me.pbData.Name = "pbData"
        Me.pbData.Size = New System.Drawing.Size(902, 23)
        Me.pbData.TabIndex = 18
        '
        'fgPortfolio
        '
        Me.fgPortfolio.AllowEditing = False
        Me.fgPortfolio.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgPortfolio.Location = New System.Drawing.Point(0, 31)
        Me.fgPortfolio.Name = "fgPortfolio"
        Me.fgPortfolio.Rows.DefaultSize = 19
        Me.fgPortfolio.Size = New System.Drawing.Size(902, 107)
        Me.fgPortfolio.TabIndex = 16
        '
        'C1InputPanel7
        '
        Me.C1InputPanel7.BorderThickness = 1
        Me.C1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel7.Items.Add(Me.InputLabel55)
        Me.C1InputPanel7.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel7.Name = "C1InputPanel7"
        Me.C1InputPanel7.Size = New System.Drawing.Size(902, 31)
        Me.C1InputPanel7.TabIndex = 14
        '
        'InputLabel55
        '
        Me.InputLabel55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel55.Name = "InputLabel55"
        Me.InputLabel55.Text = "Sales Identification: "
        Me.InputLabel55.Width = 135
        '
        'cmbExternalPortfolio
        '
        Me.cmbExternalPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbExternalPortfolio.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalPortfolio.Name = "cmbExternalPortfolio"
        Me.cmbExternalPortfolio.Width = 150
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.C1SplitContainer2)
        Me.C1DockingTabPage4.Controls.Add(Me.ProgressBar2)
        Me.C1DockingTabPage4.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(902, 417)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "INDIVIDUAL"
        '
        'C1SplitContainer2
        '
        Me.C1SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer2.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer2.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer2.Location = New System.Drawing.Point(0, 158)
        Me.C1SplitContainer2.Name = "C1SplitContainer2"
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel4)
        Me.C1SplitContainer2.Size = New System.Drawing.Size(902, 259)
        Me.C1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.SplitterWidth = 1
        Me.C1SplitContainer2.TabIndex = 2
        Me.C1SplitContainer2.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.Controls.Add(Me.C1TrueDBGrid2)
        Me.C1SplitterPanel3.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(588, 238)
        Me.C1SplitterPanel3.SizeRatio = 65.261R
        Me.C1SplitterPanel3.TabIndex = 0
        Me.C1SplitterPanel3.Text = "FOUND"
        Me.C1SplitterPanel3.Width = 588
        '
        'C1TrueDBGrid2
        '
        Me.C1TrueDBGrid2.BackColor = System.Drawing.Color.White
        Me.C1TrueDBGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1TrueDBGrid2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("C1TrueDBGrid2.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid2.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid2.PropBag = resources.GetString("C1TrueDBGrid2.PropBag")
        Me.C1TrueDBGrid2.RecordSelectors = False
        Me.C1TrueDBGrid2.Size = New System.Drawing.Size(588, 410)
        Me.C1TrueDBGrid2.TabIndex = 5
        Me.C1TrueDBGrid2.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1SplitterPanel4
        '
        Me.C1SplitterPanel4.Controls.Add(Me.C1TrueDBGrid3)
        Me.C1SplitterPanel4.Height = 259
        Me.C1SplitterPanel4.Location = New System.Drawing.Point(589, 21)
        Me.C1SplitterPanel4.Name = "C1SplitterPanel4"
        Me.C1SplitterPanel4.Size = New System.Drawing.Size(313, 238)
        Me.C1SplitterPanel4.TabIndex = 1
        Me.C1SplitterPanel4.Text = "NOT FOUND"
        '
        'C1TrueDBGrid3
        '
        Me.C1TrueDBGrid3.BackColor = System.Drawing.Color.White
        Me.C1TrueDBGrid3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1TrueDBGrid3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1TrueDBGrid3.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid3.Images.Add(CType(resources.GetObject("C1TrueDBGrid3.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid3.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid3.Name = "C1TrueDBGrid3"
        Me.C1TrueDBGrid3.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid3.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid3.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid3.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid3.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid3.PropBag = resources.GetString("C1TrueDBGrid3.PropBag")
        Me.C1TrueDBGrid3.RecordSelectors = False
        Me.C1TrueDBGrid3.Size = New System.Drawing.Size(313, 410)
        Me.C1TrueDBGrid3.TabIndex = 5
        Me.C1TrueDBGrid3.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar2.Location = New System.Drawing.Point(0, 135)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(902, 23)
        Me.ProgressBar2.TabIndex = 8
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel5.Items.Add(Me.InputButton4)
        Me.C1InputPanel5.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel5.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel5.Items.Add(Me.InputButton3)
        Me.C1InputPanel5.Items.Add(Me.InputLabel32)
        Me.C1InputPanel5.Items.Add(Me.InputLabel33)
        Me.C1InputPanel5.Items.Add(Me.InputLabel34)
        Me.C1InputPanel5.Items.Add(Me.InputLabel35)
        Me.C1InputPanel5.Items.Add(Me.InputLabel36)
        Me.C1InputPanel5.Items.Add(Me.InputLabel37)
        Me.C1InputPanel5.Items.Add(Me.InputLabel38)
        Me.C1InputPanel5.Items.Add(Me.InputLabel39)
        Me.C1InputPanel5.Items.Add(Me.InputLabel40)
        Me.C1InputPanel5.Items.Add(Me.InputLabel41)
        Me.C1InputPanel5.Items.Add(Me.InputLabel42)
        Me.C1InputPanel5.Items.Add(Me.InputLabel43)
        Me.C1InputPanel5.Items.Add(Me.InputLabel44)
        Me.C1InputPanel5.Items.Add(Me.InputLabel45)
        Me.C1InputPanel5.Items.Add(Me.InputLabel46)
        Me.C1InputPanel5.Items.Add(Me.InputLabel47)
        Me.C1InputPanel5.Items.Add(Me.InputLabel48)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(902, 135)
        Me.C1InputPanel5.TabIndex = 1
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "MASTER PORTFOLIO"
        '
        'InputButton4
        '
        Me.InputButton4.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton4.Image = CType(resources.GetObject("InputButton4.Image"), System.Drawing.Image)
        Me.InputButton4.Name = "InputButton4"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 730
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "SUMMARY"
        '
        'InputButton3
        '
        Me.InputButton3.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton3.Height = 50
        Me.InputButton3.Image = CType(resources.GetObject("InputButton3.Image"), System.Drawing.Image)
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "CHECK"
        Me.InputButton3.Width = 100
        '
        'InputLabel32
        '
        Me.InputLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel32.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel32.Name = "InputLabel32"
        Me.InputLabel32.Text = "Record(s): "
        Me.InputLabel32.Width = 75
        '
        'InputLabel33
        '
        Me.InputLabel33.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel33.Name = "InputLabel33"
        Me.InputLabel33.Width = 50
        '
        'InputLabel34
        '
        Me.InputLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel34.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel34.Name = "InputLabel34"
        Me.InputLabel34.Text = "Found: "
        Me.InputLabel34.Width = 75
        '
        'InputLabel35
        '
        Me.InputLabel35.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel35.Name = "InputLabel35"
        Me.InputLabel35.Width = 50
        '
        'InputLabel36
        '
        Me.InputLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel36.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Text = "Not Found: "
        Me.InputLabel36.Width = 75
        '
        'InputLabel37
        '
        Me.InputLabel37.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel37.Name = "InputLabel37"
        Me.InputLabel37.Width = 50
        '
        'InputLabel38
        '
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Width = 100
        '
        'InputLabel39
        '
        Me.InputLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel39.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel39.Name = "InputLabel39"
        Me.InputLabel39.Text = "Unitholder"
        Me.InputLabel39.Width = 75
        '
        'InputLabel40
        '
        Me.InputLabel40.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel40.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel40.Name = "InputLabel40"
        Me.InputLabel40.Text = "Total Unit"
        Me.InputLabel40.Width = 75
        '
        'InputLabel41
        '
        Me.InputLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel41.Name = "InputLabel41"
        Me.InputLabel41.Text = "Reconciled: "
        Me.InputLabel41.Width = 100
        '
        'InputLabel42
        '
        Me.InputLabel42.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel42.Name = "InputLabel42"
        Me.InputLabel42.Width = 75
        '
        'InputLabel43
        '
        Me.InputLabel43.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel43.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel43.Name = "InputLabel43"
        Me.InputLabel43.Width = 75
        '
        'InputLabel44
        '
        Me.InputLabel44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel44.Name = "InputLabel44"
        Me.InputLabel44.Text = "Not Reconcile: "
        Me.InputLabel44.Width = 100
        '
        'InputLabel45
        '
        Me.InputLabel45.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel45.Name = "InputLabel45"
        Me.InputLabel45.Width = 75
        '
        'InputLabel46
        '
        Me.InputLabel46.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel46.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel46.Name = "InputLabel46"
        Me.InputLabel46.Width = 75
        '
        'InputLabel47
        '
        Me.InputLabel47.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel47.Name = "InputLabel47"
        Me.InputLabel47.Text = "Unit difference tolerance"
        '
        'InputLabel48
        '
        Me.InputLabel48.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel48.Name = "InputLabel48"
        Me.InputLabel48.Width = 140
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Controls.Add(Me.C1TrueDBGrid4)
        Me.C1DockingTabPage5.Controls.Add(Me.ProgressBar3)
        Me.C1DockingTabPage5.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(902, 417)
        Me.C1DockingTabPage5.TabIndex = 4
        Me.C1DockingTabPage5.Text = "NOT FOUND"
        '
        'C1TrueDBGrid4
        '
        Me.C1TrueDBGrid4.BackColor = System.Drawing.Color.White
        Me.C1TrueDBGrid4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1TrueDBGrid4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1TrueDBGrid4.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid4.Images.Add(CType(resources.GetObject("C1TrueDBGrid4.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid4.Location = New System.Drawing.Point(0, 80)
        Me.C1TrueDBGrid4.Name = "C1TrueDBGrid4"
        Me.C1TrueDBGrid4.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid4.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid4.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid4.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid4.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid4.PropBag = resources.GetString("C1TrueDBGrid4.PropBag")
        Me.C1TrueDBGrid4.RecordSelectors = False
        Me.C1TrueDBGrid4.Size = New System.Drawing.Size(902, 410)
        Me.C1TrueDBGrid4.TabIndex = 5
        Me.C1TrueDBGrid4.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar3.Location = New System.Drawing.Point(0, 57)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(902, 23)
        Me.ProgressBar3.TabIndex = 8
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputButton2)
        Me.C1InputPanel4.Items.Add(Me.InputLabel25)
        Me.C1InputPanel4.Items.Add(Me.InputLabel26)
        Me.C1InputPanel4.Items.Add(Me.InputLabel29)
        Me.C1InputPanel4.Items.Add(Me.InputLabel30)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(902, 57)
        Me.C1InputPanel4.TabIndex = 1
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton2.Height = 50
        Me.InputButton2.Image = CType(resources.GetObject("InputButton2.Image"), System.Drawing.Image)
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "CHECK"
        Me.InputButton2.Width = 100
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Record(s): "
        Me.InputLabel25.Width = 75
        '
        'InputLabel26
        '
        Me.InputLabel26.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel26.Name = "InputLabel26"
        Me.InputLabel26.Width = 50
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Total unit: "
        Me.InputLabel29.Width = 75
        '
        'InputLabel30
        '
        Me.InputLabel30.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Width = 50
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.InputLabel57)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.lblSACode)
        Me.C1InputPanel2.Items.Add(Me.lblSAName)
        Me.C1InputPanel2.Items.Add(Me.InputComboBox1)
        Me.C1InputPanel2.Items.Add(Me.InputDatePicker1)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(904, 74)
        Me.C1InputPanel2.TabIndex = 1
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "S-INVEST IDENTIFICATION"
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "SA CODE"
        Me.InputLabel5.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "SA NAME"
        Me.InputLabel6.Width = 525
        '
        'InputLabel57
        '
        Me.InputLabel57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel57.Name = "InputLabel57"
        Me.InputLabel57.Text = "Unitholder Identification"
        Me.InputLabel57.Width = 150
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "AsOf"
        '
        'lblSACode
        '
        Me.lblSACode.Name = "lblSACode"
        Me.lblSACode.Width = 100
        '
        'lblSAName
        '
        Me.lblSAName.Name = "lblSAName"
        Me.lblSAName.Width = 525
        '
        'InputComboBox1
        '
        Me.InputComboBox1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputComboBox1.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.InputComboBox1.Name = "InputComboBox1"
        Me.InputComboBox1.Width = 150
        '
        'InputDatePicker1
        '
        Me.InputDatePicker1.Name = "InputDatePicker1"
        '
        'FormEODUnitReconcile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 513)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Name = "FormEODUnitReconcile"
        Me.Text = "END OF DAY: Reconcile Unit Balance"
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.fgSecurities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage4.ResumeLayout(False)
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer2.ResumeLayout(False)
        Me.C1SplitterPanel3.ResumeLayout(False)
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel4.ResumeLayout(False)
        CType(Me.C1TrueDBGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage5.ResumeLayout(False)
        CType(Me.C1TrueDBGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnBrowse As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtFilename As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSheet As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRowStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnRead As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents pbExcel As ProgressBar
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSAName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputDatePicker1 As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1SplitContainer2 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel4 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel32 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel33 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel34 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel37 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel39 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel40 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel41 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel42 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel43 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel44 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel45 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel46 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel47 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel48 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGPortfolio As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TrueDBGrid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TrueDBGrid3 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TrueDBGrid4 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents fgSecurities As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel49 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel50 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel51 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel53 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRecords As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel54 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel56 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNTA As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel58 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLA As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel60 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubs As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel62 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblReds As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents pbData As ProgressBar
    Friend WithEvents fgPortfolio As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel55 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel57 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputComboBox1 As C1.Win.C1InputPanel.InputComboBox
End Class
