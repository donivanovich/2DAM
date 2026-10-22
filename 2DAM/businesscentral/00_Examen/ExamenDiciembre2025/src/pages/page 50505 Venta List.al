page 50505 "Venta List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Venta;
    CardPageId = "Venta Card";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Id; Rec.Id) { }
                field(Fecha; Rec.Fecha) { }
                field(Cantidad; Rec.Cantidad) { }
                field(CodigoLibro; Rec.CodigoLibro) { }
                field(CodigoAutor; Rec.CodigoAutor) { }
            }
        }
        area(Factboxes)
        {

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
}