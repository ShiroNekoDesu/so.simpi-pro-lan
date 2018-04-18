<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODOverrideBank2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideBank2))
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
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgBank = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pbData = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalBank = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeywordTD = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeywordCash = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRecords = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchBank = New C1.Win.C1InputPanel.InputButton()
        Me.lblCompanyCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCompanyName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbCash = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbTD = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccountNo = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNominal = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInterest = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRate = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtPlacement = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtMaturity = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemove = New C1.Win.C1InputPanel.InputButton()
        Me.fgManual = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearchPosition = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.bwPortfolio = New System.ComponentModel.BackgroundWorker()
        Me.bwRun = New System.ComponentModel.BackgroundWorker()
        Me.bwBank = New System.ComponentModel.BackgroundWorker()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.fgBank, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1DockingTab1.Size = New System.Drawing.Size(902, 495)
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
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(900, 470)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "SCB FILE READ"
        '
        'fgExcel
        '
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgExcel.Location = New System.Drawing.Point(0, 151)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(900, 319)
        Me.fgExcel.TabIndex = 3
        '
        'pbExcel
        '
        Me.pbExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbExcel.Location = New System.Drawing.Point(0, 128)
        Me.pbExcel.Name = "pbExcel"
        Me.pbExcel.Size = New System.Drawing.Size(900, 23)
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel27)
        Me.C1InputPanel1.Items.Add(Me.lblDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel29)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(900, 128)
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
        Me.txtColNo.Text = "8"
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
        'InputLabel27
        '
        Me.InputLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel27.Name = "InputLabel27"
        Me.InputLabel27.Text = "Date: "
        Me.InputLabel27.Width = 75
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Red
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Width = 100
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Number of rows: "
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
        Me.C1DockingTabPage2.Controls.Add(Me.fgBank)
        Me.C1DockingTabPage2.Controls.Add(Me.pbData)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(900, 470)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "OVERRIDE FILE SCB"
        '
        'fgBank
        '
        Me.fgBank.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgBank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgBank.Location = New System.Drawing.Point(0, 105)
        Me.fgBank.Name = "fgBank"
        Me.fgBank.Rows.DefaultSize = 19
        Me.fgBank.Size = New System.Drawing.Size(900, 365)
        Me.fgBank.TabIndex = 4
        '
        'pbData
        '
        Me.pbData.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbData.Location = New System.Drawing.Point(0, 82)
        Me.pbData.Name = "pbData"
        Me.pbData.Size = New System.Drawing.Size(900, 23)
        Me.pbData.TabIndex = 14
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel10)
        Me.C1InputPanel2.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.cmbExternalBank)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.txtKeywordTD)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.txtKeywordCash)
        Me.C1InputPanel2.Items.Add(Me.btnRun)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.lblRecords)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.lblFailed)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(900, 82)
        Me.C1InputPanel2.TabIndex = 1
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "BANK UPLOAD"
        '
        'InputLabel10
        '
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Portfolio Identification: "
        Me.InputLabel10.Width = 130
        '
        'cmbExternalPortfolio
        '
        Me.cmbExternalPortfolio.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalPortfolio.Name = "cmbExternalPortfolio"
        Me.cmbExternalPortfolio.Width = 151
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Bank Identfiication: "
        Me.InputLabel5.Width = 130
        '
        'cmbExternalBank
        '
        Me.cmbExternalBank.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbExternalBank.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalBank.Name = "cmbExternalBank"
        Me.cmbExternalBank.Width = 150
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "key Term Deposit: "
        Me.InputLabel4.Width = 120
        '
        'txtKeywordTD
        '
        Me.txtKeywordTD.Name = "txtKeywordTD"
        Me.txtKeywordTD.Text = "TERM DEPOSIT"
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "key Bank Account: "
        Me.InputLabel7.Width = 120
        '
        'txtKeywordCash
        '
        Me.txtKeywordCash.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeywordCash.Name = "txtKeywordCash"
        Me.txtKeywordCash.Text = "CASH"
        '
        'btnRun
        '
        Me.btnRun.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Height = 20
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Number of record(s): "
        Me.InputLabel6.Width = 120
        '
        'lblRecords
        '
        Me.lblRecords.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Height = 25
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Width = 45
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Height = 20
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Number of fail(s): "
        Me.InputLabel8.Width = 120
        '
        'lblFailed
        '
        Me.lblFailed.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblFailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Height = 25
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Width = 50
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage3.Controls.Add(Me.fgManual)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(900, 470)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "OVERRIDE MANUAL"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BackColor = System.Drawing.Color.White
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel5.Items.Add(Me.InputLabel15)
        Me.C1InputPanel5.Items.Add(Me.btnSearchBank)
        Me.C1InputPanel5.Items.Add(Me.lblCompanyCode)
        Me.C1InputPanel5.Items.Add(Me.lblCompanyName)
        Me.C1InputPanel5.Items.Add(Me.InputLabel12)
        Me.C1InputPanel5.Items.Add(Me.rbCash)
        Me.C1InputPanel5.Items.Add(Me.rbTD)
        Me.C1InputPanel5.Items.Add(Me.InputLabel25)
        Me.C1InputPanel5.Items.Add(Me.lblAccountNo)
        Me.C1InputPanel5.Items.Add(Me.InputLabel13)
        Me.C1InputPanel5.Items.Add(Me.txtNominal)
        Me.C1InputPanel5.Items.Add(Me.InputLabel21)
        Me.C1InputPanel5.Items.Add(Me.txtInterest)
        Me.C1InputPanel5.Items.Add(Me.InputLabel22)
        Me.C1InputPanel5.Items.Add(Me.txtRate)
        Me.C1InputPanel5.Items.Add(Me.InputLabel23)
        Me.C1InputPanel5.Items.Add(Me.dtPlacement)
        Me.C1InputPanel5.Items.Add(Me.InputLabel24)
        Me.C1InputPanel5.Items.Add(Me.dtMaturity)
        Me.C1InputPanel5.Items.Add(Me.btnSave)
        Me.C1InputPanel5.Items.Add(Me.btnRemove)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 341)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(900, 129)
        Me.C1InputPanel5.TabIndex = 13
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "NEW BANK POSITION"
        '
        'InputLabel15
        '
        Me.InputLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Bank: "
        Me.InputLabel15.Width = 70
        '
        'btnSearchBank
        '
        Me.btnSearchBank.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchBank.Image = CType(resources.GetObject("btnSearchBank.Image"), System.Drawing.Image)
        Me.btnSearchBank.Name = "btnSearchBank"
        '
        'lblCompanyCode
        '
        Me.lblCompanyCode.Name = "lblCompanyCode"
        Me.lblCompanyCode.Width = 100
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Width = 676
        '
        'InputLabel12
        '
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Bank Type: "
        Me.InputLabel12.Width = 70
        '
        'rbCash
        '
        Me.rbCash.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Text = "Bank Account"
        '
        'rbTD
        '
        Me.rbTD.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbTD.Name = "rbTD"
        Me.rbTD.Text = "Bank Deposit"
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Account No: "
        Me.InputLabel25.Width = 220
        '
        'lblAccountNo
        '
        Me.lblAccountNo.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccountNo.Name = "lblAccountNo"
        Me.lblAccountNo.Width = 200
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Nominal: "
        Me.InputLabel13.Width = 70
        '
        'txtNominal
        '
        Me.txtNominal.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNominal.Name = "txtNominal"
        '
        'InputLabel21
        '
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Accrued Interest: "
        Me.InputLabel21.Width = 100
        '
        'txtInterest
        '
        Me.txtInterest.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtInterest.Name = "txtInterest"
        '
        'InputLabel22
        '
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Interest Rate: "
        Me.InputLabel22.Width = 100
        '
        'txtRate
        '
        Me.txtRate.Name = "txtRate"
        '
        'InputLabel23
        '
        Me.InputLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Text = "Placement: "
        Me.InputLabel23.Width = 70
        '
        'dtPlacement
        '
        Me.dtPlacement.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtPlacement.Name = "dtPlacement"
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Maturity: "
        Me.InputLabel24.Width = 100
        '
        'dtMaturity
        '
        Me.dtMaturity.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtMaturity.Name = "dtMaturity"
        '
        'btnSave
        '
        Me.btnSave.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'btnRemove
        '
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Name = "btnRemove"
        '
        'fgManual
        '
        Me.fgManual.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgManual.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgManual.Location = New System.Drawing.Point(0, 58)
        Me.fgManual.Name = "fgManual"
        Me.fgManual.Rows.DefaultSize = 19
        Me.fgManual.Size = New System.Drawing.Size(900, 283)
        Me.fgManual.TabIndex = 14
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel4.Items.Add(Me.btnSearchPortfolio)
        Me.C1InputPanel4.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel4.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel4.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel4.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel4.Items.Add(Me.InputLabel14)
        Me.C1InputPanel4.Items.Add(Me.dtAs)
        Me.C1InputPanel4.Items.Add(Me.btnSearchPosition)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(900, 58)
        Me.C1InputPanel4.TabIndex = 2
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "MASTER PORTFOLIO"
        '
        'btnSearchPortfolio
        '
        Me.btnSearchPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchPortfolio.Image = CType(resources.GetObject("btnSearchPortfolio.Image"), System.Drawing.Image)
        Me.btnSearchPortfolio.Name = "btnSearchPortfolio"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioCode.ForeColor = System.Drawing.Color.Red
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 120
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioName.ForeColor = System.Drawing.Color.Red
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 549
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Width = 1
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiName.Width = 1
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "As of: "
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Enabled = False
        Me.dtAs.Name = "dtAs"
        '
        'btnSearchPosition
        '
        Me.btnSearchPosition.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnSearchPosition.Image = CType(resources.GetObject("btnSearchPosition.Image"), System.Drawing.Image)
        Me.btnSearchPosition.Name = "btnSearchPosition"
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(900, 470)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "X.D.1 FILE READ"
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(900, 470)
        Me.C1DockingTabPage5.TabIndex = 4
        Me.C1DockingTabPage5.Text = "OVERRIDE FILE X.D.1"
        '
        'bwExcel
        '
        '
        'bwPortfolio
        '
        '
        'bwRun
        '
        '
        'bwBank
        '
        '
        'FormEODOverrideBank2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 495)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideBank2"
        Me.Text = "END OF DAY: Override Bank Account & Time Deposit"
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.fgBank, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalBank As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRecords As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeywordTD As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeywordCash As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearchPosition As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearchBank As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblCompanyCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCompanyName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbCash As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbTD As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNominal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInterest As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRate As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtPlacement As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtMaturity As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccountNo As C1.Win.C1InputPanel.InputLabel
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
    Friend WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents pbExcel As ProgressBar
    Friend WithEvents fgBank As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwPortfolio As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbData As ProgressBar
    Friend WithEvents bwBank As System.ComponentModel.BackgroundWorker
    Friend WithEvents fgManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
End Class
