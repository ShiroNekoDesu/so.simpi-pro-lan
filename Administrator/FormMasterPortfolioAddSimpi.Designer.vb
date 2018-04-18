<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterPortfolioAddSimpi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterPortfolioAddSimpi))
        Me.DBGUser = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbSummary = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbDetail = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbTrade = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.inputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblType = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioType = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioShortname = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblCcy = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.DBGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBGUser
        '
        Me.DBGUser.BackColor = System.Drawing.Color.White
        Me.DBGUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGUser.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGUser.Images.Add(CType(resources.GetObject("DBGUser.Images"), System.Drawing.Image))
        Me.DBGUser.Location = New System.Drawing.Point(0, 193)
        Me.DBGUser.Name = "DBGUser"
        Me.DBGUser.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGUser.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGUser.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGUser.PrintInfo.PageSettings = CType(resources.GetObject("DBGUser.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGUser.PropBag = resources.GetString("DBGUser.PropBag")
        Me.DBGUser.RecordSelectors = False
        Me.DBGUser.Size = New System.Drawing.Size(594, 181)
        Me.DBGUser.TabIndex = 14
        Me.DBGUser.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.rbSummary)
        Me.C1InputPanel1.Items.Add(Me.rbDetail)
        Me.C1InputPanel1.Items.Add(Me.rbTrade)
        Me.C1InputPanel1.Items.Add(Me.btnAdd)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 374)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(594, 32)
        Me.C1InputPanel1.TabIndex = 26
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Access Level: "
        Me.InputLabel2.Width = 338
        '
        'rbSummary
        '
        Me.rbSummary.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbSummary.Checked = True
        Me.rbSummary.Name = "rbSummary"
        Me.rbSummary.Text = "Summary"
        '
        'rbDetail
        '
        Me.rbDetail.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbDetail.Name = "rbDetail"
        Me.rbDetail.Text = "Detail"
        '
        'rbTrade
        '
        Me.rbTrade.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbTrade.Name = "rbTrade"
        Me.rbTrade.Text = "Trade"
        '
        'btnAdd
        '
        Me.btnAdd.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader1)
        Me.c1InputPanel7.Items.Add(Me.inputLabel14)
        Me.c1InputPanel7.Items.Add(Me.lblID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel1)
        Me.c1InputPanel7.Items.Add(Me.lblType)
        Me.c1InputPanel7.Items.Add(Me.inputLabel16)
        Me.c1InputPanel7.Items.Add(Me.inputLabel17)
        Me.c1InputPanel7.Items.Add(Me.lblName)
        Me.c1InputPanel7.Items.Add(Me.lblStatus)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader2)
        Me.c1InputPanel7.Items.Add(Me.InputLabel3)
        Me.c1InputPanel7.Items.Add(Me.lblPortfolioID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel4)
        Me.c1InputPanel7.Items.Add(Me.lblPortfolioCode)
        Me.c1InputPanel7.Items.Add(Me.InputLabel11)
        Me.c1InputPanel7.Items.Add(Me.lblPortfolioType)
        Me.c1InputPanel7.Items.Add(Me.InputLabel9)
        Me.c1InputPanel7.Items.Add(Me.lblPortfolioShortname)
        Me.c1InputPanel7.Items.Add(Me.InputLabel8)
        Me.c1InputPanel7.Items.Add(Me.lblPortfolioStatus)
        Me.c1InputPanel7.Items.Add(Me.InputLabel18)
        Me.c1InputPanel7.Items.Add(Me.lblPortfolioName)
        Me.c1InputPanel7.Items.Add(Me.InputLabel15)
        Me.c1InputPanel7.Items.Add(Me.lblCcy)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader3)
        Me.c1InputPanel7.Items.Add(Me.InputLabel5)
        Me.c1InputPanel7.Items.Add(Me.txtKeyword)
        Me.c1InputPanel7.Items.Add(Me.rbNone)
        Me.c1InputPanel7.Items.Add(Me.rbAnd)
        Me.c1InputPanel7.Items.Add(Me.rbOr)
        Me.c1InputPanel7.Items.Add(Me.rbCombine)
        Me.c1InputPanel7.Items.Add(Me.btnSearch)
        Me.c1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel7.Name = "c1InputPanel7"
        Me.c1InputPanel7.Size = New System.Drawing.Size(594, 193)
        Me.c1InputPanel7.TabIndex = 27
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "MASTER SIMPI"
        '
        'inputLabel14
        '
        Me.inputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel14.Name = "inputLabel14"
        Me.inputLabel14.Text = "ID: "
        Me.inputLabel14.Width = 50
        '
        'lblID
        '
        Me.lblID.Name = "lblID"
        Me.lblID.Width = 70
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "TYPE: "
        '
        'lblType
        '
        Me.lblType.Name = "lblType"
        Me.lblType.Width = 324
        '
        'inputLabel16
        '
        Me.inputLabel16.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.inputLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel16.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.inputLabel16.Name = "inputLabel16"
        Me.inputLabel16.Text = "STATUS"
        Me.inputLabel16.Width = 75
        '
        'inputLabel17
        '
        Me.inputLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel17.Name = "inputLabel17"
        Me.inputLabel17.Text = "NAME: "
        Me.inputLabel17.Width = 50
        '
        'lblName
        '
        Me.lblName.Name = "lblName"
        Me.lblName.Width = 442
        '
        'lblStatus
        '
        Me.lblStatus.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Width = 75
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "ID:"
        Me.InputLabel3.Width = 50
        '
        'lblPortfolioID
        '
        Me.lblPortfolioID.Name = "lblPortfolioID"
        Me.lblPortfolioID.Width = 70
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "CODE: "
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 235
        '
        'InputLabel11
        '
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "TYPE: "
        Me.InputLabel11.Width = 55
        '
        'lblPortfolioType
        '
        Me.lblPortfolioType.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioType.Name = "lblPortfolioType"
        '
        'InputLabel9
        '
        Me.InputLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "SHORTNAME: "
        Me.InputLabel9.Width = 85
        '
        'lblPortfolioShortname
        '
        Me.lblPortfolioShortname.Name = "lblPortfolioShortname"
        Me.lblPortfolioShortname.Width = 320
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "STATUS: "
        Me.InputLabel8.Width = 55
        '
        'lblPortfolioStatus
        '
        Me.lblPortfolioStatus.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioStatus.Name = "lblPortfolioStatus"
        '
        'InputLabel18
        '
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "NAME: "
        Me.InputLabel18.Width = 85
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Width = 320
        '
        'InputLabel15
        '
        Me.InputLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "CCY: "
        Me.InputLabel15.Width = 55
        '
        'lblCcy
        '
        Me.lblCcy.Name = "lblCcy"
        Me.lblCcy.Width = 50
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "AVAILABLE SIMPI USER"
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Keyword: "
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 267
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
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
        'FormMasterPortfolioAddSimpi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 406)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.DBGUser)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterPortfolioAddSimpi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER PORTFOLIO: Add Simpi User"
        Me.TopMost = True
        CType(Me.DBGUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DBGUser As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbSummary As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbDetail As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbTrade As C1.Win.C1InputPanel.InputRadioButton
    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents inputLabel14 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblType As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel16 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel17 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblName As C1.Win.C1InputPanel.InputLabel
    Private WithEvents lblStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioType As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioShortname As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioStatus As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblCcy As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
