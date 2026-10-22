table 50103 "Playlist Line"
{
    Description = 'Canción principal de la apertura del programa, interpretada por la banda invitada';

    fields
    {
        field(1; "Document No."; code[20]) { }
        field(2; "Line No."; Integer) { }
        field(10; "Type"; Option)
        {
            OptionMembers = ,Resource,Show,Item;
        }
        field(20; "No."; code[20])
        {
            TableRelation = IF (Type = const(Resource)) Resource."No."
            ELSE
            IF (Type = const(Show)) "Radio Show"."No."
            ELSE
            IF (Type = const(Show)) "Item"."No.";
        }
        field(30; "Data Format"; Option)
        {
            OptionMembers = ,Vinyl,CD,MP3,PSA,Advertisement;
        }
        field(40; "Publisher"; code[10]) { }
        field(50; "Description"; text[50]) { }
        field(60; "Duration"; Duration) { }
        field(70; "Start Time"; Time) { }
        field(80; "End Time"; Time) { }
    }

    keys
    {                                           // Aqui pondre las claves     
        key(PK; "Document No.", "Line No.")
        {    // Esta es la clave primaria key(nombreClave; "Campo1", *Optional*"Campo2"){}
            Clustered = true;
        }
    }
}