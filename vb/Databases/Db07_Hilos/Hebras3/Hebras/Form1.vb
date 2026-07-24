Imports System.Threading
Public Class Form1

    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click

        Dim oHebra As Thread
        Lstproceso.Items.Clear()
        For i = 0 To 5
            oHebra = New Thread(AddressOf AgregarConRetardo)
            oHebra.Start()
            oHebra.Join(1000)
        Next

        'If oHebra.Join(1000) Then
        '    LblMensaje.Text = "hebra finalizada"
        'Else
        '    LblMensaje.Text = "hebra NO finalizada"
        'End If
    End Sub
    Private Sub AgregarConRetardo()
        CheckForIllegalCrossThreadCalls = False
        Dim Contador As Integer
        Lstproceso.Items.Add("Sub agregar con retardo - ejecutando en hebra: " & AppDomain.GetCurrentThreadId)
        For Contador = 1 To 5
            Lstproceso.Items.Add("       hebra: " & AppDomain.GetCurrentThreadId.ToString & "  paso: " & Contador)
            Thread.CurrentThread.Sleep(250)

        Next

    End Sub

   
End Class
