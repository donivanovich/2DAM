page 50205 "Estudiante Card"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = Estudiante;
    Caption = 'Estudiantes con asignaturas';

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