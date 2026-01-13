Module Module1

    Sub Main()

        'Dim Resultado As Integer
        'Dim NuevoValor As Integer
        'calcular()
        'calcular(8)
        'calcular(6, True)
        'calcular(False)
        Dim Nombre As String
        Nombre = "Alvaro"
        'prueba(Nombre)
        Prueba(Nombre)
        Console.WriteLine("El nombre es: {0}", Nombre)
        Console.ReadLine()


    End Sub
    'Private Sub Prueba(ByVal Valor As String)
    '    Console.WriteLine("El nombre es: {0}", Valor)
    '    Valor = "Ines"
    '    Console.WriteLine("El nombre es: {0}", Valor)
    'End Sub
    Private Sub Prueba(ByRef Valor As String)
        Console.WriteLine("El nombre es: {0}", Valor)
        Valor = "Ines"
        Console.WriteLine("El nombre es: {0}", Valor)
    End Sub


    'Private Function calcular() As Integer
    '    Dim MiValor As Integer
    '    Console.WriteLine("Introduce un valor de 1 a 100")
    '    MiValor = Console.ReadLine
    '    Return MiValor


    'End Function
    'Private Function calcular(Otrovalor As Integer) As Integer
    '    Dim MiValor As Integer = Otrovalor
    '    Console.WriteLine("Introduce un valor de 1 a 100")
    '    MiValor = Console.ReadLine
    '    Return MiValor


    'End Function
    'Private Function calcular(Otrovalor As Integer, SW As Boolean) As Integer
    '    Dim MiValor As Integer = Otrovalor
    '    Console.WriteLine("Introduce un valor de 1 a 100")
    '    MiValor = Console.ReadLine
    '    Return MiValor


    'End Function
    'Private Sub calcular(sw As Boolean)


    'End Sub
    ''Private Sub prueba()




    ''    Return False
    ''End Sub

End Module
