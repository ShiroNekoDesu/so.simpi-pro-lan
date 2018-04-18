<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEODChargesAccrual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODChargesAccrual))
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel33 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTypeCalculation = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTypeAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel34 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFlatRate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblVATRate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblVATType = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBaseDays = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualDays = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualValue = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualTotal = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSaveAccrual = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveAccrual = New C1.Win.C1InputPanel.InputButton()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.DBGDaily = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DBGAccrual = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastDate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastDaily = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastBeforeVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastDay = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastRate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblParameter = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsDate = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAsAmount = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblAsDaily = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsBeforeVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsDay = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsRate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblReconcileAccrualID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnSaveReconcileAccrual = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveReconcileAccrual = New C1.Win.C1InputPanel.InputButton()
        Me.DBGReconcileAccrual = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel66 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel32 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel39 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel40 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastDate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLast = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastDaily = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastBeforeVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastDay = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDLastRate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDParameter = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel50 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel68 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel51 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel52 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel53 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel54 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel55 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel56 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel57 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsDate = New C1.Win.C1InputPanel.InputLabel()
        Me.txtYTDAs = New C1.Win.C1InputPanel.InputTextBox()
        Me.lblYTDAsAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsDaily = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsBeforeVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsDay = New C1.Win.C1InputPanel.InputLabel()
        Me.lblYTDAsRate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblReconcileYTDID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnSaveReconcileYTD = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveReconcileYTD = New C1.Win.C1InputPanel.InputButton()
        Me.DBGReconcileYTD = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbFee = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblPortfolioID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.DBGDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGAccrual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGReconcileAccrual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGReconcileYTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 104)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.Size = New System.Drawing.Size(858, 425)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.C1SplitContainer1)
        Me.C1DockingTabPage1.Controls.Add(Me.DBGAccrual)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(856, 400)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "ACCRUAL DAILY"
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 279)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(856, 119)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 7
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.C1InputPanel3)
        Me.C1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(594, 119)
        Me.C1SplitterPanel1.SizeRatio = 69.474R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Width = 594
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel3.Items.Add(Me.InputLabel33)
        Me.C1InputPanel3.Items.Add(Me.lblTypeCalculation)
        Me.C1InputPanel3.Items.Add(Me.InputLabel35)
        Me.C1InputPanel3.Items.Add(Me.lblTypeAUM)
        Me.C1InputPanel3.Items.Add(Me.InputLabel34)
        Me.C1InputPanel3.Items.Add(Me.lblFlatRate)
        Me.C1InputPanel3.Items.Add(Me.InputLabel36)
        Me.C1InputPanel3.Items.Add(Me.lblVATRate)
        Me.C1InputPanel3.Items.Add(Me.lblVATType)
        Me.C1InputPanel3.Items.Add(Me.InputLabel37)
        Me.C1InputPanel3.Items.Add(Me.lblBaseDays)
        Me.C1InputPanel3.Items.Add(Me.InputLabel23)
        Me.C1InputPanel3.Items.Add(Me.lblNAVDate)
        Me.C1InputPanel3.Items.Add(Me.InputLabel24)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualAUM)
        Me.C1InputPanel3.Items.Add(Me.InputLabel25)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualDays)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualID)
        Me.C1InputPanel3.Items.Add(Me.InputLabel26)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualValue)
        Me.C1InputPanel3.Items.Add(Me.InputLabel27)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualVAT)
        Me.C1InputPanel3.Items.Add(Me.InputLabel28)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualTotal)
        Me.C1InputPanel3.Items.Add(Me.btnSaveAccrual)
        Me.C1InputPanel3.Items.Add(Me.btnRemoveAccrual)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(594, 119)
        Me.C1InputPanel3.TabIndex = 0
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "DAILY ACCRUAL CALCULATION"
        '
        'InputLabel33
        '
        Me.InputLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel33.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel33.Name = "InputLabel33"
        Me.InputLabel33.Text = "Type: : "
        Me.InputLabel33.Width = 55
        '
        'lblTypeCalculation
        '
        Me.lblTypeCalculation.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTypeCalculation.Name = "lblTypeCalculation"
        Me.lblTypeCalculation.Width = 105
        '
        'InputLabel35
        '
        Me.InputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel35.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel35.Name = "InputLabel35"
        Me.InputLabel35.Text = "AUM: "
        Me.InputLabel35.Width = 55
        '
        'lblTypeAUM
        '
        Me.lblTypeAUM.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTypeAUM.Name = "lblTypeAUM"
        Me.lblTypeAUM.Width = 105
        '
        'InputLabel34
        '
        Me.InputLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel34.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel34.Name = "InputLabel34"
        Me.InputLabel34.Text = "Rate: "
        Me.InputLabel34.Width = 55
        '
        'lblFlatRate
        '
        Me.lblFlatRate.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFlatRate.Name = "lblFlatRate"
        Me.lblFlatRate.Width = 105
        '
        'InputLabel36
        '
        Me.InputLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel36.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Text = "VAT: "
        Me.InputLabel36.Width = 55
        '
        'lblVATRate
        '
        Me.lblVATRate.Name = "lblVATRate"
        Me.lblVATRate.Width = 30
        '
        'lblVATType
        '
        Me.lblVATType.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblVATType.Name = "lblVATType"
        Me.lblVATType.Width = 75
        '
        'InputLabel37
        '
        Me.InputLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel37.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel37.Name = "InputLabel37"
        Me.InputLabel37.Text = "Base: "
        Me.InputLabel37.Width = 55
        '
        'lblBaseDays
        '
        Me.lblBaseDays.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblBaseDays.Name = "lblBaseDays"
        Me.lblBaseDays.Width = 105
        '
        'InputLabel23
        '
        Me.InputLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel23.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Text = "NAV Date: "
        Me.InputLabel23.Width = 65
        '
        'lblNAVDate
        '
        Me.lblNAVDate.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNAVDate.Name = "lblNAVDate"
        Me.lblNAVDate.Width = 110
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "AUM: "
        Me.InputLabel24.Width = 65
        '
        'lblAccrualAUM
        '
        Me.lblAccrualAUM.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualAUM.Name = "lblAccrualAUM"
        Me.lblAccrualAUM.Width = 110
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Day(s): "
        Me.InputLabel25.Width = 65
        '
        'lblAccrualDays
        '
        Me.lblAccrualDays.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualDays.Name = "lblAccrualDays"
        Me.lblAccrualDays.Width = 110
        '
        'lblAccrualID
        '
        Me.lblAccrualID.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblAccrualID.Name = "lblAccrualID"
        Me.lblAccrualID.Width = 150
        '
        'InputLabel26
        '
        Me.InputLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel26.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel26.Name = "InputLabel26"
        Me.InputLabel26.Text = "Accrual Value: "
        Me.InputLabel26.Width = 85
        '
        'lblAccrualValue
        '
        Me.lblAccrualValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualValue.Name = "lblAccrualValue"
        Me.lblAccrualValue.Width = 115
        '
        'InputLabel27
        '
        Me.InputLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel27.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel27.Name = "InputLabel27"
        Me.InputLabel27.Text = "VAT: "
        Me.InputLabel27.Width = 85
        '
        'lblAccrualVAT
        '
        Me.lblAccrualVAT.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualVAT.Name = "lblAccrualVAT"
        Me.lblAccrualVAT.Width = 115
        '
        'InputLabel28
        '
        Me.InputLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel28.Name = "InputLabel28"
        Me.InputLabel28.Text = "Accrual Total: "
        '
        'lblAccrualTotal
        '
        Me.lblAccrualTotal.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualTotal.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualTotal.Name = "lblAccrualTotal"
        Me.lblAccrualTotal.Width = 115
        '
        'btnSaveAccrual
        '
        Me.btnSaveAccrual.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSaveAccrual.Enabled = False
        Me.btnSaveAccrual.Height = 35
        Me.btnSaveAccrual.Image = CType(resources.GetObject("btnSaveAccrual.Image"), System.Drawing.Image)
        Me.btnSaveAccrual.Name = "btnSaveAccrual"
        Me.btnSaveAccrual.Text = "SAVE"
        Me.btnSaveAccrual.Width = 100
        '
        'btnRemoveAccrual
        '
        Me.btnRemoveAccrual.Enabled = False
        Me.btnRemoveAccrual.Height = 35
        Me.btnRemoveAccrual.Image = CType(resources.GetObject("btnRemoveAccrual.Image"), System.Drawing.Image)
        Me.btnRemoveAccrual.Name = "btnRemoveAccrual"
        Me.btnRemoveAccrual.Text = "REMOVE"
        Me.btnRemoveAccrual.Width = 100
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.DBGDaily)
        Me.C1SplitterPanel2.Height = 119
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(595, 0)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(261, 119)
        Me.C1SplitterPanel2.TabIndex = 1
        '
        'DBGDaily
        '
        Me.DBGDaily.BackColor = System.Drawing.Color.White
        Me.DBGDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGDaily.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGDaily.Images.Add(CType(resources.GetObject("DBGDaily.Images"), System.Drawing.Image))
        Me.DBGDaily.Location = New System.Drawing.Point(0, 0)
        Me.DBGDaily.Name = "DBGDaily"
        Me.DBGDaily.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGDaily.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGDaily.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGDaily.PrintInfo.PageSettings = CType(resources.GetObject("DBGDaily.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGDaily.PropBag = resources.GetString("DBGDaily.PropBag")
        Me.DBGDaily.RecordSelectors = False
        Me.DBGDaily.Size = New System.Drawing.Size(261, 119)
        Me.DBGDaily.TabIndex = 7
        Me.DBGDaily.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'DBGAccrual
        '
        Me.DBGAccrual.BackColor = System.Drawing.Color.White
        Me.DBGAccrual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGAccrual.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGAccrual.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGAccrual.Images.Add(CType(resources.GetObject("DBGAccrual.Images"), System.Drawing.Image))
        Me.DBGAccrual.Location = New System.Drawing.Point(0, 0)
        Me.DBGAccrual.Name = "DBGAccrual"
        Me.DBGAccrual.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGAccrual.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGAccrual.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGAccrual.PrintInfo.PageSettings = CType(resources.GetObject("DBGAccrual.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGAccrual.PropBag = resources.GetString("DBGAccrual.PropBag")
        Me.DBGAccrual.RecordSelectors = False
        Me.DBGAccrual.Size = New System.Drawing.Size(856, 279)
        Me.DBGAccrual.TabIndex = 6
        Me.DBGAccrual.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel1)
        Me.C1DockingTabPage2.Controls.Add(Me.DBGReconcileAccrual)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(856, 400)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "RECONCILE ACCRUAL"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel14)
        Me.C1InputPanel1.Items.Add(Me.InputLabel29)
        Me.C1InputPanel1.Items.Add(Me.InputLabel30)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.lblLastDate)
        Me.C1InputPanel1.Items.Add(Me.lblLastAmount)
        Me.C1InputPanel1.Items.Add(Me.lblLastDaily)
        Me.C1InputPanel1.Items.Add(Me.lblLastVAT)
        Me.C1InputPanel1.Items.Add(Me.lblLastBeforeVAT)
        Me.C1InputPanel1.Items.Add(Me.lblLastAUM)
        Me.C1InputPanel1.Items.Add(Me.lblLastDay)
        Me.C1InputPanel1.Items.Add(Me.lblLastRate)
        Me.C1InputPanel1.Items.Add(Me.lblParameter)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.InputLabel15)
        Me.C1InputPanel1.Items.Add(Me.InputLabel16)
        Me.C1InputPanel1.Items.Add(Me.InputLabel17)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.InputLabel18)
        Me.C1InputPanel1.Items.Add(Me.lblAsDate)
        Me.C1InputPanel1.Items.Add(Me.txtAsAmount)
        Me.C1InputPanel1.Items.Add(Me.lblAsDaily)
        Me.C1InputPanel1.Items.Add(Me.lblAsVAT)
        Me.C1InputPanel1.Items.Add(Me.lblAsBeforeVAT)
        Me.C1InputPanel1.Items.Add(Me.lblAsAUM)
        Me.C1InputPanel1.Items.Add(Me.lblAsDay)
        Me.C1InputPanel1.Items.Add(Me.lblAsRate)
        Me.C1InputPanel1.Items.Add(Me.lblReconcileAccrualID)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.btnSaveReconcileAccrual)
        Me.C1InputPanel1.Items.Add(Me.btnRemoveReconcileAccrual)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 250)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(856, 148)
        Me.C1InputPanel1.TabIndex = 6
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "DAILY EXPENSE RECONCILE"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Last Date"
        Me.InputLabel1.Width = 100
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Amount"
        Me.InputLabel2.Width = 75
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Daily"
        Me.InputLabel4.Width = 75
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "VAT"
        Me.InputLabel14.Width = 75
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Before VAT"
        Me.InputLabel29.Width = 75
        '
        'InputLabel30
        '
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Text = "AUM"
        Me.InputLabel30.Width = 100
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Day(s)"
        Me.InputLabel3.Width = 40
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Rate"
        Me.InputLabel9.Width = 50
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "PARAMETER"
        Me.InputLabel10.Width = 90
        '
        'lblLastDate
        '
        Me.lblLastDate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastDate.Name = "lblLastDate"
        Me.lblLastDate.Width = 100
        '
        'lblLastAmount
        '
        Me.lblLastAmount.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastAmount.Name = "lblLastAmount"
        Me.lblLastAmount.Width = 75
        '
        'lblLastDaily
        '
        Me.lblLastDaily.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastDaily.Name = "lblLastDaily"
        Me.lblLastDaily.Width = 75
        '
        'lblLastVAT
        '
        Me.lblLastVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastVAT.Name = "lblLastVAT"
        Me.lblLastVAT.Width = 75
        '
        'lblLastBeforeVAT
        '
        Me.lblLastBeforeVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastBeforeVAT.Name = "lblLastBeforeVAT"
        Me.lblLastBeforeVAT.Width = 75
        '
        'lblLastAUM
        '
        Me.lblLastAUM.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastAUM.Name = "lblLastAUM"
        Me.lblLastAUM.Width = 100
        '
        'lblLastDay
        '
        Me.lblLastDay.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastDay.Name = "lblLastDay"
        Me.lblLastDay.Width = 40
        '
        'lblLastRate
        '
        Me.lblLastRate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblLastRate.Name = "lblLastRate"
        Me.lblLastRate.Width = 50
        '
        'lblParameter
        '
        Me.lblParameter.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblParameter.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblParameter.Name = "lblParameter"
        Me.lblParameter.Width = 90
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "As of"
        Me.InputLabel5.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Amount"
        Me.InputLabel6.Width = 75
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Daily"
        Me.InputLabel8.Width = 75
        '
        'InputLabel15
        '
        Me.InputLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "VAT"
        Me.InputLabel15.Width = 75
        '
        'InputLabel16
        '
        Me.InputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "Before VAT"
        Me.InputLabel16.Width = 75
        '
        'InputLabel17
        '
        Me.InputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel17.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "AUM"
        Me.InputLabel17.Width = 100
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Day(s)"
        Me.InputLabel7.Width = 40
        '
        'InputLabel18
        '
        Me.InputLabel18.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Rate"
        Me.InputLabel18.Width = 50
        '
        'lblAsDate
        '
        Me.lblAsDate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsDate.Name = "lblAsDate"
        Me.lblAsDate.Width = 100
        '
        'txtAsAmount
        '
        Me.txtAsAmount.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAsAmount.Name = "txtAsAmount"
        Me.txtAsAmount.Width = 75
        '
        'lblAsDaily
        '
        Me.lblAsDaily.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsDaily.Name = "lblAsDaily"
        Me.lblAsDaily.Width = 75
        '
        'lblAsVAT
        '
        Me.lblAsVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsVAT.Name = "lblAsVAT"
        Me.lblAsVAT.Width = 75
        '
        'lblAsBeforeVAT
        '
        Me.lblAsBeforeVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsBeforeVAT.Name = "lblAsBeforeVAT"
        Me.lblAsBeforeVAT.Width = 75
        '
        'lblAsAUM
        '
        Me.lblAsAUM.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsAUM.Name = "lblAsAUM"
        Me.lblAsAUM.Width = 100
        '
        'lblAsDay
        '
        Me.lblAsDay.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsDay.Name = "lblAsDay"
        Me.lblAsDay.Width = 40
        '
        'lblAsRate
        '
        Me.lblAsRate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAsRate.Name = "lblAsRate"
        Me.lblAsRate.Width = 50
        '
        'lblReconcileAccrualID
        '
        Me.lblReconcileAccrualID.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblReconcileAccrualID.Name = "lblReconcileAccrualID"
        Me.lblReconcileAccrualID.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblReconcileAccrualID.Width = 89
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 839
        '
        'btnSaveReconcileAccrual
        '
        Me.btnSaveReconcileAccrual.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSaveReconcileAccrual.Enabled = False
        Me.btnSaveReconcileAccrual.Height = 35
        Me.btnSaveReconcileAccrual.Image = CType(resources.GetObject("btnSaveReconcileAccrual.Image"), System.Drawing.Image)
        Me.btnSaveReconcileAccrual.Name = "btnSaveReconcileAccrual"
        Me.btnSaveReconcileAccrual.Text = "SAVE"
        Me.btnSaveReconcileAccrual.Width = 100
        '
        'btnRemoveReconcileAccrual
        '
        Me.btnRemoveReconcileAccrual.Enabled = False
        Me.btnRemoveReconcileAccrual.Height = 35
        Me.btnRemoveReconcileAccrual.Image = CType(resources.GetObject("btnRemoveReconcileAccrual.Image"), System.Drawing.Image)
        Me.btnRemoveReconcileAccrual.Name = "btnRemoveReconcileAccrual"
        Me.btnRemoveReconcileAccrual.Text = "REMOVE"
        Me.btnRemoveReconcileAccrual.Width = 100
        '
        'DBGReconcileAccrual
        '
        Me.DBGReconcileAccrual.BackColor = System.Drawing.Color.White
        Me.DBGReconcileAccrual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGReconcileAccrual.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGReconcileAccrual.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGReconcileAccrual.Images.Add(CType(resources.GetObject("DBGReconcileAccrual.Images"), System.Drawing.Image))
        Me.DBGReconcileAccrual.Location = New System.Drawing.Point(0, 0)
        Me.DBGReconcileAccrual.Name = "DBGReconcileAccrual"
        Me.DBGReconcileAccrual.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGReconcileAccrual.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGReconcileAccrual.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGReconcileAccrual.PrintInfo.PageSettings = CType(resources.GetObject("DBGReconcileAccrual.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGReconcileAccrual.PropBag = resources.GetString("DBGReconcileAccrual.PropBag")
        Me.DBGReconcileAccrual.RecordSelectors = False
        Me.DBGReconcileAccrual.Size = New System.Drawing.Size(856, 250)
        Me.DBGReconcileAccrual.TabIndex = 5
        Me.DBGReconcileAccrual.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage3.Controls.Add(Me.DBGReconcileYTD)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(856, 400)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "RECONCILE YTD"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel4.Items.Add(Me.InputLabel11)
        Me.C1InputPanel4.Items.Add(Me.InputLabel66)
        Me.C1InputPanel4.Items.Add(Me.InputLabel12)
        Me.C1InputPanel4.Items.Add(Me.InputLabel13)
        Me.C1InputPanel4.Items.Add(Me.InputLabel19)
        Me.C1InputPanel4.Items.Add(Me.InputLabel31)
        Me.C1InputPanel4.Items.Add(Me.InputLabel32)
        Me.C1InputPanel4.Items.Add(Me.InputLabel38)
        Me.C1InputPanel4.Items.Add(Me.InputLabel39)
        Me.C1InputPanel4.Items.Add(Me.InputLabel40)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastDate)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLast)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastAmount)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastDaily)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastVAT)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastBeforeVAT)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastAUM)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastDay)
        Me.C1InputPanel4.Items.Add(Me.lblYTDLastRate)
        Me.C1InputPanel4.Items.Add(Me.lblYTDParameter)
        Me.C1InputPanel4.Items.Add(Me.InputLabel50)
        Me.C1InputPanel4.Items.Add(Me.InputLabel68)
        Me.C1InputPanel4.Items.Add(Me.InputLabel51)
        Me.C1InputPanel4.Items.Add(Me.InputLabel52)
        Me.C1InputPanel4.Items.Add(Me.InputLabel53)
        Me.C1InputPanel4.Items.Add(Me.InputLabel54)
        Me.C1InputPanel4.Items.Add(Me.InputLabel55)
        Me.C1InputPanel4.Items.Add(Me.InputLabel56)
        Me.C1InputPanel4.Items.Add(Me.InputLabel57)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsDate)
        Me.C1InputPanel4.Items.Add(Me.txtYTDAs)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsAmount)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsDaily)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsVAT)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsBeforeVAT)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsAUM)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsDay)
        Me.C1InputPanel4.Items.Add(Me.lblYTDAsRate)
        Me.C1InputPanel4.Items.Add(Me.lblReconcileYTDID)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel4.Items.Add(Me.btnSaveReconcileYTD)
        Me.C1InputPanel4.Items.Add(Me.btnRemoveReconcileYTD)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 250)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(856, 147)
        Me.C1InputPanel4.TabIndex = 7
        Me.C1InputPanel4.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "YTD EXPENSE RECONCILE"
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Last Date"
        Me.InputLabel11.Width = 100
        '
        'InputLabel66
        '
        Me.InputLabel66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel66.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel66.Name = "InputLabel66"
        Me.InputLabel66.Text = "Last YTD"
        Me.InputLabel66.Width = 100
        '
        'InputLabel12
        '
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Last Diff."
        Me.InputLabel12.Width = 75
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Daily"
        Me.InputLabel13.Width = 75
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "VAT"
        Me.InputLabel19.Width = 75
        '
        'InputLabel31
        '
        Me.InputLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel31.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel31.Name = "InputLabel31"
        Me.InputLabel31.Text = "Before VAT"
        Me.InputLabel31.Width = 75
        '
        'InputLabel32
        '
        Me.InputLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel32.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel32.Name = "InputLabel32"
        Me.InputLabel32.Text = "AUM"
        Me.InputLabel32.Width = 100
        '
        'InputLabel38
        '
        Me.InputLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel38.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Text = "Day(s)"
        Me.InputLabel38.Width = 40
        '
        'InputLabel39
        '
        Me.InputLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel39.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel39.Name = "InputLabel39"
        Me.InputLabel39.Text = "Rate"
        Me.InputLabel39.Width = 50
        '
        'InputLabel40
        '
        Me.InputLabel40.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel40.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel40.Name = "InputLabel40"
        Me.InputLabel40.Text = "PARAMETER"
        Me.InputLabel40.Width = 90
        '
        'lblYTDLastDate
        '
        Me.lblYTDLastDate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastDate.Name = "lblYTDLastDate"
        Me.lblYTDLastDate.Width = 100
        '
        'lblYTDLast
        '
        Me.lblYTDLast.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLast.Name = "lblYTDLast"
        Me.lblYTDLast.Width = 100
        '
        'lblYTDLastAmount
        '
        Me.lblYTDLastAmount.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastAmount.Name = "lblYTDLastAmount"
        Me.lblYTDLastAmount.Width = 75
        '
        'lblYTDLastDaily
        '
        Me.lblYTDLastDaily.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastDaily.Name = "lblYTDLastDaily"
        Me.lblYTDLastDaily.Width = 75
        '
        'lblYTDLastVAT
        '
        Me.lblYTDLastVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastVAT.Name = "lblYTDLastVAT"
        Me.lblYTDLastVAT.Width = 75
        '
        'lblYTDLastBeforeVAT
        '
        Me.lblYTDLastBeforeVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastBeforeVAT.Name = "lblYTDLastBeforeVAT"
        Me.lblYTDLastBeforeVAT.Width = 75
        '
        'lblYTDLastAUM
        '
        Me.lblYTDLastAUM.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastAUM.Name = "lblYTDLastAUM"
        Me.lblYTDLastAUM.Width = 100
        '
        'lblYTDLastDay
        '
        Me.lblYTDLastDay.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastDay.Name = "lblYTDLastDay"
        Me.lblYTDLastDay.Width = 40
        '
        'lblYTDLastRate
        '
        Me.lblYTDLastRate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDLastRate.Name = "lblYTDLastRate"
        Me.lblYTDLastRate.Width = 50
        '
        'lblYTDParameter
        '
        Me.lblYTDParameter.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblYTDParameter.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDParameter.Name = "lblYTDParameter"
        Me.lblYTDParameter.Width = 90
        '
        'InputLabel50
        '
        Me.InputLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel50.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel50.Name = "InputLabel50"
        Me.InputLabel50.Text = "As of"
        Me.InputLabel50.Width = 100
        '
        'InputLabel68
        '
        Me.InputLabel68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel68.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel68.Name = "InputLabel68"
        Me.InputLabel68.Text = "As YTD"
        Me.InputLabel68.Width = 100
        '
        'InputLabel51
        '
        Me.InputLabel51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel51.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel51.Name = "InputLabel51"
        Me.InputLabel51.Text = "Difference"
        Me.InputLabel51.Width = 75
        '
        'InputLabel52
        '
        Me.InputLabel52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel52.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel52.Name = "InputLabel52"
        Me.InputLabel52.Text = "Daily"
        Me.InputLabel52.Width = 75
        '
        'InputLabel53
        '
        Me.InputLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel53.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel53.Name = "InputLabel53"
        Me.InputLabel53.Text = "VAT"
        Me.InputLabel53.Width = 75
        '
        'InputLabel54
        '
        Me.InputLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel54.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel54.Name = "InputLabel54"
        Me.InputLabel54.Text = "Before VAT"
        Me.InputLabel54.Width = 75
        '
        'InputLabel55
        '
        Me.InputLabel55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel55.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel55.Name = "InputLabel55"
        Me.InputLabel55.Text = "AUM"
        Me.InputLabel55.Width = 100
        '
        'InputLabel56
        '
        Me.InputLabel56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel56.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel56.Name = "InputLabel56"
        Me.InputLabel56.Text = "Day(s)"
        Me.InputLabel56.Width = 40
        '
        'InputLabel57
        '
        Me.InputLabel57.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel57.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel57.Name = "InputLabel57"
        Me.InputLabel57.Text = "Rate"
        Me.InputLabel57.Width = 50
        '
        'lblYTDAsDate
        '
        Me.lblYTDAsDate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsDate.Name = "lblYTDAsDate"
        Me.lblYTDAsDate.Width = 100
        '
        'txtYTDAs
        '
        Me.txtYTDAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtYTDAs.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.txtYTDAs.Name = "txtYTDAs"
        '
        'lblYTDAsAmount
        '
        Me.lblYTDAsAmount.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsAmount.Name = "lblYTDAsAmount"
        Me.lblYTDAsAmount.Width = 75
        '
        'lblYTDAsDaily
        '
        Me.lblYTDAsDaily.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsDaily.Name = "lblYTDAsDaily"
        Me.lblYTDAsDaily.Width = 75
        '
        'lblYTDAsVAT
        '
        Me.lblYTDAsVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsVAT.Name = "lblYTDAsVAT"
        Me.lblYTDAsVAT.Width = 75
        '
        'lblYTDAsBeforeVAT
        '
        Me.lblYTDAsBeforeVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsBeforeVAT.Name = "lblYTDAsBeforeVAT"
        Me.lblYTDAsBeforeVAT.Width = 75
        '
        'lblYTDAsAUM
        '
        Me.lblYTDAsAUM.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsAUM.Name = "lblYTDAsAUM"
        Me.lblYTDAsAUM.Width = 100
        '
        'lblYTDAsDay
        '
        Me.lblYTDAsDay.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsDay.Name = "lblYTDAsDay"
        Me.lblYTDAsDay.Width = 40
        '
        'lblYTDAsRate
        '
        Me.lblYTDAsRate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblYTDAsRate.Name = "lblYTDAsRate"
        Me.lblYTDAsRate.Width = 50
        '
        'lblReconcileYTDID
        '
        Me.lblReconcileYTDID.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblReconcileYTDID.Name = "lblReconcileYTDID"
        Me.lblReconcileYTDID.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblReconcileYTDID.Width = 89
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 839
        '
        'btnSaveReconcileYTD
        '
        Me.btnSaveReconcileYTD.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSaveReconcileYTD.Enabled = False
        Me.btnSaveReconcileYTD.Height = 35
        Me.btnSaveReconcileYTD.Image = CType(resources.GetObject("btnSaveReconcileYTD.Image"), System.Drawing.Image)
        Me.btnSaveReconcileYTD.Name = "btnSaveReconcileYTD"
        Me.btnSaveReconcileYTD.Text = "SAVE"
        Me.btnSaveReconcileYTD.Width = 100
        '
        'btnRemoveReconcileYTD
        '
        Me.btnRemoveReconcileYTD.Enabled = False
        Me.btnRemoveReconcileYTD.Height = 35
        Me.btnRemoveReconcileYTD.Image = CType(resources.GetObject("btnRemoveReconcileYTD.Image"), System.Drawing.Image)
        Me.btnRemoveReconcileYTD.Name = "btnRemoveReconcileYTD"
        Me.btnRemoveReconcileYTD.Text = "REMOVE"
        Me.btnRemoveReconcileYTD.Width = 100
        '
        'DBGReconcileYTD
        '
        Me.DBGReconcileYTD.BackColor = System.Drawing.Color.White
        Me.DBGReconcileYTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGReconcileYTD.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGReconcileYTD.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGReconcileYTD.Images.Add(CType(resources.GetObject("DBGReconcileYTD.Images"), System.Drawing.Image))
        Me.DBGReconcileYTD.Location = New System.Drawing.Point(0, 0)
        Me.DBGReconcileYTD.Name = "DBGReconcileYTD"
        Me.DBGReconcileYTD.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGReconcileYTD.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGReconcileYTD.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGReconcileYTD.PrintInfo.PageSettings = CType(resources.GetObject("DBGReconcileYTD.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGReconcileYTD.PropBag = resources.GetString("DBGReconcileYTD.PropBag")
        Me.DBGReconcileYTD.RecordSelectors = False
        Me.DBGReconcileYTD.Size = New System.Drawing.Size(856, 250)
        Me.DBGReconcileYTD.TabIndex = 6
        Me.DBGReconcileYTD.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel20)
        Me.C1InputPanel2.Items.Add(Me.cmbFee)
        Me.C1InputPanel2.Items.Add(Me.InputLabel21)
        Me.C1InputPanel2.Items.Add(Me.InputLabel22)
        Me.C1InputPanel2.Items.Add(Me.dtAs)
        Me.C1InputPanel2.Items.Add(Me.txtKeyword)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel2.Items.Add(Me.lblPortfolioID)
        Me.C1InputPanel2.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel2.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(858, 104)
        Me.C1InputPanel2.TabIndex = 2
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel20
        '
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "Charges: "
        Me.InputLabel20.Width = 50
        '
        'cmbFee
        '
        Me.cmbFee.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbFee.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbFee.Name = "cmbFee"
        Me.cmbFee.Width = 120
        '
        'InputLabel21
        '
        Me.InputLabel21.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Keyword, that simillar with portfolio code and/or name"
        '
        'InputLabel22
        '
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "As of: "
        Me.InputLabel22.Width = 50
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        Me.dtAs.Width = 120
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 635
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ToolTipText = "Search client"
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "MASTER PORTFOLIO"
        '
        'lblPortfolioID
        '
        Me.lblPortfolioID.Name = "lblPortfolioID"
        Me.lblPortfolioID.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblPortfolioID.Width = 1
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 729
        '
        'FormEODChargesAccrual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 526)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Name = "FormEODChargesAccrual"
        Me.Text = "END OF DAY: Charges Accrual"
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        CType(Me.DBGDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGAccrual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGReconcileAccrual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGReconcileYTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents DBGReconcileAccrual As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastDay As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastDaily As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAsAmount As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblAsDay As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsDaily As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSaveReconcileAccrual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveReconcileAccrual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbFee As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGAccrual As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents DBGDaily As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBaseDays As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualDays As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSaveAccrual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveAccrual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblAccrualAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTypeCalculation As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel33 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel34 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel37 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTypeAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFlatRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblVATType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblVATRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualTotal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastBeforeVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblParameter As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsBeforeVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblReconcileAccrualID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGReconcileYTD As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel32 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel39 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel40 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastDaily As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastBeforeVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastDay As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLastRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDParameter As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel50 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel51 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel52 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel53 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel54 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel55 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel56 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel57 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtYTDAs As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblYTDAsDaily As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsBeforeVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsDay As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblReconcileYTDID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnSaveReconcileYTD As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveReconcileYTD As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel66 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDLast As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel68 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblYTDAsAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioID As C1.Win.C1InputPanel.InputLabel
End Class
