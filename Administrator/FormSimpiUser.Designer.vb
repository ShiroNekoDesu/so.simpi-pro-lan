<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimpiUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSimpiUser))
        Me.DBGUser = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.inputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnProfile = New C1.Win.C1InputPanel.InputButton()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DBGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DBGUser
        '
        Me.DBGUser.BackColor = System.Drawing.Color.White
        Me.DBGUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGUser.ContextMenuStrip = Me.csMenu
        Me.DBGUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGUser.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGUser.Images.Add(CType(resources.GetObject("DBGUser.Images"), System.Drawing.Image))
        Me.DBGUser.Location = New System.Drawing.Point(0, 49)
        Me.DBGUser.Name = "DBGUser"
        Me.DBGUser.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGUser.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGUser.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGUser.PrintInfo.PageSettings = CType(resources.GetObject("DBGUser.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGUser.PropBag = resources.GetString("DBGUser.PropBag")
        Me.DBGUser.RecordSelectors = False
        Me.DBGUser.Size = New System.Drawing.Size(831, 381)
        Me.DBGUser.TabIndex = 3
        Me.DBGUser.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.inputLabel1)
        Me.C1InputPanel2.Items.Add(Me.txtKeyword)
        Me.C1InputPanel2.Items.Add(Me.rbNone)
        Me.C1InputPanel2.Items.Add(Me.rbAnd)
        Me.C1InputPanel2.Items.Add(Me.rbOr)
        Me.C1InputPanel2.Items.Add(Me.rbCombine)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Items.Add(Me.btnAdd)
        Me.C1InputPanel2.Items.Add(Me.btnProfile)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(831, 49)
        Me.C1InputPanel2.TabIndex = 7
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'inputLabel1
        '
        Me.inputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.inputLabel1.Name = "inputLabel1"
        Me.inputLabel1.Text = "Keyword, that simillar with master simpi name and/or shortname:"
        Me.inputLabel1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.txtKeyword.Width = 501
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
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        '
        'btnProfile
        '
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Name = "btnProfile"
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
        'FormSimpiUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 431)
        Me.Controls.Add(Me.DBGUser)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSimpiUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPI USER"
        CType(Me.DBGUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DBGUser As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents inputLabel1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnProfile As C1.Win.C1InputPanel.InputButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
