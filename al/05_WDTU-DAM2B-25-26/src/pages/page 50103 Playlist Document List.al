page 50103 "Playlist Document List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Playlist Header";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.") { }
                field("Radio Show No."; Rec."Radio Show No.") { }
                field("Description"; Rec."Description") { }
                field("Broadcast Date"; Rec."Broadcast Date") { }
                field("Duration"; Rec."Duration") { }
                field("Start Time"; Rec."Start Time") { }
                field("End Time"; Rec."End Time") { }
            }
        }
    }
}