Public Class TextboxNumerico
    Private Sub TxtDato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDato.KeyPress
        If Not IsNumeric(e.KeyChar) Then e.Handled = True

    End Sub

    Public Sub CabioTam(ByVal x As Integer, ByVal y As Integer)
        TxtDato.Width = x
        TxtDato.Height = y
    End Sub
End Class
