Imports System.IO
Imports simpi.GlobalUtilities
Imports simpi.GlobalCore.GlobalStatistic
Imports simpi.GlobalUtilities.GlobalString
Imports simpi.GlobalUtilities.GlobalDate
Imports simpi.CoreData
Imports simpi.MasterSecurities

Public Class FormTransactionUnitAccountBalanceReconcile
    Dim objHolding As New PositionCapital 'as of sales
    Dim tblExcel As New DataTable
    Dim tblUnit As New DataTable
    Dim portfolioCode, portfolioName, saCode, saName, fundAccount, clientName, no As String
    Private Sub FormTransactionUnitAccountBalanceReconcile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        GetPortfolioMaster()
        GetSalesMaster()
        GetClientMaster()
        lblSalesInternal.Text = objMasterSimpi.GetCodeset(8)
        objHolding.UserAccess = objAccess

        GetComboInit(New ParameterExternalSystem, cmbExternalPortfolio, "SystemID", "SystemCode")
        tblExcel.Columns.Add("ClientCode", GetType(String))
        tblExcel.Columns.Add("ClientName", GetType(String))
        tblExcel.Columns.Add("FundCode", GetType(String))
        tblExcel.Columns.Add("FundName", GetType(String))
        tblExcel.Columns.Add("SalesCode", GetType(String))
        tblExcel.Columns.Add("SalesName", GetType(String))
        tblExcel.Columns.Add("Unit", GetType(Decimal))

        tblUnit.Columns.Add("ClientID", GetType(Integer))
        tblUnit.Columns.Add("ClientCode", GetType(String))
        tblUnit.Columns.Add("ClientName", GetType(String))
        tblUnit.Columns.Add("PortfolioID", GetType(Integer))
        tblUnit.Columns.Add("PortfolioCode", GetType(String))
        tblUnit.Columns.Add("PortfolioName", GetType(String))
        tblUnit.Columns.Add("SalesID", GetType(String))
        tblUnit.Columns.Add("SalesCode", GetType(String))
        tblUnit.Columns.Add("SalesName", GetType(String))
        tblUnit.Columns.Add("UnitBalance", GetType(Decimal))
        tblUnit.Columns.Add("UnitValue", GetType(Decimal))
    End Sub

    Private Sub setButton(ByVal buttonState As Boolean)
        btnBrowse.Enabled = buttonState
        btnRead.Enabled = buttonState
        txtFilename.Enabled = buttonState
        btnProcess.Enabled = buttonState
        cmbExternalPortfolio.Enabled = buttonState
        btnDistributor.Enabled = buttonState
        cmbDistributor.Enabled = buttonState
        btnFund.Enabled = buttonState
        cmbFund.Enabled = buttonState
        btnCopyFileNotFound.Enabled = buttonState
        btnCopyFundNotFound.Enabled = buttonState
        btnCopyFundNotRecon.Enabled = buttonState
        btnCopySalesNotFound.Enabled = buttonState
        btnCopySalesNotRecon.Enabled = buttonState
        btnUpdate.Enabled = buttonState
    End Sub

