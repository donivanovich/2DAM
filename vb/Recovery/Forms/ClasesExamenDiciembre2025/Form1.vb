Imports System.ComponentModel
Imports System.IO

Public Class Form1
    Dim DlgGuardar As New SaveFileDialog
    Private listaAlumnos As New List(Of Alum)()

    'CREACION'
    Private Sub CrearAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearAlumnoToolStripMenuItem.Click
        Dim nuevoAlumno As New Alum()
        Dim id As Integer = listaAlumnos.Count + 1
        listaAlumnos.Add(nuevoAlumno)
        MessageBox.Show($"Alumno con ID {id} creado")
    End Sub

    Private Sub IntroducirDatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirDatosPersonalesToolStripMenuItem.Click
        Dim form As New FrmIntroducirDatosPersonales()
        form.listaAlumnos = listaAlumnos
        form.Show()
    End Sub

    Private Sub IntroducirAsignaturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirAsignaturasToolStripMenuItem.Click
        Dim form As New FrmIntroducirAsignaturas()
        form.listaAlumnos = listaAlumnos
        form.Show()
    End Sub

    Private Sub IntroducirDatosBancariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirDatosBancariosToolStripMenuItem.Click
        Dim form As New FrmIntroducirDatosBancarios()
        form.listaAlumnos = listaAlumnos
        form.Show()
    End Sub

    Private Sub IntroducirNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirNotasToolStripMenuItem.Click
        Dim form As New FrmIntroducirNotas()
        form.listaAlumnos = listaAlumnos
        form.Show()
    End Sub

    'LISTADO'
    Private Sub ListarDatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDatosPersonalesToolStripMenuItem.Click
        Dim frmLista As New FrmListadoAlumnos()
        frmLista.ListaAlumnosGlobal = listaAlumnos
        frmLista.ShowDialog()
    End Sub

    Private Sub ListarAsignaturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarAsignaturasToolStripMenuItem.Click
        Dim frmDNI As New FrmListadoAsignaturas()
        frmDNI.ListaAlumnosGlobal = listaAlumnos
        frmDNI.ShowDialog()
    End Sub
    Private Sub ListasDatosBancariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasDatosBancariosToolStripMenuItem.Click
        Dim frmIBAN As New FrmListadoDatosBancarios()
        frmIBAN.ListaAlumnosGlobal = listaAlumnos
        frmIBAN.ShowDialog()
    End Sub
    Private Sub ListarNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarNotasToolStripMenuItem.Click
        Dim frmIBAN As New FrmListadoNotas()
        frmIBAN.ListaAlumnosGlobal = listaAlumnos
        frmIBAN.ShowDialog()
    End Sub

    'HERRAMIENTAS Y SALIR'
    Private Sub ConversorDeNotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversorDeNotaToolStripMenuItem.Click
        Dim form As New FrmConversorNotas()
        form.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim form As New FrmCalculadora()
        form.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
            Exit Sub
        End If

        If listaAlumnos.Count > 0 Then
            DlgGuardar.FileName = "alumnos.txt"

            If DlgGuardar.ShowDialog() = DialogResult.OK Then
                Try
                    Using Escribir As New StreamWriter(DlgGuardar.FileName, False)
                        For Each alu In listaAlumnos
                            Escribir.WriteLine($"DNI: {alu.DNI}")
                            Escribir.WriteLine($"Nombre: {alu.Nombre}")
                            Escribir.WriteLine($"Apellido1: {alu.Apellido1}")
                            Escribir.WriteLine($"Apellido2: {alu.Apellido2}")
                            Escribir.WriteLine($"Nacimiento: {alu.Nacimiento:dd/MM/yyyy}")
                            Escribir.WriteLine($"Domicilio: {alu.Domicilio}")
                            Escribir.WriteLine($"Telefono: {alu.Telefono}")
                            Escribir.WriteLine("---")
                        Next
                    End Using
                    MessageBox.Show("Archivo guardado")
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}")
                End Try
            End If
        Else
            MessageBox.Show("No hay alumnos para guardar")
        End If
    End Sub
End Class
