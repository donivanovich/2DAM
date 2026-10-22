page 50207 "Asignatura Card"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = Asignatura;
    Caption = 'Asignatura de estudiantes';

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