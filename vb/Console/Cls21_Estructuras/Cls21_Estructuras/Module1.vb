Module Module1


    Sub Main()
        Dim oEmple As New Empleado
        '  Dim OtroEmple As New Empleado
        'Console.WriteLine(oEmple.VerNOmbre())
        'Console.WriteLine(OtroEmple.VerotroNOmbre())
        Dim sBanco As DatosBanco
        With sBanco
            .Iban = "ES45"
            .NBanco = 1048
            .NSucur = 245
        End With
        ' Console.WriteLine(sBanco.Iban)
        Dim FechaActual As Date = "12/12/2021"
        Dim fechaA, FechaB As Date
        Dim FechaStruc As DateTime
        'Console.WriteLine(FechaActual)
        'FechaStruc = New DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day)
        'Console.WriteLine(FechaStruc)
        'FechaActual.Year, FechaActual.Month, FechaActual.Day)
        '                          (Now.Year, Now.Month, Now.Day)
        'Console.WriteLine(FechaStruc.AddDays(1785000))
        'FechaStruc = FechaStruc.AddDays(15)
        'Console.WriteLine(FechaStruc)
        '  FechaStruc = New DateTime()
        'FechaActual = FechaStruc.AddDays(20)
        'Console.WriteLine(FechaActual)
        FechaActual = DateTime.Today
        '  Console.WriteLine(FechaActual)
        '   FechaActual = FechaActual.Today
        '  Console.WriteLine(DateTime.DaysInMonth(2008, 2))
        Dim Cadena As String = "La muúsica que me  La la La gsuta"
        Dim CadenaAgregar As String
        Dim CadenaRellena As String
        'Valormusica = Musicas.NewAge
        'Dim ValoresMusica As Musicas1
        ''Console.WriteLine(Valormusica)
        ''Console.WriteLine(Musicas1.Pop)
        ''Console.WriteLine(Musicas1.Rock)
        ''Console.WriteLine(Valormusica.ToString())
        ''Console.WriteLine(Musicas.NewAge.ToString())

        'Dim LiValores() As Integer
        'Dim LsNombres() As String
        'Dim LiContador As Integer
        'LiValores = System.Enum.GetValues(ValoresMusica.GetType())
        'LsNombres = System.Enum.GetNames(ValoresMusica.GetType())
        'For LiContador = 0 To UBound(LiValores)
        '    Console.WriteLine(LiValores(LiContador) & Space(7) & LsNombres(LiContador))
        'Next
        ''Dim emple As New Empleado
        ''Dim otroemple As Empleado = emple
        'Console.WriteLine(Valormusica)
        'Console.WriteLine(Valormusica.Trim())
        'CadenaRellena = Cadena.PadLeft(30)


        ' Console.WriteLine(Cadena.Insert(2, "Hola"))
        'Console.WriteLine(Cadena.Remove(5, 3))
        '"La muúsica que me gsuta"   "la muca que me gsuta"
        'Console.WriteLine(Cadena.Replace("La", "AA"))
        'Dim Caracter As Char
        'Caracter = Convert.ToChar(Console.ReadLine)
        'Console.WriteLine("*************" & Caracter)
        'Dim Datos1(2, 4, 5, 7, 8, 9) As Integer
        'Console.WriteLine(Datos1.Rank)
        'Console.Read()

        Try
            Dim oEmpleadoMas As New Empleado
            'Dim oempleadoOtromas As Empleado = oEmpleadoMas
            'oempleadoOtromas = oEmpleadoMas
            Dim Estaciones As New ArrayList
            Dim Datos As New ArrayList(New String() {"a", "b", "c"})
            Estaciones.Add("Primavera")
            Estaciones.Add(11111)
            Estaciones.Add(oEmple)
            Estaciones.Add(Datos)
            Estaciones.Add("VACACIONES")
            Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Dim obArrayList As Object
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            'Estaciones.Add(oEmple)
            'Estaciones.Add("Primavera")
            'Estaciones.Add(11111)
            'Estaciones.Add(oEmple)
            'Estaciones.Add(Datos)
            'Estaciones.Add("VACACIONES")
            ' Estaciones.TrimToSize()
            Estaciones.Add("Primavera")
            Estaciones.Add(11111)
            Estaciones.Add(oEmple)
            Estaciones.Add(Datos)
            Estaciones.Add("VACACIONES")
            Estaciones.Add(oEmple)
            'For Each obArrayList In Estaciones
            '    Console.WriteLine(obArrayList)
            'Next
            Dim i As Byte = 10
            ''For i = 0 To UBound(Estaciones.ToArray)
            ''    Console.WriteLine(Estaciones.Item(i))
            ''Next
            'Console.WriteLine(Estaciones.Capacity)
            'Console.WriteLine(Estaciones.Count)
            'Console.WriteLine(Estaciones.Item(Estaciones.Count - 1))
            i = Estaciones.IndexOf("VACIONES")
            Console.WriteLine("Elemento encontrado: " & i)

        Catch ex As OverflowException
            Console.WriteLine("elemento no encontrado")

            'Catch ex As Exception
            '    ' ValorError = ex
            '    ControlErrores(ex)

            ' Console.WriteLine("Error")
        End Try



        Console.ReadLine()


    End Sub
    Public Structure DatosBanco
        Public Iban As String
        Public NBanco As Integer
        Public NSucur As Integer
    End Structure
    Public Enum Musicas
        Rock
        Blues
        NewAge
        Funky
    End Enum

    Public Enum Musicas1
        Rock = 3
        Blues
        Flamenco
        NewAge = 1
        Funky
        Pop
    End Enum

End Module
Public Class Empleado
    Public Shared Function VerNOmbre() As String
        Return "Tere"
    End Function
    Public Function VerotroNOmbre() As String
        Return "Inés"
    End Function
End Class