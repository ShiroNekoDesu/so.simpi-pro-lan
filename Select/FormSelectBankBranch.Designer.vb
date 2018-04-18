<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectBankBranch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectBankBranch))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBankCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBankName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbCountry = New C1.Win.C1InputPanel.InputComboBox()
        Me.txtKeywordCity = New C1.Win.C1InputPanel.InputTextBox()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.DBGBank = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.lblBankCode)
        Me.C1InputPanel2.Items.Add(Me.lblBankName)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.cmbCountry)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.txtKeywordCity)
        Me.C1InputPanel2.Items.Add(Me.InputLabel13)
        Me.C1InputPanel2.Items.Add(Me.txtKeyword)
        Me.C1InputPanel2.Items.Add(Me.rbNone)
        Me.C1InputPanel2.Items.Add(Me.rbAnd)
        Me.C1InputPanel2.Items.Add(Me.rbOr)
        Me.C1InputPanel2.Items.Add(Me.rbCombine)
        Me.C1InputPanel2.Items.Add(Me.btnSearch)
        Me.C1InputPanel2.Items.Add(Me.btnSelect)
        Me.C1InputPanel2.Items.Add(Me.btnCancel)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(770, 89)
        Me.C1InputPanel2.TabIndex = 5
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Bank"
        Me.InputLabel6.Width = 100
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Name"
        '
        'lblBankCode
        '
        Me.lblBankCode.Name = "lblBankCode"
        Me.lblBankCode.Width = 100
        '
        'lblBankName
        '
        Me.lblBankName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblBankName.Name = "lblBankName"
        Me.lblBankName.Width = 648
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 1
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Country"
        Me.InputLabel1.Width = 150
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Keyword city:"
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Keyword branch"
        '
        'cmbCountry
        '
        Me.cmbCountry.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.cmbCountry.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Width = 140
        '
        'txtKeywordCity
        '
        Me.txtKeywordCity.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.txtKeywordCity.Name = "txtKeywordCity"
        Me.txtKeywordCity.Width = 128
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 143
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'DBGBank
        '
        Me.DBGBank.BackColor = System.Drawing.Color.White
        Me.DBGBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGBank.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGBank.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGBank.Images.Add(CType(resources.GetObject("DBGBank.Images"), System.Drawing.Image))
        Me.DBGBank.Location = New System.Drawing.Point(0, 89)
        Me.DBGBank.Name = "DBGBank"
        Me.DBGBank.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGBank.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGBank.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGBank.PrintInfo.PageSettings = CType(resources.GetObject("DBGBank.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGBank.PropBag = resources.GetString("DBGBank.PropBag")
        Me.DBGBank.Size = New System.Drawing.Size(770, 316)
        Me.DBGBank.TabIndex = 7
        Me.DBGBank.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
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
        'FormSelectBankBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 406)
        Me.Controls.Add(Me.DBGBank)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectBankBranch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECT: Bank Branch"
        Me.TopMost = True
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeyword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbCountry As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents DBGBank As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBankCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBankName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtKeywordCity As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
End Class
