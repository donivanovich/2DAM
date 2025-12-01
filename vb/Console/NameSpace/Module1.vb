Imports [NameSpace].Personal
Imports NombresDeEspacio.Personal
Module Module1


    Sub Main()
        Dim oFactura As Factura
        oFactura = New Factura
        With oFactura
            .Id = 5
            .Importe = 500
            .Datos()
        End With
        ' Dim oEmpleado As Personal.Empleado
        '  Dim otroEmpleado As NombresDeEspacio.Personal.Empleado
        Dim UnEmpleado As Empleado


        Console.ReadLine()
    End Sub


End Module
Public Class Factura
    Public Id As Integer
    Public Importe As Integer


    Public Sub Datos()
        Console.WriteLine("la factura {0} tiene un importe de {1}", Id, Importe)
    End Sub
    '  Private nombre As String
End Class
Namespace Personal
    Public Class Empleado
        Public Id As Integer
        Public Sub MostrarDatos()
            Console.WriteLine("identificador de empleado {0} ", Id)
        End Sub


    End Class
    Public Class Empleado2
        Public Id As Integer
        Public Sub MostrarDatos()
            Console.WriteLine("identificador de empleado {0} ", Id)
        End Sub


    End Class
End Namespace