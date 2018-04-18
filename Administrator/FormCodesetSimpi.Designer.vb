<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCodesetSimpi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCodesetSimpi))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGCodeset = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel8 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader10 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCodesetField = New C1.Win.C1InputPanel.InputTextBox()
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
        Me.C1InputPanel1.Items.Add(Me.txtKeyword)
        Me.C1InputPanel1.Items.Add(Me.rbNone)
        Me.C1InputPanel1.Items.Add(Me.rbAnd)
        Me.C1InputPanel1.Items.Add(Me.rbOr)
        Me.C1InputPanel1.Items.Add(Me.rbCombine)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(769, 34)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Keyword: "
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 442
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
        Me.DBGCodeset.Location = New System.Drawing.Point(0, 34)
        Me.DBGCodeset.Name = "DBGCodeset"
        Me.DBGCodeset.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGCodeset.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGCodeset.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGCodeset.PrintInfo.PageSettings = CType(resources.GetObject("DBGCodeset.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGCodeset.PropBag = resources.GetString("DBGCodeset.PropBag")
        Me.DBGCodeset.RecordSelectors = False
        Me.DBGCodeset.Size = New System.Drawing.Size(769, 263)
        Me.DBGCodeset.TabIndex = 4
        Me.DBGCodeset.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel8
        '
        Me.C1InputPanel8.BorderThickness = 1
        Me.C1InputPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel8.Items.Add(Me.InputGroupHeader10)
        Me.C1InputPanel8.Items.Add(Me.InputLabel8)
        Me.C1InputPanel8.Items.Add(Me.txtCodesetField)
        Me.C1InputPanel8.Items.Add(Me.InputLabel53)
        Me.C1InputPanel8.Items.Add(Me.txtCodesetData)
        Me.C1InputPanel8.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel8.Items.Add(Me.btnCodesetAdd)
        Me.C1InputPanel8.Items.Add(Me.btnCodesetRemove)
        Me.C1InputPanel8.Location = New System.Drawing.Point(0, 297)
        Me.C1InputPanel8.Name = "C1InputPanel8"
        Me.C1InputPanel8.Size = New System.Drawing.Size(769, 152)
        Me.C1InputPanel8.TabIndex = 5
        Me.C1InputPanel8.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader10
        '
        Me.InputGroupHeader10.Name = "InputGroupHeader10"
        Me.InputGroupHeader10.Text = "ADD/REMOVE SIMPI CODESET"
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Code field: "
        Me.InputLabel8.Width = 65
        '
        'txtCodesetField
        '
        Me.txtCodesetField.Multiline = True
        Me.txtCodesetField.Name = "txtCodesetField"
        Me.txtCodesetField.ReadOnly = True
        Me.txtCodesetField.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtCodesetField.Width = 685
        '
        'InputLabel53
        '
        Me.InputLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel53.Height = 50
        Me.InputLabel53.Name = "InputLabel53"
        Me.InputLabel53.Text = "Code data: "
        Me.InputLabel53.Width = 65
        '
        'txtCodesetData
        '
        Me.txtCodesetData.Height = 50
        Me.txtCodesetData.Multiline = True
        Me.txtCodesetData.Name = "txtCodesetData"
        Me.txtCodesetData.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtCodesetData.Width = 685
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 753
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
        'FormCodesetSimpi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 449)
        Me.Controls.Add(Me.C1InputPanel8)
        Me.Controls.Add(Me.DBGCodeset)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCodesetSimpi"
        Me.Text = "CODESET: Master Simpi"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGCodeset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGCodeset As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel8 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader10 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCodesetField As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel53 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCodesetData As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnCodesetAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCodesetRemove As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
