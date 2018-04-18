<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalesCodeset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesCodeset))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchField = New C1.Win.C1InputPanel.InputButton()
        Me.lblID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.fgCodeset = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgCodeset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.btnSearchField)
        Me.C1InputPanel1.Items.Add(Me.lblID)
        Me.C1InputPanel1.Items.Add(Me.lblDescription)
        Me.C1InputPanel1.Items.Add(Me.lblCode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.txtKeyword)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(889, 48)
        Me.C1InputPanel1.TabIndex = 5
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Codeset Field"
        Me.InputLabel2.Width = 85
        '
        'btnSearchField
        '
        Me.btnSearchField.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchField.Image = CType(resources.GetObject("btnSearchField.Image"), System.Drawing.Image)
        Me.btnSearchField.Name = "btnSearchField"
        '
        'lblID
        '
        Me.lblID.Name = "lblID"
        Me.lblID.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblID.Width = 1
        '
        'lblDescription
        '
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblDescription.Width = 1
        '
        'lblCode
        '
        Me.lblCode.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Width = 508
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Keyword, that simillar with sales name"
        Me.InputLabel1.Width = 291
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 288
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ToolTipText = "Search client with codeset"
        '
        'fgCodeset
        '
        Me.fgCodeset.AutoResize = True
        Me.fgCodeset.ColumnInfo = "7,0,0,0,0,95,Columns:"
        Me.fgCodeset.ContextMenuStrip = Me.csMenu
        Me.fgCodeset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgCodeset.Location = New System.Drawing.Point(0, 48)
        Me.fgCodeset.Name = "fgCodeset"
        Me.fgCodeset.Rows.Count = 1
        Me.fgCodeset.Rows.DefaultSize = 19
        Me.fgCodeset.Size = New System.Drawing.Size(889, 368)
        Me.fgCodeset.TabIndex = 6
        Me.fgCodeset.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
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
        'FormSalesCodeset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 416)
        Me.Controls.Add(Me.fgCodeset)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalesCodeset"
        Me.Text = "SALES MANAGEMENT: Codeset"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgCodeset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearchField As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgCodeset As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents lblDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
