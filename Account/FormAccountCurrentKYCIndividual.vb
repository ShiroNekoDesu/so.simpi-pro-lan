Imports System.IO
Imports simpi.globalutilities
Imports simpi.MasterClient
Imports simpi.MasterSales
Imports simpi.GlobalUtilities.GlobalDate
Imports simpi.GlobalUtilities.GlobalString

Public Class FormAccountCurrentKYCIndividual
    Dim objSalesDefault As New MasterSales
    Dim objSalesDistributor As New MasterSales

    Dim objDirectKYC As New ClientKYC
    Dim objClientKYC As New ClientKYC

    Dim objDistributorExist As New MasterClientIndividu
    Dim objIndividu As New MasterClientIndividu
    Dim objDistributorExistSub As New MasterClientIndividuSub
    Dim objIndividuSub As New MasterClientIndividuSub
    Dim objDistributorExistKYC As New MasterClient
    Dim objIndividuKYC As New MasterClient
    Dim objIndividuSubKYC As New MasterClient

    Dim returnS, returnMsg As String
    Dim isExists As Boolean
    Dim dateExpired As Date
    Dim SID, ClientCode, ClientName As String

    Private Sub FormCurrentKYCIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetMasterSimpi()
        lblSalesInternal.Text = objMasterSimpi.GetCodeset(8)
        GetParameterCountry()
        GetParameterClientRisk()
        GetParameterCity()
        GetParameterClientReligion()
        GetParameterClientEducationLevel()
        GetParameterClientOccupation()
        GetParameterClientMarital()

        objSalesDefault.UserAccess = objAccess
        objDirectKYC.UserAccess = objAccess

        objSalesDistributor.UserAccess = objAccess
        objDistributorExist.UserAccess = objAccess
        objDistributorExistSub.UserAccess = objAccess
        objDistributorExistKYC.UserAccess = objAccess

        objIndividu.UserAccess = objAccess
        objIndividuKYC.UserAccess = objAccess
        objIndividuSub.UserAccess = objAccess
        objIndividuSubKYC.UserAccess = objAccess

        objClientKYC.UserAccess = objAccess
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
            fgExcel.AutoSizeCols()
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
        GetClientKYCUpdateIndividu()
        GetSalesCodesetUpdate()
        lblClientKYC.Text = (From r In dtClientKYCIndividu.AsEnumerable Select r.Field(Of Integer)("ClientID")).Count
        lblClientNo.Text = (From r In dtClientKYCIndividu.AsEnumerable Select r.Field(Of Integer)("ClientID")).Distinct.Count
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
        form.lblSalesCode = lblDefaultSalesCode
        form.lblSalesName = lblDefaultSalesName
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
                Dim saCode As String
                Dim nationality As String
                objSalesDefault.Clear()
                objSalesDefault.Load(objMasterSimpi, lblDefaultSalesCode.Text)
                If objSalesDefault.ErrID <> 0 Then
                    ExceptionMessage.Show(objSalesDefault.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    nationality = ""
                    If Not IsNothing(fgExcel(i, 9)) Then If fgExcel(i, 9).ToString.Trim <> "" Then nationality = fgExcel(i, 9).ToString.Trim

                    If saCode = lblSalesInternal.Text.Trim Then
                        lblDirectRows.Text = CInt(lblDirectRows.Text) + 1
                        ClientName = ""
                        If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then ClientName = fgExcel(i, 6).ToString.Trim
                        If Not IsNothing(fgExcel(i, 7)) Then If fgExcel(i, 7).ToString.Trim <> "" Then ClientName = ClientName & " " & fgExcel(i, 7).ToString.Trim
                        If Not IsNothing(fgExcel(i, 8)) Then If fgExcel(i, 8).ToString.Trim <> "" Then ClientName = ClientName & " " & fgExcel(i, 8).ToString.Trim
                        SID = ""
                        If Not IsNothing(fgExcel(i, 4)) Then If fgExcel(i, 4).ToString.Trim <> "" Then SID = fgExcel(i, 4).ToString.Trim
                        rowClient = dtClientKYCIndividu.Select("kycAnswer = '" & SQLFix(SID) & "' And kycID = " & Str(CInt(lblKYCID.Text)))
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
                            If nationality = "ID" Then lblLocal.Text = CInt(lblLocal.Text) + 1 Else lblForeign.Text = CInt(lblForeign.Text) + 1
                            lblDirectExisting.Text = CInt(lblDirectExisting.Text) + 1
                        End If

                    Else
                        lblDistributorRow.Text = CInt(lblDistributorRow.Text) + 1
                        ClientName = ""
                        If Not IsNothing(fgExcel(i, 6)) Then If fgExcel(i, 6).ToString.Trim <> "" Then ClientName = fgExcel(i, 6).ToString.Trim
                        If Not IsNothing(fgExcel(i, 7)) Then If fgExcel(i, 7).ToString.Trim <> "" Then ClientName = ClientName & " " & fgExcel(i, 7).ToString.Trim
                        If Not IsNothing(fgExcel(i, 8)) Then If fgExcel(i, 8).ToString.Trim <> "" Then ClientName = ClientName & " " & fgExcel(i, 8).ToString.Trim
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
                                lblDistributorExisting.Text = CInt(lblDistributorExisting.Text) + 1
                                If nationality = "ID" Then lblLocal.Text = CInt(lblLocal.Text) + 1 Else lblForeign.Text = CInt(lblForeign.Text) + 1
                            ElseIf returnS = "" Then
                                fgDistributorNew.Rows.Add()
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 0) = fgDistributorNew.Rows.Count - 1
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 1) = ""
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 2) = ""
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 3) = SID
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 4) = ClientCode
                                fgDistributorNew(fgDistributorNew.Rows.Count - 1, 5) = ClientName
                                lblDistributorSucced.Text = CInt(lblDistributorSucced.Text) + 1
                                If nationality = "ID" Then lblLocal.Text = CInt(lblLocal.Text) + 1 Else lblForeign.Text = CInt(lblForeign.Text) + 1
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

    Private Sub btnDirectExists_Click(sender As Object, e As EventArgs) Handles btnDirectExists.Click
        With fgDirectNotExists
            If .Rows.Count > 1 And lblKYCID.Text <> "" Then
                For i = 1 To .Rows.Count - 1
                    If fgDirectNotExists(i, 1) = "NOT EXISTS" Then
                        objDirectKYC.Clear()
                        objDirectKYC.Load(objMasterSimpi, CInt(lblKYCID.Text), fgDirectNotExists(i, 3))
                        If objDirectKYC.ErrID = 0 Then
                            fgDirectNotExists(i, 1) = "EXISTS"
                            fgDirectNotExists(i, 2) = ""
                            fgDirectNotExists(i, 4) = objDirectKYC.GetMasterClient.GetClientCode
                            lblDirectExisting.Text = CInt(lblDirectExisting.Text) + 1
                        End If
                    End If
                Next
            End If
        End With
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

    Private Function _distributor(ByVal iRow As Integer, ByVal SalesCode As String) As String
        Dim ClientCode As String = ""
        Dim rowClient(), rowCity() As DataRow
        Dim riskID As Integer = 1
        Dim CountryID As Integer = 1
        Dim Province As String = "NA"
        Dim CountryCorrID As Integer = 1
        Dim ReligionID As Integer = 1
        Dim EducationID As Integer = 1
        Dim OccupationID As Integer = 1
        Dim MaritalID As Integer = 1
        Dim CityName As String = "NA"
        Dim NameFirst As String = ""
        Dim NameMiddle As String = ""
        Dim NameLast As String = ""
        Dim MMN As String = "MMN"
        Dim CorrPhone As String = ""
        Dim CorrAddress As String = ""
        Dim CorrCity As String = ""
        Dim CorrPostal As String = ""
        Dim CorrEmail As String = ""
        Dim SpouseName As String = ""
        Dim LF As Char = "L"c
        Dim birthPlace As String = ""
        Dim birthDate As Date = Now
        Dim TaxID As String = ""
        Dim Gender As Char = "M"c
        Dim IDCardTypeID As Integer = 1
        Dim IDCardNo As String = ""
        Dim IDCardExpired As Byte = 1
        Dim tmp As String

        SID = ""
        If Not IsNothing(fgExcel(iRow, 4)) Then If fgExcel(iRow, 4).ToString.Trim <> "" Then SID = fgExcel(iRow, 4).ToString.Trim
        rowClient = dtClientKYCIndividu.Select("kycAnswer = '" & SQLFix(SID) & "' And kycID = " & Str(CInt(lblKYCID.Text)))
        If rowClient.Length = 0 Then
            isExists = False
            Dim rowCountry(), rowCorr(), rowReligion(), rowEducation(), rowOccupation(), rowMarital(), rowKTP() As DataRow
            Dim rowRisk() As DataRow = Nothing

            If Not IsNothing(fgExcel(iRow, 6)) Then If fgExcel(iRow, 6).ToString.Trim <> "" Then NameFirst = fgExcel(iRow, 6).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 7)) Then If fgExcel(iRow, 7).ToString.Trim <> "" Then NameMiddle = fgExcel(iRow, 7).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 8)) Then If fgExcel(iRow, 8).ToString.Trim <> "" Then NameLast = fgExcel(iRow, 8).ToString.Trim

            tmp = ""
            If Not IsNothing(fgExcel(iRow, 9)) Then
                If fgExcel(iRow, 9).ToString.Trim <> "" Then
                    tmp = fgExcel(iRow, 9).ToString.Trim
                    If tmp = "ID" Then
                        LF = "L"c
                        IDCardTypeID = 1
                    Else
                        LF = "F"c
                        IDCardTypeID = 2
                    End If
                Else
                    LF = "L"c
                    IDCardTypeID = 1
                End If
            End If
            rowCountry = dtParameterCountry.Select("CountryCode = '" & SQLFix(tmp) & "'")
            If rowCountry.Length > 0 Then
                CountryID = rowCountry(0)("CountryID")
                tmp = ""
                If Not IsNothing(fgExcel(iRow, 31)) Then If fgExcel(iRow, 31).ToString.Trim <> "" Then tmp = fgExcel(iRow, 31).ToString.Trim
                rowKTP = dtParameterCity.Select("CityCode = '" & SQLFix(tmp) & "' And CountryID = " & Str(CountryID))
                If rowKTP.Length > 0 Then CityName = rowKTP(0)("CityName").ToString.Trim
            End If
            If Not IsNothing(fgExcel(iRow, 11)) Then If fgExcel(iRow, 11).ToString.Trim <> "" Then IDCardNo = fgExcel(iRow, 11).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 12)) Then If fgExcel(iRow, 12).ToString.Trim = "" Then IDCardExpired = 2
            dateExpired = New Date(1900, 12, 31)
            If Not IsNothing(fgExcel(iRow, 12)) Then If fgExcel(iRow, 12).ToString.Trim <> "" Then dateExpired = ConvertToDate(fgExcel(iRow, 12).ToString.Trim, "YMD")

            If Not IsNothing(fgExcel(iRow, 13)) Then If fgExcel(iRow, 13).ToString.Trim <> "" Then TaxID = fgExcel(iRow, 13).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 16)) Then If fgExcel(iRow, 16).ToString.Trim <> "" Then birthPlace = fgExcel(iRow, 16).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 17)) Then If fgExcel(iRow, 17).ToString.Trim <> "" Then birthDate = ConvertToDate(fgExcel(iRow, 17).ToString.Trim, "YMD")
            If Not IsNothing(fgExcel(iRow, 18)) Then If fgExcel(iRow, 18).ToString.Trim <> "" Then Gender = Mid(fgExcel(iRow, 18).ToString.Trim, 1, 1)

            If Not IsNothing(fgExcel(iRow, 19)) Then
                If fgExcel(iRow, 19).ToString.Trim <> "" Then
                    rowEducation = dtParameterClientEducationLevel.Select("LevelCode = '" & SQLFix(fgExcel(iRow, 19).ToString.Trim) & "'")
                    If rowEducation.Length > 0 Then EducationID = rowEducation(0)("LevelID")
                End If
            End If

            If Not IsNothing(fgExcel(iRow, 20)) Then If fgExcel(iRow, 20).ToString.Trim <> "" Then MMN = fgExcel(iRow, 20).ToString.Trim

            If Not IsNothing(fgExcel(iRow, 21)) Then
                If fgExcel(iRow, 21).ToString.Trim <> "" Then
                    rowReligion = dtParameterClientReligion.Select("ReligionCode = '" & SQLFix(fgExcel(iRow, 21).ToString.Trim) & "'")
                    If rowReligion.Length > 0 Then ReligionID = rowReligion(0)("ReligionID")
                End If
            End If

            If Not IsNothing(fgExcel(iRow, 22)) Then
                If fgExcel(iRow, 22).ToString.Trim <> "" Then
                    rowOccupation = dtParameterClientOccupation.Select("OccupationCode = '" & SQLFix(fgExcel(iRow, 22).ToString.Trim) & "'")
                    If rowOccupation.Length > 0 Then OccupationID = rowOccupation(0)("OccupationID")
                End If
            End If

            If Not IsNothing(fgExcel(iRow, 24)) Then
                If fgExcel(iRow, 24).ToString.Trim <> "" Then
                    rowMarital = dtParameterClientMarital.Select("StatusCode = '" & SQLFix(fgExcel(iRow, 24).ToString.Trim) & "'")
                    If rowMarital.Length > 0 Then MaritalID = rowMarital(0)("StatusID")
                End If
            End If

            If Not IsNothing(fgExcel(iRow, 25)) Then If fgExcel(iRow, 25).ToString.Trim <> "" Then SpouseName = fgExcel(iRow, 25).ToString.Trim

            If Not IsNothing(fgExcel(iRow, 26)) Then
                If fgExcel(iRow, 26).ToString.Trim <> "" Then
                    rowRisk = dtParameterClientRisk.Select("RiskCode = '" & SQLFix(fgExcel(iRow, 26).ToString.Trim) & "'")
                    If rowRisk.Length > 0 Then riskID = rowRisk(0)("RiskID")
                End If
            End If

            If Not IsNothing(fgExcel(iRow, 37)) Then
                rowCorr = dtParameterCountry.Select("CountryCode = '" & SQLFix(fgExcel(iRow, 37).ToString.Trim) & "'")
                If rowCorr.Length > 0 Then
                    CountryCorrID = rowCorr(0)("CountryID")

                    tmp = ""
                    If Not IsNothing(fgExcel(iRow, 34)) Then If fgExcel(iRow, 34).ToString.Trim <> "" Then tmp = fgExcel(iRow, 34).ToString.Trim
                    rowCity = dtParameterCity.Select("CityCode = '" & SQLFix(tmp) & "' And CountryID = " & Str(CountryCorrID))
                    If rowCity.Length > 0 Then Province = rowCity(0)("Province")

                    If Not IsNothing(fgExcel(iRow, 35)) Then If fgExcel(iRow, 35).ToString.Trim <> "" Then CorrCity = fgExcel(iRow, 35).ToString.Trim
                    If CorrCity.Trim = "" Then
                        tmp = ""
                        If Not IsNothing(fgExcel(iRow, 34)) Then If fgExcel(iRow, 34).ToString.Trim <> "" Then tmp = fgExcel(iRow, 34).ToString.Trim
                        rowKTP = dtParameterCity.Select("CityCode = '" & SQLFix(tmp) & "' And CountryID = " & Str(CountryCorrID))
                        If rowKTP.Length > 0 Then CorrCity = rowKTP(0)("CityName").ToString.Trim
                    End If
                End If
            End If
            If Not IsNothing(fgExcel(iRow, 33)) Then If fgExcel(iRow, 33).ToString.Trim <> "" Then CorrAddress = fgExcel(iRow, 33).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 36)) Then If fgExcel(iRow, 36).ToString.Trim <> "" Then CorrPostal = fgExcel(iRow, 36).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then CorrPhone = fgExcel(iRow, 43).ToString.Trim
            If CorrPhone.Trim = "" Then If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then CorrPhone = fgExcel(iRow, 44).ToString.Trim
            If Not IsNothing(fgExcel(iRow, 46)) Then If fgExcel(iRow, 46).ToString.Trim <> "" Then CorrEmail = fgExcel(iRow, 46).ToString.Trim

            objIndividu.Clear()
            objIndividu.Add(objMasterSimpi, objSalesDefault, ClientName, CountryID, riskID, 1, LF, CorrAddress, CorrCity, Province, CountryCorrID,
                            CorrPostal, CorrPhone, CorrEmail, NameFirst, NameMiddle, IIf(NameLast.Trim = "", NameFirst, NameLast),
                            "", "", birthPlace, birthDate, MMN, TaxID, Gender, CountryID, ReligionID, EducationID, OccupationID,
                            "", "", "", 1, MaritalID, SpouseName, "", IDCardTypeID, IDCardNo, CityName, IDCardExpired, dateExpired)
            If objIndividu.ErrID = 0 Then
                returnS = ""
                returnMsg = ""

                objIndividuKYC.Clear()
                objIndividuKYC.Load(objMasterSimpi, objIndividu.GetClientCode)
                objClientKYC.Add(objIndividuKYC, 41, SID) 'SID
                If Not IsNothing(fgExcel(iRow, 23)) Then If fgExcel(iRow, 23).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 3, fgExcel(iRow, 23)) 'Income Level (IDR)
                If Not IsNothing(fgExcel(iRow, 27)) Then If fgExcel(iRow, 27).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 1, fgExcel(iRow, 27)) 'Investment Objective
                If Not IsNothing(fgExcel(iRow, 28)) Then If fgExcel(iRow, 28).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 15, fgExcel(iRow, 28)) 'Source of Fund
                If Not IsNothing(fgExcel(iRow, 29)) Then If fgExcel(iRow, 29).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 44, fgExcel(iRow, 29)) 'Asset Owner
                If Not IsNothing(fgExcel(iRow, 30)) Then If fgExcel(iRow, 30).ToString.Trim <> "" And fgExcel(iRow, 30).ToString.Trim <> "0" Then objClientKYC.Add(objIndividuKYC, 49, fgExcel(iRow, 30)) 'KTP Address
                If CityName <> "" And CityName <> "NA" Then objClientKYC.Add(objIndividuKYC, 50, CityName) 'KTP City Code
                If Not IsNothing(fgExcel(iRow, 32)) Then If fgExcel(iRow, 32).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 51, fgExcel(iRow, 32)) 'KTP Postal Code
                If Not IsNothing(fgExcel(iRow, 38)) Then If fgExcel(iRow, 38).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 52, fgExcel(iRow, 38)) 'Domicile Address
                If Not IsNothing(fgExcel(iRow, 40)) Then If fgExcel(iRow, 40).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 53, fgExcel(iRow, 40)) 'Domicile City Name
                If Not IsNothing(fgExcel(iRow, 41)) Then If fgExcel(iRow, 41).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 54, fgExcel(iRow, 41)) 'Domicile Postal Code
                If Not IsNothing(fgExcel(iRow, 42)) Then If fgExcel(iRow, 42).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 55, fgExcel(iRow, 42)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 56, fgExcel(iRow, 43)) 'Home Phone
                If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 74, fgExcel(iRow, 44)) 'Mobile Phone
                If Not IsNothing(fgExcel(iRow, 45)) Then If fgExcel(iRow, 45).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 57, fgExcel(iRow, 45)) 'Facsimile
                If Not IsNothing(fgExcel(iRow, 47)) Then If fgExcel(iRow, 47).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 45, fgExcel(iRow, 47)) 'Statement Type
                If Not IsNothing(fgExcel(iRow, 48)) Then If fgExcel(iRow, 48).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 46, fgExcel(iRow, 48)) 'FATCA (Status)
                If Not IsNothing(fgExcel(iRow, 49)) Then If fgExcel(iRow, 49).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 58, fgExcel(iRow, 49)) 'TIN / Foreign TIN
                If Not IsNothing(fgExcel(iRow, 50)) Then If fgExcel(iRow, 50).ToString.Trim <> "" Then objClientKYC.Add(objIndividuKYC, 59, fgExcel(iRow, 50)) 'TIN / Foreign TIN Issuance Country

                objSalesDistributor.Clear()
                objSalesDistributor.Load(objMasterSimpi, SalesCode)
                objIndividuSub.Clear()
                objIndividuSub.Add(objIndividu, objSalesDistributor, objIndividu.GetClientName, objIndividu.GetClientName, "", "")
                ClientCode = objIndividuSub.GetClientCode

                objIndividuSubKYC.Clear()
                objIndividuSubKYC.Load(objMasterSimpi, objIndividuSub.GetClientCode)
                objClientKYC.Add(objIndividuSubKYC, 41, SID) 'SID
                If Not IsNothing(fgExcel(iRow, 23)) Then If fgExcel(iRow, 23).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 3, fgExcel(iRow, 23)) 'Income Level (IDR)
                If Not IsNothing(fgExcel(iRow, 27)) Then If fgExcel(iRow, 27).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 1, fgExcel(iRow, 27)) 'Investment Objective
                If Not IsNothing(fgExcel(iRow, 28)) Then If fgExcel(iRow, 28).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 15, fgExcel(iRow, 28)) 'Source of Fund
                If Not IsNothing(fgExcel(iRow, 29)) Then If fgExcel(iRow, 29).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 44, fgExcel(iRow, 29)) 'Asset Owner
                If Not IsNothing(fgExcel(iRow, 30)) Then If fgExcel(iRow, 30).ToString.Trim <> "" And fgExcel(iRow, 30).ToString.Trim <> "0" Then objClientKYC.Add(objIndividuSubKYC, 49, fgExcel(iRow, 30)) 'KTP Address
                If CityName <> "" And CityName <> "NA" Then objClientKYC.Add(objIndividuSubKYC, 50, CityName)
                If Not IsNothing(fgExcel(iRow, 32)) Then If fgExcel(iRow, 32).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 51, fgExcel(iRow, 32)) 'KTP Postal Code
                If Not IsNothing(fgExcel(iRow, 38)) Then If fgExcel(iRow, 38).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 52, fgExcel(iRow, 38)) 'Domicile Address
                If Not IsNothing(fgExcel(iRow, 40)) Then If fgExcel(iRow, 40).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 53, fgExcel(iRow, 40)) 'Domicile City Name
                If Not IsNothing(fgExcel(iRow, 41)) Then If fgExcel(iRow, 41).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 54, fgExcel(iRow, 41)) 'Domicile Postal Code
                If Not IsNothing(fgExcel(iRow, 42)) Then If fgExcel(iRow, 42).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 55, fgExcel(iRow, 42)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 56, fgExcel(iRow, 43)) 'Home Phone
                If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 74, fgExcel(iRow, 44)) 'Mobile Phone
                If Not IsNothing(fgExcel(iRow, 45)) Then If fgExcel(iRow, 45).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 57, fgExcel(iRow, 45)) 'Facsimile
                If Not IsNothing(fgExcel(iRow, 47)) Then If fgExcel(iRow, 47).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 45, fgExcel(iRow, 47)) 'Statement Type
                If Not IsNothing(fgExcel(iRow, 48)) Then If fgExcel(iRow, 48).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 46, fgExcel(iRow, 48)) 'FATCA (Status)
                If Not IsNothing(fgExcel(iRow, 49)) Then If fgExcel(iRow, 49).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 58, fgExcel(iRow, 49)) 'TIN / Foreign TIN
                If Not IsNothing(fgExcel(iRow, 50)) Then If fgExcel(iRow, 50).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 59, fgExcel(iRow, 50)) 'TIN / Foreign TIN Issuance Country

            Else
                returnS = "Failed"
                returnMsg = objIndividu.ErrMsg
            End If
        Else
            objSalesDistributor.Clear()
            objSalesDistributor.Load(objMasterSimpi, SalesCode)

            objIndividuKYC.Clear()
            objIndividuKYC.LoadDistributor(objMasterSimpi, objSalesDistributor, CInt(lblKYCID.Text), SID)
            If objIndividuKYC.ErrID = 0 Then
                ClientCode = objIndividuKYC.GetClientCode
                isExists = True
            Else
                isExists = False

                objIndividu.Clear()
                objIndividu.LoadInternal(objMasterSimpi, CInt(lblKYCID.Text), SID)
                objIndividuSub.Clear()
                objIndividuSub.Add(objIndividu, objSalesDistributor, ClientName, ClientName, "", "")
                ClientCode = objIndividuSub.GetClientCode

                objIndividuSubKYC.Clear()
                objIndividuSubKYC.Load(objMasterSimpi, objIndividuSub.GetClientCode)
                objClientKYC.Add(objIndividuSubKYC, 41, SID) 'SID
                If Not IsNothing(fgExcel(iRow, 23)) Then If fgExcel(iRow, 23).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 3, fgExcel(iRow, 23)) 'Income Level (IDR)
                If Not IsNothing(fgExcel(iRow, 27)) Then If fgExcel(iRow, 27).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 1, fgExcel(iRow, 27)) 'Investment Objective
                If Not IsNothing(fgExcel(iRow, 28)) Then If fgExcel(iRow, 28).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 15, fgExcel(iRow, 28)) 'Source of Fund
                If Not IsNothing(fgExcel(iRow, 29)) Then If fgExcel(iRow, 29).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 44, fgExcel(iRow, 29)) 'Asset Owner
                If Not IsNothing(fgExcel(iRow, 30)) Then If fgExcel(iRow, 30).ToString.Trim <> "" And fgExcel(iRow, 30).ToString.Trim <> "0" Then objClientKYC.Add(objIndividuSubKYC, 49, fgExcel(iRow, 30)) 'KTP Address
                If CityName <> "" And CityName <> "NA" Then objClientKYC.Add(objIndividuSubKYC, 50, CityName)
                If Not IsNothing(fgExcel(iRow, 32)) Then If fgExcel(iRow, 32).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 51, fgExcel(iRow, 32)) 'KTP Postal Code
                If Not IsNothing(fgExcel(iRow, 38)) Then If fgExcel(iRow, 38).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 52, fgExcel(iRow, 38)) 'Domicile Address
                If Not IsNothing(fgExcel(iRow, 40)) Then If fgExcel(iRow, 40).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 53, fgExcel(iRow, 40)) 'Domicile City Name
                If Not IsNothing(fgExcel(iRow, 41)) Then If fgExcel(iRow, 41).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 54, fgExcel(iRow, 41)) 'Domicile Postal Code
                If Not IsNothing(fgExcel(iRow, 42)) Then If fgExcel(iRow, 42).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 55, fgExcel(iRow, 42)) 'Country of Domicile
                If Not IsNothing(fgExcel(iRow, 43)) Then If fgExcel(iRow, 43).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 56, fgExcel(iRow, 43)) 'Home Phone
                If Not IsNothing(fgExcel(iRow, 44)) Then If fgExcel(iRow, 44).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 74, fgExcel(iRow, 44)) 'Mobile Phone
                If Not IsNothing(fgExcel(iRow, 45)) Then If fgExcel(iRow, 45).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 57, fgExcel(iRow, 45)) 'Facsimile
                If Not IsNothing(fgExcel(iRow, 47)) Then If fgExcel(iRow, 47).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 45, fgExcel(iRow, 47)) 'Statement Type
                If Not IsNothing(fgExcel(iRow, 48)) Then If fgExcel(iRow, 48).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 46, fgExcel(iRow, 48)) 'FATCA (Status)
                If Not IsNothing(fgExcel(iRow, 49)) Then If fgExcel(iRow, 49).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 58, fgExcel(iRow, 49)) 'TIN / Foreign TIN
                If Not IsNothing(fgExcel(iRow, 50)) Then If fgExcel(iRow, 50).ToString.Trim <> "" Then objClientKYC.Add(objIndividuSubKYC, 59, fgExcel(iRow, 50)) 'TIN / Foreign TIN Issuance Country
            End If
        End If
        Return ClientCode
    End Function

#End Region

End Class