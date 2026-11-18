Public Class FrmCalculadora
    Dim Opera1 As Double
    Dim Opera2 As Double
    Dim operadores As Char

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MostrarNumeros(sender)
    End Sub
    Private Sub MostrarNumeros(ByVal Boton As System.Windows.Forms.Button)
        If TxtNumeros.Text = "0" Then
            TxtNumeros.Text = Boton.Text
        ElseIf TxtNumeros.Text.Length < 15 Then
            TxtNumeros.Text = TxtNumeros.Text & Boton.Text
        Else
            MessageBox.Show("No se admiten más números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        '  End If




    End Sub
    'Private Function Ejemplo() As Byte
    '    Dim valor As Byte
    '    Return valor
    'End Function


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        MostrarNumeros(sender)
    End Sub


    Private Sub ButtonC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonC.Click
        TxtNumeros.Text = "0"
    End Sub


    Private Sub ButtonSuma_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSuma.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "+"




    End Sub


    Private Sub ButtonIgual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonIgual.Click
        Select Case operadores
            Case "+"
                Opera2 = Val(TxtNumeros.Text) + Opera1
            Case "-"
                Opera2 = Opera1 - Val(TxtNumeros.Text)
            Case "*"
                Opera2 = Val(TxtNumeros.Text) * Opera1
            Case "/"
                Opera2 = Opera1 / Val(TxtNumeros.Text)
            Case "R"
                Opera2 = Opera1 Mod TxtNumeros.Text
            Case "P"
                Opera2 = Math.Pow(Opera1, Val(TxtNumeros.Text))
        End Select


        TxtNumeros.Text = Opera2
    End Sub


    Private Sub ButtonResta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonResta.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "-"
    End Sub


    Private Sub ButtonMultiplicacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonMultiplicacion.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "*"
    End Sub


    Private Sub ButtonDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDivision.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "/"
    End Sub


    Private Sub TxtNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeros.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub BttResto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMod.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "R"
    End Sub


    Private Sub ButtonCientifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCientifica.Click
        Cientifica()
    End Sub


    Private Sub ButtonEstandar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEstandar.Click
        Estandar()
    End Sub



    Private Sub ButtonRaiz_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonRaiz.Click
        TxtNumeros.Text = Math.Sqrt(Val(TxtNumeros.Text))
    End Sub


    Private Sub ButtonPotencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonPotencia.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "P"
    End Sub


    'Private Sub MnuEstandar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEstandar.Click
    '    Estandar()
    'End Sub
    Private Sub Estandar()
        Me.Size = New Point(291, 390)
        ButtonCientifica.Enabled = True
        ButtonEstandar.Enabled = False
        'MnuEstandar.Enabled = False
        'MnuCientifica.Enabled = True
    End Sub


    'Private Sub MnuCientifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuCientifica.Click
    '    Cientifica()
    'End Sub
    Private Sub Cientifica()
        Me.Size = New Point(372, 390)
        ButtonEstandar.Enabled = True
        'MnuEstandar.Enabled = True
        ButtonCientifica.Enabled = False
        'MnuCientifica.Enabled = False
    End Sub


    'Private Sub MnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSalir.Click
    'Me.Close()
    'End Sub


    Private Sub FrmCalculadora_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub
    'fuera de la calculadora
    Private Sub ButtonOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOperacion.Click
        Dim Texto1 As String = TextBox1.Text
        Dim texto2 As String = TextBox2.Text
        ' Txtresul.Text = Texto1.Length
        TextBoxResultado.Text = texto2.IndexOf(Texto1)
        If TextBoxResultado.Text = -1 Then
            TextBoxResultado.Text = "no exixte el caracter"
        End If
        'Txtresul.Text = texto2.Substring(2, 4)


        Dim MiArray(10) As Char




    End Sub
    Private Sub FrmCalculadora_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New Size(303, 404)
        ' Me.Size.Height = New Size(309, 404)




    End Sub

End Class