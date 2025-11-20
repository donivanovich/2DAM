Public Class FrmCalculadora

    Dim Valor As Integer = 10

    Private Sub FrmCalculadora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim Res As Byte ' Esto es la declaración de una variable local
        Res = MessageBox.Show("¿Desea Finalizar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Res = vbNo Then e.Cancel = True


        'Else
        '    If Res = vbYes Then
        '    Else
        '        If Res = vbYes Then


        '        End If


        '    End If
        'End If



    End Sub
End Class




