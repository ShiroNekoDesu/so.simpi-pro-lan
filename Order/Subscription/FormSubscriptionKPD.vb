Public Class FormSubscriptionKPD
    Private Sub btnNew_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormSubscriptionKPDNew
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) 
        Dim frm As New FormSubscriptionKPDDelete
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class