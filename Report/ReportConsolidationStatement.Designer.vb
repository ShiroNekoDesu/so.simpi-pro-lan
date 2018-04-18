<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportConsolidationStatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportConsolidationStatement))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchClient = New C1.Win.C1InputPanel.InputButton()
        Me.lblClientCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.dtTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbType = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnExcel = New C1.Win.C1InputPanel.InputButton()
        Me.btnPDF = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBalance = New C1.Win.C1InputPanel.InputLabel()
        Me.DBGTransaction = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.btnSearchPortfolio)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.btnSearchClient)
        Me.C1InputPanel1.Items.Add(Me.lblClientCode)
        Me.C1InputPanel1.Items.Add(Me.lblClientName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel1.Items.Add(Me.lblSalesName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtFrom)
        Me.C1InputPanel1.Items.Add(Me.dtTo)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.cmbType)
        Me.C1InputPanel1.Items.Add(Me.btnExcel)
        Me.C1InputPanel1.Items.Add(Me.btnPDF)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblBalance)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1005, 186)
        Me.C1InputPanel1.TabIndex = 4
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'btnSearchPortfolio
        '
        Me.btnSearchPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchPortfolio.Image = CType(resources.GetObject("btnSearchPortfolio.Image"), System.Drawing.Image)
        Me.btnSearchPortfolio.Name = "btnSearchPortfolio"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiName.Name = "lblSimpiName"
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "MASTER CLIENT"
        '
        'btnSearchClient
        '
        Me.btnSearchClient.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchClient.Image = CType(resources.GetObject("btnSearchClient.Image"), System.Drawing.Image)
        Me.btnSearchClient.Name = "btnSearchClient"
        '
        'lblClientCode
        '
        Me.lblClientCode.Name = "lblClientCode"
        '
        'lblClientName
        '
        Me.lblClientName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblClientName.Name = "lblClientName"
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Sales Agent: "
        '
        'lblSalesCode
        '
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Width = 100
        '
        'lblSalesName
        '
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Width = 500
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "From date: "
        Me.InputLabel1.Width = 65
        '
        'dtFrom
        '
        Me.dtFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtFrom.Name = "dtFrom"
        '
        'dtTo
        '
        Me.dtTo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtTo.Name = "dtTo"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 986
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Trans. Type: "
        '
        'cmbType
        '
        Me.cmbType.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Width = 150
        '
        'btnExcel
        '
        Me.btnExcel.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        '
        'btnPDF
        '
        Me.btnPDF.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnPDF.Enabled = False
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.Name = "btnPDF"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Beginning Balance: "
        Me.InputLabel3.Width = 586
        '
        'lblBalance
        '
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Width = 100
        '
        'DBGTransaction
        '
        Me.DBGTransaction.BackColor = System.Drawing.Color.White
        Me.DBGTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGTransaction.CaptionHeight = 17
        Me.DBGTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGTransaction.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTransaction.Images.Add(CType(resources.GetObject("DBGTransaction.Images"), System.Drawing.Image))
        Me.DBGTransaction.Location = New System.Drawing.Point(0, 186)
        Me.DBGTransaction.Name = "DBGTransaction"
        Me.DBGTransaction.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTransaction.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTransaction.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTransaction.PrintInfo.PageSettings = CType(resources.GetObject("DBGTransaction.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTransaction.PropBag = resources.GetString("DBGTransaction.PropBag")
        Me.DBGTransaction.RecordSelectors = False
        Me.DBGTransaction.RowHeight = 15
        Me.DBGTransaction.Size = New System.Drawing.Size(1005, 280)
        Me.DBGTransaction.TabIndex = 11
        '
        'ReportAccountStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 466)
        Me.Controls.Add(Me.DBGTransaction)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportConsolidationStatement"
        Me.Text = "REPORT: Account Consolidation Statement"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dtTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchClient As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblClientCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnExcel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGTransaction As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnPDF As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBalance As C1.Win.C1InputPanel.InputLabel
End Class
