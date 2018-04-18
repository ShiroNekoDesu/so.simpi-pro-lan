<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountKYC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountKYC))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearchKYC = New C1.Win.C1InputPanel.InputButton()
        Me.lblKYCID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblKYCDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.lblKYCCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbClientType = New C1.Win.C1InputPanel.InputComboBox()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.fgKYC = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        CType(Me.fgKYC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.ContextMenuStrip = Me.csMenu
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.cmbClientType)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.btnSearchKYC)
        Me.C1InputPanel1.Items.Add(Me.lblKYCID)
        Me.C1InputPanel1.Items.Add(Me.lblKYCDescription)
        Me.C1InputPanel1.Items.Add(Me.lblKYCCode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.txtKeyword)
        Me.C1InputPanel1.Items.Add(Me.rbNone)
        Me.C1InputPanel1.Items.Add(Me.rbAnd)
        Me.C1InputPanel1.Items.Add(Me.rbOr)
        Me.C1InputPanel1.Items.Add(Me.rbCombine)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(889, 84)
        Me.C1InputPanel1.TabIndex = 5
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
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
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "KYC Field: "
        Me.InputLabel2.Width = 75
        '
        'btnSearchKYC
        '
        Me.btnSearchKYC.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchKYC.Image = CType(resources.GetObject("btnSearchKYC.Image"), System.Drawing.Image)
        Me.btnSearchKYC.Name = "btnSearchKYC"
        '
        'lblKYCID
        '
        Me.lblKYCID.Name = "lblKYCID"
        Me.lblKYCID.Width = 55
        '
        'lblKYCDescription
        '
        Me.lblKYCDescription.Name = "lblKYCDescription"
        Me.lblKYCDescription.Width = 332
        '
        'lblKYCCode
        '
        Me.lblKYCCode.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblKYCCode.Name = "lblKYCCode"
        Me.lblKYCCode.Width = 363
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Client Type: "
        Me.InputLabel4.Width = 75
        '
        'cmbClientType
        '
        Me.cmbClientType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbClientType.Name = "cmbClientType"
        Me.cmbClientType.Width = 200
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
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Keyword: "
        Me.InputLabel1.Width = 75
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 424
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ToolTipText = "Search client with codeset"
        '
        'fgKYC
        '
        Me.fgKYC.AutoResize = True
        Me.fgKYC.ColumnInfo = "7,0,0,0,0,95,Columns:"
        Me.fgKYC.ContextMenuStrip = Me.csMenu
        Me.fgKYC.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgKYC.Location = New System.Drawing.Point(0, 84)
        Me.fgKYC.Name = "fgKYC"
        Me.fgKYC.Rows.Count = 1
        Me.fgKYC.Rows.DefaultSize = 19
        Me.fgKYC.Size = New System.Drawing.Size(889, 332)
        Me.fgKYC.TabIndex = 6
        Me.fgKYC.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'FormAccountKYC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 416)
        Me.Controls.Add(Me.fgKYC)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAccountKYC"
        Me.Text = "ACCOUNT MANAGEMENT: Know Your Customer"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        CType(Me.fgKYC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearchKYC As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblKYCCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgKYC As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbClientType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents lblKYCDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblKYCID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
