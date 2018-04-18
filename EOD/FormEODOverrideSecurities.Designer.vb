<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODOverrideSecurities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideSecurities))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
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
        Me.InputLabel43 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblMaturity = New C1.Win.C1InputPanel.InputLabel()
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
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryQty = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryCost = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryValue = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryAccrued = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSummaryTotal = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgPortfolio = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalSecurities = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRecords = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
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
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader9 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputComboBox1 = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputComboBox2 = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel39 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel40 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel41 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel42 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox2 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox3 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox4 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel32 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox5 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel33 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel34 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.fgPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1DockingTab1.Size = New System.Drawing.Size(944, 546)
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
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(942, 521)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "OVERIDE MANUAL"
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
        Me.C1InputPanel5.Items.Add(Me.InputLabel43)
        Me.C1InputPanel5.Items.Add(Me.lblMaturity)
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
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 373)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(942, 148)
        Me.C1InputPanel5.TabIndex = 17
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
        Me.txtQty.Name = "txtQty"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQty.Width = 120
        '
        'InputLabel43
        '
        Me.InputLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel43.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel43.Name = "InputLabel43"
        Me.InputLabel43.Text = "Maturity: "
        Me.InputLabel43.Width = 65
        '
        'lblMaturity
        '
        Me.lblMaturity.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblMaturity.Name = "lblMaturity"
        Me.lblMaturity.Width = 100
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
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblMarketValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
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
        Me.txtAccruedCoupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblTotalValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
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
        Me.InputLabel19.Width = 305
        '
        'lblTTM
        '
        Me.lblTTM.Name = "lblTTM"
        Me.lblTTM.Width = 75
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "YTM: "
        '
        'lblYTM
        '
        Me.lblYTM.Name = "lblYTM"
        Me.lblYTM.Width = 75
        '
        'InputLabel10
        '
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Yield Effective: "
        '
        'lblYieldEffective
        '
        Me.lblYieldEffective.Name = "lblYieldEffective"
        Me.lblYieldEffective.Width = 75
        '
        'InputLabel23
        '
        Me.InputLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel23.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Text = "Modified Duration: "
        '
        'lblModifiedDuration
        '
        Me.lblModifiedDuration.Name = "lblModifiedDuration"
        Me.lblModifiedDuration.Width = 75
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
        Me.fgManual.Size = New System.Drawing.Size(942, 270)
        Me.fgManual.TabIndex = 16
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
        Me.C1InputPanel4.Items.Add(Me.cmbType)
        Me.C1InputPanel4.Items.Add(Me.InputLabel12)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryQty)
        Me.C1InputPanel4.Items.Add(Me.InputLabel5)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryCost)
        Me.C1InputPanel4.Items.Add(Me.InputLabel14)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryValue)
        Me.C1InputPanel4.Items.Add(Me.InputLabel22)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryAccrued)
        Me.C1InputPanel4.Items.Add(Me.InputLabel26)
        Me.C1InputPanel4.Items.Add(Me.txtSummaryTotal)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(942, 103)
        Me.C1InputPanel4.TabIndex = 3
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
        Me.lblPortfolioNameManual.Width = 662
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
        'txtSummaryQty
        '
        Me.txtSummaryQty.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtSummaryQty.Name = "txtSummaryQty"
        Me.txtSummaryQty.ReadOnly = True
        Me.txtSummaryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSummaryQty.Width = 120
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Cost"
        Me.InputLabel5.Width = 120
        '
        'txtSummaryCost
        '
        Me.txtSummaryCost.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtSummaryCost.Name = "txtSummaryCost"
        Me.txtSummaryCost.ReadOnly = True
        Me.txtSummaryCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSummaryCost.Width = 120
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
        'txtSummaryValue
        '
        Me.txtSummaryValue.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtSummaryValue.Name = "txtSummaryValue"
        Me.txtSummaryValue.ReadOnly = True
        Me.txtSummaryValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSummaryValue.Width = 120
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
        Me.C1DockingTabPage2.Controls.Add(Me.fgPortfolio)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage2.Controls.Add(Me.fgExcel)
        Me.C1DockingTabPage2.Controls.Add(Me.pbExcel)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel1)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(942, 521)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "OVERRIDE FILE SCB"
        '
        'fgPortfolio
        '
        Me.fgPortfolio.AllowEditing = False
        Me.fgPortfolio.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgPortfolio.Location = New System.Drawing.Point(0, 358)
        Me.fgPortfolio.Name = "fgPortfolio"
        Me.fgPortfolio.Rows.DefaultSize = 19
        Me.fgPortfolio.Size = New System.Drawing.Size(942, 163)
        Me.fgPortfolio.TabIndex = 12
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel3.Items.Add(Me.InputLabel6)
        Me.C1InputPanel3.Items.Add(Me.cmbExternalSecurities)
        Me.C1InputPanel3.Items.Add(Me.btnRun)
        Me.C1InputPanel3.Items.Add(Me.InputLabel7)
        Me.C1InputPanel3.Items.Add(Me.lblRecords)
        Me.C1InputPanel3.Items.Add(Me.InputLabel8)
        Me.C1InputPanel3.Items.Add(Me.lblFailed)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 288)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(942, 70)
        Me.C1InputPanel3.TabIndex = 11
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
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
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
        Me.btnRun.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Number of portfolio(s): "
        Me.InputLabel7.Width = 135
        '
        'lblRecords
        '
        Me.lblRecords.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Width = 45
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Number of fail(s): "
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
        Me.fgExcel.Size = New System.Drawing.Size(942, 185)
        Me.fgExcel.TabIndex = 6
        '
        'pbExcel
        '
        Me.pbExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbExcel.Location = New System.Drawing.Point(0, 80)
        Me.pbExcel.Name = "pbExcel"
        Me.pbExcel.Size = New System.Drawing.Size(942, 23)
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.lblDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel27)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(942, 80)
        Me.C1InputPanel1.TabIndex = 8
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
        Me.txtFilename.Width = 818
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
        Me.btnRead.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Date: "
        Me.InputLabel4.Width = 76
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
        Me.C1DockingTabPage3.Controls.Add(Me.C1FlexGrid2)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel6)
        Me.C1DockingTabPage3.Controls.Add(Me.C1FlexGrid1)
        Me.C1DockingTabPage3.Controls.Add(Me.ProgressBar1)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(942, 521)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "OVERRIDE FILE X.D.1"
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.AllowEditing = False
        Me.C1FlexGrid2.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.C1FlexGrid2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1FlexGrid2.Location = New System.Drawing.Point(0, 358)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.Rows.DefaultSize = 19
        Me.C1FlexGrid2.Size = New System.Drawing.Size(942, 163)
        Me.C1FlexGrid2.TabIndex = 13
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.BorderThickness = 1
        Me.C1InputPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader9)
        Me.C1InputPanel6.Items.Add(Me.InputLabel37)
        Me.C1InputPanel6.Items.Add(Me.InputComboBox1)
        Me.C1InputPanel6.Items.Add(Me.InputLabel38)
        Me.C1InputPanel6.Items.Add(Me.InputComboBox2)
        Me.C1InputPanel6.Items.Add(Me.InputButton3)
        Me.C1InputPanel6.Items.Add(Me.InputLabel39)
        Me.C1InputPanel6.Items.Add(Me.InputLabel40)
        Me.C1InputPanel6.Items.Add(Me.InputLabel41)
        Me.C1InputPanel6.Items.Add(Me.InputLabel42)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 288)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(942, 70)
        Me.C1InputPanel6.TabIndex = 12
        '
        'InputGroupHeader9
        '
        Me.InputGroupHeader9.Name = "InputGroupHeader9"
        Me.InputGroupHeader9.Text = "FILE UPLOAD"
        '
        'InputLabel37
        '
        Me.InputLabel37.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel37.Name = "InputLabel37"
        Me.InputLabel37.Text = "Portfolio Identification: "
        Me.InputLabel37.Width = 150
        '
        'InputComboBox1
        '
        Me.InputComboBox1.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputComboBox1.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.InputComboBox1.Name = "InputComboBox1"
        Me.InputComboBox1.Width = 150
        '
        'InputLabel38
        '
        Me.InputLabel38.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Text = "Securities Identfiication"
        Me.InputLabel38.Width = 135
        '
        'InputComboBox2
        '
        Me.InputComboBox2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputComboBox2.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.InputComboBox2.Name = "InputComboBox2"
        Me.InputComboBox2.Width = 150
        '
        'InputButton3
        '
        Me.InputButton3.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton3.Image = CType(resources.GetObject("InputButton3.Image"), System.Drawing.Image)
        Me.InputButton3.Name = "InputButton3"
        '
        'InputLabel39
        '
        Me.InputLabel39.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel39.Name = "InputLabel39"
        Me.InputLabel39.Text = "Number of portfolio(s): "
        Me.InputLabel39.Width = 135
        '
        'InputLabel40
        '
        Me.InputLabel40.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel40.ForeColor = System.Drawing.Color.Red
        Me.InputLabel40.Name = "InputLabel40"
        Me.InputLabel40.Width = 45
        '
        'InputLabel41
        '
        Me.InputLabel41.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel41.Name = "InputLabel41"
        Me.InputLabel41.Text = "Number of fail(s): "
        '
        'InputLabel42
        '
        Me.InputLabel42.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel42.ForeColor = System.Drawing.Color.Red
        Me.InputLabel42.Name = "InputLabel42"
        Me.InputLabel42.Width = 50
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 103)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(942, 185)
        Me.C1FlexGrid1.TabIndex = 11
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 80)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(942, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel20)
        Me.C1InputPanel2.Items.Add(Me.InputButton1)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox1)
        Me.C1InputPanel2.Items.Add(Me.InputLabel24)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel29)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel30)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox4)
        Me.C1InputPanel2.Items.Add(Me.InputLabel32)
        Me.C1InputPanel2.Items.Add(Me.InputTextBox5)
        Me.C1InputPanel2.Items.Add(Me.InputButton2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel33)
        Me.C1InputPanel2.Items.Add(Me.InputLabel34)
        Me.C1InputPanel2.Items.Add(Me.InputLabel35)
        Me.C1InputPanel2.Items.Add(Me.InputLabel36)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(942, 80)
        Me.C1InputPanel2.TabIndex = 9
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "FILE SELECTION"
        '
        'InputLabel20
        '
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "Filename: "
        Me.InputLabel20.Width = 75
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
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Worksheet: "
        Me.InputLabel24.Width = 169
        '
        'InputTextBox2
        '
        Me.InputTextBox2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox2.Name = "InputTextBox2"
        Me.InputTextBox2.Text = "Sheet1"
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Start row: "
        '
        'InputTextBox3
        '
        Me.InputTextBox3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox3.Name = "InputTextBox3"
        Me.InputTextBox3.Text = "2"
        Me.InputTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputTextBox3.Width = 35
        '
        'InputLabel30
        '
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Text = "Start col: "
        '
        'InputTextBox4
        '
        Me.InputTextBox4.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox4.Name = "InputTextBox4"
        Me.InputTextBox4.Text = "1"
        Me.InputTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InputTextBox4.Width = 35
        '
        'InputLabel32
        '
        Me.InputLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel32.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel32.Name = "InputLabel32"
        Me.InputLabel32.Text = "No of col: "
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
        'InputLabel33
        '
        Me.InputLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel33.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel33.Name = "InputLabel33"
        Me.InputLabel33.Text = "Date: "
        Me.InputLabel33.Width = 76
        '
        'InputLabel34
        '
        Me.InputLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel34.ForeColor = System.Drawing.Color.Red
        Me.InputLabel34.Name = "InputLabel34"
        Me.InputLabel34.Width = 100
        '
        'InputLabel35
        '
        Me.InputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel35.Name = "InputLabel35"
        Me.InputLabel35.Text = "Number of rows: "
        '
        'InputLabel36
        '
        Me.InputLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel36.ForeColor = System.Drawing.Color.Red
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Width = 35
        '
        'FormEODOverrideSecurities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 546)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideSecurities"
        Me.Text = "END OF DAY: Override Securities Holding"
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.fgPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgManual As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchSecurities As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSecuritiesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSecuritiesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCompany As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCompanyID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTypeID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtQty As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCost As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtPrice As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblMarketValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAccruedCoupon As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTotalValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTTM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYieldEffective As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblModifiedDuration As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents pbExcel As ProgressBar
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
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalSecurities As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRecords As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgPortfolio As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox2 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox3 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox4 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel32 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox5 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel33 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel34 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader9 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel37 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputComboBox1 As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputComboBox2 As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel39 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel40 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel41 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel42 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents InputLabel43 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblMaturity As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSummaryQty As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSummaryCost As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSummaryValue As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSummaryAccrued As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSummaryTotal As C1.Win.C1InputPanel.InputTextBox
End Class
