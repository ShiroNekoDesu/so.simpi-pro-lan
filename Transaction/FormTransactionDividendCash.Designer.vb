<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactionDividendCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransactionDividendCash))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVDate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCcy = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPrice = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTransactionDate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAV = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTotalUnits = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnDelete = New C1.Win.C1InputPanel.InputButton()
        Me.DBGSubscription = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGSubscription, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.lblNAVDate)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCcy)
        Me.C1InputPanel1.Items.Add(Me.lblPrice)
        Me.C1InputPanel1.Items.Add(Me.lblTransactionDate)
        Me.C1InputPanel1.Items.Add(Me.lblNAV)
        Me.C1InputPanel1.Items.Add(Me.lblTotalUnits)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtFrom)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.dtTo)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.btnAdd)
        Me.C1InputPanel1.Items.Add(Me.btnDelete)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(884, 116)
        Me.C1InputPanel1.TabIndex = 2
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
        Me.lblPortfolioCode.Width = 100
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
        Me.lblSimpiName.Width = 680
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Height = 3
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 685
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "NAV Date: "
        Me.InputLabel4.Width = 100
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Price"
        Me.InputLabel5.Width = 140
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Trans. Date"
        Me.InputLabel3.Width = 100
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Net Asset Value"
        Me.InputLabel6.Width = 130
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Total Unit(s)"
        Me.InputLabel7.Width = 100
        '
        'lblNAVDate
        '
        Me.lblNAVDate.Name = "lblNAVDate"
        Me.lblNAVDate.Width = 100
        '
        'lblPortfolioCcy
        '
        Me.lblPortfolioCcy.Name = "lblPortfolioCcy"
        Me.lblPortfolioCcy.Width = 35
        '
        'lblPrice
        '
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Width = 100
        '
        'lblTransactionDate
        '
        Me.lblTransactionDate.Name = "lblTransactionDate"
        Me.lblTransactionDate.Width = 100
        '
        'lblNAV
        '
        Me.lblNAV.Name = "lblNAV"
        Me.lblNAV.Width = 130
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Width = 100
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
        Me.dtFrom.Name = "dtFrom"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "To date: "
        Me.InputLabel2.Width = 65
        '
        'dtTo
        '
        Me.dtTo.Name = "dtTo"
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        '
        'DBGSubscription
        '
        Me.DBGSubscription.BackColor = System.Drawing.Color.White
        Me.DBGSubscription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGSubscription.CaptionHeight = 17
        Me.DBGSubscription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGSubscription.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGSubscription.Images.Add(CType(resources.GetObject("DBGSubscription.Images"), System.Drawing.Image))
        Me.DBGSubscription.Location = New System.Drawing.Point(0, 116)
        Me.DBGSubscription.Name = "DBGSubscription"
        Me.DBGSubscription.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGSubscription.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGSubscription.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGSubscription.PrintInfo.PageSettings = CType(resources.GetObject("DBGSubscription.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGSubscription.PropBag = resources.GetString("DBGSubscription.PropBag")
        Me.DBGSubscription.RecordSelectors = False
        Me.DBGSubscription.RowHeight = 35
        Me.DBGSubscription.Size = New System.Drawing.Size(884, 346)
        Me.DBGSubscription.TabIndex = 9
        '
        'FormTransactionDividendCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.DBGSubscription)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransactionDividendCash"
        Me.Text = "TRANSACTION: Dividend Cash"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGSubscription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCcy As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTransactionDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAV As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTotalUnits As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGSubscription As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnDelete As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
End Class
