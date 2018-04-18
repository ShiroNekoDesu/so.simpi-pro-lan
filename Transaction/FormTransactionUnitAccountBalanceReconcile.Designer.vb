<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactionUnitAccountBalanceReconcile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransactionUnitAccountBalanceReconcile))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
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
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientKYC = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientNo = New C1.Win.C1InputPanel.InputLabel()
        Me.btnUpdate = New C1.Win.C1InputPanel.InputButton()
        Me.pbNAV = New System.Windows.Forms.ProgressBar()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundAccountID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundAccountDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundAccountCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesInternal = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel60 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsOf = New C1.Win.C1InputPanel.InputLabel()
        Me.btnProcess = New C1.Win.C1InputPanel.InputButton()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFileRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFileFound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFileNotFound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFileUnitTotal = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFileUnitFound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFileUnitNotfound = New C1.Win.C1InputPanel.InputLabel()
        Me.btnCopyFileNotFound = New C1.Win.C1InputPanel.InputButton()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.fgFileFound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.fgFileNotfound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer2 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel4 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbDistributor = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnDistributor = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.btnCopySalesNotRecon = New C1.Win.C1InputPanel.InputButton()
        Me.btnCopySalesNotFound = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAccount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAccountFound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAccountNotfound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel33 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAccountReconcile = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAccountReconcileNot = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorUnitReconcile = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorUnitReconcileNot = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAUMReconcile = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorAUMReconcileNot = New C1.Win.C1InputPanel.InputLabel()
        Me.C1SplitterPanel5 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.fgDistributorFound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1SplitterPanel6 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.fgDistributorNotFound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer3 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel7 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbFund = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnFund = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundName = New C1.Win.C1InputPanel.InputLabel()
        Me.btnCopyFundNotRecon = New C1.Win.C1InputPanel.InputButton()
        Me.btnCopyFundNotFound = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAccount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel42 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAccountFound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel44 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAccountNotfound = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel46 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel47 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel49 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel52 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAccountReconcile = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAccountReconcileNot = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel55 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectUnitReconcile = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectUnitReconcileNot = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAUMReconcile = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectAUMReconcileNot = New C1.Win.C1InputPanel.InputLabel()
        Me.C1SplitterPanel8 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.fgDirectFound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1SplitterPanel9 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.fgDirectNotfound = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.bwFile = New System.ComponentModel.BackgroundWorker()
        Me.bwDistributor = New System.ComponentModel.BackgroundWorker()
        Me.bwFund = New System.ComponentModel.BackgroundWorker()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.fgFileFound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel3.SuspendLayout()
        CType(Me.fgFileNotfound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer2.SuspendLayout()
        Me.C1SplitterPanel4.SuspendLayout()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel5.SuspendLayout()
        CType(Me.fgDistributorFound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel6.SuspendLayout()
        CType(Me.fgDistributorNotFound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage4.SuspendLayout()
        CType(Me.C1SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer3.SuspendLayout()
        Me.C1SplitterPanel7.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel8.SuspendLayout()
        CType(Me.fgDirectFound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel9.SuspendLayout()
        CType(Me.fgDirectNotfound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel24)
        Me.C1InputPanel1.Items.Add(Me.txtSheet)
        Me.C1InputPanel1.Items.Add(Me.InputLabel28)
        Me.C1InputPanel1.Items.Add(Me.txtRowStart)
        Me.C1InputPanel1.Items.Add(Me.InputLabel31)
        Me.C1InputPanel1.Items.Add(Me.txtColStart)
        Me.C1InputPanel1.Items.Add(Me.InputLabel50)
        Me.C1InputPanel1.Items.Add(Me.txtColNo)
        Me.C1InputPanel1.Items.Add(Me.btnRead)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Items.Add(Me.InputLabel22)
        Me.C1InputPanel1.Items.Add(Me.lblClientKYC)
        Me.C1InputPanel1.Items.Add(Me.lblClientNo)
        Me.C1InputPanel1.Items.Add(Me.btnUpdate)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(951, 83)
        Me.C1InputPanel1.TabIndex = 20
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
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
        Me.txtFilename.Width = 821
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
        Me.txtRowStart.Text = "1"
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
        Me.txtColNo.Text = "19"
        Me.txtColNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColNo.Width = 35
        '
        'btnRead
        '
        Me.btnRead.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputLabel12
        '
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Rows: "
        Me.InputLabel12.Width = 126
        '
        'lblRows
        '
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 40
        '
        'InputLabel22
        '
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Data: "
        '
        'lblClientKYC
        '
        Me.lblClientKYC.Name = "lblClientKYC"
        Me.lblClientKYC.Width = 40
        '
        'lblClientNo
        '
        Me.lblClientNo.Name = "lblClientNo"
        Me.lblClientNo.Width = 40
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Name = "btnUpdate"
        '
        'pbNAV
        '
        Me.pbNAV.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbNAV.Location = New System.Drawing.Point(0, 83)
        Me.pbNAV.Name = "pbNAV"
        Me.pbNAV.Size = New System.Drawing.Size(951, 23)
        Me.pbNAV.Step = 1
        Me.pbNAV.TabIndex = 21
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.ItemSize = New System.Drawing.Size(0, 35)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 106)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(951, 415)
        Me.C1DockingTab1.TabIndex = 22
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage1.Controls.Add(Me.fgExcel)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(949, 376)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "FILE READ"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel15)
        Me.C1InputPanel2.Items.Add(Me.lblFundAccountID)
        Me.C1InputPanel2.Items.Add(Me.lblFundAccountDescription)
        Me.C1InputPanel2.Items.Add(Me.lblFundAccountCode)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetID)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetCode)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetDescription)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.lblSalesInternal)
        Me.C1InputPanel2.Items.Add(Me.InputLabel60)
        Me.C1InputPanel2.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.lblAsOf)
        Me.C1InputPanel2.Items.Add(Me.btnProcess)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 298)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(949, 78)
        Me.C1InputPanel2.TabIndex = 20
        '
        'InputLabel15
        '
        Me.InputLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "S-Invest Fund Account:"
        Me.InputLabel15.Width = 135
        '
        'lblFundAccountID
        '
        Me.lblFundAccountID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblFundAccountID.Name = "lblFundAccountID"
        Me.lblFundAccountID.Text = "42"
        Me.lblFundAccountID.Width = 35
        '
        'lblFundAccountDescription
        '
        Me.lblFundAccountDescription.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblFundAccountDescription.Name = "lblFundAccountDescription"
        Me.lblFundAccountDescription.Text = "Investor Fund Unit A/C No"
        Me.lblFundAccountDescription.Width = 150
        '
        'lblFundAccountCode
        '
        Me.lblFundAccountCode.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFundAccountCode.Name = "lblFundAccountCode"
        Me.lblFundAccountCode.Text = "S-INVEST Investor Fund Unit A/C No"
        Me.lblFundAccountCode.Width = 260
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "S-Invest SA Code:"
        Me.InputLabel8.Width = 135
        '
        'lblSACodesetID
        '
        Me.lblSACodesetID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSACodesetID.Name = "lblSACodesetID"
        Me.lblSACodesetID.Text = "1"
        Me.lblSACodesetID.Width = 35
        '
        'lblSACodesetCode
        '
        Me.lblSACodesetCode.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSACodesetCode.Name = "lblSACodesetCode"
        Me.lblSACodesetCode.Text = "S-INVEST SA CODE"
        Me.lblSACodesetCode.Width = 150
        '
        'lblSACodesetDescription
        '
        Me.lblSACodesetDescription.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSACodesetDescription.Name = "lblSACodesetDescription"
        Me.lblSACodesetDescription.Text = "S-INVEST SA CODE"
        Me.lblSACodesetDescription.Width = 252
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Height = 35
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Internal SA Code:"
        Me.InputLabel4.Width = 135
        '
        'lblSalesInternal
        '
        Me.lblSalesInternal.Height = 35
        Me.lblSalesInternal.Name = "lblSalesInternal"
        Me.lblSalesInternal.Width = 233
        '
        'InputLabel60
        '
        Me.InputLabel60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel60.Height = 35
        Me.InputLabel60.Name = "InputLabel60"
        Me.InputLabel60.Text = "Portfolio Identification: "
        '
        'cmbExternalPortfolio
        '
        Me.cmbExternalPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbExternalPortfolio.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalPortfolio.Height = 35
        Me.cmbExternalPortfolio.Name = "cmbExternalPortfolio"
        Me.cmbExternalPortfolio.Width = 150
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Height = 35
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "As Of: "
        Me.InputLabel2.Width = 56
        '
        'lblAsOf
        '
        Me.lblAsOf.Height = 35
        Me.lblAsOf.Name = "lblAsOf"
        Me.lblAsOf.Width = 100
        '
        'btnProcess
        '
        Me.btnProcess.Height = 35
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Text = "PROCESS"
        Me.btnProcess.Width = 100
        '
        'fgExcel
        '
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgExcel.Location = New System.Drawing.Point(0, 0)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(949, 298)
        Me.fgExcel.StyleInfo = resources.GetString("fgExcel.StyleInfo")
        Me.fgExcel.TabIndex = 19
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1SplitContainer1)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(949, 376)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "FILE STATUS"
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
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(949, 376)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 0
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.C1InputPanel3)
        Me.C1SplitterPanel1.Height = 63
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(949, 63)
        Me.C1SplitterPanel1.SizeRatio = 16.716R
        Me.C1SplitterPanel1.TabIndex = 0
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.lblFileRows)
        Me.C1InputPanel3.Items.Add(Me.InputLabel17)
        Me.C1InputPanel3.Items.Add(Me.lblFileFound)
        Me.C1InputPanel3.Items.Add(Me.InputLabel19)
        Me.C1InputPanel3.Items.Add(Me.lblFileNotFound)
        Me.C1InputPanel3.Items.Add(Me.InputLabel21)
        Me.C1InputPanel3.Items.Add(Me.lblFileUnitTotal)
        Me.C1InputPanel3.Items.Add(Me.InputLabel3)
        Me.C1InputPanel3.Items.Add(Me.lblFileUnitFound)
        Me.C1InputPanel3.Items.Add(Me.InputLabel6)
        Me.C1InputPanel3.Items.Add(Me.lblFileUnitNotfound)
        Me.C1InputPanel3.Items.Add(Me.btnCopyFileNotFound)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(949, 63)
        Me.C1InputPanel3.TabIndex = 0
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Rows: "
        Me.InputLabel9.Width = 65
        '
        'lblFileRows
        '
        Me.lblFileRows.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFileRows.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblFileRows.Name = "lblFileRows"
        Me.lblFileRows.Width = 35
        '
        'InputLabel17
        '
        Me.InputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel17.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Found: "
        Me.InputLabel17.Width = 65
        '
        'lblFileFound
        '
        Me.lblFileFound.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFileFound.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblFileFound.Name = "lblFileFound"
        Me.lblFileFound.Width = 35
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "Not found: "
        Me.InputLabel19.Width = 65
        '
        'lblFileNotFound
        '
        Me.lblFileNotFound.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblFileNotFound.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblFileNotFound.Name = "lblFileNotFound"
        Me.lblFileNotFound.Width = 35
        '
        'InputLabel21
        '
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Total units: "
        Me.InputLabel21.Width = 100
        '
        'lblFileUnitTotal
        '
        Me.lblFileUnitTotal.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFileUnitTotal.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblFileUnitTotal.Name = "lblFileUnitTotal"
        Me.lblFileUnitTotal.Width = 120
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Found units: "
        Me.InputLabel3.Width = 100
        '
        'lblFileUnitFound
        '
        Me.lblFileUnitFound.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFileUnitFound.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblFileUnitFound.Name = "lblFileUnitFound"
        Me.lblFileUnitFound.Width = 120
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Not found units: "
        Me.InputLabel6.Width = 100
        '
        'lblFileUnitNotfound
        '
        Me.lblFileUnitNotfound.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblFileUnitNotfound.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblFileUnitNotfound.Name = "lblFileUnitNotfound"
        Me.lblFileUnitNotfound.Width = 120
        '
        'btnCopyFileNotFound
        '
        Me.btnCopyFileNotFound.Name = "btnCopyFileNotFound"
        Me.btnCopyFileNotFound.Text = "C2"
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.fgFileFound)
        Me.C1SplitterPanel2.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 85)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(474, 291)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "Found"
        Me.C1SplitterPanel2.Width = 474
        '
        'fgFileFound
        '
        Me.fgFileFound.AllowEditing = False
        Me.fgFileFound.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgFileFound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgFileFound.Location = New System.Drawing.Point(0, 0)
        Me.fgFileFound.Name = "fgFileFound"
        Me.fgFileFound.Rows.DefaultSize = 19
        Me.fgFileFound.Size = New System.Drawing.Size(474, 291)
        Me.fgFileFound.TabIndex = 9
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.Controls.Add(Me.fgFileNotfound)
        Me.C1SplitterPanel3.Height = 312
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(475, 85)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(474, 291)
        Me.C1SplitterPanel3.TabIndex = 2
        Me.C1SplitterPanel3.Text = "Not Found"
        '
        'fgFileNotfound
        '
        Me.fgFileNotfound.AllowEditing = False
        Me.fgFileNotfound.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgFileNotfound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgFileNotfound.Location = New System.Drawing.Point(0, 0)
        Me.fgFileNotfound.Name = "fgFileNotfound"
        Me.fgFileNotfound.Rows.DefaultSize = 19
        Me.fgFileNotfound.Size = New System.Drawing.Size(474, 291)
        Me.fgFileNotfound.TabIndex = 9
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1SplitContainer2)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(949, 376)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "SALES DISTRIBUTOR"
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
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel4)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel5)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel6)
        Me.C1SplitContainer2.Size = New System.Drawing.Size(949, 376)
        Me.C1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer2.SplitterWidth = 1
        Me.C1SplitContainer2.TabIndex = 0
        Me.C1SplitContainer2.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel4
        '
        Me.C1SplitterPanel4.Controls.Add(Me.C1InputPanel4)
        Me.C1SplitterPanel4.Height = 60
        Me.C1SplitterPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel4.Name = "C1SplitterPanel4"
        Me.C1SplitterPanel4.Size = New System.Drawing.Size(949, 60)
        Me.C1SplitterPanel4.SizeRatio = 16.0R
        Me.C1SplitterPanel4.TabIndex = 0
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputLabel5)
        Me.C1InputPanel4.Items.Add(Me.cmbDistributor)
        Me.C1InputPanel4.Items.Add(Me.btnDistributor)
        Me.C1InputPanel4.Items.Add(Me.InputLabel10)
        Me.C1InputPanel4.Items.Add(Me.lblSalesID)
        Me.C1InputPanel4.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel4.Items.Add(Me.lblSalesName)
        Me.C1InputPanel4.Items.Add(Me.btnCopySalesNotRecon)
        Me.C1InputPanel4.Items.Add(Me.btnCopySalesNotFound)
        Me.C1InputPanel4.Items.Add(Me.InputLabel13)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAccount)
        Me.C1InputPanel4.Items.Add(Me.InputLabel14)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAccountFound)
        Me.C1InputPanel4.Items.Add(Me.InputLabel16)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAccountNotfound)
        Me.C1InputPanel4.Items.Add(Me.InputLabel7)
        Me.C1InputPanel4.Items.Add(Me.InputLabel11)
        Me.C1InputPanel4.Items.Add(Me.InputLabel33)
        Me.C1InputPanel4.Items.Add(Me.InputLabel35)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAccountReconcile)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAccountReconcileNot)
        Me.C1InputPanel4.Items.Add(Me.InputLabel38)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorUnitReconcile)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorUnitReconcileNot)
        Me.C1InputPanel4.Items.Add(Me.InputLabel18)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAUMReconcile)
        Me.C1InputPanel4.Items.Add(Me.lblDistributorAUMReconcileNot)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(949, 60)
        Me.C1InputPanel4.TabIndex = 0
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Distributor"
        '
        'cmbDistributor
        '
        Me.cmbDistributor.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbDistributor.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbDistributor.Name = "cmbDistributor"
        Me.cmbDistributor.Width = 75
        '
        'btnDistributor
        '
        Me.btnDistributor.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnDistributor.Height = 40
        Me.btnDistributor.Name = "btnDistributor"
        Me.btnDistributor.Text = "RECONCILE"
        Me.btnDistributor.Width = 100
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Selected Sales"
        '
        'lblSalesID
        '
        Me.lblSalesID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSalesID.Name = "lblSalesID"
        Me.lblSalesID.Width = 50
        '
        'lblSalesCode
        '
        Me.lblSalesCode.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Width = 100
        '
        'lblSalesName
        '
        Me.lblSalesName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Width = 285
        '
        'btnCopySalesNotRecon
        '
        Me.btnCopySalesNotRecon.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnCopySalesNotRecon.Name = "btnCopySalesNotRecon"
        Me.btnCopySalesNotRecon.Text = "C1"
        '
        'btnCopySalesNotFound
        '
        Me.btnCopySalesNotFound.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnCopySalesNotFound.Name = "btnCopySalesNotFound"
        Me.btnCopySalesNotFound.Text = "C2"
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Acc."
        Me.InputLabel13.Width = 40
        '
        'lblDistributorAccount
        '
        Me.lblDistributorAccount.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDistributorAccount.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAccount.Name = "lblDistributorAccount"
        Me.lblDistributorAccount.Width = 35
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Found"
        Me.InputLabel14.Width = 40
        '
        'lblDistributorAccountFound
        '
        Me.lblDistributorAccountFound.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDistributorAccountFound.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAccountFound.Name = "lblDistributorAccountFound"
        Me.lblDistributorAccountFound.Width = 35
        '
        'InputLabel16
        '
        Me.InputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "NotFound"
        Me.InputLabel16.Width = 40
        '
        'lblDistributorAccountNotfound
        '
        Me.lblDistributorAccountNotfound.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDistributorAccountNotfound.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAccountNotfound.Name = "lblDistributorAccountNotfound"
        Me.lblDistributorAccountNotfound.Width = 35
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Width = 40
        '
        'InputLabel11
        '
        Me.InputLabel11.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Recon:"
        Me.InputLabel11.Width = 40
        '
        'InputLabel33
        '
        Me.InputLabel33.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel33.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel33.Name = "InputLabel33"
        Me.InputLabel33.Text = "NotRec:"
        Me.InputLabel33.Width = 40
        '
        'InputLabel35
        '
        Me.InputLabel35.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel35.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel35.Name = "InputLabel35"
        Me.InputLabel35.Text = "Acc."
        Me.InputLabel35.Width = 35
        '
        'lblDistributorAccountReconcile
        '
        Me.lblDistributorAccountReconcile.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDistributorAccountReconcile.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAccountReconcile.Name = "lblDistributorAccountReconcile"
        Me.lblDistributorAccountReconcile.Width = 35
        '
        'lblDistributorAccountReconcileNot
        '
        Me.lblDistributorAccountReconcileNot.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDistributorAccountReconcileNot.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAccountReconcileNot.Name = "lblDistributorAccountReconcileNot"
        Me.lblDistributorAccountReconcileNot.Width = 35
        '
        'InputLabel38
        '
        Me.InputLabel38.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel38.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Text = "Units"
        Me.InputLabel38.Width = 75
        '
        'lblDistributorUnitReconcile
        '
        Me.lblDistributorUnitReconcile.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDistributorUnitReconcile.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorUnitReconcile.Name = "lblDistributorUnitReconcile"
        Me.lblDistributorUnitReconcile.Width = 75
        '
        'lblDistributorUnitReconcileNot
        '
        Me.lblDistributorUnitReconcileNot.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDistributorUnitReconcileNot.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorUnitReconcileNot.Name = "lblDistributorUnitReconcileNot"
        Me.lblDistributorUnitReconcileNot.Width = 75
        '
        'InputLabel18
        '
        Me.InputLabel18.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "AUM"
        Me.InputLabel18.Width = 100
        '
        'lblDistributorAUMReconcile
        '
        Me.lblDistributorAUMReconcile.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDistributorAUMReconcile.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAUMReconcile.Name = "lblDistributorAUMReconcile"
        Me.lblDistributorAUMReconcile.Width = 100
        '
        'lblDistributorAUMReconcileNot
        '
        Me.lblDistributorAUMReconcileNot.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDistributorAUMReconcileNot.Name = "lblDistributorAUMReconcileNot"
        Me.lblDistributorAUMReconcileNot.Width = 100
        '
        'C1SplitterPanel5
        '
        Me.C1SplitterPanel5.Controls.Add(Me.fgDistributorFound)
        Me.C1SplitterPanel5.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel5.Location = New System.Drawing.Point(0, 82)
        Me.C1SplitterPanel5.Name = "C1SplitterPanel5"
        Me.C1SplitterPanel5.Size = New System.Drawing.Size(474, 294)
        Me.C1SplitterPanel5.TabIndex = 1
        Me.C1SplitterPanel5.Text = "Found"
        Me.C1SplitterPanel5.Width = 474
        '
        'fgDistributorFound
        '
        Me.fgDistributorFound.AllowEditing = False
        Me.fgDistributorFound.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDistributorFound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgDistributorFound.Location = New System.Drawing.Point(0, 0)
        Me.fgDistributorFound.Name = "fgDistributorFound"
        Me.fgDistributorFound.Rows.DefaultSize = 19
        Me.fgDistributorFound.Size = New System.Drawing.Size(474, 294)
        Me.fgDistributorFound.TabIndex = 10
        '
        'C1SplitterPanel6
        '
        Me.C1SplitterPanel6.Controls.Add(Me.fgDistributorNotFound)
        Me.C1SplitterPanel6.Height = 315
        Me.C1SplitterPanel6.Location = New System.Drawing.Point(475, 82)
        Me.C1SplitterPanel6.Name = "C1SplitterPanel6"
        Me.C1SplitterPanel6.Size = New System.Drawing.Size(474, 294)
        Me.C1SplitterPanel6.TabIndex = 2
        Me.C1SplitterPanel6.Text = "Not Found"
        '
        'fgDistributorNotFound
        '
        Me.fgDistributorNotFound.AllowEditing = False
        Me.fgDistributorNotFound.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDistributorNotFound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgDistributorNotFound.Location = New System.Drawing.Point(0, 0)
        Me.fgDistributorNotFound.Name = "fgDistributorNotFound"
        Me.fgDistributorNotFound.Rows.DefaultSize = 19
        Me.fgDistributorNotFound.Size = New System.Drawing.Size(474, 294)
        Me.fgDistributorNotFound.TabIndex = 10
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.C1SplitContainer3)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(949, 376)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "FUND OUTSTANDING"
        '
        'C1SplitContainer3
        '
        Me.C1SplitContainer3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer3.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer3.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer3.Name = "C1SplitContainer3"
        Me.C1SplitContainer3.Panels.Add(Me.C1SplitterPanel7)
        Me.C1SplitContainer3.Panels.Add(Me.C1SplitterPanel8)
        Me.C1SplitContainer3.Panels.Add(Me.C1SplitterPanel9)
        Me.C1SplitContainer3.Size = New System.Drawing.Size(949, 376)
        Me.C1SplitContainer3.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.C1SplitContainer3.SplitterWidth = 1
        Me.C1SplitContainer3.TabIndex = 0
        Me.C1SplitContainer3.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel7
        '
        Me.C1SplitterPanel7.Controls.Add(Me.C1InputPanel5)
        Me.C1SplitterPanel7.Height = 60
        Me.C1SplitterPanel7.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel7.Name = "C1SplitterPanel7"
        Me.C1SplitterPanel7.Size = New System.Drawing.Size(949, 60)
        Me.C1SplitterPanel7.SizeRatio = 16.0R
        Me.C1SplitterPanel7.TabIndex = 0
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputLabel23)
        Me.C1InputPanel5.Items.Add(Me.cmbFund)
        Me.C1InputPanel5.Items.Add(Me.btnFund)
        Me.C1InputPanel5.Items.Add(Me.InputLabel25)
        Me.C1InputPanel5.Items.Add(Me.lblFundID)
        Me.C1InputPanel5.Items.Add(Me.lblFundCode)
        Me.C1InputPanel5.Items.Add(Me.lblFundName)
        Me.C1InputPanel5.Items.Add(Me.btnCopyFundNotRecon)
        Me.C1InputPanel5.Items.Add(Me.btnCopyFundNotFound)
        Me.C1InputPanel5.Items.Add(Me.InputLabel29)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAccount)
        Me.C1InputPanel5.Items.Add(Me.InputLabel42)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAccountFound)
        Me.C1InputPanel5.Items.Add(Me.InputLabel44)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAccountNotfound)
        Me.C1InputPanel5.Items.Add(Me.InputLabel46)
        Me.C1InputPanel5.Items.Add(Me.InputLabel47)
        Me.C1InputPanel5.Items.Add(Me.InputLabel49)
        Me.C1InputPanel5.Items.Add(Me.InputLabel52)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAccountReconcile)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAccountReconcileNot)
        Me.C1InputPanel5.Items.Add(Me.InputLabel55)
        Me.C1InputPanel5.Items.Add(Me.lblDirectUnitReconcile)
        Me.C1InputPanel5.Items.Add(Me.lblDirectUnitReconcileNot)
        Me.C1InputPanel5.Items.Add(Me.InputLabel30)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAUMReconcile)
        Me.C1InputPanel5.Items.Add(Me.lblDirectAUMReconcileNot)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(949, 60)
        Me.C1InputPanel5.TabIndex = 1
        '
        'InputLabel23
        '
        Me.InputLabel23.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Text = "Fund"
        '
        'cmbFund
        '
        Me.cmbFund.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbFund.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbFund.Name = "cmbFund"
        Me.cmbFund.Width = 75
        '
        'btnFund
        '
        Me.btnFund.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnFund.Height = 40
        Me.btnFund.Name = "btnFund"
        Me.btnFund.Text = "RECONCILE"
        Me.btnFund.Width = 100
        '
        'InputLabel25
        '
        Me.InputLabel25.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Selected Fund"
        '
        'lblFundID
        '
        Me.lblFundID.Name = "lblFundID"
        Me.lblFundID.Width = 50
        '
        'lblFundCode
        '
        Me.lblFundCode.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblFundCode.Name = "lblFundCode"
        Me.lblFundCode.Width = 100
        '
        'lblFundName
        '
        Me.lblFundName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblFundName.Name = "lblFundName"
        Me.lblFundName.Width = 285
        '
        'btnCopyFundNotRecon
        '
        Me.btnCopyFundNotRecon.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnCopyFundNotRecon.Name = "btnCopyFundNotRecon"
        Me.btnCopyFundNotRecon.Text = "C1"
        '
        'btnCopyFundNotFound
        '
        Me.btnCopyFundNotFound.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnCopyFundNotFound.Name = "btnCopyFundNotFound"
        Me.btnCopyFundNotFound.Text = "C2"
        '
        'InputLabel29
        '
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Acc."
        Me.InputLabel29.Width = 40
        '
        'lblDirectAccount
        '
        Me.lblDirectAccount.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDirectAccount.Name = "lblDirectAccount"
        Me.lblDirectAccount.Width = 35
        '
        'InputLabel42
        '
        Me.InputLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel42.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel42.Name = "InputLabel42"
        Me.InputLabel42.Text = "Found"
        Me.InputLabel42.Width = 40
        '
        'lblDirectAccountFound
        '
        Me.lblDirectAccountFound.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDirectAccountFound.Name = "lblDirectAccountFound"
        Me.lblDirectAccountFound.Width = 35
        '
        'InputLabel44
        '
        Me.InputLabel44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel44.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel44.Name = "InputLabel44"
        Me.InputLabel44.Text = "NotFound"
        Me.InputLabel44.Width = 40
        '
        'lblDirectAccountNotfound
        '
        Me.lblDirectAccountNotfound.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDirectAccountNotfound.Name = "lblDirectAccountNotfound"
        Me.lblDirectAccountNotfound.Width = 35
        '
        'InputLabel46
        '
        Me.InputLabel46.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel46.Name = "InputLabel46"
        Me.InputLabel46.Width = 40
        '
        'InputLabel47
        '
        Me.InputLabel47.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel47.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel47.Name = "InputLabel47"
        Me.InputLabel47.Text = "Recon:"
        Me.InputLabel47.Width = 40
        '
        'InputLabel49
        '
        Me.InputLabel49.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel49.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel49.Name = "InputLabel49"
        Me.InputLabel49.Text = "NotRec:"
        Me.InputLabel49.Width = 40
        '
        'InputLabel52
        '
        Me.InputLabel52.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel52.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel52.Name = "InputLabel52"
        Me.InputLabel52.Text = "Acc."
        Me.InputLabel52.Width = 35
        '
        'lblDirectAccountReconcile
        '
        Me.lblDirectAccountReconcile.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDirectAccountReconcile.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblDirectAccountReconcile.Name = "lblDirectAccountReconcile"
        Me.lblDirectAccountReconcile.Width = 35
        '
        'lblDirectAccountReconcileNot
        '
        Me.lblDirectAccountReconcileNot.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDirectAccountReconcileNot.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblDirectAccountReconcileNot.Name = "lblDirectAccountReconcileNot"
        Me.lblDirectAccountReconcileNot.Width = 35
        '
        'InputLabel55
        '
        Me.InputLabel55.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel55.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel55.Name = "InputLabel55"
        Me.InputLabel55.Text = "Units"
        Me.InputLabel55.Width = 75
        '
        'lblDirectUnitReconcile
        '
        Me.lblDirectUnitReconcile.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDirectUnitReconcile.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDirectUnitReconcile.Name = "lblDirectUnitReconcile"
        Me.lblDirectUnitReconcile.Width = 75
        '
        'lblDirectUnitReconcileNot
        '
        Me.lblDirectUnitReconcileNot.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDirectUnitReconcileNot.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDirectUnitReconcileNot.Name = "lblDirectUnitReconcileNot"
        Me.lblDirectUnitReconcileNot.Width = 75
        '
        'InputLabel30
        '
        Me.InputLabel30.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Text = "AUM"
        Me.InputLabel30.Width = 100
        '
        'lblDirectAUMReconcile
        '
        Me.lblDirectAUMReconcile.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDirectAUMReconcile.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDirectAUMReconcile.Name = "lblDirectAUMReconcile"
        Me.lblDirectAUMReconcile.Width = 100
        '
        'lblDirectAUMReconcileNot
        '
        Me.lblDirectAUMReconcileNot.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDirectAUMReconcileNot.Name = "lblDirectAUMReconcileNot"
        Me.lblDirectAUMReconcileNot.Width = 100
        '
        'C1SplitterPanel8
        '
        Me.C1SplitterPanel8.Controls.Add(Me.fgDirectFound)
        Me.C1SplitterPanel8.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel8.Location = New System.Drawing.Point(0, 82)
        Me.C1SplitterPanel8.Name = "C1SplitterPanel8"
        Me.C1SplitterPanel8.Size = New System.Drawing.Size(474, 294)
        Me.C1SplitterPanel8.TabIndex = 1
        Me.C1SplitterPanel8.Text = "Found"
        Me.C1SplitterPanel8.Width = 474
        '
        'fgDirectFound
        '
        Me.fgDirectFound.AllowEditing = False
        Me.fgDirectFound.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDirectFound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgDirectFound.Location = New System.Drawing.Point(0, 0)
        Me.fgDirectFound.Name = "fgDirectFound"
        Me.fgDirectFound.Rows.DefaultSize = 19
        Me.fgDirectFound.Size = New System.Drawing.Size(474, 294)
        Me.fgDirectFound.TabIndex = 11
        '
        'C1SplitterPanel9
        '
        Me.C1SplitterPanel9.Controls.Add(Me.fgDirectNotfound)
        Me.C1SplitterPanel9.Height = 315
        Me.C1SplitterPanel9.Location = New System.Drawing.Point(475, 82)
        Me.C1SplitterPanel9.Name = "C1SplitterPanel9"
        Me.C1SplitterPanel9.Size = New System.Drawing.Size(474, 294)
        Me.C1SplitterPanel9.TabIndex = 2
        Me.C1SplitterPanel9.Text = "Not Found"
        '
        'fgDirectNotfound
        '
        Me.fgDirectNotfound.AllowEditing = False
        Me.fgDirectNotfound.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDirectNotfound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgDirectNotfound.Location = New System.Drawing.Point(0, 0)
        Me.fgDirectNotfound.Name = "fgDirectNotfound"
        Me.fgDirectNotfound.Rows.DefaultSize = 19
        Me.fgDirectNotfound.Size = New System.Drawing.Size(474, 294)
        Me.fgDirectNotfound.TabIndex = 11
        '
        'bwExcel
        '
        '
        'bwFile
        '
        '
        'bwDistributor
        '
        '
        'bwFund
        '
        '
        'FormTransactionUnitAccountBalanceReconcile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 521)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.pbNAV)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransactionUnitAccountBalanceReconcile"
        Me.Text = "S-INVEST: Unit Account Balance Reconcile"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        CType(Me.fgFileFound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel3.ResumeLayout(False)
        CType(Me.fgFileNotfound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer2.ResumeLayout(False)
        Me.C1SplitterPanel4.ResumeLayout(False)
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel5.ResumeLayout(False)
        CType(Me.fgDistributorFound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel6.ResumeLayout(False)
        CType(Me.fgDistributorNotFound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage4.ResumeLayout(False)
        CType(Me.C1SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer3.ResumeLayout(False)
        Me.C1SplitterPanel7.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel8.ResumeLayout(False)
        CType(Me.fgDirectFound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel9.ResumeLayout(False)
        CType(Me.fgDirectNotfound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
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
    Friend WithEvents pbNAV As ProgressBar
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFundAccountID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFundAccountDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFundAccountCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACodesetID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACodesetCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACodesetDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesInternal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnProcess As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFileRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFileFound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFileNotFound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFileUnitTotal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgFileFound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgFileNotfound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFileUnitFound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFileUnitNotfound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1SplitContainer2 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel4 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel5 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel6 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents fgDistributorFound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgDistributorNotFound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1SplitContainer3 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel7 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel8 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel9 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents fgDirectFound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgDirectNotfound As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbDistributor As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnDistributor As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAccount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAccountFound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAccountNotfound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel33 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAccountReconcile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAccountReconcileNot As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorUnitReconcile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorUnitReconcileNot As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel60 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbFund As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents btnFund As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFundCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFundName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAccount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel42 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAccountFound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel44 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAccountNotfound As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel46 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel47 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel49 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel52 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAccountReconcile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAccountReconcileNot As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel55 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectUnitReconcile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectUnitReconcileNot As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwDistributor As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwFund As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAsOf As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAUMReconcile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorAUMReconcileNot As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAUMReconcile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectAUMReconcileNot As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFundID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnCopySalesNotRecon As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCopySalesNotFound As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCopyFileNotFound As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCopyFundNotRecon As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCopyFundNotFound As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientKYC As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientNo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnUpdate As C1.Win.C1InputPanel.InputButton
End Class
