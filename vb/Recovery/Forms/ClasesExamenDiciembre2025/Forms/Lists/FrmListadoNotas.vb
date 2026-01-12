Imports ClasesExamenDiciembre2025.ClaseExamenDiciembre2025
Public Class FrmListadoNotas
    Private listaAlumnos As List(Of Alum)

    Public Property ListaAlumnosGlobal As List(Of Alum)
        Get
            Return listaAlumnos
        End Get
        Set(value As List(Of Alum))
            listaAlumnos = value
            CargarListado()
        End Set
    End Property

    Private Sub FrmListadoNotasAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        ListViewNotas.Items.Clear()

        If listaAlumnos IsNot Nothing Then
            For Each alu As Alum In listaAlumnos
                If alu.Nota IsNot Nothing AndAlso alu.Nota.Notas IsNot Nothing AndAlso alu.Nota.Notas.Count > 0 Then
                    For i As Integer = 0 To alu.Asignaturas.Asignaturas.Count - 1
                        Dim asignatura As String = alu.Asignaturas.Asignaturas(i).ToString()
                        Dim nota As String = If(i < alu.Nota.Notas.Count, alu.Nota.Notas(i).ToString(), "Sin nota")

                        Dim item As New ListViewItem(alu.DNI)
                        item.SubItems.Add(asignatura)
                        item.SubItems.Add(nota)

                        ListViewNotas.Items.Add(item)
                    Next
                Else
                    Dim item As New ListViewItem(alu.DNI)
                    item.SubItems.Add("Sin asignaturas")
                    item.SubItems.Add("Sin notas")
                    ListViewNotas.Items.Add(item)
                End If
            Next
        End If
    End Sub
End Class