<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterSimpiTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterSimpiTicket))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserID = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserLogin = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTicketID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTicketDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTicketType = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTicketStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTicketDescription = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescription = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbStatus = New C1.Win.C1InputPanel.InputComboBox()
        Me.cmdSubmit = New C1.Win.C1InputPanel.InputButton()
        Me.cmbCancel = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGFollowUp = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGFollowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel16)
        Me.C1InputPanel1.Items.Add(Me.lblUserID)
        Me.C1InputPanel1.Items.Add(Me.lblUserName)
        Me.C1InputPanel1.Items.Add(Me.lblUserLogin)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.lblTicketID)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblTicketDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblTicketType)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.lblTicketStatus)
        Me.C1InputPanel1.Items.Add(Me.lblTicketDescription)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.txtDescription)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.cmbStatus)
        Me.C1InputPanel1.Items.Add(Me.cmdSubmit)
        Me.C1InputPanel1.Items.Add(Me.cmbCancel)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(731, 262)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "TICKET PROFILE"
        '
        'InputLabel16
        '
        Me.InputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "SIMPI USER: "
        Me.InputLabel16.Width = 100
        '
        'lblUserID
        '
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Text = "12345"
        Me.lblUserID.Width = 65
        '
        'lblUserName
        '
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Text = "Label"
        Me.lblUserName.Width = 271
        '
        'lblUserLogin
        '
        Me.lblUserLogin.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Text = "Label"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "ID: "
        '
        'lblTicketID
        '
        Me.lblTicketID.Name = "lblTicketID"
        Me.lblTicketID.Text = "123456789"
        Me.lblTicketID.Width = 250
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "DATE: "
        '
        'lblTicketDate
        '
        Me.lblTicketDate.Name = "lblTicketDate"
        Me.lblTicketDate.Text = "22-May-2016"
        Me.lblTicketDate.Width = 100
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "TYPE: "
        Me.InputLabel3.Width = 149
        '
        'lblTicketType
        '
        Me.lblTicketType.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTicketType.Name = "lblTicketType"
        Me.lblTicketType.Text = "SIMPI SUPPORT"
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "DESCRIPTION"
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "STATUS: "
        Me.InputLabel4.Width = 490
        '
        'lblTicketStatus
        '
        Me.lblTicketStatus.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTicketStatus.Name = "lblTicketStatus"
        Me.lblTicketStatus.Text = "FOLLOW UP"
        '
        'lblTicketDescription
        '
        Me.lblTicketDescription.Height = 50
        Me.lblTicketDescription.Name = "lblTicketDescription"
        Me.lblTicketDescription.Text = "Label"
        Me.lblTicketDescription.Width = 713
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "NEW FOLLOW UP"
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtDescription.Height = 60
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtDescription.Width = 501
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Width = 201
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmdSubmit.Height = 35
        Me.cmdSubmit.Image = CType(resources.GetObject("cmdSubmit.Image"), System.Drawing.Image)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Text = "SUBMIT"
        Me.cmdSubmit.Width = 100
        '
        'cmbCancel
        '
        Me.cmbCancel.Height = 35
        Me.cmbCancel.Image = CType(resources.GetObject("cmbCancel.Image"), System.Drawing.Image)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Text = "CANCEL"
        Me.cmbCancel.Width = 100
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "FOLLOW UP HISTORY"
        '
        'DBGFollowUp
        '
        Me.DBGFollowUp.BackColor = System.Drawing.Color.White
        Me.DBGFollowUp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGFollowUp.ContextMenuStrip = Me.csMenu
        Me.DBGFollowUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGFollowUp.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGFollowUp.Images.Add(CType(resources.GetObject("DBGFollowUp.Images"), System.Drawing.Image))
        Me.DBGFollowUp.Location = New System.Drawing.Point(0, 262)
        Me.DBGFollowUp.Name = "DBGFollowUp"
        Me.DBGFollowUp.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGFollowUp.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGFollowUp.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGFollowUp.PrintInfo.PageSettings = CType(resources.GetObject("DBGFollowUp.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGFollowUp.PropBag = resources.GetString("DBGFollowUp.PropBag")
        Me.DBGFollowUp.RecordSelectors = False
        Me.DBGFollowUp.Size = New System.Drawing.Size(731, 276)
        Me.DBGFollowUp.TabIndex = 7
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
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'FormMasterSimpiTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 537)
        Me.Controls.Add(Me.DBGFollowUp)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "FormMasterSimpiTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER SIMPI: Ticket FollowUp"
        Me.TopMost = True
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGFollowUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents DBGFollowUp As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescription As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbStatus As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents cmdSubmit As C1.Win.C1InputPanel.InputButton
    Friend WithEvents cmbCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblTicketID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTicketDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTicketType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTicketStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTicketDescription As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserLogin As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
