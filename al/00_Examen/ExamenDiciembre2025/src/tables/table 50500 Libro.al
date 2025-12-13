table 50500 Libro
{
    Description = 'Tabla de libros';

    fields
    {
        field(1; "Codigo"; Code[10]) { }
        field(10; "Titulo"; Text[100]) { }
        field(20; "Precio"; Integer) { }
        field(30; "Genero"; Enum GeneroLibro) { }
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
        if Titulo = '' then
            Error('Debe introducir un titulo para el libro');
        if Precio < 0 then
            Error('Debe introducir un valor positivo');
    end;
}