<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEODOverrideClosing2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODOverrideClosing2))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtAs = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPrice = New C1.Win.C1InputPanel.InputLabel()
        Me.btnRun = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRows = New C1.Win.C1InputPanel.InputLabel()
        Me.pbNAV = New System.Windows.Forms.ProgressBar()
        Me.fgExcel = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bwRun = New System.ComponentModel.BackgroundWorker()
        Me.btnLoad = New C1.Win.C1InputPanel.InputButton()
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
        Me.C1InputPanel2.Items.Add(Me.dtAs)
        Me.C1InputPanel2.Items.Add(Me.btnLoad)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.lblPrice)
        Me.C1InputPanel2.Items.Add(Me.btnRun)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.lblRows)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(974, 124)
        Me.C1InputPanel2.TabIndex = 15
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
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
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
        Me.lblSimpiName.Width = 926
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "NAV PERIOD"
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "As Of: "
        '
        'dtAs
        '
        Me.dtAs.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtAs.Name = "dtAs"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "NAV/Unit: "
        '
        'lblPrice
        '
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Width = 100
        '
        'btnRun
        '
        Me.btnRun.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.Name = "btnRun"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "No of record(s): "
        '
        'lblRows
        '
        Me.lblRows.ForeColor = System.Drawing.Color.Red
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Width = 50
        '
        'pbNAV
        '
        Me.pbNAV.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbNAV.Location = New System.Drawing.Point(0, 124)
        Me.pbNAV.Name = "pbNAV"
        Me.pbNAV.Size = New System.Drawing.Size(974, 23)
        Me.pbNAV.Step = 1
        Me.pbNAV.TabIndex = 19
        '
        'fgExcel
        '
        Me.fgExcel.ColumnInfo = "0,0,0,0,0,95,Columns:"
        Me.fgExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.fgExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgExcel.Location = New System.Drawing.Point(0, 147)
        Me.fgExcel.Name = "fgExcel"
        Me.fgExcel.Rows.DefaultSize = 19
        Me.fgExcel.Size = New System.Drawing.Size(974, 367)
        Me.fgExcel.StyleInfo = resources.GetString("fgExcel.StyleInfo")
        Me.fgExcel.TabIndex = 20
        '
        'bwRun
        '
        '
        'btnLoad
        '
        Me.btnLoad.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        '
        'FormEODOverrideClosing2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 514)
        Me.Controls.Add(Me.fgExcel)
        Me.Controls.Add(Me.pbNAV)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Name = "FormEODOverrideClosing2"
        Me.Text = "END OF DAY: Override Closing"
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
    Friend WithEvents btnRun As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRows As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents pbNAV As ProgressBar
    Friend WithEvents fgExcel As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtAs As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnLoad As C1.Win.C1InputPanel.InputButton
End Class
