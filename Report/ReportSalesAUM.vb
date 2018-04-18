Imports C1.Win.C1TrueDBGrid
Imports simpi.globalutilities
Imports simpi.CoreData

Public Class ReportSalesAUM
    Dim objPortfolio As New simpi.MasterPortfolio.MasterPortfolio
    Dim objSimpi As New simpi.MasterSimpi.MasterSimpi
    Dim objCapital As New PositionSales
    Dim objSales As New simpi.MasterSales.MasterSales
    Dim dtClient As New DataTable
    Dim value As Double = 0

    Private Sub ReportSalesAUM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        objPortfolio.UserAccess = objAccess
        objSimpi.UserAccess = objAccess
        objCapital.UserAccess = objAccess
        objSales.UserAccess = objAccess
        DBGClient.FetchRowStyles = True
        dtAs.Value = Now
    End Sub

    Private Sub btnSearchPortfolio_Click(sender As Object, e As EventArgs) Handles btnSearchPortfolio.Click
        PortfolioSearch()
    End Sub

    Private Sub PortfolioSearch()
        Dim form As New FormSelectMasterPortfolioNormal
        form.lblCode = lblPortfolioCode
        form.lblName = lblPortfolioName
        form.lblSimpiEmail = lblSimpiEmail
        form.lblSimpiName = lblSimpiName
        form.Show()
        form.MdiParent = MDISO
        lblPortfolioCode.Text = ""
        lblPortfolioName.Text = ""
        lblSimpiEmail.Text = ""
        lblSimpiName.Text = ""
        objPortfolio.Clear()
    End Sub

    Private Sub lblSimpiEmail_TextChanged(sender As Object, e As EventArgs) Handles lblSimpiEmail.TextChanged
        PortfolioLoad()
    End Sub

    Private Sub PortfolioLoad()
        If lblPortfolioCode.Text.Trim <> "" Then
            objSimpi.Clear()
            objSimpi.Load(lblSimpiEmail.Text)
            If objSimpi.ErrID = 0 Then
                objPortfolio.Clear()
                objPortfolio.LoadCode(objSimpi, lblPortfolioCode.Text)
                If objPortfolio.ErrID <> 0 Then
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExceptionMessage.Show(objSimpi.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSearchSales_Click(sender As Object, e As EventArgs) Handles btnSearchSales.Click
        SalesScreen()
    End Sub

    Private Sub SalesScreen()
        Dim form As New FormSelectMasterSales
        form.lblSalesCode = lblSalesCode
        form.lblSalesName = lblSalesName
        form.Show()
        If IsMdiChild Then form.MdiParent = MDISO
        lblSalesCode.Text = ""
        lblSalesName.Text = ""
        objSales.Clear()
    End Sub

    Private Sub lblSalesCode_TextChanged(sender As Object, e As EventArgs) Handles lblSalesCode.TextChanged
        SalesLoad()
    End Sub

    Private Sub SalesLoad()
        objSales.Clear()
        objSales.Load(objMasterSimpi, lblSalesCode.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        DataSearch()
    End Sub

    Private Sub DataSearch()
        If objPortfolio.GetPortfolioID > 0 And objSales.GetSalesID > 0 Then
            objCapital.Clear()
            dtClient = objCapital.SearchAll(objSales, objPortfolio, dtAs.Value, "")
            SummaryClear()
            DBGClient.Columns.Clear()
            If objCapital.ErrID = 0 Then
                SummaryTotal()
                DisplayClient()
                SummaryLocal()
                SummaryForeign()
                SummaryIndividu()
                SummaryIndividuSA()
                SummaryInstitution()
                SummaryInstitutionSA()
                SummaryDistributor()
                SummaryNominee()
            Else
                ExceptionMessage.Show(objCapital.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExceptionMessage.Show(objError.Message(81) & " master portfolio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub rbSalesDirect_Click(sender As Object, e As EventArgs) Handles rbSalesDirect.Click
        DisplayClient()
    End Sub

    Private Sub rbSalesTeam_Click(sender As Object, e As EventArgs) Handles rbSalesTeam.Click
        DisplayClient()
    End Sub

    Private Sub rbSalesAll_Click(sender As Object, e As EventArgs) Handles rbSalesAll.Click
        DisplayClient()
    End Sub

    Private Sub DisplayClient()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            If rbSalesDirect.Checked Then
                DisplayDirect()
            ElseIf rbSalesTeam.Checked Then
                DisplayTeam()
            ElseIf rbSalesAll.Checked Then
                DisplayAll()
            End If
        End If
    End Sub

    Private Sub DisplayDirect()
        Dim query = From u In dtClient.AsEnumerable Where u.Field(Of Integer)("SalesID") = objSales.GetSalesID
                    Group u By key = New With {
                        Key .ID = u.Field(Of Integer)("ClientID"),
                        Key .CIF = u.Field(Of String)("ClientCode"),
                        Key .Name = u.Field(Of String)("ClientName"),
                        Key .Sales = u.Field(Of String)("SalesCode"),
                        Key .LF = u.Field(Of String)("LF")
                        }
                    Into Group Select New With {
                        .ID = key.ID, .CIF = key.CIF, .Name = key.Name, .Sales = key.Sales, .LF = key.LF,
                        .Unit = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit")),
                        .value = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice")),
                        .Persen = SetPersen(Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice"))),
                        .Cost = Group.Sum(Function(r) r.Field(Of Decimal)("AcqTotal")),
                        .PL = Group.Sum(Function(r) (r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice")) - r.Field(Of Decimal)("AcqTotal"))
                        }
        With DBGClient
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = query.ToList

            .Columns("Unit").NumberFormat = "n4"
            .Columns("Persen").NumberFormat = "n2"
            .Columns("Value").NumberFormat = "n0"
            .Columns("Cost").NumberFormat = "n4"
            .Columns("PL").NumberFormat = "n4"

            .Splits(0).DisplayColumns("ID").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("CIF").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Name").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Sales").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("LF").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Persen").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Value").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Cost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("PL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

            .Splits(0).DisplayColumns("ID").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("CIF").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Name").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Sales").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("LF").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Persen").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Value").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Cost").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("PL").Style.HorizontalAlignment = AlignHorzEnum.Far

            .Columns("Persen").Caption = "%"

            For Each column As C1DisplayColumn In DBGClient.Splits(0).DisplayColumns
                column.AutoSize()
            Next
        End With
    End Sub

    Private Sub DisplayTeam()
        Dim query = From u In dtClient.AsEnumerable
                    Where u.Field(Of String)("TreePrefix").ToUpper.StartsWith(objSales.GetTreePrefix.ToUpper) And
                          u.Field(Of Integer)("SalesID") <> objSales.GetSalesID
                    Group u By key = New With {
                        Key .ID = u.Field(Of Integer)("ClientID"),
                        Key .CIF = u.Field(Of String)("ClientCode"),
                        Key .Name = u.Field(Of String)("ClientName"),
                        Key .Sales = u.Field(Of String)("SalesCode"),
                        Key .LF = u.Field(Of String)("LF")
                        }
                    Into Group Select New With {
                        .ID = key.ID, .CIF = key.CIF, .Name = key.Name, .Sales = key.Sales, .LF = key.LF,
                        .Unit = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit")),
                        .value = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice")),
                        .Persen = SetPersen(Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice"))),
                        .Cost = Group.Sum(Function(r) r.Field(Of Decimal)("AcqTotal")),
                        .PL = Group.Sum(Function(r) (r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice")) - r.Field(Of Decimal)("AcqTotal"))
                        }
        With DBGClient
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = query.ToList

            .Columns("Unit").NumberFormat = "n4"
            .Columns("Persen").NumberFormat = "n2"
            .Columns("Value").NumberFormat = "n0"
            .Columns("Cost").NumberFormat = "n4"
            .Columns("PL").NumberFormat = "n4"

            .Splits(0).DisplayColumns("ID").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("CIF").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Name").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Sales").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("LF").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Persen").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Value").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Cost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("PL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

            .Splits(0).DisplayColumns("ID").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("CIF").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Name").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Sales").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("LF").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Persen").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Value").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Cost").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("PL").Style.HorizontalAlignment = AlignHorzEnum.Far

            .Columns("Persen").Caption = "%"

            For Each column As C1DisplayColumn In DBGClient.Splits(0).DisplayColumns
                column.AutoSize()
            Next
        End With
    End Sub

    Private Sub DisplayAll()
        Dim query = From u In dtClient.AsEnumerable
                    Where u.Field(Of String)("TreePrefix").ToUpper.StartsWith(objSales.GetTreePrefix.ToUpper)
                    Group u By key = New With {
                        Key .ID = u.Field(Of Integer)("ClientID"),
                        Key .CIF = u.Field(Of String)("ClientCode"),
                        Key .Name = u.Field(Of String)("ClientName"),
                        Key .Sales = u.Field(Of String)("SalesCode"),
                        Key .LF = u.Field(Of String)("LF")
                        }
                    Into Group Select New With {
                        .ID = key.ID, .CIF = key.CIF, .Name = key.Name, .Sales = key.Sales, .LF = key.LF,
                        .Unit = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit")),
                        .value = Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice")),
                        .Persen = SetPersen(Group.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice"))),
                        .Cost = Group.Sum(Function(r) r.Field(Of Decimal)("AcqTotal")),
                        .PL = Group.Sum(Function(r) (r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice")) - r.Field(Of Decimal)("AcqTotal"))
                        }
        With DBGClient
            .AllowAddNew = False
            .AllowDelete = False
            .AllowUpdate = False
            .Style.WrapText = False
            .Columns.Clear()
            .DataSource = query.ToList

            .Columns("Unit").NumberFormat = "n4"
            .Columns("Persen").NumberFormat = "n2"
            .Columns("Value").NumberFormat = "n0"
            .Columns("Cost").NumberFormat = "n4"
            .Columns("PL").NumberFormat = "n4"

            .Splits(0).DisplayColumns("ID").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("CIF").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Name").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Sales").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("LF").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Persen").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Value").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Cost").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("PL").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center

            .Splits(0).DisplayColumns("ID").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("CIF").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Name").Style.HorizontalAlignment = AlignHorzEnum.Near
            .Splits(0).DisplayColumns("Sales").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("LF").Style.HorizontalAlignment = AlignHorzEnum.Center
            .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Persen").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Value").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("Cost").Style.HorizontalAlignment = AlignHorzEnum.Far
            .Splits(0).DisplayColumns("PL").Style.HorizontalAlignment = AlignHorzEnum.Far

            .Columns("Persen").Caption = "%"

            For Each column As C1DisplayColumn In DBGClient.Splits(0).DisplayColumns
                column.AutoSize()
            Next
        End With
    End Sub

    Private Function SetPersen(ByVal value As Double) As Double
        Dim total As Double = 0
        If IsNumeric(lblTotalValue.Text) Then
            total = CDbl(lblTotalValue.Text)
        End If
        If total = 0 Then
            Return 0
        Else
            Return value * 100 / total
        End If
    End Function

    Private Sub DBGClient_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGClient.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGClient.Click
        With DBGClient
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub SummaryClear()
        lblLocalNo.Text = "0"
        lblLocalUnit.Text = "0"
        lblLocalValue.Text = "0"
        lblLocalPersen.Text = "0"

        lblForeignNo.Text = "0"
        lblForeignUnit.Text = "0"
        lblForeignValue.Text = "0"
        lblForeignPersen.Text = "0"

        lblIndividuNo.Text = "0"
        lblIndividuUnit.Text = "0"
        lblIndividuValue.Text = "0"
        lblIndividuPersen.Text = "0"

        lblIndividuSANo.Text = "0"
        lblIndividuSAUnit.Text = "0"
        lblIndividuSAValue.Text = "0"
        lblIndividuSAPersen.Text = "0"

        lblInstitutionNo.Text = "0"
        lblInstitutionUnit.Text = "0"
        lblInstitutionValue.Text = "0"
        lblInstitutionPersen.Text = "0"

        lblInstitutionSANo.Text = "0"
        lblInstitutionSAUnit.Text = "0"
        lblInstitutionSAValue.Text = "0"
        lblInstitutionSAPersen.Text = "0"

        lblDistributorNo.Text = "0"
        lblDistributorUnit.Text = "0"
        lblDistributorValue.Text = "0"
        lblDistributorPersen.Text = "0"

        lblNomineeNo.Text = "0"
        lblNomineeUnit.Text = "0"
        lblNomineeValue.Text = "0"
        lblNomineePersen.Text = "0"

        lblTotalNo.Text = "0"
        lblTotalUnit.Text = "0"
        lblTotalValue.Text = "0"
        lblTotalPersen.Text = "0"
    End Sub

    Private Sub SummaryTotal()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            Dim query = From u In dtClient.AsEnumerable
                        Group u By key = u.Field(Of Integer)("SalesID") And u.Field(Of Integer)("ClientID")
                        Into uSum = Group
                        Select value = uSum.Sum(Function(r) r.Field(Of Decimal)("AcqUnit"))
            lblTotalNo.Text = query.Count.ToString("n0")
            lblTotalUnit.Text = query.Sum().ToString("n0")
            lblTotalValue.Text = (From u In dtClient.AsEnumerable
                                  Group u By key = u.Field(Of Integer)("SalesID") And u.Field(Of Integer)("ClientID")
                                  Into uSum = Group
                                  Select value = uSum.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice"))).Sum().ToString("n0")
            lblTotalPersen.Text = "100.00"
        End If
    End Sub

    Private Sub SummaryLocal()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            Dim query = From u In dtClient.AsEnumerable Where u.Field(Of String)("LF") = "L"
                        Group u By key = u.Field(Of Integer)("SalesID") And u.Field(Of Integer)("ClientID")
                        Into uSum = Group
                        Select value = uSum.Sum(Function(r) r.Field(Of Decimal)("AcqUnit"))
            lblLocalNo.Text = query.Count.ToString("n0")
            lblLocalUnit.Text = query.Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of String)("LF") = "L"
                     Group u By key = u.Field(Of Integer)("SalesID") And u.Field(Of Integer)("ClientID")
                     Into uSum = Group
                     Select value = uSum.Sum(Function(r) r.Field(Of Decimal)("AcqUnit") * r.Field(Of Decimal)("UnitPrice"))).Sum()
            lblLocalValue.Text = value.ToString("n0")
            lblLocalPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryForeign()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblForeignNo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of String)("LF") = "F"
                                 Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblForeignUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of String)("LF") = "F"
                                   Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of String)("LF") = "F"
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblForeignValue.Text = value.ToString("n0")
            lblForeignPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryIndividu()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblIndividuNo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 1
                                  Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblIndividuUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 1
                                    Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 1
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblIndividuValue.Text = value.ToString("n0")
            lblIndividuPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryIndividuSA()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblIndividuSANo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 3
                                    Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblIndividuSAUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 3
                                      Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 3
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblIndividuSAValue.Text = value.ToString("n0")
            lblIndividuSAPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryInstitution()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblInstitutionNo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 2
                                     Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblInstitutionUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 2
                                       Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 2
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblInstitutionValue.Text = value.ToString("n0")
            lblInstitutionPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryInstitutionSA()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblInstitutionSANo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 4
                                       Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblInstitutionSAUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 4
                                         Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 4
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblInstitutionSAValue.Text = value.ToString("n0")
            lblInstitutionSAPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryDistributor()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblDistributorNo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 7
                                     Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblDistributorUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 7
                                       Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 7
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblDistributorValue.Text = value.ToString("n0")
            lblDistributorPersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub SummaryNominee()
        If dtClient IsNot Nothing And dtClient.Rows.Count > 0 Then
            lblNomineeNo.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 5 Or
                                                                       u.Field(Of Integer)("ClientTypeID") = 6
                                 Select u.Field(Of Decimal)("AcqUnit")).Count.ToString("n0")
            lblNomineeUnit.Text = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 5 Or
                                                                       u.Field(Of Integer)("ClientTypeID") = 6
                                   Select u.Field(Of Decimal)("AcqUnit")).Sum().ToString("n0")
            value = (From u In dtClient.AsEnumerable Where u.Field(Of Integer)("ClientTypeID") = 5 Or
                                                                       u.Field(Of Integer)("ClientTypeID") = 6
                     Select u.Field(Of Decimal)("AcqUnit") * u.Field(Of Decimal)("UnitPrice")).Sum()
            lblNomineeValue.Text = value.ToString("n0")
            lblNomineePersen.Text = SetPersen(value).ToString("n2")
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        ExportExcel(False)
    End Sub

    Public Function ExportExcel(ByVal isSave As Boolean) As String
        Return PrintExcel(False, DBGClient, "ReportSAUM.xls")
    End Function

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        ReportEmail()
    End Sub

    Private Sub ReportEmail()
        If DBGClient.RowCount > 0 Then
            Dim frm As New ReportSalesAUMEmail
            frm.Show()
            frm.frm = Me
            frm.MdiParent = MDISO
        End If
    End Sub

End Class