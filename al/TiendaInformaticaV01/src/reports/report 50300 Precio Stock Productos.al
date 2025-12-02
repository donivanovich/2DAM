report 50300 "Precio Stock Productos"
{
    UsageCategory = ReportsAndAnalysis;
    ApplicationArea = All;
    DefaultLayout = Word;

    dataset
    {
        dataitem(DataItemName; Productos)
        {
            column(no; "No.") { }
            column(descripcion; "Descripcion") { }
            column(categoria; "Categoria") { }
            column(preciounitario; "Precio Unitario") { }
            column(stock; "Stock") { }
            column(filtrocategoria; "Filtro de categoria") { }
            column("stocktotalporcategoria"; "Stock total por categoria") { }
        }
    }

}