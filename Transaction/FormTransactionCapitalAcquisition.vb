Imports C1.Win.C1TrueDBGrid
Imports simpi.CoreData

Public Class FormTransactionCapitalAcquisition
    Public objPosition As PositionCapital

    Public Sub DataLoad()
        DBGAcquisition.FetchRowStyles = True
        PositionLoad()
        AcquisitionSearch()
    End Sub

    Private Sub PositionLoad()
        lblPortfolioCode.Text = objPosition.GetMasterPortfolio.GetPortfolioCode
        lblPortfolioName.Text = objPosition.GetMasterPortfolio.GetPortfolioNameFull
        lblSimpiName.Text = objPosition.GetMasterPortfolio.GetMasterSimpi.GetSimpiName
        lblClientCode.Text = objPosition.GetMasterClient.GetClientCode
        lblClientName.Text = objPosition.GetMasterClient.GetClientName
        lblSalesCode.Text = objPosition.GetMasterClient.GetMasterSales.GetSalesCode
        lblSalesName.Text = objPosition.GetMasterClient.GetMasterSales.GetSimpiUser.GetUserName
        lblPositionDate.Text = objPosition.GetPositionDate.ToString("dd-MMM-yyyy")
        lblQty.Text = objPosition.GetUnitBalance.ToString("n4")
        lblPrice.Text = objPosition.GetUnitPrice.ToString("n4")
        lblLastValue.Text = objPosition.GetUnitValue.ToString("n2")
        lblLastCost.Text = objPosition.GetCostTotal.ToString("n2")
    End Sub

    Private Sub AcquisitionSearch()
        Dim dtAcquisition As New DataTable
        dtAcquisition = objPosition.Detail_Search(objPosition.GetMasterPortfolio,
                                                  objPosition.GetMasterClient, objPosition.GetPositionDate)
        If dtAcquisition.Rows.Count > 0 Then
            Dim query = From a In dtAcquisition.AsEnumerable
                        Join s In dtMasterSales.AsEnumerable On
                              a.Field(Of Integer)("SalesID") Equals s.Field(Of Integer)("SalesID")
                        Select
                                 No = a.Field(Of Integer)("AcqNo"),
                                 Sales = s.Field(Of String)("SalesCode"),
                                 AcqDate = a.Field(Of Date)("AcqDate"),
                                 Unit = a.Field(Of Decimal)("AcqUnit"),
                                 Price = a.Field(Of Decimal)("AcqPrice"),
                                 Cost = a.Field(Of Decimal)("AcqTotal")
            With DBGAcquisition
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Style.WrapText = False
                .Columns.Clear()
                .DataSource = query.ToList

                .Columns("AcqDate").NumberFormat = "dd-MMM-yy"
                .Columns("Unit").NumberFormat = "n4"
                .Columns("Price").NumberFormat = "n4"
                .Columns("Cost").NumberFormat = "n2"
                .Splits(0).DisplayColumns("No").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("AcqDate").Style.HorizontalAlignment = AlignHorzEnum.Center
                .Splits(0).DisplayColumns("Unit").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Price").Style.HorizontalAlignment = AlignHorzEnum.Far
                .Splits(0).DisplayColumns("Cost").Style.HorizontalAlignment = AlignHorzEnum.Far

                For Each column As C1DisplayColumn In .Splits(0).DisplayColumns
                    column.AutoSize()
                    .Splits(0).DisplayColumns(column.Name).HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                Next

            End With
        Else
            DBGAcquisition.Columns.Clear()
        End If
    End Sub

    Private Sub DBGAcquisition_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGAcquisition.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGAcquisition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGAcquisition.Click
        With DBGAcquisition
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

End Class