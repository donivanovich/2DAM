Public Class FrmListadoDatosBancarios
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

    Private Sub FrmListadoDNIIBAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        ListViewDatosBancarios.Items.Clear()

        If listaAlumnos IsNot Nothing Then
            For Each alu As Alum In listaAlumnos
                Dim item As New ListViewItem(alu.DNI)

                Dim ibanTexto As String = If(alu.IBAN IsNot Nothing, alu.IBAN.IBAN, "Sin IBAN")
                item.SubItems.Add(ibanTexto)

                ListViewDatosBancarios.Items.Add(item)
            Next
        End If
    End Sub
End Class