#Region "read"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenExcel()
    End Sub

    Private Sub txtFilename_Click(sender As Object, e As EventArgs) Handles txtFilename.Click
        OpenExcel()
    End Sub

    Private Sub txtFilename_TextChanged(sender As Object, e As EventArgs) Handles txtFilename.TextChanged
        If txtFilename.Text.Trim <> "" Then btnRead.Enabled = True Else btnRead.Enabled = False
    End Sub

    Private Sub OpenExcel()
        Dim myStream As Stream = Nothing
        Dim ofd As New OpenFileDialog()
        Dim fileReader As StreamReader = Nothing
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then txtFilename.Text = ofd.FileName
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        lblFileRows.Text = ""
        setButton(False)
        bwExcel.RunWorkerAsync()
    End Sub

    Private Sub bwExcel_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwExcel.DoWork
        ReadExcel()
    End Sub

    Private Sub bwExcel_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwExcel.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Function FileValidation() As Boolean
        If Trim(txtFilename.Text) = "" Then
            ExceptionMessage.Show(objError.Message(81) & " filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Trim(txtSheet.Text) = "" Then
            ExceptionMessage.Show(objError.Message(81) & " sheet name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Not IsNumeric(txtRowStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " start row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Not IsNumeric(txtColStart.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " start col", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        If Not IsNumeric(txtColNo.Text) Then
            ExceptionMessage.Show(objError.Message(81) & " number of cols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileValidation = False
            Exit Function
        End If
        FileValidation = True
    End Function

    Private Sub ReadExcel()
        Dim unit As Double
        Dim tmp As String
        If Not FileValidation() Then Exit Sub
        Try
            fgExcel.LoadExcel(txtFilename.Text, Trim(txtSheet.Text), C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            lblRows.Text = fgExcel.Rows.Count - 1
            lblFileRows.Text = fgExcel.Rows.Count - 1
            lblAsOf.Text = ConvertToDate(fgExcel(1, 1), "YMD").ToString("dd-MMM-yyyy")
            fgExcel.AutoSizeCols()

            getClient()

            tblExcel.Clear()
            pbNAV.Value = 0
            lblFileUnitTotal.Text = "0"
            For i = 1 To fgExcel.Rows.Count - 1
                Dim dr As DataRow = tblExcel.NewRow()

                tmp = ""
                If Not IsNothing(fgExcel(i, 2)) Then If fgExcel(i, 2).ToString.Trim <> "" Then tmp = fgExcel(i, 2).ToString.Trim
                dr("ClientCode") = tmp

                tmp = ""
                If Not IsNothing(fgExcel(i, 3)) Then If fgExcel(i, 3).ToString.Trim <> "" Then tmp = fgExcel(i, 3).ToString.Trim
                dr("ClientName") = tmp

                tmp = ""
                If Not IsNothing(fgExcel(i, 5)) Then If fgExcel(i, 5).ToString.Trim <> "" Then tmp = fgExcel(i, 5).ToString.Trim
                dr("FundCode") = tmp

                tmp = ""
                If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then tmp = fgExcel(i, 6).ToString.Trim
                dr("FundName") = tmp

                tmp = ""
                If Not IsNothing(fgExcel(i, 12)) Then If fgExcel(i, 12).ToString.Trim <> "" Then tmp = fgExcel(i, 12).ToString.Trim
                dr("SalesCode") = tmp

                tmp = ""
                If Not IsNothing(fgExcel(i, 13)) Then If fgExcel(i, 13).ToString.Trim <> "" Then tmp = fgExcel(i, 13).ToString.Trim
                dr("SalesName") = tmp

                unit = 0
                If Not IsNothing(fgExcel(i, 14)) Then If fgExcel(i, 14).ToString.Trim <> "" Then Double.TryParse(fgExcel(i, 14), unit)
                dr("Unit") = unit

                tblExcel.Rows.Add(dr)
                lblFileUnitTotal.Text = (CDbl(lblFileUnitTotal.Text) + unit).ToString("n4")
                If pbNAV.Value = 99 Then pbNAV.Value = 0 Else pbNAV.Value += 1
            Next
            pbNAV.Value = 100

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        getClient()
    End Sub

    Private Sub getClient()
        Cursor = Cursors.WaitCursor
        GetClientKYC()
        GetSalesCodeset()
        GetPortfolioExternalID()
        lblClientKYC.Text = (From r In dtClientKYC.AsEnumerable Select r.Field(Of Integer)("ClientID")).Count
        lblClientNo.Text = (From r In dtClientKYC.AsEnumerable Select r.Field(Of Integer)("ClientID")).Distinct.Count
        Cursor = Cursors.Default
    End Sub


#End Region

#Region "file status"
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        setButton(False)
        bwFile.RunWorkerAsync()
    End Sub

    Private Sub bwFile_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwFile.DoWork
        FileStatus
    End Sub

    Private Sub bwFile_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwFile.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Sub initFile()
        With fgFileFound
            .Rows.Count = 1
            .Cols.Count = 8
            .ExtendLastCol = False
            fgFileFound(0, 0) = "No"
            fgFileFound(0, 1) = "Client"
            fgFileFound(0, 2) = "Name"
            fgFileFound(0, 3) = "Fund"
            fgFileFound(0, 4) = "Name"
            fgFileFound(0, 5) = "Sales"
            fgFileFound(0, 6) = "Name"
            fgFileFound(0, 7) = "Unit"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With

        With fgFileNotfound
            .Rows.Count = 1
            .Cols.Count = 9
            .ExtendLastCol = False
            fgFileNotfound(0, 0) = "S"
            fgFileNotfound(0, 1) = "Client"
            fgFileNotfound(0, 2) = "Name"
            fgFileNotfound(0, 3) = "Fund"
            fgFileNotfound(0, 4) = "Name"
            fgFileNotfound(0, 5) = "Sales"
            fgFileNotfound(0, 6) = "Name"
            fgFileNotfound(0, 7) = "Unit"
            fgFileNotfound(0, 8) = "ErrMsg"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub FileStatus()
        If fgExcel.Rows.Count > 0 And cmbExternalPortfolio.SelectedIndex <> -1 Then
            Dim unit As Double
            Dim isFound As Boolean
            Dim isMessage As String
            Dim rowFund(), rowClient(), rowData() As DataRow
            Dim fundList(fgExcel.Rows.Count - 2) As String
            Dim saList(fgExcel.Rows.Count - 2) As String

            pbNAV.Value = 100
            lblFileFound.Text = "0"
            lblFileNotFound.Text = "0"
            lblFileUnitFound.Text = "0"
            lblFileUnitNotfound.Text = "0"
            initFile()

            Dim tbl As New DataTable
            objHolding.Clear()
            tbl = objHolding.Search(objMasterSimpi, CDate(lblAsOf.Text))
            Dim query = From u In tbl.AsEnumerable
                        Join p In dtPortfolioMaster.AsEnumerable
                               On u.Field(Of Integer)("PortfolioID") Equals p.Field(Of Integer)("PortfolioID")
                        Join c In dtClientMaster.AsEnumerable
                               On u.Field(Of Integer)("ClientID") Equals c.Field(Of Integer)("ClientID")
                        Join s In dtSalesMaster.AsEnumerable
                               On c.Field(Of Integer)("SalesID") Equals s.Field(Of Integer)("SalesID")
                        Select ClientID = c.Field(Of Integer)("ClientID"),
                                  ClientCode = c.Field(Of String)("ClientCode"),
                                  ClientName = c.Field(Of String)("ClientName"),
                                  PortfolioID = p.Field(Of Integer)("PortfolioID"),
                                  PortfolioCode = p.Field(Of String)("PortfolioCode"),
                                  PortfolioName = p.Field(Of String)("PortfolioNameFull"),
                                  SalesID = s.Field(Of Integer)("SalesID"),
                                  SalesCode = s.Field(Of String)("SalesCode"),
                                  SalesName = s.Field(Of String)("UserName"),
                                  UnitBalance = u.Field(Of Decimal)("UnitBalance"),
                                  UnitValue = u.Field(Of Decimal)("UnitValue")

            'Dim query = From d In tbl.AsEnumerable
            '            Group By key = New With {
            '                     Key .ClientID = d.Field(Of Integer)("ClientID"),
            '                     Key .ClientCode = d.Field(Of String)("ClientCode"),
            '                     Key .ClientName = d.Field(Of String)("ClientName"),
            '                     Key .PortfolioID = d.Field(Of Integer)("PortfolioID"),
            '                     Key .PortfolioCode = d.Field(Of String)("PortfolioCode"),
            '                     Key .PortfolioName = d.Field(Of String)("PortfolioNameFull"),
            '                     Key .SalesID = d.Field(Of Integer)("SalesID"),
            '                     Key .SalesCode = d.Field(Of String)("SalesCode"),
            '                     Key .SalesName = d.Field(Of String)("SalesName")
            '                     }
            '                Into Group Select New With {
            '                     .ClientID = key.ClientID, .ClientCode = key.ClientCode, .ClientName = key.ClientName,
            '                     .PortfolioID = key.PortfolioID, .PortfolioCode = key.PortfolioCode, .PortfolioName = key.PortfolioName,
            '                     .SalesID = key.SalesID, .SalesCode = key.SalesCode, .SalesName = key.SalesName,
            '                     .UnitBalance = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit")),
            '                     .UnitValue = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice"))
            '                     }

            tblUnit.Clear()
            For Each item In query
                Dim dr As DataRow = tblUnit.NewRow()
                dr("ClientID") = item.ClientID
                dr("ClientCode") = item.ClientCode
                dr("ClientName") = item.ClientName
                dr("PortfolioID") = item.PortfolioID
                dr("PortfolioCode") = item.PortfolioCode
                dr("PortfolioName") = item.PortfolioName
                dr("SalesID") = ""
                dr("SalesCode") = item.SalesCode
                dr("SalesName") = item.SalesName
                dr("UnitBalance") = item.UnitBalance
                dr("UnitValue") = item.UnitValue
                tblUnit.Rows.Add(dr)
            Next

            For i = 1 To fgExcel.Rows.Count - 1
                unit = 0
                If Not IsNothing(fgExcel(i, 14)) Then If fgExcel(i, 14).ToString.Trim <> "" Then Double.TryParse(fgExcel(i, 14), unit)
                portfolioCode = ""
                If Not IsNothing(fgExcel(i, 5)) Then If fgExcel(i, 5).ToString.Trim <> "" Then portfolioCode = fgExcel(i, 5).ToString.Trim
                fundList(i - 1) = portfolioCode
                saCode = ""
                If Not IsNothing(fgExcel(i, 12)) Then If fgExcel(i, 12).ToString.Trim <> "" Then saCode = fgExcel(i, 12).ToString.Trim
                saList(i - 1) = saCode
                fundAccount = ""
                If Not IsNothing(fgExcel(i, 2)) Then If fgExcel(i, 2).ToString.Trim <> "" Then fundAccount = fgExcel(i, 2).ToString.Trim
                clientName = ""
                If Not IsNothing(fgExcel(i, 3)) Then If fgExcel(i, 3).ToString.Trim <> "" Then clientName = fgExcel(i, 3).ToString.Trim
                no = ""
                If Not IsNothing(fgExcel(i, 0)) Then If fgExcel(i, 0).ToString.Trim <> "" Then no = fgExcel(i, 0).ToString.Trim
                portfolioName = ""
                If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then portfolioName = fgExcel(i, 6).ToString.Trim
                saName = ""
                If Not IsNothing(fgExcel(i, 13)) Then If fgExcel(i, 13).ToString.Trim <> "" Then saName = fgExcel(i, 13).ToString.Trim

                rowFund = dtPortfolioExternalID.Select("PortfolioExternalCode = '" & SQLFix(portfolioCode) & "' And SystemID = " & Str(cmbExternalPortfolio.SelectedValue))
                If rowFund.Length = 0 Then
                    isFound = False
                    isMessage = "portfolio not found"
                    lblFileNotFound.Text = CInt(lblFileNotFound.Text) + 1
                    lblFileUnitNotfound.Text = (CDbl(lblFileUnitNotfound.Text) + unit).ToString("n4")
                Else
                    rowClient = dtClientKYC.Select("kycAnswer = '" & SQLFix(fundAccount) & "' And kycID = " & Str(CInt(lblFundAccountID.Text)))
                    If rowClient.Length = 0 Then
                        isFound = False
                        isMessage = "client not found"
                        lblFileNotFound.Text = CInt(lblFileNotFound.Text) + 1
                        lblFileUnitNotfound.Text = (CDbl(lblFileUnitNotfound.Text) + unit).ToString("n4")
                    Else
                        rowData = tblUnit.Select("PortfolioID = " & Str(CInt(rowFund(0)("PortfolioID"))) & " And ClientID = " & Str(CInt(rowClient(0)("ClientID"))))
                        If rowData.Length = 0 Then
                            isFound = False
                            isMessage = "position not found"
                            lblFileNotFound.Text = CInt(lblFileNotFound.Text) + 1
                            lblFileUnitNotfound.Text = (CDbl(lblFileUnitNotfound.Text) + unit).ToString("n4")
                        Else
                            rowData(0)("SalesID") = saCode
                            isFound = True
                            isMessage = ""
                            lblFileFound.Text = CInt(lblFileFound.Text) + 1
                            lblFileUnitFound.Text = (CDbl(lblFileUnitFound.Text) + unit).ToString("n4")
                        End If
                    End If
                End If

                If isFound Then
                    fgFileFound.Rows.Add()
                    fgFileFound(fgFileFound.Rows.Count - 1, 0) = no
                    fgFileFound(fgFileFound.Rows.Count - 1, 1) = fundAccount
                    fgFileFound(fgFileFound.Rows.Count - 1, 2) = clientName
                    fgFileFound(fgFileFound.Rows.Count - 1, 3) = portfolioCode
                    fgFileFound(fgFileFound.Rows.Count - 1, 4) = portfolioName
                    fgFileFound(fgFileFound.Rows.Count - 1, 5) = saCode
                    fgFileFound(fgFileFound.Rows.Count - 1, 6) = saName
                    fgFileFound(fgFileFound.Rows.Count - 1, 7) = unit.ToString("n4")
                Else
                    fgFileNotfound.Rows.Add()
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 0) = no
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 1) = fundAccount
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 2) = clientName
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 3) = portfolioCode
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 4) = portfolioName
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 5) = saCode
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 6) = saName
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 7) = unit.ToString("n4")
                    fgFileNotfound(fgFileNotfound.Rows.Count - 1, 8) = isMessage
                End If
                If pbNAV.Value = 1 Then pbNAV.Value = 100 Else pbNAV.Value -= 1
            Next
            cmbFund.Items.Clear()
            cmbDistributor.Items.Clear()
            cmbFund.Items.AddText(RemoveDuplicates(fundList))
            cmbDistributor.Items.AddText(RemoveDuplicates(saList))
            pbNAV.Value = 0
            fgFileFound.AutoSizeCols()
            fgFileNotfound.AutoSizeCols()
        End If

    End Sub

