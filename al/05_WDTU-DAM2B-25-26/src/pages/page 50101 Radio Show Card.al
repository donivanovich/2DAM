page 50101 "Radio Show Card"
{
    PageType = Card;                    //Card = formulario con todos los campos de la tabla para CRUD
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = "Radio Show";         // Tabla con la que esta vinculada
    
    layout
    {
        area(Content)
        {
            group(GroupName)
            {
                //field(nombreRotulo; Rec."nombreCampoEnTabla")
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
    
    actions
    {
        area(Processing)
        {
            action(ActionName)
            {
                
                trigger OnAction()
                begin
                    
                end;
            }
        }
    }
    
    var
        myInt: Integer;
}