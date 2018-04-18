<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectSimpiPortfolioNormal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectSimpiPortfolioNormal))
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiType = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.Keyword = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGPortfolio = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader1)
        Me.c1InputPanel7.Items.Add(Me.InputLabel1)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel3)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiType)
        Me.c1InputPanel7.Items.Add(Me.InputLabel5)
        Me.c1InputPanel7.Items.Add(Me.InputLabel6)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiName)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiStatus)
        Me.c1InputPanel7.Items.Add(Me.InputSeparator1)
        Me.c1InputPanel7.Items.Add(Me.Keyword)
        Me.c1InputPanel7.Items.Add(Me.txtKeyword)
        Me.c1InputPanel7.Items.Add(Me.rbNone)
        Me.c1InputPanel7.Items.Add(Me.rbAnd)
        Me.c1InputPanel7.Items.Add(Me.rbOr)
        Me.c1InputPanel7.Items.Add(Me.rbCombine)
        Me.c1InputPanel7.Items.Add(Me.btnSearch)
        Me.c1InputPanel7.Items.Add(Me.btnSelect)
        Me.c1InputPanel7.Items.Add(Me.btnCancel)
        Me.c1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel7.Name = "c1InputPanel7"
        Me.c1InputPanel7.Size = New System.Drawing.Size(797, 98)
        Me.c1InputPanel7.TabIndex = 15
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "MASTER SIMPI"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "ID: "
        '
        'lblSimpiID
        '
        Me.lblSimpiID.Name = "lblSimpiID"
        Me.lblSimpiID.Width = 75
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "TYPE: "
        '
        'lblSimpiType
        '
        Me.lblSimpiType.Name = "lblSimpiType"
        Me.lblSimpiType.Width = 550
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "STATUS"
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "NAME: "
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 650
        '
        'lblSimpiStatus
        '
        Me.lblSimpiStatus.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiStatus.Name = "lblSimpiStatus"
        Me.lblSimpiStatus.Width = 75
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 779
        '
        'Keyword
        '
        Me.Keyword.Name = "Keyword"
        Me.Keyword.Text = "Keyword: "
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 411
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'DBGPortfolio
        '
        Me.DBGPortfolio.BackColor = System.Drawing.Color.White
        Me.DBGPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGPortfolio.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGPortfolio.Images.Add(CType(resources.GetObject("DBGPortfolio.Images"), System.Drawing.Image))
        Me.DBGPortfolio.Location = New System.Drawing.Point(0, 98)
        Me.DBGPortfolio.Name = "DBGPortfolio"
        Me.DBGPortfolio.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolio.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGPortfolio.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGPortfolio.PrintInfo.PageSettings = CType(resources.GetObject("DBGPortfolio.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGPortfolio.PropBag = resources.GetString("DBGPortfolio.PropBag")
        Me.DBGPortfolio.Size = New System.Drawing.Size(797, 269)
        Me.DBGPortfolio.TabIndex = 16
        Me.DBGPortfolio.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormSelectSimpiPortfolioNormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 378)
        Me.Controls.Add(Me.DBGPortfolio)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectSimpiPortfolioNormal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECT: Simpi Portfolio exclude sub portfolio, multi currency, fund umbrella, mod" &
    "el, index, simulation, fund of fund"
        Me.TopMost = True
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents Keyword As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGPortfolio As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
End Class
