Public Class FormSubscriptionForm
    Private Sub btnNew_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormSubscriptionFormNew
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormSubscriptionFormProfile
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class