Module Module1


    Sub Main()
        Dim valor As Integer
        Dim Cadena As String
        If IsNumeric(Cadena) Then


        End If
        If IsDate(Cadena) Then


        End If
        Dim colores() As String = {"Azul", "Verde", "Rojo", "Amarillo"}
        ' Verificar(colores)
        'Console.WriteLine(Int(66.88))
        'Console.WriteLine(Fix(66.88))




        Console.ReadLine()


    End Sub
    Private Sub Verificar(ValorPasado As Object)
        If IsArray(ValorPasado) Then
            Console.WriteLine(IsArray(ValorPasado))
        End If
    End Sub


End Module