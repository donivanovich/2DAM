table 50200 "Estudiante"
{
    Description = 'Datos de estudiantes';

    fields
    {
        field(1; "No."; Code[10]) { }
        field(10; "Nombre"; Text[100]) { }
        field(20; "Tutor No."; Code[10]) { }
        field(30; "Tutor Nombre"; Text[100]) { }
        field(40; "Nota Media"; Integer) { }
        field(50; "Curso"; Enum Curso) { }
        field(60; "Refuerzo"; Boolean) { }
    }

    keys
    {
        key("PK"; "No.") { }
    }
}