Imports C1.Win.C1TrueDBGrid
Imports simpi.MasterSales
Imports simpi.globalutilities

Public Class FormSalesProfile
    Public CallerForm As FormSalesMaintenance
    Public objSales As MasterSales
    Dim objProfile As New MasterSales
    Dim dtSalesDirect As New DataTable
    Dim dtSalesTeam As New DataTable

    Public Sub SalesLoad()
        If objSales.GetSalesID > 0 Then
            lblSimpiName.Text = objSales.GetSimpiUser.GetMasterSimpi.GetSimpiName
            lblHeadCode.Text = objSales.GetTreeParentCode
            lblHeadName.Text = objSales.GetTreeParentName
            lblSalesLevel.Text = objSales.GetTreeLevel
            lblSalesCode.Text = objSales.GetSalesCode
            lblSalesName.Text = objSales.GetSimpiUser.GetUserName
            lblStatus.Text = objSales.GetSimpiUser.GetUserStatus.GetStatusCode
            lblTaxID.Text = objSales.GetTaxID
            lblLicenseNo.Text = objSales.GetLicenseNo
            lblLicenseExpired.Text = objSales.GetLicenseExpired.ToString("dd-MMM-yyyy")
            lblAddress.Text = objSales.GetCorrespondenceAddress
            lblPhone.Text = objSales.GetCorrespondencePhone
            lblEmail.Text = objSales.GetCorrespondenceEmail
            dtSalesDirect = objSales.SearchDirect("")
            dtSalesTeam = objSales.SearchAll("")
            If dtSalesTeam.Rows.Count > 0 Then
                Dim row() As DataRow = dtSalesTeam.Select("", "TreeLevel DESC")
                If row.Length = 0 Then
                    lblSalesSpan.Text = "0"
                Else
                    lblSalesSpan.Text = row(0)("TreeLevel") - objSales.GetTreeLevel
                End If
            Else
                lblSalesSpan.Text = "0"
            End If

            GetMasterSimpi()
            GetParameterClientStatus()
            DBGDirect.FetchRowStyles = True
            DBGTeam.FetchRowStyles = True
            DisplayDirect(dtSalesDirect)
            DisplayTeam(dtSalesTeam)
            objProfile.UserAccess = objAccess
        Else
            Close()
        End If
    End Sub

    Private Sub btnSearchDirect_Click(sender As Object, e As EventArgs) Handles btnSearchDirect.Click
        SearchDirect()
    End Sub

    Private Sub btnSearchTeam_Click(sender As Object, e As EventArgs) Handles btnSearchTeam.Click
        SearchTeam()
    End Sub

    Private Sub SearchTeam()
        If dtSalesTeam IsNot Nothing AndAlso dtSalesTeam.Rows.Count > 0 Then
            Dim tbl As New DataTable
            Dim strFilter As String = "SalesCode Like '%" & txtKeywordTeam.Text.Trim & "%' OR " &
                                      "UserName Like '%" & txtKeywordTeam.Text.Trim & "%'"
            tbl = dtSalesTeam.Select(strFilter).CopyToDataTable
            DisplayTeam(tbl)
        End If
    End Sub

    Private Sub SearchDirect()
        If dtSalesDirect IsNot Nothing AndAlso dtSalesDirect.Rows.Count > 0 Then
            Dim tbl As New DataTable
            Dim strFilter As String = "SalesCode Like '%" & txtKeywordDirect.Text.Trim & "%' OR " &
                                      "UserName Like '%" & txtKeywordDirect.Text.Trim & "%'"
            tbl = dtSalesDirect.Select(strFilter).CopyToDataTable
            DisplayDirect(tbl)
        End If
    End Sub

    Private Sub DisplayDirect(tbl As DataTable)
        If tbl.Rows.Count > 0 Then
            lblNumberDirect.Text = tbl.Rows.Count
            Dim query = From p In tbl.AsEnumerable
                        Join s In dtParameterClientStatus.AsEnumerable On
                                  p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Select
                             ID = p.Field(Of Integer)("SalesID"),
                             Code = p.Field(Of String)("SalesCode"),
                             Name = p.Field(Of String)("UserName"),
                             simpi = p.Field(Of String)("simpiName"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGDirect
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGDirect.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            lblNumberDirect.Text = "0"
            DBGDirect.Columns.Clear()
        End If
        btnProfileDirect.Enabled = False
    End Sub

    Private Sub DBGDirect_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGDirect.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGDirect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGDirect.Click
        With DBGDirect
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfileDirect.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGDirect_DoubleClick(sender As Object, e As EventArgs) Handles DBGDirect.DoubleClick
        ProfileDirect()
    End Sub

    Private Sub btnProfileDirect_Click(sender As Object, e As EventArgs) Handles btnProfileDirect.Click
        ProfileDirect()
    End Sub

    Private Sub ProfileDirect()
        With DBGDirect
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objProfile.Clear()
                objProfile.Load(objMasterSimpi, .Columns("Code").Text)
                If objProfile.ErrID = 0 Then
                    Dim frm As New FormSalesProfile
                    frm.Show()
                    frm.objSales = objProfile
                    frm.SalesLoad()
                    frm.MdiParent = MDISO
                Else
                    ExceptionMessage.Show(objProfile.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub DisplayTeam(tbl As DataTable)
        If tbl.Rows.Count > 0 Then
            lblNumberTeam.Text = tbl.Rows.Count
            Dim query = From p In tbl.AsEnumerable
                        Join s In dtParameterClientStatus.AsEnumerable On
                                  p.Field(Of Integer)("StatusID") Equals s.Field(Of Integer)("StatusID")
                        Select
                             ID = p.Field(Of Integer)("SalesID"),
                             Code = p.Field(Of String)("SalesCode"),
                             Name = p.Field(Of String)("UserName"),
                             simpi = p.Field(Of String)("simpiName"),
                             Status = s.Field(Of String)("StatusCode")
            With DBGTeam
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGTeam.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
        Else
            lblNumberTeam.Text = "0"
            DBGTeam.Columns.Clear()
        End If
        btnProfileTeam.Enabled = False
    End Sub

    Private Sub DBGTeam_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGTeam.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGTeam.Click
        With DBGTeam
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfileTeam.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGTeam_DoubleClick(sender As Object, e As EventArgs) Handles DBGTeam.DoubleClick
        ProfileTeam()
    End Sub

    Private Sub btnProfileTeam_Click(sender As Object, e As EventArgs) Handles btnProfileTeam.Click
        ProfileTeam()
    End Sub

    Private Sub ProfileTeam()
        With DBGTeam
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objProfile.Clear()
                objProfile.Load(objMasterSimpi, .Columns("Code").Text)
                If objProfile.ErrID = 0 Then
                    Dim frm As New FormSalesProfile
                    frm.Show()
                    frm.objSales = objProfile
                    frm.SalesLoad()
                    frm.MdiParent = MDISO
                Else
                    ExceptionMessage.Show(objProfile.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SalesEdit()
    End Sub

    Private Sub SalesEdit()
        Dim frm As New FormSalesEdit
        frm.Show()
        frm.objSales = objSales
        frm.SalesLoad()
        frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

    Private Sub btnAddSalesInternal_Click(sender As Object, e As EventArgs) Handles btnAddSalesInternal.Click
        SalesInternalAdd()
    End Sub

    Private Sub SalesInternalAdd()
        Dim frm As New FormSalesNew
        frm.Show()
        frm.objSales = objSales
        frm.SalesLoad()
        If CallerForm.IsHandleCreated Then frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

    Private Sub btnAddSalesIFA_Click(sender As Object, e As EventArgs) Handles btnAddSalesIFA.Click
        SalesIFAAdd()
    End Sub

    Private Sub SalesIFAAdd()
        Dim frm As New FormSalesNewIFA
        frm.Show()
        frm.objSales = objSales
        frm.SalesLoad()
        If CallerForm.IsHandleCreated Then frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

    Private Sub btnAddSalesReferral_Click(sender As Object, e As EventArgs) Handles btnAddSalesReferral.Click
        SalesReferralAdd()
    End Sub

    Private Sub SalesReferralAdd()
        Dim frm As New FormSalesNewReferral
        frm.Show()
        frm.objSales = objSales
        frm.SalesLoad()
        If CallerForm.IsHandleCreated Then frm.CallerForm = CallerForm
        frm.MdiParent = MDISO
        Close()
    End Sub

    Private Sub btnAddReferral_Click(sender As Object, e As EventArgs) Handles btnAddReferral.Click
        Dim frm As New FormSalesFeeReferral
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddSharing_Click(sender As Object, e As EventArgs) Handles btnAddSharing.Click
        Dim frm As New FormSalesFeeSharing
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddMulti_Click(sender As Object, e As EventArgs) Handles btnAddMulti.Click
        Dim frm As New FormSalesFeeMulti
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddSubscription_Click(sender As Object, e As EventArgs)
        Dim frm As New FormSalesFeeIncentive
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnAddSellingFee_Click(sender As Object, e As EventArgs) Handles btnAddSellingFee.Click
        Dim frm As New FormSalesFeeSelling
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

End Class