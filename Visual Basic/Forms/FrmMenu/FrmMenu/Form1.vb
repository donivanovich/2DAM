Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MnuEditar.Visible = False
        MnuSalir.Enabled = False
    End Sub

    Private Sub MnuActivae_Click(sender As Object, e As EventArgs) Handles MnuActivae.Click
        MnuEditar.Visible = True
        MnuSalir.Enabled = True

    End Sub

    Private Sub MnuAbrir_Click(sender As Object, e As EventArgs) Handles MnuAbrir.Click
        FrmCalculadora.Show()
    End Sub
End Class
