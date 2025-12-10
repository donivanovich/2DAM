page 50108 "Publishers"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Publisher";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Code"; Rec."Code") { }
                field("Description"; Rec."Description") { }
            }
        }
    }
}