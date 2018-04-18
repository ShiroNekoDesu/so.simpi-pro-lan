<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalesNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesNew))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblHeadCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblHeadName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesLevel = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.lblUserLogin = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUserName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtSalesCode = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtTaxID = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtPhone = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtEmail = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLicenseNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtExpired = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtLicenseIssuer = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.White
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblHeadCode)
        Me.C1InputPanel1.Items.Add(Me.lblHeadName)
        Me.C1InputPanel1.Items.Add(Me.lblSalesLevel)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.lblUserLogin)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblUserName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.txtSalesCode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.txtTaxID)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.txtAddress)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.txtPhone)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.txtEmail)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtLicenseNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.dtExpired)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.txtLicenseIssuer)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.btnSave)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(618, 290)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel12
        '
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "SALES HEAD"
        Me.InputLabel12.Width = 555
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "LEVEL"
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
        Me.lblSalesLevel.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSalesLevel.Name = "lblSalesLevel"
        Me.lblSalesLevel.Width = 35
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "SIMPI USER"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "User login: "
        Me.InputLabel1.Width = 65
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'lblUserLogin
        '
        Me.lblUserLogin.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUserLogin.Name = "lblUserLogin"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Height = 20
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "User name: "
        Me.InputLabel2.Width = 65
        '
        'lblUserName
        '
        Me.lblUserName.Height = 20
        Me.lblUserName.Name = "lblUserName"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "SALES PROFILE"
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Sales Code"
        Me.InputLabel4.Width = 65
        '
        'txtSalesCode
        '
        Me.txtSalesCode.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtSalesCode.Name = "txtSalesCode"
        Me.txtSalesCode.Width = 149
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "TaxID: "
        Me.InputLabel11.Width = 197
        '
        'txtTaxID
        '
        Me.txtTaxID.Name = "txtTaxID"
        Me.txtTaxID.Width = 175
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Address: "
        Me.InputLabel5.Width = 65
        '
        'txtAddress
        '
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtAddress.Width = 530
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Phone: "
        Me.InputLabel6.Width = 65
        '
        'txtPhone
        '
        Me.txtPhone.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Width = 150
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Email: "
        Me.InputLabel7.Width = 45
        '
        'txtEmail
        '
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Width = 327
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "License No"
        Me.InputLabel3.Width = 65
        '
        'txtLicenseNo
        '
        Me.txtLicenseNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtLicenseNo.Name = "txtLicenseNo"
        Me.txtLicenseNo.Width = 150
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Expired"
        Me.InputLabel8.Width = 45
        '
        'dtExpired
        '
        Me.dtExpired.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtExpired.Name = "dtExpired"
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Issuer: "
        '
        'txtLicenseIssuer
        '
        Me.txtLicenseIssuer.Name = "txtLicenseIssuer"
        Me.txtLicenseIssuer.Width = 175
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 595
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
        'FormSalesNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 290)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSalesNew"
        Me.Text = "SALES MAINTENANCE: New Sales Agent"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUserName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtSalesCode As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtPhone As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtEmail As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLicenseNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtExpired As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtLicenseIssuer As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblUserLogin As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtTaxID As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblHeadCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblHeadName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesLevel As C1.Win.C1InputPanel.InputLabel
End Class
