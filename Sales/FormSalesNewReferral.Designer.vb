<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalesNewReferral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesNewReferral))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lbl = New C1.Win.C1InputPanel.InputLabel()
        Me.lblHeadCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblHeadName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesLevel = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserLogin = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTaxID = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtEmail = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPhone = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLicenseNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtLicenseExpired = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLicenseIssuer = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNumberTeam = New C1.Win.C1InputPanel.InputLabel()
        Me.DBGTeam = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPrefix = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNumberStart = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtNumberLength = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSample = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.lbl)
        Me.C1InputPanel1.Items.Add(Me.lblHeadCode)
        Me.C1InputPanel1.Items.Add(Me.lblHeadName)
        Me.C1InputPanel1.Items.Add(Me.lblSalesLevel)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.lblUserName)
        Me.C1InputPanel1.Items.Add(Me.lblUserLogin)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.txtAddress)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.txtTaxID)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.txtEmail)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.txtPhone)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.txtLicenseNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.dtLicenseExpired)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.txtLicenseIssuer)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Items.Add(Me.InputLabel14)
        Me.C1InputPanel1.Items.Add(Me.lblNumberTeam)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(648, 257)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "SALES HEAD"
        Me.InputLabel1.Width = 555
        '
        'lbl
        '
        Me.lbl.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Name = "lbl"
        Me.lbl.Text = "LEVEL"
        '
        'lblHeadCode
        '
        Me.lblHeadCode.Name = "lblHeadCode"
        Me.lblHeadCode.Width = 150
        '
        'lblHeadName
        '
        Me.lblHeadName.Name = "lblHeadName"
        Me.lblHeadName.Width = 400
        '
        'lblSalesLevel
        '
        Me.lblSalesLevel.Name = "lblSalesLevel"
        Me.lblSalesLevel.Width = 35
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "SALES REFERRAL"
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Master Simpi: "
        Me.InputLabel6.Width = 80
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 512
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "REFERRAL HEAD"
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Name: "
        Me.InputLabel9.Width = 70
        '
        'lblUserName
        '
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Width = 554
        '
        'lblUserLogin
        '
        Me.lblUserLogin.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblUserLogin.Width = 1
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Address: "
        Me.InputLabel5.Width = 70
        '
        'txtAddress
        '
        Me.txtAddress.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Width = 355
        '
        'InputLabel10
        '
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "TaxID: "
        Me.InputLabel10.Width = 45
        '
        'txtTaxID
        '
        Me.txtTaxID.Name = "txtTaxID"
        Me.txtTaxID.ReadOnly = True
        Me.txtTaxID.Width = 150
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Email: "
        Me.InputLabel8.Width = 70
        '
        'txtEmail
        '
        Me.txtEmail.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Width = 355
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Phone: "
        Me.InputLabel7.Width = 45
        '
        'txtPhone
        '
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Width = 150
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "License No: "
        Me.InputLabel11.Width = 70
        '
        'txtLicenseNo
        '
        Me.txtLicenseNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtLicenseNo.Name = "txtLicenseNo"
        Me.txtLicenseNo.ReadOnly = True
        Me.txtLicenseNo.Width = 197
        '
        'InputLabel12
        '
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Expired: "
        '
        'dtLicenseExpired
        '
        Me.dtLicenseExpired.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtLicenseExpired.Name = "dtLicenseExpired"
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Issuer: "
        Me.InputLabel13.Width = 45
        '
        'txtLicenseIssuer
        '
        Me.txtLicenseIssuer.Name = "txtLicenseIssuer"
        Me.txtLicenseIssuer.ReadOnly = True
        Me.txtLicenseIssuer.Width = 150
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "REFERRAL TEAM"
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Number of sales: "
        '
        'lblNumberTeam
        '
        Me.lblNumberTeam.Name = "lblNumberTeam"
        Me.lblNumberTeam.Width = 50
        '
        'DBGTeam
        '
        Me.DBGTeam.BackColor = System.Drawing.Color.White
        Me.DBGTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGTeam.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGTeam.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTeam.Images.Add(CType(resources.GetObject("DBGTeam.Images"), System.Drawing.Image))
        Me.DBGTeam.Location = New System.Drawing.Point(0, 257)
        Me.DBGTeam.Name = "DBGTeam"
        Me.DBGTeam.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTeam.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTeam.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTeam.PrintInfo.PageSettings = CType(resources.GetObject("DBGTeam.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTeam.PropBag = resources.GetString("DBGTeam.PropBag")
        Me.DBGTeam.RecordSelectors = False
        Me.DBGTeam.Size = New System.Drawing.Size(648, 175)
        Me.DBGTeam.TabIndex = 7
        Me.DBGTeam.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.txtPrefix)
        Me.C1InputPanel2.Items.Add(Me.InputLabel3)
        Me.C1InputPanel2.Items.Add(Me.txtNumberStart)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.txtNumberLength)
        Me.C1InputPanel2.Items.Add(Me.InputLabel15)
        Me.C1InputPanel2.Items.Add(Me.lblSample)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel2.Items.Add(Me.btnSave)
        Me.C1InputPanel2.Items.Add(Me.btnCancel)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 432)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(648, 102)
        Me.C1InputPanel2.TabIndex = 8
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "SALES CODE"
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Prefix: "
        '
        'txtPrefix
        '
        Me.txtPrefix.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtPrefix.Name = "txtPrefix"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Start number: "
        '
        'txtNumberStart
        '
        Me.txtNumberStart.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNumberStart.Name = "txtNumberStart"
        Me.txtNumberStart.Text = "1"
        Me.txtNumberStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumberStart.Width = 50
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Number length: "
        '
        'txtNumberLength
        '
        Me.txtNumberLength.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtNumberLength.Name = "txtNumberLength"
        Me.txtNumberLength.Text = "3"
        Me.txtNumberLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumberLength.Width = 50
        '
        'InputLabel15
        '
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "SAMPLE: "
        Me.InputLabel15.Width = 55
        '
        'lblSample
        '
        Me.lblSample.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSample.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSample.Name = "lblSample"
        Me.lblSample.Text = "001"
        Me.lblSample.Width = 150
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 633
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
        'FormSalesNewReferral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 534)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.DBGTeam)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalesNewReferral"
        Me.Text = "SALES MAINTENANCE: New Referral Agent"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGTeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents DBGTeam As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lbl As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblHeadCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblHeadName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesLevel As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtPrefix As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNumberStart As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtNumberLength As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserLogin As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtPhone As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtEmail As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtLicenseNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents dtLicenseExpired As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents txtLicenseIssuer As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtTaxID As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNumberTeam As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSample As C1.Win.C1InputPanel.InputLabel
End Class
