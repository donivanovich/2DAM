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
        Console.WriteLine(FechaActual)
        FechaStruc = New DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day)
        '                          (Now.Year, Now.Month, Now.Day)
        Console.WriteLine(FechaStruc.AddDays(15))
        Console.WriteLine(FechaActual)
        ' FechaStruc = New DateTime()
        FechaActual = FechaStruc.AddDays(20)
        Console.WriteLine(FechaActual)
        FechaActual = DateTime.Today
        ' FechaActual = FechaActual.Today
        'Console.WriteLine(DateTime.DaysInMonth(2021, 11))


        Console.ReadLine()
    End Sub
    Public Structure DatosBanco
        Public Iban As String
        Public NBanco As Integer
        Public NSucur As Integer
    End Structure


End Module
Public Class Empleado
    Public Shared Function VerNOmbre() As String
        Return "Tere"
    End Function
    Public Function VerotroNOmbre() As String
        Return "Inés"
    End Function
End Class