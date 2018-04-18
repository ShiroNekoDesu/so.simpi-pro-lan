<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRedemptionKPDDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRedemptionKPDDelete))
        Me.btnCancel = New C1.Win.C1InputPanel.InputButton()
        Me.btnDelete = New C1.Win.C1InputPanel.InputButton()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.lblNetAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTransactionAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemptionFeeAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.lblTotalUnits = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAV = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPrice = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCcy = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNAVDate = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTransactionDate = New C1.Win.C1InputPanel.InputLabel()
        Me.lblClientCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.btnAcq = New C1.Win.C1InputPanel.InputButton()
        Me.chkAll = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccountName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblAccountCcy = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblTransactionUnit = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedemptionFee = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPayment = New C1.Win.C1InputPanel.InputLabel()
        Me.lblBankAccount = New C1.Win.C1InputPanel.InputLabel()
        Me.lblNotes = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Height = 35
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Width = 100
        '
        'btnDelete
        '
        Me.btnDelete.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnDelete.Height = 35
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.Width = 100
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 764
        '
        'lblNetAmount
        '
        Me.lblNetAmount.Name = "lblNetAmount"
        Me.lblNetAmount.Width = 100
        '
        'InputLabel24
        '
        Me.InputLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Net Amount: "
        Me.InputLabel24.Width = 100
        '
        'lblTransactionAmount
        '
        Me.lblTransactionAmount.Name = "lblTransactionAmount"
        Me.lblTransactionAmount.Width = 100
        '
        'InputLabel22
        '
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Amount: "
        Me.InputLabel22.Width = 85
        '
        'lblRedemptionFeeAmount
        '
        Me.lblRedemptionFeeAmount.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRedemptionFeeAmount.Name = "lblRedemptionFeeAmount"
        Me.lblRedemptionFeeAmount.Width = 100
        '
        'InputLabel20
        '
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "Redemption Fee: "
        Me.InputLabel20.Width = 100
        '
        'InputLabel19
        '
        Me.InputLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "Unit(s): "
        '
        'lblSalesName
        '
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Width = 495
        '
        'InputLabel14
        '
        Me.InputLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Sales Agent: "
        Me.InputLabel14.Width = 80
        '
        'lblClientName
        '
        Me.lblClientName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Width = 545
        '
        'InputLabel13
        '
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Master Client: "
        Me.InputLabel13.Width = 80
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "REDEMPTION DATA"
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Text = "100.000.000"
        Me.lblTotalUnits.Width = 120
        '
        'lblNAV
        '
        Me.lblNAV.Name = "lblNAV"
        Me.lblNAV.Text = "37.000.000.000.000,00"
        Me.lblNAV.Width = 150
        '
        'lblPrice
        '
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Text = "5.000.000.000,-"
        Me.lblPrice.Width = 100
        '
        'lblPortfolioCcy
        '
        Me.lblPortfolioCcy.Name = "lblPortfolioCcy"
        Me.lblPortfolioCcy.Text = "EURO"
        Me.lblPortfolioCcy.Width = 35
        '
        'lblNAVDate
        '
        Me.lblNAVDate.Name = "lblNAVDate"
        Me.lblNAVDate.Text = "22-May-2016"
        Me.lblNAVDate.Width = 100
        '
        'InputLabel7
        '
        Me.InputLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Total Unit(s)"
        Me.InputLabel7.Width = 120
        '
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Net Asset Value"
        Me.InputLabel6.Width = 145
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Price"
        Me.InputLabel5.Width = 140
        '
        'InputLabel4
        '
        Me.InputLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "NAV Date"
        Me.InputLabel4.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
        Me.lblPortfolioName.Text = "Reksadana Bahana Dana Prima"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Text = "PRIMA"
        Me.lblPortfolioCode.Width = 100
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.White
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.InputLabel18)
        Me.C1InputPanel1.Items.Add(Me.lblNAVDate)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCcy)
        Me.C1InputPanel1.Items.Add(Me.lblPrice)
        Me.C1InputPanel1.Items.Add(Me.lblNAV)
        Me.C1InputPanel1.Items.Add(Me.lblTotalUnits)
        Me.C1InputPanel1.Items.Add(Me.lblTransactionDate)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblClientCode)
        Me.C1InputPanel1.Items.Add(Me.lblClientName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel14)
        Me.C1InputPanel1.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel1.Items.Add(Me.lblSalesName)
        Me.C1InputPanel1.Items.Add(Me.btnAcq)
        Me.C1InputPanel1.Items.Add(Me.InputLabel19)
        Me.C1InputPanel1.Items.Add(Me.chkAll)
        Me.C1InputPanel1.Items.Add(Me.lblTransactionUnit)
        Me.C1InputPanel1.Items.Add(Me.InputLabel20)
        Me.C1InputPanel1.Items.Add(Me.lblRedemptionFee)
        Me.C1InputPanel1.Items.Add(Me.lblRedemptionFeeAmount)
        Me.C1InputPanel1.Items.Add(Me.InputLabel22)
        Me.C1InputPanel1.Items.Add(Me.lblTransactionAmount)
        Me.C1InputPanel1.Items.Add(Me.InputLabel24)
        Me.C1InputPanel1.Items.Add(Me.lblNetAmount)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.lblPayment)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.lblBankAccount)
        Me.C1InputPanel1.Items.Add(Me.lblAccountName)
        Me.C1InputPanel1.Items.Add(Me.lblAccountCcy)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.lblNotes)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.btnDelete)
        Me.C1InputPanel1.Items.Add(Me.btnCancel)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(784, 283)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 765
        '
        'InputLabel18
        '
        Me.InputLabel18.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Transaction Date"
        '
        'lblTransactionDate
        '
        Me.lblTransactionDate.Name = "lblTransactionDate"
        Me.lblTransactionDate.Text = "23-May-2016"
        '
        'lblClientCode
        '
        Me.lblClientCode.Name = "lblClientCode"
        Me.lblClientCode.Width = 100
        '
        'lblSalesCode
        '
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Width = 100
        '
        'btnAcq
        '
        Me.btnAcq.Name = "btnAcq"
        Me.btnAcq.Text = "ACQUISITION"
        '
        'chkAll
        '
        Me.chkAll.Break = C1.Win.C1InputPanel.BreakType.None
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Text = "All"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Payment Date: "
        '
        'InputLabel3
        '
        Me.InputLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Bank Account: "
        Me.InputLabel3.Width = 85
        '
        'lblAccountName
        '
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Width = 300
        '
        'lblAccountCcy
        '
        Me.lblAccountCcy.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblAccountCcy.Name = "lblAccountCcy"
        Me.lblAccountCcy.Width = 45
        '
        'InputLabel8
        '
        Me.InputLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Notes: "
        Me.InputLabel8.Width = 85
        '
        'lblTransactionUnit
        '
        Me.lblTransactionUnit.Name = "lblTransactionUnit"
        Me.lblTransactionUnit.Text = "Label"
        Me.lblTransactionUnit.Width = 100
        '
        'lblRedemptionFee
        '
        Me.lblRedemptionFee.Name = "lblRedemptionFee"
        Me.lblRedemptionFee.Text = "Label"
        Me.lblRedemptionFee.Width = 50
        '
        'lblPayment
        '
        Me.lblPayment.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Text = "Label"
        Me.lblPayment.Width = 100
        '
        'lblBankAccount
        '
        Me.lblBankAccount.Name = "lblBankAccount"
        Me.lblBankAccount.Text = "Label"
        Me.lblBankAccount.Width = 320
        '
        'lblNotes
        '
        Me.lblNotes.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Text = "Label"
        '
        'FormRedemptionKPDDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 283)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "FormRedemptionKPDDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REDEMPTION: Delete Discretionary Account"
        Me.TopMost = True
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnDelete As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents lblNetAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTransactionAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemptionFeeAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblTotalUnits As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAV As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPrice As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCcy As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNAVDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblTransactionDate As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccountName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblAccountCcy As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblClientCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnAcq As C1.Win.C1InputPanel.InputButton
    Friend WithEvents chkAll As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents lblTransactionUnit As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedemptionFee As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPayment As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblBankAccount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblNotes As C1.Win.C1InputPanel.InputLabel
End Class
