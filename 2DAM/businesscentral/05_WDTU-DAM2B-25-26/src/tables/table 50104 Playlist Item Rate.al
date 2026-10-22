table 50104 "Playlist Item Rate"
{
    Description = 'Tarifa especial para cliente VIP durante horario nocturno';

    fields
    {
        field(1; "Source Type"; Option)
        {
            OptionMembers = Vendor,Customer;
        }
        field(2; "Source No."; code[20])
        {
            TableRelation = IF ("Source Type" = const(Vendor)) Vendor."No."
            ELSE
            IF ("Source Type" = const(Customer)) Customer."No.";
        }
        field(30; "Item No."; code[20]) { }
        field(40; "Start Time"; Time) { }
        field(50; "End Time"; Time) { }
        field(60; "Rate Amount"; Decimal) { }
        field(70; "Publisher code"; code[10]) { }
    }
}