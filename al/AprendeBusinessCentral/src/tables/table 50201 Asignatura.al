table 50201 "Asignatura"
{
    Description = 'Asignaturas a impartir';
    fields
    {
        field(1; "No."; Code[10]) { }
        field(10; "Nombre"; Text[100]) { }
        field(20; "Curso"; Enum Curso) { }
        field(30; "Profesor No."; Code[10]) { }
        field(40; "Nombre Profesor"; Text[100]) { }
        field(50; "Nota Media"; Decimal) { }
    }

    keys
    {
        key("PK"; "No.") { }
    }
}