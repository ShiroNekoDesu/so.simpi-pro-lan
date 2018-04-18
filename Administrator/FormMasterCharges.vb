Imports C1.Win.C1TrueDBGrid
Imports simpi.ParameterFA
Imports simpi.globalutilities
Imports simpi.globalutilities.GlobalString
Imports simpi.CoreBilling
Imports simpi.MasterPortfolio
Imports Microsoft.Office.Interop

Public Class FormMasterCharges
    Dim objSetting As New FundSetting
    Dim objPortfolio As New MasterPortfolio
    Dim objFee As New ParameterCharges

    Private Sub csMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles csMenu.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Detach"
                MdiParent = Nothing
                e.ClickedItem.Text = "Attach"
            Case "Attach"
                e.ClickedItem.Text = "Detach"
                MdiParent = MDISO
            Case "Close"
                Close()
            Case "Export"
                PrintExcel(DBGFee)
        End Select
    End Sub

    Private Sub FormMasterManagementFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMasterSimpi()
        GetComboInit(New ParameterCharges, cmbFee, "FeeID", "FeeCode")
        objSetting.UserAccess = objAccess
        objPortfolio.UserAccess = objAccess
        objFee.UserAccess = objAccess
        DBGFee.FetchRowStyles = True
    End Sub

    Private Sub cmbFee_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFee.SelectedValueChanged
        DBGFee.Columns.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FeeSearch()
    End Sub

    Private Sub txtKeyword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            FeeSearch()
        End If
    End Sub

    Public Sub FeeSearch()
        If cmbFee.SelectedIndex <> -1 Then
            Dim dtPortfolio As New DataTable
            Dim dtFee As New DataTable
            objPortfolio.Clear()
            Dim strKeyword As String = SQLKeyword(txtKeyword.Text, IIf(rbNone.Checked, rbNone.Text, IIf(rbAnd.Checked, rbAnd.Text, IIf(rbOr.Checked, rbOr.Text, rbCombine.Text))))
            dtPortfolio = objPortfolio.Search(objMasterSimpi, strKeyword, 0, 0, 0, 0, 0)
            If objPortfolio.ErrID = 0 Then
                If dtPortfolio IsNot Nothing AndAlso dtPortfolio.Rows.Count > 0 Then
                    objSetting.Clear()
                    dtFee = objSetting.Search(cmbFee.SelectedValue, txtKeyword.Text)
                    Dim query = From p In dtPortfolio.AsEnumerable
                                Group Join f In dtFee.AsEnumerable On
                                      p.Field(Of Integer)("PortfolioID") Equals f.Field(Of Integer)("PortfolioID")
                                Into pf = Group Let f = pf.FirstOrDefault
                                Select
                                 ID = p.Field(Of Integer)("PortfolioID"),
                                 Code = p.Field(Of String)("PortfolioCode"),
                                 Name = p.Field(Of String)("PortfolioNameshort"),
                                 Basis = If(f Is Nothing, "", ParameterFA.SetChargesAccrualBasis(CByte(f.Field(Of SByte)("TypeBasis")))),
                                 Accrual = If(f Is Nothing, "", ParameterFA.SetChargesAccrualType(CByte(f.Field(Of SByte)("TypeAccrual")))),
                                 Calculation = If(f Is Nothing, "", ParameterFA.SetChargesCalculationType(CByte(f.Field(Of SByte)("TypeCalculation")))),
                                 Amount = If(f Is Nothing, 0, f.Field(Of Decimal)("FixedAmount")),
                                 Rate = If(f Is Nothing, 0, f.Field(Of Decimal)("FlatRate") * 100),
                                 AUM = If(f Is Nothing, "", ParameterFA.SetChargesAUMType(CByte(f.Field(Of SByte)("TypeAUM"))))
                    With DBGFee
                        .AllowAddNew = False
                        .AllowDelete = False
                        .AllowUpdate = False
                        .Style.WrapText = False
                        .Columns.Clear()
                        .DataSource = query.ToList

                        .Columns("Amount").NumberFormat = "n2"
                        .Columns("Rate").NumberFormat = "n5"

                        For Each column As C1DisplayColumn In DBGFee.Splits(0).DisplayColumns
                            column.AutoSize()
                        Next

                    End With
                Else
                    DBGFee.Columns.Clear()
                End If
            Else
                DBGFee.Columns.Clear()
                ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            btnProfile.Enabled = False
        End If
    End Sub

    Private Sub DBGFee_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGFee.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub DBGFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFee.Click
        With DBGFee
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                btnProfile.Enabled = True
            End If
        End With
    End Sub

    Private Sub DBGFee_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBGFee.DoubleClick
        FeeProfile()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        FeeProfile()
    End Sub

    Private Sub FeeProfile()
        With DBGFee
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                objPortfolio.Clear()
                objPortfolio.LoadCode(objMasterSimpi, .Columns("Code").Text)
                If objPortfolio.ErrID = 0 Then
                    If objPortfolio.IsPortfolio Then
                        Dim frm As New FormMasterChargesProfile
                        frm.Show()
                        frm.objPortfolio = objPortfolio
                        frm.FeeID = cmbFee.SelectedValue
                        frm.FormLoad()
                        frm.CallerForm = Me
                        frm.MdiParent = MDISO
                    End If
                Else
                    ExceptionMessage.Show(objPortfolio.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Sub


End Class