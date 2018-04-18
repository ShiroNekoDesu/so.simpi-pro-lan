<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountCurrentKYCIndividual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountCurrentKYCIndividual))
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
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientKYC = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientNo = New C1.Win.C1InputPanel.InputLabel()
        Me.btnUpdate = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectExisting = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDirectFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorRow = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorExisting = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorSucced = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDistributorFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLocal = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblForeign = New C1.Win.C1InputPanel.InputLabel()
        Me.pbNAV = New System.Windows.Forms.ProgressBar()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblKYCID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblKYCDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.lblKYCCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesInternal = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchSales = New C1.Win.C1InputPanel.InputButton()
        Me.lblDefaultSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDefaultSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.btnProcess = New C1.Win.C1InputPanel.InputButton()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgDirect = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.btnDirectExists = New C1.Win.C1InputPanel.InputButton()
        Me.btnCopyDirect = New C1.Win.C1InputPanel.InputButton()
        Me.fgDirectNotExists = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgDistributor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.btnCopyDistributor = New C1.Win.C1InputPanel.InputButton()
        Me.fgDistributorNew = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.bwProcess = New System.ComponentModel.BackgroundWorker()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.fgDirect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage4.SuspendLayout()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgDirectNotExists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.fgDistributor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage5.SuspendLayout()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgDistributorNew, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.lblClientKYC)
        Me.C1InputPanel1.Items.Add(Me.lblClientNo)
        Me.C1InputPanel1.Items.Add(Me.btnUpdate)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.lblDirectRows)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.lblDirectExisting)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.lblDirectFailed)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.lblDistributorRow)
        Me.C1InputPanel1.Items.Add(Me.InputLabel14)
        Me.C1InputPanel1.Items.Add(Me.lblDistributorExisting)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.lblDistributorSucced)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblDistributorFailed)
        Me.C1InputPanel1.Items.Add(Me.InputLabel15)
        Me.C1InputPanel1.Items.Add(Me.lblLocal)
        Me.C1InputPanel1.Items.Add(Me.InputLabel17)
        Me.C1InputPanel1.Items.Add(Me.lblForeign)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(902, 123)
        Me.C1InputPanel1.TabIndex = 18
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
        Me.txtColNo.Text = "50"
        Me.txtColNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColNo.Width = 35
        '
        'btnRead
        '
        Me.btnRead.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Rows: "
        Me.InputLabel3.Width = 79
        '
        'lblRows
        '
        Me.lblRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRows.ForeColor = System.Drawing.Color.Red
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 40
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Data: "
        '
        'lblClientKYC
        '
        Me.lblClientKYC.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblClientKYC.Name = "lblClientKYC"
        Me.lblClientKYC.Width = 40
        '
        'lblClientNo
        '
        Me.lblClientNo.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblClientNo.Name = "lblClientNo"
        Me.lblClientNo.Width = 40
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Name = "btnUpdate"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "FILE STATUS"
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Direct: "
        '
        'lblDirectRows
        '
        Me.lblDirectRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectRows.ForeColor = System.Drawing.Color.Red
        Me.lblDirectRows.Name = "lblDirectRows"
        Me.lblDirectRows.Width = 35
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Exists:"
        '
        'lblDirectExisting
        '
        Me.lblDirectExisting.Name = "lblDirectExisting"
        Me.lblDirectExisting.Width = 35
        '
        'InputLabel10
        '
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Not Exists: "
        '
        'lblDirectFailed
        '
        Me.lblDirectFailed.Name = "lblDirectFailed"
        Me.lblDirectFailed.Width = 35
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Distributor: "
        Me.InputLabel7.Width = 125
        '
        'lblDistributorRow
        '
        Me.lblDistributorRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistributorRow.ForeColor = System.Drawing.Color.Red
        Me.lblDistributorRow.Name = "lblDistributorRow"
        Me.lblDistributorRow.Width = 35
        '
        'InputLabel14
        '
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Exists:"
        '
        'lblDistributorExisting
        '
        Me.lblDistributorExisting.Name = "lblDistributorExisting"
        Me.lblDistributorExisting.Width = 35
        '
        'InputLabel12
        '
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "New: "
        '
        'lblDistributorSucced
        '
        Me.lblDistributorSucced.Name = "lblDistributorSucced"
        Me.lblDistributorSucced.Width = 35
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Failed:"
        '
        'lblDistributorFailed
        '
        Me.lblDistributorFailed.Name = "lblDistributorFailed"
        Me.lblDistributorFailed.Width = 35
        '
        'InputLabel15
        '
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Local: "
        Me.InputLabel15.Width = 106
        '
        'lblLocal
        '
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Width = 35
        '
        'InputLabel17
        '
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Foreign: "
        '
        'lblForeign
        '
        Me.lblForeign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForeign.ForeColor = System.Drawing.Color.Red
        Me.lblForeign.Name = "lblForeign"
        Me.lblForeign.Width = 35
        '
        'pbNAV
        '
        Me.pbNAV.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbNAV.Location = New System.Drawing.Point(0, 123)
        Me.pbNAV.Name = "pbNAV"
        Me.pbNAV.Size = New System.Drawing.Size(902, 23)
        Me.pbNAV.Step = 1
        Me.pbNAV.TabIndex = 19
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.ItemSize = New System.Drawing.Size(0, 35)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 146)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(902, 359)
        Me.C1DockingTab1.TabIndex = 20
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
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(900, 320)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "FILE READ"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.lblKYCID)
        Me.C1InputPanel2.Items.Add(Me.lblKYCDescription)
        Me.C1InputPanel2.Items.Add(Me.lblKYCCode)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetID)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetCode)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetDescription)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.lblSalesInternal)
        Me.C1InputPanel2.Items.Add(Me.InputLabel9)
        Me.C1InputPanel2.Items.Add(Me.btnSearchSales)
        Me.C1InputPanel2.Items.Add(Me.lblDefaultSalesCode)
        Me.C1InputPanel2.Items.Add(Me.lblDefaultSalesName)
        Me.C1InputPanel2.Items.Add(Me.btnProcess)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 253)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(900, 66)
        Me.C1InputPanel2.TabIndex = 19
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "S-Invest SID:  "
        Me.InputLabel2.Width = 110
        '
        'lblKYCID
        '
        Me.lblKYCID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblKYCID.Name = "lblKYCID"
        Me.lblKYCID.Text = "41"
        Me.lblKYCID.Width = 35
        '
        'lblKYCDescription
        '
        Me.lblKYCDescription.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblKYCDescription.Name = "lblKYCDescription"
        Me.lblKYCDescription.Text = "SID"
        Me.lblKYCDescription.Width = 150
        '
        'lblKYCCode
        '
        Me.lblKYCCode.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblKYCCode.Name = "lblKYCCode"
        Me.lblKYCCode.Text = "Single Identity Number"
        Me.lblKYCCode.Width = 464
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "S-Invest SA Code:"
        Me.InputLabel8.Width = 110
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
        Me.lblSACodesetDescription.Name = "lblSACodesetDescription"
        Me.lblSACodesetDescription.Text = "S-INVEST SA CODE"
        Me.lblSACodesetDescription.Width = 229
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Internal :"
        Me.InputLabel4.Width = 65
        '
        'lblSalesInternal
        '
        Me.lblSalesInternal.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSalesInternal.Name = "lblSalesInternal"
        Me.lblSalesInternal.Width = 161
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Default Sales: "
        Me.InputLabel9.Width = 110
        '
        'btnSearchSales
        '
        Me.btnSearchSales.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchSales.Image = CType(resources.GetObject("btnSearchSales.Image"), System.Drawing.Image)
        Me.btnSearchSales.Name = "btnSearchSales"
        '
        'lblDefaultSalesCode
        '
        Me.lblDefaultSalesCode.Name = "lblDefaultSalesCode"
        Me.lblDefaultSalesCode.Width = 188
        '
        'lblDefaultSalesName
        '
        Me.lblDefaultSalesName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDefaultSalesName.Name = "lblDefaultSalesName"
        Me.lblDefaultSalesName.Width = 439
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
        Me.fgExcel.Size = New System.Drawing.Size(900, 253)
        Me.fgExcel.StyleInfo = resources.GetString("fgExcel.StyleInfo")
        Me.fgExcel.TabIndex = 18
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.fgDirect)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(900, 320)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "DIRECT CLIENT"
        '
        'fgDirect
        '
        Me.fgDirect.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDirect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgDirect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgDirect.Location = New System.Drawing.Point(0, 0)
        Me.fgDirect.Name = "fgDirect"
        Me.fgDirect.Rows.DefaultSize = 19
        Me.fgDirect.Size = New System.Drawing.Size(900, 320)
        Me.fgDirect.StyleInfo = resources.GetString("fgDirect.StyleInfo")
        Me.fgDirect.TabIndex = 19
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage4.Controls.Add(Me.fgDirectNotExists)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(900, 320)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "DIRECT CLIENT NOT EXISTS"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.btnDirectExists)
        Me.C1InputPanel3.Items.Add(Me.btnCopyDirect)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 277)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(900, 43)
        Me.C1InputPanel3.TabIndex = 21
        '
        'btnDirectExists
        '
        Me.btnDirectExists.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnDirectExists.Height = 35
        Me.btnDirectExists.Name = "btnDirectExists"
        Me.btnDirectExists.Text = "CHECK"
        Me.btnDirectExists.Width = 100
        '
        'btnCopyDirect
        '
        Me.btnCopyDirect.Height = 35
        Me.btnCopyDirect.Name = "btnCopyDirect"
        Me.btnCopyDirect.Text = "COPY"
        Me.btnCopyDirect.Width = 100
        '
        'fgDirectNotExists
        '
        Me.fgDirectNotExists.AutoClipboard = True
        Me.fgDirectNotExists.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDirectNotExists.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgDirectNotExists.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgDirectNotExists.Location = New System.Drawing.Point(0, 0)
        Me.fgDirectNotExists.Name = "fgDirectNotExists"
        Me.fgDirectNotExists.Rows.DefaultSize = 19
        Me.fgDirectNotExists.Size = New System.Drawing.Size(900, 277)
        Me.fgDirectNotExists.StyleInfo = resources.GetString("fgDirectNotExists.StyleInfo")
        Me.fgDirectNotExists.TabIndex = 20
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.fgDistributor)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(900, 320)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "DISTRIBUTOR CLIENT"
        '
        'fgDistributor
        '
        Me.fgDistributor.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDistributor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgDistributor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgDistributor.Location = New System.Drawing.Point(0, 0)
        Me.fgDistributor.Name = "fgDistributor"
        Me.fgDistributor.Rows.DefaultSize = 19
        Me.fgDistributor.Size = New System.Drawing.Size(900, 320)
        Me.fgDistributor.StyleInfo = resources.GetString("fgDistributor.StyleInfo")
        Me.fgDistributor.TabIndex = 20
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage5.Controls.Add(Me.fgDistributorNew)
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(900, 320)
        Me.C1DockingTabPage5.TabIndex = 4
        Me.C1DockingTabPage5.Text = "DISTRIBUTOR CLIENT NEW"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.btnCopyDistributor)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 277)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(900, 43)
        Me.C1InputPanel4.TabIndex = 22
        '
        'btnCopyDistributor
        '
        Me.btnCopyDistributor.Height = 35
        Me.btnCopyDistributor.Name = "btnCopyDistributor"
        Me.btnCopyDistributor.Text = "COPY"
        Me.btnCopyDistributor.Width = 100
        '
        'fgDistributorNew
        '
        Me.fgDistributorNew.AutoClipboard = True
        Me.fgDistributorNew.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgDistributorNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgDistributorNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgDistributorNew.Location = New System.Drawing.Point(0, 0)
        Me.fgDistributorNew.Name = "fgDistributorNew"
        Me.fgDistributorNew.Rows.DefaultSize = 19
        Me.fgDistributorNew.Size = New System.Drawing.Size(900, 277)
        Me.fgDistributorNew.StyleInfo = resources.GetString("fgDistributorNew.StyleInfo")
        Me.fgDistributorNew.TabIndex = 21
        '
        'bwExcel
        '
        '
        'bwProcess
        '
        '
        'FormAccountCurrentKYCIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 505)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.pbNAV)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAccountCurrentKYCIndividual"
        Me.Text = "S-INVEST: Current KYC Individual"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.fgDirect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage4.ResumeLayout(False)
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgDirectNotExists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.fgDistributor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage5.ResumeLayout(False)
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgDistributorNew, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorRow As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents pbNAV As ProgressBar
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblKYCID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblKYCDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblKYCCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnProcess As C1.Win.C1InputPanel.InputButton
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgDirect As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgDistributor As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACodesetID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACodesetCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesInternal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSACodesetDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectExisting As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDirectFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorExisting As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDistributorSucced As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearchSales As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblDefaultSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDefaultSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgDirectNotExists As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgDistributorNew As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnDirectExists As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCopyDirect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnCopyDistributor As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientKYC As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientNo As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnUpdate As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLocal As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblForeign As C1.Win.C1InputPanel.InputLabel
End Class
