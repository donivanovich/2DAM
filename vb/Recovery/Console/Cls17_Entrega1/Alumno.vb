Public Class Alumno
    ' Campos privados
    Private nmat As Integer
    Private nombre As String
    Private apellidos As String
    Private fechNaci As Date

    ' Propiedades públicas
    Public Property NMatriculacion As Integer
        Get
            Return nmat
        End Get
        Set(value As Integer)
            nmat = value
        End Set
    End Property

    Public Property NombreAlumno As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property ApellidosAlumno As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return fechNaci
        End Get
        Set(value As Date)
            fechNaci = value
        End Set
    End Property

    ' Método: imprime los datos en línea
    Public Sub MostrarDatos()
        Console.WriteLine("NºMatriculación: " & nmat)
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Apellidos: " & apellidos)
        Console.WriteLine("Fecha Nacimiento: " & fechNaci.ToShortDateString())
    End Sub
End Class