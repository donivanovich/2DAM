page 50201 "Calificacion Card"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = Calificacion;
    Caption = 'Calificaciones de los alumnos';

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No. Serie"; Rec."No. Serie") { }
                field(Asignatura; Rec.Asignatura) { }
                field("Curso Asignatura"; Rec."Curso Asignatura") { }
                field("Profesor Asignatura"; Rec."Profesor Asignatura") { }
                field(Alumno; Rec.Alumno) { }
                field(Nota; Rec.Nota) { }
            }
        }
    }
}