Module Module1
    Public nombre As String
    Sub Main()
        'Totales(3000)
        'Calculos.Totales(500)
        'Dim valor As Integer
        Verificacion("Primera")
        Verificacion("Segunda")
        Verificacion("Tercera")




        Console.ReadLine()
    End Sub
    'Private Sub Verificacion(OrdenLlamada As String)
    '    Dim importe As Integer = 5
    '    importe += 2
    '    Console.WriteLine("Orden llamada:{0} importe: {1}", OrdenLlamada, importe)
    'End Sub
    Private Sub Verificacion(OrdenLlamada As String)
        Static Dim importe As Integer = 5
        importe += 2
        Console.WriteLine("Orden llamada:{0} importe: {1}", OrdenLlamada, importe)
    End Sub




    'Private Sub cambio()
    '    nombre = "Raul"
    'End Sub


End Module
Module Calculos
    Public Sub Totales(Importe As Integer)
        Dim resultado As Integer
        resultado = Importe + 1000
        Console.WriteLine(resultado)
    End Sub
    Private Sub Totales1(Importe As Integer)
        Dim resultado As Integer
        resultado = Importe + 1000
        Console.WriteLine(resultado)
    End Sub
End Module