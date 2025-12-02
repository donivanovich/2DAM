page 50300 "Productos Card"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = "Productos";

    layout
    {
        area(Content)
        {
            group(GroupName)
            {
                field("No."; Rec."No.") { }
                field(Descripcion; Rec.Descripcion) { }
                field(Categoria; Rec.Categoria) { }
                field("Precio Unitario"; Rec."Precio Unitario") { }
                field(Stock; Rec.Stock) { }
                field("Filtro de categoria"; Rec."Filtro de categoria") { }
                field("Stock total por categoria"; Rec."Stock total por categoria") { }
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