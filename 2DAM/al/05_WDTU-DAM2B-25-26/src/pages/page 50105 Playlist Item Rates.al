page 50105 "Playlist Item Rates"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Playlist Item Rate";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Source Type"; Rec."Source Type") { }
                field("Source No."; Rec."Source No.") { }
                field("Item No."; Rec."Item No.") { }
                field("Start Time"; Rec."Start Time") { }
                field("End Time"; Rec."End Time") { }
                field("Rate Amount"; Rec."Rate Amount") { }
                field("Publisher code"; Rec."Publisher code") { }
            }
        }
    }
}