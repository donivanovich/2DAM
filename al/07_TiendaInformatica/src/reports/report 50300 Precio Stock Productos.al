report 50300 "Precio Stock Productos"
{
    UsageCategory = ReportsAndAnalysis;
    ApplicationArea = All;
    DefaultLayout = Word;
    WordLayout = 'Report Precio Stock Productos.docx';

    dataset
    {
        dataitem(Productos123; Productos)
        {
            column(no; "No.") { }
            column(descripcion; "Descripcion") { }
            column(preciounitario; "Precio Unitario") { }
            column(stock; "Stock") { }
        }
    }

}

//AL package y abres el word con Open Externally
// Dentro de Word, arriba, en "Programador" le das a Panel de asignacion XML
// en Elemento XML personalizado: selecciona el report
// CADA CAMPO CREADO CORRESPONDE A UNA FILA, CLICK DERECHO -> INSERTAR CONTENIDO -> TEXTO SIN FORMATO
// Poner tu nombre en el pie del documento
// Abre Paquetes de Configuracion
// Crear un nuevo paquete, codigo (nombre que quieras), 
//nombre del paquete (nombre que quieras), version(v01), 
//id. tabla 50300 (o lo que tengas) y marcar el tercer check
// exportar a excel
// pegas los datos del excel en los campos correspondientes
// Importar desde excel  y subes el archivo editado y aplicas el paquete
// Luego en las listas puedes ver los datos
// En los reports ahora puedes ver la vista previa, imprimirlo y pasarlo a PDF gracias al Word previamente diseñado