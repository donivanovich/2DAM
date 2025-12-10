table 50202 "Calificacion"
{
    Description = 'Calificaciones';

    fields
    {
        field(1; "No. Serie"; Code[10]) { }
        field(10; "Asignatura"; Text[50]) { }
        field(20; "Curso Asignatura"; Text[50]) { }// Puede que este tipo este mal
        field(30; "Profesor Asignatura"; Text[100]) { }
        field(40; "Alumno"; Text[100]) { }
        field(50; "Nota"; Integer) { }
    }

    keys
    {
        key("PK"; "No. Serie") { }
    }
}