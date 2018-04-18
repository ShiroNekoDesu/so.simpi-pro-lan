<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSimpiUserProfilePortfolioSharing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSimpiUserProfilePortfolioSharing))
        Me.c1InputPanel7 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.inputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblID = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblType = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatus = New C1.Win.C1InputPanel.InputLabel()
        Me.inputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.inputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblIDUser = New C1.Win.C1InputPanel.InputLabel()
        Me.lblLoginUser = New C1.Win.C1InputPanel.InputLabel()
        Me.lblStatusUser = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.Keyword = New C1.Win.C1InputPanel.InputLabel()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGPortfolio = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbSummary = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbDetail = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbTrade = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnAdd = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel7
        '
        Me.c1InputPanel7.BorderThickness = 1
        Me.c1InputPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1InputPanel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel7.Items.Add(Me.inputLabel14)
        Me.c1InputPanel7.Items.Add(Me.lblID)
        Me.c1InputPanel7.Items.Add(Me.InputLabel1)
        Me.c1InputPanel7.Items.Add(Me.lblType)
        Me.c1InputPanel7.Items.Add(Me.inputLabel16)
        Me.c1InputPanel7.Items.Add(Me.inputLabel17)
        Me.c1InputPanel7.Items.Add(Me.lblName)
        Me.c1InputPanel7.Items.Add(Me.lblStatus)
        Me.c1InputPanel7.Items.Add(Me.inputSeparator1)
        Me.c1InputPanel7.Items.Add(Me.InputLabel3)
        Me.c1InputPanel7.Items.Add(Me.inputLabel35)
        Me.c1InputPanel7.Items.Add(Me.InputLabel4)
        Me.c1InputPanel7.Items.Add(Me.lblIDUser)
        Me.c1InputPanel7.Items.Add(Me.lblLoginUser)
        Me.c1InputPanel7.Items.Add(Me.lblStatusUser)
        Me.c1InputPanel7.Items.Add(Me.InputGroupHeader1)
        Me.c1InputPanel7.Items.Add(Me.Keyword)
        Me.c1InputPanel7.Items.Add(Me.txtKeyword)
        Me.c1InputPanel7.Items.Add(Me.rbNone)
        Me.c1InputPanel7.Items.Add(Me.rbAnd)
        Me.c1InputPanel7.Items.Add(Me.rbOr)
        Me.c1InputPanel7.Items.Add(Me.rbCombine)
        Me.c1InputPanel7.Items.Add(Me.btnSearch)
        Me.c1InputPanel7.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel7.Name = "c1InputPanel7"
        Me.c1InputPanel7.Size = New System.Drawing.Size(588, 131)
        Me.c1InputPanel7.TabIndex = 13
        Me.c1InputPanel7.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
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
        Me.lblID.Width = 100
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
        Me.lblType.Width = 289
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
        Me.lblName.Width = 434
        '
        'lblStatus
        '
        Me.lblStatus.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Width = 75
        '
        'inputSeparator1
        '
        Me.inputSeparator1.Name = "inputSeparator1"
        Me.inputSeparator1.Width = 565
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "ID"
        Me.InputLabel3.Width = 50
        '
        'inputLabel35
        '
        Me.inputLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLabel35.Name = "inputLabel35"
        Me.inputLabel35.Text = "USER LOGIN"
        Me.inputLabel35.Width = 449
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "STATUS"
        '
        'lblIDUser
        '
        Me.lblIDUser.Name = "lblIDUser"
        Me.lblIDUser.Width = 50
        '
        'lblLoginUser
        '
        Me.lblLoginUser.Name = "lblLoginUser"
        Me.lblLoginUser.Width = 449
        '
        'lblStatusUser
        '
        Me.lblStatusUser.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblStatusUser.Name = "lblStatusUser"
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "AVAILABLE MASTER PORTFOLIO"
        '
        'Keyword
        '
        Me.Keyword.Name = "Keyword"
        Me.Keyword.Text = "Keyword: "
        Me.Keyword.Width = 27
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 286
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'DBGPortfolio
        '
        Me.DBGPortfolio.BackColor = System.Drawing.Color.White
        Me.DBGPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGPortfolio.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGPortfolio.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGPortfolio.Images.Add(CType(resources.GetObject("DBGPortfolio.Images"), System.Drawing.Image))
        Me.DBGPortfolio.Location = New System.Drawing.Point(0, 131)
        Me.DBGPortfolio.Name = "DBGPortfolio"
        Me.DBGPortfolio.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGPortfolio.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGPortfolio.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGPortfolio.PrintInfo.PageSettings = CType(resources.GetObject("DBGPortfolio.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGPortfolio.PropBag = resources.GetString("DBGPortfolio.PropBag")
        Me.DBGPortfolio.RecordSelectors = False
        Me.DBGPortfolio.Size = New System.Drawing.Size(588, 243)
        Me.DBGPortfolio.TabIndex = 14
        Me.DBGPortfolio.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        Me.C1InputPanel1.Size = New System.Drawing.Size(588, 32)
        Me.C1InputPanel1.TabIndex = 26
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Access Level: "
        Me.InputLabel2.Width = 329
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
        'FormSimpiUserProfilePortfolioSharing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 406)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.DBGPortfolio)
        Me.Controls.Add(Me.c1InputPanel7)
        Me.Name = "FormSimpiUserProfilePortfolioSharing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPI USER: Add Sharing Portfolio"
        Me.TopMost = True
        CType(Me.c1InputPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1InputPanel7 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents inputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblID As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblType As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel16 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblStatus As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents inputLabel35 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblIDUser As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblLoginUser As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblStatusUser As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents Keyword As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DBGPortfolio As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents btnAdd As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbSummary As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbDetail As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbTrade As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
End Class
