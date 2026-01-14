Imports System.ComponentModel
Imports System.IO

Public Class FrmConversorNotas
    Private Sub FrmConversorNotas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Integer
        nota = TextBox1.Text
        Dim mensaje As String = ""

        Select Case nota
            Case 0 To 4
                mensaje = "insuficiente"
            Case 5
                mensaje = "suficiente"
            Case 6
                mensaje = "bien"
            Case 7 To 8
                mensaje = "notable"
            Case 9 To 10
                mensaje = "sobresaliente"
            Case Else
                mensaje = "Error"
        End Select

        MessageBox.Show($"Nota: {nota} → {mensaje}")
    End Sub
End Class