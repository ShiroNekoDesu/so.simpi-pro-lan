Public Class FormRedemptionSettle
    Private Sub btnSettle_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormRedemptionSettleProfile
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class