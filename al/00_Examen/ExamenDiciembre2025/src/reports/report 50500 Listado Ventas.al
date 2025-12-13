report 50500 "Listado Ventas"
{
    UsageCategory = ReportsAndAnalysis;
    ApplicationArea = All;
    DefaultLayout = Word;
    WordLayout = 'Listado Ventas.docx';

    dataset
    {
        dataitem(ListadoVentas; Venta)
        {
            column(id; Id) { }
            column(fecha; Fecha) { }
            column(cantidad; Cantidad) { }
            column(codigolibro; CodigoLibro) { }
            column(codigoautor; CodigoAutor) { }
        }
    }

}