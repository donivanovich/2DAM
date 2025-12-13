table 50501 Autor
{
    Description = 'Tabla de autores';

    fields
    {
        field(1; "Codigo"; Code[10]) { }
        field(10; "Nombre"; Text[100]) { }
        field(20; "Nacionalidad"; Text[100]) { }
    }

    keys
    {
        key("PK"; "Codigo")
        {
            Clustered = true;
        }
    }

    trigger OnInsert()
    begin
        if Nombre = '' then
            Error('Debe introducir un nombre para el autor');
        if Nacionalidad = '' then
            Error('Debe introducir una nacionalidad para el autor');
    end;
}