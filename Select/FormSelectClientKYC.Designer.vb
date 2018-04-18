<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectClientKYC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectClientKYC))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientType = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.DBGKYC = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        CType(Me.DBGKYC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.ContextMenuStrip = Me.csMenu
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblClientType)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtKeyword)
        Me.C1InputPanel1.Items.Add(Me.rbNone)
        Me.C1InputPanel1.Items.Add(Me.rbAnd)
        Me.C1InputPanel1.Items.Add(Me.rbOr)
        Me.C1InputPanel1.Items.Add(Me.rbCombine)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.btnSelect)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(661, 47)
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
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Client Type"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Keyword, that simillar with code or description: "
        '
        'lblClientType
        '
        Me.lblClientType.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblClientType.Name = "lblClientType"
        Me.lblClientType.Width = 176
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 148
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'btnSelect
        '
        Me.btnSelect.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Name = "btnSelect"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        '
        'DBGKYC
        '
        Me.DBGKYC.BackColor = System.Drawing.Color.White
        Me.DBGKYC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGKYC.ContextMenuStrip = Me.csMenu
        Me.DBGKYC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGKYC.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGKYC.Images.Add(CType(resources.GetObject("DBGKYC.Images"), System.Drawing.Image))
        Me.DBGKYC.Location = New System.Drawing.Point(0, 47)
        Me.DBGKYC.Name = "DBGKYC"
        Me.DBGKYC.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGKYC.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGKYC.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGKYC.PrintInfo.PageSettings = CType(resources.GetObject("DBGKYC.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGKYC.PropBag = resources.GetString("DBGKYC.PropBag")
        Me.DBGKYC.RecordSelectors = False
        Me.DBGKYC.Size = New System.Drawing.Size(661, 461)
        Me.DBGKYC.TabIndex = 120
        Me.DBGKYC.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormSelectClientKYC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 508)
        Me.Controls.Add(Me.DBGKYC)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectClientKYC"
        Me.Text = "SELECT CLIENT KYC FIELD"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        CType(Me.DBGKYC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGKYC As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblClientType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
