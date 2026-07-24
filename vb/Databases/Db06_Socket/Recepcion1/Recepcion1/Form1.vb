Imports Cliente.Cliente
Public Class Form1


    Dim WithEvents WinSockCliente As New Cliente.Cliente

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConectar.Click
        With WinSockCliente
            'Determino a donde se quiere conectar el usuario 
            .IPDelHost = TxtIP.Text
            .PuertoDelHost = TxtPuerto.Text

            'Me conecto 
            .Conectar()

            'Deshabilito la posibilidad de conexion 
            TxtIP.Enabled = False
            TxtPuerto.Enabled = False
            BtnConectar.Enabled = False


            'Habilito la posibilidad de enviar mensajes 
            BtnEnviarMensaje.Enabled = True
            TxtMensaje.Enabled = True
        End With
    End Sub

    Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles WinSockCliente.DatosRecibidos
        MsgBox("El servidor envio el siguiente mensaje: " & datos)
    End Sub

    Private Sub WinSockCliente_ConexionTerminada() Handles WinSockCliente.ConexionTerminada
        MsgBox("Finalizo la conexion")

        'Habilito la posibilidad de una reconexion 
        TxtIP.Enabled = True
        TxtPuerto.Enabled = True
        BtnConectar.Enabled = True

        'Deshabilito la posibilidad de enviar mensajes 
        BtnEnviarMensaje.Enabled = False
        TxtMensaje.Enabled = False
    End Sub

    Private Sub btnEnviarMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviarMensaje.Click
        'Envio lo que esta escrito en la caja de texto del mensaje 
        WinSockCliente.EnviarDatos(TxtMensaje.Text)
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

End Class
