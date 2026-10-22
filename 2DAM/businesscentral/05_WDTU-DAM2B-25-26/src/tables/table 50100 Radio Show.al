table 50100 "Radio Show"
{
    DataClassification = ToBeClassified;
    // Zona de propiedades (de la tabla)
    // * Caption = Contiene el titulo para el idioma seleccionado
    // * CaptionML = Contiene el titulo en caso de ultilenguaje
    Description = 'Inventario de programas que estan disponibles para programarse';
    // * Permissions = Permite dotar de persmisos al usuario para el CRUD de la tabla y de su estructura
    // * LookupPaeId = Pagina predeterminada par abuscar datos de esta tabla
    // * DrillDownPageId = Pagina para ver detalles o resumen de datos de esta tabla
    // * DataCaptionFields = Permite definir los campos que se mostraran como titulo
    // PasteIsValid = Permite o no pegar datos en los campos
    // LinkedObject =
    // TableType = 
    // ObsoleteState = Indica al desarrollador que en fututas versiones desaparecera esta tabla
    // ObsoleteReason = Explico por que se va a eliminar y/o digo por cual se va a reemplazar

    // Nota: las propiedades con * son las mas habituales

    // Zona de campos
    fields
    {
        field(1; "No."; code[20])
        {
            //Aqui pondre las propiedades del campo
            trigger OnValidate() // Este trigger se va a disparar cuando el usuario ingresa un valor en este campo
            begin

            end;

            trigger OnLookup()
            begin

            end;
        }
        field(10; "Radio Show type"; code[20])
        {
            TableRelation = "Radio Show Type";
        }
        field(20; "Name"; Text[50]) { }
        field(30; "Run time"; Duration) { }
        field(40; "Host No"; Code[20]) { }
        field(50; "Host Name"; Text[50]) { }
        field(60; "Average Listeners"; Decimal)
        {
            Description = 'Numero promedio de oyentes segun lo informado por la agencia de calificacion';
            FieldClass = FlowField;
            CalcFormula = average(                          // Metodo a usar (average, count, suma, max, min, lookup, exist)
                "Listenership Entry"."Listener Count"       // TablaForanea.CampoDeTablaForanea
                    where(                                  // Clausula de BC para calcular
                        "Radio Show No." = field("No."),    // Condicion 1ª campoDeTablaForanea = (CampoDeEstaTabla | Filter | Constant)
                        Date = field("Date Filter")         // Condicion 2ª campoDeTablaForanea = CampoDeEstaTabla (ojo es un filtro)
                    )
                );
            Editable = false; // Al ser campo calculado no permito la edicion
        }
        field(70; "Audience share"; Decimal)
        {
            Description = 'Porcentaje de la audiencia estimada por la estacion de radio en la franja horaria';
            FieldClass = FlowField;
            CalcFormula = average(
                "Listenership Entry"."Audience Share"
                    where(
                        "Radio Show No." = field("No."),
                        Date = field("Date Filter")
                    )
                );
            Editable = false;
        }
        field(80; "Advertising Revenue"; Decimal)
        {
            Description = 'Suma total de ingresos por la publicidad generada';
            FieldClass = FlowField;
            CalcFormula = sum(
                "Radio Show Entry"."Fee Amount"
                    where(
                        "Radio Show No." = field("No."),
                        "Data Format" = filter(Advertisement) // Advertisement es una de las opciones del campo "Data Format" en la tabla "Radio Show Entry" 
                    )
                );
            Editable = false;
        }
        field(90; "Royalty Cost"; Decimal)
        {
            Description = 'Suma total de royalties adeudados por los derechos de autor de las canciones emitidas';
        }
        field(1000; "Frequency"; Option)                     // Aparece un desplegable
        {
            OptionMembers = Hourly,Daily,Weekly,Monthly;     // con estas opciones
        }
        field(1010; "PSA Planned Quantity"; Integer) { }
        field(1020; "ADS Planned Quantity"; Integer) { }
        field(1030; "News Required"; Boolean)
        {                                                   // Campo tipo booleano (0/1), (Si/No), (false/true) 
            InitValue = true;                               // Valor predeterminado o inicial 
        }
        field(1040; "News Duration"; Duration) { }
        field(1050; "Sports Required"; Boolean) { }
        field(1060; "Sports Duration"; Duration) { }
        field(1070; "Weather Required"; Boolean) { }
        field(1080; "Weather Duration"; Duration)
        {
            TableRelation = Customer;
        }
        field(1090; "Date Filter"; Date)
        {
            FieldClass = FlowFilter; // Volver aqui al terminar de hablar de los FlowField
        }
    }

    // Zona de claves (Keys)
    // La clave primaria se utiliza para identificar un registro, para acelerar la clasificacion y filtrado
    keys
    {
        key(PK; "No.")
        {
            // Propiedades de las keys
            // TODO: Volver al hablar de los campos
            // MaintainSiftIndex => Permiten mantener la tecnologia SUMINDEXFIELDS 
            // MaintainSqlIndex
        }
        key(Name; Name) { }
        key(HostName; "Host Name") { }
    }

    // Cuando un usuario ingresa datos en un campo, 
    // a veces el sistema debe proporcionarle ayudas sobre
    // las opciones disponibles
    fieldgroups
    {
        fieldgroup(DropDown; "No.", Name, "Host Name") { }
        fieldgroup(Brick; "No.", Name, "Audience share") { }
    }

    // Zona de triggers
    // El codigo contenido en cada trigger se ejecuta antes de ejecutar el evento correspondiente
    trigger OnInsert()
    var
        myInt: Integer;
    begin
        // Aqui va el codigo del trigger
    end;

    //Este trigger se ejecuta al cambiar algun dato que pertenezca a la clave principal 
    trigger OnModify()
    var
        myInt: Integer;
    begin

    end;

    //Este trigger se ejecuta al cambiar algun dato que no pertenece a la clave principal 
    trigger OnRename()
    var
        myInt: Integer;
    begin

    end;

    // Zona de variables
}