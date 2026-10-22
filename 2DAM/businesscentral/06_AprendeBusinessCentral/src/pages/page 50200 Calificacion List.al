page 50200 "Calificacion List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Calificacion;
    CardPageId = "Calificacion Card";

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