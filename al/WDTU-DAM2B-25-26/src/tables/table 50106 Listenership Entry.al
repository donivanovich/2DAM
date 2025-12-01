table 50106 "Listenership Entry"
{
    Description = 'Entrada correspondiente a la medición de audiencia del programa matutino, muestra especial para adolescentes';

    fields
    {
        field(1; "Entry No."; Integer) { }
        field(10; "Ratings Source entry No."; Integer) { }
        field(20; "Date"; Date) { }
        field(30; "Start Time"; Time) { }
        field(40; "End Time"; Time) { }
        field(50; "Radio Show No."; code[20]) { }
        field(60; "Listener Count"; Decimal) { }
        field(70; "Audience Share"; Decimal) { }
        field(80; "Age Demographic"; Option)
        {
            OptionMembers = ,"0-12","13-18","19-34","35-50","51+";
        }
    }
    keys
    {
        key(PK; "Entry No.")
        {
            Clustered = true;
        }
        key(Reporting; "Radio Show No.", "Date", "Start Time", "Age Demographic")
        {
            SumIndexFields = "Listener Count", "Audience Share";
        }
    }
}