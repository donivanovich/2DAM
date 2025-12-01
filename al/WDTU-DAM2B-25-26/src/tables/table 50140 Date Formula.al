table 50140 "Date Formula"
{
    Description = 'Esta tabla sirve solamente para experimentar con las formulas de fecha';

    fields
    {
        field(1; "Primary Key"; Code[10]) { }
        field(10; "Reference For Date Calculation"; Date)
        {
            trigger OnValidate()
            begin
                CalculateNewDate;
            end;
        }
        field(20; "Date Formula To Test"; DateFormula)
        {
            trigger OnValidate()
            begin
                CalculateNewDate();
            end;
        }
        field(30; "Date Result"; Date) { }
    }

    local procedure CalculateNewDate();
    begin
        "Date Result" := CalcDate("Date Formula To Test", "Reference For Date Calculation");
    end;
}