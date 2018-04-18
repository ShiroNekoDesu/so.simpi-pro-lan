<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterSimpiRiskLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterSimpiRiskLevel))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtQuestionNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtQuestionText = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnSave = New C1.Win.C1InputPanel.InputButton()
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.DBGAnswer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAnswerNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtMaximumValue = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.txtAnswerText = New C1.Win.C1InputPanel.InputTextBox()
        Me.btnAddAnswer = New C1.Win.C1InputPanel.InputButton()
        Me.btnRemoveAnswer = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.txtQuestionNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.txtQuestionText)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.btnSave)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(686, 170)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "No: "
        Me.InputLabel1.Width = 35
        '
        'txtQuestionNo
        '
        Me.txtQuestionNo.Name = "txtQuestionNo"
        Me.txtQuestionNo.Width = 64
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Question"
        '
        'txtQuestionText
        '
        Me.txtQuestionText.Height = 50
        Me.txtQuestionText.Multiline = True
        Me.txtQuestionText.Name = "txtQuestionText"
        Me.txtQuestionText.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.txtQuestionText.Width = 669
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 670
        '
        'btnSave
        '
        Me.btnSave.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSave.Enabled = False
        Me.btnSave.Height = 35
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Text = "SAVE"
        Me.btnSave.Width = 100
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "LIST OF ANSWER OPTION"
        '
        'DBGAnswer
        '
        Me.DBGAnswer.BackColor = System.Drawing.Color.White
        Me.DBGAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGAnswer.Dock = System.Windows.Forms.DockStyle.Top
        Me.DBGAnswer.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGAnswer.Images.Add(CType(resources.GetObject("DBGAnswer.Images"), System.Drawing.Image))
        Me.DBGAnswer.Location = New System.Drawing.Point(0, 170)
        Me.DBGAnswer.Name = "DBGAnswer"
        Me.DBGAnswer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGAnswer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGAnswer.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGAnswer.PrintInfo.PageSettings = CType(resources.GetObject("DBGAnswer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGAnswer.PropBag = resources.GetString("DBGAnswer.PropBag")
        Me.DBGAnswer.RecordSelectors = False
        Me.DBGAnswer.Size = New System.Drawing.Size(686, 190)
        Me.DBGAnswer.TabIndex = 7
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.InputLabel2)
        Me.C1InputPanel2.Items.Add(Me.txtAnswerNo)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.txtMaximumValue)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.txtAnswerText)
        Me.C1InputPanel2.Items.Add(Me.btnAddAnswer)
        Me.C1InputPanel2.Items.Add(Me.btnRemoveAnswer)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 360)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(686, 82)
        Me.C1InputPanel2.TabIndex = 8
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Add/remove answer option for question"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "No: "
        Me.InputLabel2.Width = 50
        '
        'txtAnswerNo
        '
        Me.txtAnswerNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAnswerNo.Name = "txtAnswerNo"
        Me.txtAnswerNo.Width = 50
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Value: "
        '
        'txtMaximumValue
        '
        Me.txtMaximumValue.Name = "txtMaximumValue"
        Me.txtMaximumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMaximumValue.Width = 50
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Answer: "
        Me.InputLabel6.Width = 50
        '
        'txtAnswerText
        '
        Me.txtAnswerText.Break = C1.Win.C1InputPanel.BreakType.None
        Me.txtAnswerText.Name = "txtAnswerText"
        Me.txtAnswerText.Width = 562
        '
        'btnAddAnswer
        '
        Me.btnAddAnswer.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnAddAnswer.Enabled = False
        Me.btnAddAnswer.Image = CType(resources.GetObject("btnAddAnswer.Image"), System.Drawing.Image)
        Me.btnAddAnswer.Name = "btnAddAnswer"
        '
        'btnRemoveAnswer
        '
        Me.btnRemoveAnswer.Enabled = False
        Me.btnRemoveAnswer.Image = CType(resources.GetObject("btnRemoveAnswer.Image"), System.Drawing.Image)
        Me.btnRemoveAnswer.Name = "btnRemoveAnswer"
        '
        'FormMasterSimpiRiskLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 442)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.DBGAnswer)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterSimpiRiskLevel"
        Me.Text = "MASTER SIMPI: Risk Profile Questioner"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtQuestionText As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents DBGAnswer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtMaximumValue As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents txtAnswerText As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents btnAddAnswer As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnRemoveAnswer As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtQuestionNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents btnSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents txtAnswerNo As C1.Win.C1InputPanel.InputTextBox
End Class
