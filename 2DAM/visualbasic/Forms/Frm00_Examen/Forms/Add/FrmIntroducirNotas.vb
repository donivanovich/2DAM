Imports System.ComponentModel
Imports ClasesExamenDiciembre2025.ClaseExamenDiciembre2025

Public Class FrmIntroducirNotas
    Private Sub FrmIntroducirNotas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim res As Integer
        res = MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub

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

    Private Sub FrmIntroducirNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                CargarComboAsignaturas()
            End If
        End If
    End Sub

    Private Sub ComboBoxAlumnos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAlumnos.SelectedIndexChanged
        CargarComboAsignaturas()
    End Sub

    Private Sub CargarComboAsignaturas()
        ComboBoxAsignatura.Items.Clear()
        If ComboBoxAlumnos.SelectedIndex >= 0 Then
            Dim alumno As Alum = alumnos(ComboBoxAlumnos.SelectedIndex)
            If alumno.Asignaturas IsNot Nothing AndAlso alumno.Asignaturas.Asignaturas IsNot Nothing Then
                For Each asig As String In alumno.Asignaturas.Asignaturas
                    ComboBoxAsignatura.Items.Add(asig)
                Next
            End If
            If ComboBoxAsignatura.Items.Count > 0 Then
                ComboBoxAsignatura.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If alumnos IsNot Nothing AndAlso ComboBoxAlumnos.SelectedIndex >= 0 AndAlso ComboBoxAsignatura.SelectedIndex >= 0 Then
            Dim indiceAlumno As Integer = ComboBoxAlumnos.SelectedIndex
            Dim alumno As Alum = alumnos(indiceAlumno)

            ' Asegurar Nota
            If alumno.Nota Is Nothing Then
                alumno.Nota = New Nota()
            End If

            Dim notaValor As Single
            If Single.TryParse(TextBoxNota.Text, notaValor) Then
                alumno.Nota.Notas.Add(notaValor)
                MessageBox.Show($"Nota {notaValor} añadida a {ComboBoxAsignatura.Text} de {ComboBoxAlumnos.Text}")
            Else
                MessageBox.Show("Introduce numero valido")
            End If

            TextBoxNota.Clear()
            TextBoxNota.Focus()
        Else
            MessageBox.Show("Selecciona alumno y asignatura")
        End If
    End Sub
End Class