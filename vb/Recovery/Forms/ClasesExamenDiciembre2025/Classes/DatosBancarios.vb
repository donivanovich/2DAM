Public Class DatosBancarios
    Private _iban As String

    Public Property IBAN As String
        Get
            Return _iban
        End Get
        Set(value As String)
            _iban = value
        End Set
    End Property

    Public Sub New()
    End Sub
End Class
