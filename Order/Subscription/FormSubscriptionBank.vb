Public Class FormSubscriptionBank
    Private Sub btnNew_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormSubscriptionBankNew
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormSubscriptionBankProfile
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class