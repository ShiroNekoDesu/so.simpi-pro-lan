<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEODReturnProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEODReturnProfile))
        Me.PanelPortfolio = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCcy = New C1.Win.C1InputPanel.InputLabel()
        Me.lblInception = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblValuation = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAV = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVAdjustment = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblUnit = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVPerUnit = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnGenerate = New C1.Win.C1InputPanel.InputButton()
        Me.btnDelete = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.fgReturn = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.PanelPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPortfolio
        '
        Me.PanelPortfolio.BorderThickness = 1
        Me.PanelPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPortfolio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PanelPortfolio.Items.Add(Me.InputLabel1)
        Me.PanelPortfolio.Items.Add(Me.InputLabel8)
        Me.PanelPortfolio.Items.Add(Me.InputLabel9)
        Me.PanelPortfolio.Items.Add(Me.InputLabel10)
        Me.PanelPortfolio.Items.Add(Me.lblPortfolioCode)
        Me.PanelPortfolio.Items.Add(Me.lblPortfolioName)
        Me.PanelPortfolio.Items.Add(Me.lblPortfolioCcy)
        Me.PanelPortfolio.Items.Add(Me.lblInception)
        Me.PanelPortfolio.Location = New System.Drawing.Point(0, 0)
        Me.PanelPortfolio.Name = "PanelPortfolio"
        Me.PanelPortfolio.Size = New System.Drawing.Size(784, 38)
        Me.PanelPortfolio.TabIndex = 3
        Me.PanelPortfolio.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Code"
        Me.InputLabel1.Width = 100
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Name"
        Me.InputLabel8.Width = 500
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Ccy"
        Me.InputLabel9.Width = 40
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Inception"
        Me.InputLabel10.Width = 110
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Text = "PRIMA"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Text = "Reksadana Bahana Dana Prima"
        Me.lblPortfolioName.Width = 500
        '
        'lblPortfolioCcy
        '
        Me.lblPortfolioCcy.Name = "lblPortfolioCcy"
        Me.lblPortfolioCcy.Text = "IDR"
        Me.lblPortfolioCcy.Width = 40
        '
        'lblInception
        '
        Me.lblInception.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblInception.Name = "lblInception"
        Me.lblInception.Text = "22-November-2017"
        Me.lblInception.Width = 110
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel18)
        Me.C1InputPanel1.Items.Add(Me.lblValuation)
        Me.C1InputPanel1.Items.Add(Me.InputLabel19)
        Me.C1InputPanel1.Items.Add(Me.lblNAV)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblNAVAdjustment)
        Me.C1InputPanel1.Items.Add(Me.InputLabel21)
        Me.C1InputPanel1.Items.Add(Me.lblUnit)
        Me.C1InputPanel1.Items.Add(Me.InputLabel20)
        Me.C1InputPanel1.Items.Add(Me.lblNAVPerUnit)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.btnGenerate)
        Me.C1InputPanel1.Items.Add(Me.btnDelete)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 38)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(431, 292)
        Me.C1InputPanel1.TabIndex = 4
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "NET ASSET VALUE"
        '
        'InputLabel18
        '
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.Height = 35
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Current Valuation"
        Me.InputLabel18.Width = 150
        '
        'lblValuation
        '
        Me.lblValuation.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblValuation.Height = 35
        Me.lblValuation.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblValuation.Name = "lblValuation"
        Me.lblValuation.Text = " "
        Me.lblValuation.Width = 150
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.Height = 35
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "Net Asset Value "
        Me.InputLabel19.Width = 150
        '
        'lblNAV
        '
        Me.lblNAV.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNAV.Height = 35
        Me.lblNAV.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblNAV.Name = "lblNAV"
        Me.lblNAV.Text = " "
        Me.lblNAV.Width = 150
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Height = 35
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Capital Subsription/ Withdrawal.:"
        Me.InputLabel2.Width = 150
        '
        'lblNAVAdjustment
        '
        Me.lblNAVAdjustment.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNAVAdjustment.Height = 35
        Me.lblNAVAdjustment.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblNAVAdjustment.Name = "lblNAVAdjustment"
        Me.lblNAVAdjustment.Text = " "
        Me.lblNAVAdjustment.Width = 150
        '
        'InputLabel21
        '
        Me.InputLabel21.AutoEllipsis = False
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.Height = 35
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Total Unit(s)"
        Me.InputLabel21.Width = 150
        '
        'lblUnit
        '
        Me.lblUnit.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblUnit.Height = 35
        Me.lblUnit.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Text = " "
        Me.lblUnit.Width = 150
        '
        'InputLabel20
        '
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.Height = 35
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "NAV/Unit"
        Me.InputLabel20.Width = 150
        '
        'lblNAVPerUnit
        '
        Me.lblNAVPerUnit.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNAVPerUnit.Height = 35
        Me.lblNAVPerUnit.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblNAVPerUnit.Name = "lblNAVPerUnit"
        Me.lblNAVPerUnit.Text = " "
        Me.lblNAVPerUnit.Width = 150
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Height = 40
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputSeparator1.Width = 412
        '
        'btnGenerate
        '
        Me.btnGenerate.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnGenerate.Height = 35
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.Width = 100
        '
        'btnDelete
        '
        Me.btnDelete.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnDelete.Height = 35
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "REMOVE"
        Me.btnDelete.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'fgReturn
        '
        Me.fgReturn.ColumnInfo = "3,0,0,0,0,95,Columns:0{Width:65;Caption:""Periode"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:85;Caption:""Date"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2" &
    "{Width:75;Caption:""Return"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgReturn.Dock = System.Windows.Forms.DockStyle.Left
        Me.fgReturn.Location = New System.Drawing.Point(431, 38)
        Me.fgReturn.Name = "fgReturn"
        Me.fgReturn.Rows.Count = 2
        Me.fgReturn.Rows.DefaultSize = 19
        Me.fgReturn.Size = New System.Drawing.Size(353, 292)
        Me.fgReturn.TabIndex = 5
        Me.fgReturn.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'FormEODReturnProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 330)
        Me.Controls.Add(Me.fgReturn)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.PanelPortfolio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEODReturnProfile"
        Me.Text = "END OF DAY: Generate Portfolio Return"
        CType(Me.PanelPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPortfolio As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCcy As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblInception As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblValuation As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAV As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVPerUnit As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblUnit As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents fgReturn As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVAdjustment As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnGenerate As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnDelete As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
End Class
