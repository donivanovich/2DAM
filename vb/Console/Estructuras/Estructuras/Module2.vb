Module Module2
    ' Public ValorError As Exception
    Public Sub ControlErrores(ex As Exception)

        '  Console.WriteLine("Error: " & ValorError.ToString)
        Console.WriteLine("Error: " & ex.Message)

        Select Case ex.Message
            Case "La operación aritmética ha provocado un desbordamiento."
                Console.WriteLine("Elemto no encontrado")


        End Select



    End Sub
End Module
