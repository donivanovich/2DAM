page 50100 "Radio Show List"
{
    PageType = List;                    //Esta page es de tipo List
    ApplicationArea = all;
    UsageCategory = Lists;              // Al buscar en BC con la lupa me aparece esta page como lista
    SourceTable = "Radio Show";         // Tabla origen de los datos
    CardPageId = 50101;                 // Aqui pondre la page card que enlaza con este list

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                //field(nombreColumna;Rec."nombreCampoEnLaTabla"){propiedadesdeLaColumna}
                field("No."; Rec."No."){}
                field("Radio Show Type"; Rec."Radio Show type"){}
                field("Name"; Rec."Name"){}
                field("Run time"; Rec."Run time"){}
                field("Host No"; Rec."Host No"){}
                field("Host Name"; Rec."Host Name"){}
                field("Average Listeners"; Rec."Average Listeners"){}
                field("Audience share"; Rec."Audience share"){}
                field("Advertising Revenue"; Rec."Advertising Revenue"){}
                field("Royalty Cost"; Rec."Royalty Cost"){}
            }
        }
    }

}