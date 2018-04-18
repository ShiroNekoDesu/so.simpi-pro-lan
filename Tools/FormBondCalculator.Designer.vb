<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBondCalculator
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
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtSettlement = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtMaturity = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtCoupon = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtFrequency = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.txtPrice = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbPrice = New C1.Win.C1InputPanel.InputRadioButton()
        Me.txtYield = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbYTM = New C1.Win.C1InputPanel.InputRadioButton()
        Me.lblPriceTitle = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPriceValue = New C1.Win.C1InputPanel.InputLabel()
        Me.btnCalculate = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDuration = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbDIM = New C1.Win.C1InputPanel.InputComboBox()
        Me.cmbDIY = New C1.Win.C1InputPanel.InputComboBox()
        Me.mA = New C1.Win.C1InputPanel.InputOption()
        Me.m30 = New C1.Win.C1InputPanel.InputOption()
        Me.m30E = New C1.Win.C1InputPanel.InputOption()
        Me.m30U = New C1.Win.C1InputPanel.InputOption()
        Me.m30ISDA = New C1.Win.C1InputPanel.InputOption()
        Me.yA = New C1.Win.C1InputPanel.InputOption()
        Me.y360 = New C1.Win.C1InputPanel.InputOption()
        Me.y365 = New C1.Win.C1InputPanel.InputOption()
        Me.y366 = New C1.Win.C1InputPanel.InputOption()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtSettlement)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.dtMaturity)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.txtCoupon)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.txtFrequency)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.cmbDIM)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.cmbDIY)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.rbPrice)
        Me.C1InputPanel1.Items.Add(Me.txtPrice)
        Me.C1InputPanel1.Items.Add(Me.rbYTM)
        Me.C1InputPanel1.Items.Add(Me.txtYield)
        Me.C1InputPanel1.Items.Add(Me.btnCalculate)
        Me.C1InputPanel1.Items.Add(Me.lblPriceTitle)
        Me.C1InputPanel1.Items.Add(Me.lblPriceValue)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblDuration)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(426, 148)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Settlement: "
        '
        'dtSettlement
        '
        Me.dtSettlement.Name = "dtSettlement"
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Maturity: "
        '
        'dtMaturity
        '
        Me.dtMaturity.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.dtMaturity.Name = "dtMaturity"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Coupon: "
        '
        'txtCoupon
        '
        Me.txtCoupon.Name = "txtCoupon"
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Frequency: "
        '
        'txtFrequency
        '
        Me.txtFrequency.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtFrequency.Name = "txtFrequency"
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Day(s) in Month: "
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Day(s) in Year: "
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 1
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        '
        'txtPrice
        '
        Me.txtPrice.Name = "txtPrice"
        '
        'rbPrice
        '
        Me.rbPrice.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbPrice.Checked = True
        Me.rbPrice.Name = "rbPrice"
        Me.rbPrice.Text = "Price"
        '
        'txtYield
        '
        Me.txtYield.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtYield.Name = "txtYield"
        Me.txtYield.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        '
        'rbYTM
        '
        Me.rbYTM.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbYTM.Name = "rbYTM"
        Me.rbYTM.Text = "YTM"
        '
        'lblPriceTitle
        '
        Me.lblPriceTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceTitle.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPriceTitle.Name = "lblPriceTitle"
        Me.lblPriceTitle.Text = "YTM: "
        Me.lblPriceTitle.Width = 55
        '
        'lblPriceValue
        '
        Me.lblPriceValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPriceValue.Name = "lblPriceValue"
        Me.lblPriceValue.Width = 65
        '
        'btnCalculate
        '
        Me.btnCalculate.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnCalculate.Height = 35
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.Width = 100
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Duration: "
        Me.InputLabel13.Width = 55
        '
        'lblDuration
        '
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Width = 65
        '
        'cmbDIM
        '
        Me.cmbDIM.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbDIM.Items.Add(Me.mA)
        Me.cmbDIM.Items.Add(Me.m30)
        Me.cmbDIM.Items.Add(Me.m30E)
        Me.cmbDIM.Items.Add(Me.m30U)
        Me.cmbDIM.Items.Add(Me.m30ISDA)
        Me.cmbDIM.Name = "cmbDIM"
        '
        'cmbDIY
        '
        Me.cmbDIY.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbDIY.Items.Add(Me.yA)
        Me.cmbDIY.Items.Add(Me.y360)
        Me.cmbDIY.Items.Add(Me.y365)
        Me.cmbDIY.Items.Add(Me.y366)
        Me.cmbDIY.Name = "cmbDIY"
        '
        'mA
        '
        Me.mA.Name = "mA"
        Me.mA.Text = "A"
        '
        'm30
        '
        Me.m30.Name = "m30"
        Me.m30.Text = "30"
        '
        'm30E
        '
        Me.m30E.Name = "m30E"
        Me.m30E.Text = "30E"
        '
        'm30U
        '
        Me.m30U.Name = "m30U"
        Me.m30U.Text = "30U"
        '
        'm30ISDA
        '
        Me.m30ISDA.Name = "m30ISDA"
        Me.m30ISDA.Text = "30ISDA"
        '
        'yA
        '
        Me.yA.Name = "yA"
        Me.yA.Text = "A"
        '
        'y360
        '
        Me.y360.Name = "y360"
        Me.y360.Text = "360"
        '
        'y365
        '
        Me.y365.Name = "y365"
        Me.y365.Text = "365"
        '
        'y366
        '
        Me.y366.Name = "y366"
        Me.y366.Text = "366"
        '
        'FormBondCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 148)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "FormBondCalculator"
        Me.Text = "BOND CALCULATOR"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtSettlement As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtMaturity As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtCoupon As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtYield As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents txtPrice As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtFrequency As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnCalculate As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPriceTitle As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPriceValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDuration As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents rbPrice As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbYTM As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents cmbDIM As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents cmbDIY As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents mA As C1.Win.C1InputPanel.InputOption
    Friend WithEvents m30 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents m30E As C1.Win.C1InputPanel.InputOption
    Friend WithEvents m30U As C1.Win.C1InputPanel.InputOption
    Friend WithEvents m30ISDA As C1.Win.C1InputPanel.InputOption
    Friend WithEvents yA As C1.Win.C1InputPanel.InputOption
    Friend WithEvents y360 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents y365 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents y366 As C1.Win.C1InputPanel.InputOption
End Class
