table 50502 Venta
{
    Description = 'Tabla de autores';

    fields
    {
        field(1; "Id"; Code[10]) { }
        field(10; "Fecha"; Date) { }
        field(20; "Cantidad"; Integer) { }
        field(30; "CodigoLibro"; Code[10]) { }
        field(40; "CodigoAutor"; Code[10]) { }
    }

    keys
    {
        key("PK"; "Id")
        {
            Clustered = true;
        }
    }

    trigger OnInsert()
    begin
        if Cantidad < 0 then
            Error('Debe introducir un valor positivo');
    end;
}