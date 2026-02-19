'Espacio de nombres necesario
Imports System.Net.Mail
Imports System.Threading

Public Class FrmMail

    'variable array para adjuntos
    Dim Adjuntos() As String

    'instanciar la hebra
    Dim oHebra As Thread
    'Objeto SMTP
    Dim SMPT As New SmtpClient

    'Procedimiento
    Private Sub EnviarMail(ByVal StrDe As String, ByVal StrPara As String, _
                           ByVal StrAsunto As String, ByVal sAdjunto() As String, _
                           ByVal StrMensaje As String)
        Try

            'variable tipo mensaje con parametros De: Para:
            Dim Msg As New MailMessage(New MailAddress(StrDe), New MailAddress(StrPara))
            'asunto
            Msg.Subject = StrAsunto
            'mensaje
            Msg.Body = StrMensaje

            'ADJUNTOS
            For Each FAdjunto As String In sAdjunto
                If Not FAdjunto = "" Then
                    'Objeto tipo attachment
                    Dim Adjunto As New Attachment(FAdjunto)
                    'agregar adjunto al objeto mensaje
                    Msg.Attachments.Add(Adjunto)
                End If
            Next

            'DATOS SMTP
            
            'Credenciales
            SMPT.Credentials = New System.Net.NetworkCredential _
            ("usuario@gmail.com", "password")
            'Host, Puerto, autenticacion
            SMPT.Host = "smtp.gmail.com"
            SMPT.Port = 587
            SMPT.EnableSsl = True
            SMPT.Timeout = 10
            'Enviar
            SMPT.Send(Msg)

            'regresar cursor y controles a modo normal
            Me.Cursor = Cursors.Default
            btnEnviar.Enabled = True
            ProgressBar1.Visible = False
            Label6.Visible = False

        Catch ex As Exception
            'regresar cursor y controles a modo normal
            Me.Cursor = Cursors.Default
            btnEnviar.Enabled = True
            ProgressBar1.Visible = False
            Label6.Visible = False
            MsgBox(ex.Message)
        End Try
    End Sub

    'función para validar formato de dirección Email
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As  _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function


    Private Sub TxtDe_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDe.Validating
        'si la validación no pasa se visualiza el errorprovider
        If ValidateEmail(TxtDe.Text.Trim) Then
            e.Cancel = False
            ErrorProvider1.SetError(TxtDe, "")
        Else
            e.Cancel = True
            ErrorProvider1.SetError(TxtDe, "La dirección de correo no es válida. Presione F1 para obtener ayuda.")
        End If
    End Sub
    Private Sub TxtPara_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtPara.Validating
        If ValidateEmail(TxtPara.Text.Trim) Then
            e.Cancel = False
            ErrorProvider1.SetError(TxtPara, "")
        Else
            e.Cancel = True
            ErrorProvider1.SetError(TxtPara, "La dirección de correo no es válida. Presione F1 para obtener ayuda.")
        End If
    End Sub
    Private Sub FrmMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' se establece el texto de ayuda al pulsar F1 en los textboxs
        HelpProvider1.SetHelpString(TxtDe, "Una dirección de correo válida debe tener el formato: alguien@microsoft.com")
        HelpProvider1.SetHelpString(TxtPara, "Una dirección de correo válida debe tener el formato: alguien@microsoft.com")
    End Sub

    Private Sub BtnAdjuntos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdjuntos.Click
        'para obtener adjuntos
        'establecemos filtros para mostrar todos los archivos
        OpenFileDialog1.Filter = "Todos los archivos|*.*"
        'mostramos el dialogo
        OpenFileDialog1.ShowDialog()
        'agregamos la ruta del adjunto
        CboAdjunto.Items.Add(OpenFileDialog1.FileName)
        'visualizamos la ruta
        CboAdjunto.SelectedIndex = CboAdjunto.Items.Count - 1
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        'obtenemos los adjuntos
        ReDim Preserve Adjuntos(0 To CboAdjunto.Items.Count - 1)
        For i As Integer = 0 To Adjuntos.Length - 1
            Adjuntos(i) = CboAdjunto.Items.Item(i).ToString
        Next
   
        Me.Cursor = Cursors.WaitCursor
        btnEnviar.Enabled = False

        'poner en marcha la hebra
        oHebra = New Thread(AddressOf Envio)
        ProgressBar1.Visible = True
        Label6.Visible = True
        oHebra.Start()

    End Sub

    Private Sub Envio()
        'al finalizar el envío, abortar la hebra
        Control.CheckForIllegalCrossThreadCalls = False
        EnviarMail(TxtDe.Text.Trim, TxtPara.Text.Trim, TxtAsunto.Text, Adjuntos, TxtMensaje.Text)
        oHebra.Abort()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'cancelamos la operación
        SMPT.SendAsyncCancel()
    End Sub
End Class
