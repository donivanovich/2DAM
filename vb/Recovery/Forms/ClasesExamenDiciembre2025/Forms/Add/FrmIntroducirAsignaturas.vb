Imports System.ComponentModel

Public Class FrmIntroducirAsignaturas
    Private asignatura As Academico
    Public Property listaAlumnos As List(Of Alum)
        Get
            Return alumnos
        End Get
        Set(value As List(Of Alum))
            alumnos = value
            CargarComboAlumnos()
        End Set
    End Property

    Private alumnos As List(Of Alum)
    Private Sub FrmIntroducirAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboAlumnos()
    End Sub

    Private Sub CargarComboAlumnos()
        ComboBoxAlumnos.Items.Clear()
        If alumnos IsNot Nothing Then
            For i As Integer = 0 To alumnos.Count - 1
                ComboBoxAlumnos.Items.Add($"{i + 1} ({alumnos(i).DNI})")
            Next
            If ComboBoxAlumnos.Items.Count > 0 Then
                ComboBoxAlumnos.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If alumnos IsNot Nothing AndAlso alumnos.Count > 0 AndAlso ComboBoxAlumnos.SelectedIndex >= 0 Then
            Dim indice As Integer = ComboBoxAlumnos.SelectedIndex
            Dim alumnoSeleccionado As Alum = alumnos(indice)

            If alumnoSeleccionado.Asignaturas Is Nothing Then
                alumnoSeleccionado.Asignaturas = New Academico()
            End If

            alumnoSeleccionado.Asignaturas.Asignaturas.Add(TextBoxAsignatura.Text)

            MessageBox.Show($"Asignatura '{TextBoxAsignatura.Text}' añadida a {ComboBoxAlumnos.Text}")

            TextBoxAsignatura.Clear()
            TextBoxAsignatura.Focus()
        Else
            MessageBox.Show("Selecciona un alumno")
        End If
    End Sub

    Private Sub FrmIntroducirAsignaturas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub
End Class