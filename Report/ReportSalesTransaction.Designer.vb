﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSalesTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSalesTransaction))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchPortfolio = New C1.Win.C1InputPanel.InputButton()
        Me.lblPortfolioCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblPortfolioName = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiEmail = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSimpiName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.btnSearchSales = New C1.Win.C1InputPanel.InputButton()
        Me.lblSalesCode = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSalesName = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.dtFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.dtTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.btnSearch = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubsNoSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubsNoST = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedsNoSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedsNoST = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDivNoSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDivNoST = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubsUnitSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubsUnitST = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedsUnitSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedsUnitST = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDivUnitSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDivUnitST = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubsValueSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblSubsValueST = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedsValueSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblRedsValueST = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDivValueSD = New C1.Win.C1InputPanel.InputLabel()
        Me.lblDivValueST = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.rbSalesDirect = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbSalesTeam = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rbSalesAll = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.cmbType = New C1.Win.C1InputPanel.InputComboBox()
        Me.btnExcel = New C1.Win.C1InputPanel.InputButton()
        Me.btnPDF = New C1.Win.C1InputPanel.InputButton()
        Me.DBGTransaction = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnEmail = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBGTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.btnSearchPortfolio)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioCode)
        Me.C1InputPanel1.Items.Add(Me.lblPortfolioName)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiEmail)
        Me.C1InputPanel1.Items.Add(Me.lblSimpiName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.btnSearchSales)
        Me.C1InputPanel1.Items.Add(Me.lblSalesCode)
        Me.C1InputPanel1.Items.Add(Me.lblSalesName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.dtFrom)
        Me.C1InputPanel1.Items.Add(Me.dtTo)
        Me.C1InputPanel1.Items.Add(Me.btnSearch)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.lblSubsNoSD)
        Me.C1InputPanel1.Items.Add(Me.lblSubsNoST)
        Me.C1InputPanel1.Items.Add(Me.lblRedsNoSD)
        Me.C1InputPanel1.Items.Add(Me.lblRedsNoST)
        Me.C1InputPanel1.Items.Add(Me.lblDivNoSD)
        Me.C1InputPanel1.Items.Add(Me.lblDivNoST)
        Me.C1InputPanel1.Items.Add(Me.InputLabel20)
        Me.C1InputPanel1.Items.Add(Me.InputLabel21)
        Me.C1InputPanel1.Items.Add(Me.InputLabel22)
        Me.C1InputPanel1.Items.Add(Me.lblSubsUnitSD)
        Me.C1InputPanel1.Items.Add(Me.lblSubsUnitST)
        Me.C1InputPanel1.Items.Add(Me.lblRedsUnitSD)
        Me.C1InputPanel1.Items.Add(Me.lblRedsUnitST)
        Me.C1InputPanel1.Items.Add(Me.lblDivUnitSD)
        Me.C1InputPanel1.Items.Add(Me.lblDivUnitST)
        Me.C1InputPanel1.Items.Add(Me.InputLabel29)
        Me.C1InputPanel1.Items.Add(Me.InputLabel30)
        Me.C1InputPanel1.Items.Add(Me.InputLabel31)
        Me.C1InputPanel1.Items.Add(Me.lblSubsValueSD)
        Me.C1InputPanel1.Items.Add(Me.lblSubsValueST)
        Me.C1InputPanel1.Items.Add(Me.lblRedsValueSD)
        Me.C1InputPanel1.Items.Add(Me.lblRedsValueST)
        Me.C1InputPanel1.Items.Add(Me.lblDivValueSD)
        Me.C1InputPanel1.Items.Add(Me.lblDivValueST)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.rbSalesDirect)
        Me.C1InputPanel1.Items.Add(Me.rbSalesTeam)
        Me.C1InputPanel1.Items.Add(Me.rbSalesAll)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.cmbType)
        Me.C1InputPanel1.Items.Add(Me.btnExcel)
        Me.C1InputPanel1.Items.Add(Me.btnPDF)
        Me.C1InputPanel1.Items.Add(Me.btnEmail)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(941, 287)
        Me.C1InputPanel1.TabIndex = 5
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Blue
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "MASTER PORTFOLIO"
        '
        'btnSearchPortfolio
        '
        Me.btnSearchPortfolio.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchPortfolio.Image = CType(resources.GetObject("btnSearchPortfolio.Image"), System.Drawing.Image)
        Me.btnSearchPortfolio.Name = "btnSearchPortfolio"
        '
        'lblPortfolioCode
        '
        Me.lblPortfolioCode.Name = "lblPortfolioCode"
        Me.lblPortfolioCode.Width = 100
        '
        'lblPortfolioName
        '
        Me.lblPortfolioName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblPortfolioName.Name = "lblPortfolioName"
        '
        'lblSimpiEmail
        '
        Me.lblSimpiEmail.Name = "lblSimpiEmail"
        Me.lblSimpiEmail.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.lblSimpiEmail.Width = 1
        '
        'lblSimpiName
        '
        Me.lblSimpiName.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSimpiName.Name = "lblSimpiName"
        Me.lblSimpiName.Width = 680
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "SALES AGENT"
        '
        'btnSearchSales
        '
        Me.btnSearchSales.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearchSales.Image = CType(resources.GetObject("btnSearchSales.Image"), System.Drawing.Image)
        Me.btnSearchSales.Name = "btnSearchSales"
        '
        'lblSalesCode
        '
        Me.lblSalesCode.Name = "lblSalesCode"
        Me.lblSalesCode.Width = 100
        '
        'lblSalesName
        '
        Me.lblSalesName.Name = "lblSalesName"
        Me.lblSalesName.Width = 490
        '
        'InputLabel1
        '
        Me.InputLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "From date: "
        Me.InputLabel1.Width = 65
        '
        'dtFrom
        '
        Me.dtFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtFrom.Name = "dtFrom"
        '
        'dtTo
        '
        Me.dtTo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.dtTo.Name = "dtTo"
        '
        'btnSearch
        '
        Me.btnSearch.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Name = "btnSearch"
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "TRANSACTION SUMMARY"
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Summary"
        Me.InputLabel6.Width = 200
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Width = 100
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Subscription"
        Me.InputLabel7.Width = 200
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Redemption"
        Me.InputLabel8.Width = 200
        '
        'InputLabel9
        '
        Me.InputLabel9.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Dividend"
        Me.InputLabel9.Width = 200
        '
        'InputLabel11
        '
        Me.InputLabel11.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "No Of Transaction"
        Me.InputLabel11.Width = 150
        '
        'InputLabel12
        '
        Me.InputLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Direct Sales"
        Me.InputLabel12.Width = 75
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Team Sales"
        Me.InputLabel13.Width = 75
        '
        'lblSubsNoSD
        '
        Me.lblSubsNoSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSubsNoSD.Name = "lblSubsNoSD"
        Me.lblSubsNoSD.Width = 75
        '
        'lblSubsNoST
        '
        Me.lblSubsNoST.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSubsNoST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblSubsNoST.Name = "lblSubsNoST"
        Me.lblSubsNoST.Width = 75
        '
        'lblRedsNoSD
        '
        Me.lblRedsNoSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblRedsNoSD.Name = "lblRedsNoSD"
        Me.lblRedsNoSD.Width = 75
        '
        'lblRedsNoST
        '
        Me.lblRedsNoST.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRedsNoST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblRedsNoST.Name = "lblRedsNoST"
        Me.lblRedsNoST.Width = 75
        '
        'lblDivNoSD
        '
        Me.lblDivNoSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblDivNoSD.Name = "lblDivNoSD"
        Me.lblDivNoSD.Width = 75
        '
        'lblDivNoST
        '
        Me.lblDivNoST.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDivNoST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.lblDivNoST.Name = "lblDivNoST"
        Me.lblDivNoST.Width = 75
        '
        'InputLabel20
        '
        Me.InputLabel20.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel20.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "No Of Unit(s)"
        Me.InputLabel20.Width = 200
        '
        'InputLabel21
        '
        Me.InputLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel21.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Direct Sales"
        Me.InputLabel21.Width = 100
        '
        'InputLabel22
        '
        Me.InputLabel22.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel22.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Team Sales"
        Me.InputLabel22.Width = 100
        '
        'lblSubsUnitSD
        '
        Me.lblSubsUnitSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSubsUnitSD.Name = "lblSubsUnitSD"
        Me.lblSubsUnitSD.Width = 100
        '
        'lblSubsUnitST
        '
        Me.lblSubsUnitST.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSubsUnitST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSubsUnitST.Name = "lblSubsUnitST"
        Me.lblSubsUnitST.Width = 100
        '
        'lblRedsUnitSD
        '
        Me.lblRedsUnitSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedsUnitSD.Name = "lblRedsUnitSD"
        Me.lblRedsUnitSD.Width = 100
        '
        'lblRedsUnitST
        '
        Me.lblRedsUnitST.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRedsUnitST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedsUnitST.Name = "lblRedsUnitST"
        Me.lblRedsUnitST.Width = 100
        '
        'lblDivUnitSD
        '
        Me.lblDivUnitSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDivUnitSD.Name = "lblDivUnitSD"
        Me.lblDivUnitSD.Width = 100
        '
        'lblDivUnitST
        '
        Me.lblDivUnitST.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.lblDivUnitST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDivUnitST.Name = "lblDivUnitST"
        Me.lblDivUnitST.Width = 100
        '
        'InputLabel29
        '
        Me.InputLabel29.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel29.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Value"
        Me.InputLabel29.Width = 240
        '
        'InputLabel30
        '
        Me.InputLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel30.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Text = "Direct Sales"
        Me.InputLabel30.Width = 120
        '
        'InputLabel31
        '
        Me.InputLabel31.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel31.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel31.Name = "InputLabel31"
        Me.InputLabel31.Text = "Team Sales"
        Me.InputLabel31.Width = 120
        '
        'lblSubsValueSD
        '
        Me.lblSubsValueSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSubsValueSD.Name = "lblSubsValueSD"
        Me.lblSubsValueSD.Width = 120
        '
        'lblSubsValueST
        '
        Me.lblSubsValueST.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblSubsValueST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblSubsValueST.Name = "lblSubsValueST"
        Me.lblSubsValueST.Width = 120
        '
        'lblRedsValueSD
        '
        Me.lblRedsValueSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedsValueSD.Name = "lblRedsValueSD"
        Me.lblRedsValueSD.Width = 120
        '
        'lblRedsValueST
        '
        Me.lblRedsValueST.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.lblRedsValueST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblRedsValueST.Name = "lblRedsValueST"
        Me.lblRedsValueST.Width = 120
        '
        'lblDivValueSD
        '
        Me.lblDivValueSD.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDivValueSD.Name = "lblDivValueSD"
        Me.lblDivValueSD.Width = 120
        '
        'lblDivValueST
        '
        Me.lblDivValueST.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.lblDivValueST.Name = "lblDivValueST"
        Me.lblDivValueST.Width = 120
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "TRANSACTION FILTER"
        '
        'InputLabel5
        '
        Me.InputLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Level: "
        '
        'rbSalesDirect
        '
        Me.rbSalesDirect.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbSalesDirect.Name = "rbSalesDirect"
        Me.rbSalesDirect.Text = "Direct Sales"
        '
        'rbSalesTeam
        '
        Me.rbSalesTeam.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbSalesTeam.Name = "rbSalesTeam"
        Me.rbSalesTeam.Text = "Team Sales"
        '
        'rbSalesAll
        '
        Me.rbSalesAll.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rbSalesAll.Checked = True
        Me.rbSalesAll.Name = "rbSalesAll"
        Me.rbSalesAll.Text = "All Sales"
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Trans. Type: "
        '
        'cmbType
        '
        Me.cmbType.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmbType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Width = 150
        '
        'btnExcel
        '
        Me.btnExcel.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Name = "btnExcel"
        '
        'btnPDF
        '
        Me.btnPDF.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnPDF.Enabled = False
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.Name = "btnPDF"
        '
        'DBGTransaction
        '
        Me.DBGTransaction.BackColor = System.Drawing.Color.White
        Me.DBGTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBGTransaction.CaptionHeight = 17
        Me.DBGTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGTransaction.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGTransaction.Images.Add(CType(resources.GetObject("DBGTransaction.Images"), System.Drawing.Image))
        Me.DBGTransaction.Location = New System.Drawing.Point(0, 287)
        Me.DBGTransaction.Name = "DBGTransaction"
        Me.DBGTransaction.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGTransaction.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGTransaction.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGTransaction.PrintInfo.PageSettings = CType(resources.GetObject("DBGTransaction.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGTransaction.PropBag = resources.GetString("DBGTransaction.PropBag")
        Me.DBGTransaction.RecordSelectors = False
        Me.DBGTransaction.RowHeight = 15
        Me.DBGTransaction.Size = New System.Drawing.Size(941, 232)
        Me.DBGTransaction.TabIndex = 13
        '
        'btnEmail
        '
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.Name = "btnEmail"
        '
        'ReportSalesTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 519)
        Me.Controls.Add(Me.DBGTransaction)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportSalesTransaction"
        Me.Text = "REPORT: Sales Transaction"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBGTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchPortfolio As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblPortfolioCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblPortfolioName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiEmail As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSimpiName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnSearchSales As C1.Win.C1InputPanel.InputButton
    Friend WithEvents lblSalesCode As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSalesName As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents cmbType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents dtFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents dtTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents btnSearch As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btnExcel As C1.Win.C1InputPanel.InputButton
    Friend WithEvents DBGTransaction As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents rbSalesDirect As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rbSalesAll As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubsNoSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubsNoST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedsNoSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedsNoST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDivNoSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDivNoST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubsUnitSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubsUnitST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedsUnitSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents lblRedsUnitST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDivUnitSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDivUnitST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubsValueSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblSubsValueST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedsValueSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblRedsValueST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDivValueSD As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents lblDivValueST As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents btnPDF As C1.Win.C1InputPanel.InputButton
    Friend WithEvents rbSalesTeam As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents btnEmail As C1.Win.C1InputPanel.InputButton
End Class
