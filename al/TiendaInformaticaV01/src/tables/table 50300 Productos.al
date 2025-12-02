table 50300 Productos
{
    Description = 'Tabla de productos';

    fields
    {
        field(1; "No."; Code[10])
        {
            trigger OnValidate()
            begin
                if "No." = '' then
                    Error('El codigo del producto no puede estar vacio');
            end;
        }
        field(10; "Descripcion"; Text[50]) { }
        field(20; "Categoria"; Enum "Categoria Productos") { }
        field(30; "Precio Unitario"; Decimal) { }
        field(40; "Stock"; Integer) { }
        field(50; "Filtro de categoria"; Enum "Categoria Productos") { }
        field(60; "Stock total por categoria"; Integer) { }
    }

    keys
    {
        key("PK"; "No.")
        {
            Clustered = true;
        }
    }

    trigger OnInsert()
    begin
        if Descripcion = '' then
            Error('Debe introducir una descripcion para el producto');
    end;
}