Imports System.IO
Imports simpi.GlobalUtilities
Imports simpi.MasterClient
Imports simpi.MasterSales
Imports simpi.GlobalUtilities.GlobalDate
Imports simpi.GlobalUtilities.GlobalString

Public Class FormAccountCurrentKYCInstitutional
    Dim objSales As New MasterSales

    Dim objDistributor As New MasterSales
    Dim objDistributorExist As New MasterClientInstitution
    Dim objDistributorExistSub As New MasterClientInstitutionSub
    Dim objDistributorExistKYC As New MasterClient

    Dim objInstitution As New MasterClientInstitution
    Dim objInstitutionKYC As New MasterClient
    Dim objInstitutionSub As New MasterClientInstitutionSub
    Dim objInstitutionSubKYC As New MasterClient

    Dim objClientKYC As New ClientKYC

    Dim objDocument As New ClientDocument
    Dim objOfficer As New ClientOfficer

    Dim returnS, returnMsg As String
    Dim isExists As Boolean
    Dim SID, ClientCode, ClientName As String

    Private Sub FormCurrentKYCInstitutional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        lblSalesInternal.Text = objMasterSimpi.GetCodeset(8)
        GetParameterCountry()
        GetParameterCity()
        GetParameterClientRisk()
        GetParameterClientBusinessType()
        GetParameterClientBusinessActivity()
        GetParameterClientDocumentType()

        objSales.UserAccess = objAccess

        objDistributor.UserAccess = objAccess
        objDistributorExist.UserAccess = objAccess
        objDistributorExistSub.UserAccess = objAccess
        objDistributorExistKYC.UserAccess = objAccess

        objInstitution.UserAccess = objAccess
        objInstitutionKYC.UserAccess = objAccess
        objInstitutionSub.UserAccess = objAccess
        objInstitutionSubKYC.UserAccess = objAccess

        objClientKYC.UserAccess = objAccess

        objDocument.UserAccess = objAccess
        objOfficer.UserAccess = objAccess
    End Sub

    Private Sub setButton(ByVal buttonState As Boolean)
        btnBrowse.Enabled = buttonState
        btnRead.Enabled = buttonState
        txtFilename.Enabled = buttonState
        btnProcess.Enabled = buttonState
        btnSearchSales.Enabled = buttonState
        btnCopyDirect.Enabled = buttonState
        btnCopyDistributor.Enabled = buttonState
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
        lblRows.Text = ""
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
        If Not FileValidation() Then Exit Sub
        Try
            fgExcel.LoadExcel(txtFilename.Text, Trim(txtSheet.Text), C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            lblRows.Text = fgExcel.Rows.Count - 1
            getClient()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        getClient()
    End Sub

    Private Sub getClient()
        Cursor = Cursors.WaitCursor
        GetClientKYCUpdateInstitusi()
        GetSalesCodesetUpdate()
        lblClientKYC.Text = (From r In dtClientKYCInstitusi.AsEnumerable Select r.Field(Of Integer)("ClientID")).Count
        lblClientNo.Text = (From r In dtClientKYCInstitusi.AsEnumerable Select r.Field(Of Integer)("ClientID")).Distinct.Count
        Cursor = Cursors.Default
    End Sub

#End Region

#Region "process"
    Private Sub btnSearchSales_Click(sender As Object, e As EventArgs) Handles btnSearchSales.Click
        SalesSearch()
    End Sub

    Private Sub SalesSearch()
        Dim form As New FormSelectMasterSales
        form.Show()
        form.lblSalesCode = lblSalesCode
        form.lblSalesName = lblSalesName
        form.MdiParent = MDISO
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        setButton(False)
        bwProcess.RunWorkerAsync()
    End Sub

    Private Sub bwProcess_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwProcess.DoWork
        initDirect()
        initDistributor()
        DataProcess()
    End Sub

    Private Sub bwProcess_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bwProcess.RunWorkerCompleted
        setButton(True)
    End Sub

    Private Sub initDirect()
        With fgDirect
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDirect(0, 0) = "No"
            fgDirect(0, 1) = "S"
            fgDirect(0, 2) = "Error Msg"
            fgDirect(0, 3) = "SID"
            fgDirect(0, 4) = "CIF"
            fgDirect(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With

        With fgDirectNotExists
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDirectNotExists(0, 0) = "No"
            fgDirectNotExists(0, 1) = "S"
            fgDirectNotExists(0, 2) = "Error Msg"
            fgDirectNotExists(0, 3) = "SID"
            fgDirectNotExists(0, 4) = "CIF"
            fgDirectNotExists(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub initDistributor()
        With fgDistributor
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDistributor(0, 0) = "No"
            fgDistributor(0, 1) = "S"
            fgDistributor(0, 2) = "Error Msg"
            fgDistributor(0, 3) = "SID"
            fgDistributor(0, 4) = "CIF"
            fgDistributor(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
        With fgDistributorNew
            .Rows.Count = 1
            .Cols.Count = 6
            .ExtendLastCol = False
            fgDistributorNew(0, 0) = "No"
            fgDistributorNew(0, 1) = "S"
            fgDistributorNew(0, 2) = "Error Msg"
            fgDistributorNew(0, 3) = "SID"
            fgDistributorNew(0, 4) = "CIF"
            fgDistributorNew(0, 5) = "Name"
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            .SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
            .AutoSizeCols()
        End With
    End Sub

    Private Sub DataProcess()
        With fgExcel
            If .Rows.Count > 1 And lblKYCID.Text <> "" And lblSACodesetID.Text <> "" And lblSalesInternal.Text <> "" Then
                Dim rowClient(), rowSales() As DataRow
                Dim saCode As String = ""
                Dim t As String

                objSales.Clear()
                objSales.Load(objMasterSimpi, lblSalesCode.Text)
                If objSales.ErrID <> 0 Then
                    ExceptionMessage.Show(objSales.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                pbNAV.Value = 100
                lblLocal.Text = "0"
                lblForeign.Text = "0"
                lblDirectRows.Text = "0"
                lblDirectExisting.Text = "0"
                lblDirectFailed.Text = "0"
                lblDistributorRow.Text = "0"
                lblDistributorExisting.Text = "0"
                lblDistributorFailed.Text = "0"
                lblDistributorSucced.Text = "0"
                For i = 1 To .Rows.Count - 1
                    saCode = ""
                    If Not IsNothing(fgExcel(i, 2)) Then If fgExcel(i, 2).ToString.Trim <> "" Then saCode = fgExcel(i, 2).ToString.Trim
                    t = ""
                    If Not IsNothing(fgExcel(i, 7)) Then If fgExcel(i, 7).ToString.Trim <> "" Then t = fgExcel(i, 7).ToString.Trim

                    If saCode = lblSalesInternal.Text.Trim Then
                        lblDirectRows.Text = CInt(lblDirectRows.Text) + 1
                        ClientName = ""
                        If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then ClientName = fgExcel(i, 6).ToString.Trim
                        SID = ""
                        If Not IsNothing(fgExcel(i, 4)) Then If fgExcel(i, 4).ToString.Trim <> "" Then SID = fgExcel(i, 4).ToString.Trim
                        rowClient = dtClientKYCInstitusi.Select("kycAnswer = '" & SQLFix(SID) & "' And kycID = " & Str(CInt(lblKYCID.Text)))
                        If rowClient.Length = 0 Then
                            fgDirectNotExists.Rows.Add()
                            fgDirectNotExists(fgDirectNotExists.Rows.Count - 1, 0) = fgDirectNotExists.Rows.Count - 1
                            fgDirectNotExists(fgDirectNotExists.Rows.Count - 1, 1) = "NOT EXISTS"
                            fgDirectNotExists(fgDirectNotExists.Rows.Count - 1, 2) = ""
                            fgDirectNotExists(fgDirectNotExists.Rows.Count - 1, 3) = SID
                            fgDirectNotExists(fgDirectNotExists.Rows.Count - 1, 4) = ""
                            fgDirectNotExists(fgDirectNotExists.Rows.Count - 1, 5) = ClientName
                            lblDirectFailed.Text = CInt(lblDirectFailed.Text) + 1
                        Else
                            fgDirect.Rows.Add()
                            fgDirect(fgDirect.Rows.Count - 1, 0) = fgDirect.Rows.Count - 1
                            fgDirect(fgDirect.Rows.Count - 1, 1) = "EXISTS"
                            fgDirect(fgDirect.Rows.Count - 1, 2) = ""
                            fgDirect(fgDirect.Rows.Count - 1, 3) = SID
                            fgDirect(fgDirect.Rows.Count - 1, 4) = rowClient(0)("ClientCode")
                            fgDirect(fgDirect.Rows.Count - 1, 5) = ClientName
                            If t = "ID" Then lblLocal.Text = CInt(lblLocal.Text) + 1 Else lblForeign.Text = CInt(lblForeign.Text) + 1
                            lblDirectExisting.Text = CInt(lblDirectExisting.Text) + 1
                        End If

                    Else
                        lblDistributorRow.Text = CInt(lblDistributorRow.Text) + 1
                        ClientName = ""
                        If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then ClientName = fgExcel(i, 6).ToString.Trim
                        SID = ""
                        If Not IsNothing(fgExcel(i, 4)) Then If fgExcel(i, 4).ToString.Trim <> "" Then SID = fgExcel(i, 4).ToString.Trim

                        rowSales = dtSalesCodeset.Select("FieldData = '" & SQLFix(saCode) & "' And FieldID = " & Str(CInt(lblSACodesetID.Text)))
                        If rowSales.Length = 0 Then
                            fgDistributor.Rows.Add()
                            fgDistributor(fgDistributor.Rows.Count - 1, 0) = fgDistributor.Rows.Count - 1
                            fgDistributor(fgDistributor.Rows.Count - 1, 1) = "DISTRIBUTOR"
                            fgDistributor(fgDistributor.Rows.Count - 1, 2) = "sales not found"
                            fgDistributor(fgDistributor.Rows.Count - 1, 3) = SID
                            fgDistributor(fgDistributor.Rows.Count - 1, 4) = ""
                            fgDistributor(fgDistributor.Rows.Count - 1, 5) = ClientName
                            lblDistributorFailed.Text = CInt(lblDistributorFailed.Text) + 1
                        Else
                            ClientCode = _distributor(i, rowSales(0)("SalesCode"))
                            If isExists Then
                                fgDistributor.Rows.Add()
                                fgDistributor(fgDistributor.Rows.Count - 1, 0) = fgDistributor.Rows.Count - 1
                                fgDistributor(fgDistributor.Rows.Count - 1, 1) = "EXISTS"
                                fgDistributor(fgDistributor.Rows.Count - 1, 2) = ""
                                fgDistributor(fgDistributor.Rows.Count - 1, 3) = SID
                                fgDistributor(fgDistributor.Rows.Count - 1, 4) = ClientCode
                                fgDistributor(fgDistributor.Rows.Count - 1, 5) = ClientName
                                If t = "ID" Then lblLocal.Text = CInt(lblLocal.Text) + 1 Else lblForeign.Text = CInt(lblForeign.Text) + 1
                                lblDistributorExisting.Text = CInt(lblDistributorExisting.Text) + 1
                            ElseIf returnS = "" Then
                                fgDistributorNew.Rows.Add()
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 0) = fgDistributorNew.Rows.Count - 1
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 1) = ""
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 2) = ""
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 3) = SID
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 4) = ClientCode
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 5) = ClientName
                                If t = "ID" Then lblLocal.Text = CInt(lblLocal.Text) + 1 Else lblForeign.Text = CInt(lblForeign.Text) + 1
                                lblDistributorSucced.Text = CInt(lblDistributorSucced.Text) + 1
                            Else
                                fgDistributor.Rows.Add()
                                fgDistributor(fgDistributor.Rows.Count - 1, 0) = fgDistributor.Rows.Count - 1
                                fgDistributor(fgDistributor.Rows.Count - 1, 1) = returnS
                                fgDistributor(fgDistributor.Rows.Count - 1, 2) = returnMsg
                                fgDistributor(fgDistributor.Rows.Count - 1, 3) = SID
                                fgDistributor(fgDistributor.Rows.Count - 1, 4) = ""
                                fgDistributor(fgDistributor.Rows.Count - 1, 5) = ClientName
                                lblDistributorFailed.Text = CInt(lblDistributorFailed.Text) + 1
                            End If
                        End If

                    End If
                    If pbNAV.Value = 1 Then pbNAV.Value = 100 Else pbNAV.Value -= 1
                Next
                fgDirect.AutoSizeCols()
                fgDistributor.AutoSizeCols()
                pbNAV.Value = 0
            End If
        End With
    End Sub

    Private Sub btnCopyDirect_Click(sender As Object, e As EventArgs) Handles btnCopyDirect.Click
        Dim myText As String = ""
        For i As Integer = fgDirectNotExists.Rows.Fixed To fgDirectNotExists.Rows.Count - 1
            For j As Integer = fgDirectNotExists.Cols.Fixed To fgDirectNotExists.Cols.Count - 1
                myText = myText & fgDirectNotExists(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Sub btnCopyDistributor_Click(sender As Object, e As EventArgs) Handles btnCopyDistributor.Click
        Dim myText As String = ""
        For i As Integer = fgDistributorNew.Rows.Fixed To fgDistributorNew.Rows.Count - 1
            For j As Integer = fgDistributorNew.Cols.Fixed To fgDistributorNew.Cols.Count - 1
                myText = myText & fgDistributorNew(i, j) & Convert.ToString(ControlChars.Tab)
            Next
            myText = myText.TrimEnd(ControlChars.Tab)
            myText = myText & Convert.ToString(ControlChars.Lf)
        Next
        myText = myText.TrimEnd(ControlChars.Lf)
        If myText.Trim <> "" Then Clipboard.SetText(myText)
    End Sub

    Private Function _distributor(ByVal iRow As Integer, ByVal SalesCode As String) As String
        Dim ClientCode As String = ""
        Dim rowClient(), rowCity() As DataRow
        Dim riskID As Integer = 1
        Dim CountryID As Integer = 1
        Dim Province As String = "NA"
        Dim CountryCorrID As Integer = 1
        Dim ActivityID As Integer = 1
        Dim TypeID As Integer = 1
        Dim CityName As String = "NA"
        Dim LF As Char = "L"c
        Dim CorrPhone As String = ""
        Dim CorrAddress As String = ""
        Dim CorrCity As String = ""
        Dim CorrPostal As String = ""
        Dim CorrEmail As String = ""
        Dim TaxID As String = ""
        Dim tmp As String
        Dim dt As Date
        Dim exp As Byte
        Dim OfficerName As String = ""
        Dim OfficerTitle As String = ""
        Dim OfficerEmail As String = ""
        Dim OfficerPhone As String = ""
        Dim rowCountry(), rowCorr(), rowType(), rowActivity() As DataRow
        Dim rowRisk() As DataRow = Nothing

        tmp = ""
        If Not IsNothing(fgExcel(iRow, 7)) Then
            If fgExcel(iRow, 7).ToString.Trim <> "" Then
                tmp = fgExcel(iRow, 7).ToString.Trim
                If tmp = "ID" Then
                    LF = "L"c
                Else
                    LF = "F"c
                End If
            Else
                LF = "L"c
            End If
        End If
        rowCountry = dtParameterCountry.Select("CountryCode = '" & SQLFix(tmp) & "'")
        If rowCountry.Length > 0 Then CountryID = rowCountry(0)("CountryID")

        tmp = ""
        If Not IsNothing(fgExcel(iRow, 18)) Then If fgExcel(iRow, 18).ToString.Trim <> "" Then tmp = fgExcel(iRow, 18).ToString.Trim
        rowActivity = dtParameterClientBusinessActivity.Select("ActivityCode = '" & SQLFix(tmp) & "'")
        If rowActivity.Length > 0 Then ActivityID = rowActivity(0)("ActivityID")

        tmp = ""
        If Not IsNothing(fgExcel(iRow, 19)) Then If fgExcel(iRow, 19).ToString.Trim <> "" Then tmp = fgExcel(iRow, 19).ToString.Trim
        rowType = dtParameterClientBusinessType.Select("TypeCode = '" & SQLFix(tmp) & "'")
        If rowType.Length > 0 Then TypeID = rowType(0)("TypeID")

        If Not IsNothing(fgExcel(iRow, 12)) Then If fgExcel(iRow, 12).ToString.Trim <> "" Then TaxID = fgExcel(iRow, 12).ToString.Trim

        SID = ""
        If Not IsNothing(fgExcel(iRow, 4)) Then If fgExcel(iRow, 4).ToString.Trim <> "" Then SID = fgExcel(iRow, 4).ToString.Trim
        rowClient = dtClientKYCInstitusi.Select("kycAnswer = '" & SQLFix(SID) & "' And kycID = " & Str(CInt(lblKYCID.Text)))
        If rowClient.Length = 0 Then
            isExists = False

            tmp = ""
            If Not IsNothing(fgExcel(iRow, 29)) Then If fgExcel(iRow, 29).ToString.Trim <> "" Then tmp = fgExcel(iRow, 29).ToString.Trim
            rowCorr = dtParameterCountry.Select("CountryCode = '" & SQLFix(tmp) & "'")
            If rowCorr.Length > 0 Then
                CountryCorrID = rowCorr(0)("CountryID")

                tmp = ""
                If Not IsNothing(fgExcel(iRow, 26)) Then If fgExcel(iRow, 26).ToString.Trim <> "" Then tmp = fgExcel(iRow, 26).ToString.Trim
                rowCity = dtParameterCity.Select("CityCode = '" & SQLFix(tmp) & "' And CountryID = " & Str(CountryCorrID))
                If rowCity.Length > 0 Then
                    Province = rowCity(0)("Province")
                    CityName = rowCity(0)("CityName")
                End If
            End If

            tmp = ""
            If Not IsNothing(fgExcel(iRow, 21)) Then If fgExcel(iRow, 21).ToString.Trim <> "" Then tmp = fgExcel(iRow, 21).ToString.Trim
            rowRisk = dtParameterClientRisk.Select("RiskCode = '" & SQLFix(tmp) & "'")
            If rowRisk.Length > 1 Then riskID = rowRisk(0)("RiskID")

            If Not IsNothing(fgExcel(iRow, 25)) Then If fgExcel(iRow, 25).ToString.Trim <> "" Then CorrAddress = fgExcel(iRow, 25).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 28)) Then If fgExcel(iRow, 28).ToString.Trim <> "" Then CorrPostal = fgExcel(iRow, 28).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 30)) Then If fgExcel(iRow, 30).ToString.Trim <> "" Then CorrPhone = fgExcel(iRow, 30).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 32)) Then If fgExcel(iRow, 32).ToString.Trim <> "" Then CorrEmail = fgExcel(iRow, 32).ToString.Trim

            objInstitution.Clear()
            objInstitution.Add(objMasterSimpi, objSales, ClientName, CountryID, riskID, 1, LF, CorrAddress, CityName,
                               Province, CountryCorrID, CorrPostal, CorrPhone, CorrEmail, "", "", TaxID, TypeID, ActivityID)
            If objInstitution.ErrID = 0 Then
                returnS = ""
                returnMsg = ""

                objInstitutionKYC.Clear()
                objInstitutionKYC.Load(objMasterSimpi, objInstitution.GetClientCode)
                objClientKYC.Add(objInstitutionKYC, 41, SID) 'SID
                If Not IsNothing(fgExcel(iRow, 4)) Then If fgExcel(iRow, 4).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 41, fgExcel(iRow, 4)) 'SID
                If Not IsNothing(fgExcel(iRow, 7)) Then If fgExcel(iRow, 7).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 55, fgExcel(iRow, 7)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 13)) Then If fgExcel(iRow, 13).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 66, IIf(fgExcel(iRow, 13).ToString.Trim = "", Now, ConvertToDate(fgExcel(iRow, 13), "YMD"))) 'NPWP Registration Date 
                If Not IsNothing(fgExcel(iRow, 14)) Then If fgExcel(iRow, 14).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 60, fgExcel(iRow, 14)) 'Country of Establishment
                If Not IsNothing(fgExcel(iRow, 20)) Then If fgExcel(iRow, 20).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 34, fgExcel(iRow, 20)) 'Income Level (IDR)
                If Not IsNothing(fgExcel(iRow, 22)) Then If fgExcel(iRow, 22).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 47, fgExcel(iRow, 22)) 'Investment Objective
                If Not IsNothing(fgExcel(iRow, 23)) Then If fgExcel(iRow, 23).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 2, fgExcel(iRow, 23)) 'Source of Fund
                If Not IsNothing(fgExcel(iRow, 24)) Then If fgExcel(iRow, 24).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 44, fgExcel(iRow, 24)) 'Asset Owner
                If Not IsNothing(fgExcel(iRow, 31)) Then If fgExcel(iRow, 31).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 57, fgExcel(iRow, 31)) 'Facsimile
                If Not IsNothing(fgExcel(iRow, 33)) Then If fgExcel(iRow, 33).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 45, fgExcel(iRow, 33)) 'Statement Type
                If Not IsNothing(fgExcel(iRow, 56)) Then If fgExcel(iRow, 56).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 35, fgExcel(iRow, 56)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 57)) Then If fgExcel(iRow, 57).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 36, fgExcel(iRow, 57)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 58)) Then If fgExcel(iRow, 58).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 37, fgExcel(iRow, 58)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 59)) Then If fgExcel(iRow, 59).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 38, fgExcel(iRow, 59)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 60)) Then If fgExcel(iRow, 60).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 39, fgExcel(iRow, 60)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 61)) Then If fgExcel(iRow, 61).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 40, fgExcel(iRow, 61)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 62)) Then If fgExcel(iRow, 62).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 48, fgExcel(iRow, 62)) 'FATCA (Status)
                If Not IsNothing(fgExcel(iRow, 63)) Then If fgExcel(iRow, 63).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 58, fgExcel(iRow, 63)) 'TIN / Foreign TIN
                If Not IsNothing(fgExcel(iRow, 64)) Then If fgExcel(iRow, 64).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 59, fgExcel(iRow, 64)) 'TIN / Foreign TIN Issuance Country
                If Not IsNothing(fgExcel(iRow, 65)) Then If fgExcel(iRow, 65).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 62, fgExcel(iRow, 65)) 'GIIN
                If Not IsNothing(fgExcel(iRow, 66)) Then If fgExcel(iRow, 66).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 63, fgExcel(iRow, 66)) 'Substantial U.S. Owner Name
                If Not IsNothing(fgExcel(iRow, 67)) Then If fgExcel(iRow, 67).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 64, fgExcel(iRow, 67)) 'Substantial U.S. Owner Address
                If Not IsNothing(fgExcel(iRow, 68)) Then If fgExcel(iRow, 68).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 65, fgExcel(iRow, 68)) 'Substantial U.S. Owner TIN

                dt = New Date(1, 1, 1) 'SIUP
                exp = 0
                If Not IsNothing(fgExcel(iRow, 9)) Then
                    If fgExcel(iRow, 9).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 9), "YMD")
                        exp = 1
                    End If
                End If
                If Not IsNothing(fgExcel(iRow, 8)) Then If fgExcel(iRow, 8).ToString.Trim <> "" Then objDocument.Add(objInstitutionKYC, 2, fgExcel(iRow, 8).ToString.Trim, "", "", exp, dt)

                dt = New Date(1, 1, 1) 'SKD
                exp = 0
                If Not IsNothing(fgExcel(iRow, 11)) Then
                    If fgExcel(iRow, 11).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 11), "YMD")
                        exp = 1
                    End If
                End If
                If Not IsNothing(fgExcel(iRow, 10)) Then If fgExcel(iRow, 10).ToString.Trim <> "" Then objDocument.Add(objInstitutionKYC, 5, fgExcel(iRow, 10).ToString.Trim, "", "", exp, dt)

                dt = New Date(1, 1, 1) ''Articles of Association
                exp = 0
                If Not IsNothing(fgExcel(iRow, 16)) Then
                    If fgExcel(iRow, 16).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 16), "YMD")
                        exp = 1
                    End If
                End If
                tmp = ""
                If Not IsNothing(fgExcel(iRow, 15)) Then If fgExcel(iRow, 15).ToString.Trim <> "" Then tmp = fgExcel(iRow, 15).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 17)) Then If fgExcel(iRow, 17).ToString.Trim <> "" Then objDocument.Add(objInstitutionKYC, 6, fgExcel(iRow, 17).ToString.Trim, "", tmp, exp, dt)

                If Not IsNothing(fgExcel(iRow, 34)) Then If fgExcel(iRow, 34).ToString.Trim <> "" Then OfficerName = fgExcel(iRow, 34).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 35)) Then If fgExcel(iRow, 35).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 35).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 36)) Then If fgExcel(iRow, 36).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 36).ToString.Trim
                If OfficerName.Trim <> "" Then
                    If Not IsNothing(fgExcel(iRow, 37)) Then If fgExcel(iRow, 37).ToString.Trim <> "" Then OfficerTitle = fgExcel(iRow, 37).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 38)) Then If fgExcel(iRow, 38).ToString.Trim <> "" Then OfficerPhone = fgExcel(iRow, 38).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 39)) Then If fgExcel(iRow, 39).ToString.Trim <> "" Then OfficerEmail = fgExcel(iRow, 39).ToString.Trim
                    objOfficer.Add(objInstitutionKYC, OfficerName, OfficerTitle, OfficerEmail, OfficerPhone,
                                   New Date(1, 1, 1), 1, "", "", "", 1, "", "", 1, Now)
                    If Not IsNothing(fgExcel(iRow, 40)) Then If fgExcel(iRow, 40).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 68, fgExcel(iRow, 40)) 'NPWP
                    If Not IsNothing(fgExcel(iRow, 41)) Then If fgExcel(iRow, 41).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 5, fgExcel(iRow, 41)) 'KTP
                    If Not IsNothing(fgExcel(iRow, 42)) Then If fgExcel(iRow, 42).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 6, ConvertToDate(fgExcel(iRow, 42), "YMD")) 'Expired
                    If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 12, fgExcel(iRow, 43)) 'Paspor
                    If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 67, ConvertToDate(fgExcel(iRow, 44), "YMD")) 'Expired
                End If

                OfficerName = ""
                If Not IsNothing(fgExcel(iRow, 45)) Then If fgExcel(iRow, 45).ToString.Trim <> "" Then OfficerName = fgExcel(iRow, 45).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 46)) Then If fgExcel(iRow, 46).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 46).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 47)) Then If fgExcel(iRow, 47).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 47).ToString.Trim
                If OfficerName.Trim <> "" Then
                    If Not IsNothing(fgExcel(iRow, 48)) Then If fgExcel(iRow, 48).ToString.Trim <> "" Then OfficerTitle = fgExcel(iRow, 48).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 49)) Then If fgExcel(iRow, 49).ToString.Trim <> "" Then OfficerPhone = fgExcel(iRow, 49).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 50)) Then If fgExcel(iRow, 50).ToString.Trim <> "" Then OfficerEmail = fgExcel(iRow, 50).ToString.Trim
                    objOfficer.Add(objInstitutionKYC, OfficerName, OfficerTitle, OfficerEmail, OfficerPhone,
                                   New Date(1, 1, 1), 1, "", "", "", 1, "", "", 1, Now)
                    If Not IsNothing(fgExcel(iRow, 51)) Then If fgExcel(iRow, 51).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 69, fgExcel(iRow, 51)) 'NPWP
                    If Not IsNothing(fgExcel(iRow, 52)) Then If fgExcel(iRow, 52).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 70, fgExcel(iRow, 52)) 'KTP
                    If Not IsNothing(fgExcel(iRow, 53)) Then If fgExcel(iRow, 53).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 71, ConvertToDate(fgExcel(iRow, 42), "YMD"))  'Expired
                    If Not IsNothing(fgExcel(iRow, 54)) Then If fgExcel(iRow, 54).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 72, fgExcel(iRow, 54)) 'Paspor
                    If Not IsNothing(fgExcel(iRow, 55)) Then If fgExcel(iRow, 55).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionKYC, 73, ConvertToDate(fgExcel(iRow, 44), "YMD")) 'Expired
                End If

                objDistributor.Clear()
                objDistributor.Load(objMasterSimpi, SalesCode)
                objInstitutionSub.Clear()
                objInstitutionSub.Add(objInstitution, objDistributor, objInstitution.GetClientName, objInstitution.GetClientCcy.GetCountryID,
                        objInstitution.GetClientXRate.GetXRateID, objInstitution.GetLocalForeign, objInstitution.GetSignatureRule, objInstitution.GetTaxID,
                        objInstitution.GetBusinessType.GetTypeID, objInstitution.GetBusinessActivity.GetActivityID, objInstitution.GetClientName, "")
                ClientCode = objInstitutionSub.GetClientCode

                objInstitutionSubKYC.Clear()
                objInstitutionSubKYC.Load(objMasterSimpi, objInstitutionSub.GetClientCode)
                objClientKYC.Add(objInstitutionSubKYC, 41, SID) 'SID
                If Not IsNothing(fgExcel(iRow, 4)) Then If fgExcel(iRow, 4).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 41, fgExcel(iRow, 4)) 'SID
                If Not IsNothing(fgExcel(iRow, 7)) Then If fgExcel(iRow, 7).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 55, fgExcel(iRow, 7)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 13)) Then If fgExcel(iRow, 13).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 66, ConvertToDate(fgExcel(iRow, 13), "YMD")) 'NPWP Registration Date 
                If Not IsNothing(fgExcel(iRow, 14)) Then If fgExcel(iRow, 14).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 55, fgExcel(iRow, 14)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 20)) Then If fgExcel(iRow, 20).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 34, fgExcel(iRow, 20)) 'Income Level (IDR)
                If Not IsNothing(fgExcel(iRow, 22)) Then If fgExcel(iRow, 22).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 47, fgExcel(iRow, 22)) 'Investment Objective
                If Not IsNothing(fgExcel(iRow, 23)) Then If fgExcel(iRow, 23).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 2, fgExcel(iRow, 23)) 'Source of Fund
                If Not IsNothing(fgExcel(iRow, 24)) Then If fgExcel(iRow, 24).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 44, fgExcel(iRow, 24)) 'Asset Owner
                If Not IsNothing(fgExcel(iRow, 31)) Then If fgExcel(iRow, 31).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 57, fgExcel(iRow, 31)) 'Facsimile
                If Not IsNothing(fgExcel(iRow, 33)) Then If fgExcel(iRow, 33).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 45, fgExcel(iRow, 33)) 'Statement Type
                If Not IsNothing(fgExcel(iRow, 56)) Then If fgExcel(iRow, 56).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 35, fgExcel(iRow, 56)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 57)) Then If fgExcel(iRow, 57).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 36, fgExcel(iRow, 57)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 58)) Then If fgExcel(iRow, 58).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 37, fgExcel(iRow, 58)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 59)) Then If fgExcel(iRow, 59).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 38, fgExcel(iRow, 59)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 60)) Then If fgExcel(iRow, 60).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 39, fgExcel(iRow, 60)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 61)) Then If fgExcel(iRow, 61).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 40, fgExcel(iRow, 61)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 62)) Then If fgExcel(iRow, 62).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 48, fgExcel(iRow, 62)) 'FATCA (Status)
                If Not IsNothing(fgExcel(iRow, 63)) Then If fgExcel(iRow, 63).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 58, fgExcel(iRow, 63)) 'TIN / Foreign TIN
                If Not IsNothing(fgExcel(iRow, 64)) Then If fgExcel(iRow, 64).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 59, fgExcel(iRow, 64)) 'TIN / Foreign TIN Issuance Country
                If Not IsNothing(fgExcel(iRow, 65)) Then If fgExcel(iRow, 65).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 62, fgExcel(iRow, 65)) 'GIIN
                If Not IsNothing(fgExcel(iRow, 66)) Then If fgExcel(iRow, 66).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 63, fgExcel(iRow, 66)) 'Substantial U.S. Owner Name
                If Not IsNothing(fgExcel(iRow, 67)) Then If fgExcel(iRow, 67).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 64, fgExcel(iRow, 67)) 'Substantial U.S. Owner Address
                If Not IsNothing(fgExcel(iRow, 68)) Then If fgExcel(iRow, 68).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 65, fgExcel(iRow, 68)) 'Substantial U.S. Owner TIN

                dt = New Date(1, 1, 1) 'SIUP
                exp = 0
                If Not IsNothing(fgExcel(iRow, 9)) Then
                    If fgExcel(iRow, 9).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 9), "YMD")
                        exp = 1
                    End If
                End If
                If Not IsNothing(fgExcel(iRow, 8)) Then If fgExcel(iRow, 8).ToString.Trim <> "" Then objDocument.Add(objInstitutionSubKYC, 2, fgExcel(iRow, 8).ToString.Trim, "", "", exp, dt)

                dt = New Date(1, 1, 1) 'SKD
                exp = 0
                If Not IsNothing(fgExcel(iRow, 11)) Then
                    If fgExcel(iRow, 11).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 11), "YMD")
                        exp = 1
                    End If
                End If
                If Not IsNothing(fgExcel(iRow, 10)) Then If fgExcel(iRow, 10).ToString.Trim <> "" Then objDocument.Add(objInstitutionSubKYC, 5, fgExcel(iRow, 10).ToString.Trim, "", "", exp, dt)

                dt = New Date(1, 1, 1) ''Articles of Association
                exp = 0
                If Not IsNothing(fgExcel(iRow, 16)) Then
                    If fgExcel(iRow, 16).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 16), "YMD")
                        exp = 1
                    End If
                End If
                tmp = ""
                If Not IsNothing(fgExcel(iRow, 15)) Then If fgExcel(iRow, 15).ToString.Trim <> "" Then tmp = fgExcel(iRow, 15).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 17)) Then If fgExcel(iRow, 17).ToString.Trim <> "" Then objDocument.Add(objInstitutionSubKYC, 6, fgExcel(iRow, 17).ToString.Trim, "", tmp, exp, dt)

                If Not IsNothing(fgExcel(iRow, 34)) Then If fgExcel(iRow, 34).ToString.Trim <> "" Then OfficerName = fgExcel(iRow, 34).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 35)) Then If fgExcel(iRow, 35).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 35).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 36)) Then If fgExcel(iRow, 36).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 36).ToString.Trim
                If OfficerName.Trim <> "" Then
                    If Not IsNothing(fgExcel(iRow, 37)) Then If fgExcel(iRow, 37).ToString.Trim <> "" Then OfficerTitle = fgExcel(iRow, 37).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 38)) Then If fgExcel(iRow, 38).ToString.Trim <> "" Then OfficerPhone = fgExcel(iRow, 38).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 39)) Then If fgExcel(iRow, 39).ToString.Trim <> "" Then OfficerEmail = fgExcel(iRow, 39).ToString.Trim
                    objOfficer.Add(objInstitutionSubKYC, OfficerName, OfficerTitle, OfficerEmail, OfficerPhone,
                                   New Date(1, 1, 1), 1, "", "", "", 1, "", "", 1, Now)
                    If Not IsNothing(fgExcel(iRow, 40)) Then If fgExcel(iRow, 40).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 68, fgExcel(iRow, 40)) 'NPWP
                    If Not IsNothing(fgExcel(iRow, 41)) Then If fgExcel(iRow, 41).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 5, fgExcel(iRow, 41)) 'KTP
                    If Not IsNothing(fgExcel(iRow, 42)) Then If fgExcel(iRow, 42).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 6, ConvertToDate(fgExcel(iRow, 42), "YMD")) 'Expired
                    If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 12, fgExcel(iRow, 43)) 'Paspor
                    If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 67, ConvertToDate(fgExcel(iRow, 44), "YMD")) 'Expired
                End If

                OfficerName = ""
                If Not IsNothing(fgExcel(iRow, 45)) Then If fgExcel(iRow, 45).ToString.Trim <> "" Then OfficerName = fgExcel(iRow, 45).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 46)) Then If fgExcel(iRow, 46).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 46).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 47)) Then If fgExcel(iRow, 47).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 47).ToString.Trim
                If OfficerName.Trim <> "" Then
                    If Not IsNothing(fgExcel(iRow, 48)) Then If fgExcel(iRow, 48).ToString.Trim <> "" Then OfficerTitle = fgExcel(iRow, 48).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 49)) Then If fgExcel(iRow, 49).ToString.Trim <> "" Then OfficerPhone = fgExcel(iRow, 49).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 50)) Then If fgExcel(iRow, 50).ToString.Trim <> "" Then OfficerEmail = fgExcel(iRow, 50).ToString.Trim
                    objOfficer.Add(objInstitutionSubKYC, OfficerName, OfficerTitle, OfficerEmail, OfficerPhone,
                                   New Date(1, 1, 1), 1, "", "", "", 1, "", "", 1, Now)
                    If Not IsNothing(fgExcel(iRow, 51)) Then If fgExcel(iRow, 51).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 69, fgExcel(iRow, 51)) 'NPWP
                    If Not IsNothing(fgExcel(iRow, 52)) Then If fgExcel(iRow, 52).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 70, fgExcel(iRow, 52)) 'KTP
                    If Not IsNothing(fgExcel(iRow, 53)) Then If fgExcel(iRow, 53).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 71, ConvertToDate(fgExcel(iRow, 42), "YMD"))  'Expired
                    If Not IsNothing(fgExcel(iRow, 54)) Then If fgExcel(iRow, 54).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 72, fgExcel(iRow, 54)) 'Paspor
                    If Not IsNothing(fgExcel(iRow, 55)) Then If fgExcel(iRow, 55).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 73, ConvertToDate(fgExcel(iRow, 44), "YMD")) 'Expired
                End If

            Else
                returnS = "Failed"
                returnMsg = objInstitution.ErrMsg
            End If
        Else
            objDistributor.Clear()
            objDistributor.Load(objMasterSimpi, SalesCode)

            objInstitutionKYC.Clear()
            objInstitutionKYC.LoadDistributor(objMasterSimpi, objDistributor, CInt(lblKYCID.Text), SID)
            If objInstitutionKYC.ErrID = 0 Then
                ClientCode = objInstitutionKYC.GetClientCode
                isExists = True
            Else
                isExists = False

                objInstitution.Clear()
                objInstitution.LoadInternal(objMasterSimpi, CInt(lblKYCID.Text), SID)
                objInstitutionSub.Clear()
                objInstitutionSub.Add(objInstitution, objDistributor, ClientName, CountryID, 1, LF, "", TaxID, TypeID, ActivityID, ClientName, "")
                ClientCode = objInstitutionSub.GetClientCode

                objInstitutionSubKYC.Clear()
                objInstitutionSubKYC.Load(objMasterSimpi, objInstitutionSub.GetClientCode)
                objClientKYC.Add(objInstitutionSubKYC, 41, SID) 'SID
                If Not IsNothing(fgExcel(iRow, 4)) Then If fgExcel(iRow, 4).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 41, fgExcel(iRow, 4)) 'SID
                If Not IsNothing(fgExcel(iRow, 7)) Then If fgExcel(iRow, 7).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 55, fgExcel(iRow, 7)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 13)) Then If fgExcel(iRow, 13).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 66, ConvertToDate(fgExcel(iRow, 13), "YMD")) 'NPWP Registration Date 
                If Not IsNothing(fgExcel(iRow, 14)) Then If fgExcel(iRow, 14).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 55, fgExcel(iRow, 14)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 20)) Then If fgExcel(iRow, 20).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 34, fgExcel(iRow, 20)) 'Income Level (IDR)
                If Not IsNothing(fgExcel(iRow, 22)) Then If fgExcel(iRow, 22).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 47, fgExcel(iRow, 22)) 'Investment Objective
                If Not IsNothing(fgExcel(iRow, 23)) Then If fgExcel(iRow, 23).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 2, fgExcel(iRow, 23)) 'Source of Fund
                If Not IsNothing(fgExcel(iRow, 24)) Then If fgExcel(iRow, 24).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 44, fgExcel(iRow, 24)) 'Asset Owner
                If Not IsNothing(fgExcel(iRow, 31)) Then If fgExcel(iRow, 31).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 57, fgExcel(iRow, 31)) 'Facsimile
                If Not IsNothing(fgExcel(iRow, 33)) Then If fgExcel(iRow, 33).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 45, fgExcel(iRow, 33)) 'Statement Type
                If Not IsNothing(fgExcel(iRow, 56)) Then If fgExcel(iRow, 56).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 35, fgExcel(iRow, 56)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 57)) Then If fgExcel(iRow, 57).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 36, fgExcel(iRow, 57)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 58)) Then If fgExcel(iRow, 58).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 37, fgExcel(iRow, 58)) 'Asset Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 59)) Then If fgExcel(iRow, 59).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 38, fgExcel(iRow, 59)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 60)) Then If fgExcel(iRow, 60).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 39, fgExcel(iRow, 60)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 61)) Then If fgExcel(iRow, 61).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 40, fgExcel(iRow, 61)) 'Profit Information for the Past 3 Years (IDR) - Last Year
                If Not IsNothing(fgExcel(iRow, 62)) Then If fgExcel(iRow, 62).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 48, fgExcel(iRow, 62)) 'FATCA (Status)
                If Not IsNothing(fgExcel(iRow, 63)) Then If fgExcel(iRow, 63).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 58, fgExcel(iRow, 63)) 'TIN / Foreign TIN
                If Not IsNothing(fgExcel(iRow, 64)) Then If fgExcel(iRow, 64).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 59, fgExcel(iRow, 64)) 'TIN / Foreign TIN Issuance Country
                If Not IsNothing(fgExcel(iRow, 65)) Then If fgExcel(iRow, 65).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 62, fgExcel(iRow, 65)) 'GIIN
                If Not IsNothing(fgExcel(iRow, 66)) Then If fgExcel(iRow, 66).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 63, fgExcel(iRow, 66)) 'Substantial U.S. Owner Name
                If Not IsNothing(fgExcel(iRow, 67)) Then If fgExcel(iRow, 67).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 64, fgExcel(iRow, 67)) 'Substantial U.S. Owner Address
                If Not IsNothing(fgExcel(iRow, 68)) Then If fgExcel(iRow, 68).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 65, fgExcel(iRow, 68)) 'Substantial U.S. Owner TIN

                dt = New Date(1, 1, 1) 'SIUP
                exp = 0
                If Not IsNothing(fgExcel(iRow, 9)) Then
                    If fgExcel(iRow, 9).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 9), "YMD")
                        exp = 1
                    End If
                End If
                If Not IsNothing(fgExcel(iRow, 8)) Then If fgExcel(iRow, 8).ToString.Trim <> "" Then objDocument.Add(objInstitutionSubKYC, 2, fgExcel(iRow, 8).ToString.Trim, "", "", exp, dt)

                dt = New Date(1, 1, 1) 'SKD
                exp = 0
                If Not IsNothing(fgExcel(iRow, 11)) Then
                    If fgExcel(iRow, 11).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 11), "YMD")
                        exp = 1
                    End If
                End If
                If Not IsNothing(fgExcel(iRow, 10)) Then If fgExcel(iRow, 10).ToString.Trim <> "" Then objDocument.Add(objInstitutionSubKYC, 5, fgExcel(iRow, 10).ToString.Trim, "", "", exp, dt)

                dt = New Date(1, 1, 1) ''Articles of Association
                exp = 0
                If Not IsNothing(fgExcel(iRow, 16)) Then
                    If fgExcel(iRow, 16).ToString.Trim <> "" Then
                        dt = ConvertToDate(fgExcel(iRow, 16), "YMD")
                        exp = 1
                    End If
                End If
                tmp = ""
                If Not IsNothing(fgExcel(iRow, 15)) Then If fgExcel(iRow, 15).ToString.Trim <> "" Then tmp = fgExcel(iRow, 15).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 17)) Then If fgExcel(iRow, 17).ToString.Trim <> "" Then objDocument.Add(objInstitutionSubKYC, 6, fgExcel(iRow, 17).ToString.Trim, "", tmp, exp, dt)

                If Not IsNothing(fgExcel(iRow, 34)) Then If fgExcel(iRow, 34).ToString.Trim <> "" Then OfficerName = fgExcel(iRow, 34).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 35)) Then If fgExcel(iRow, 35).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 35).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 36)) Then If fgExcel(iRow, 36).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 36).ToString.Trim
                If OfficerName.Trim <> "" Then
                    If Not IsNothing(fgExcel(iRow, 37)) Then If fgExcel(iRow, 37).ToString.Trim <> "" Then OfficerTitle = fgExcel(iRow, 37).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 38)) Then If fgExcel(iRow, 38).ToString.Trim <> "" Then OfficerPhone = fgExcel(iRow, 38).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 39)) Then If fgExcel(iRow, 39).ToString.Trim <> "" Then OfficerEmail = fgExcel(iRow, 39).ToString.Trim
                    objOfficer.Add(objInstitutionSubKYC, OfficerName, OfficerTitle, OfficerEmail, OfficerPhone,
                                   New Date(1, 1, 1), 1, "", "", "", 1, "", "", 1, Now)
                    If Not IsNothing(fgExcel(iRow, 40)) Then If fgExcel(iRow, 40).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 68, fgExcel(iRow, 40)) 'NPWP
                    If Not IsNothing(fgExcel(iRow, 41)) Then If fgExcel(iRow, 41).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 5, fgExcel(iRow, 41)) 'KTP
                    If Not IsNothing(fgExcel(iRow, 42)) Then If fgExcel(iRow, 42).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 6, ConvertToDate(fgExcel(iRow, 42), "YMD")) 'Expired
                    If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 12, fgExcel(iRow, 43)) 'Paspor
                    If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 67, ConvertToDate(fgExcel(iRow, 44), "YMD")) 'Expired
                End If

                OfficerName = ""
                If Not IsNothing(fgExcel(iRow, 45)) Then If fgExcel(iRow, 45).ToString.Trim <> "" Then OfficerName = fgExcel(iRow, 45).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 46)) Then If fgExcel(iRow, 46).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 46).ToString.Trim
                If Not IsNothing(fgExcel(iRow, 47)) Then If fgExcel(iRow, 47).ToString.Trim <> "" Then OfficerName = OfficerName & " " & fgExcel(iRow, 47).ToString.Trim
                If OfficerName.Trim <> "" Then
                    If Not IsNothing(fgExcel(iRow, 48)) Then If fgExcel(iRow, 48).ToString.Trim <> "" Then OfficerTitle = fgExcel(iRow, 48).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 49)) Then If fgExcel(iRow, 49).ToString.Trim <> "" Then OfficerPhone = fgExcel(iRow, 49).ToString.Trim
                    If Not IsNothing(fgExcel(iRow, 50)) Then If fgExcel(iRow, 50).ToString.Trim <> "" Then OfficerEmail = fgExcel(iRow, 50).ToString.Trim
                    objOfficer.Add(objInstitutionSubKYC, OfficerName, OfficerTitle, OfficerEmail, OfficerPhone,
                                   New Date(1, 1, 1), 1, "", "", "", 1, "", "", 1, Now)
                    If Not IsNothing(fgExcel(iRow, 51)) Then If fgExcel(iRow, 51).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 69, fgExcel(iRow, 51)) 'NPWP
                    If Not IsNothing(fgExcel(iRow, 52)) Then If fgExcel(iRow, 52).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 70, fgExcel(iRow, 52)) 'KTP
                    If Not IsNothing(fgExcel(iRow, 53)) Then If fgExcel(iRow, 53).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 71, ConvertToDate(fgExcel(iRow, 42), "YMD"))  'Expired
                    If Not IsNothing(fgExcel(iRow, 54)) Then If fgExcel(iRow, 54).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 72, fgExcel(iRow, 54)) 'Paspor
                    If Not IsNothing(fgExcel(iRow, 55)) Then If fgExcel(iRow, 55).ToString.Trim <> "" Then objClientKYC.Add(objInstitutionSubKYC, 73, ConvertToDate(fgExcel(iRow, 44), "YMD")) 'Expired
                End If
            End If
        End If
        Return ClientCode
    End Function

#End Region

End Class