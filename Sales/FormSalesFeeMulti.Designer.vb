<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalesFeeMulti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesFeeMulti))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblMultiID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblMultiCode = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblMultiDescription = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbFlat = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbTiering = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbLayering = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDays = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.btnAddPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemovePortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGPortfolio = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.chkTop = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtAmount = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtDescription = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.chkDirect = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtDirect = New C1.Win.C1InputPanel.InputTextBox()
        Me.chkTeam = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtTeam = New C1.Win.C1InputPanel.InputTextBox()
        Me.chkTotal = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtTotal = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemove = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGTable = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblMultiID)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblMultiCode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.lblMultiDescription)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.rbFlat)
        Me.C1InputPanel1.Items.Add(Me.rbTiering)
        Me.C1InputPanel1.Items.Add(Me.rbLayering)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.txtDays)
        Me.C1InputPanel1.Items.Add(Me.InputLabel19)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.btnAddPortfolio)
        Me.C1InputPanel1.Items.Add(Me.btnRemovePortfolio)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(684, 215)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "ID: "
        '
        'lblMultiID
        '
        Me.lblMultiID.Name = "lblMultiID"
        Me.lblMultiID.Text = "Label"
        Me.lblMultiID.Width = 50
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "CODE: "
        '
        'lblMultiCode
        '
        Me.lblMultiCode.Name = "lblMultiCode"
        Me.lblMultiCode.Width = 150
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "DESCRIPTION: "
        Me.InputLabel4.Width = 122
        '
        'lblMultiDescription
        '
        Me.lblMultiDescription.Name = "lblMultiDescription"
        Me.lblMultiDescription.Width = 538
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "FEE SETTING"
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Type: "
        Me.InputLabel7.Width = 45
        '
        'rbFlat
        '
        Me.rbFlat.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbFlat.Checked = True
        Me.rbFlat.Name = "rbFlat"
        Me.rbFlat.Text = "Flat"
        '
        'rbTiering
        '
        Me.rbTiering.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbTiering.Name = "rbTiering"
        Me.rbTiering.Text = "Tiering"
        '
        'rbLayering
        '
        Me.rbLayering.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbLayering.Name = "rbLayering"
        Me.rbLayering.Text = "Layering"
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Apply after: "
        Me.InputLabel8.Width = 75
        '
        'txtDays
        '
        Me.txtDays.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Width = 65
        '
        'InputLabel19
        '
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "day(s) of investment"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Text = "Label"
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Text = "Label"
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Text = "Label"
        Me.lblSimpiName.Width = 605
        '
        'btnAddPortfolio
        '
        Me.btnAddPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAddPortfolio.Image = CType(resources.GetObject("btnAddPortfolio.Image"), System.Drawing.Image)
        Me.btnAddPortfolio.Name = "btnAddPortfolio"
        Me.btnAddPortfolio.ToolTipText = "Add new master portfolio"
        '
        'btnRemovePortfolio
        '
        Me.btnRemovePortfolio.Image = CType(resources.GetObject("btnRemovePortfolio.Image"), System.Drawing.Image)
        Me.btnRemovePortfolio.Name = "btnRemovePortfolio"
        Me.btnRemovePortfolio.ToolTipText = "Remove selected master portfolio"
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "LIST OF PORTFOLIO APPLIED"
        '
        'DBGPortfolio
        '
        Me.DBGPortfolio.BackColor = System.Drawing.Color.White
        Me.DBGPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGPortfolio.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGPortfolio.Images.Add(CType(resources.GetObject("DBGPortfolio.Images"), System.Drawing.Image))
        Me.DBGPortfolio.Location = New System.Drawing.Point(0, 215)
        Me.DBGPortfolio.Name = "DBGPortfolio"
        Me.DBGPortfolio.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolio.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGPortfolio.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGPortfolio.PrintInfo.PageSettings = CType(resources.GetObject("DBGPortfolio.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGPortfolio.PropBag = resources.GetString("DBGPortfolio.PropBag")
        Me.DBGPortfolio.RecordSelectors = False
        Me.DBGPortfolio.Size = New System.Drawing.Size(684, 95)
        Me.DBGPortfolio.TabIndex = 6
        Me.DBGPortfolio.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.btnSave)
        Me.C1InputPanel2.Items.Add(Me.btnCancel)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 488)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(684, 42)
        Me.C1InputPanel2.TabIndex = 7
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'btnSave
        '
        Me.btnSave.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSave.Height = 35
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "SAVE"
        Me.btnSave.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputLabel17)
        Me.C1InputPanel3.Items.Add(Me.chkTop)
        Me.C1InputPanel3.Items.Add(Me.txtAmount)
        Me.C1InputPanel3.Items.Add(Me.txtDescription)
        Me.C1InputPanel3.Items.Add(Me.InputLabel18)
        Me.C1InputPanel3.Items.Add(Me.chkDirect)
        Me.C1InputPanel3.Items.Add(Me.txtDirect)
        Me.C1InputPanel3.Items.Add(Me.chkTeam)
        Me.C1InputPanel3.Items.Add(Me.txtTeam)
        Me.C1InputPanel3.Items.Add(Me.chkTotal)
        Me.C1InputPanel3.Items.Add(Me.txtTotal)
        Me.C1InputPanel3.Items.Add(Me.btnAdd)
        Me.C1InputPanel3.Items.Add(Me.btnRemove)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 310)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(684, 83)
        Me.C1InputPanel3.TabIndex = 8
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel17
        '
        Me.InputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Range: "
        Me.InputLabel17.Width = 45
        '
        'chkTop
        '
        Me.chkTop.Break = C1.Win.C1InputPanel.BreakType.None
        Me.chkTop.Name = "chkTop"
        Me.chkTop.Text = "Top"
        Me.chkTop.Width = 55
        '
        'txtAmount
        '
        Me.txtAmount.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Width = 125
        '
        'txtDescription
        '
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Width = 430
        '
        'InputLabel18
        '
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Sales: "
        Me.InputLabel18.Width = 45
        '
        'chkDirect
        '
        Me.chkDirect.Break = C1.Win.C1InputPanel.BreakType.None
        Me.chkDirect.Name = "chkDirect"
        Me.chkDirect.Text = "Direct"
        Me.chkDirect.Width = 55
        '
        'txtDirect
        '
        Me.txtDirect.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtDirect.Name = "txtDirect"
        Me.txtDirect.Width = 65
        '
        'chkTeam
        '
        Me.chkTeam.Break = C1.Win.C1InputPanel.BreakType.None
        Me.chkTeam.Name = "chkTeam"
        Me.chkTeam.Text = "Team"
        Me.chkTeam.Width = 55
        '
        'txtTeam
        '
        Me.txtTeam.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Width = 65
        '
        'chkTotal
        '
        Me.chkTotal.Break = C1.Win.C1InputPanel.BreakType.None
        Me.chkTotal.Name = "chkTotal"
        Me.chkTotal.Text = "Total"
        Me.chkTotal.Width = 55
        '
        'txtTotal
        '
        Me.txtTotal.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Width = 65
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ToolTipText = "Add new tiering/layering row"
        '
        'btnRemove
        '
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.ToolTipText = "Remove tiering/layering row"
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "TIERING/LAYERING TABLE"
        '
        'DBGTable
        '
        Me.DBGTable.BackColor = System.Drawing.Color.White
        Me.DBGTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGTable.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTable.Images.Add(CType(resources.GetObject("DBGTable.Images"), System.Drawing.Image))
        Me.DBGTable.Location = New System.Drawing.Point(0, 393)
        Me.DBGTable.Name = "DBGTable"
        Me.DBGTable.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTable.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTable.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTable.PrintInfo.PageSettings = CType(resources.GetObject("DBGTable.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTable.PropBag = resources.GetString("DBGTable.PropBag")
        Me.DBGTable.RecordSelectors = False
        Me.DBGTable.Size = New System.Drawing.Size(684, 95)
        Me.DBGTable.TabIndex = 9
        Me.DBGTable.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'FormSalesFeeMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 530)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.DBGTable)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.DBGPortfolio)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalesFeeMulti"
        Me.Text = "SALES MAINTENANCE: Multi Sharing Fee"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnAddPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemovePortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGPortfolio As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblMultiID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblMultiCode As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents lblMultiDescription As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbFlat As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbTiering As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbLayering As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDays As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents chkTop As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtAmount As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtDescription As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents chkDirect As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtDirect As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents chkTeam As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtTeam As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents chkTotal As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtTotal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGTable As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
End Class
