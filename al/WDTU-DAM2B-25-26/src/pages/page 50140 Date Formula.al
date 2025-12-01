page 50140 "Date Formula"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = "Date Formula";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Primary Key"; Rec."Primary Key") { }
                field("Reference For Date Calculation"; Rec."Reference For Date Calculation") { }
                field("Date Formula To Test"; Rec."Date Formula To Test") { }
                field("Date Result"; Rec."Date Result") { }
            }
        }
    }
}