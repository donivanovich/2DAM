Module Module1
    Sub Main()
        ' Crear instancia de Alumno
        Dim alumno1 As New Alumno()
        alumno1.NMatriculacion = 101
        alumno1.NombreAlumno = "Juan"
        alumno1.ApellidosAlumno = "Pérez López"
        alumno1.FechaNacimiento = New Date(2003, 5, 12)

        Console.WriteLine("Datos del alumno:")
        alumno1.MostrarDatos()
        Console.WriteLine()

        ' Crear instancia de Notas
        Dim notas1 As New Notas(alumno1.NMatriculacion)
        notas1.AnnadirNota("Programación", "1º Evaluación", 8.5)
        notas1.AnnadirNota("Bases de Datos", "Final Ordinaria", 7.8)
        notas1.AnnadirNota("Programación", "Final Extraordinaria", 9.2)

        Console.WriteLine("Notas del alumno:")
        notas1.MostrarNotas()
        Console.WriteLine()

        ' Crear instancia de Recibo
        Dim recibo1 As New Recibo()
        recibo1.idRecibo = 1
        recibo1.idAlumno = alumno1.NMatriculacion
        recibo1.fechaEmision = Date.Now
        recibo1.concepto = "Matrícula Curso 2025"
        recibo1.cantidad = 320.0

        Console.WriteLine("Recibo del alumno:")
        recibo1.MostrarRecibo()

        Console.ReadLine()
    End Sub
End Module
