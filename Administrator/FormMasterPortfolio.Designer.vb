<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterPortfolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterPortfolio))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.inputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine1 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnProfile = New C1.Win.C1InputPanel.InputButton()
        Me.DBGPortfolio = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.DBGPortfolioSharing = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeywordSharing = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbNone2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine2 = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearchSharing = New C1.Win.C1InputPanel.InputButton()
        Me.btnProfileSharing = New C1.Win.C1InputPanel.InputButton()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SharingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.DBGPortfolioSharing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.inputLabel1)
        Me.C1InputPanel2.Items.Add(Me.txtKeyword)
        Me.C1InputPanel2.Items.Add(Me.rbNone1)
        Me.C1InputPanel2.Items.Add(Me.rbAnd1)
        Me.C1InputPanel2.Items.Add(Me.rbOr1)
        Me.C1InputPanel2.Items.Add(Me.rbCombine1)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Items.Add(Me.btnAdd)
        Me.C1InputPanel2.Items.Add(Me.btnProfile)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(785, 50)
        Me.C1InputPanel2.TabIndex = 10
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'inputLabel1
        '
        Me.inputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.inputLabel1.Name = "inputLabel1"
        Me.inputLabel1.Text = "Keyword, that simillar with master portfolio code,  name and/or shortname:"
        Me.inputLabel1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.txtKeyword.Width = 458
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
        'DBGPortfolio
        '
        Me.DBGPortfolio.BackColor = System.Drawing.Color.White
        Me.DBGPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGPortfolio.ContextMenuStrip = Me.csMenu
        Me.DBGPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGPortfolio.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGPortfolio.Images.Add(CType(resources.GetObject("DBGPortfolio.Images"), System.Drawing.Image))
        Me.DBGPortfolio.Location = New System.Drawing.Point(0, 50)
        Me.DBGPortfolio.Name = "DBGPortfolio"
        Me.DBGPortfolio.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolio.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGPortfolio.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGPortfolio.PrintInfo.PageSettings = CType(resources.GetObject("DBGPortfolio.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGPortfolio.PropBag = resources.GetString("DBGPortfolio.PropBag")
        Me.DBGPortfolio.Size = New System.Drawing.Size(785, 375)
        Me.DBGPortfolio.TabIndex = 8
        Me.DBGPortfolio.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.ItemSize = New System.Drawing.Size(0, 35)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(787, 464)
        Me.C1DockingTab1.TabIndex = 11
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.DBGPortfolio)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(785, 425)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "SIMPI PORTFOLIO"
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.DBGPortfolioSharing)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel1)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 38)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(785, 425)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "SHARING PORTFOLIO"
        '
        'DBGPortfolioSharing
        '
        Me.DBGPortfolioSharing.BackColor = System.Drawing.Color.White
        Me.DBGPortfolioSharing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGPortfolioSharing.ContextMenuStrip = Me.csMenu
        Me.DBGPortfolioSharing.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGPortfolioSharing.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGPortfolioSharing.Images.Add(CType(resources.GetObject("DBGPortfolioSharing.Images"), System.Drawing.Image))
        Me.DBGPortfolioSharing.Location = New System.Drawing.Point(0, 50)
        Me.DBGPortfolioSharing.Name = "DBGPortfolioSharing"
        Me.DBGPortfolioSharing.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolioSharing.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGPortfolioSharing.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGPortfolioSharing.PrintInfo.PageSettings = CType(resources.GetObject("DBGPortfolioSharing.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGPortfolioSharing.PropBag = resources.GetString("DBGPortfolioSharing.PropBag")
        Me.DBGPortfolioSharing.Size = New System.Drawing.Size(785, 375)
        Me.DBGPortfolioSharing.TabIndex = 12
        Me.DBGPortfolioSharing.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.txtKeywordSharing)
        Me.C1InputPanel1.Items.Add(Me.rbNone2)
        Me.C1InputPanel1.Items.Add(Me.rbAnd2)
        Me.C1InputPanel1.Items.Add(Me.rbOr2)
        Me.C1InputPanel1.Items.Add(Me.rbCombine2)
        Me.C1InputPanel1.Items.Add(Me.btnSearchSharing)
        Me.C1InputPanel1.Items.Add(Me.btnProfileSharing)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(785, 50)
        Me.C1InputPanel1.TabIndex = 11
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Keyword, that simillar with master portfolio code,  name and/or shortname:"
        Me.InputLabel2.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        '
        'txtKeywordSharing
        '
        Me.txtKeywordSharing.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeywordSharing.Name = "txtKeywordSharing"
        Me.txtKeywordSharing.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.txtKeywordSharing.Width = 487
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
        'btnSearchSharing
        '
        Me.btnSearchSharing.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchSharing.Image = CType(resources.GetObject("btnSearchSharing.Image"), System.Drawing.Image)
        Me.btnSearchSharing.Name = "btnSearchSharing"
        '
        'btnProfileSharing
        '
        Me.btnProfileSharing.Image = CType(resources.GetObject("btnProfileSharing.Image"), System.Drawing.Image)
        Me.btnProfileSharing.Name = "btnProfileSharing"
        '
        'csMenu
        '
        Me.csMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttachToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExportToolStripMenuItem, Me.SharingToolStripMenuItem})
        Me.csMenu.Name = "csMenu"
        Me.csMenu.Size = New System.Drawing.Size(157, 92)
        '
        'AttachToolStripMenuItem
        '
        Me.AttachToolStripMenuItem.Name = "AttachToolStripMenuItem"
        Me.AttachToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AttachToolStripMenuItem.Text = "Detach"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExportToolStripMenuItem.Text = "Export Portfolio"
        '
        'SharingToolStripMenuItem
        '
        Me.SharingToolStripMenuItem.Name = "SharingToolStripMenuItem"
        Me.SharingToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SharingToolStripMenuItem.Text = "Export Sharing"
        '
        'FormMasterPortfolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 464)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterPortfolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER PORTFOLIO"
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.DBGPortfolioSharing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents inputLabel1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGPortfolio As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents DBGPortfolioSharing As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents txtKeywordSharing As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents btnSearchSharing As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnProfile As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnProfileSharing As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine1 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine2 As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SharingToolStripMenuItem As ToolStripMenuItem
End Class
