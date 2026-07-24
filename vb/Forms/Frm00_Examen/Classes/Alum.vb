Namespace ClaseExamenDiciembre2025
    Public Class Alum
        Private _dni As String
        Private _nombre As String
        Private _apellido1 As String
        Private _apellido2 As String
        Private _nacimiento As Date
        Private _domicilio As String
        Private _telefono As Integer
        Private _asignaturas As Academico
        Private _nota As Nota
        Private _iban As DatosBancarios

        Public Property IBAN As DatosBancarios
            Get
                Return _iban
            End Get
            Set(value As DatosBancarios)
                _iban = value
            End Set
        End Property

        Public Property Nota As Nota
            Get
                Return _nota
            End Get
            Set(value As Nota)
                _nota = value
            End Set
        End Property

        Public Property Asignaturas As Academico
            Get
                Return _asignaturas
            End Get
            Set(value As Academico)
                _asignaturas = value
            End Set
        End Property

        Public Property DNI As String
            Get
                Return _dni
            End Get
            Set(value As String)
                _dni = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Apellido1 As String
            Get
                Return _apellido1
            End Get
            Set(value As String)
                _apellido1 = value
            End Set
        End Property

        Public Property Apellido2 As String
            Get
                Return _apellido2
            End Get
            Set(value As String)
                _apellido2 = value
            End Set
        End Property

        Public Property Nacimiento As Date
            Get
                Return _nacimiento
            End Get
            Set(value As Date)
                _nacimiento = value
            End Set
        End Property

        Public Property Domicilio As String
            Get
                Return _domicilio
            End Get
            Set(value As String)
                _domicilio = value
            End Set
        End Property

        Public Property Telefono As Integer
            Get
                Return _telefono
            End Get
            Set(value As Integer)
                _telefono = value
            End Set
        End Property

        Public Sub New()
            _asignaturas = New Academico()
            _iban = New DatosBancarios()
            _nota = New Nota()
        End Sub
    End Class
End Namespace