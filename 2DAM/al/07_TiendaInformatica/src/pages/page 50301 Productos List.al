page 50301 "Productos List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Productos;
    CardPageId = "Productos Card";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
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