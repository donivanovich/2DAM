Imports System.IO
Public Class FrmUsuarios
    Dim NombreFpassword As String
    Dim Password As String = "joyfe"
    Dim cipherText As String
    Dim Escribir As StreamWriter
    Dim Lector As StreamReader
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        ' Dim Escribir As New StreamWriter("D:\contra3.txt", True) 'si el archivo existe se añade y si no se crea


        ' Dim plainText As String = InputBox("Enter the plain text:")
        'Dim password As String = InputBox("Enter the password:")

        Dim wrapper As New Simple3Des(Password)
        cipherText = wrapper.EncryptData(TxtPass.Text)

        ' MsgBox("The cipher text is: " & cipherText)
        'My.Computer.FileSystem.WriteAllText(
        'My.Computer.FileSystem.SpecialDirectories.MyDocuments &
        '"\cipherText.txt", cipherText, False)
        Escribir.WriteLine(TxtUsuario.Text & ";" & cipherText)
        TxtUsuario.Text = ""
        TxtPass.Text = ""

    End Sub



    'Private Sub FrmUsuarios_Click(sender As Object, e As EventArgs) Handles Me.Click
    '    Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
    '    My.Computer.FileSystem.SpecialDirectories.MyDocuments &
    '        "\cipherText.txt")
    '    Dim password As String = InputBox("Enter the password:")
    '    Dim wrapper As New Simple3Des(password)

    '    ' DecryptData throws if the wrong password is used.
    '    Try
    '        Dim plainText As String = wrapper.DecryptData(cipherText)
    '        MsgBox("The plain text is: " & plainText)
    '    Catch ex As System.Security.Cryptography.CryptographicException
    '        MsgBox("The data could not be decrypted with the password.")
    '    End Try

    'End Sub


    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oExplorador As New OpenFileDialog
        oExplorador.InitialDirectory = "C:\Users\tere\Desktop\VbNet-2019\Ficheros"
        ' oExplorador.DefaultExt = ".cla"
        oExplorador.Filter = "password(*.cla)|*.cla"
        oExplorador.CheckFileExists = False
        oExplorador.ShowDialog()
        NombreFpassword = oExplorador.FileName
        ' MessageBox.Show(NombreFpassword)

        'Password = InputBox("Enter the password:")
        oExplorador = Nothing
        Escribir = New StreamWriter(NombreFpassword, True) 'si el archivo existe se añade y si no se crea

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Escribir.Close()
        Me.Close()
    End Sub

    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        Escribir.Close()
        Dim Linea As String
        Dim wrapper As New Simple3Des(Password)
        Lector = New StreamReader(NombreFpassword)
        Dim plainText As String
        Linea = Lector.ReadLine
        Dim campos As String()
        While (Linea IsNot Nothing)
            ' MessageBox.Show(Linea)
            campos = Linea.Split(";")
            MessageBox.Show("Usuario: " & campos(0) & " password: " & campos(1))
            cipherText = campos(1)
            plainText = wrapper.DecryptData(cipherText)
            MessageBox.Show("Usuario: " & campos(0) & " password: " & plainText)
            Linea = Lector.ReadLine
        End While
        Escribir.Close()




    End Sub
End Class
