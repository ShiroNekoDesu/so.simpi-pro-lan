<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalesFeeIncentive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesFeeIncentive))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbSubscription = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbRedemption = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbNTA = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbLA = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.chkTop = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtAmount = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtDescription = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.chkDirect = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtDirect = New C1.Win.C1InputPanel.InputTextBox()
        Me.chkTeam = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtTeam = New C1.Win.C1InputPanel.InputTextBox()
        Me.chkTotal = New C1.Win.C1InputPanel.InputCheckBox()
        Me.txtTotal = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemove = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGTable = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.b = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.rbSubscription)
        Me.C1InputPanel1.Items.Add(Me.rbRedemption)
        Me.C1InputPanel1.Items.Add(Me.rbNTA)
        Me.C1InputPanel1.Items.Add(Me.rbLA)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.chkTop)
        Me.C1InputPanel1.Items.Add(Me.txtAmount)
        Me.C1InputPanel1.Items.Add(Me.txtDescription)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.chkDirect)
        Me.C1InputPanel1.Items.Add(Me.txtDirect)
        Me.C1InputPanel1.Items.Add(Me.chkTeam)
        Me.C1InputPanel1.Items.Add(Me.txtTeam)
        Me.C1InputPanel1.Items.Add(Me.chkTotal)
        Me.C1InputPanel1.Items.Add(Me.txtTotal)
        Me.C1InputPanel1.Items.Add(Me.btnAdd)
        Me.C1InputPanel1.Items.Add(Me.btnRemove)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(684, 127)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "FEE SETTING"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Type: "
        Me.InputLabel1.Width = 45
        '
        'rbSubscription
        '
        Me.rbSubscription.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbSubscription.Checked = True
        Me.rbSubscription.Enabled = False
        Me.rbSubscription.Name = "rbSubscription"
        Me.rbSubscription.Text = "Subscription"
        '
        'rbRedemption
        '
        Me.rbRedemption.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbRedemption.Enabled = False
        Me.rbRedemption.Name = "rbRedemption"
        Me.rbRedemption.Text = "Redemption"
        '
        'rbNTA
        '
        Me.rbNTA.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNTA.Enabled = False
        Me.rbNTA.Name = "rbNTA"
        Me.rbNTA.Text = "New Transaction Account"
        '
        'rbLA
        '
        Me.rbLA.Enabled = False
        Me.rbLA.Name = "rbLA"
        Me.rbLA.Text = "Liquidation Account"
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Range: "
        Me.InputLabel5.Width = 45
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
        Me.txtDescription.Width = 410
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Sales: "
        Me.InputLabel6.Width = 45
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
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "TIERING/LAYERING TABLE"
        '
        'DBGTable
        '
        Me.DBGTable.BackColor = System.Drawing.Color.White
        Me.DBGTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGTable.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTable.Images.Add(CType(resources.GetObject("DBGTable.Images"), System.Drawing.Image))
        Me.DBGTable.Location = New System.Drawing.Point(0, 127)
        Me.DBGTable.Name = "DBGTable"
        Me.DBGTable.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTable.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTable.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTable.PrintInfo.PageSettings = CType(resources.GetObject("DBGTable.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTable.PropBag = resources.GetString("DBGTable.PropBag")
        Me.DBGTable.RecordSelectors = False
        Me.DBGTable.Size = New System.Drawing.Size(684, 200)
        Me.DBGTable.TabIndex = 6
        Me.DBGTable.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.b)
        Me.C1InputPanel2.Items.Add(Me.btnCancel)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 327)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(684, 42)
        Me.C1InputPanel2.TabIndex = 7
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'b
        '
        Me.b.Break = C1.Win.C1InputPanel.BreakType.None
        Me.b.Height = 35
        Me.b.Image = CType(resources.GetObject("b.Image"), System.Drawing.Image)
        Me.b.Name = "b"
        Me.b.Text = "SAVE"
        Me.b.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'FormSalesFeeIncentive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 369)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.DBGTable)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalesFeeIncentive"
        Me.Text = "SALES MAINTENANCE: Sales Incentive"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbSubscription As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbRedemption As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNTA As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAmount As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtDescription As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents chkDirect As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtDirect As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents chkTeam As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtTeam As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents chkTotal As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents txtTotal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents chkTop As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGTable As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents b As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbLA As C1.Win.C1InputPanel.InputRadioButton
End Class
