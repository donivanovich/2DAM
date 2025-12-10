```bash
table 50199 "Propiedades de Campos"
{
    Description = 'Aqui hablamos de las propiedades de los campos en Business Central';

    fields
    {
        // field("field No." name (del campo); tipo de datos [Blob, Integer, Date, Text, Code, Decimal, Option y Boolean]);
        field(1; "Propiedades Generales"; Integer)
        {
            // Propiedades universales (comunes a todos los tipos de campos)
            Caption = 'Mi caption para el campo Propiedades Generales'; // Este es el titulo del campo, si no existe se utiliza como titulo el nombre del campo 
            Description = 'Descripcion del campo para uso documental o interno';
            Enabled = true; // El campo esta activado o no
        }

        field(2; "Propiedades del campo Blob"; Blob)
        {
            Subtype = Bitmap; // Tambien admite valores: Json, Memo y UserDefined
            Compressed = true; // Por defecto se almacena este objeto ya comprimido, si quiero acceder a el desde una aplicacion externa o fuera del BC tengo que guardarlo sin comprimir (false)
        }

        field(3; "Propiedades de Code y Text"; Code[20])
        {
            InitValue = ''; // Valor predeterminado (o inicial)
            CaptionClass = '1.1'; // Este titulo es dinamico (el usuario lo podra modificar)
            Editable = false; // Este campo no se puede editar, suelen ser no editables los compos calculados
            NotBlank = true; // No permite dejar este campo en blanco
            Numeric = true; // Admite o no solamente valores numericos
            CharAllowed = 'AZ'; // Caracteres permitidos. Los pongo en rangos DesdeHasta (ej: AZ / 09)
            DateFormula = false; // Formula para fechas (las veremos un poco mas adelante)
            ValuesAllowed = ''; // Valores permitidos
            SqlDataType = BigInteger; // En la tabla de la BD se guardara de esta forma
            TableRelation = "Radio Show"; // Tabla relacionada, aqui voy a guardar el Primary Key de la tabla foranea
            ValidateTableRelation = true; // Sirve para confirmar que los datos que existen en la otra tabla
            ExtendedDatatype = EMail; // Se usa para formatos y validaciones especiales, email, numero de telefono, url
        }

        field(4; "Propiedades Decimal e Integer"; Decimal)
        {
            DecimalPlaces = 2; // Numero de posiciones decimales para guardado y visualizacion
            BlankNumbers = BlankNeg; // Mostrar o no estos valores
            BlankZero = true; // Mostrar o no los valores cero
            SignDisplacement = -1; // Coloca el tipo negativo antes o despues del valor
            MaxValue = 1000; // Valor maximo que admite este campo
            MinValue = 0; // Valor minimo que admite este campo
            AutoIncrement = true; // Valor autoincremental, NO garantiza una secuencia numerica contigua
        }

        field(5; "Propiedades Option"; Option)
        {
            // Las opciones se almacenan segun su posicion, comienza por la posicion 0
            OptionMembers = ,Opcion2,Opcion3,Opcion4; // Si quiero una opcion vacia dejo un espacio en blanco al principio
            OptionCaption = 'Titulo del Option';
            // OptionCaptionML = EEU; // Opciones en otros idiomas
        }
    }
}
```