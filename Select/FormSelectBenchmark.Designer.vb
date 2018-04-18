<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectBenchmark
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectBenchmark))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.DBGBenchmark = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGBenchmark, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel1.Items.Add(Me.btnSelect)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(709, 48)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Keyword: "
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 383
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
        'DBGBenchmark
        '
        Me.DBGBenchmark.BackColor = System.Drawing.Color.White
        Me.DBGBenchmark.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGBenchmark.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGBenchmark.Images.Add(CType(resources.GetObject("DBGBenchmark.Images"), System.Drawing.Image))
        Me.DBGBenchmark.Location = New System.Drawing.Point(0, 48)
        Me.DBGBenchmark.Name = "DBGBenchmark"
        Me.DBGBenchmark.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGBenchmark.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGBenchmark.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGBenchmark.PrintInfo.PageSettings = CType(resources.GetObject("DBGBenchmark.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGBenchmark.PropBag = resources.GetString("DBGBenchmark.PropBag")
        Me.DBGBenchmark.RecordSelectors = False
        Me.DBGBenchmark.Size = New System.Drawing.Size(709, 394)
        Me.DBGBenchmark.TabIndex = 5
        Me.DBGBenchmark.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormSelectBenchmark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 443)
        Me.Controls.Add(Me.DBGBenchmark)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "FormSelectBenchmark"
        Me.Text = "SELECT BENCHMARK"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGBenchmark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGBenchmark As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
