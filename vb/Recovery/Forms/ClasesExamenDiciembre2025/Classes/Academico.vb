Namespace ClaseExamenDiciembre2025
    Public Class Academico
        Private _asignaturas As ArrayList

        Public Property Asignaturas As ArrayList
            Get
                Return _asignaturas
            End Get
            Set(value As ArrayList)
                _asignaturas = value
            End Set
        End Property

        Public Sub New()
            _asignaturas = New ArrayList()
        End Sub
    End Class
End Namespace