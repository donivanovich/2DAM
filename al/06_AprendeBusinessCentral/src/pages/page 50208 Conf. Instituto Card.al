page 50208 "Conf. Instituto Card"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = "Conf. Instituto";
    Caption = 'Instituto';

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No. Serie Asignatura"; Rec."No. Serie Asignatura") { }
                field("No. Serie Profesor"; Rec."No. Serie Profesor") { }
            }
        }
    }
}