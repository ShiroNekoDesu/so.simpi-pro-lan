<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODOverrideBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideBank))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbBankAccount = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbDeposit = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbBankAccount = New C1.Win.C1InputPanel.InputComboBox()
        Me.lblAccountID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchBank = New C1.Win.C1InputPanel.InputButton()
        Me.lblCompanyID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCompanyCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCompanyName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNominal = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtMaturity = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtInterest = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRate = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemove = New C1.Win.C1InputPanel.InputButton()
        Me.fgManual = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCodeManual = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioNameManual = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbAll = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCash = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbTD = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryQty = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryAccrued = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryTotal = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalSecurities = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRecords = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pbExcel = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnBrowse = New C1.Win.C1InputPanel.InputButton()
        Me.txtFilename = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSheet = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRowStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtColNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnRead = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox2 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox3 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox4 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox5 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(969, 546)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage1.Controls.Add(Me.fgManual)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(967, 521)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "OVERRIDE MANUAL"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BackColor = System.Drawing.Color.White
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel5.Items.Add(Me.InputLabel1)
        Me.C1InputPanel5.Items.Add(Me.rbBankAccount)
        Me.C1InputPanel5.Items.Add(Me.rbDeposit)
        Me.C1InputPanel5.Items.Add(Me.InputLabel25)
        Me.C1InputPanel5.Items.Add(Me.cmbBankAccount)
        Me.C1InputPanel5.Items.Add(Me.lblAccountID)
        Me.C1InputPanel5.Items.Add(Me.InputLabel15)
        Me.C1InputPanel5.Items.Add(Me.btnSearchBank)
        Me.C1InputPanel5.Items.Add(Me.lblCompanyID)
        Me.C1InputPanel5.Items.Add(Me.lblCompanyCode)
        Me.C1InputPanel5.Items.Add(Me.lblCompanyName)
        Me.C1InputPanel5.Items.Add(Me.InputLabel13)
        Me.C1InputPanel5.Items.Add(Me.txtNominal)
        Me.C1InputPanel5.Items.Add(Me.InputLabel24)
        Me.C1InputPanel5.Items.Add(Me.dtMaturity)
        Me.C1InputPanel5.Items.Add(Me.InputLabel21)
        Me.C1InputPanel5.Items.Add(Me.txtInterest)
        Me.C1InputPanel5.Items.Add(Me.InputLabel2)
        Me.C1InputPanel5.Items.Add(Me.txtRate)
        Me.C1InputPanel5.Items.Add(Me.btnSave)
        Me.C1InputPanel5.Items.Add(Me.btnRemove)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 387)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(967, 133)
        Me.C1InputPanel5.TabIndex = 18
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "NEW BANK POSITION"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Bank Type: "
        Me.InputLabel1.Width = 70
        '
        'rbBankAccount
        '
        Me.rbBankAccount.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbBankAccount.Checked = True
        Me.rbBankAccount.Name = "rbBankAccount"
        Me.rbBankAccount.Text = "Cash"
        '
        'rbDeposit
        '
        Me.rbDeposit.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbDeposit.Name = "rbDeposit"
        Me.rbDeposit.Text = "TD"
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Bank Account: "
        Me.InputLabel25.Width = 115
        '
        'cmbBankAccount
        '
        Me.cmbBankAccount.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbBankAccount.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbBankAccount.Name = "cmbBankAccount"
        Me.cmbBankAccount.Width = 451
        '
        'lblAccountID
        '
        Me.lblAccountID.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Width = 100
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
        Me.btnSearchBank.Enabled = False
        Me.btnSearchBank.Image = CType(resources.GetObject("btnSearchBank.Image"), System.Drawing.Image)
        Me.btnSearchBank.Name = "btnSearchBank"
        '
        'lblCompanyID
        '
        Me.lblCompanyID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblCompanyID.Name = "lblCompanyID"
        Me.lblCompanyID.Width = 50
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
        Me.lblCompanyName.Width = 629
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
        Me.txtNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Maturity: "
        Me.InputLabel24.Width = 100
        '
        'dtMaturity
        '
        Me.dtMaturity.Enabled = False
        Me.dtMaturity.Name = "dtMaturity"
        '
        'InputLabel21
        '
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Interest: "
        Me.InputLabel21.Width = 70
        '
        'txtInterest
        '
        Me.txtInterest.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Rate: "
        Me.InputLabel2.Width = 100
        '
        'txtRate
        '
        Me.txtRate.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtRate.Enabled = False
        Me.txtRate.Name = "txtRate"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.fgManual.Location = New System.Drawing.Point(0, 103)
        Me.fgManual.Name = "fgManual"
        Me.fgManual.Rows.DefaultSize = 19
        Me.fgManual.Size = New System.Drawing.Size(967, 284)
        Me.fgManual.TabIndex = 17
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
        Me.C1InputPanel4.Items.Add(Me.btnSearch)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel4.Items.Add(Me.InputLabel11)
        Me.C1InputPanel4.Items.Add(Me.rbAll)
        Me.C1InputPanel4.Items.Add(Me.rbCash)
        Me.C1InputPanel4.Items.Add(Me.rbTD)
        Me.C1InputPanel4.Items.Add(Me.InputLabel12)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryQty)
        Me.C1InputPanel4.Items.Add(Me.InputLabel22)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryAccrued)
        Me.C1InputPanel4.Items.Add(Me.InputLabel26)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryTotal)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(967, 103)
        Me.C1InputPanel4.TabIndex = 4
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
        Me.lblPortfolioNameManual.Width = 686
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
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
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Bank Type"
        Me.InputLabel11.Width = 100
        '
        'rbAll
        '
        Me.rbAll.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbAll.Checked = True
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Text = "All"
        '
        'rbCash
        '
        Me.rbCash.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Text = "Cash"
        '
        'rbTD
        '
        Me.rbTD.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.rbTD.Name = "rbTD"
        Me.rbTD.Text = "TD"
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Nominal"
        Me.InputLabel12.Width = 120
        '
        'txtSummaryQty
        '
        Me.txtSummaryQty.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtSummaryQty.Name = "txtSummaryQty"
        Me.txtSummaryQty.ReadOnly = True
        Me.txtSummaryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSummaryQty.Width = 120
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
        'txtSummaryAccrued
        '
        Me.txtSummaryAccrued.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtSummaryAccrued.Name = "txtSummaryAccrued"
        Me.txtSummaryAccrued.ReadOnly = True
        Me.txtSummaryAccrued.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSummaryAccrued.Width = 120
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
        'txtSummaryTotal
        '
        Me.txtSummaryTotal.Name = "txtSummaryTotal"
        Me.txtSummaryTotal.ReadOnly = True
        Me.txtSummaryTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSummaryTotal.Width = 120
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage2.Controls.Add(Me.fgExcel)
        Me.C1DockingTabPage2.Controls.Add(Me.pbExcel)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel1)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(967, 521)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "OVERRIDE FILE SCB"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel3.Items.Add(Me.InputLabel7)
        Me.C1InputPanel3.Items.Add(Me.cmbExternalSecurities)
        Me.C1InputPanel3.Items.Add(Me.btnRun)
        Me.C1InputPanel3.Items.Add(Me.InputLabel8)
        Me.C1InputPanel3.Items.Add(Me.lblRecords)
        Me.C1InputPanel3.Items.Add(Me.InputLabel10)
        Me.C1InputPanel3.Items.Add(Me.lblFailed)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 451)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(967, 70)
        Me.C1InputPanel3.TabIndex = 12
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "FILE UPLOAD"
        '
        'InputLabel9
        '
        Me.InputLabel9.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Portfolio Identification: "
        Me.InputLabel9.Width = 150
        '
        'cmbExternalPortfolio
        '
        Me.cmbExternalPortfolio.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbExternalPortfolio.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalPortfolio.Name = "cmbExternalPortfolio"
        Me.cmbExternalPortfolio.Width = 150
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Securities Identfiication"
        Me.InputLabel7.Width = 135
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
        Me.btnRun.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Number of portfolio(s): "
        Me.InputLabel8.Width = 135
        '
        'lblRecords
        '
        Me.lblRecords.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Width = 45
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Number of fail(s): "
        '
        'lblFailed
        '
        Me.lblFailed.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblFailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Width = 50
        '
        'fgExcel
        '
        Me.fgExcel.AllowEditing = False
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgExcel.Location = New System.Drawing.Point(0, 103)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(967, 348)
        Me.fgExcel.TabIndex = 11
        '
        'pbExcel
        '
        Me.pbExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbExcel.Location = New System.Drawing.Point(0, 80)
        Me.pbExcel.Name = "pbExcel"
        Me.pbExcel.Size = New System.Drawing.Size(967, 23)
        Me.pbExcel.TabIndex = 10
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.btnBrowse)
        Me.C1InputPanel1.Items.Add(Me.txtFilename)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.txtSheet)
        Me.C1InputPanel1.Items.Add(Me.InputLabel28)
        Me.C1InputPanel1.Items.Add(Me.txtRowStart)
        Me.C1InputPanel1.Items.Add(Me.InputLabel31)
        Me.C1InputPanel1.Items.Add(Me.txtColStart)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.txtColNo)
        Me.C1InputPanel1.Items.Add(Me.btnRead)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.lblDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel27)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(967, 80)
        Me.C1InputPanel1.TabIndex = 9
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "FILE SELECTION"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Filename: "
        Me.InputLabel3.Width = 75
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
        Me.txtFilename.Width = 818
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Worksheet: "
        Me.InputLabel4.Width = 169
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
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "No of col: "
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
        Me.btnRead.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Date: "
        Me.InputLabel6.Width = 76
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
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(967, 521)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "OVERRIDE FILE X.D.1"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel14)
        Me.C1InputPanel2.Items.Add(Me.InputButton1)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox1)
        Me.C1InputPanel2.Items.Add(Me.InputLabel16)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel17)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel18)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox4)
        Me.C1InputPanel2.Items.Add(Me.InputLabel19)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox5)
        Me.C1InputPanel2.Items.Add(Me.InputButton2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel20)
        Me.C1InputPanel2.Items.Add(Me.InputLabel23)
        Me.C1InputPanel2.Items.Add(Me.InputLabel29)
        Me.C1InputPanel2.Items.Add(Me.InputLabel30)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(967, 80)
        Me.C1InputPanel2.TabIndex = 10
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "FILE SELECTION"
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Filename: "
        Me.InputLabel14.Width = 75
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.Name = "InputButton1"
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.Text = "C:\"
        Me.InputTextBox1.Width = 818
        '
        'InputLabel16
        '
        Me.InputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "Worksheet: "
        Me.InputLabel16.Width = 169
        '
        'InputTextBox2
        '
        Me.InputTextBox2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox2.Name = "InputTextBox2"
        Me.InputTextBox2.Text = "Sheet1"
        '
        'InputLabel17
        '
        Me.InputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel17.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Start row: "
        '
        'InputTextBox3
        '
        Me.InputTextBox3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox3.Name = "InputTextBox3"
        Me.InputTextBox3.Text = "2"
        Me.InputTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputTextBox3.Width = 35
        '
        'InputLabel18
        '
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Start col: "
        '
        'InputTextBox4
        '
        Me.InputTextBox4.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox4.Name = "InputTextBox4"
        Me.InputTextBox4.Text = "1"
        Me.InputTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputTextBox4.Width = 35
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "No of col: "
        '
        'InputTextBox5
        '
        Me.InputTextBox5.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox5.Name = "InputTextBox5"
        Me.InputTextBox5.Text = "7"
        Me.InputTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputTextBox5.Width = 35
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton2.Image = CType(resources.GetObject("InputButton2.Image"), System.Drawing.Image)
        Me.InputButton2.Name = "InputButton2"
        '
        'InputLabel20
        '
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "Date: "
        Me.InputLabel20.Width = 76
        '
        'InputLabel23
        '
        Me.InputLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel23.ForeColor = System.Drawing.Color.Red
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Width = 100
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Number of rows: "
        '
        'InputLabel30
        '
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.ForeColor = System.Drawing.Color.Red
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Width = 35
        '
        'FormEODOverrideBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 546)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideBank"
        Me.Text = "END OF DAY: Override Bank Account & Time Deposit"
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCodeManual As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioNameManual As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbAll As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCash As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbTD As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents fgManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearchBank As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblCompanyCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCompanyName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbBankAccount As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbDeposit As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNominal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtInterest As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRate As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtMaturity As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnBrowse As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtFilename As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSheet As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRowStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtColNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnRead As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents pbExcel As ProgressBar
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalSecurities As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRecords As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox2 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox3 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox4 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox5 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccountID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbBankAccount As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents txtSummaryQty As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSummaryAccrued As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSummaryTotal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblCompanyID As C1.Win.C1InputPanel.InputLabel
End Class
