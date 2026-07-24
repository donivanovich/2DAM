page 50501 "Libro List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Libro;
    CardPageId = "Libro Card";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Codigo; Rec.Codigo) { }
                field(Titulo; Rec.Titulo) { }
                field(Precio; Rec.Precio) { }
                field(Genero; Rec.Genero) { }
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