Imports System.Threading
Public Class Form1
    Dim oHebra As Thread
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        Lstproceso.Items.Clear()
        oHebra = New Thread(AddressOf llenarLista)
        oHebra.Start()
    End Sub
    Private Sub llenarLista()
        CheckForIllegalCrossThreadCalls = False
        Dim iContador As Integer
        Dim iCuentaBis As Integer
        Lstproceso.Items.Add("ID Hebra: " & AppDomain.GetCurrentThreadId)
        While True
            iContador += 1
            Lstproceso.Items.Add("Contador pasos: " & iContador)
      
            Thread.CurrentThread.Sleep(500)
        End While

        oHebra.Abort()
    End Sub

    Private Sub BtnDetener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetener.Click
        oHebra.Abort()
        Lstproceso.Items.Add("Hebra Detenida")

    End Sub
End Class
