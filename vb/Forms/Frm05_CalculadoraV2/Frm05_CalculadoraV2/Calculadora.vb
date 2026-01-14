Public Class FrmCalculadora
    Dim Opera1 As Double
    Dim Opera2 As Double
    Dim operadores As Char



   
    Private Sub Btt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt1.Click
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

    End Sub

    Private Sub Btt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt2.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt3.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt4.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt5.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt6.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt7.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt8.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt9.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub Btt0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btt0.Click
        MostrarNumeros(sender)
    End Sub

    Private Sub BttC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttC.Click
        TxtNumeros.Text = "0"
    End Sub

    Private Sub BttSuma_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttSuma.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "+"


    End Sub

    Private Sub BttIgual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttIgual.Click
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

    Private Sub BttResta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttResta.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "-"
    End Sub

    Private Sub BttPor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttPor.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "*"
    End Sub

    Private Sub BttDiv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttDiv.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "/"
    End Sub

    Private Sub TxtNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeros.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
     
    End Sub

    Private Sub BttResto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttResto.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "R"
    End Sub

    Private Sub BttCientifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCientifica.Click
      
        Cientifica()
    End Sub

    Private Sub BttEstandar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttEstandar.Click
        Estandar()
    End Sub

   
    Private Sub BttRaiz_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttRaiz.Click
        TxtNumeros.Text = Math.Sqrt(Val(TxtNumeros.Text))
    End Sub

    Private Sub BttPotencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BttPotencia.Click
        Opera1 = TxtNumeros.Text
        TxtNumeros.Text = "0"
        operadores = "P"
    End Sub

    Private Sub MnuEstandar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEstandar.Click
        Estandar()
    End Sub
    Private Sub Estandar()
        Me.Size = New Point(291, 390)
        BttCientifica.Enabled = True
        BttEstandar.Enabled = False
        MnuEstandar.Enabled = False
        MnuCientifica.Enabled = True
    End Sub

    Private Sub MnuCientifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuCientifica.Click
        Cientifica()
    End Sub
    Private Sub Cientifica()
        Me.Size = New Point(372, 390)
        BttEstandar.Enabled = True
        MnuEstandar.Enabled = True
        BttCientifica.Enabled = False
        MnuCientifica.Enabled = False
    End Sub

    Private Sub MnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSalir.Click
        Me.Close()

    End Sub

    Private Sub FrmCalculadora_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub
    'fuera de la calculadora
    Private Sub BttOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttOperacion.Click
        Dim Texto1 As String = TxtUno.Text
        Dim texto2 As String = TxtDos.Text
        ' Txtresul.Text = Texto1.Length
        Txtresul.Text = texto2.IndexOf(Texto1)
        If Txtresul.Text = -1 Then
            Txtresul.Text = "no exixte el caracter"
        End If
        'Txtresul.Text = texto2.Substring(2, 4)

        Dim MiArray(10) As Char


    End Sub
End Class
