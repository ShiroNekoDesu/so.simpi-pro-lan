<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEODOverrideSecurities2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideSecurities2))
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
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolio = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgSecurities = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalSecurities = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRecords = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.pbData = New System.Windows.Forms.ProgressBar()
        Me.fgPortfolio = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchSecurities = New C1.Win.C1InputPanel.InputButton()
        Me.lblSecuritiesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSecuritiesName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCompany = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCompanyID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTypeID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblType = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtQty = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCost = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPrice = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblMarketValue = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAccruedCoupon = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTotalValue = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTTM = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTM = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYieldEffective = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblModifiedDuration = New C1.Win.C1InputPanel.InputLabel()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemove = New C1.Win.C1InputPanel.InputButton()
        Me.fgManual = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCodeManual = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioNameManual = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnProfile = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSummaryQty = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSummaryValue = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSummaryAccrued = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSummaryTotal = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.bwID = New System.ComponentModel.BackgroundWorker()
        Me.bwRead = New System.ComponentModel.BackgroundWorker()
        Me.bwRun = New System.ComponentModel.BackgroundWorker()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.fgSecurities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 2
        Me.C1DockingTab1.Size = New System.Drawing.Size(904, 490)
        Me.C1DockingTab1.TabIndex = 1
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
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(902, 465)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "SCB FILE READ"
        '
        'fgExcel
        '
        Me.fgExcel.AllowEditing = False
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgExcel.Location = New System.Drawing.Point(0, 151)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(902, 314)
        Me.fgExcel.TabIndex = 3
        '
        'pbExcel
        '
        Me.pbExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbExcel.Location = New System.Drawing.Point(0, 128)
        Me.pbExcel.Name = "pbExcel"
        Me.pbExcel.Size = New System.Drawing.Size(902, 23)
        Me.pbExcel.TabIndex = 4
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel29)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolio)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(902, 128)
        Me.C1InputPanel1.TabIndex = 5
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
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Number of portfolio: "
        Me.InputLabel29.Width = 121
        '
        'lblPortfolio
        '
        Me.lblPortfolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolio.ForeColor = System.Drawing.Color.Red
        Me.lblPortfolio.Name = "lblPortfolio"
        Me.lblPortfolio.Width = 42
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.fgSecurities)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage2.Controls.Add(Me.pbData)
        Me.C1DockingTabPage2.Controls.Add(Me.fgPortfolio)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(902, 465)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "OVERRIDE FILE SCB"
        '
        'fgSecurities
        '
        Me.fgSecurities.AllowEditing = False
        Me.fgSecurities.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgSecurities.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgSecurities.Location = New System.Drawing.Point(0, 250)
        Me.fgSecurities.Name = "fgSecurities"
        Me.fgSecurities.Rows.DefaultSize = 19
        Me.fgSecurities.Size = New System.Drawing.Size(902, 205)
        Me.fgSecurities.TabIndex = 12
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel3.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel3.Items.Add(Me.InputLabel6)
        Me.C1InputPanel3.Items.Add(Me.cmbExternalSecurities)
        Me.C1InputPanel3.Items.Add(Me.btnRun)
        Me.C1InputPanel3.Items.Add(Me.InputLabel7)
        Me.C1InputPanel3.Items.Add(Me.lblRecords)
        Me.C1InputPanel3.Items.Add(Me.InputLabel8)
        Me.C1InputPanel3.Items.Add(Me.lblFailed)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 161)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(902, 89)
        Me.C1InputPanel3.TabIndex = 10
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "SECURITIES UPLOAD"
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Master Portfolio: "
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
        Me.lblPortfolioName.Width = 680
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Securities Identfiication"
        Me.InputLabel6.Width = 135
        '
        'cmbExternalSecurities
        '
        Me.cmbExternalSecurities.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbExternalSecurities.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalSecurities.Name = "cmbExternalSecurities"
        Me.cmbExternalSecurities.Width = 150
        '
        'btnRun
        '
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Number of record(s): "
        Me.InputLabel7.Width = 135
        '
        'lblRecords
        '
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Width = 45
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Number of fail(s): "
        '
        'lblFailed
        '
        Me.lblFailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Width = 50
        '
        'pbData
        '
        Me.pbData.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbData.Location = New System.Drawing.Point(0, 138)
        Me.pbData.Name = "pbData"
        Me.pbData.Size = New System.Drawing.Size(902, 23)
        Me.pbData.TabIndex = 13
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
        Me.fgPortfolio.TabIndex = 11
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(902, 31)
        Me.C1InputPanel2.TabIndex = 1
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Portolio Identification: "
        Me.InputLabel5.Width = 135
        '
        'cmbExternalPortfolio
        '
        Me.cmbExternalPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbExternalPortfolio.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalPortfolio.Name = "cmbExternalPortfolio"
        Me.cmbExternalPortfolio.Width = 150
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage3.Controls.Add(Me.fgManual)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(902, 465)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "OVERRIDE MANUAL"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BackColor = System.Drawing.Color.White
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel5.Items.Add(Me.btnSearchSecurities)
        Me.C1InputPanel5.Items.Add(Me.lblSecuritiesCode)
        Me.C1InputPanel5.Items.Add(Me.lblSecuritiesName)
        Me.C1InputPanel5.Items.Add(Me.lblCompany)
        Me.C1InputPanel5.Items.Add(Me.lblCompanyID)
        Me.C1InputPanel5.Items.Add(Me.lblTypeID)
        Me.C1InputPanel5.Items.Add(Me.lblType)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel5.Items.Add(Me.InputLabel15)
        Me.C1InputPanel5.Items.Add(Me.txtQty)
        Me.C1InputPanel5.Items.Add(Me.InputLabel13)
        Me.C1InputPanel5.Items.Add(Me.txtCost)
        Me.C1InputPanel5.Items.Add(Me.InputLabel17)
        Me.C1InputPanel5.Items.Add(Me.txtPrice)
        Me.C1InputPanel5.Items.Add(Me.InputLabel16)
        Me.C1InputPanel5.Items.Add(Me.lblMarketValue)
        Me.C1InputPanel5.Items.Add(Me.InputLabel18)
        Me.C1InputPanel5.Items.Add(Me.txtAccruedCoupon)
        Me.C1InputPanel5.Items.Add(Me.InputLabel21)
        Me.C1InputPanel5.Items.Add(Me.lblTotalValue)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel5.Items.Add(Me.InputLabel19)
        Me.C1InputPanel5.Items.Add(Me.lblTTM)
        Me.C1InputPanel5.Items.Add(Me.InputLabel25)
        Me.C1InputPanel5.Items.Add(Me.lblYTM)
        Me.C1InputPanel5.Items.Add(Me.InputLabel10)
        Me.C1InputPanel5.Items.Add(Me.lblYieldEffective)
        Me.C1InputPanel5.Items.Add(Me.InputLabel23)
        Me.C1InputPanel5.Items.Add(Me.lblModifiedDuration)
        Me.C1InputPanel5.Items.Add(Me.btnAdd)
        Me.C1InputPanel5.Items.Add(Me.btnRemove)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 316)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(902, 148)
        Me.C1InputPanel5.TabIndex = 3
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "NEW SECURITIES BALANCE POSITION"
        '
        'btnSearchSecurities
        '
        Me.btnSearchSecurities.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchSecurities.Image = CType(resources.GetObject("btnSearchSecurities.Image"), System.Drawing.Image)
        Me.btnSearchSecurities.Name = "btnSearchSecurities"
        '
        'lblSecuritiesCode
        '
        Me.lblSecuritiesCode.Name = "lblSecuritiesCode"
        Me.lblSecuritiesCode.Width = 100
        '
        'lblSecuritiesName
        '
        Me.lblSecuritiesName.Name = "lblSecuritiesName"
        Me.lblSecuritiesName.Width = 669
        '
        'lblCompany
        '
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblCompany.Width = 1
        '
        'lblCompanyID
        '
        Me.lblCompanyID.Name = "lblCompanyID"
        Me.lblCompanyID.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblCompanyID.Width = 1
        '
        'lblTypeID
        '
        Me.lblTypeID.Name = "lblTypeID"
        Me.lblTypeID.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblTypeID.Width = 1
        '
        'lblType
        '
        Me.lblType.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblType.Name = "lblType"
        Me.lblType.Width = 50
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Height = 1
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        '
        'InputLabel15
        '
        Me.InputLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Quantity: "
        Me.InputLabel15.Width = 65
        '
        'txtQty
        '
        Me.txtQty.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Width = 120
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Cost Price: "
        Me.InputLabel13.Width = 85
        '
        'txtCost
        '
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Width = 75
        '
        'InputLabel17
        '
        Me.InputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel17.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Market Price: "
        Me.InputLabel17.Width = 85
        '
        'txtPrice
        '
        Me.txtPrice.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Width = 75
        '
        'InputLabel16
        '
        Me.InputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "Market Value: "
        Me.InputLabel16.Width = 110
        '
        'lblMarketValue
        '
        Me.lblMarketValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblMarketValue.Name = "lblMarketValue"
        Me.lblMarketValue.Width = 120
        '
        'InputLabel18
        '
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Accrued Coupon: "
        Me.InputLabel18.Width = 110
        '
        'txtAccruedCoupon
        '
        Me.txtAccruedCoupon.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtAccruedCoupon.Name = "txtAccruedCoupon"
        Me.txtAccruedCoupon.Width = 120
        '
        'InputLabel21
        '
        Me.InputLabel21.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Total Value: "
        Me.InputLabel21.Width = 120
        '
        'lblTotalValue
        '
        Me.lblTotalValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Width = 120
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Height = 1
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "TTM: "
        Me.InputLabel19.Width = 65
        '
        'lblTTM
        '
        Me.lblTTM.Name = "lblTTM"
        Me.lblTTM.Width = 119
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "YTM: "
        Me.InputLabel25.Width = 85
        '
        'lblYTM
        '
        Me.lblYTM.Name = "lblYTM"
        Me.lblYTM.Width = 127
        '
        'InputLabel10
        '
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Yield Efftv: "
        '
        'lblYieldEffective
        '
        Me.lblYieldEffective.Name = "lblYieldEffective"
        Me.lblYieldEffective.Width = 60
        '
        'InputLabel23
        '
        Me.InputLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel23.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Text = "Modified duration: "
        '
        'lblModifiedDuration
        '
        Me.lblModifiedDuration.Name = "lblModifiedDuration"
        Me.lblModifiedDuration.Width = 65
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        '
        'btnRemove
        '
        Me.btnRemove.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Name = "btnRemove"
        '
        'fgManual
        '
        Me.fgManual.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgManual.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgManual.Location = New System.Drawing.Point(0, 103)
        Me.fgManual.Name = "fgManual"
        Me.fgManual.Rows.DefaultSize = 19
        Me.fgManual.Size = New System.Drawing.Size(902, 213)
        Me.fgManual.TabIndex = 15
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel4.Items.Add(Me.btnSearchPortfolio)
        Me.C1InputPanel4.Items.Add(Me.lblPortfolioCodeManual)
        Me.C1InputPanel4.Items.Add(Me.lblPortfolioNameManual)
        Me.C1InputPanel4.Items.Add(Me.dtAs)
        Me.C1InputPanel4.Items.Add(Me.btnProfile)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel4.Items.Add(Me.InputLabel11)
        Me.C1InputPanel4.Items.Add(Me.cmbType)
        Me.C1InputPanel4.Items.Add(Me.InputLabel12)
        Me.C1InputPanel4.Items.Add(Me.lblSummaryQty)
        Me.C1InputPanel4.Items.Add(Me.InputLabel14)
        Me.C1InputPanel4.Items.Add(Me.lblSummaryValue)
        Me.C1InputPanel4.Items.Add(Me.InputLabel22)
        Me.C1InputPanel4.Items.Add(Me.lblSummaryAccrued)
        Me.C1InputPanel4.Items.Add(Me.InputLabel26)
        Me.C1InputPanel4.Items.Add(Me.lblSummaryTotal)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(902, 103)
        Me.C1InputPanel4.TabIndex = 2
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "MASTER PORTFOLIO"
        '
        'btnSearchPortfolio
        '
        Me.btnSearchPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchPortfolio.Image = CType(resources.GetObject("btnSearchPortfolio.Image"), System.Drawing.Image)
        Me.btnSearchPortfolio.Name = "btnSearchPortfolio"
        '
        'lblPortfolioCodeManual
        '
        Me.lblPortfolioCodeManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioCodeManual.Name = "lblPortfolioCodeManual"
        Me.lblPortfolioCodeManual.Width = 100
        '
        'lblPortfolioNameManual
        '
        Me.lblPortfolioNameManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioNameManual.Name = "lblPortfolioNameManual"
        Me.lblPortfolioNameManual.Width = 620
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        '
        'btnProfile
        '
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Name = "btnProfile"
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Height = 1
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        '
        'InputLabel11
        '
        Me.InputLabel11.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Asset Type"
        Me.InputLabel11.Width = 100
        '
        'cmbType
        '
        Me.cmbType.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbType.Name = "cmbType"
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Qty"
        Me.InputLabel12.Width = 120
        '
        'lblSummaryQty
        '
        Me.lblSummaryQty.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSummaryQty.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSummaryQty.Name = "lblSummaryQty"
        Me.lblSummaryQty.Width = 120
        '
        'InputLabel14
        '
        Me.InputLabel14.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Value"
        Me.InputLabel14.Width = 120
        '
        'lblSummaryValue
        '
        Me.lblSummaryValue.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSummaryValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSummaryValue.Name = "lblSummaryValue"
        Me.lblSummaryValue.Width = 120
        '
        'InputLabel22
        '
        Me.InputLabel22.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Accrued Interest"
        Me.InputLabel22.Width = 120
        '
        'lblSummaryAccrued
        '
        Me.lblSummaryAccrued.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSummaryAccrued.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSummaryAccrued.Name = "lblSummaryAccrued"
        Me.lblSummaryAccrued.Width = 120
        '
        'InputLabel26
        '
        Me.InputLabel26.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel26.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel26.Name = "InputLabel26"
        Me.InputLabel26.Text = "Total"
        Me.InputLabel26.Width = 120
        '
        'lblSummaryTotal
        '
        Me.lblSummaryTotal.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSummaryTotal.Name = "lblSummaryTotal"
        Me.lblSummaryTotal.Width = 120
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(902, 465)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "X.D.1 FILE READ"
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(902, 465)
        Me.C1DockingTabPage5.TabIndex = 4
        Me.C1DockingTabPage5.Text = "OVERRIDE FILE X.D.1"
        '
        'bwExcel
        '
        '
        'bwID
        '
        '
        'bwRead
        '
        '
        'bwRun
        '
        '
        'FormEODOverrideSecurities2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 490)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideSecurities2"
        Me.Text = "END OF DAY: Override Securities Holding"
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.fgSecurities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents pbExcel As System.Windows.Forms.ProgressBar
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalSecurities As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRecords As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCodeManual As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioNameManual As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnProfile As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtQty As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblMarketValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtPrice As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAccruedCoupon As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTotalValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTTM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblModifiedDuration As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTM As C1.Win.C1InputPanel.InputLabel
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
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolio As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgSecurities As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgPortfolio As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bwID As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbData As ProgressBar
    Friend WithEvents bwRead As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYieldEffective As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchSecurities As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSecuritiesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSecuritiesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTypeID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblCompany As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCompanyID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSummaryQty As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSummaryValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSummaryAccrued As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSummaryTotal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCost As C1.Win.C1InputPanel.InputTextBox
End Class
