<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterSimpi
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterSimpi))
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.inputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblType = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.DBGBilling = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblShortname = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAddress = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPIC = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPhone = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserLogin = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserInitial = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel32 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel41 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTerminalMACAddress = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel44 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTerminalIPAddress = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel46 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTerminalComputerName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel48 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTerminalID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCreditCcy = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCreditAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblValid = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblGrace = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBilling = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer2 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel5 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel8 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMACAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIPAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtComputerName = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnAddTerminal = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveTerminal = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnClearSession = New C1.Win.C1InputPanel.InputButton()
        Me.DBGTerminal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1SplitterPanel6 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.DBGSession = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.DBGTicket = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader13 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel49 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTicketDescription = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel50 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbTicketType = New C1.Win.C1InputPanel.InputComboBox()
        Me.cmdTicketSubmit = New C1.Win.C1InputPanel.InputButton()
        Me.cmdTicketCancel = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader14 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel43 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel45 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel54 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtTicketFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.dtTicketTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.cmbTicketStatus = New C1.Win.C1InputPanel.InputComboBox()
        Me.cmdTicketSearch = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.DBGLog = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel72 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel73 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel74 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtLogFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.dtLogTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.txtLogKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone3 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd3 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr3 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine3 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnLogSearch = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRiskLevel = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMaximumValue = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSetRiskLevel = New C1.Win.C1InputPanel.InputButton()
        Me.DBGRisk = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.DBGQuestion = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbClientType = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnAddQuestion = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveQuestion = New C1.Win.C1InputPanel.InputButton()
        Me.btnProfileQuestion = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTabPage7 = New C1.Win.C1Command.C1DockingTabPage()
        Me.DBGKYCAvailable = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel10 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader9 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeywordKYCAvailable = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearchKYCAvailable = New C1.Win.C1InputPanel.InputButton()
        Me.btnAddKYC = New C1.Win.C1InputPanel.InputButton()
        Me.DBGKYCApply = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel9 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbClientTypeKYC = New C1.Win.C1InputPanel.InputComboBox()
        Me.txtKeywordKYCApply = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearchKYCApply = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveKYC = New C1.Win.C1InputPanel.InputButton()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.DBGBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer2.SuspendLayout()
        Me.C1SplitterPanel5.SuspendLayout()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGTerminal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel6.SuspendLayout()
        CType(Me.DBGSession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage4.SuspendLayout()
        CType(Me.DBGTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage5.SuspendLayout()
        CType(Me.DBGLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGRisk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.DBGQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage7.SuspendLayout()
        CType(Me.DBGKYCAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGKYCApply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.ContextMenuStrip = Me.csMenu
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.inputLabel14)
        Me.c1InputPanel7.Items.Add(Me.lblID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel1)
        Me.c1InputPanel7.Items.Add(Me.lblType)
        Me.c1InputPanel7.Items.Add(Me.inputLabel16)
        Me.c1InputPanel7.Items.Add(Me.inputLabel17)
        Me.c1InputPanel7.Items.Add(Me.lblName)
        Me.c1InputPanel7.Items.Add(Me.lblStatus)
        Me.c1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel7.Name = "c1InputPanel7"
        Me.c1InputPanel7.Size = New System.Drawing.Size(771, 44)
        Me.c1InputPanel7.TabIndex = 10
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'csMenu
        '
        Me.csMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttachToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.csMenu.Name = "csMenu"
        Me.csMenu.Size = New System.Drawing.Size(112, 48)
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
        'inputLabel14
        '
        Me.inputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel14.Name = "inputLabel14"
        Me.inputLabel14.Text = "ID: "
        Me.inputLabel14.Width = 50
        '
        'lblID
        '
        Me.lblID.Name = "lblID"
        Me.lblID.Width = 100
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "TYPE: "
        '
        'lblType
        '
        Me.lblType.Name = "lblType"
        Me.lblType.Width = 453
        '
        'inputLabel16
        '
        Me.inputLabel16.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.inputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.inputLabel16.Name = "inputLabel16"
        Me.inputLabel16.Text = "STATUS"
        Me.inputLabel16.Width = 75
        '
        'inputLabel17
        '
        Me.inputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel17.Name = "inputLabel17"
        Me.inputLabel17.Text = "NAME: "
        Me.inputLabel17.Width = 50
        '
        'lblName
        '
        Me.lblName.Name = "lblName"
        Me.lblName.Width = 600
        '
        'lblStatus
        '
        Me.lblStatus.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Width = 75
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.AlignTabs = System.Drawing.StringAlignment.Center
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage7)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 44)
        Me.C1DockingTab1.MultiLine = True
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(771, 461)
        Me.C1DockingTab1.TabIndex = 11
        Me.C1DockingTab1.TabLook = C1.Win.C1Command.ButtonLookFlags.Text
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.TextDirection = C1.Win.C1Command.TabTextDirectionEnum.Horizontal
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.DBGBilling)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(769, 436)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "SIMPI PROFILE"
        '
        'DBGBilling
        '
        Me.DBGBilling.BackColor = System.Drawing.Color.White
        Me.DBGBilling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGBilling.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGBilling.Images.Add(CType(resources.GetObject("DBGBilling.Images"), System.Drawing.Image))
        Me.DBGBilling.Location = New System.Drawing.Point(0, 278)
        Me.DBGBilling.Name = "DBGBilling"
        Me.DBGBilling.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGBilling.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGBilling.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGBilling.PrintInfo.PageSettings = CType(resources.GetObject("DBGBilling.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGBilling.PropBag = resources.GetString("DBGBilling.PropBag")
        Me.DBGBilling.RecordSelectors = False
        Me.DBGBilling.Size = New System.Drawing.Size(769, 159)
        Me.DBGBilling.TabIndex = 6
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel24)
        Me.C1InputPanel2.Items.Add(Me.lblShortname)
        Me.C1InputPanel2.Items.Add(Me.InputLabel25)
        Me.C1InputPanel2.Items.Add(Me.lblAddress)
        Me.C1InputPanel2.Items.Add(Me.InputLabel26)
        Me.C1InputPanel2.Items.Add(Me.lblPIC)
        Me.C1InputPanel2.Items.Add(Me.InputLabel27)
        Me.C1InputPanel2.Items.Add(Me.lblEmail)
        Me.C1InputPanel2.Items.Add(Me.InputLabel28)
        Me.C1InputPanel2.Items.Add(Me.lblPhone)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel29)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel30)
        Me.C1InputPanel2.Items.Add(Me.lblUserLogin)
        Me.C1InputPanel2.Items.Add(Me.lblUserInitial)
        Me.C1InputPanel2.Items.Add(Me.lblUserStatus)
        Me.C1InputPanel2.Items.Add(Me.InputLabel31)
        Me.C1InputPanel2.Items.Add(Me.InputLabel32)
        Me.C1InputPanel2.Items.Add(Me.lblUserName)
        Me.C1InputPanel2.Items.Add(Me.lblUserTitle)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel2.Items.Add(Me.InputLabel41)
        Me.C1InputPanel2.Items.Add(Me.lblTerminalMACAddress)
        Me.C1InputPanel2.Items.Add(Me.InputLabel44)
        Me.C1InputPanel2.Items.Add(Me.lblTerminalIPAddress)
        Me.C1InputPanel2.Items.Add(Me.InputLabel46)
        Me.C1InputPanel2.Items.Add(Me.lblTerminalComputerName)
        Me.C1InputPanel2.Items.Add(Me.InputLabel48)
        Me.C1InputPanel2.Items.Add(Me.lblTerminalID)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel2.Items.Add(Me.InputLabel3)
        Me.C1InputPanel2.Items.Add(Me.lblCreditCcy)
        Me.C1InputPanel2.Items.Add(Me.lblCreditAmount)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.lblValid)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.lblGrace)
        Me.C1InputPanel2.Items.Add(Me.InputLabel9)
        Me.C1InputPanel2.Items.Add(Me.lblBilling)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(769, 278)
        Me.C1InputPanel2.TabIndex = 4
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER SIMPI"
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Shortname*: "
        Me.InputLabel24.Width = 75
        '
        'lblShortname
        '
        Me.lblShortname.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblShortname.Name = "lblShortname"
        Me.lblShortname.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblShortname.Width = 386
        '
        'InputLabel25
        '
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.Height = 50
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Address: "
        Me.InputLabel25.Width = 75
        '
        'lblAddress
        '
        Me.lblAddress.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblAddress.Height = 50
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Width = 373
        '
        'InputLabel26
        '
        Me.InputLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel26.Name = "InputLabel26"
        Me.InputLabel26.Text = "PIC: "
        Me.InputLabel26.Width = 50
        '
        'lblPIC
        '
        Me.lblPIC.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPIC.Height = 20
        Me.lblPIC.Name = "lblPIC"
        Me.lblPIC.Width = 185
        '
        'InputLabel27
        '
        Me.InputLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel27.Name = "InputLabel27"
        Me.InputLabel27.Text = "Email: "
        Me.InputLabel27.Width = 50
        '
        'lblEmail
        '
        Me.lblEmail.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblEmail.Height = 20
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Width = 185
        '
        'InputLabel28
        '
        Me.InputLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel28.Name = "InputLabel28"
        Me.InputLabel28.Text = "Phone: "
        Me.InputLabel28.Width = 50
        '
        'lblPhone
        '
        Me.lblPhone.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPhone.Height = 20
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Width = 185
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "ADMINISTRATOR"
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "User login"
        Me.InputLabel29.Width = 450
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Initial"
        Me.InputLabel2.Width = 190
        '
        'InputLabel30
        '
        Me.InputLabel30.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.InputLabel30.Text = "Status"
        '
        'lblUserLogin
        '
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Width = 450
        '
        'lblUserInitial
        '
        Me.lblUserInitial.Name = "lblUserInitial"
        Me.lblUserInitial.Width = 190
        '
        'lblUserStatus
        '
        Me.lblUserStatus.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUserStatus.Name = "lblUserStatus"
        '
        'InputLabel31
        '
        Me.InputLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel31.Name = "InputLabel31"
        Me.InputLabel31.Text = "Username"
        Me.InputLabel31.Width = 450
        '
        'InputLabel32
        '
        Me.InputLabel32.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel32.Name = "InputLabel32"
        Me.InputLabel32.Text = "Title"
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Width = 450
        '
        'lblUserTitle
        '
        Me.lblUserTitle.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUserTitle.Name = "lblUserTitle"
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "TERMINAL"
        '
        'InputLabel41
        '
        Me.InputLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel41.Name = "InputLabel41"
        Me.InputLabel41.Text = "MAC Address: "
        '
        'lblTerminalMACAddress
        '
        Me.lblTerminalMACAddress.Name = "lblTerminalMACAddress"
        Me.lblTerminalMACAddress.Width = 100
        '
        'InputLabel44
        '
        Me.InputLabel44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel44.Name = "InputLabel44"
        Me.InputLabel44.Text = "IP Address: "
        '
        'lblTerminalIPAddress
        '
        Me.lblTerminalIPAddress.Name = "lblTerminalIPAddress"
        Me.lblTerminalIPAddress.Width = 100
        '
        'InputLabel46
        '
        Me.InputLabel46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel46.Name = "InputLabel46"
        Me.InputLabel46.Text = "Computer name: "
        '
        'lblTerminalComputerName
        '
        Me.lblTerminalComputerName.Name = "lblTerminalComputerName"
        Me.lblTerminalComputerName.Width = 200
        '
        'InputLabel48
        '
        Me.InputLabel48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel48.Name = "InputLabel48"
        Me.InputLabel48.Text = "ID: "
        '
        'lblTerminalID
        '
        Me.lblTerminalID.Name = "lblTerminalID"
        Me.lblTerminalID.Width = 50
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "CREDIT"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Price: "
        '
        'lblCreditCcy
        '
        Me.lblCreditCcy.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblCreditCcy.Name = "lblCreditCcy"
        Me.lblCreditCcy.Width = 35
        '
        'lblCreditAmount
        '
        Me.lblCreditAmount.Name = "lblCreditAmount"
        Me.lblCreditAmount.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Valid date: "
        '
        'lblValid
        '
        Me.lblValid.Name = "lblValid"
        Me.lblValid.Width = 100
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Grace period:"
        '
        'lblGrace
        '
        Me.lblGrace.Name = "lblGrace"
        Me.lblGrace.Width = 100
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Billing type: "
        '
        'lblBilling
        '
        Me.lblBilling.Name = "lblBilling"
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1SplitContainer2)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(769, 436)
        Me.C1DockingTabPage3.TabIndex = 6
        Me.C1DockingTabPage3.Text = "TERMINAL"
        '
        'C1SplitContainer2
        '
        Me.C1SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer2.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer2.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer2.Name = "C1SplitContainer2"
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel5)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel6)
        Me.C1SplitContainer2.Size = New System.Drawing.Size(769, 436)
        Me.C1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.SplitterWidth = 1
        Me.C1SplitContainer2.TabIndex = 3
        Me.C1SplitContainer2.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel5
        '
        Me.C1SplitterPanel5.Controls.Add(Me.C1InputPanel8)
        Me.C1SplitterPanel5.Controls.Add(Me.DBGTerminal)
        Me.C1SplitterPanel5.Height = 256
        Me.C1SplitterPanel5.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel5.Name = "C1SplitterPanel5"
        Me.C1SplitterPanel5.Size = New System.Drawing.Size(769, 235)
        Me.C1SplitterPanel5.SizeRatio = 58.795R
        Me.C1SplitterPanel5.TabIndex = 0
        Me.C1SplitterPanel5.Text = "LIST TERMINAL"
        Me.C1SplitterPanel5.Width = 769
        '
        'C1InputPanel8
        '
        Me.C1InputPanel8.BorderThickness = 1
        Me.C1InputPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel8.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel8.Items.Add(Me.InputLabel20)
        Me.C1InputPanel8.Items.Add(Me.txtMACAddress)
        Me.C1InputPanel8.Items.Add(Me.InputLabel21)
        Me.C1InputPanel8.Items.Add(Me.txtIPAddress)
        Me.C1InputPanel8.Items.Add(Me.InputLabel22)
        Me.C1InputPanel8.Items.Add(Me.txtComputerName)
        Me.C1InputPanel8.Items.Add(Me.btnAddTerminal)
        Me.C1InputPanel8.Items.Add(Me.btnRemoveTerminal)
        Me.C1InputPanel8.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel8.Items.Add(Me.btnClearSession)
        Me.C1InputPanel8.Location = New System.Drawing.Point(437, 0)
        Me.C1InputPanel8.Name = "C1InputPanel8"
        Me.C1InputPanel8.Size = New System.Drawing.Size(332, 227)
        Me.C1InputPanel8.TabIndex = 2
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Add new terminal, or select from list above then edit it"
        '
        'InputLabel20
        '
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "MACAddress: "
        Me.InputLabel20.Width = 90
        '
        'txtMACAddress
        '
        Me.txtMACAddress.Name = "txtMACAddress"
        Me.txtMACAddress.Width = 219
        '
        'InputLabel21
        '
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "IP Address: "
        Me.InputLabel21.Width = 90
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Width = 219
        '
        'InputLabel22
        '
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Computer name: "
        Me.InputLabel22.Width = 90
        '
        'txtComputerName
        '
        Me.txtComputerName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtComputerName.Name = "txtComputerName"
        Me.txtComputerName.Width = 162
        '
        'btnAddTerminal
        '
        Me.btnAddTerminal.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAddTerminal.Image = CType(resources.GetObject("btnAddTerminal.Image"), System.Drawing.Image)
        Me.btnAddTerminal.Name = "btnAddTerminal"
        '
        'btnRemoveTerminal
        '
        Me.btnRemoveTerminal.Image = CType(resources.GetObject("btnRemoveTerminal.Image"), System.Drawing.Image)
        Me.btnRemoveTerminal.Name = "btnRemoveTerminal"
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Height = 78
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Padding = New System.Windows.Forms.Padding(0, 55, 0, 0)
        Me.InputGroupHeader6.Text = "Select terminal session below, then click clear"
        '
        'btnClearSession
        '
        Me.btnClearSession.Height = 34
        Me.btnClearSession.Image = CType(resources.GetObject("btnClearSession.Image"), System.Drawing.Image)
        Me.btnClearSession.Name = "btnClearSession"
        Me.btnClearSession.Text = "CLEAR"
        Me.btnClearSession.Width = 100
        '
        'DBGTerminal
        '
        Me.DBGTerminal.BackColor = System.Drawing.Color.White
        Me.DBGTerminal.Dock = System.Windows.Forms.DockStyle.Left
        Me.DBGTerminal.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTerminal.Images.Add(CType(resources.GetObject("DBGTerminal.Images"), System.Drawing.Image))
        Me.DBGTerminal.Location = New System.Drawing.Point(0, 0)
        Me.DBGTerminal.Name = "DBGTerminal"
        Me.DBGTerminal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTerminal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTerminal.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTerminal.PrintInfo.PageSettings = CType(resources.GetObject("DBGTerminal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTerminal.PropBag = resources.GetString("DBGTerminal.PropBag")
        Me.DBGTerminal.RecordSelectors = False
        Me.DBGTerminal.Size = New System.Drawing.Size(437, 235)
        Me.DBGTerminal.TabIndex = 0
        '
        'C1SplitterPanel6
        '
        Me.C1SplitterPanel6.Controls.Add(Me.DBGSession)
        Me.C1SplitterPanel6.Height = 179
        Me.C1SplitterPanel6.Location = New System.Drawing.Point(0, 278)
        Me.C1SplitterPanel6.Name = "C1SplitterPanel6"
        Me.C1SplitterPanel6.Size = New System.Drawing.Size(769, 158)
        Me.C1SplitterPanel6.TabIndex = 1
        Me.C1SplitterPanel6.Text = "TERMINAL SESSION"
        '
        'DBGSession
        '
        Me.DBGSession.BackColor = System.Drawing.Color.White
        Me.DBGSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGSession.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGSession.Images.Add(CType(resources.GetObject("DBGSession.Images"), System.Drawing.Image))
        Me.DBGSession.Location = New System.Drawing.Point(0, 0)
        Me.DBGSession.Name = "DBGSession"
        Me.DBGSession.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGSession.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGSession.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGSession.PrintInfo.PageSettings = CType(resources.GetObject("DBGSession.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGSession.PropBag = resources.GetString("DBGSession.PropBag")
        Me.DBGSession.RecordSelectors = False
        Me.DBGSession.Size = New System.Drawing.Size(769, 158)
        Me.DBGSession.TabIndex = 1
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.DBGTicket)
        Me.C1DockingTabPage4.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(769, 436)
        Me.C1DockingTabPage4.TabIndex = 4
        Me.C1DockingTabPage4.Text = "TICKET"
        '
        'DBGTicket
        '
        Me.DBGTicket.BackColor = System.Drawing.Color.White
        Me.DBGTicket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGTicket.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGTicket.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTicket.Images.Add(CType(resources.GetObject("DBGTicket.Images"), System.Drawing.Image))
        Me.DBGTicket.Location = New System.Drawing.Point(0, 175)
        Me.DBGTicket.Name = "DBGTicket"
        Me.DBGTicket.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTicket.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTicket.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTicket.PrintInfo.PageSettings = CType(resources.GetObject("DBGTicket.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTicket.PropBag = resources.GetString("DBGTicket.PropBag")
        Me.DBGTicket.RecordSelectors = False
        Me.DBGTicket.Size = New System.Drawing.Size(769, 262)
        Me.DBGTicket.TabIndex = 6
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader13)
        Me.C1InputPanel5.Items.Add(Me.InputLabel49)
        Me.C1InputPanel5.Items.Add(Me.txtTicketDescription)
        Me.C1InputPanel5.Items.Add(Me.InputLabel50)
        Me.C1InputPanel5.Items.Add(Me.cmbTicketType)
        Me.C1InputPanel5.Items.Add(Me.cmdTicketSubmit)
        Me.C1InputPanel5.Items.Add(Me.cmdTicketCancel)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader14)
        Me.C1InputPanel5.Items.Add(Me.InputLabel43)
        Me.C1InputPanel5.Items.Add(Me.InputLabel45)
        Me.C1InputPanel5.Items.Add(Me.InputLabel54)
        Me.C1InputPanel5.Items.Add(Me.dtTicketFrom)
        Me.C1InputPanel5.Items.Add(Me.dtTicketTo)
        Me.C1InputPanel5.Items.Add(Me.cmbTicketStatus)
        Me.C1InputPanel5.Items.Add(Me.cmdTicketSearch)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(769, 175)
        Me.C1InputPanel5.TabIndex = 5
        Me.C1InputPanel5.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader13
        '
        Me.InputGroupHeader13.Name = "InputGroupHeader13"
        Me.InputGroupHeader13.Text = "NEW TICKET"
        '
        'InputLabel49
        '
        Me.InputLabel49.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel49.Name = "InputLabel49"
        Me.InputLabel49.Text = "Description"
        '
        'txtTicketDescription
        '
        Me.txtTicketDescription.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtTicketDescription.Height = 60
        Me.txtTicketDescription.Multiline = True
        Me.txtTicketDescription.Name = "txtTicketDescription"
        Me.txtTicketDescription.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtTicketDescription.Width = 534
        '
        'InputLabel50
        '
        Me.InputLabel50.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel50.Name = "InputLabel50"
        Me.InputLabel50.Text = "Ticket Type "
        '
        'cmbTicketType
        '
        Me.cmbTicketType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbTicketType.Name = "cmbTicketType"
        Me.cmbTicketType.Width = 203
        '
        'cmdTicketSubmit
        '
        Me.cmdTicketSubmit.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmdTicketSubmit.Image = CType(resources.GetObject("cmdTicketSubmit.Image"), System.Drawing.Image)
        Me.cmdTicketSubmit.Name = "cmdTicketSubmit"
        '
        'cmdTicketCancel
        '
        Me.cmdTicketCancel.Image = CType(resources.GetObject("cmdTicketCancel.Image"), System.Drawing.Image)
        Me.cmdTicketCancel.Name = "cmdTicketCancel"
        '
        'InputGroupHeader14
        '
        Me.InputGroupHeader14.Name = "InputGroupHeader14"
        Me.InputGroupHeader14.Text = "TICKET HISTORY"
        '
        'InputLabel43
        '
        Me.InputLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel43.Name = "InputLabel43"
        Me.InputLabel43.Text = "From date"
        Me.InputLabel43.Width = 95
        '
        'InputLabel45
        '
        Me.InputLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel45.Name = "InputLabel45"
        Me.InputLabel45.Text = "To date"
        Me.InputLabel45.Width = 95
        '
        'InputLabel54
        '
        Me.InputLabel54.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel54.Name = "InputLabel54"
        Me.InputLabel54.Text = "Status"
        Me.InputLabel54.Width = 100
        '
        'dtTicketFrom
        '
        Me.dtTicketFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtTicketFrom.Name = "dtTicketFrom"
        Me.dtTicketFrom.Value = New Date(2016, 12, 31, 0, 0, 0, 0)
        Me.dtTicketFrom.Width = 95
        '
        'dtTicketTo
        '
        Me.dtTicketTo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtTicketTo.Name = "dtTicketTo"
        Me.dtTicketTo.Width = 95
        '
        'cmbTicketStatus
        '
        Me.cmbTicketStatus.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbTicketStatus.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbTicketStatus.Name = "cmbTicketStatus"
        '
        'cmdTicketSearch
        '
        Me.cmdTicketSearch.Image = CType(resources.GetObject("cmdTicketSearch.Image"), System.Drawing.Image)
        Me.cmdTicketSearch.Name = "cmdTicketSearch"
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Controls.Add(Me.DBGLog)
        Me.C1DockingTabPage5.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(769, 436)
        Me.C1DockingTabPage5.TabIndex = 5
        Me.C1DockingTabPage5.Text = "ACTIVITY LOG"
        '
        'DBGLog
        '
        Me.DBGLog.BackColor = System.Drawing.Color.White
        Me.DBGLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGLog.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGLog.Images.Add(CType(resources.GetObject("DBGLog.Images"), System.Drawing.Image))
        Me.DBGLog.Location = New System.Drawing.Point(0, 46)
        Me.DBGLog.Name = "DBGLog"
        Me.DBGLog.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGLog.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGLog.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGLog.PrintInfo.PageSettings = CType(resources.GetObject("DBGLog.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGLog.PropBag = resources.GetString("DBGLog.PropBag")
        Me.DBGLog.RecordSelectors = False
        Me.DBGLog.Size = New System.Drawing.Size(769, 392)
        Me.DBGLog.TabIndex = 5
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputLabel72)
        Me.C1InputPanel4.Items.Add(Me.InputLabel73)
        Me.C1InputPanel4.Items.Add(Me.InputLabel74)
        Me.C1InputPanel4.Items.Add(Me.dtLogFrom)
        Me.C1InputPanel4.Items.Add(Me.dtLogTo)
        Me.C1InputPanel4.Items.Add(Me.txtLogKeyword)
        Me.C1InputPanel4.Items.Add(Me.rbNone3)
        Me.C1InputPanel4.Items.Add(Me.rbAnd3)
        Me.C1InputPanel4.Items.Add(Me.rbOr3)
        Me.C1InputPanel4.Items.Add(Me.rbCombine3)
        Me.C1InputPanel4.Items.Add(Me.btnLogSearch)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(769, 46)
        Me.C1InputPanel4.TabIndex = 4
        Me.C1InputPanel4.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel72
        '
        Me.InputLabel72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel72.Name = "InputLabel72"
        Me.InputLabel72.Text = "From date"
        Me.InputLabel72.Width = 95
        '
        'InputLabel73
        '
        Me.InputLabel73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel73.Name = "InputLabel73"
        Me.InputLabel73.Text = "To date"
        Me.InputLabel73.Width = 95
        '
        'InputLabel74
        '
        Me.InputLabel74.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel74.Name = "InputLabel74"
        Me.InputLabel74.Text = "Keyword"
        '
        'dtLogFrom
        '
        Me.dtLogFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtLogFrom.Name = "dtLogFrom"
        Me.dtLogFrom.Value = New Date(2016, 12, 31, 0, 0, 0, 0)
        Me.dtLogFrom.Width = 95
        '
        'dtLogTo
        '
        Me.dtLogTo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtLogTo.Name = "dtLogTo"
        Me.dtLogTo.Width = 95
        '
        'txtLogKeyword
        '
        Me.txtLogKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtLogKeyword.Name = "txtLogKeyword"
        Me.txtLogKeyword.Width = 300
        '
        'rbNone3
        '
        Me.rbNone3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNone3.Checked = True
        Me.rbNone3.Name = "rbNone3"
        Me.rbNone3.Text = "NONE"
        '
        'rbAnd3
        '
        Me.rbAnd3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbAnd3.Name = "rbAnd3"
        Me.rbAnd3.Text = "AND"
        '
        'rbOr3
        '
        Me.rbOr3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbOr3.Name = "rbOr3"
        Me.rbOr3.Text = "OR"
        '
        'rbCombine3
        '
        Me.rbCombine3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCombine3.Name = "rbCombine3"
        Me.rbCombine3.Text = "COMBINE"
        '
        'btnLogSearch
        '
        Me.btnLogSearch.Image = CType(resources.GetObject("btnLogSearch.Image"), System.Drawing.Image)
        Me.btnLogSearch.Name = "btnLogSearch"
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1SplitContainer1)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(769, 436)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "RISK LEVEL"
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(769, 436)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 0
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.C1InputPanel1)
        Me.C1SplitterPanel1.Controls.Add(Me.DBGRisk)
        Me.C1SplitterPanel1.Height = 105
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(769, 84)
        Me.C1SplitterPanel1.SizeRatio = 24.163R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "RISK LEVEL "
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.lblRiskLevel)
        Me.C1InputPanel1.Items.Add(Me.InputLabel15)
        Me.C1InputPanel1.Items.Add(Me.txtMaximumValue)
        Me.C1InputPanel1.Items.Add(Me.btnSetRiskLevel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(377, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(393, 84)
        Me.C1InputPanel1.TabIndex = 1
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Select risk level then set maximum value for each level"
        '
        'InputLabel12
        '
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Risk Level: "
        Me.InputLabel12.Width = 100
        '
        'lblRiskLevel
        '
        Me.lblRiskLevel.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRiskLevel.Name = "lblRiskLevel"
        Me.lblRiskLevel.Width = 165
        '
        'InputLabel15
        '
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Maximum Value: "
        Me.InputLabel15.Width = 100
        '
        'txtMaximumValue
        '
        Me.txtMaximumValue.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtMaximumValue.Name = "txtMaximumValue"
        Me.txtMaximumValue.Width = 50
        '
        'btnSetRiskLevel
        '
        Me.btnSetRiskLevel.Image = CType(resources.GetObject("btnSetRiskLevel.Image"), System.Drawing.Image)
        Me.btnSetRiskLevel.Name = "btnSetRiskLevel"
        '
        'DBGRisk
        '
        Me.DBGRisk.BackColor = System.Drawing.Color.White
        Me.DBGRisk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGRisk.Dock = System.Windows.Forms.DockStyle.Left
        Me.DBGRisk.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGRisk.Images.Add(CType(resources.GetObject("DBGRisk.Images"), System.Drawing.Image))
        Me.DBGRisk.Location = New System.Drawing.Point(0, 0)
        Me.DBGRisk.Name = "DBGRisk"
        Me.DBGRisk.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGRisk.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGRisk.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGRisk.PrintInfo.PageSettings = CType(resources.GetObject("DBGRisk.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGRisk.PropBag = resources.GetString("DBGRisk.PropBag")
        Me.DBGRisk.RecordSelectors = False
        Me.DBGRisk.Size = New System.Drawing.Size(377, 84)
        Me.DBGRisk.TabIndex = 7
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.DBGQuestion)
        Me.C1SplitterPanel2.Controls.Add(Me.C1InputPanel6)
        Me.C1SplitterPanel2.Height = 330
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 127)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(769, 309)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "RISK LEVEL QUESTIONER"
        '
        'DBGQuestion
        '
        Me.DBGQuestion.BackColor = System.Drawing.Color.White
        Me.DBGQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGQuestion.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGQuestion.Images.Add(CType(resources.GetObject("DBGQuestion.Images"), System.Drawing.Image))
        Me.DBGQuestion.Location = New System.Drawing.Point(0, 31)
        Me.DBGQuestion.Name = "DBGQuestion"
        Me.DBGQuestion.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGQuestion.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGQuestion.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGQuestion.PrintInfo.PageSettings = CType(resources.GetObject("DBGQuestion.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGQuestion.PropBag = resources.GetString("DBGQuestion.PropBag")
        Me.DBGQuestion.RecordSelectors = False
        Me.DBGQuestion.Size = New System.Drawing.Size(769, 280)
        Me.DBGQuestion.TabIndex = 7
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.BorderThickness = 1
        Me.C1InputPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputLabel13)
        Me.C1InputPanel6.Items.Add(Me.cmbClientType)
        Me.C1InputPanel6.Items.Add(Me.btnAddQuestion)
        Me.C1InputPanel6.Items.Add(Me.btnRemoveQuestion)
        Me.C1InputPanel6.Items.Add(Me.btnProfileQuestion)
        Me.C1InputPanel6.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(769, 31)
        Me.C1InputPanel6.TabIndex = 0
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Client Type: "
        '
        'cmbClientType
        '
        Me.cmbClientType.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbClientType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbClientType.Name = "cmbClientType"
        Me.cmbClientType.Width = 200
        '
        'btnAddQuestion
        '
        Me.btnAddQuestion.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAddQuestion.Image = CType(resources.GetObject("btnAddQuestion.Image"), System.Drawing.Image)
        Me.btnAddQuestion.Name = "btnAddQuestion"
        '
        'btnRemoveQuestion
        '
        Me.btnRemoveQuestion.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRemoveQuestion.Image = CType(resources.GetObject("btnRemoveQuestion.Image"), System.Drawing.Image)
        Me.btnRemoveQuestion.Name = "btnRemoveQuestion"
        '
        'btnProfileQuestion
        '
        Me.btnProfileQuestion.Image = CType(resources.GetObject("btnProfileQuestion.Image"), System.Drawing.Image)
        Me.btnProfileQuestion.Name = "btnProfileQuestion"
        '
        'C1DockingTabPage7
        '
        Me.C1DockingTabPage7.Controls.Add(Me.DBGKYCAvailable)
        Me.C1DockingTabPage7.Controls.Add(Me.C1InputPanel10)
        Me.C1DockingTabPage7.Controls.Add(Me.DBGKYCApply)
        Me.C1DockingTabPage7.Controls.Add(Me.C1InputPanel9)
        Me.C1DockingTabPage7.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage7.Name = "C1DockingTabPage7"
        Me.C1DockingTabPage7.Size = New System.Drawing.Size(769, 436)
        Me.C1DockingTabPage7.TabIndex = 7
        Me.C1DockingTabPage7.Text = "KYC FIELD"
        '
        'DBGKYCAvailable
        '
        Me.DBGKYCAvailable.BackColor = System.Drawing.Color.White
        Me.DBGKYCAvailable.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGKYCAvailable.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGKYCAvailable.Images.Add(CType(resources.GetObject("DBGKYCAvailable.Images"), System.Drawing.Image))
        Me.DBGKYCAvailable.Location = New System.Drawing.Point(0, 294)
        Me.DBGKYCAvailable.Name = "DBGKYCAvailable"
        Me.DBGKYCAvailable.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGKYCAvailable.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGKYCAvailable.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGKYCAvailable.PrintInfo.PageSettings = CType(resources.GetObject("DBGKYCAvailable.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGKYCAvailable.PropBag = resources.GetString("DBGKYCAvailable.PropBag")
        Me.DBGKYCAvailable.RecordSelectors = False
        Me.DBGKYCAvailable.Size = New System.Drawing.Size(769, 143)
        Me.DBGKYCAvailable.TabIndex = 17
        '
        'C1InputPanel10
        '
        Me.C1InputPanel10.BorderThickness = 1
        Me.C1InputPanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel10.Items.Add(Me.InputGroupHeader9)
        Me.C1InputPanel10.Items.Add(Me.InputLabel5)
        Me.C1InputPanel10.Items.Add(Me.txtKeywordKYCAvailable)
        Me.C1InputPanel10.Items.Add(Me.rbNone1)
        Me.C1InputPanel10.Items.Add(Me.rbAnd1)
        Me.C1InputPanel10.Items.Add(Me.rbOr1)
        Me.C1InputPanel10.Items.Add(Me.rbCombine1)
        Me.C1InputPanel10.Items.Add(Me.btnSearchKYCAvailable)
        Me.C1InputPanel10.Items.Add(Me.btnAddKYC)
        Me.C1InputPanel10.Location = New System.Drawing.Point(0, 223)
        Me.C1InputPanel10.Name = "C1InputPanel10"
        Me.C1InputPanel10.Size = New System.Drawing.Size(769, 71)
        Me.C1InputPanel10.TabIndex = 16
        Me.C1InputPanel10.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader9
        '
        Me.InputGroupHeader9.Name = "InputGroupHeader9"
        Me.InputGroupHeader9.Text = "AVAILABLE KYC FIELD"
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Keyword, that simillar with code or description: "
        Me.InputLabel5.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        '
        'txtKeywordKYCAvailable
        '
        Me.txtKeywordKYCAvailable.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeywordKYCAvailable.Name = "txtKeywordKYCAvailable"
        Me.txtKeywordKYCAvailable.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.txtKeywordKYCAvailable.Width = 469
        '
        'rbNone1
        '
        Me.rbNone1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNone1.Checked = True
        Me.rbNone1.Name = "rbNone1"
        Me.rbNone1.Text = "NONE"
        '
        'rbAnd1
        '
        Me.rbAnd1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbAnd1.Name = "rbAnd1"
        Me.rbAnd1.Text = "AND"
        '
        'rbOr1
        '
        Me.rbOr1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbOr1.Name = "rbOr1"
        Me.rbOr1.Text = "OR"
        '
        'rbCombine1
        '
        Me.rbCombine1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCombine1.Name = "rbCombine1"
        Me.rbCombine1.Text = "COMBINE"
        '
        'btnSearchKYCAvailable
        '
        Me.btnSearchKYCAvailable.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchKYCAvailable.Image = CType(resources.GetObject("btnSearchKYCAvailable.Image"), System.Drawing.Image)
        Me.btnSearchKYCAvailable.Name = "btnSearchKYCAvailable"
        '
        'btnAddKYC
        '
        Me.btnAddKYC.Image = CType(resources.GetObject("btnAddKYC.Image"), System.Drawing.Image)
        Me.btnAddKYC.Name = "btnAddKYC"
        '
        'DBGKYCApply
        '
        Me.DBGKYCApply.BackColor = System.Drawing.Color.White
        Me.DBGKYCApply.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGKYCApply.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGKYCApply.Images.Add(CType(resources.GetObject("DBGKYCApply.Images"), System.Drawing.Image))
        Me.DBGKYCApply.Location = New System.Drawing.Point(0, 71)
        Me.DBGKYCApply.Name = "DBGKYCApply"
        Me.DBGKYCApply.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGKYCApply.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGKYCApply.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGKYCApply.PrintInfo.PageSettings = CType(resources.GetObject("DBGKYCApply.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGKYCApply.PropBag = resources.GetString("DBGKYCApply.PropBag")
        Me.DBGKYCApply.RecordSelectors = False
        Me.DBGKYCApply.Size = New System.Drawing.Size(769, 152)
        Me.DBGKYCApply.TabIndex = 15
        '
        'C1InputPanel9
        '
        Me.C1InputPanel9.BorderThickness = 1
        Me.C1InputPanel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel9.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel9.Items.Add(Me.InputLabel7)
        Me.C1InputPanel9.Items.Add(Me.InputLabel4)
        Me.C1InputPanel9.Items.Add(Me.cmbClientTypeKYC)
        Me.C1InputPanel9.Items.Add(Me.txtKeywordKYCApply)
        Me.C1InputPanel9.Items.Add(Me.rbNone2)
        Me.C1InputPanel9.Items.Add(Me.rbAnd2)
        Me.C1InputPanel9.Items.Add(Me.rbOr2)
        Me.C1InputPanel9.Items.Add(Me.rbCombine2)
        Me.C1InputPanel9.Items.Add(Me.btnSearchKYCApply)
        Me.C1InputPanel9.Items.Add(Me.btnRemoveKYC)
        Me.C1InputPanel9.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel9.Name = "C1InputPanel9"
        Me.C1InputPanel9.Size = New System.Drawing.Size(769, 71)
        Me.C1InputPanel9.TabIndex = 14
        Me.C1InputPanel9.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "APPLIED KYC FIELD FOR ACCOUNT OPENING"
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Client Type"
        Me.InputLabel7.Width = 200
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Keyword, that simillar with code or description: "
        Me.InputLabel4.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        '
        'cmbClientTypeKYC
        '
        Me.cmbClientTypeKYC.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbClientTypeKYC.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbClientTypeKYC.Name = "cmbClientTypeKYC"
        Me.cmbClientTypeKYC.Width = 200
        '
        'txtKeywordKYCApply
        '
        Me.txtKeywordKYCApply.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeywordKYCApply.Name = "txtKeywordKYCApply"
        Me.txtKeywordKYCApply.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.txtKeywordKYCApply.Width = 265
        '
        'rbNone2
        '
        Me.rbNone2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNone2.Checked = True
        Me.rbNone2.Name = "rbNone2"
        Me.rbNone2.Text = "NONE"
        '
        'rbAnd2
        '
        Me.rbAnd2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbAnd2.Name = "rbAnd2"
        Me.rbAnd2.Text = "AND"
        '
        'rbOr2
        '
        Me.rbOr2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbOr2.Name = "rbOr2"
        Me.rbOr2.Text = "OR"
        '
        'rbCombine2
        '
        Me.rbCombine2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCombine2.Name = "rbCombine2"
        Me.rbCombine2.Text = "COMBINE"
        '
        'btnSearchKYCApply
        '
        Me.btnSearchKYCApply.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchKYCApply.Image = CType(resources.GetObject("btnSearchKYCApply.Image"), System.Drawing.Image)
        Me.btnSearchKYCApply.Name = "btnSearchKYCApply"
        '
        'btnRemoveKYC
        '
        Me.btnRemoveKYC.Image = CType(resources.GetObject("btnRemoveKYC.Image"), System.Drawing.Image)
        Me.btnRemoveKYC.Name = "btnRemoveKYC"
        '
        'FormMasterSimpi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 506)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterSimpi"
        Me.Text = "MASTER SIMPI"
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.DBGBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer2.ResumeLayout(False)
        Me.C1SplitterPanel5.ResumeLayout(False)
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGTerminal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel6.ResumeLayout(False)
        CType(Me.DBGSession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage4.ResumeLayout(False)
        CType(Me.DBGTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage5.ResumeLayout(False)
        CType(Me.DBGLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGRisk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        CType(Me.DBGQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage7.ResumeLayout(False)
        CType(Me.DBGKYCAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGKYCApply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents inputLabel14 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblType As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel16 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel17 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblName As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblShortname As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblPIC As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblEmail As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblPhone As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblUserLogin As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblUserStatus As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel32 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblUserName As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblUserTitle As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserInitial As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCreditCcy As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCreditAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblValid As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBilling As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblGrace As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGBilling As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel41 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTerminalMACAddress As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel44 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTerminalIPAddress As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel46 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTerminalComputerName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel48 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTerminalID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGLog As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel72 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel73 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel74 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtLogFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dtLogTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents txtLogKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnLogSearch As C1.Win.C1InputPanel.InputButton
    Private WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader13 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel43 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel45 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtTicketFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dtTicketTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents cmdTicketSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader14 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGTicket As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputLabel49 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTicketDescription As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel50 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbTicketType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents cmdTicketSubmit As C1.Win.C1InputPanel.InputButton
    Friend WithEvents cmdTicketCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel54 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbTicketStatus As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblAddress As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRiskLevel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMaximumValue As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSetRiskLevel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbClientType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents DBGRisk As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DBGQuestion As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnAddQuestion As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveQuestion As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1SplitContainer2 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel5 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1InputPanel8 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMACAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIPAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtComputerName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnAddTerminal As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveTerminal As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGTerminal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1SplitterPanel6 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents DBGSession As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DockingTabPage7 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnClearSession As C1.Win.C1InputPanel.InputButton
    Private WithEvents C1InputPanel9 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtKeywordKYCApply As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents btnSearchKYCApply As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveKYC As C1.Win.C1InputPanel.InputButton
    Private WithEvents C1InputPanel10 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader9 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtKeywordKYCAvailable As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents btnSearchKYCAvailable As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnAddKYC As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGKYCApply As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DBGKYCAvailable As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnProfileQuestion As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbClientTypeKYC As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbNone3 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd3 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr3 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine3 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine2 As C1.Win.C1InputPanel.InputRadioButton
End Class
