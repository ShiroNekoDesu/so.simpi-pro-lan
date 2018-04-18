<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEODOverrideDividendCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideDividendCash))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtPayment = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnLoad = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUnits = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPrice = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAV = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtRate = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDividendAmount = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel2.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel2.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel2.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.dtPayment)
        Me.C1InputPanel2.Items.Add(Me.btnLoad)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.lblNAVDate)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.lblUnits)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.lblPrice)
        Me.C1InputPanel2.Items.Add(Me.InputLabel3)
        Me.C1InputPanel2.Items.Add(Me.lblNAV)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.lblRows)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.txtRate)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.lblDividendAmount)
        Me.C1InputPanel2.Items.Add(Me.btnRun)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(981, 125)
        Me.C1InputPanel2.TabIndex = 16
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 812
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Text = "Label"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 1
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "NAV PERIOD"
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Payment Date"
        Me.InputLabel8.Width = 100
        '
        'dtPayment
        '
        Me.dtPayment.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtPayment.Name = "dtPayment"
        '
        'btnLoad
        '
        Me.btnLoad.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "NAV Date"
        Me.InputLabel5.Width = 100
        '
        'lblNAVDate
        '
        Me.lblNAVDate.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblNAVDate.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblNAVDate.Name = "lblNAVDate"
        Me.lblNAVDate.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Total Units"
        Me.InputLabel6.Width = 120
        '
        'lblUnits
        '
        Me.lblUnits.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblUnits.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Width = 120
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "NAV/Unit"
        Me.InputLabel2.Width = 100
        '
        'lblPrice
        '
        Me.lblPrice.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblPrice.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Width = 100
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "NAV"
        Me.InputLabel3.Width = 120
        '
        'lblNAV
        '
        Me.lblNAV.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblNAV.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblNAV.Name = "lblNAV"
        Me.lblNAV.Width = 120
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Acc#"
        Me.InputLabel1.Width = 50
        '
        'lblRows
        '
        Me.lblRows.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblRows.ForeColor = System.Drawing.Color.Red
        Me.lblRows.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 50
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Rate/Unit"
        Me.InputLabel4.Width = 100
        '
        'txtRate
        '
        Me.txtRate.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtRate.Name = "txtRate"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRun
        '
        Me.btnRun.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'fgExcel
        '
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgExcel.Location = New System.Drawing.Point(0, 125)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(981, 345)
        Me.fgExcel.StyleInfo = resources.GetString("fgExcel.StyleInfo")
        Me.fgExcel.TabIndex = 21
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Dividend Amount"
        Me.InputLabel7.Width = 120
        '
        'lblDividendAmount
        '
        Me.lblDividendAmount.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDividendAmount.Name = "lblDividendAmount"
        Me.lblDividendAmount.Width = 120
        '
        'FormEODOverrideDividendCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 471)
        Me.Controls.Add(Me.fgExcel)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODOverrideDividendCash"
        Me.Text = "END OF DAY: Override Dividend Cash"
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtPayment As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUnits As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAV As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnLoad As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtRate As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDividendAmount As C1.Win.C1InputPanel.InputLabel
End Class
