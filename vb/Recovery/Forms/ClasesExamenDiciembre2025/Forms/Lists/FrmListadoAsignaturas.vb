Imports ClasesExamenDiciembre2025.ClaseExamenDiciembre2025
Public Class FrmListadoAsignaturas
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

    Private Sub FrmListadoAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        ListViewAsignaturas.Items.Clear()

        If listaAlumnos IsNot Nothing Then
            For Each alu As Alum In listaAlumnos
                Dim item As New ListViewItem(alu.DNI)

                Dim asignaturasTexto As String = ""
                If alu.Asignaturas?.Asignaturas IsNot Nothing Then
                    For Each asig As String In alu.Asignaturas.Asignaturas
                        asignaturasTexto += asig & ", "
                    Next
                    asignaturasTexto = asignaturasTexto.TrimEnd(" ,".ToCharArray())
                End If
                item.SubItems.Add(If(asignaturasTexto = "", "Sin asignaturas", asignaturasTexto))

                ListViewAsignaturas.Items.Add(item)
            Next
        End If
    End Sub
End Class