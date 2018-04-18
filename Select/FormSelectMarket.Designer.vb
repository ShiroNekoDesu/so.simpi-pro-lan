<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectMarket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectMarket))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGMarket = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbMid = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbBid = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOffer = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGMarket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel13)
        Me.C1InputPanel2.Items.Add(Me.txtKeyword)
        Me.C1InputPanel2.Items.Add(Me.rbNone)
        Me.C1InputPanel2.Items.Add(Me.rbAnd)
        Me.C1InputPanel2.Items.Add(Me.rbOr)
        Me.C1InputPanel2.Items.Add(Me.rbCombine)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(770, 50)
        Me.C1InputPanel2.TabIndex = 5
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Keyword, that simillar with market code and/or name"
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 499
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'DBGMarket
        '
        Me.DBGMarket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGMarket.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGMarket.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGMarket.Images.Add(CType(resources.GetObject("DBGMarket.Images"), System.Drawing.Image))
        Me.DBGMarket.Location = New System.Drawing.Point(0, 50)
        Me.DBGMarket.Name = "DBGMarket"
        Me.DBGMarket.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGMarket.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGMarket.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGMarket.PrintInfo.PageSettings = CType(resources.GetObject("DBGMarket.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGMarket.PropBag = resources.GetString("DBGMarket.PropBag")
        Me.DBGMarket.Size = New System.Drawing.Size(770, 351)
        Me.DBGMarket.TabIndex = 7
        Me.DBGMarket.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.rbMid)
        Me.C1InputPanel1.Items.Add(Me.rbBid)
        Me.C1InputPanel1.Items.Add(Me.rbOffer)
        Me.C1InputPanel1.Items.Add(Me.btnSelect)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 401)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(770, 31)
        Me.C1InputPanel1.TabIndex = 8
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Price Type: "
        Me.InputLabel1.Width = 514
        '
        'rbMid
        '
        Me.rbMid.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbMid.Checked = True
        Me.rbMid.Name = "rbMid"
        Me.rbMid.Text = "Mid/Closing"
        '
        'rbBid
        '
        Me.rbBid.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbBid.Name = "rbBid"
        Me.rbBid.Text = "Bid"
        '
        'rbOffer
        '
        Me.rbOffer.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbOffer.Name = "rbOffer"
        Me.rbOffer.Text = "Offer"
        '
        'btnSelect
        '
        Me.btnSelect.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Name = "btnSelect"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        '
        'rbNone
        '
        Me.rbNone.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNone.Checked = True
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Text = "NONE"
        '
        'rbAnd
        '
        Me.rbAnd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbAnd.Name = "rbAnd"
        Me.rbAnd.Text = "AND"
        '
        'rbOr
        '
        Me.rbOr.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbOr.Name = "rbOr"
        Me.rbOr.Text = "OR"
        '
        'rbCombine
        '
        Me.rbCombine.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbCombine.Name = "rbCombine"
        Me.rbCombine.Text = "COMBINE"
        '
        'FormSelectMarket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 432)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.DBGMarket)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectMarket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECT: Market Price Souce"
        Me.TopMost = True
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGMarket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGMarket As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbMid As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbBid As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOffer As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
