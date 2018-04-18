<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactionUnitAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransactionUnitAllocation))
        Me.pbNAV = New System.Windows.Forms.ProgressBar()
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
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFailed = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSucced = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAsOf = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubscriptionAccount = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubscriptionAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemptionAccount = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemptionAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbExternalPortfolio = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundAccountID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundAccountDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.lblFundAccountCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSACodesetDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesInternal = New C1.Win.C1InputPanel.InputLabel()
        Me.btnProcess = New C1.Win.C1InputPanel.InputButton()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fgTransaction = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bwExcel = New System.ComponentModel.BackgroundWorker()
        Me.bwRun = New System.ComponentModel.BackgroundWorker()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.fgTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbNAV
        '
        Me.pbNAV.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbNAV.Location = New System.Drawing.Point(0, 123)
        Me.pbNAV.Name = "pbNAV"
        Me.pbNAV.Size = New System.Drawing.Size(903, 23)
        Me.pbNAV.Step = 1
        Me.pbNAV.TabIndex = 21
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
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblRows)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.lblFailed)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.lblSucced)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.lblAsOf)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.lblSubscriptionAccount)
        Me.C1InputPanel1.Items.Add(Me.lblSubscriptionAmount)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblRedemptionAccount)
        Me.C1InputPanel1.Items.Add(Me.lblRedemptionAmount)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(903, 123)
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
        Me.txtColNo.Text = "22"
        Me.txtColNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtColNo.Width = 35
        '
        'btnRead
        '
        Me.btnRead.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRead.Image = CType(resources.GetObject("btnRead.Image"), System.Drawing.Image)
        Me.btnRead.Name = "btnRead"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "FILE STATUS"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Rows: "
        '
        'lblRows
        '
        Me.lblRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRows.ForeColor = System.Drawing.Color.Red
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 60
        '
        'InputLabel10
        '
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Failed:"
        '
        'lblFailed
        '
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Width = 35
        '
        'InputLabel11
        '
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Succed:"
        '
        'lblSucced
        '
        Me.lblSucced.Name = "lblSucced"
        Me.lblSucced.Width = 35
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "As Of: "
        '
        'lblAsOf
        '
        Me.lblAsOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsOf.ForeColor = System.Drawing.Color.Red
        Me.lblAsOf.Name = "lblAsOf"
        Me.lblAsOf.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Subscription: "
        '
        'lblSubscriptionAccount
        '
        Me.lblSubscriptionAccount.Name = "lblSubscriptionAccount"
        Me.lblSubscriptionAccount.Width = 35
        '
        'lblSubscriptionAmount
        '
        Me.lblSubscriptionAmount.Name = "lblSubscriptionAmount"
        Me.lblSubscriptionAmount.Width = 100
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Redemption: "
        '
        'lblRedemptionAccount
        '
        Me.lblRedemptionAccount.Name = "lblRedemptionAccount"
        Me.lblRedemptionAccount.Width = 35
        '
        'lblRedemptionAmount
        '
        Me.lblRedemptionAmount.Name = "lblRedemptionAmount"
        Me.lblRedemptionAmount.Width = 100
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.ItemSize = New System.Drawing.Size(0, 35)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 146)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(903, 367)
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
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(901, 328)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "FILE READ"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.cmbExternalPortfolio)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.lblFundAccountID)
        Me.C1InputPanel2.Items.Add(Me.lblFundAccountDescription)
        Me.C1InputPanel2.Items.Add(Me.lblFundAccountCode)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetID)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetCode)
        Me.C1InputPanel2.Items.Add(Me.lblSACodesetDescription)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.lblSalesInternal)
        Me.C1InputPanel2.Items.Add(Me.btnProcess)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 262)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(901, 66)
        Me.C1InputPanel2.TabIndex = 19
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Portfolio Identification:"
        Me.InputLabel5.Width = 135
        '
        'cmbExternalPortfolio
        '
        Me.cmbExternalPortfolio.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbExternalPortfolio.Name = "cmbExternalPortfolio"
        Me.cmbExternalPortfolio.Width = 150
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "S-Invest Fund Account:"
        Me.InputLabel2.Width = 135
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
        Me.lblFundAccountCode.Width = 365
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
        Me.lblSACodesetDescription.Name = "lblSACodesetDescription"
        Me.lblSACodesetDescription.Text = "S-INVEST SA CODE"
        Me.lblSACodesetDescription.Width = 205
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
        Me.lblSalesInternal.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblSalesInternal.Name = "lblSalesInternal"
        Me.lblSalesInternal.Width = 161
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
        Me.fgExcel.Size = New System.Drawing.Size(901, 262)
        Me.fgExcel.StyleInfo = resources.GetString("fgExcel.StyleInfo")
        Me.fgExcel.TabIndex = 18
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.fgTransaction)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(901, 328)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "TRANSACTION"
        '
        'fgTransaction
        '
        Me.fgTransaction.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgTransaction.Location = New System.Drawing.Point(0, 0)
        Me.fgTransaction.Name = "fgTransaction"
        Me.fgTransaction.Rows.DefaultSize = 19
        Me.fgTransaction.Size = New System.Drawing.Size(901, 328)
        Me.fgTransaction.StyleInfo = resources.GetString("fgTransaction.StyleInfo")
        Me.fgTransaction.TabIndex = 19
        '
        'bwExcel
        '
        '
        'bwRun
        '
        '
        'FormTransactionUnitAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 513)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.pbNAV)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransactionUnitAllocation"
        Me.Text = "S-INVEST: Upload Unit Allocation - Transaction"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.fgTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbNAV As ProgressBar
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
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblFailed As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSucced As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAsOf As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
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
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fgTransaction As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbExternalPortfolio As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents bwExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubscriptionAccount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubscriptionAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemptionAccount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemptionAmount As C1.Win.C1InputPanel.InputLabel
End Class
