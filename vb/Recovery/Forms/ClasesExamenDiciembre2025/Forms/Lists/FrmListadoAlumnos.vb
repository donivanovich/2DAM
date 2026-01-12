Imports ClasesExamenDiciembre2025.ClaseExamenDiciembre2025
Public Class FrmListadoAlumnos
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

    Private Sub FrmListadoAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        ListViewAlumnos.Items.Clear()

        If ListaAlumnosGlobal IsNot Nothing Then
            For Each alu As Alum In ListaAlumnosGlobal
                Dim datos() As String = {
                alu.DNI,
                alu.Nombre,
                alu.Apellido1,
                alu.Apellido2,
                alu.Nacimiento.ToShortDateString(),
                alu.Domicilio,
                alu.Telefono.ToString()
            }
                ListViewAlumnos.Items.Add(New ListViewItem(datos))
            Next
        End If
    End Sub
End Class