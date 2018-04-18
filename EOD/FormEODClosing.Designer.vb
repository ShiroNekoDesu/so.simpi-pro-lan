<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEODClosing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODClosing))
        Me.DBGPortfolio = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.chkAll = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtNext = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnGenerate = New C1.Win.C1InputPanel.InputButton()
        Me.btnReverse = New C1.Win.C1InputPanel.InputButton()
        Me.btnProfile = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbCcy = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtValuation = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBGPortfolio
        '
        Me.DBGPortfolio.BackColor = System.Drawing.Color.White
        Me.DBGPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.DBGPortfolio.RecordSelectors = False
        Me.DBGPortfolio.Size = New System.Drawing.Size(784, 410)
        Me.DBGPortfolio.TabIndex = 0
        Me.DBGPortfolio.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.chkAll)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtNext)
        Me.C1InputPanel1.Items.Add(Me.btnGenerate)
        Me.C1InputPanel1.Items.Add(Me.btnReverse)
        Me.C1InputPanel1.Items.Add(Me.btnProfile)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 460)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(784, 42)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'chkAll
        '
        Me.chkAll.Break = C1.Win.C1InputPanel.BreakType.None
        Me.chkAll.Enabled = False
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Text = "Select All"
        Me.chkAll.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.chkAll.Width = 100
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Next: "
        '
        'dtNext
        '
        Me.dtNext.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtNext.Enabled = False
        Me.dtNext.Name = "dtNext"
        '
        'btnGenerate
        '
        Me.btnGenerate.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Height = 35
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.Width = 100
        '
        'btnReverse
        '
        Me.btnReverse.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnReverse.Enabled = False
        Me.btnReverse.Height = 35
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Text = "REVERSE"
        Me.btnReverse.Width = 100
        '
        'btnProfile
        '
        Me.btnProfile.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnProfile.Height = 35
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Text = "PROFILE"
        Me.btnProfile.Width = 100
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.cmbCcy)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.dtValuation)
        Me.C1InputPanel2.Items.Add(Me.InputLabel3)
        Me.C1InputPanel2.Items.Add(Me.txtKeyword)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(784, 50)
        Me.C1InputPanel2.TabIndex = 2
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Currency: "
        '
        'cmbCcy
        '
        Me.cmbCcy.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbCcy.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbCcy.Name = "cmbCcy"
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Current Valuation: "
        '
        'dtValuation
        '
        Me.dtValuation.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.dtValuation.Name = "dtValuation"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Keyword, that simillar with portfolio code or name: "
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 517
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'FormEODClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.DBGPortfolio)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Name = "FormEODClosing"
        Me.Text = "END OF DAY: Closing Portfolio NAV"
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DBGPortfolio As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents chkAll As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents btnGenerate As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnReverse As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnProfile As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtNext As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtValuation As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbCcy As C1.Win.C1InputPanel.InputComboBox
End Class
