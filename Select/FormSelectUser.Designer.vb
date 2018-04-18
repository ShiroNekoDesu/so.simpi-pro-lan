<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectUser))
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.inputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiType = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.Keyword = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.DBGUser = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.inputLabel14)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel1)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiType)
        Me.c1InputPanel7.Items.Add(Me.inputLabel16)
        Me.c1InputPanel7.Items.Add(Me.inputLabel17)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiName)
        Me.c1InputPanel7.Items.Add(Me.lblSimpiStatus)
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
        Me.c1InputPanel7.Size = New System.Drawing.Size(784, 91)
        Me.c1InputPanel7.TabIndex = 17
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'inputLabel14
        '
        Me.inputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel14.Name = "inputLabel14"
        Me.inputLabel14.Text = "ID: "
        Me.inputLabel14.Width = 50
        '
        'lblSimpiID
        '
        Me.lblSimpiID.Name = "lblSimpiID"
        Me.lblSimpiID.Text = "123"
        Me.lblSimpiID.Width = 100
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "TYPE: "
        '
        'lblSimpiType
        '
        Me.lblSimpiType.Name = "lblSimpiType"
        Me.lblSimpiType.Text = "Fund Manager"
        Me.lblSimpiType.Width = 479
        '
        'inputLabel16
        '
        Me.inputLabel16.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.inputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.inputLabel16.Name = "inputLabel16"
        Me.inputLabel16.Text = "STATUS"
        Me.inputLabel16.Width = 75
        '
        'inputLabel17
        '
        Me.inputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel17.Name = "inputLabel17"
        Me.inputLabel17.Text = "NAME: "
        Me.inputLabel17.Width = 50
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Text = "PT BJ Manunggal Perkasa"
        Me.lblSimpiName.Width = 628
        '
        'lblSimpiStatus
        '
        Me.lblSimpiStatus.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.lblSimpiStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpiStatus.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSimpiStatus.Name = "lblSimpiStatus"
        Me.lblSimpiStatus.Text = "ACTIVE"
        Me.lblSimpiStatus.Width = 75
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "SEARCH SIMPI USER"
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
        Me.txtKeyword.Width = 398
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
        'DBGUser
        '
        Me.DBGUser.BackColor = System.Drawing.Color.White
        Me.DBGUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGUser.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGUser.Images.Add(CType(resources.GetObject("DBGUser.Images"), System.Drawing.Image))
        Me.DBGUser.Location = New System.Drawing.Point(0, 91)
        Me.DBGUser.Name = "DBGUser"
        Me.DBGUser.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGUser.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGUser.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGUser.PrintInfo.PageSettings = CType(resources.GetObject("DBGUser.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGUser.PropBag = resources.GetString("DBGUser.PropBag")
        Me.DBGUser.Size = New System.Drawing.Size(784, 270)
        Me.DBGUser.TabIndex = 18
        Me.DBGUser.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormSelectUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.DBGUser)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectUser"
        Me.Text = "SELECT SIMPI USER"
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents inputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiType As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel16 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents Keyword As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGUser As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
