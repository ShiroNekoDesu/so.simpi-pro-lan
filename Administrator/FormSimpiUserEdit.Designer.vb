<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimpiUserEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSimpiUserEdit))
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.inputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblType = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.inputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserLogin = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUserName = New C1.Win.C1InputPanel.InputTextBox()
        Me.inputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel42 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUserTitle = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtUserInitial = New C1.Win.C1InputPanel.InputTextBox()
        Me.inputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BackColor = System.Drawing.Color.White
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.inputLabel14)
        Me.c1InputPanel7.Items.Add(Me.lblID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel1)
        Me.c1InputPanel7.Items.Add(Me.lblType)
        Me.c1InputPanel7.Items.Add(Me.inputLabel16)
        Me.c1InputPanel7.Items.Add(Me.inputLabel17)
        Me.c1InputPanel7.Items.Add(Me.lblName)
        Me.c1InputPanel7.Items.Add(Me.lblStatus)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader1)
        Me.c1InputPanel7.Items.Add(Me.inputLabel35)
        Me.c1InputPanel7.Items.Add(Me.lblUserLogin)
        Me.c1InputPanel7.Items.Add(Me.inputLabel37)
        Me.c1InputPanel7.Items.Add(Me.txtUserName)
        Me.c1InputPanel7.Items.Add(Me.inputLabel11)
        Me.c1InputPanel7.Items.Add(Me.inputLabel42)
        Me.c1InputPanel7.Items.Add(Me.txtUserTitle)
        Me.c1InputPanel7.Items.Add(Me.txtUserInitial)
        Me.c1InputPanel7.Items.Add(Me.inputSeparator1)
        Me.c1InputPanel7.Items.Add(Me.btnSave)
        Me.c1InputPanel7.Items.Add(Me.btnCancel)
        Me.c1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel7.Name = "c1InputPanel7"
        Me.c1InputPanel7.Size = New System.Drawing.Size(581, 225)
        Me.c1InputPanel7.TabIndex = 9
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'inputLabel14
        '
        Me.inputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel14.Name = "inputLabel14"
        Me.inputLabel14.Text = "ID: "
        Me.inputLabel14.Width = 50
        '
        'lblID
        '
        Me.lblID.Name = "lblID"
        Me.lblID.Width = 100
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "TYPE: "
        '
        'lblType
        '
        Me.lblType.Name = "lblType"
        Me.lblType.Width = 255
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
        'lblName
        '
        Me.lblName.Name = "lblName"
        Me.lblName.Width = 400
        '
        'lblStatus
        '
        Me.lblStatus.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Width = 75
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "EDIT DATA SIMPI USER"
        '
        'inputLabel35
        '
        Me.inputLabel35.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.inputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel35.Name = "inputLabel35"
        Me.inputLabel35.Text = "USER LOGIN"
        Me.inputLabel35.Width = 410
        '
        'lblUserLogin
        '
        Me.lblUserLogin.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Width = 560
        '
        'inputLabel37
        '
        Me.inputLabel37.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.inputLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel37.Name = "inputLabel37"
        Me.inputLabel37.Text = "NAME"
        Me.inputLabel37.Width = 65
        '
        'txtUserName
        '
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Width = 565
        '
        'inputLabel11
        '
        Me.inputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel11.Name = "inputLabel11"
        Me.inputLabel11.Text = "TITLE"
        Me.inputLabel11.Width = 410
        '
        'inputLabel42
        '
        Me.inputLabel42.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.inputLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel42.Name = "inputLabel42"
        Me.inputLabel42.Text = "INITIAL"
        Me.inputLabel42.Width = 100
        '
        'txtUserTitle
        '
        Me.txtUserTitle.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtUserTitle.Name = "txtUserTitle"
        Me.txtUserTitle.Width = 410
        '
        'txtUserInitial
        '
        Me.txtUserInitial.Name = "txtUserInitial"
        Me.txtUserInitial.Width = 150
        '
        'inputSeparator1
        '
        Me.inputSeparator1.Name = "inputSeparator1"
        Me.inputSeparator1.Width = 565
        '
        'btnSave
        '
        Me.btnSave.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSave.Height = 35
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "SAVE"
        Me.btnSave.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'FormSimpiUserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 225)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSimpiUserEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPI USER: Edit"
        Me.TopMost = True
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents inputLabel14 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblType As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel16 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel17 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblName As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents inputLabel35 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel42 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUserInitial As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents inputLabel37 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUserName As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents inputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUserTitle As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents inputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblUserLogin As C1.Win.C1InputPanel.InputLabel
End Class
