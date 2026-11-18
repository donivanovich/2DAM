Imports System.IO
Public Class Form1
    Dim Admin As Byte
    Dim Usuario As String
    Dim Password As String
    Dim DlgAbrir As New OpenFileDialog
    Dim DlgGuardar As New SaveFileDialog
    Dim DlgColor As New ColorDialog
    Dim DlgFuente As New FontDialog
    Dim DlgPrint As New PrintDialog
    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        DlgGuardar = New SaveFileDialog
        DlgGuardar.ShowDialog()
        Dim Escribir As New StreamWriter(DlgGuardar.FileName, True) 'si el archivo existe se añade y si no se crea
        Usuario = TxtUsuario.Text
        Password = TxtPass.Text
        Admin = 0
        If ChkAdmin.Checked = True Then Admin = 1
        Escribir.Write(Usuario & ";" & Password & ";" & "1")
        'Escribir.WriteLine(Password)
        'Escribir.Write(Usuario & ";" & Password & "*")
        Escribir.Close()
        DlgGuardar = Nothing
    End Sub
    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        'DlgAbrir
        DlgAbrir.ShowDialog()
        Dim Leer As New StreamReader(DlgAbrir.FileName, True)
        BtnLeer.Enabled = False
        Dim CarLeido As Integer

        'Usuario = Leer.ReadLine
        'Password = Leer.ReadLine
        'TxtUsuario.Text = Usuario
        'TxtPass.Text = Password
        CarLeido = Leer.Read
        Do While Not (CarLeido = -1)
            Do While Not (Chr(CarLeido) = ";")
                TxtUsuario.Text = TxtUsuario.Text & Chr(CarLeido)
                '  MessageBox.Show(CarLeido)
                CarLeido = Leer.Read
            Loop
            CarLeido = Leer.Read
            Do While Not (Chr(CarLeido) = ";")
                TxtPass.Text = TxtPass.Text & Chr(CarLeido)
                '   MessageBox.Show(CarLeido)
                CarLeido = Leer.Read
            Loop
            CarLeido = Leer.Read
            If Chr(CarLeido) = "1" Then
                ChkAdmin.Checked = True
            Else
                ChkAdmin.Checked = False
            End If
            '  CarLeido = Leer.Read
            CarLeido = Leer.Read
            MessageBox.Show("a")
            TxtUsuario.Text = ""
            TxtPass.Text = ""

        Loop


        'Do While (Not Usuario Is Nothing)
        '    TxtUsuario.Text = Usuario
        '    TxtPass.Text = Password
        '    MessageBox.Show("Siguiente")
        '    Usuario = Leer.ReadLine
        '    Password = Leer.ReadLine
        'Loop
        MessageBox.Show("Final archivo")
        BtnLeer.Enabled = True
        Leer.Close()
    End Sub

    Private Sub BtnPruebaDialog_Click(sender As Object, e As EventArgs) Handles BtnDialog.Click
        'DlgColor.ShowDialog()
        'MessageBox.Show(DlgColor.Color.ToString, "Colores")
        'DlgFuente.ShowColor = True
        'DlgFuente.ShowEffects = True
        DlgPrint.ShowDialog()
        'MessageBox.Show(DlgFuente.Font.ToString, "Fuente")
    End Sub
End Class