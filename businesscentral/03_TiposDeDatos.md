# Tipos de datos en Business Central

## Datos Númericos
- Integer: desde -2.147.483.648 hasta 2.147.283.647
- Decimal: -999.999.999.999.999,99
- Option: desde 0 a 147.483.646
- OptionMembers: Conjunto de opciones enumeradas en una cadena separada por comas
- Boolean: 0/1
- Biginteger: Entero de 8 bytes
- Char: Hexadecimal entre 0000 y FFFF
- Byte: 8 bits entre 0 y 255
- Action: 
- Executionmode: debug/standard

## Datos de Cadena
- Text: Hasta 250 caracteres alfanumericos (nombre Variable)
- Code: Entre 1 y 250 caracteres, Las letras siempre se almacenan en mayusculas y sin espacios
- TextBuilder: Permite la manipulacion de cadenas como 'Append', 'Replace' y 'Length'

## Datos de Fecha y Hora

## Tipos de Datos Complejos
- Archivos 
- Registros

## Objetos de BC
- Como por ejemplo: Page, Report, Codeunit, XmlPort, TableExtension

## Entrada y Salida
- Dialog: Ventana en la interfaz de usuario ()

## Datos de Fecha y Hora
- Date:
  - Contiene un numero entero que se interpreta como una fecha
  - El primer dia es el 01/01/1574 y el ultimo el 31/12/9999
  - Podemos escribir la fecha como MMDDAAAA (xEj 18112025) pero tambien MMDDAA (181124D) D significa fecha
- Time:
  - Contiene un numero que representa un reloj de 24h en milisegundos
  - Va desde las 00:00:00:0000 hasta las 23:59:59:9999
- DateTime:
  - Representa el dia y la hora combinadas en tiempo UTC
  - Util cuando necesitamos distintas zonas horarias
  - Va desde el 01/01/1574 00:00:00:0000 y el ultimo el 31/12/9999 23:59:59:9999
- Duration: representa la diferencia entre dos Datetime

## Formulas de Fecha
- DateFormula: Sirve para almacenar calculos de fechas sensible al tiempo
- Admite:
  - Multiplicadores numericos (xEj: 1, 2, 3...)
  - Unidades de tiempo (todas en mayuscula)
  - D = Dia
  - W = Semana
  - WD = Dia de la semana (del 1 al 7 siendo 1 = Lunes y 7 = Domingo)(a contar en la proxima semana)
  - M = Mes del calendario
  - Y = Año del calendario
  - CM = Mes actual (se refiere al ultimo dia del mes actual)
  - CY = Año actual
  - CW = Semana actual
  - Simbolos matematicos: xEj CM + 10D => fin de mes actual + 10 dias (o dia 10 del siguiente mes)
  - Notacion posicional:
    - D15 es el dia 15 del mes actual
    - 15D es 15 dias para operar
  -  