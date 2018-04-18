<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectBankAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectBankAccount))
        Me.DBGAccount = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.Keyword = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.DBGAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBGAccount
        '
        Me.DBGAccount.BackColor = System.Drawing.Color.White
        Me.DBGAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGAccount.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGAccount.Images.Add(CType(resources.GetObject("DBGAccount.Images"), System.Drawing.Image))
        Me.DBGAccount.Location = New System.Drawing.Point(0, 56)
        Me.DBGAccount.Name = "DBGAccount"
        Me.DBGAccount.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGAccount.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGAccount.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGAccount.PrintInfo.PageSettings = CType(resources.GetObject("DBGAccount.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGAccount.PropBag = resources.GetString("DBGAccount.PropBag")
        Me.DBGAccount.Size = New System.Drawing.Size(797, 322)
        Me.DBGAccount.TabIndex = 26
        Me.DBGAccount.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader1)
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
        Me.c1InputPanel7.Size = New System.Drawing.Size(797, 56)
        Me.c1InputPanel7.TabIndex = 25
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "AVAILABLE MASTER PORTFOLIO"
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
        Me.txtKeyword.Width = 415
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
        'rbNone
        '
        Me.rbNone.Break = C1.Win.C1InputPanel.BreakType.None
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
        'FormSelectBankAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 378)
        Me.Controls.Add(Me.DBGAccount)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectBankAccount"
        Me.Text = "SELECT: Bank Account"
        CType(Me.DBGAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DBGAccount As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents Keyword As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
