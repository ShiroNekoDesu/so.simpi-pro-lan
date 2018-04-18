<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRedemptionBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRedemptionBank))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputDatePicker1 = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputDatePicker2 = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.DBGChargesTransaction = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGChargesTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.InputDatePicker1)
        Me.C1InputPanel1.Items.Add(Me.InputDatePicker2)
        Me.C1InputPanel1.Items.Add(Me.InputButton1)
        Me.C1InputPanel1.Items.Add(Me.InputButton2)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(884, 57)
        Me.C1InputPanel1.TabIndex = 2
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "TRANSACTION PERIOD"
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Date: "
        '
        'InputDatePicker1
        '
        Me.InputDatePicker1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputDatePicker1.Name = "InputDatePicker1"
        '
        'InputDatePicker2
        '
        Me.InputDatePicker2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputDatePicker2.Name = "InputDatePicker2"
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.Name = "InputButton1"
        '
        'DBGChargesTransaction
        '
        Me.DBGChargesTransaction.BackColor = System.Drawing.Color.White
        Me.DBGChargesTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGChargesTransaction.CaptionHeight = 17
        Me.DBGChargesTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGChargesTransaction.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGChargesTransaction.Images.Add(CType(resources.GetObject("DBGChargesTransaction.Images"), System.Drawing.Image))
        Me.DBGChargesTransaction.Location = New System.Drawing.Point(0, 57)
        Me.DBGChargesTransaction.Name = "DBGChargesTransaction"
        Me.DBGChargesTransaction.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGChargesTransaction.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGChargesTransaction.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGChargesTransaction.PrintInfo.PageSettings = CType(resources.GetObject("DBGChargesTransaction.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGChargesTransaction.PropBag = resources.GetString("DBGChargesTransaction.PropBag")
        Me.DBGChargesTransaction.RecordSelectors = False
        Me.DBGChargesTransaction.RowHeight = 35
        Me.DBGChargesTransaction.Size = New System.Drawing.Size(884, 306)
        Me.DBGChargesTransaction.TabIndex = 9
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton2.Image = CType(resources.GetObject("InputButton2.Image"), System.Drawing.Image)
        Me.InputButton2.Name = "InputButton2"
        '
        'InputButton3
        '
        Me.InputButton3.Image = CType(resources.GetObject("InputButton3.Image"), System.Drawing.Image)
        Me.InputButton3.Name = "InputButton3"
        '
        'FormRedemptionBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 363)
        Me.Controls.Add(Me.DBGChargesTransaction)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "FormRedemptionBank"
        Me.Text = " "
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGChargesTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputDatePicker1 As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputDatePicker2 As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGChargesTransaction As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
End Class
