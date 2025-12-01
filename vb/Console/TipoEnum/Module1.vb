Module Module1




    Sub Main()
        Dim oEmple As Empleado
        Dim OtroEmple As New Empleado
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
        Dim Valormusica As String


        Valormusica = Musicas.NewAge
        Dim ValoresMusica As Musicas
        'Console.WriteLine(Valormusica)
        'Console.WriteLine(Valormusica.ToString())
        Dim LiValores() As Integer
        Dim LsNombres() As String
        Dim LiContador As Integer
        LiValores = System.Enum.GetValues(ValoresMusica.GetType())
        LsNombres = System.Enum.GetNames(ValoresMusica.GetType())
        For LiContador = 0 To UBound(LiValores)
            Console.WriteLine(LiValores(LiContador) & Space(7) & LsNombres(LiContador))
        Next














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
        Rock = 10
        Blues
        NewAge = 1
        Funky
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