Imports Servidor.WinSockServer ' para poder importarlo hay que añadir una referencia al proyecto
' coton derecho sobre el proyecto, agregar referncia
Public Class Form1

    Dim WithEvents WinSockServer As New Servidor.WinSockServer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With WinSockServer
            'Establezco el puerto donde escuchar 
            .PuertoDeEscucha = 8080

            'Comienzo la escucha 
            .Escuchar()
        End With
    End Sub

    Private Sub WinSockServer_NuevaConexion(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer.NuevaConexion
        'Muestro quien se conecto 
        MsgBox("Se ha conectado un nuevo cliente desde la IP= " & IDTerminal.Address.ToString & _
                                                                ",Puerto = " & IDTerminal.Port)
    End Sub


    Private Sub WinSockServer_ConexionTerminada(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer.ConexionTerminada
        'Muestro con quien se termino la conexion 
        MsgBox("Se ha desconectado el cliente desde la IP= " & IDTerminal.Address.ToString & _
                                                             ",Puerto = " & IDTerminal.Port)

    End Sub

    Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer.DatosRecibidos
        'Muestro quien envio el mensaje 
        MsgBox("Nuevo mensaje desde el cliente de la IP= " & IDTerminal.Address.ToString & _
                                                   ",Puerto = " & IDTerminal.Port)

        'Muestro el mensaje recibido 
        Call MsgBox(WinSockServer.ObtenerDatos(IDTerminal))

    End Sub

    Private Sub btnEnviarMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnviarMensaje.Click
        'Envio el texto escrito en el textbox txtMensaje a todos los clientes 
        WinSockServer.EnviarDatos(TxtMensaje.Text)
    End Sub
End Class
