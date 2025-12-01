Public Class Notas
    ' ID alumno y estructura para notas
    Private idAlumno As Integer
    Private notas As Dictionary(Of String, Dictionary(Of String, Double))

    ' Constructor
    Public Sub New(idAlumno As Integer)
        Me.idAlumno = idAlumno
        notas = New Dictionary(Of String, Dictionary(Of String, Double))()
    End Sub

    ' Propiedades
    Public Property IdentificadorAlumno As Integer
        Get
            Return idAlumno
        End Get
        Set(value As Integer)
            idAlumno = value
        End Set
    End Property

    ' Añadir nota para módulo y evaluación
    Public Sub AnnadirNota(modulo As String, evaluacion As String, nota As Double)
        If Not notas.ContainsKey(modulo) Then
            notas(modulo) = New Dictionary(Of String, Double)()
        End If
        notas(modulo)(evaluacion) = nota
    End Sub

    ' Consultar nota de módulo y evaluación
    Public Function ObtenerNota(modulo As String, evaluacion As String) As Double
        If notas.ContainsKey(modulo) AndAlso notas(modulo).ContainsKey(evaluacion) Then
            Return notas(modulo)(evaluacion)
        End If
        Return -1 ' Valor que indica no hallada
    End Function

    ' Mostrar todas las notas
    Public Sub MostrarNotas()
        Console.WriteLine("Notas para el alumno: " & idAlumno)
        For Each modulo In notas.Keys
            Console.WriteLine("Módulo: " & modulo)
            For Each evaluacion In notas(modulo).Keys
                Console.WriteLine("  " & evaluacion & ": " & notas(modulo)(evaluacion))
            Next
        Next
    End Sub
End Class
