table 50203 "Profesor"
{
    Description = 'Tabla con datos de profesores';

    fields
    {
        field(1; "No."; Code[10]) { }
        field(10; "Nombre"; Text[100]) { }
        field(20; "Fecha Incorporacion"; Date) { }
        field(30; "No. Asignatura"; Code[10]) { }
        field(40; "Nombre Asignatura"; Text[100]) { }
        field(50; "Curso"; Enum Curso) { }
        field(60; "Jubilado"; Boolean) { }
        field(70; "Tutor"; Boolean) { }
    }

    keys
    {
        key("PK"; "No.") { }
    }
}