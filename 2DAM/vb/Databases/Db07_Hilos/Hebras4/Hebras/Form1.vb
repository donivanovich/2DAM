Imports System.Threading
Public Class Form1
    Dim oHebra As Thread
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        oHebra = New Thread(AddressOf ComprobarClave)
        oHebra.Start()
    End Sub
    Private Sub Comprobarclave()
        CheckForIllegalCrossThreadCalls = False
        Dim iContador As Integer
        While True
            iContador += 1
            LblContador.Text = iContador
            If TxtClave.Text = "778899" Then
                Lblestado.Text = "CORRECTA"
            Else
                Lblestado.Text = "INCORRECTA"

            End If
            oHebra.Sleep(250)
        End While
    End Sub

    Private Sub BtnParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParar.Click
        oHebra.Abort()
        LblContador.Text = ""
        Lblestado.Text = ""
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not (oHebra Is Nothing) Then
            If oHebra.IsAlive Then
                oHebra.Abort()
            End If
        End If
    End Sub
End Class
