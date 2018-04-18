Public Class FormRedemptionBank
    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        Dim frm As New FormRedemptionBankNew
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs)
        Dim frm As New FormRedemptionBankProfile
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class