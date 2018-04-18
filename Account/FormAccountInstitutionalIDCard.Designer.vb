<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountInstitutionalIDCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountInstitutionalIDCard))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblOfficerTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblOfficerName = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbIDCardType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIDCardNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel39 = New C1.Win.C1InputPanel.InputLabel()
        Me.chkIDCardIsExpired = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtIDCardIssuer = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel40 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtIDCardExpired = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel58 = New C1.Win.C1InputPanel.InputLabel()
        Me.btnIDCard = New C1.Win.C1InputPanel.InputButton()
        Me.lblIDCardFile = New C1.Win.C1InputPanel.InputLabel()
        Me.btnBrowseIDCard = New C1.Win.C1InputPanel.InputButton()
        Me.btnUploadIDCard = New C1.Win.C1InputPanel.InputButton()
        Me.btnSaveIDCard = New C1.Win.C1InputPanel.InputButton()
        Me.imgIDCard = New C1.Win.C1InputPanel.InputImage()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblCode)
        Me.C1InputPanel1.Items.Add(Me.lblName)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.lblOfficerTitle)
        Me.C1InputPanel1.Items.Add(Me.lblOfficerName)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(680, 103)
        Me.C1InputPanel1.TabIndex = 3
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Institutional Officer"
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "CIF"
        Me.InputLabel9.Width = 120
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "INSTITUTIONAL"
        Me.InputLabel2.Width = 500
        '
        'lblCode
        '
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Width = 120
        '
        'lblName
        '
        Me.lblName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblName.Name = "lblName"
        Me.lblName.Width = 533
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 656
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "TITLE"
        Me.InputLabel4.Width = 120
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "OFFICER"
        '
        'lblOfficerTitle
        '
        Me.lblOfficerTitle.Name = "lblOfficerTitle"
        Me.lblOfficerTitle.Width = 120
        '
        'lblOfficerName
        '
        Me.lblOfficerName.Name = "lblOfficerName"
        Me.lblOfficerName.Width = 532
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BackColor = System.Drawing.Color.White
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel5.Items.Add(Me.InputLabel36)
        Me.C1InputPanel5.Items.Add(Me.cmbIDCardType)
        Me.C1InputPanel5.Items.Add(Me.InputLabel38)
        Me.C1InputPanel5.Items.Add(Me.txtIDCardNo)
        Me.C1InputPanel5.Items.Add(Me.InputLabel39)
        Me.C1InputPanel5.Items.Add(Me.chkIDCardIsExpired)
        Me.C1InputPanel5.Items.Add(Me.InputLabel37)
        Me.C1InputPanel5.Items.Add(Me.txtIDCardIssuer)
        Me.C1InputPanel5.Items.Add(Me.InputLabel40)
        Me.C1InputPanel5.Items.Add(Me.dtIDCardExpired)
        Me.C1InputPanel5.Items.Add(Me.InputLabel58)
        Me.C1InputPanel5.Items.Add(Me.btnIDCard)
        Me.C1InputPanel5.Items.Add(Me.lblIDCardFile)
        Me.C1InputPanel5.Items.Add(Me.btnBrowseIDCard)
        Me.C1InputPanel5.Items.Add(Me.btnUploadIDCard)
        Me.C1InputPanel5.Items.Add(Me.btnSaveIDCard)
        Me.C1InputPanel5.Items.Add(Me.imgIDCard)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 103)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(680, 364)
        Me.C1InputPanel5.TabIndex = 4
        Me.C1InputPanel5.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "ID Card"
        '
        'InputLabel36
        '
        Me.InputLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Text = "Type: "
        Me.InputLabel36.Width = 60
        '
        'cmbIDCardType
        '
        Me.cmbIDCardType.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbIDCardType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbIDCardType.Name = "cmbIDCardType"
        Me.cmbIDCardType.Width = 120
        '
        'InputLabel38
        '
        Me.InputLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel38.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Text = "No: "
        Me.InputLabel38.Width = 40
        '
        'txtIDCardNo
        '
        Me.txtIDCardNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtIDCardNo.Name = "txtIDCardNo"
        Me.txtIDCardNo.Width = 248
        '
        'InputLabel39
        '
        Me.InputLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel39.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel39.Name = "InputLabel39"
        Me.InputLabel39.Text = "IsExpired: "
        Me.InputLabel39.Width = 75
        '
        'chkIDCardIsExpired
        '
        Me.chkIDCardIsExpired.Name = "chkIDCardIsExpired"
        Me.chkIDCardIsExpired.Text = "Y"
        '
        'InputLabel37
        '
        Me.InputLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel37.Name = "InputLabel37"
        Me.InputLabel37.Text = "Issuer: "
        Me.InputLabel37.Width = 60
        '
        'txtIDCardIssuer
        '
        Me.txtIDCardIssuer.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtIDCardIssuer.Name = "txtIDCardIssuer"
        Me.txtIDCardIssuer.Width = 416
        '
        'InputLabel40
        '
        Me.InputLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel40.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel40.Name = "InputLabel40"
        Me.InputLabel40.Text = "Expired: "
        Me.InputLabel40.Width = 75
        '
        'dtIDCardExpired
        '
        Me.dtIDCardExpired.Name = "dtIDCardExpired"
        '
        'InputLabel58
        '
        Me.InputLabel58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel58.Name = "InputLabel58"
        Me.InputLabel58.Text = "Filename: "
        Me.InputLabel58.Width = 60
        '
        'btnIDCard
        '
        Me.btnIDCard.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnIDCard.Image = CType(resources.GetObject("btnIDCard.Image"), System.Drawing.Image)
        Me.btnIDCard.Name = "btnIDCard"
        '
        'lblIDCardFile
        '
        Me.lblIDCardFile.Name = "lblIDCardFile"
        Me.lblIDCardFile.Text = "Label"
        Me.lblIDCardFile.Width = 486
        '
        'btnBrowseIDCard
        '
        Me.btnBrowseIDCard.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnBrowseIDCard.Image = CType(resources.GetObject("btnBrowseIDCard.Image"), System.Drawing.Image)
        Me.btnBrowseIDCard.Name = "btnBrowseIDCard"
        '
        'btnUploadIDCard
        '
        Me.btnUploadIDCard.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnUploadIDCard.Image = CType(resources.GetObject("btnUploadIDCard.Image"), System.Drawing.Image)
        Me.btnUploadIDCard.Name = "btnUploadIDCard"
        '
        'btnSaveIDCard
        '
        Me.btnSaveIDCard.Image = CType(resources.GetObject("btnSaveIDCard.Image"), System.Drawing.Image)
        Me.btnSaveIDCard.Name = "btnSaveIDCard"
        '
        'imgIDCard
        '
        Me.imgIDCard.Height = 257
        Me.imgIDCard.Image = CType(resources.GetObject("imgIDCard.Image"), System.Drawing.Image)
        Me.imgIDCard.ImageAlign = C1.Win.C1InputPanel.InputImageAlignment.MiddleCenter
        Me.imgIDCard.Name = "imgIDCard"
        Me.imgIDCard.Width = 664
        '
        'FormAccountInstitutionalIDCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 467)
        Me.Controls.Add(Me.C1InputPanel5)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAccountInstitutionalIDCard"
        Me.Text = "ACCOUNT MANAGEMENT: Institutional Account ID Card"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblOfficerName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblOfficerTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbIDCardType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIDCardNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel39 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents chkIDCardIsExpired As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputLabel37 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtIDCardIssuer As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel40 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtIDCardExpired As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel58 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnIDCard As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblIDCardFile As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnBrowseIDCard As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnUploadIDCard As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnSaveIDCard As C1.Win.C1InputPanel.InputButton
    Friend WithEvents imgIDCard As C1.Win.C1InputPanel.InputImage
End Class
