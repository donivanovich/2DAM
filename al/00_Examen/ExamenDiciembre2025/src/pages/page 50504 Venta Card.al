page 50504 "Venta Card"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = "Venta";

    layout
    {
        area(Content)
        {
            group(GroupName)
            {
                field(Id; Rec.Id) { }
                field(Fecha; Rec.Fecha) { }
                field(Cantidad; Rec.Cantidad) { }
                field(CodigoLibro; Rec.CodigoLibro) { }
                field(CodigoAutor; Rec.CodigoAutor) { }
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