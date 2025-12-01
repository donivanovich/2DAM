page 50202 "Profesor List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Profesor;
    CardPageId = "Profesor Card";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.") { }
                field(Nombre; Rec.Nombre) { }
                field("Fecha Incorporacion"; Rec."Fecha Incorporacion") { }
                field("No. Asignatura"; Rec."No. Asignatura") { }
                field("Nombre Asignatura"; Rec."Nombre Asignatura") { }
                field(Curso; Rec.Curso) { }
                field(Jubilado; Rec.Jubilado) { }
                field(Tutor; Rec.Tutor) { }
            }
        }
    }
}