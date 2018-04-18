<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReferralProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReferralProfile))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblReferralCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblReferralName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTaxID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAddress = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPhone = New C1.Win.C1InputPanel.InputLabel()
        Me.lblEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.btnEdit = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.lblReferralCode)
        Me.C1InputPanel1.Items.Add(Me.lblReferralName)
        Me.C1InputPanel1.Items.Add(Me.lblStatus)
        Me.C1InputPanel1.Items.Add(Me.lblTaxID)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.lblAddress)
        Me.C1InputPanel1.Items.Add(Me.lblPhone)
        Me.C1InputPanel1.Items.Add(Me.lblEmail)
        Me.C1InputPanel1.Items.Add(Me.btnEdit)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(793, 110)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "MASTER SIMPI"
        Me.InputLabel1.Width = 350
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 350
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 772
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "CODE"
        Me.InputLabel2.Width = 100
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "NAME"
        Me.InputLabel3.Width = 365
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "STATUS"
        Me.InputLabel4.Width = 60
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "TAXID"
        Me.InputLabel8.Width = 90
        '
        'lblReferralCode
        '
        Me.lblReferralCode.Name = "lblReferralCode"
        Me.lblReferralCode.Width = 100
        '
        'lblReferralName
        '
        Me.lblReferralName.Name = "lblReferralName"
        Me.lblReferralName.Width = 365
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Width = 60
        '
        'lblTaxID
        '
        Me.lblTaxID.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblTaxID.Name = "lblTaxID"
        Me.lblTaxID.Width = 90
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "CORRESPONDENCE ADDRESS"
        Me.InputLabel5.Width = 436
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "PHONE"
        Me.InputLabel6.Width = 150
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "EMAIL"
        '
        'lblAddress
        '
        Me.lblAddress.Height = 30
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Width = 436
        '
        'lblPhone
        '
        Me.lblPhone.Height = 30
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Width = 150
        '
        'lblEmail
        '
        Me.lblEmail.Height = 30
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Width = 157
        '
        'btnEdit
        '
        Me.btnEdit.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ToolTipText = "Edit sales agent"
        '
        'FormReferralProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 110)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReferralProfile"
        Me.Text = "REFERRAL MAINTENANCE: Sales Referral"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblReferralCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblReferralName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTaxID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAddress As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPhone As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnEdit As C1.Win.C1InputPanel.InputButton
End Class
