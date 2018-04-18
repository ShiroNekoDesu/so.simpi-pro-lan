<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimpiUserProfileMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSimpiUserProfileMenu))
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblIDUser = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLoginUser = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatusUser = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAppsID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAppsCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAppsName = New C1.Win.C1InputPanel.InputLabel()
        Me.DBGMenu = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.InputLabel3)
        Me.c1InputPanel7.Items.Add(Me.inputLabel35)
        Me.c1InputPanel7.Items.Add(Me.InputLabel4)
        Me.c1InputPanel7.Items.Add(Me.lblIDUser)
        Me.c1InputPanel7.Items.Add(Me.lblLoginUser)
        Me.c1InputPanel7.Items.Add(Me.lblStatusUser)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader1)
        Me.c1InputPanel7.Items.Add(Me.InputLabel2)
        Me.c1InputPanel7.Items.Add(Me.lblAppsID)
        Me.c1InputPanel7.Items.Add(Me.lblAppsCode)
        Me.c1InputPanel7.Items.Add(Me.lblAppsName)
        Me.c1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel7.Name = "c1InputPanel7"
        Me.c1InputPanel7.Size = New System.Drawing.Size(588, 101)
        Me.c1InputPanel7.TabIndex = 12
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "ID"
        Me.InputLabel3.Width = 50
        '
        'inputLabel35
        '
        Me.inputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel35.Name = "inputLabel35"
        Me.inputLabel35.Text = "USER LOGIN"
        Me.inputLabel35.Width = 449
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "STATUS"
        '
        'lblIDUser
        '
        Me.lblIDUser.Name = "lblIDUser"
        Me.lblIDUser.Width = 50
        '
        'lblLoginUser
        '
        Me.lblLoginUser.Name = "lblLoginUser"
        Me.lblLoginUser.Width = 449
        '
        'lblStatusUser
        '
        Me.lblStatusUser.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblStatusUser.Name = "lblStatusUser"
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "AVAILABLE SYSTEM MENU"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "SYSTEM APPLICATION"
        '
        'lblAppsID
        '
        Me.lblAppsID.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblAppsID.Name = "lblAppsID"
        Me.lblAppsID.Width = 75
        '
        'lblAppsCode
        '
        Me.lblAppsCode.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAppsCode.Name = "lblAppsCode"
        Me.lblAppsCode.Width = 350
        '
        'lblAppsName
        '
        Me.lblAppsName.Name = "lblAppsName"
        Me.lblAppsName.Width = 570
        '
        'DBGMenu
        '
        Me.DBGMenu.BackColor = System.Drawing.Color.White
        Me.DBGMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGMenu.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGMenu.Images.Add(CType(resources.GetObject("DBGMenu.Images"), System.Drawing.Image))
        Me.DBGMenu.Location = New System.Drawing.Point(0, 101)
        Me.DBGMenu.Name = "DBGMenu"
        Me.DBGMenu.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGMenu.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGMenu.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGMenu.PrintInfo.PageSettings = CType(resources.GetObject("DBGMenu.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGMenu.RecordSelectors = False
        Me.DBGMenu.Size = New System.Drawing.Size(588, 235)
        Me.DBGMenu.TabIndex = 13
        Me.DBGMenu.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.DBGMenu.PropBag = resources.GetString("DBGMenu.PropBag")
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.btnAdd)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 336)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(588, 42)
        Me.C1InputPanel1.TabIndex = 25
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Height = 35
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'FormSimpiUserProfileMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 378)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.DBGMenu)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSimpiUserProfileMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPI USER: Add Menu"
        Me.TopMost = True
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblIDUser As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLoginUser As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblStatusUser As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAppsID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAppsCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAppsName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGMenu As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
End Class
