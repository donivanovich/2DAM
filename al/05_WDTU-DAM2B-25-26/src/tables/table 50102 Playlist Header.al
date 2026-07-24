table 50102 "Playlist Header"
{
    Description = 'Instancia unica de Radio Show con datos secundarios en forma de lineas de lista de reproduccion';

    fields
    {
        field(1; "No."; code[20]) { }
        field(10; "Radio Show No."; code[20]) { }
        field(20; "Description"; Text[20]) { }
        field(30; "Broadcast Date"; Date) { }
        field(40; "Duration"; Duration) { }
        field(50; "Start Time"; Time) { }
        field(60; "End Time"; Time) { }
    }
}