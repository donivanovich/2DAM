page 50204 "Estudiante List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Estudiante;
    CardPageId = "Estudiante Card";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.") { }
                field(Nombre; Rec.Nombre) { }
                field("Tutor No."; Rec."Tutor No.") { }
                field("Tutor Nombre"; Rec."Tutor Nombre") { }
                field("Nota Media"; Rec."Nota Media") { }
                field(Curso; Rec.Curso) { }
                field(Refuerzo; Rec.Refuerzo) { }
            }
        }
    }
}