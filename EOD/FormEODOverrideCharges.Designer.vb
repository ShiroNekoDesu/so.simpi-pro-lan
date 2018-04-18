<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODOverrideCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideCharges))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbFee = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnLoad = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTotalAccrual = New C1.Win.C1InputPanel.InputLabel()
        Me.DBGAccrual = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblPortfolioID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel33 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTypeCalculation = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTypeAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel34 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFlatRate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBaseDays = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblVATRate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblVATType = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVDate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualAUM = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualDays = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualValue = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualVAT = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccrualTotal = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSaveAccrual = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveAccrual = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCurrent = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLast = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPayment = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblMovement = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNet = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDaily = New C1.Win.C1InputPanel.InputLabel()
        Me.DBGDaily = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGAccrual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.cmbFee)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.dtAs)
        Me.C1InputPanel2.Items.Add(Me.btnLoad)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.lblTotalAccrual)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(947, 58)
        Me.C1InputPanel2.TabIndex = 17
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "NAV PERIOD"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Charges: "
        '
        'cmbFee
        '
        Me.cmbFee.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbFee.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbFee.Name = "cmbFee"
        Me.cmbFee.Width = 150
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "As Of: "
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        '
        'btnLoad
        '
        Me.btnLoad.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Total Accrual: "
        Me.InputLabel7.Width = 379
        '
        'lblTotalAccrual
        '
        Me.lblTotalAccrual.Name = "lblTotalAccrual"
        Me.lblTotalAccrual.Width = 150
        '
        'DBGAccrual
        '
        Me.DBGAccrual.BackColor = System.Drawing.Color.White
        Me.DBGAccrual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGAccrual.ContextMenuStrip = Me.csMenu
        Me.DBGAccrual.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGAccrual.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGAccrual.Images.Add(CType(resources.GetObject("DBGAccrual.Images"), System.Drawing.Image))
        Me.DBGAccrual.Location = New System.Drawing.Point(0, 58)
        Me.DBGAccrual.Name = "DBGAccrual"
        Me.DBGAccrual.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGAccrual.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGAccrual.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGAccrual.PrintInfo.PageSettings = CType(resources.GetObject("DBGAccrual.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGAccrual.PropBag = resources.GetString("DBGAccrual.PropBag")
        Me.DBGAccrual.RecordSelectors = False
        Me.DBGAccrual.Size = New System.Drawing.Size(947, 251)
        Me.DBGAccrual.TabIndex = 18
        Me.DBGAccrual.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.lblPortfolioID)
        Me.C1InputPanel3.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel3.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel3.Items.Add(Me.InputLabel33)
        Me.C1InputPanel3.Items.Add(Me.lblTypeCalculation)
        Me.C1InputPanel3.Items.Add(Me.InputLabel35)
        Me.C1InputPanel3.Items.Add(Me.lblTypeAUM)
        Me.C1InputPanel3.Items.Add(Me.InputLabel34)
        Me.C1InputPanel3.Items.Add(Me.lblFlatRate)
        Me.C1InputPanel3.Items.Add(Me.InputLabel37)
        Me.C1InputPanel3.Items.Add(Me.lblBaseDays)
        Me.C1InputPanel3.Items.Add(Me.InputLabel36)
        Me.C1InputPanel3.Items.Add(Me.lblVATRate)
        Me.C1InputPanel3.Items.Add(Me.lblVATType)
        Me.C1InputPanel3.Items.Add(Me.InputLabel23)
        Me.C1InputPanel3.Items.Add(Me.lblNAVDate)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualID)
        Me.C1InputPanel3.Items.Add(Me.InputLabel24)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualAUM)
        Me.C1InputPanel3.Items.Add(Me.InputLabel25)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualDays)
        Me.C1InputPanel3.Items.Add(Me.InputLabel26)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualValue)
        Me.C1InputPanel3.Items.Add(Me.InputLabel27)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualVAT)
        Me.C1InputPanel3.Items.Add(Me.InputLabel28)
        Me.C1InputPanel3.Items.Add(Me.lblAccrualTotal)
        Me.C1InputPanel3.Items.Add(Me.btnSaveAccrual)
        Me.C1InputPanel3.Items.Add(Me.btnRemoveAccrual)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel3.Items.Add(Me.InputLabel5)
        Me.C1InputPanel3.Items.Add(Me.txtCurrent)
        Me.C1InputPanel3.Items.Add(Me.InputLabel6)
        Me.C1InputPanel3.Items.Add(Me.txtLast)
        Me.C1InputPanel3.Items.Add(Me.InputLabel3)
        Me.C1InputPanel3.Items.Add(Me.txtPayment)
        Me.C1InputPanel3.Items.Add(Me.InputLabel2)
        Me.C1InputPanel3.Items.Add(Me.lblMovement)
        Me.C1InputPanel3.Items.Add(Me.InputLabel4)
        Me.C1InputPanel3.Items.Add(Me.lblNet)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.lblDaily)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 309)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(728, 199)
        Me.C1InputPanel3.TabIndex = 19
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'lblPortfolioID
        '
        Me.lblPortfolioID.Name = "lblPortfolioID"
        Me.lblPortfolioID.Width = 35
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 566
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
        Me.InputLabel33.Text = "Type:"
        Me.InputLabel33.Width = 45
        '
        'lblTypeCalculation
        '
        Me.lblTypeCalculation.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTypeCalculation.Name = "lblTypeCalculation"
        Me.lblTypeCalculation.Width = 65
        '
        'InputLabel35
        '
        Me.InputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel35.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel35.Name = "InputLabel35"
        Me.InputLabel35.Text = "AUM: "
        Me.InputLabel35.Width = 45
        '
        'lblTypeAUM
        '
        Me.lblTypeAUM.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTypeAUM.Name = "lblTypeAUM"
        Me.lblTypeAUM.Width = 65
        '
        'InputLabel34
        '
        Me.InputLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel34.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel34.Name = "InputLabel34"
        Me.InputLabel34.Text = "Rate: "
        Me.InputLabel34.Width = 45
        '
        'lblFlatRate
        '
        Me.lblFlatRate.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFlatRate.Name = "lblFlatRate"
        Me.lblFlatRate.Width = 65
        '
        'InputLabel37
        '
        Me.InputLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel37.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel37.Name = "InputLabel37"
        Me.InputLabel37.Text = "Base: "
        Me.InputLabel37.Width = 45
        '
        'lblBaseDays
        '
        Me.lblBaseDays.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblBaseDays.Name = "lblBaseDays"
        Me.lblBaseDays.Width = 65
        '
        'InputLabel36
        '
        Me.InputLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel36.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Text = "VAT: "
        Me.InputLabel36.Width = 45
        '
        'lblVATRate
        '
        Me.lblVATRate.Name = "lblVATRate"
        Me.lblVATRate.Width = 20
        '
        'lblVATType
        '
        Me.lblVATType.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblVATType.Name = "lblVATType"
        Me.lblVATType.Width = 50
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
        Me.lblNAVDate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblNAVDate.Name = "lblNAVDate"
        Me.lblNAVDate.Width = 100
        '
        'lblAccrualID
        '
        Me.lblAccrualID.Name = "lblAccrualID"
        Me.lblAccrualID.Width = 27
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "AUM: "
        '
        'lblAccrualAUM
        '
        Me.lblAccrualAUM.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualAUM.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualAUM.Name = "lblAccrualAUM"
        Me.lblAccrualAUM.Width = 100
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
        Me.lblAccrualDays.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblAccrualDays.Name = "lblAccrualDays"
        Me.lblAccrualDays.Width = 100
        '
        'InputLabel26
        '
        Me.InputLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel26.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel26.Name = "InputLabel26"
        Me.InputLabel26.Text = "Accr. Val: "
        Me.InputLabel26.Width = 65
        '
        'lblAccrualValue
        '
        Me.lblAccrualValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualValue.Name = "lblAccrualValue"
        Me.lblAccrualValue.Width = 100
        '
        'InputLabel27
        '
        Me.InputLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel27.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel27.Name = "InputLabel27"
        Me.InputLabel27.Text = "VAT: "
        Me.InputLabel27.Width = 65
        '
        'lblAccrualVAT
        '
        Me.lblAccrualVAT.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccrualVAT.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualVAT.Name = "lblAccrualVAT"
        Me.lblAccrualVAT.Width = 100
        '
        'InputLabel28
        '
        Me.InputLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel28.Name = "InputLabel28"
        Me.InputLabel28.Text = "Accr.Total: "
        Me.InputLabel28.Width = 75
        '
        'lblAccrualTotal
        '
        Me.lblAccrualTotal.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblAccrualTotal.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblAccrualTotal.Name = "lblAccrualTotal"
        Me.lblAccrualTotal.Width = 85
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
        Me.btnRemoveAccrual.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnRemoveAccrual.Enabled = False
        Me.btnRemoveAccrual.Height = 35
        Me.btnRemoveAccrual.Image = CType(resources.GetObject("btnRemoveAccrual.Image"), System.Drawing.Image)
        Me.btnRemoveAccrual.Name = "btnRemoveAccrual"
        Me.btnRemoveAccrual.Text = "REMOVE"
        Me.btnRemoveAccrual.Width = 100
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "BK ACCRUAL"
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Current: "
        Me.InputLabel5.Width = 75
        '
        'txtCurrent
        '
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent.Width = 85
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Last: "
        Me.InputLabel6.Width = 75
        '
        'txtLast
        '
        Me.txtLast.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtLast.Name = "txtLast"
        Me.txtLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLast.Width = 85
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Payment: "
        Me.InputLabel3.Width = 75
        '
        'txtPayment
        '
        Me.txtPayment.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Width = 85
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Movement: "
        Me.InputLabel2.Width = 75
        '
        'lblMovement
        '
        Me.lblMovement.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblMovement.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblMovement.Name = "lblMovement"
        Me.lblMovement.Width = 100
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Net: "
        Me.InputLabel4.Width = 75
        '
        'lblNet
        '
        Me.lblNet.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNet.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Width = 100
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Daily: "
        Me.InputLabel9.Width = 75
        '
        'lblDaily
        '
        Me.lblDaily.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDaily.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDaily.Name = "lblDaily"
        Me.lblDaily.Width = 100
        '
        'DBGDaily
        '
        Me.DBGDaily.BackColor = System.Drawing.Color.White
        Me.DBGDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGDaily.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGDaily.Images.Add(CType(resources.GetObject("DBGDaily.Images"), System.Drawing.Image))
        Me.DBGDaily.Location = New System.Drawing.Point(728, 309)
        Me.DBGDaily.Name = "DBGDaily"
        Me.DBGDaily.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGDaily.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGDaily.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGDaily.PrintInfo.PageSettings = CType(resources.GetObject("DBGDaily.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGDaily.PropBag = resources.GetString("DBGDaily.PropBag")
        Me.DBGDaily.RecordSelectors = False
        Me.DBGDaily.Size = New System.Drawing.Size(219, 199)
        Me.DBGDaily.TabIndex = 20
        Me.DBGDaily.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'FormEODOverrideCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 508)
        Me.Controls.Add(Me.DBGDaily)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.DBGAccrual)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideCharges"
        Me.Text = "END OF DAY: Override Portfolio Charges"
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGAccrual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnLoad As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbFee As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents DBGAccrual As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel33 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTypeCalculation As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTypeAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel34 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFlatRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblVATRate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblVATType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel37 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBaseDays As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualAUM As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualDays As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualVAT As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccrualTotal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSaveAccrual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveAccrual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGDaily As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblPortfolioID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCurrent As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtLast As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblMovement As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNet As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDaily As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtPayment As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTotalAccrual As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
