Module Module1


    Sub Main()
        Dim oEmpleado As Empleado
        oEmpleado = New Empleado
        Console.WriteLine("{0}", oEmpleado.FechaCrea)
        Dim OtroEmpleado As Empleado


        Dim MiFecha As Date
        MiFecha = "28/02/2021"
        OtroEmpleado = New Empleado(MiFecha)
        ' OtroEmpleado = New Empleado("29/02/2021")
        Console.WriteLine("{0}", OtroEmpleado.FechaCrea)




        Console.ReadLine()


    End Sub


End Module
Public Class Empleado
    Private msNombre As String
    Private micategoria As Integer
    Private mdSueldo As Double
    Private msCtaBancaria As String
    Private msEntidad As String
    Private msCodigoEntidad As String
    Private Identificador As Integer
    Private mdFechaAlta As Date
    Private msViajes() As String


    Public Property FechaCrea() As Date
        Get
            Return mdFechaAlta
        End Get
        Set(value As Date)
            mdFechaAlta = value
        End Set


    End Property


    Public Sub New()
        Me.FechaCrea = Now
        Console.WriteLine("Objeto construido")
    End Sub
    Public Sub New(ValorFecha As Date)


        Me.FechaCrea = ValorFecha
    End Sub
    Default Public Property Viajes(ByVal Indice As Integer) As String
        Get
            Return msViajes(Indice)
        End Get
        Set(value As String)
            If msViajes Is Nothing Then
                ReDim msViajes(0)
                msViajes(Indice) = value
            Else
                ReDim Preserve msViajes(UBound(msViajes) + 1)
                msViajes(Indice) = value
            End If
        End Set




    End Property








    Public ReadOnly Property MesAlta As String
        Get
            Return Format(mdFechaAlta, "MMMM")
        End Get
    End Property




    Public Property FechaAlta As Date
        Get
            Return mdFechaAlta
        End Get
        Set(value As Date)
            mdFechaAlta = value
        End Set
    End Property
    Public ReadOnly Property EntidadBancaria As String
        Get
            Return msEntidad
        End Get
    End Property
    Public WriteOnly Property CuentaBancaria As String
        Set(value As String)
            msCtaBancaria = value
            Select Case Left(value, 4)
                Case "1111"
                    msEntidad = "Banco universal"
                Case "2222"
                    msEntidad = "Banco central"
                Case "3333"
                    msEntidad = "Banco Sur"
                Case Else
                    msEntidad = "Entidad sin catalogar"








            End Select
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return msNombre
        End Get
        Set(value As String)
            msNombre = value
        End Set
    End Property








    Public Property Categoria As Integer
        Get
            Return micategoria
        End Get
        Set(value As Integer)
            micategoria = value
        End Set
    End Property
    Public Property Sueldo As Double
        Get
            Return mdSueldo
        End Get
        Set(value As Double)
            If micategoria = 1 Then
                If value > 200 Then
                    Console.WriteLine("La categoria no corresponde con el sueldo")
                    mdSueldo = 0
                Else
                    mdSueldo = value
                End If
            End If
        End Set
    End Property








    Public Sub IntoduceNombre(Valor As String)
        msNombre = UCase(Valor)




    End Sub
    Public Sub IntoduceNombre()








    End Sub
    Public Function DevuelveNombre() As String
        Return ""
    End Function


End Class
Public Class Administrativo
    Inherits Empleado
    Public Sub EnviarCorreo(mensaje As String)
        Console.WriteLine("{0}- {1} - {2}", Me.Nombre, Me.Categoria, mensaje)
    End Sub
End Class