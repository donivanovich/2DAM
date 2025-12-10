page 50102 "Radio Show Type"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Radio Show Type";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Code; Rec.Code) { }
                field(Description; Rec.Description) { }
            }
        }
    }
}