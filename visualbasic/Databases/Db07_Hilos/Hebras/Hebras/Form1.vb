Imports System.Threading
Public Class Form1
    Dim oHebra As Thread
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        oHebra = New Thread(AddressOf llenarLista)
        oHebra.Start()
    End Sub
    Private Sub llenarLista()

        CheckForIllegalCrossThreadCalls = False
        Dim iContador As Integer
        Dim iCuentaBis As Integer
        For iContador = 1 To 100000
            Lstproceso.Items.Add("Contador: " & iContador)
            For icuntabis = 1 To 50000
                'retardo
            Next

        Next
        oHebra.Abort()
    End Sub
End Class
