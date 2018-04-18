<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportAccountValuation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportAccountValuation))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchClient = New C1.Win.C1InputPanel.InputButton()
        Me.lblClientCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnExcel = New C1.Win.C1InputPanel.InputButton()
        Me.btnEmail = New C1.Win.C1InputPanel.InputButton()
        Me.DBGFund = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGFund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.btnSearchClient)
        Me.C1InputPanel1.Items.Add(Me.lblClientCode)
        Me.C1InputPanel1.Items.Add(Me.lblClientName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel1.Items.Add(Me.lblSalesName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtAs)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.btnExcel)
        Me.C1InputPanel1.Items.Add(Me.btnEmail)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(944, 79)
        Me.C1InputPanel1.TabIndex = 5
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
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
        Me.lblSalesName.Width = 514
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "As Of: "
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'btnExcel
        '
        Me.btnExcel.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        '
        'btnEmail
        '
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.Name = "btnEmail"
        '
        'DBGFund
        '
        Me.DBGFund.BackColor = System.Drawing.Color.White
        Me.DBGFund.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGFund.CaptionHeight = 17
        Me.DBGFund.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGFund.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGFund.Images.Add(CType(resources.GetObject("DBGFund.Images"), System.Drawing.Image))
        Me.DBGFund.Location = New System.Drawing.Point(0, 79)
        Me.DBGFund.Name = "DBGFund"
        Me.DBGFund.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGFund.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGFund.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGFund.PrintInfo.PageSettings = CType(resources.GetObject("DBGFund.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGFund.PropBag = resources.GetString("DBGFund.PropBag")
        Me.DBGFund.RecordSelectors = False
        Me.DBGFund.RowHeight = 15
        Me.DBGFund.Size = New System.Drawing.Size(944, 266)
        Me.DBGFund.TabIndex = 12
        '
        'ReportAccountValuation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 345)
        Me.Controls.Add(Me.DBGFund)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportAccountValuation"
        Me.Text = "REPORT: Account Valuation"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGFund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchClient As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblClientCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnExcel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGFund As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnEmail As C1.Win.C1InputPanel.InputButton
End Class
