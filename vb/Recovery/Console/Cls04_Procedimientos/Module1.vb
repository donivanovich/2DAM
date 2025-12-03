Module Module1


    Sub Main()


        'Dim Localidad As String = "Madrid"
        'Dim Importe As Integer = 15044
        'Dim DiaHoy As Date = #10/22/2021#
        'Prueba(Localidad, Importe, DiaHoy)
        'Prueba(Cantidad:=Importe, Fecha:=DiaHoy, Ciudad:=Localidad)
        'Prueba1("Sevilla")
        'Prueba1("Zaragoza", 3550)
        Dim Valor As Integer = 1567
        Dim Ciudad As String = "Madrid"
        Dim Nombre As String = "Jorge"


        prueba2(Valor, Ciudad, Nombre)
        prueba2(45000, Ciudad, Nombre, "hola", "adios", "hasta siempre", "123")








        Console.ReadLine()
    End Sub
    Private Sub prueba2(importe As Integer, ParamArray MasDatos() As String)
        Dim contador As Byte
        For contador = 0 To UBound(MasDatos)
            Console.WriteLine("Elemento {0} - Valor: {1}", contador, MasDatos(contador))
        Next
    End Sub
    Private Sub Prueba(Ciudad As String, Cantidad As Integer, Fecha As Date)
        Console.WriteLine("{0} - {1} - {2}", Ciudad, Cantidad, Fecha)
    End Sub
    Private Sub Prueba1(Ciudad As String, Optional Cantidad As Integer = 1500)
        Console.WriteLine("{0} - {1}", Ciudad, Cantidad)
    End Sub


End Module