Module Module1


    Sub Main()
        Dim oEmpleado As Empleado
        oEmpleado = New Empleado
        'oEmpleado = Nothing
        'oEmpleado = New Empleado
        'Dim otroEmpleado As New Empleado
        'otroEmpleado = Nothing
        'otroEmpleado = New Empleado
        'oEmpleado.Identificador = 75
        ' Console.WriteLine("{0}", oEmpleado.Identificador)
        oEmpleado.Nombre = "Guillermo"
        Console.WriteLine("{0}", oEmpleado.Nombre)
        oEmpleado.Categoria = 1
        oEmpleado.Sueldo = 150
        'Console.WriteLine("{0} - {1}", oEmpleado.Nombre, oEmpleado.Sueldo)
        oEmpleado.CuentaBancaria = "111178965621217271927"
        Console.WriteLine("{0} - {1} - {2} - {3}", oEmpleado.Nombre, oEmpleado.Sueldo, oEmpleado.EntidadBancaria)
        oEmpleado.IntoduceNombre("Daniel")
        Console.WriteLine("{0}", oEmpleado.DevuelveNombre)
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


    End Sub
    Public Function DevuelveNombre() As String


    End Function












    ' Public Identificador As Integer
End Class