<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccountMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountMaintenance))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnAdd = New C1.Win.C1InputPanel.InputSplitButton()
        Me.btnAddIndividual = New C1.Win.C1InputPanel.InputButton()
        Me.btnAddInstitutional = New C1.Win.C1InputPanel.InputButton()
        Me.btnAddDistributor = New C1.Win.C1InputPanel.InputButton()
        Me.btnProfile = New C1.Win.C1InputPanel.InputButton()
        Me.DBGClient = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGClient, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel1.Items.Add(Me.btnAdd)
        Me.C1InputPanel1.Items.Add(Me.btnProfile)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(889, 50)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Keyword, that simillar with client name"
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 551
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
        Me.btnSearch.ToolTipText = "Search client"
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Items.Add(Me.btnAddIndividual)
        Me.btnAdd.Items.Add(Me.btnAddInstitutional)
        Me.btnAdd.Items.Add(Me.btnAddDistributor)
        Me.btnAdd.Name = "btnAdd"
        '
        'btnAddIndividual
        '
        Me.btnAddIndividual.Name = "btnAddIndividual"
        Me.btnAddIndividual.Text = "INDIVIDUAL"
        Me.btnAddIndividual.ToolTipText = "Add new individual account"
        '
        'btnAddInstitutional
        '
        Me.btnAddInstitutional.Name = "btnAddInstitutional"
        Me.btnAddInstitutional.Text = "INSTITUTION"
        Me.btnAddInstitutional.ToolTipText = "Add new institutional account"
        '
        'btnAddDistributor
        '
        Me.btnAddDistributor.Name = "btnAddDistributor"
        Me.btnAddDistributor.Text = "DISTRIBUTOR"
        Me.btnAddDistributor.ToolTipText = "Add new distributor account"
        '
        'btnProfile
        '
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Name = "btnProfile"
        '
        'DBGClient
        '
        Me.DBGClient.BackColor = System.Drawing.Color.White
        Me.DBGClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGClient.ContextMenuStrip = Me.csMenu
        Me.DBGClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGClient.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGClient.Images.Add(CType(resources.GetObject("DBGClient.Images"), System.Drawing.Image))
        Me.DBGClient.Location = New System.Drawing.Point(0, 50)
        Me.DBGClient.Name = "DBGClient"
        Me.DBGClient.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGClient.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGClient.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGClient.PrintInfo.PageSettings = CType(resources.GetObject("DBGClient.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGClient.PropBag = resources.GetString("DBGClient.PropBag")
        Me.DBGClient.RecordSelectors = False
        Me.DBGClient.Size = New System.Drawing.Size(889, 368)
        Me.DBGClient.TabIndex = 4
        Me.DBGClient.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormAccountMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 418)
        Me.Controls.Add(Me.DBGClient)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAccountMaintenance"
        Me.Text = "ACCOUNT MANAGEMENT"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGClient As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputSplitButton
    Friend WithEvents btnAddIndividual As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnAddInstitutional As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnAddDistributor As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnProfile As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
