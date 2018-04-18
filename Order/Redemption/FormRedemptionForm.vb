Public Class FormRedemptionForm
    Private Sub btnNew_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormRedemptionFormNew
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormRedemptionFormProfile
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class