#End Region

#Region "distributor reconcile"
    Private Sub cmbDistributor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDistributor.SelectedIndexChanged
        DistributorSelect()
    End Sub

    Private Sub DistributorSelect()
        If cmbDistributor.SelectedIndex <> -1 Then
            Dim rowSales() As DataRow
            rowSales = dtSalesCodeset.Select("FieldData = '" & SQLFix(cmbDistributor.Text) & "' And FieldID = " & Str(CInt(lblSACodesetID.Text)))
            lblSalesID.Text = cmbDistributor.Text
            If cmbDistributor.Text = lblSalesInternal.Text Then
                lblSalesCode.Text = cmbDistributor.Text
                lblSalesName.Text = objMasterSimpi.GetSimpiNameshort
            Else
                If rowSales.Length = 0 Then
                    ExceptionMessage.Show("sales not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lblSalesCode.Text = ""
                    lblSalesName.Text = ""
                Else
                    lblSalesCode.Text = rowSales(0)("SalesCode")
                    lblSalesName.Text = rowSales(0)("UserName")
                End If
            End If
        End If
    End Sub

    Private Sub btnDistributor_Click(sender As Object, e As EventArgs) Handles btnDistributor.Click
        setButton(False)
        bwDistributor.RunWorkerAsync()
    End Sub

    Private Sub bwDistributor_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwDistributor.DoWork
        DistributorReconcile()
    End Sub

    Private Sub bwDistributor_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwDistributor.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Sub initDistributor()
        With fgDistributorFound
            .Rows.Count = 1
            .Cols.Count = 8
            .ExtendLastCol = False
            fgDistributorFound(0, 0) = "No"
            fgDistributorFound(0, 1) = "Fund"
            fgDistributorFound(0, 2) = "Name"
            fgDistributorFound(0, 3) = "Client"
            fgDistributorFound(0, 4) = "Name"
            fgDistributorFound(0, 5) = "Unit"
            fgDistributorFound(0, 6) = "S-Invest"
            fgDistributorFound(0, 7) = "Diff."
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With

        With fgDistributorNotFound
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDistributorNotFound(0, 0) = "No"
            fgDistributorNotFound(0, 1) = "Fund"
            fgDistributorNotFound(0, 2) = "Name"
            fgDistributorNotFound(0, 3) = "Client"
            fgDistributorNotFound(0, 4) = "Name"
            fgDistributorNotFound(0, 5) = "Unit"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub DistributorReconcile()
        If fgExcel.Rows.Count > 0 And cmbExternalPortfolio.SelectedIndex <> -1 And cmbDistributor.SelectedIndex <> -1 Then
            Dim isFound As Boolean
            Dim rowFund(), rowClient(), rowData() As DataRow
            Dim unit, selisih As Double

            pbNAV.Value = 0
            lblDistributorAccount.Text = "0"
            lblDistributorAccountFound.Text = "0"
            lblDistributorAccountNotfound.Text = "0"
            lblDistributorAccountReconcile.Text = "0"
            lblDistributorAccountReconcileNot.Text = "0"
            lblDistributorUnitReconcile.Text = "0"
            lblDistributorUnitReconcileNot.Text = "0"
            lblDistributorAUMReconcile.Text = "0"
            lblDistributorAUMReconcileNot.Text = "0"
            initDistributor()
            Dim query = From p In tblUnit.AsEnumerable
                        Where p.Field(Of String)("SalesID") = lblSalesID.Text.Trim
                        Select PortfolioCode = p.Field(Of String)("PortfolioCode"),
                               PortfolioName = p.Field(Of String)("PortfolioName"),
                               ClientCode = p.Field(Of String)("ClientCode"),
                               ClientName = p.Field(Of String)("ClientName"),
                               UnitBalance = p.Field(Of Decimal)("UnitBalance"),
                               UnitValue = p.Field(Of Decimal)("UnitValue")

            For Each item In query
                If tblExcel.Rows.Count > 0 Then
                    rowFund = dtPortfolioExternalID.Select("PortfolioCode = '" & SQLFix(item.PortfolioCode) & "' And SystemID = " & Str(cmbExternalPortfolio.SelectedValue))
                    If rowFund.Length = 0 Then
                        isFound = False
                    Else
                        rowClient = dtClientKYC.Select("ClientCode = '" & SQLFix(item.ClientCode) & "' And kycID = " & Str(CInt(lblFundAccountID.Text)))
                        If rowClient.Length = 0 Then
                            isFound = False
                        Else
                            rowData = tblExcel.Select("FundCode = '" & SQLFix(rowFund(0)("PortfolioExternalCode")) & "' And ClientCode = '" & SQLFix(rowClient(0)("kycAnswer")) & "'")
                            If rowData.Length = 0 Then
                                isFound = False
                            Else
                                isFound = True
                                unit = CDbl(rowData(0)("Unit"))
                                If IsEqualWith(item.UnitBalance, unit) Then
                                    lblDistributorAccountReconcile.Text = CInt(lblDistributorAccountReconcile.Text) + 1
                                    lblDistributorUnitReconcile.Text = (CDbl(lblDistributorUnitReconcile.Text) + item.UnitBalance).ToString("n0")
                                    lblDistributorAUMReconcile.Text = (CDbl(lblDistributorAUMReconcile.Text) + item.UnitValue).ToString("n0")
                                    selisih = 0
                                Else
                                    lblDistributorAccountReconcileNot.Text = CInt(lblDistributorAccountReconcileNot.Text) + 1
                                    selisih = item.UnitBalance - unit
                                    lblDistributorUnitReconcileNot.Text = (CDbl(lblDistributorUnitReconcileNot.Text) + item.UnitBalance).ToString("n0")
                                    lblDistributorAUMReconcileNot.Text = (CDbl(lblDistributorAUMReconcileNot.Text) + item.UnitValue).ToString("n0")
                                End If
                            End If
                        End If
                    End If
                Else
                    isFound = False
                End If

                If isFound Then
                    fgDistributorFound.Rows.Add()
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 0) = fgDistributorFound.Rows.Count - 1
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 1) = item.PortfolioCode
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 2) = item.PortfolioName
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 3) = item.ClientCode
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 4) = item.ClientName
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 5) = item.UnitBalance.ToString("n4")
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 6) = unit.ToString("n4")
                    fgDistributorFound(fgDistributorFound.Rows.Count - 1, 7) = selisih.ToString("n4")

                    lblDistributorAccount.Text = CInt(lblDistributorAccount.Text) + 1
                    lblDistributorAccountFound.Text = CInt(lblDistributorAccountFound.Text) + 1
                Else
                    fgDistributorNotFound.Rows.Add()
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 0) = fgDistributorNotFound.Rows.Count - 1
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 1) = item.PortfolioCode
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 2) = item.PortfolioName
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 3) = item.ClientCode
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 4) = item.ClientName
                    fgDistributorNotFound(fgDistributorNotFound.Rows.Count - 1, 5) = item.UnitBalance.ToString("n4")

                    lblDistributorAccount.Text = CInt(lblDistributorAccount.Text) + 1
                    lblDistributorAccountNotfound.Text = CInt(lblDistributorAccountNotfound.Text) + 1
                End If
                If pbNAV.Value = 100 Then pbNAV.Value = 0 Else pbNAV.Value += 1
            Next
            pbNAV.Value = 100
            fgDistributorFound.AutoSizeCols()
            fgDistributorNotFound.AutoSizeCols()
        End If
    End Sub


