<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCodetsetPortfolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCodetsetPortfolio))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchCodeset = New C1.Win.C1InputPanel.InputButton()
        Me.lblCodeset = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGCodeset = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel8 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader10 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel53 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCodesetData = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnCodesetAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnCodesetRemove = New C1.Win.C1InputPanel.InputButton()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGCodeset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.btnSearchCodeset)
        Me.C1InputPanel1.Items.Add(Me.lblCodeset)
        Me.C1InputPanel1.Items.Add(Me.lblDescription)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtKeyword)
        Me.C1InputPanel1.Items.Add(Me.rbNone)
        Me.C1InputPanel1.Items.Add(Me.rbAnd)
        Me.C1InputPanel1.Items.Add(Me.rbOr)
        Me.C1InputPanel1.Items.Add(Me.rbCombine)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(837, 58)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Codeset: "
        Me.InputLabel1.Width = 75
        '
        'btnSearchCodeset
        '
        Me.btnSearchCodeset.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchCodeset.Image = CType(resources.GetObject("btnSearchCodeset.Image"), System.Drawing.Image)
        Me.btnSearchCodeset.Name = "btnSearchCodeset"
        '
        'lblCodeset
        '
        Me.lblCodeset.Name = "lblCodeset"
        Me.lblCodeset.Width = 200
        '
        'lblDescription
        '
        Me.lblDescription.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Width = 507
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Portfolio: "
        Me.InputLabel3.Width = 75
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 487
        '
        'rbNone
        '
        Me.rbNone.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNone.Checked = True
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Text = "NONE"
        '
        'rbAnd
        '
        Me.rbAnd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbAnd.Name = "rbAnd"
        Me.rbAnd.Text = "AND"
        '
        'rbOr
        '
        Me.rbOr.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbOr.Name = "rbOr"
        Me.rbOr.Text = "OR"
        '
        'rbCombine
        '
        Me.rbCombine.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCombine.Name = "rbCombine"
        Me.rbCombine.Text = "COMBINE"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'DBGCodeset
        '
        Me.DBGCodeset.BackColor = System.Drawing.Color.White
        Me.DBGCodeset.ContextMenuStrip = Me.csMenu
        Me.DBGCodeset.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGCodeset.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGCodeset.Images.Add(CType(resources.GetObject("DBGCodeset.Images"), System.Drawing.Image))
        Me.DBGCodeset.Location = New System.Drawing.Point(0, 58)
        Me.DBGCodeset.Name = "DBGCodeset"
        Me.DBGCodeset.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGCodeset.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGCodeset.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGCodeset.PrintInfo.PageSettings = CType(resources.GetObject("DBGCodeset.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGCodeset.PropBag = resources.GetString("DBGCodeset.PropBag")
        Me.DBGCodeset.RecordSelectors = False
        Me.DBGCodeset.Size = New System.Drawing.Size(837, 325)
        Me.DBGCodeset.TabIndex = 5
        Me.DBGCodeset.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel8
        '
        Me.C1InputPanel8.BorderThickness = 1
        Me.C1InputPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel8.Items.Add(Me.InputGroupHeader10)
        Me.C1InputPanel8.Items.Add(Me.InputLabel2)
        Me.C1InputPanel8.Items.Add(Me.lblCode)
        Me.C1InputPanel8.Items.Add(Me.lblName)
        Me.C1InputPanel8.Items.Add(Me.InputLabel53)
        Me.C1InputPanel8.Items.Add(Me.txtCodesetData)
        Me.C1InputPanel8.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel8.Items.Add(Me.btnCodesetAdd)
        Me.C1InputPanel8.Items.Add(Me.btnCodesetRemove)
        Me.C1InputPanel8.Location = New System.Drawing.Point(0, 383)
        Me.C1InputPanel8.Name = "C1InputPanel8"
        Me.C1InputPanel8.Size = New System.Drawing.Size(837, 145)
        Me.C1InputPanel8.TabIndex = 6
        Me.C1InputPanel8.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader10
        '
        Me.InputGroupHeader10.Name = "InputGroupHeader10"
        Me.InputGroupHeader10.Text = "ADD/REMOVE PORTFOLIO CODESET"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Master Portfolio: "
        Me.InputLabel2.Width = 100
        '
        'lblCode
        '
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Width = 100
        '
        'lblName
        '
        Me.lblName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblName.Name = "lblName"
        '
        'InputLabel53
        '
        Me.InputLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel53.Height = 50
        Me.InputLabel53.Name = "InputLabel53"
        Me.InputLabel53.Text = "Code data: "
        Me.InputLabel53.Width = 100
        '
        'txtCodesetData
        '
        Me.txtCodesetData.Height = 50
        Me.txtCodesetData.Multiline = True
        Me.txtCodesetData.Name = "txtCodesetData"
        Me.txtCodesetData.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtCodesetData.Width = 716
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 817
        '
        'btnCodesetAdd
        '
        Me.btnCodesetAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnCodesetAdd.Enabled = False
        Me.btnCodesetAdd.Height = 35
        Me.btnCodesetAdd.Image = CType(resources.GetObject("btnCodesetAdd.Image"), System.Drawing.Image)
        Me.btnCodesetAdd.Name = "btnCodesetAdd"
        Me.btnCodesetAdd.Text = "ADD"
        Me.btnCodesetAdd.Width = 100
        '
        'btnCodesetRemove
        '
        Me.btnCodesetRemove.Enabled = False
        Me.btnCodesetRemove.Height = 35
        Me.btnCodesetRemove.Image = CType(resources.GetObject("btnCodesetRemove.Image"), System.Drawing.Image)
        Me.btnCodesetRemove.Name = "btnCodesetRemove"
        Me.btnCodesetRemove.Text = "REMOVE"
        Me.btnCodesetRemove.Width = 100
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
        'FormCodetsetPortfolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 528)
        Me.Controls.Add(Me.C1InputPanel8)
        Me.Controls.Add(Me.DBGCodeset)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCodetsetPortfolio"
        Me.Text = "CODESET: Master Portfolio"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGCodeset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearchCodeset As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGCodeset As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel8 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader10 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel53 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCodesetData As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnCodesetAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCodesetRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCodeset As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
