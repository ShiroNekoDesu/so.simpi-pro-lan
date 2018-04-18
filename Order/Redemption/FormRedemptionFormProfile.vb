Public Class FormRedemptionFormProfile
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New FormRedemptionFormEdit
        frm.Left = 0
        frm.Top = 30
        frm.MdiParent = MDISO
        frm.Show()
    End Sub
End Class