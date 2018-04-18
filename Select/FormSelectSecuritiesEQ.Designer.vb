<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectSecuritiesEQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectSecuritiesEQ))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbCountry = New C1.Win.C1InputPanel.InputComboBox()
        Me.cmbSubType = New C1.Win.C1InputPanel.InputComboBox()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGInstrument = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        CType(Me.DBGInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.ContextMenuStrip = Me.csMenu
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.cmbCountry)
        Me.C1InputPanel1.Items.Add(Me.cmbSubType)
        Me.C1InputPanel1.Items.Add(Me.txtKeyword)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(965, 47)
        Me.C1InputPanel1.TabIndex = 119
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'csMenu
        '
        Me.csMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.csMenu.Name = "csMenu"
        Me.csMenu.Size = New System.Drawing.Size(112, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem1.Text = "Detach"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem2.Text = "Close"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Country"
        Me.InputLabel1.Width = 150
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Sub Type: "
        Me.InputLabel2.Width = 100
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Keyword, that simillar with securities code or name"
        Me.InputLabel3.Width = 576
        '
        'cmbCountry
        '
        Me.cmbCountry.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbCountry.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Width = 150
        '
        'cmbSubType
        '
        Me.cmbSubType.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbSubType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbSubType.Name = "cmbSubType"
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 581
        '
        'btnSearch
        '
        Me.btnSearch.Height = 40
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.Width = 100
        '
        'DBGInstrument
        '
        Me.DBGInstrument.BackColor = System.Drawing.Color.White
        Me.DBGInstrument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGInstrument.ContextMenuStrip = Me.csMenu
        Me.DBGInstrument.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGInstrument.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGInstrument.Images.Add(CType(resources.GetObject("DBGInstrument.Images"), System.Drawing.Image))
        Me.DBGInstrument.Location = New System.Drawing.Point(0, 47)
        Me.DBGInstrument.Name = "DBGInstrument"
        Me.DBGInstrument.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGInstrument.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGInstrument.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGInstrument.PrintInfo.PageSettings = CType(resources.GetObject("DBGInstrument.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGInstrument.RecordSelectors = False
        Me.DBGInstrument.RowHeight = 35
        Me.DBGInstrument.Size = New System.Drawing.Size(965, 345)
        Me.DBGInstrument.TabIndex = 120
        Me.DBGInstrument.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.DBGInstrument.PropBag = resources.GetString("DBGInstrument.PropBag")
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.ContextMenuStrip = Me.csMenu
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.btnSelect)
        Me.C1InputPanel2.Items.Add(Me.btnCancel)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 392)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(965, 42)
        Me.C1InputPanel2.TabIndex = 121
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'btnSelect
        '
        Me.btnSelect.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSelect.Height = 35
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'FormSelectSecuritiesEQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 434)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.DBGInstrument)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectSecuritiesEQ"
        Me.Text = "SELECT: Market Instrument Equities"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        CType(Me.DBGInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbSubType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGInstrument As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbCountry As C1.Win.C1InputPanel.InputComboBox
End Class
