<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelectBank))
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbCountry = New C1.Win.C1InputPanel.InputComboBox()
        Me.txtKeyword = New C1.Win.C1InputPanel.InputTextBox()
        Me.rbAnd = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbOr = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbCombine = New C1.Win.C1InputPanel.InputRadioButton()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.btnSelect = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.DBGBank = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.rbNone = New C1.Win.C1InputPanel.InputRadioButton()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.InputLabel13)
        Me.C1InputPanel2.Items.Add(Me.cmbCountry)
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
        Me.C1InputPanel2.Size = New System.Drawing.Size(770, 50)
        Me.C1InputPanel2.TabIndex = 5
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Country"
        Me.InputLabel1.Width = 150
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Keyword, that simillar with bank code and/or name"
        '
        'cmbCountry
        '
        Me.cmbCountry.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbCountry.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Width = 150
        '
        'txtKeyword
        '
        Me.txtKeyword.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Width = 289
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
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
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
        'DBGBank
        '
        Me.DBGBank.BackColor = System.Drawing.Color.White
        Me.DBGBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBGBank.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGBank.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGBank.Images.Add(CType(resources.GetObject("DBGBank.Images"), System.Drawing.Image))
        Me.DBGBank.Location = New System.Drawing.Point(0, 50)
        Me.DBGBank.Name = "DBGBank"
        Me.DBGBank.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGBank.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGBank.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGBank.PrintInfo.PageSettings = CType(resources.GetObject("DBGBank.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGBank.PropBag = resources.GetString("DBGBank.PropBag")
        Me.DBGBank.Size = New System.Drawing.Size(770, 340)
        Me.DBGBank.TabIndex = 7
        Me.DBGBank.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        '
        'rbNone
        '
        Me.rbNone.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbNone.Checked = True
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Text = "NONE"
        '
        'FormSelectBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 389)
        Me.Controls.Add(Me.DBGBank)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelectBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECT: Master Bank"
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
    Friend WithEvents btnSelect As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbAnd As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbOr As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbCombine As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbNone As C1.Win.C1InputPanel.InputRadioButton
End Class
