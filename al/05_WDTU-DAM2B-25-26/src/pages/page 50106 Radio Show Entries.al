page 50106 "Radio Show Entries"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Radio Show Entry";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Entry No."; Rec."Entry No.") { }
                field("Radio Show No."; Rec."Radio Show No.") { }
                field("Type"; Rec."Type") { }
                field("No."; Rec."No.") { }
                field("Data Format"; Rec."Data Format") { }
                field("Description"; Rec."Description") { }
                field("Date"; Rec."Date") { }
                field("Time"; Rec."Time") { }
                field("Duration"; Rec."Duration") { }
                field("Fee Amount"; Rec."Fee Amount") { }
                field("ACSAP ID"; Rec."ACSAP ID") { }
                field("Publisher Code"; Rec."Publisher Code") { }
            }
        }
    }
}