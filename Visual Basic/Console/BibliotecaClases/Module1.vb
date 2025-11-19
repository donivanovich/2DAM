Imports BibliotecaClases.DatosAdministrativos
Imports BibliotecaClases.DatosEmpleado
Module Module1

    Sub Main()
        Dim oEmpleado As DatosEmpleado.Empleado
        oEmpleado = New Empleado
        '  Console.WriteLine("{0}", oEmpleado.FechaCrea)
        ' Dim OtroEmpleado As Empleado


        'oEmpleado.mdOtroSueldo = 450
        'oEmpleado.mdOtroMasSueldo = 670
        ' Dim MiFecha As Date
        ' MiFecha = "28/02/2021"
        ' OtroEmpleado = New Empleado(MiFecha)


        ' MiFecha = "11/02/2022"
        ' OtroEmpleado = New Empleado(MiFecha, "OtroEmpleado")
        ' OtroEmpleado = New Empleado("29/02/2021")
        ' Console.WriteLine("{0}", OtroEmpleado.FechaCrea)
        Console.WriteLine("oEmpleado {0} - {1} ", oEmpleado.Nombre, oEmpleado.FechaCrea)
        Dim oAdministracion As New Administrativo
        ' oAdministracion.Nombre = "Guillermo"
        oAdministracion.Categoria = 1
        ' oAdministracion.EnviarCorreo("creado con herencia")
        Console.WriteLine("oAdministracion {0} - {1} ", oAdministracion.Nombre, oAdministracion.FechaCrea)






        Console.ReadLine()




    End Sub




End Module