#End Region

#Region "fund reconcile"
    Private Sub cmbFund_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFund.SelectedIndexChanged
        FundSelect()
    End Sub

    Private Sub FundSelect()
        If cmbFund.SelectedIndex <> -1 And cmbExternalPortfolio.SelectedIndex <> -1 Then
            Dim rowFund() As DataRow
            rowFund = dtPortfolioExternalID.Select("PortfolioExternalCode = '" & SQLFix(cmbFund.Text) & "' And SystemID = " & Str(cmbExternalPortfolio.SelectedValue))
            If rowFund.Length = 0 Then
                ExceptionMessage.Show("fund not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblFundID.Text = ""
                lblFundCode.Text = ""
                lblFundName.Text = ""
            Else
                lblFundID.Text = rowFund(0)("PortfolioID")
                lblFundCode.Text = rowFund(0)("PortfolioCode")
                lblFundName.Text = rowFund(0)("PortfolioNameShort")
            End If
        End If
    End Sub

    Private Sub btnFund_Click(sender As Object, e As EventArgs) Handles btnFund.Click
        setButton(False)
        bwFund.RunWorkerAsync()
    End Sub

    Private Sub bwFund_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwFund.DoWork
        FundReconcile()
    End Sub

    Private Sub bwFund_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwFund.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Sub initFund()
        With fgDirectFound
            .Rows.Count = 1
            .Cols.Count = 8
            .ExtendLastCol = False
            fgDirectFound(0, 0) = "No"
            fgDirectFound(0, 1) = "Sales"
            fgDirectFound(0, 2) = "Name"
            fgDirectFound(0, 3) = "Client"
            fgDirectFound(0, 4) = "Name"
            fgDirectFound(0, 5) = "Unit"
            fgDirectFound(0, 6) = "S-Invest"
            fgDirectFound(0, 7) = "Diff"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With

        With fgDirectNotfound
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDirectNotfound(0, 0) = "No"
            fgDirectNotfound(0, 1) = "Sales"
            fgDirectNotfound(0, 2) = "Name"
            fgDirectNotfound(0, 3) = "Client"
            fgDirectNotfound(0, 4) = "Name"
            fgDirectNotfound(0, 5) = "Unit"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub FundReconcile()
        If fgExcel.Rows.Count > 0 And cmbFund.SelectedIndex <> -1 Then
            Dim isFound As Boolean
            Dim rowClient(), rowData() As DataRow
            Dim sinvest, selisih As Double

            pbNAV.Value = 0
            lblDirectAccount.Text = "0"
            lblDirectAccountFound.Text = "0"
            lblDirectAccountNotfound.Text = "0"
            lblDirectAccountReconcile.Text = "0"
            lblDirectAccountReconcileNot.Text = "0"
            lblDirectUnitReconcile.Text = "0"
            lblDirectUnitReconcileNot.Text = "0"
            lblDirectAUMReconcile.Text = "0"
            lblDirectAUMReconcileNot.Text = "0"
            initFund()
            Dim query = From p In tblUnit.AsEnumerable
                        Where p.Field(Of Integer)("PortfolioID") = CInt(lblFundID.Text)
                        Select SalesCode = p.Field(Of String)("SalesCode"),
                               SalesName = p.Field(Of String)("SalesName"),
                               ClientCode = p.Field(Of String)("ClientCode"),
                               ClientName = p.Field(Of String)("ClientName"),
                               UnitBalance = p.Field(Of Decimal)("UnitBalance"),
                               UnitValue = p.Field(Of Decimal)("UnitValue")

            For Each item In query
                If tblExcel.Rows.Count > 0 Then
                    rowClient = dtClientKYC.Select("ClientCode = '" & SQLFix(item.ClientCode) & "' And kycID = " & Str(CInt(lblFundAccountID.Text)))
                    If rowClient.Length = 0 Then
                        isFound = False
                    Else
                        rowData = tblExcel.Select("FundCode = '" & SQLFix(cmbFund.Text) & "' And ClientCode = '" & SQLFix(rowClient(0)("kycAnswer")) & "'")
                        If rowData.Length = 0 Then
                            isFound = False
                        Else
                            isFound = True
                            sinvest = CDbl(rowData(0)("Unit"))
                            If IsEqualWith(item.UnitBalance, sinvest) Then
                                lblDirectAccountReconcile.Text = CInt(lblDirectAccountReconcile.Text) + 1
                                lblDirectUnitReconcile.Text = (CDbl(lblDirectUnitReconcile.Text) + item.UnitBalance).ToString("n0")
                                lblDirectAUMReconcile.Text = (CDbl(lblDirectAUMReconcile.Text) + item.UnitValue).ToString("n0")
                                selisih = 0
                            Else
                                lblDirectAccountReconcileNot.Text = CInt(lblDirectAccountReconcileNot.Text) + 1
                                selisih = item.UnitBalance - sinvest
                                lblDirectUnitReconcileNot.Text = (CDbl(lblDirectUnitReconcileNot.Text) + item.UnitBalance).ToString("n0")
                                lblDirectAUMReconcileNot.Text = (CDbl(lblDirectAUMReconcileNot.Text) + item.UnitValue).ToString("n0")
                            End If
                        End If
                    End If
                Else
                    isFound = False
                End If

                If isFound Then
                    fgDirectFound.Rows.Add()
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 0) = fgDirectFound.Rows.Count - 1
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 1) = item.SalesCode
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 2) = item.SalesName
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 3) = item.ClientCode
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 4) = item.ClientName
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 5) = item.UnitBalance.ToString("n4")
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 6) = sinvest.ToString("n4")
                    fgDirectFound(fgDirectFound.Rows.Count - 1, 7) = selisih.ToString("n4")

                    lblDirectAccount.Text = CInt(lblDirectAccount.Text) + 1
                    lblDirectAccountFound.Text = CInt(lblDirectAccountFound.Text) + 1
                Else
                    fgDirectNotfound.Rows.Add()
                    fgDirectNotfound(fgDirectNotfound.Rows.Count - 1, 0) = fgDirectNotfound.Rows.Count - 1
                    fgDirectNotfound(fgDirectNotfound.Rows.Count - 1, 1) = item.SalesCode
                    fgDirectNotfound(fgDirectNotfound.Rows.Count - 1, 2) = item.SalesName
                    fgDirectNotfound(fgDirectNotfound.Rows.Count - 1, 3) = item.ClientCode
                    fgDirectNotfound(fgDirectNotfound.Rows.Count - 1, 4) = item.ClientName
                    fgDirectNotfound(fgDirectNotfound.Rows.Count - 1, 5) = item.UnitBalance.ToString("n4")

                    lblDirectAccount.Text = CInt(lblDirectAccount.Text) + 1
                    lblDirectAccountNotfound.Text = CInt(lblDirectAccountNotfound.Text) + 1
                End If

                If pbNAV.Value = 100 Then pbNAV.Value = 0 Else pbNAV.Value += 1
            Next
            pbNAV.Value = 100
            fgDirectFound.AutoSizeCols()
            fgDirectNotfound.AutoSizeCols()
        End If
    End Sub

    Private Sub btnCopyFileNotFound_Click(sender As Object, e As EventArgs) Handles btnCopyFileNotFound.Click
        Dim myText As String = ""
        For i As Integer = fgFileNotfound.Rows.Fixed To fgFileNotfound.Rows.Count - 1
            For j As Integer = fgFileNotfound.Cols.Fixed To fgFileNotfound.Cols.Count - 1
                myText = myText & fgFileNotfound(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Sub btnCopySalesNotFound_Click(sender As Object, e As EventArgs) Handles btnCopySalesNotFound.Click
        Dim myText As String = ""
        For i As Integer = fgDistributorNotFound.Rows.Fixed To fgDistributorNotFound.Rows.Count - 1
            For j As Integer = fgDistributorNotFound.Cols.Fixed To fgDistributorNotFound.Cols.Count - 1
                myText = myText & fgDistributorNotFound(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Sub btnCopyFundNotFound_Click(sender As Object, e As EventArgs) Handles btnCopyFundNotFound.Click
        Dim myText As String = ""
        For i As Integer = fgDirectNotfound.Rows.Fixed To fgDirectNotfound.Rows.Count - 1
            For j As Integer = fgDirectNotfound.Cols.Fixed To fgDirectNotfound.Cols.Count - 1
                myText = myText & fgDirectNotfound(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Sub btnCopySalesNotRecon_Click(sender As Object, e As EventArgs) Handles btnCopySalesNotRecon.Click
        Dim myText As String = ""
        For i As Integer = fgDistributorFound.Rows.Fixed To fgDistributorFound.Rows.Count - 1
            If CDbl(fgDistributorFound(i, 7)) <> 0 Then
                For j As Integer = fgDistributorFound.Cols.Fixed To fgDistributorFound.Cols.Count - 1
                    myText = myText & fgDistributorFound(i, j) & Convert.ToString(ControlChars.Tab)
                Next
                myText = myText.TrimEnd(ControlChars.Tab)
                myText = myText & Convert.ToString(ControlChars.Lf)
            End If
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Sub btnCopyFundNotRecon_Click(sender As Object, e As EventArgs) Handles btnCopyFundNotRecon.Click
        Dim myText As String = ""
        For i As Integer = fgDirectFound.Rows.Fixed To fgDirectFound.Rows.Count - 1
            If CDbl(fgDirectFound(i, 7)) <> 0 Then
                For j As Integer = fgDirectFound.Cols.Fixed To fgDirectFound.Cols.Count - 1
                    myText = myText & fgDirectFound(i, j) & Convert.ToString(ControlChars.Tab)
                Next
                myText = myText.TrimEnd(ControlChars.Tab)
                myText = myText & Convert.ToString(ControlChars.Lf)
            End If
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

#End Region

End Class