table 50204 "Conf. Instituto"
{
    Description = 'Instituto';

    fields
    {
        field(1; "Primary Key"; Code[10]) { }
        field(10; "No. Serie Asignatura"; Code[20]) { }
        field(20; "No. Serie Profesor"; Code[20]) { }
    }

    keys
    {
        key("PK"; "Primary Key") { }
    }
}