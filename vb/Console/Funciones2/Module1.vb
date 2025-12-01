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
        'Len(Cadena)
        'Cadena = Space(5)
        'InStr([comienzo,] cadenabuscar, cadenabuscada [,tipocomparación])
        'Left(Cadena, longitud)
        ' Right(Cadena, longitud)
        'Mid(Cadena, inicio [,longitud]) 
        'Replace(Cadena, cadorigen, cadnuev[, inicio][, sustitución][, tipoconversión])
        'LTrim(Cadena)
        'RTrim(Cadena)
        'Trim(Cadena)


        '"  MAría Teresa"
        '"MAría Teresa  "
        ' "  MAría Teresa  "
        '"MAría Teresa"


        'UCase(Cadena)
        'LCase(Cadena)
        Dim fecha As Date
        Dim numero As Double
        Dim ValorFormato As String
        numero = 1899
        fecha = #10/25/2021 3:34:00 PM#
        Console.WriteLine(Format(fecha, "Long Date"))
        Console.WriteLine(Format(fecha, "Short Date"))
        Console.WriteLine(Format(numero, "Standard"))
        Console.WriteLine(Format(numero, "Currency"))
        Console.WriteLine(Format(numero, "Percent"))


        ' Caracteres especiales patrón
        '  : separador hora
        ' / separador fecha
        ' d visualiza el número de día sin cero a la izq

        ' dd visualiza el número de día con cero a la izq

        ' ddd visualiza el nombre de día abreviado
        ' dddd visualiza el nombre de día completo

        ' M  visualiza el número de mes sin cero a la izq
        ' MM  visualiza el número de mes con cero a la izq
        ' MMM visualiza el nombre de mes abreviado
        ' MMMM visualiza el nombre de mes completo
        ' yyyy  visualiza los 4 dígitos del año
        ' H  visualiza hora sin cero a la izq
        ' MM  visualiza hora  con cero a la izq
        ' m  visualiza minutos sin cero a la izq
        ' mm  visualiza minutos con cero a la izq
        ' s  visualiza segundos sin cero a la izq
        ' ss  visualiza segundos con cero a la izq
        ' 0  en valores numéricos visualiza un dígito o cero 
        ' #  en valores numéricos visualiza un dígito o nada
        ' ,  separación millar
        ' .  separación decimal

        Console.WriteLine(Format(fecha, "dddd d/MMM/yyyy"))   ' viernes 29/oct/2021

        Console.WriteLine(Format(fecha, "HH:mm"))   ' 15:30
        Dim Valor As Double = 16587.097        Console.WriteLine(Format(Valor, "#,#.00" ))   ' 16.587,10
        Dim Micadena As String
        Dim Conversion As String
        Micadena = "El tren lle puntual"
        Conversion = StrConv(Micadena, VbStrConv.Uppercase) ' Convierte a Mayúsculas 
        Conversion = StrConv(Micadena, VbStrConv.Lowercase) ' Convierte a Minúsculas 
        Conversion = StrConv(Micadena, VbStrConv.ProperCase) ' Convierte a May la primera letra de cada                                                                                                                           'palabra 
        Dim MiFecha As Date
        Dim DiasDiferencia As Long
        Dim FechaPosterior As Date
        Dim FechaAnterior As Date
        Dim ParteFecha As Integer
        MiFecha = Now() ' Devuelve fecha y hora actual
        FechaAnterior = DateAdd(DateInterval.Month, -2, MiFecha) 'Resta a una fecha el intervalo especificado
        DiasDiferencia = DateDiff(DateInterval.Day, MiFecha, FechaPosterior)
        'Calcula la diferencia entre dos  fechas, segun el intervalo indicado, dias, meses... 
        ParteFecha = DatePart(DateInterval.Year, MiFecha) ' Extrae la parte de la fecha especificada

        Console.ReadLine()




    End Sub
    Private Sub Verificar(ValorPasado As Object)
        If IsArray(ValorPasado) Then
            Console.WriteLine(IsArray(ValorPasado))
        End If
    End Sub




End Module