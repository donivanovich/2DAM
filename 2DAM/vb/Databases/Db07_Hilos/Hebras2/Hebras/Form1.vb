Imports System.Threading
Public Class Form1
    ' Dim t As New System.Timers.Timer(10000)
    Dim i As Long
    Dim oHebra As Thread
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click

        Dim iContador As Integer
        Lstproceso.Items.Clear()
        For iContador = 1 To 10
            System.Threading.Thread.Sleep(250)

            oHebra = New Thread(AddressOf llenarLista)
            ' MessageBox.Show(AppDomain.GetCurrentThreadId, "Hebra activa", MessageBoxButtons.OK)
            oHebra.Start()

            '     MessageBox.Show("hebra activa")
            'For i = 0 To 1500
            '    Dim a As Integer
            '    For a = 0 To 1500
            '        Dim res As Integer
            '        res = 150 / 5 * 2 + 1 * 89 / 4
            '    Next

            'Next


        Next




        ' Thread.SpinWait(10000)

        'intervalo en milisegundos
        't.Enabled = True 'para que lance el evento elapsed cuando le toque
        't.Start()


        't = Nothing
        '  MessageBox.Show(AppDomain.GetCurrentThreadId, "hebra actual", MessageBoxButtons.OK)
        ' System.Threading.Thread.Sleep(1000)
        'Dim x As Integer
        'For x = 0 To 1125000
        '    Dim a As Integer
        '    a += 10
        'Next



    End Sub
    'Private Sub t_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles t.Elapsed
    '    Dim oHebra As Thread
    '    oHebra = New Thread(AddressOf llenarLista)
    '    ' MessageBox.Show(AppDomain.GetCurrentThreadId, "Hebra activa", MessageBoxButtons.OK)
    '    oHebra.Start()
    'End Sub
    Private Sub llenarLista()
        CheckForIllegalCrossThreadCalls = False
        '  MessageBox.Show(AppDomain.GetCurrentThreadId, "hebra actual", MessageBoxButtons.OK)
        Dim iContador As Integer
        Lstproceso.Items.Add("Sub Llenar Lista - ejecutandose en hebra: " & AppDomain.GetCurrentThreadId)

        For iContador = 1 To 7
            Lstproceso.Items.Add(ControlChars.Tab & AppDomain.GetCurrentThreadId & " Paso " & iContador)


        Next

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Dim oHebra As Thread
    '    oHebra = New Thread(AddressOf llenarLista)
    '    ' MessageBox.Show(AppDomain.GetCurrentThreadId, "Hebra activa", MessageBoxButtons.OK)
    '    oHebra.Start()
    '    i = i + 1
    'End Sub
End Class
