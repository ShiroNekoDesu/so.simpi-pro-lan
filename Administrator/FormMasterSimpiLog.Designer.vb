<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterSimpiLog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterSimpiLog))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLogID = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTerminal = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLogDate = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAppsDate = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAppsID = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtApplication = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtUserID = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtUserLogin = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSimpiID = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtSimpiName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtDescription = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtContent = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGSQL = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.csMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AttachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.csMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtLogID)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.txtTerminal)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.txtLogDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.txtAppsDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.txtAppsID)
        Me.C1InputPanel1.Items.Add(Me.txtApplication)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.txtUserID)
        Me.C1InputPanel1.Items.Add(Me.txtUserLogin)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.txtSimpiID)
        Me.C1InputPanel1.Items.Add(Me.txtSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.txtDescription)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.txtContent)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(845, 519)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "LOG DATE && USER"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "ID: "
        Me.InputLabel3.Width = 75
        '
        'txtLogID
        '
        Me.txtLogID.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtLogID.Enabled = False
        Me.txtLogID.Name = "txtLogID"
        Me.txtLogID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLogID.Width = 281
        '
        'InputLabel4
        '
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Terminal: "
        Me.InputLabel4.Width = 66
        '
        'txtTerminal
        '
        Me.txtTerminal.Enabled = False
        Me.txtTerminal.Name = "txtTerminal"
        Me.txtTerminal.Width = 400
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Date: (server)"
        Me.InputLabel2.Width = 75
        '
        'txtLogDate
        '
        Me.txtLogDate.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtLogDate.Enabled = False
        Me.txtLogDate.Name = "txtLogDate"
        Me.txtLogDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLogDate.Width = 111
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "(terminal)"
        '
        'txtAppsDate
        '
        Me.txtAppsDate.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAppsDate.Enabled = False
        Me.txtAppsDate.Name = "txtAppsDate"
        Me.txtAppsDate.Text = "99-DEC-99 99:99:99"
        Me.txtAppsDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAppsDate.Width = 111
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Application: "
        Me.InputLabel5.Width = 65
        '
        'txtAppsID
        '
        Me.txtAppsID.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAppsID.Enabled = False
        Me.txtAppsID.Name = "txtAppsID"
        Me.txtAppsID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAppsID.Width = 50
        '
        'txtApplication
        '
        Me.txtApplication.Enabled = False
        Me.txtApplication.Name = "txtApplication"
        Me.txtApplication.Width = 350
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "User: "
        Me.InputLabel6.Width = 75
        '
        'txtUserID
        '
        Me.txtUserID.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtUserID.Enabled = False
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUserID.Width = 75
        '
        'txtUserLogin
        '
        Me.txtUserLogin.Enabled = False
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Width = 680
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Master SIMPI: "
        Me.InputLabel7.Width = 75
        '
        'txtSimpiID
        '
        Me.txtSimpiID.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtSimpiID.Enabled = False
        Me.txtSimpiID.Name = "txtSimpiID"
        Me.txtSimpiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSimpiID.Width = 75
        '
        'txtSimpiName
        '
        Me.txtSimpiName.Enabled = False
        Me.txtSimpiName.Name = "txtSimpiName"
        Me.txtSimpiName.Width = 680
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "LOG CONTENT && DESCRIPTION"
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Description: "
        Me.InputLabel9.Width = 65
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Width = 760
        '
        'InputLabel8
        '
        Me.InputLabel8.Height = 100
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Content: "
        Me.InputLabel8.Width = 65
        '
        'txtContent
        '
        Me.txtContent.Enabled = False
        Me.txtContent.Height = 100
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtContent.Width = 760
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "LOG SQL"
        '
        'DBGSQL
        '
        Me.DBGSQL.BackColor = System.Drawing.Color.White
        Me.DBGSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGSQL.ContextMenuStrip = Me.csMenu
        Me.DBGSQL.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGSQL.Images.Add(CType(resources.GetObject("DBGSQL.Images"), System.Drawing.Image))
        Me.DBGSQL.Location = New System.Drawing.Point(4, 312)
        Me.DBGSQL.Name = "DBGSQL"
        Me.DBGSQL.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGSQL.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGSQL.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGSQL.PrintInfo.PageSettings = CType(resources.GetObject("DBGSQL.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGSQL.PropBag = resources.GetString("DBGSQL.PropBag")
        Me.DBGSQL.Size = New System.Drawing.Size(838, 203)
        Me.DBGSQL.TabIndex = 1
        Me.DBGSQL.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormMasterSimpiLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 519)
        Me.Controls.Add(Me.DBGSQL)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "FormMasterSimpiLog"
        Me.Text = "MASTER SIMPI: System Log"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.csMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLogID As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAppsDate As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLogDate As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAppsID As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtUserID As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtApplication As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtTerminal As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtUserLogin As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSimpiID As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtSimpiName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtDescription As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtContent As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGSQL As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents csMenu As ContextMenuStrip
    Friend WithEvents AttachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
