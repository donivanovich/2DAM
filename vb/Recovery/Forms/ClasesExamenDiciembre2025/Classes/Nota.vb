Public Class Nota
    Private _notas As ArrayList

    Public Property Notas As ArrayList
        Get
            Return _notas
        End Get
        Set(value As ArrayList)
            _notas = value
        End Set
    End Property

    Public Sub New()
        _notas = New ArrayList()
    End Sub
End Class
