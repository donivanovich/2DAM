page 50107 "Listenership Entries"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Listenership Entry";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Entry No."; Rec."Entry No.") { }
                field("Ratings Source entry No."; Rec."Ratings Source entry No.") { }
                field("Date"; Rec."Date") { }
                field("Start Time"; Rec."Start Time") { }
                field("End Time"; Rec."End Time") { }
                field("Radio Show No."; Rec."Radio Show No.") { }
                field("Listener Count"; Rec."Listener Count") { }
                field("Audience Share"; Rec."Audience Share") { }
                field("Age Demographic"; Rec."Age Demographic") { }
            }
        }
    }
}