Imports System.ComponentModel

Public Class FrmIntroducirDatosPersonales
    Public Property listaAlumnos As List(Of Alum)
        Get
            Return alumnos
        End Get
        Set(value As List(Of Alum))
            alumnos = value
        End Set
    End Property

    Private alumnos As List(Of Alum)
    Private Sub FrmCrearAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxAlumnos.Items.Clear()
        For i As Integer = 0 To listaAlumnos.Count - 1
            ComboBoxAlumnos.Items.Add($"ID {i + 1} ({listaAlumnos(i).DNI})")
        Next
        If ComboBoxAlumnos.Items.Count > 0 Then
            ComboBoxAlumnos.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If listaAlumnos IsNot Nothing AndAlso listaAlumnos.Count > 0 AndAlso ComboBoxAlumnos.SelectedIndex >= 0 Then
            Dim indice As Integer = ComboBoxAlumnos.SelectedIndex
            Dim alumno As Alum = listaAlumnos(indice)

            alumno.DNI = TextBoxDni.Text
            alumno.Nombre = TextNombre.Text
            alumno.Apellido1 = TextApellido1.Text
            alumno.Apellido2 = TextBoxApellido2.Text
            alumno.Nacimiento = DateTimePicker1.Value
            alumno.Domicilio = TextBoxDomicilio.Text
            alumno.Telefono = Integer.Parse(TextBoxTelefono.Text)

            MessageBox.Show($"Alumno con ID {indice + 1} actualizado: {alumno.Nombre}")

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Selecciona un alumno")
        End If
    End Sub

    Private Sub FrmCrearAlumno_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class