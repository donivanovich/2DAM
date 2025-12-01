table 50101 "Radio Show Type"
{
    Description = 'Lista de tipos de Radio shows disponibles';
    LookupPageId = "Radio Show Type";       // Al buscar algo de esta tabla aparecera esta page list
    DrillDownPageId = "Radio Show Type";    // Para busquedad en mas profundidad

    fields
    {
        field(1; Code; code[20]) { }
        field(10; Description; Text[50]) { }
    }

}