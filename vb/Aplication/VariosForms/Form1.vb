Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmForm1.Text = "Formulario Principal"
        Me.BackColor = Color.LightBlue
        Me.Width = 800
        Me.Height = 600
    End Sub

    Private Sub BtnAbrirForm_Click(sender As Object, e As EventArgs) Handles BtnAbrirForm.Click
        ' Dim FrmForm2 As New Form2
        Frmform2.Show()
    End Sub
End Class
