Public Class FormRedemptionKPD
    Private Sub btnNew_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormRedemptionKPDNew
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormRedemptionKPDDelete
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class