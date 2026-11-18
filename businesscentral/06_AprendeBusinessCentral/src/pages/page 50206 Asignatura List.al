page 50206 "Asignatura List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Asignatura;
    CardPageId = "Asignatura Card";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.") { }
                field(Nombre; Rec.Nombre) { }
                field(Curso; Rec.Curso) { }
                field("Profesor No."; Rec."Profesor No.") { }
                field("Nombre Profesor"; Rec."Nombre Profesor") { }
                field("Nota Media"; Rec."Nota Media") { }
            }
        }
    }
}