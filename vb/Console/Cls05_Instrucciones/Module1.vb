Module Module1

    Sub Main()
        Dim valor As Integer
        If valor = 0 Then Console.WriteLine("sola linea no tiene EndIf")


        If valor = 0 Then


        Else
            If valor = 1 Then


            End If




        End If




        If valor = 0 Then


        ElseIf valor = 1 Then


        End If
        Select Case valor
            Case 1
                Console.WriteLine("valor 1")
            Case 120, 150
                Console.WriteLine("si 120 o 150")
            Case 300 To 400
                Console.WriteLine("entre 300 y 400")
            Case Is < 10
                Console.WriteLine("menor de 10")
            Case Else
                Console.WriteLine("cualquier otro valor")






        End Select


        While valor < 10


        End While


        Do While valor <> 10


        Loop


        Do Until valor = 20


        Loop


        Do


        Loop While valor < 10
        Do


        Loop Until valor = 20


        Do
            If valor = 100 Then Exit Do
        Loop


        For valor = 0 To 10 Step 4


        Next




        For valor = 20 To 10 Step -1


        Next


        Dim Alumnos(3) As String


        Dim alumno As String


        For Each alumno In Alumnos


        Next
    End Sub

End Module
