Public Class Recibo
    ' Campos privados
    Public idRecibo As Integer
    Public idAlumno As Integer
    Public fechaEmision As Date
    Public concepto As String
    Public cantidad As Double

    ' Propiedades públicas
    Public Property IdentificadorRecibo As Integer
        Get
            Return idRecibo
        End Get
        Set(value As Integer)
            idRecibo = value
        End Set
    End Property

    Public Property IdentificadorAlumno As Integer
        Get
            Return idAlumno
        End Get
        Set(value As Integer)
            idAlumno = value
        End Set
    End Property

    Public Property Emision As Date
        Get
            Return fechaEmision
        End Get
        Set(value As Date)
            fechaEmision = value
        End Set
    End Property

    Public Property ConceptoRecibo As String
        Get
            Return concepto
        End Get
        Set(value As String)
            concepto = value
        End Set
    End Property

    Public Property CantidadRecibo As Double
        Get
            Return cantidad
        End Get
        Set(value As Double)
            cantidad = value
        End Set
    End Property

    ' Método para mostrar datos del recibo
    Public Sub MostrarRecibo()
        Console.WriteLine("ID Recibo: " & idRecibo)
        Console.WriteLine("ID Alumno: " & idAlumno)
        Console.WriteLine("Fecha emisión: " & fechaEmision.ToShortDateString())
        Console.WriteLine("Concepto: " & concepto)
        Console.WriteLine("Cantidad: " & cantidad)
    End Sub
End Class