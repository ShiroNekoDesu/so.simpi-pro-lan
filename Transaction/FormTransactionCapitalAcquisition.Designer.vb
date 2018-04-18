<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactionCapitalAcquisition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransactionCapitalAcquisition))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPositionDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel32 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblQty = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPrice = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastValue = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel42 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLastCost = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGAcquisition = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGAcquisition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblClientCode)
        Me.C1InputPanel1.Items.Add(Me.lblClientName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel1.Items.Add(Me.lblSalesName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel30)
        Me.C1InputPanel1.Items.Add(Me.lblPositionDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel32)
        Me.C1InputPanel1.Items.Add(Me.lblQty)
        Me.C1InputPanel1.Items.Add(Me.InputLabel36)
        Me.C1InputPanel1.Items.Add(Me.lblPrice)
        Me.C1InputPanel1.Items.Add(Me.InputLabel38)
        Me.C1InputPanel1.Items.Add(Me.lblLastValue)
        Me.C1InputPanel1.Items.Add(Me.InputLabel42)
        Me.C1InputPanel1.Items.Add(Me.lblLastCost)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(784, 160)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Text = "PRIMA"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Text = "Reksadana Bahana Dana Prima"
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 760
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Master Client"
        Me.InputLabel13.Width = 85
        '
        'lblClientCode
        '
        Me.lblClientCode.Name = "lblClientCode"
        Me.lblClientCode.Width = 125
        '
        'lblClientName
        '
        Me.lblClientName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Width = 550
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Master Sales: "
        Me.InputLabel1.Width = 85
        '
        'lblSalesCode
        '
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Width = 125
        '
        'lblSalesName
        '
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Width = 550
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "LATEST POSITION"
        '
        'InputLabel30
        '
        Me.InputLabel30.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Text = "As of: "
        Me.InputLabel30.Width = 100
        '
        'lblPositionDate
        '
        Me.lblPositionDate.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblPositionDate.Name = "lblPositionDate"
        Me.lblPositionDate.Text = "22-May-17"
        Me.lblPositionDate.Width = 100
        '
        'InputLabel32
        '
        Me.InputLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel32.Name = "InputLabel32"
        Me.InputLabel32.Text = "Unit(s): "
        Me.InputLabel32.Width = 65
        '
        'lblQty
        '
        Me.lblQty.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblQty.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Text = "17.350,98"
        Me.lblQty.Width = 100
        '
        'InputLabel36
        '
        Me.InputLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Text = "Unit Price:"
        Me.InputLabel36.Width = 65
        '
        'lblPrice
        '
        Me.lblPrice.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblPrice.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Text = "22-May-17"
        Me.lblPrice.Width = 100
        '
        'InputLabel38
        '
        Me.InputLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Text = "Market Value: "
        Me.InputLabel38.Width = 80
        '
        'lblLastValue
        '
        Me.lblLastValue.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblLastValue.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblLastValue.Name = "lblLastValue"
        Me.lblLastValue.Text = "99.00.000.000.000"
        Me.lblLastValue.Width = 100
        '
        'InputLabel42
        '
        Me.InputLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel42.Name = "InputLabel42"
        Me.InputLabel42.Text = "Cost Total: "
        Me.InputLabel42.Width = 80
        '
        'lblLastCost
        '
        Me.lblLastCost.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblLastCost.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblLastCost.Name = "lblLastCost"
        Me.lblLastCost.Text = "99.00.000.000.000"
        Me.lblLastCost.Width = 100
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "ACQUSITION HISTORY"
        '
        'DBGAcquisition
        '
        Me.DBGAcquisition.BackColor = System.Drawing.Color.White
        Me.DBGAcquisition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGAcquisition.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGAcquisition.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGAcquisition.Images.Add(CType(resources.GetObject("DBGAcquisition.Images"), System.Drawing.Image))
        Me.DBGAcquisition.Location = New System.Drawing.Point(0, 160)
        Me.DBGAcquisition.Name = "DBGAcquisition"
        Me.DBGAcquisition.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGAcquisition.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGAcquisition.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGAcquisition.PrintInfo.PageSettings = CType(resources.GetObject("DBGAcquisition.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGAcquisition.PropBag = resources.GetString("DBGAcquisition.PropBag")
        Me.DBGAcquisition.RecordSelectors = False
        Me.DBGAcquisition.RowHeight = 35
        Me.DBGAcquisition.Size = New System.Drawing.Size(784, 298)
        Me.DBGAcquisition.TabIndex = 121
        Me.DBGAcquisition.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'FormTransactionCapitalAcquisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 459)
        Me.Controls.Add(Me.DBGAcquisition)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransactionCapitalAcquisition"
        Me.Text = "TRANSACTION CAPITAL: ACQUSITION TABLE"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGAcquisition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPositionDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel32 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblQty As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastValue As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel42 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLastCost As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGAcquisition As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblClientCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
End Class
