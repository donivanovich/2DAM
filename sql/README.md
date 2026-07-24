# Apuntes Oracle Academy SQL

---

## Índice

- [Apuntes Oracle Academy SQL](#apuntes-oracle-academy-sql)
  - [Índice](#índice)
  - [1 - Introduccion](#1---introduccion)
    - [**1-1 Oracle APEX**](#1-1-oracle-apex)
    - [**1-2 Tecnología de Base de Datos Relacional**](#1-2-tecnología-de-base-de-datos-relacional)
    - [**1-3 Anatomía de una Sentencia SQL**](#1-3-anatomía-de-una-sentencia-sql)
  - [2 - SELECT y WHERE](#2---select-y-where)
    - [**2-1 Columnas, Caraceres y Filas**](#2-1-columnas-caraceres-y-filas)
    - [**2-2 Limitación de Filas Seleccionadas**](#2-2-limitación-de-filas-seleccionadas)
    - [**2-3 Operadores de Comparación**](#2-3-operadores-de-comparación)
  - [3 - WHERE, ORDER BY e Introduccion a las Funciones](#3---where-order-by-e-introduccion-a-las-funciones)
    - [**3-1 Comparaciones Lógicas y Reglas de Prioridad**](#3-1-comparaciones-lógicas-y-reglas-de-prioridad)
    - [**3-2 Ordenación de Filas**](#3-2-ordenación-de-filas)
    - [**3-3 Introducción a las Funciones**](#3-3-introducción-a-las-funciones)
  - [4 - Funciones de Una Sola Fila Parte 1](#4---funciones-de-una-sola-fila-parte-1)
    - [**4-1 Manipulacion de Mayúsculas/Minúsculas y de Caracteres**](#4-1-manipulacion-de-mayúsculasminúsculas-y-de-caracteres)
    - [**4-2 Funciones Numéricas**](#4-2-funciones-numéricas)
    - [**4-3 Funciones de Fecha**](#4-3-funciones-de-fecha)
  - [5 - Funciones de Una Sola Fila Parte 2](#5---funciones-de-una-sola-fila-parte-2)
    - [**5-1 Funciones de Conversión**](#5-1-funciones-de-conversión)
    - [**5-2 Funciones NULL**](#5-2-funciones-null)
    - [**5-3 Expresiones Condicionales**](#5-3-expresiones-condicionales)
  - [6 - JOIN Parte 1](#6---join-parte-1)
    - [**6-1 Uniones Cruzadas y Uniones Naturales**](#6-1-uniones-cruzadas-y-uniones-naturales)
    - [**6-2 Cláusulas Join**](#6-2-cláusulas-join)
    - [**6-3 Uniones Internas frente a Externas**](#6-3-uniones-internas-frente-a-externas)
    - [**6-4 Autouniones y Consultas Jerárquicas**](#6-4-autouniones-y-consultas-jerárquicas)
  - [7 - JOIN Parte 2](#7---join-parte-2)
    - [**7-1 Unión Igualitaria y Producto Cartesiano de Oracle**](#7-1-unión-igualitaria-y-producto-cartesiano-de-oracle)
    - [**7-2 Uniones No Igualitarias y Uniones Externas de Oracle**](#7-2-uniones-no-igualitarias-y-uniones-externas-de-oracle)
  - [8 - Funciones de Grupo Parte 1](#8---funciones-de-grupo-parte-1)
    - [**8-1 Funciones de Grupo**](#8-1-funciones-de-grupo)
    - [**8-2 COUNT, DISTINCT, NVL**](#8-2-count-distinct-nvl)
  - [9 - Funciones de Grupo Parte 2](#9---funciones-de-grupo-parte-2)
    - [**9-1 Uso de las Cláusulas GROUP BY y HAVING**](#9-1-uso-de-las-cláusulas-group-by-y-having)
    - [**9-2 Uso de las Operaciones Rollup y Cube, y Grouping Sets**](#9-2-uso-de-las-operaciones-rollup-y-cube-y-grouping-sets)
    - [**9-3 Uso de los Operadores SET**](#9-3-uso-de-los-operadores-set)
  - [10 - Subconsultas](#10---subconsultas)
    - [**10-1 Conceptos Fundamentales de las Subconsultas**](#10-1-conceptos-fundamentales-de-las-subconsultas)
    - [**10-2 Subconsultas de Una Sola Fila**](#10-2-subconsultas-de-una-sola-fila)
    - [**10-3 Subconsultas de Varias Filas**](#10-3-subconsultas-de-varias-filas)
    - [**10-4 Subconsultas Correlacionadas**](#10-4-subconsultas-correlacionadas)
  - [11 - Garantia de Consultas de Calidad Parte 1](#11---garantia-de-consultas-de-calidad-parte-1)
    - [**11-1 Garantia de Resultados de Consultas de Calidad**](#11-1-garantia-de-resultados-de-consultas-de-calidad)
  - [12 - DML](#12---dml)
    - [**12-1 Sentencias INSERT**](#12-1-sentencias-insert)
    - [**12-2 Actualizacion de Valores de Columnas y Supresion de Filas**](#12-2-actualizacion-de-valores-de-columnas-y-supresion-de-filas)
    - [**12-3 Valores DEFAULT, MERGE e Inserciones en Varias Tablas**](#12-3-valores-default-merge-e-inserciones-en-varias-tablas)
  - [13 - DDL](#13---ddl)
    - [**13-1 Creacion de Tablas**](#13-1-creacion-de-tablas)
    - [**13-2 Uso de Tipos de Dato**](#13-2-uso-de-tipos-de-dato)
    - [**13-3 Modificacion de una Tabla**](#13-3-modificacion-de-una-tabla)
  - [14 - Restricciones](#14---restricciones)
    - [**14-1 Introduccion a las Restricciones NOT NULL y UNIQUE**](#14-1-introduccion-a-las-restricciones-not-null-y-unique)
    - [**14-2 Restricciones PRIMARY KEY, FOREIGN KEY y CHECK**](#14-2-restricciones-primary-key-foreign-key-y-check)
    - [**14-3 Gestion de Restricciones**](#14-3-gestion-de-restricciones)
  - [15 - Vistas](#15---vistas)
    - [**15-1 Creacion de Vistas**](#15-1-creacion-de-vistas)
    - [**15-2 Operaciones DML y Vistas**](#15-2-operaciones-dml-y-vistas)
    - [**15-3 Gestion de Vistas**](#15-3-gestion-de-vistas)
  - [16 - Secuencias y Sinonimos](#16---secuencias-y-sinonimos)
    - [**16-1 Trabajar con Secuencias**](#16-1-trabajar-con-secuencias)
    - [**16-2 Indices y Sinonimos**](#16-2-indices-y-sinonimos)
  - [17 - Privilegios y Expresiones Regulares](#17---privilegios-y-expresiones-regulares)
    - [**17-1 Control de Acceso de los Usuarios**](#17-1-control-de-acceso-de-los-usuarios)
    - [**17-2 Creacion y Revocacion de Privilegios de Objeto**](#17-2-creacion-y-revocacion-de-privilegios-de-objeto)
    - [**17-3 Expresiones Regulares**](#17-3-expresiones-regulares)
  - [18 - TCL](#18---tcl)
    - [**18-1 Transacciones de Base de Datos**](#18-1-transacciones-de-base-de-datos)
  - [19 - Proyecto Final y Revision de Examen](#19---tcl)
    - [**19-1 Pruebas**](#19-1-pruebas)
    - [**19-2 Creacion de la BBDD del Proyecto Final**](#19-2-creacion-de-la-bbdd-del-proyecto-final)
    - [**19-2 Revision del Examen Final**](#19-3-revision-del-examen-final)
  - [20 - Garantia de Consultas de Calidad Parte 2](#20---garantia-de-consultas-de-calidad-parte-2)
    - [**20-1 Garantia de Resultados de Consultas de Calidad - Tecnicas Avanzadas**](#20-1-garantia-de-resultados-de-consultas-de-calidad---tecnicas-avanzadas)

## 1 - Introduccion

### **1-1 Oracle APEX**

- Dos componentes en *Oracle APEX* son:
    1. *Taller de SQL*
    2. *Creador de Aplicaciones*
- Para obtener más información sobre SQL, utilizará el componente **Taller de SQL**
- Para diseñar una aplicación, se utiliza **Creador de Aplicaciones**
- El comando SELECT * devuelve todas las filas de una tabla
```sql
SELECT *
FROM employees;
```
- Para devolver ciertas columnas de una BBDD y con condiciones, modifique la sentencia SELECT
```sql
SELECT first_name, last_name, job_id
FROM employees
WHERE job_id = '1';
```

### **1-2 Tecnología de Base de Datos Relacional**

- Una **base de datos relacional** permite relacionar tablas por medio de un campo común
- Con solo dos tablas se puede considerar como una base de datos relacional si comparten un campo común

| COUNTRY_ID | COUNTRY_NAME             | REGION_ID |
|------------|--------------------------|-----------|
| CA         | Canada                   | 2         |
| DE         | Germany                  | 1         |
| UK         | United Kingdom           | 1         |
| US         | United States of America | 2         |

- Términos Clave
    1. tabla: estructura básica de almacenamiento
    2. columna: un tipo de datos de una tabla
    3. fila: datos de una instancia de tabla
    4. campo: valor de la intersección de una fila y una columna
    5. clave primaria: identificador único para cada fila
    6. clave ajena: columna que hace referencia a una columna de clave primaria de otra tabla

- Propiedades de Tablas
    1. Las entradas en las columnas tienen un valor único
    2. Las entradas en las columnas son del mismo tipo
    3. Cada fila es única
    4. La secuencia de columnas no es significativa
    5. La secuencia de filas no es significativa
    6. Cada columna tiene un nombre único

- Categorías de Sentencias SQL
    1. Lenguaje de manipulación de datos **(DML)**
        - Las sentencias DML comienzan con **INSERT**, **UPDATE**, **DELETE** o **MERGE** y **se utilizan para modificar los datos de la tabla** introduciendo nuevas filas, cambiando las filas existentes o eliminando las filas existentes
    2. Lenguaje de definición de datos **(DDL)**
        - Las sentencias DDL **crean, cambian y eliminan las estructuras de datos de la base de datos**
        - Las palabras clave **CREATE**, **ALTER**, **DROP**, **RENAME** y **TRUNCATE** comienzan las sentencias DDL
    3. Lenguaje de control de transacciones **(TCL)**
        - Las sentencias TCL **se utilizan para gestionar los cambios realizados por sentencias DML**
        - Los cambios de los datos se ejecutan mediante **COMMIT**, **ROLLBACK** y **SAVEPOINT**
        - Los cambios del TCL se pueden agrupar en transacciones lógicas
    4. Lenguaje de control de datos **(DCL)**
        - Las palabras clave del DCL **GRANT** y **REVOKE** **se utilizan para proporcionar o eliminar derechos de acceso** a la base de datos y las estructuras dentro de ell

### **1-3 Anatomía de una Sentencia SQL**

- SELECT
    ```sql
    SELECT <column_name(s)>
    FROM <table_name>;
    ```

    - Se utiliza para recuperar información de la base de datos permitiendo buscar datos específicos

    - Una palabra clave **hace referencia a un comando SQL** *(SELECT/FROM)*

    - Una cláusula **es una parte de una sentencia SQL** *(SELECT employee_id, last_name)*
    
    - Una sentecia **es una combinación de dos o más cláusulas** *(SELECT last_name FROM employees)*
    
    - Proyección: se utiliza para seleccionar columnas de una tabla
    
    - Selección: se utiliza para seleccionar filas de una tabla
    
    ```sql
    SELECT salary -- Proyección
    FROM employees
    WHERE last_name LIKE 'Smith'; -- Selección
    ```
    - Puede mostrar todas las columnas de datos de una tabla con **(*)**
    
    ```sql
    SELECT *
    FROM countries;
    ```

    - Uso de Operadores Aritméticos
        1. **sumar** (+)
        2. **restar** (-)
        3. **multiplicar** (*)
        4. **dividir** (/)
        - Prioridad de los Operadores Aritméticos: * / + -
    
    - **NULL** es un valor que no está disponible, sin asignar, desconocido o que no es aplicable
    
    - Un alias es una forma de cambiar el nombre de una cabecera de columna en la salida con la palabra clave **AS**
    ```sql
    SELECT last_name AS name, commission_pct AS comm
    FROM employees;
    ```

## 2 - SELECT y WHERE

### **2-1 Columnas, Caraceres y Filas**

- El comando **DESCRIBE (DESC)** se utiliza para mostrar la estructura de una tabla, devolviendo el nombre de la tabla, los tipos de dato, las claves primarias y ajenas y las columnas con valores nulos

```sql
DESCRIBE <table_name>
```

- El operador de concatenación **||** enlaza columnas a otras columnas, expresiones aritméticas o valores constantes para crear una expresión de caracteres

```sql
SELECT department_id || department_name
FROM departments;
```

- Esta variante **||' '||** se utiliza para introducir un espacio entre los datos de las columnas concatenadas y un alias a la concatenación

```sql
SELECT department_id ||' => '|| department_name AS "Department Info"
FROM departments;
```
|   Department Info   |
|---------------------|
| 10 => Administration|
| 20 => Marketing     |
| 50 => Shipping      |
| 60 => IT            |

- Se utiliza la palabra clave **DISTINCT** para eliminar las filas duplicadas

```sql
SELECT DISTINCT department_id
FROM employees
```

### **2-2 Limitación de Filas Seleccionadas**

- La cláusula **WHERE** se utiliza para limitar las filas de datos que se muestran

```sql
SELECT employee_id, first_name, last_name
FROM employees
WHERE employee_id = 101;
```

- Se pueden utilizar otros operadores de comparación para comparar una expresión con otra:
    1. **=**  igual que
    2. **>**  mayor que
    3. **>=** mayor o igual que
    4. **<**  menor que
    5. **<=** menor o igual que
    6. **<>** no es igual que (o **!=** o **^=**)

- Las fechas y cadenas de caracteres se deben incluir entre comillas simples**('')**, los números no

### **2-3 Operadores de Comparación**

- El operador **BETWEEN...AND** se utiliza para seleccionar y mostrar las filas según un rango de valores

```sql
SELECT last_name, salary
FROM employees
WHERE salary BETWEEN 9000 AND 11000;
```

- La condición **IN** se utiliza para probar si un valor está en un juego de valores especificado

```sql
SELECT city, state_province, country_id
FROM locations
WHERE country_id IN ('UK', 'SP');
-- WHERE country_id = 'UK' OR country_id = 'SP'
```

- La condición **LIKE** permite seleccionar las filas que coincidan con caracteres, fechas o patrones de números
    - El símbolo **(%)** se utiliza para representar cualquier secencia de cero o más caracteres 
    - El símbolo **(_)** se utiliza para representar un único carácter

```sql
-- En este ejemplo se muestran todos los apellidos que empiecen por cualquier letra seguida de una "o" y seguidos de cualquier otro número de letras
SELECT last_name
FROM employees
WHERE last_name LIKE '_o%';
```

- La opción **ESCAPE** se utiliza para indicar que los caracteres **_** o **%** son parte del nombre

```sql
-- En este ejemplo se desea mostrar el JOB_ID de empleados que contenga '_R'
SELECT last_name, job_id
FROM employees
WHERE job_id LIKE '%\_R%' ESCAPE '\';
```

- La condición **IS NULL** prueba los datos null
- **IS NOT NULL** prueba los datos que no sean null

```sql
SELECT last_name, manager_id
FROM employees
WHERE manager_id IS NULL;
```

## 3 - WHERE, ORDER BY e Introduccion a las Funciones

### **3-1 Comparaciones Lógicas y Reglas de Prioridad**

- Las condiciones lógicas combinan el resultado de dos condiciones de componentes para producir un único resultado según dichas condiciones

- Un operador lógico combina los resultados de dos o más condiciones para producir un único resultado
    - **AND** devuelve **TRUE** si ambas condiciones son verdaderas

        ```sql
        SELECT last_name, hire_date, job_id
        FROM employees
        WHERE hire_date > '01-Jan-1998' AND job_id LIKE 'SA%';
        ```

        |LAST_NAME |HIRE_DATE  | JOB_ID|
        |----------|-----------|-------|
        |Zlotkey   |29-Jan-2000|SA_MAN |
        |Taylot    |24-Mar-1998|SA_REP |
        |Grant     |24-May-1999|SA_REP |

    - **OR** devuelve **TRUE** si cualquier condición es verdadera

        ```sql
        SELECT department_name, manager_id, location_id
        FROM departments
        WHERE location_id = 2500 OR manager_id = 124;
        ```

        |DEPARTMENT_NAME|MANAGER_ID|LOCATION_ID|
        |---------------|----------|-----------|
        |Shipping       |124       |1500       |
        |Sales          |149       |2500       |

    - **NOT** devuelve **TRUE** si la condición es falsa

        ```sql
        SELECT department_name, location_id
        FROM departments
        WHERE location_id NOT IN (1700, 1800);
        ```

        |DEPARTMENT_NAME|LOCATION_ID|
        |---------------|-----------|
        |Shipping       |1500       |
        |IT             |1400       |
        |Sales          |2500       |

- El operador **AND** se evalúa antes que el operador **OR**, si no se cumple alguna de las condiciones de la sentencia **AND**, se utilizá el operador **OR** para seleccionar las filas

    ```sql
    SELECT last_name || ' ' || salary * 1.05 AS "Employee Raise", department_id, first_name
    FROM employees
    WHERE department_id IN (50, 80)
        AND first_name LIKE 'C%'
        OR last_name LIKE '%s%';
    ```

    | Employee Raise  | DEPARTMENT_ID | FIRST_NAME |
    | --------------- | ------------- | ---------- |
    | Higgins 12600   | 110           | Shelley    |
    | Mourgos 6090    | 50            | Kevin      |
    | Rajs 3675       | 50            | Trenna     |
    | Davies 3255     | 50            | Curtis     |
    | Matos 2730      | 50            | Randall    |
    | Vargas 2625     | 50            | Peter      |
    | Ernst 6300      | 60            | Bruce      |
    | Hartstein 13650 | 20            | Michael    |

- Agregar paréntesis cambia la forma en la que se evalúa la cláusila **WHERE** y las filas devueltas

    ```sql
    SELECT last_name || ' ' || salary * 1.05 AS "Employee Raise", department_id, first_name
    FROM employees
    WHERE (department_id IN (50,80) OR first_name LIKE 'C%')
    AND last_name LIKE '%s%';
    ```

### **3-2 Ordenación de Filas**

- El orden de ejecución de una sentencia SELECT es el siguiente:
    - **Cláusula FROM:** busca la tabla que contiene los datos
    - **Cláusula WHERE:** restringe las filas que se van a devolver
    - **Cláusula SELECT:** selecciona en el conjunto de datos reducido las columnas solicitadas
    - **Cláusula ORDER BY:** ordena el conjunto de resultados

- **NULLS FIRST** especifica que los valores nulos se deben devolver antes 

- **NULLS LAST** especifica que los valores no nulos se deben devolver

- La cláusula **ORDER BY** se utiliza para ordenar datos, por defecto es ascendente
    ```sql
    SELECT last_name, hire_date
    FROM employees
    ORDER BY hire_date;
    ```

    | LAST_NAME | HIRE_DATE   |
    | --------- | ----------- |
    | King      | 17-Jun-1987 |
    | Whalen    | 17-Sep-1987 |
    | Kochhar   | 21-Sep-1989 |
    | Hunold    | 03-Jan-1990 |
    | Ernst     | 21-May-1991 |
    | De Haan   | 13-Jan-1993 |
    | Gietz     | 07-Jun-1994 |
    | Higgins   | 07-Jun-1994 |
    | Rajs      | 17-Oct-1995 |
    | Hartstein | 17-Feb-1996 |

    - Con la palabra clave **DESC** se puede invertir el orden por defecto en la cláusula **ORDER BY**

        ```sql
        SELECT last_name, hire_date
        FROM employees
        ORDER BY hire_date DESC;
        ```

        | LAST_NAME | HIRE_DATE   |
        | --------- | ----------- |
        | Zlotkey   | 29-Jan-2000 |
        | Mourgos   | 16-Nov-1999 |
        | Grant     | 24-May-1999 |
        | Lorentz   | 07-Feb-1999 |
        | Vargas    | 09-Jul-1998 |
        | Taylor    | 24-Mar-1998 |
        | Matos     | 15-Mar-1998 |
        | Fay       | 17-Aug-1997 |
        | Davies    | 29-Jan-1997 |
        | Abel      | 11-May-1996 |
    
    - Puede ordenar los datos mediante un alias de columna

        ```sql
        SELECT last_name, hire_date AS "Date Started"
        FROM employees
        ORDER BY "Date Started";
        ```

        | LAST_NAME | Date Started |
        | --------- | ------------ |
        | King      | 17-Jun-1987  |
        | Whalen    | 17-Sep-1987  |
        | Kochhar   | 21-Sep-1989  |
        | Hunold    | 03-Jan-1990  |
        | Ernst     | 21-May-1991  |
        | De Haan   | 13-Jan-1993  |
        | Gietz     | 07-Jun-1994  |
        | Higgins   | 07-Jun-1994  |
        | Rajs      | 17-Oct-1995  |
        | Hartstein | 17-Feb-1996  |

    - También se puede ordenar los resultados de la consulta por más de una columna
        ```sql
        SELECT department_id, last_name
        FROM employees
        WHERE department_id <= 50
        ORDER BY department_id, last_name;
        ```
        | DEPARTMENT_ID | LAST_NAME |
        | ------------- | --------- |
        | 10            | Whalen    |
        | 20            | Fay       |
        | 20            | Hartstein |
        | 50            | Davies    |
        | 50            | Matos     |
        | 50            | Mourgos   |
        | 50            | Rajs      |
        | 50            | Vargas    |

### **3-3 Introducción a las Funciones**

- Las funciones tienen tanto entrada **(argumento)** como salida

- Funciones de una Sola Fila 
    - Funcionan solo en filas únicas y devuelven un resultado por fila, exiten funciones como carácter, número, fecha y conversión
    - Se utilizan para:
        - Realizar cálculos como redondear números
        - Modificar elementos de datos individuales como la conversión de valores de caracteres de mayúsculas a minúsculas
        - Dar formato a fechas y números para su visualización 
        - Convertir los tipos de dato de columna
    - Aceptan uno o más argumentos y devolverán un único resultado por fila
- Funciones de Varias Filas 
    - Pueden manipular grupos de filas para proporcionar un resultado por grupo de filas
    - Toman muchas filas como entrada, y devuelven un valor único como salida
    - Ejemplos de funciones de varias filas
        - **MAX**: busca el valor más alto en un grupo de filas
        - **MIN**: busca el valor más bajo en un grupo de filas
        - **AVG**: busca el valor medio de un grupo de filas

## 4 - Funciones de Una Sola Fila Parte 1

### **4-1 Manipulacion de Mayúsculas/Minúsculas y de Caracteres**

- Tabla Dual
    |DUMMY|
    |-----|
    |  X  |
    - Tiene una fila denominada **"X"** y una columna denominada **"DUMMY"**
    - Se utiliza para crear sentencias **SELECT** y ejecutar funciones que no estén directamente relacionadas con una tabla de BBDD concreta
    - Las consultas que utilizan la tabla DUAL devuelven una fila como resultado
    - **DUAL** se utilizará para obetener muchas de las funciones de una sola fila
    ```sql
    -- En este ejemplo la tabla DUAL se utiliza para ejecutar una sentencia SELECT que contenga un cálculo
    SELECT (319/29) + 12
    FROM DUAL;
    ```
    | (319/29)+12 |
    | ----------- |
    | 23          |

- Funciones de **Caracteres** de **Una Sola Fila**
    - Se dividen en dos categorias:
        - Funciones que convierten las mayúsculas/minúsculas de las cadenas de caracteres
        - Funciones que pueden unir, extraer, mostrar, encontrar, rellenar, recortar cadenas de caracteres
    - Las funciones de una sola fila se pueden utilizar en cláusulas **SELECT**, **WHERE** y **ORDER BY**

- Funciones de Manipulación de Mayúsculas/Minúsculas 
    - Se utilizan para convertir los datos del estado en el que se almacenan en una tabla en mayúsculas, minúsculas o mayúsculas y minúsculas
    - Se puede utilizar para aplicar formato a la salida y también se pueden usar para buscar cadenas específicas
    - Funciones:
        - **LOWER**(columna | expresión) convierte los caracteres alfabéticos en minúscula
            ```sql
            SELECT last_name
            FROM employees
            WHERE LOWER(last_name) = 'abel';
            ```

        - **UPPER**(columna | expresión) convierte los caracteres alfabéticos en mayúscula
            ```sql
            SELECT last_name
            FROM employees
            WHERE UPPER(last_name) = 'ABEL';
            ```

        - **INITCAP**(columna | expresión) convierte los valores de caracteres alfabéticos en mayúscula para la primera letra de cada palabra
            ```sql
            SELECT last_name
            FROM employees
            WHERE INITCAP(last_name) = 'Abel';
            ```

- Funciones de Manipulación de Caracteres
    - Se utilizan para extraer, cambiar, formatear o modificar de alguna forma una cadena de caracteres
    - A la función se pasan uno o más caracteres o palabras, entonces, esta realiza sus funciones en las cadenas de caracteres de entrada y devuelve el valor cambiado, extraído, contado o alterado
    - Funciones:
        - **CONCAT**(cadena | cadena) une dos valores
            ```sql
            SELECT CONCAT(first_name, last_name)
            FROM employees;
            -- CurtisDavies
            ```
        - **SUBSTR**(cadena | posicionInicial | length) extrae una cadena de una longitud determinada
            ```sql
            SELECT SUBSTR(last_name, 1, 3)
            FROM employees;
            -- Dav
            ```
        - **LENGTH**(cadena) muestra la longitud de una cadena como un valor númerico
            ```sql
            SELECT LENGTH(last_name)
            FROM employees;
            -- 6
            ```
        - **INSTR**(cadena | cadena) encuentra la posición numérica de los caracteres especificados
            ```sql
            SELECT last_name, INSTR(last_name, 'a')
            FROM employees;
            -- Davies 2
            ```
        - **LPAD**(cadena | totalCaracteres | caracterRelleno) rellena la parte izquierda de una cadena dando lugar a un valor justificado a la derecha
            ```sql
            SELECT LPAD(last_name, 10, '*')
            FROM employees;
            -- ****Davies
            ```
        - **RPAD**(cadena | totalCaracteres | caracterRelleno) rellena la parte derecha de una cadena, dando lugar a un valor justificado a la izquierda
            ```sql
            SELECT RPAD(last_name, 10, '*')
            FROM employees;
            -- Davies****
            ```
        - **TRIM** elimina todos los caracteres especificados
            ```sql
            SELECT TRIM(LEADING 'a' FROM 'abcba')
            FROM DUAL;
            -- Elimina la primera 'a'
            -- Resultado: bcba

            SELECT TRIM(TRAILING 'a' FROM 'abcba')
            FROM DUAL;
            -- Elimina la última 'a'
            -- Resultado: abcb

            SELECT TRIM(BOTH 'a' FROM 'abcba')
            FROM DUAL;
            -- Elimina la primera y última 'a'
            -- Resultado: bcb
            ```
        - **REPLACE**(cadena | cadenaAReemplazar | [cadenaReemplazada]) sustituye una subcadena de una cadena por otra subcadena
            ```sql
            SELECT REPLACE(last_name, 'a', '*')
            FROM employees;
            -- D*vies
            ```

- Se puede dar un alias al resultado de las funciones de manipulación
    ```sql
    SELECT LOWER(last_name) || LOWER(SUBSTR(first_name,1,1)) AS "User Name"
    FROM employees;
    ```
    | User Name   |
    |-------------|
    | abele       |
    | daviesc     |
    | de haanl    |

- Variables de Sustitución
    - Sirven para ejecutar la misma consulta con muchos valores diferentes para obtener conjuntos de resultados diferentes, mostrando una ventana emergente para introducir los valores
    ```sql
    SELECT first_name, last_name, salary, department_id
    FROM employees
    WHERE department_id = :enter_dept_id;
    ```

### **4-2 Funciones Numéricas**

- Funciones Númericas
    - **ROUND**(columna, decimalPlace) se utiliza para redondear números a un número especificado de posiciones decimales y también para redonder números a la izquierda de la coma decimal
        ```sql
        - ROUND(45.926) => 46
        - ROUND(45.926, 0) => 46
        - ROUND(45.926, 2) => 45.93
        - ROUND(45.926, -1) => 50
        ```
    - **TRUNC**(columna, decimalPlace) se utiliza para terminar la columna, expresión o el valor en un número especificado de posiciones decimales
        ```sql
        - TRUNC(45.926) 45
        - TRUNC(45.926, 0) 45
        - TRUNC(45.926, 2) 45.92
        ```
    - **MOD**(columna, valor) encuentra el resto después de que un valor se divida entre otro valor y se utiliza para determinar si un valor es par o impar
        ```sql
        SELECT country_name, MOD(airports, 2) AS "Mod Demo"
        FROM wf_countries;
        ```
        | COUNTRY_NAME           | Mod Demo |
        | ---------------------- | -------- |
        | Canada                 | 1        |
        | Republic of Costa Rica | 0        |
        | Republic of Cape Verde | 1        |
        | Greenland              | 0        |
        | Dominican Republic     | 0        |
        | State of Eritrea       | 1        |

### **4-3 Funciones de Fecha**

- La visualización por defecto y el formato de entrada de las fechas es **DD-Mon-YYYY**

- **SYSDATE** devuelve la fecha y hora actuales del servidor de BBDD
    ```sql
    SELECT SYSDATE
    FROM dual;
    -- 12-Jul-2025
    ```

- Tipo de Dato **DATE** 
    - Siempre almacena internamente la información del año como un número de 4 dígitos: dos para el siglo y dos para el año
    - Las funciones de fecha devuelven un valor del tipo de dato Date excepto **MONTHS_BETWEEN**
        | Función        | Descripción                                                        |
        | -------------- | ------------------------------------------------------------------ |
        | MONTHS_BETWEEN | Número de meses entre dos fechas                                   |
        | ADD_MONTHS     | Agregar meses de calendario a fecha                                |
        | NEXT_DAY       | Fecha de la siguiente incidencia del día de la semana especificado |
        | LAST_DAY       | Último día del mes                                                 |
        | ROUND          | Redondear fecha                                                    |
        | TRUNC          | Truncar fecha                                                      |

- Funciones de Fecha
    - **MONTH_BETWEEN**(date, date) devuelve el número de meses de calendario entre 2 fechas
        ```sql
        SELECT last_name, hire_date
        FROM employees
        WHERE MONTHS_BETWEEN(SYSDATE, hire_date) > 240;
        -- King | 17-Jun-1987
        ```
    - **ADD_MONTH**(date, int) toma una fecha y un número y devuelve un valor de fecha con el argumento númerico agregado al componente mensual de la fecha
        ```sql
        SELECT ADD_MONTHS(SYSDATE, 12) AS "Next Year"
        FROM dual;
        -- Resultado: 01-Jul-2016
        ```
    - **NEXT_DAY**(date, diaDeSemana) toma una fecha y un día de la semana y devuelve la fecha de la siguiente incidencia de ese día de la semana después del argumento DATE
        ```sql
        SELECT NEXT_DAY(SYSDATE, 'Saturday') AS "Next Saturday"
        FROM dual;
        -- Resultado: 08-Jul-2017
        ```
    - **LAST_DAY**(date) toma una fecha y devuelve la fecha del último día del mes del argumento DATE
        ```sql
        SELECT LAST_DAY(SYSDATE) AS "End of the Month"
        FROM dual;
        -- Resultado: 31-Jul-2015
        ```
    - **ROUND**(date, unidadFecha) devuelve una fecha redondeada a la unidad especificada
        ```sql
        SELECT hire_date, ROUND(hire_date, 'Month')
        FROM employees
        WHERE department_id = 50;
        -- 16-Nov-1999 | 01-Dec-1999
        ```
    - **TRUNC**(fecha, unidadFecha) devuelve una fecha truncada a la unidad especificada
        ```sql
        SELECT last_name, hire_date + 60
        FROM employees;
        -- Añade 60 dias a hire_date
        ```

## 5 - Funciones de Una Sola Fila Parte 2

### **5-1 Funciones de Conversión**

- Tipos de datos
    - **VARCHAR2** se utiliza para datos de caracteres de longitud variable
    - **CHAR** se utiliza para datos de texto y de caracteres de longitud fija
    - **NUMBER** se utiliza para almacenar datos númericos de longitud variable
    - **DATE** se utiliza para valores de fecha y hora

    | Formato       | Descripción                          |
    | ------------- | ------------------------------------ |
    | YYYY          | Año completo en números              |
    | YEAR          | Año en letra                         |
    | MM            | Valor de dos dígitos del mes         |
    | MONTH         | Nombre completo del mes              |
    | MON           | Abreviatura de tres letras del mes   |
    | DY            | Abreviatura de tres letras del día   |
    | DAY           | Nombre completo del día de la semana |
    | DD            | Día numérico del mes                 |
    | DDspth        | FOURTEENTH                           |
    | Ddspth        | Fourteenth                           |
    | ddspth        | fourteenth                           |
    | DDD o DD o D  | Día del año, mes o semana            |
    | HH24:MI:SS AM | 15:45:32 PM                          |
    | DD "of" MONTH | 12 de octubre                        |

- Conversión de Tipo
    - Se puede convertir automáticamente **VARCHAR2** y **CHAR** en **NUMBER** y **DATE**
    - Puede convertir datos de tipo **NUMBER** y **DATE** a **CHAR**
    - Funciones de conversión de tipos de dato:
        - Convertir dato date a char
            ```sql
            TO_CHAR (date column name, 'format model you specify')
            ```
            ```sql
            SELECT TO_CHAR(hire_date, 'Month dd, YYYY')
            FROM employees;
            -- Resultado: June 07, 1994
            ```
            ```sql
            SELECT TO_CHAR(SYSDATE, 'hh:mm')
            FROM dual;
            -- Resultado: 02:07
            ```
        - Convertir dato int a chat
            ```sql
            TO_CHAR(number, 'format model')
            ```
            ```sql
            SELECT TO_CHAR(3000, '$99999.99')
            FROM dual;
            -- Resultado: 3000,00 $
            ```
        - Convertir dato char a int
            ```sql
            TO_NUMBER(character string, 'format model')
            ```
            ```sql
            SELECT TO_NUMBER('5,320', '9,999')
            AS "Number"
            FROM dual;
            -- Resultado: 5320
            ```
        - Convertir dato char a date
            ```sql
            TO_DATE('character string', 'format model')
            ```
            ````sql
            SELECT TO_DATE('May10,1989', 'fxMonDD,YYYY')
            AS "Convert"
            FROM DUAL;
            -- Resultado: 10-May-1989
            ```
    - Reglas del Modificador **fx**
        - La puntuación y el texto entre comillas en el argumento de caracteres deben coincidir con las partes correspondientes del modelo de formato exactamente
        - El argumento de carácter no puede tener espacios en blanco adicionales
        - Los datos numéricos del argumento de carácter deben tener el mismo número de dígitos que el elemento correspondiente en el modelo de formato
        
        | Ejemplo                                                                  | Resultado   |
        | ------------------------------------------------------------------------ | ----------- |
        | SELECT TO_DATE('Sep 07, 1965', 'fxMon dd, YYYY') AS "Date" FROM dual;    | 07-Sep-1965 |
        | SELECT TO_DATE('July312004', 'fxMonthDDYYYY') AS "Date" FROM dual;       | 31-Jul-2004 |
        | SELECT TO_DATE('June 19, 1990', 'fxMonth dd, YYYY') AS "Date" FROM dual; | 19-Jun-1990 |

- Formato de Fecha RR y Formato de Fecha YY
    - Todos los datos de fecha ahora se almacenan utilizando años de cuatro dígitos (YYYY), pero pueden seguir utilizando el formato de dos dígitos (YY) o (RR)
        ```sql
        SELECT TO_DATE('27-Oct-95','DD-Mon-YY')
        AS "Date"
        FROM dual;
        -- Resultado: 27-Oct-2095
        ```
        ```sql
        SELECT TO_DATE('27-Oct-95','DD-Mon-RR')
        AS "Date"
        FROM dual;
        -- Resultado: 27-Oct-1995
        ```
    - Reglas Sencillas
        - Si el año actual está entre 0-49:
            - Fechas a partir de **0-49**, la fecha estará en el siglo actual (2000)
            - Fechas a partir de **50-99**, la fecha estará en el siglo pasado (1900)
        - Si el año actual está entre 50-99:
            - Fechas a partir de **0-49**, la fecha estará en el siglo siguiente (2100)
            - Fechas a partir de **50-99**, la fecha estará en el siglo actual (2000)
        
        | Año Actual | Fecha Especificada | Formato RR | Formato YY |
        | ---------- | ------------------ | ---------- | ---------- |
        | 1995       | 27-Oct-95          | 1995       | 1995       |
        | 1995       | 27-Oct-17          | 2017       | 1917       |
        | 2015       | 27-Oct-17          | 2017       | 2017       |
        | 2015       | 27-Oct-95          | 1995       | 2095       |

### **5-2 Funciones NULL**

- Método de Evaluación de las Funciones
    ```sql
    SELECT TO_CHAR(
            NEXT_DAY(
                ADD_MONTHS(hire_date, 6), 
                'FRIDAY'
                ), 
                'fmDay, Month ddth, YYYY'
    ) AS "Next Evaluation"
    FROM employees
    WHERE employee_id = 100;
    -- Resultado: Friday, December 18th, 1987
    ```
    1. A la fecha de contratación se le van a agregar seis meses
    2. Se identificará el primer viernes siguiente al día devuelto en el paso 1
    3. Al formato de fecha por defecto se le aplicará formato para que muestre la fecha devuelta por el paso 2 en un formato similar a: Friday, December 18th, 1987, y aparecerá en la salida bajo el nombre de la columna "Next Evaluation"

- Funciones Relacionadas con los Valores Nulos
    - **NVL** convierte un valor nulo en un valor conocido de un tipo de dato fijo
        ```sql
        NVL(expression_1, expression_2)
        -- expression_1: valor que puede contener NULL
        -- expression_2: valor por el que se sustituye si es NULL
        ```
        ```sql
        SELECT country_name, NVL(internet_extension, 'None') AS "Internet extn"
        FROM wf_countries
        WHERE location = 'Southern Africa'
        ORDER BY internet_extension DESC;
        -- Los valores nulos se sustituyen por 'None'
        ```
    - **NVL2** evalúa una expresión con tres valores
        ```sql
        NVL2(expression_1, expression_2, expression_3)
        -- expression_1: valor que puede contener NULL
        -- expression_2: valor a devolver si expression_1 NO es NULL
        -- expression_3: valor a devolver si expression_1 SÍ es NULL
        ```
        ```sql
        SELECT last_name, salary,
            NVL2(commission_pct, salary + (salary * commission_pct), salary) AS income
        FROM employees
        WHERE department_id IN (80, 90);
        -- Zlotkey | 10500 | 12600
        ```
    - **NULLIF** compara dos expresiones, si son iguales devuelve null y si no son iguales devuelve la primera expresion 
        ```sql
        NULLIF(expresion1, expression2)
        ```
        ```sql
        SELECT first_name, LENGTH(first_name) AS "Length FN",
            last_name, LENGTH(last_name) AS "Length LN",
            NULLIF(LENGTH(first_name), LENGTH(last_name)) AS "Compare Them"
        FROM employees;
        -- Ellen | 5 | Abel | 4 | 5
        ```
    - **COALESCE** es una extensión de la función **NVL**, pero puede tener varios valores, y lo que hace es una unión
        ```sql
        COALESCE(expression1, expression2, ...expressionN)
        ```
        ```sql
        SELECT last_name,
        COALESCE(commission_pct, salary, 10) AS "Comm"
        FROM employees
        ORDER BY commission_pct;
        ```

### **5-3 Expresiones Condicionales**

- Expresiones Condicionales
    - **CASE** permite realizar evaluaciones condicionales dentro de una consulta, devolviendo diferentes valores según se cumplan ciertas condiciones
        ```sql
        CASE expr
            WHEN comparison_expr1 THEN return_expr1
            [WHEN comparison_expr2 THEN return_expr2
            WHEN comparison_exprn THEN return_exprn
            ELSE else_expr]
        END
        ```
        ```sql
        SELECT last_name,
        CASE department_id
            WHEN 90 THEN 'Management'
            WHEN 80 THEN 'Sales'
            WHEN 60 THEN 'It'
            ELSE 'Other dept.'
        END AS "Department"
        FROM employees;
        ```
    - **DECODE** realiza comparaciones y devuelve valores según condiciones, siendo similar al **CASE** pero con sintaxis más corta
        ```sql
        DECODE(column1|expression, search1, result1
        [, search2, result2, ...]
        [, default])
        ```
        ```sql
        SELECT last_name,
            DECODE(department_id,
                    90, 'Management',
                    80, 'Sales',
                    60, 'It',
                    'Other dept.')
            AS "Department"
        FROM employees;
        ```

## 6 - JOIN Parte 1

### **6-1 Uniones Cruzadas y Uniones Naturales**

- Unión Natural
    - Es una forma de combinar tablas automáticamente usando todas las columnas que tienen el mismo nombre y tipo en ambas tablas. No requiere que indiques la condición; SQL detecta y usa las columnas comunes, mostrando solo una vez cada columna coincidente y evitando duplicados
    - Combina campos de 2 o mas tablas en una BBDD relacional
    - Se basa en todas las columnas de 2 tablas que tengan el mismo nombre y selecciona las filas de las 2 tablas que tengan valores equivalentes en todas las columnas coincidentes
    ```sql
    SELECT first_name, last_name, job_id, job_title
    FROM employees NATURAL JOIN jobs
    WHERE department_id > 80;
    ```

- Unión Cruzada
    - Combina cada fila de la primera tabla con cada fila de la segunda, generando todas las combinaciones posibles de ambas tablas
    - Si ejecuta **CROSS JOIN** en una tabla con 20 filas con una tabla con 100 filas, la consulta devolverá 2000 filas
    ```sql
    SELECT last_name, department_name
    FROM employees CROSS JOIN departments;
    ```

### **6-2 Cláusulas Join**
    
- Si las tablas tienen columnas con los mismos nombres, pero diferentes tipos de dato, la unión provoca un error, para evitarlo, la cláusula de unión se puede modificar con **USING**, la cual especifica las columnas que se deben utilizar para la unión, además nos permite utilizar **WHERE** para limitar las filas de una o de ambas tablas
    ```sql
    SELECT first_name, last_name, department_id, department_name
    FROM employees JOIN departments USING (department_id);
    ```

- Si las columnas que se van a unir tienen nombre diferentes utilizaremos la cláusula **ON** y tambien nos permite utilizar **WHERE** para limitar las filas de una o de ambas tablas
    ```sql
    SELECT last_name, job_title
    FROM employees e JOIN jobs j
    ON (e.job_id = j.job_id);
    ```
    - **ON** también nos permite unir una tabla que no tenga ninguna columna correspondiente con otra tabla
        ```sql
        SELECT last_name, salary, grade_level, lowest_sal, highest_sal
        FROM employees JOIN job_grades
        ON (salary BETWEEN lowest_sal AND highest_sal);
        -- La tabla job_grades no tiene una columna común con la tabla employees
        ```

### **6-3 Uniones Internas frente a Externas**

- Uniones Internas y Externas
    - Una unión de dos o más tablas que devuelven solo las filas coincidentes se denomina unión interna
    - Cuando una unión devuelve las filas no coincidentes, así como las filas coincidentes, se denominana unión externa
    - En la sintaxis de las uniones externas se utilizan los términos "izquierda, completa y derecha"

- Uniones Externas Izquierdas y Derechas
    ```sql
    SELECT e.last_name, d.department_id, d.department_name
    FROM employees e LEFT OUTER JOIN departments d
    ON (e.department_id = d.department_id);
    -- Esta consulta devolverá los apellidos de todos los empleados, tanto aquellos que asignados a un departamento como los que no (null)
    ```
    | LAST_NAME | DEPT_ID | DEPT_NAME      |
    | --------- | ------- | -------------- |
    | Whalen    | 10      | Administration |
    | Fay       | 20      | Marketing      |
    | ...       | ...     | ...            |
    | Zlotkey   | 80      | Sales          |
    | De Haan   | 90      | Executive      |
    | Kochhar   | 90      | Executive      |
    | King      | 90      | Executive      |
    | Gietz     | 110     | Accounting     |
    | Higgins   | 110     | Accounting     |
    | Grant     | -       | -              |
    ```sql
    SELECT e.last_name, d.department_id, d.department_name
    FROM employees e RIGHT OUTER JOIN departments d
    ON (e.department_id = d.department_id);
    -- Esta consulta devolverá todos los ID de departamento y los nombres de departamento, tanto aquellos que tengan empleados asignados como los que no (null)
    ```
    | LAST_NAME | DEPT_ID | DEPT_NAME      |
    | --------- | ------- | -------------- |
    | Whalen    | 10      | Administration |
    | Hartstein | 20      | Marketing      |
    | ...       | ...     | ...            |
    | King      | 90      | Executive      |
    | Kochhar   | 90      | Executive      |
    | De Haan   | 90      | Executive      |
    | Higgins   | 110     | Accounting     |
    | Gietz     | 110     | Accounting     |
    | -         | 190     | Contracting    |

- Unión Externa Completa
    - Se puede crear una condición de unión para recuperar todas las filas coincidentes y todas las filas no coincidentes de ambas tablas
        ```sql
        SELECT e.last_name, d.department_id, d.department_name
        FROM employees e FULL OUTER JOIN departments d
        ON (e.department_id = d.department_id);
        ```
        | LAST_NAME | DEPARTMENT_ID | DEPARTMENT_NAME |
        |-----------|--------------|-----------------|
        | King      | 90           | Executive       |
        | Kochhar   | 90           | Executive       |
        | ...       | ...          | ...             |
        | Taylor    | 80           | Sales           |
        | Grant     | -            | -               |
        | Mourgos   | 50           | Shipping        |
        | ...       | ...          | ...             |
        | Fay       | 20           | Marketing       |
        | -         | 190          | Contracting     |

### **6-4 Autouniones y Consultas Jerárquicas**

- Autounión
    - Para unir una tabla a sí misma, a la tabla se le asignan dos nombre o alias, esto hará que la BBDD "crea" que hay dos tablas
        | employee_id | last_name | manager_id |WORKER ! MANAGER| employee_id | last_name | 
        |-------------|-----------|------------|----------------|-------------|-----------|
        | 100         | King      |            |                | 100         | King      |
        | 101         | Kochar    | 100        |                | 101         | Kochar    |
        | 102         | De Haan   | 100        |                | 102         | De Haan   |
        | 103         | Hunold    | 102        |                | 103         | Hunold    |
        | 104         | Ernst     | 103        |                | 104         | Ernst     |
        | 107         | Lorentz   | 103        |                | 107         | Lorentz   |
        | 124         | Mourgos   | 100        |                | 124         | Mourgos   |

        ```sql
        SELECT worker.last_name, worker.manager_id, manager.last_name AS "Manager name"
        FROM employees worker JOIN employees manager
        ON (worker.manager_id = manager.employee_id);
        ```
        | LAST_NAME  | MANAGER_ID | Manager name |
        |------------|------------|--------------|
        | Kochhar    | 100        | King         |
        | De Haan    | 100        | King         |
        | Zlotkey    | 100        | King         |
        | Mourgos    | 100        | King         |
        | Hartstein  | 100        | King         |
        | Whalen     | 101        | Kochhar      |
        | Higgins    | 101        | Kochhar      |
        | Hunold     | 102        | De Haan      |
        | ...        | ...        | ...          |

- Consultas Jerárquicas
    - Con las consultas jerárquicas, puede recuperar datos según una relación jerárquica natural entre las filas de una tabla
    - Cuando existe una relación jerárquica entre las filas de una única tabla, un proceso denominado recorrido por el árbol permite construir la jeraquía
    - Una consulta jerárquica es un **método de creación de informes**, con las ramas de un árbol en un determinado orden
    - Palabras clave:
        - **START WITH** identifica qué fila se va a utilizar como raíz del árbol que se está creando
        - **CONNECT BY PRIOR** explica cómo realizar las uniones entre filas
        - **LEVEL** especifica cuántas ramas de profundidad recorrerá el árbol y es una pseudocolumna que se utiliza con consultas jerárquicas y que cuenta el número de pasos que ha realizado desde la raíz del árbol
        ```sql
        SELECT LEVEL, last_name || ' reports to ' || PRIOR last_name AS "Walk Top Down"
        FROM employees
        START WITH last_name = 'King'
        CONNECT BY PRIOR employee_id = manager_id;
        ```
        | LEVEL | Walk Top Down              |
        | ----- | -------------------------- |
        | 1     | King reports to            |
        | 2     | Kochhar reports to King    |
        | 3     | Whalen reports to Kochhar  |
        | 3     | Higgins reports to Kochhar |
        | 4     | Gietz reports to Higgins   |
        | 2     | De Haan reports to King    |
        | 3     | Hunold reports to De Haan  |
        | 4     | Ernst reports to Hunold    |
    ```sql
    SELECT employee_id, last_name, job_id, manager_id
    FROM employees
    START WITH employee_id = 100
    CONNECT BY PRIOR employee_id = manager_id
    ```
    | EMPLOYEE_ID | LAST_NAME | JOB_ID     | MANAGER_ID |
    | ----------- | --------- | ---------- | ---------- |
    | 100         | King      | AD_PRES    | -          |
    | 101         | Kochhar   | AD_VP      | 100        |
    | 200         | Whalen    | AD_ASST    | 101        |
    | 205         | Higgins   | AC_MGR     | 101        |
    | 206         | Gietz     | AC_ACCOUNT | 205        |
    | 102         | De Haan   | AD_VP      | 100        |
    | 103         | Hunold    | IT_PROG    | 102        |
    | 104         | Ernst     | IT_PROG    | 103        |

    ```sql
    SELECT last_name || ' reports to ' || PRIOR last_name AS "Walk Top Down"
    FROM employees
    START WITH last_name = 'King'
    CONNECT BY PRIOR employee_id = manager_id;
    ```
    | Walk Top Down              |
    | -------------------------- |
    | King reports to            |
    | Kochhar reports to King    |
    | Whalen reports to Kochhar  |
    | Higgins reports to Kochhar |
    | Gietz reports to Higgins   |
    | De Haan reports to King    |
    | Hunold reports to De Haan  |
    | Ernst reports to Hunold    |

## 7 - JOIN Parte 2

### **7-1 Unión Igualitaria y Producto Cartesiano de Oracle**

- Comandos de Unión
    - Para consultar datos de más de una tabla utilice una condición de unión en la cláusula **WHERE**
        ```sql
        SELECT table1.column, table2.column
        FROM table1, table2
        WHERE table1.column1 = table2.column2;
        ```
    - A esto se le denomina **cualificar sus columnas**
    - La combinación del nombre de tabla y el nombre de columna ayuda a eliminar nombres ambiguos cuando dos tablas contienen una columna con el mismo nombre de columna

- Unión Igualitaria
    - Es una unión de tabla que combina filas con los mismos valores para las columnas especificas
        - **NATURAL JOIN**
        - **JOIN USING**
        - **JOIN ON**
        ```sql
        SELECT employees.last_name, departments.department_name
        FROM employees, departments
        WHERE employees.department_id = departments.department_id;
        ```

- Unión de Producto Cartesiano
    - Si en la cláusula **WHERE** de dos tablas de una consulta de unión no se ha especificado ninguna condición de unión o la condición de unión no es válida, Oracle Server devuelve el producto cartesiano de dos tablas
    - Esta es una **combinación de cada fila de una tabla con cada fila de otra**
        ```sql
        SELECT last_name, city
        FROM employees e, departments d, locations l
        WHERE e.department_id = d.department_id
            AND d.location_id = l.location_id;
        ```

### **7-2 Uniones No Igualitarias y Uniones Externas de Oracle**

- Unión No Igualitaria
    - Una unión no igualitaria es equivalente a **JOIN ON**
    - Ya que no hay ninguna coincidencia exacta entre las dos columnas de cada tabla, el operador de igualdad = no se puede utilizar
    - Por eso se pueden utilizar las condiciones de comparación **<=** y **>=**, **BETWEEN...AND**
        ```sql
        SELECT last_name, salary, grade_level, lowest_sal, highest_sal
        FROM employees, job_grades
        WHERE (salary BETWEEN lowest_sal AND highest_sal);
        ```

- **OUTER JOIN**
    - Una unión externa se utiliza para ver las filas que tengan un valor correspondiente en otra tabla, más aquellas filas de una de las tablas que no tengan ningún valor coincidente en la otra tabla
    - Para indicar qué tabla puede tener datos que faltan mediante la sintaxis de unión de Oracle, agregue un signo más (+) después del nombre de columna de la tabla en la cláusula **WHERE** de la consulta

    - **LEFT OUTER JOIN**
        ```sql
        SELECT e.last_name, d.department_id, d.department_name
        FROM employees e, departments d
        WHERE e.department_id = d.department_id(+);
        ```
    - **RIGHT OUTER JOIN**
        ```sql
        SELECT e.last_name, d.department_id, d.department_name
        FROM employees e, departments d
        WHERE e.department_id(+) = d.department_id;
        ```
    - **FULL OUTER JOIN**
        - No es posible tener el equivalente de **FULL OUTER JOIN** mediante la adición de un signo (+), esto producira un **error**

## 8 - Funciones de Grupo Parte 1

### **8-1 Funciones de Grupo**

- Funciones de Grupo
    - Las funciones de grupo no se pueden utilizar en la claúsula **WHERE** e ignoran los valores **NULL**
    - Las siguientes funciones de grupo se pueden utilizar en una tabla completa o en un grupo específico de filas:
        - **MIN** se utiliza con las columnas que almacenan cualquier tipo de dato para devolver el valor mínimo
            ```sql
            SELECT MIN(salary)
            FROM employees;
            -- 12000
            ```
        - **MAX** se utiliza con las columnas que almacenan cualquier tipo de dato para devolver el valor máximo
            ```sql
            SELECT MAX(salary)
            FROM employees;
            -- 24000
            ```
        - **SUM** se utiliza con las columnas que almacenan los datos numéricos para buscar el total o la suma de valores
            ```sql
            SELECT SUM(salary)
            FROM employees;
            -- 1700000
            ```
        - **AVG** se utiliza con las columnas que almacenan los datos numéricos para calcular la media
            ```sql
            SELECT AVG(salary)
            FROM employees;
            -- 15755
            ```
        - **COUNT** devuelve el número de filas
            ```sql
            SELECT COUNT(salary)
            FROM employees;
            -- 15
            ```
        - **VARIANCE** se utiliza con columnas que almacenan datos númericos para calcular la difusión de datos en torno a la media
            ```sql
            SELECT VARIANCE(nota) AS varianza_notas
            FROM notas_alumnos;
            -- Por ejemplo, si las notas son 6, 7, 7, 9 y 10, podría devolver: 2.3
            ```
        - **STDDEV** similar a la varianza, la desviaciñon estándar mide difusión de los datos
            ```sql
            SELECT STDDEV(nota) AS desviacion_tipica
            FROM notas_alumnos;
            -- Por ejemplo, si las notas son 6, 7, 7, 9 y 10, podría devolver: 1.516
            ```

### **8-2 COUNT, DISTINCT, NVL**

- **COUNT**
    - Devuelve el número de valores no ulos de la columna de expresión 
    - Ignora los valores nulos en la columna
    - Con **COUNT(*)** devuelve el número de filas de una tabla

- **DISTINCT**
    - Se utiliza para devolver solo valores no duplicados o combinaciones de valores no duplicados en una consulta de todas las columnas seleccionadas
        ```sql
        SELECT DISTINCT job_id
        FROM employees;
        ```

- **NVL** 
    - Con esto incluiremos valores nulos en funciones de rupo
        ```sql
        SELECT AVG(NVL(commission_pct, 0))
        FROM employees
        -- .0425
        ```

## 9 - Funciones de Grupo Parte 2

### **9-1 Uso de las Cláusulas GROUP BY y HAVING**

- **GROUP BY**
    - Sirve para dividir las filas de una tabla en grupos más pequeños y normalmente debemos incluir la columna **GROUP BY** en la lista **SELECT**
        ```sql
        SELECT department_id, AVG(salary)
        FROM employees
        GROUP BY department_id
        -- Las filas se están agrupando por department_id
        ```

- **COUNT** 
    - Se recomienda utilizar (*)
        ```sql
        SELECT COUNT(*), region_id
        FROM wf_countries
        GROUP BY region_id
        ORDER BY region_id;
        -- Esto contaría todas las filas de cada grupo de regiones, sin tener que comprobar las columnas NULL
        ```
        ```sql
        SELECT department_id, job_id, count(*)
        FROM employees
        WHERE department_id > 40
        GROUP BY department_id, job_id;
        -- En este ejemplo se muestra el número de empleados que están realizando cada trabajo dentro de cada departamento
        ```
        | DEPT_ID | JOB_ID     | COUNT(*) |
        | ------- | ---------- | -------- |
        | 110     | AC_ACCOUNT | 1        |
        | 50      | ST_CLERK   | 4        |
        | 80      | SA_REP     | 2        |
        | 90      | AD_VP      | 2        |
        | 50      | ST_MAN     | 1        |

- **HAVING**
    - **WHERE** se utiliza para restringir las filas que seleccionó, pero **HAVING** se utiliza para restringir los grupos
        ```sql
        SELECT department_id, MAX(salary)
        FROM employees
        GROUP BY department_id
        HAVING COUNT(*) > 1
        ORDER BY department_id;
        ```
        | DEPARTMENT_ID | MAX(SALARY) |
        | ------------- | ----------- |
        | 20            | 13000       |
        | 50            | 5800        |
        | 60            | 9000        |
        | 80            | 11000       |
        | 90            | 24000       |
        | 110           | 12000       |

### **9-2 Uso de las Operaciones Rollup y Cube, y Grouping Sets**

- **ROLLUP**
    - En las consultas con **GROUP BY**, a menudo se deben producir subtotales y totales, y la operación **ROLLUP**, puede realizar esta acción por usted
    - **ROLLUP** crea subtotales que se acumulan desde el nivel más detallado hasta la suma total, siguiendo la lista de agrupamiento especificada en la cláusula **GROUP BY**
    - Utiliza una lista ordenada de las columnas del argumentos
        ```sql
        SELECT department_id, job_id, SUM(salary)
        FROM employees
        WHERE department_id < 50
        GROUP BY ROLLUP (department_id, job_id);
        -- En la tabla de resultados siguiente, las filas con job_id null las genera la operación ROLLUP
        ```
        | DEPARTMENT_ID | JOB_ID  | SUM(SALARY) |
        | ------------- | ------- | ----------- |
        | 10            | AD_ASST | 4400        |
        | 10            | -       | 4400        |
        | 20            | MK_MAN  | 13000       |
        | 20            | MK_REP  | 6000        |
        | 20            | -       | 19000       |
        | -             | -       | 23400       |

- **CUBE**
    - Genera informes de tabulación cruzada
    - Todas las combinaciones posibles de filas se agregan con **CUBE**
    - Se utiliza a menudo en las consultas que utilizan columnas de tablas independientes, en lugar de distintas columnas de una sola tabla
        ```sql
        SELECT department_id, job_id, SUM(salary)
        FROM employees
        WHERE department_id < 50
        GROUP BY CUBE (department_id, job_id);
        -- Las filas con datos null las genera la operación CUBE
        ```
        | DEPARTMENT_ID | JOB_ID  | SUM(SALARY) |
        | ------------- | ------- | ----------- |
        | -             | -       | 23400       |
        | -             | MK_MAN  | 13000       |
        | -             | MK_REP  | 6000        |
        | -             | AD_ASST | 4400        |
        | 10            | -       | 4400        |
        | 10            | AD_ASST | 4400        |
        | 20            | -       | 19000       |
        | 20            | MK_MAN  | 13000       |
        | 20            | MK_REP  | 6000        |

- **GROUPING SETS**
    - Se utiliza para especificar varias agrupaciones de datos
    - Esto le proporciona la funcionalidad de tener varias cláusulas **GROUP BY** en la misma sentencia **SELECT**, lo cual no está permitido en la sintaxis normal
        ```sql
        SELECT department_id, job_id, manager_id, SUM(salary)
        FROM employees
        WHERE department_id < 50
        GROUP BY GROUPING SETS (
            (job_id, manager_id),
            (department_id, job_id),
            (department_id, manager_id)
        );
        -- Las filas 4, 5 y 6 las genera la operación GROUPING SETS
        ```
        | DEPARTMENT_ID | JOB_ID  | MANAGER_ID | SUM(SALARY) |
        | ------------- | ------- | ---------- | ----------- |
        | -             | MK_MAN  | 100        | 13000       |
        | -             | MK_MAN  | 201        | 6000        |
        | -             | AD_ASST | 101        | 4400        |
        | 10            | AD_ASST | -          | 4400        |
        | 20            | MK_MAN  | -          | 13000       |
        | 20            | MK_REP  | -          | 6000        |
        | -             | -       | 101        | 4400        |
        | -             | -       | 201        | 6000        |
        | 10            | -       | 101        | 4400        |
        | 20            | -       | -          | 19000       |
        | 20            | -       | 100        | 13000       |
        | 20            | -       | 201        | 6000        |

- Funciones GROUPING
    - La función **GROUPING** en SQL se utiliza junto con los operadores **ROLLUP**, **CUBE** o **GROUPING SETS** para distinguir entre los valores **NULL** generados automáticamente al crear subtotales o totales, y los valores **NULL** normales de los datos originales
        ```sql
        SELECT department_id, job_id, SUM(salary),
            GROUPING(department_id) AS "Dept sub total",
            GROUPING(job_id) AS "Job sub total"
        FROM employees
        WHERE department_id < 50
        GROUP BY CUBE(department_id, job_id);
        ```
        | DEPARTMENT_ID | JOB_ID  | SUM(SALARY) | Dept sub total | Job sub total |
        | ------------- | ------- | ----------- | -------------- | ------------- |
        | -             | -       | 23400       | 1              | 1             |
        | -             | MK_MAN  | 13000       | 1              | 0             |
        | -             | MK_REP  | 6000        | 1              | 0             |
        | -             | AD_ASST | 4400        | 1              | 0             |
        | 10            | -       | 4400        | 0              | 1             |
        | 10            | AD_ASST | 4400        | 0              | 0             |
        | 20            | -       | 19000       | 0              | 1             |
        | 20            | MK_MAN  | 13000       | 0              | 0             |
        | 20            | MK_REP  | 6000        | 0              | 0             |

### **9-3 Uso de los Operadores SET**

- Operadores Set
    - Para explicar los operadores **SET**, se hará referencia a las dos listas siguientes a lo largo de esta lección
        1. A = {1, 2, 3, 4, 5}
        2. B = {4, 5, 6, 7, 8}
    - El número de columnas y los tipos de datos de las columnas debe ser idéntico en todas las sentencias **SELECT** utilizadas en la consulta
    - No es necesario que los nombres de las columnas sean idénticos
    - Los nombres de columna de la salida se toman de los nombres de columnas de la primera sentencia **SELECT**
    - **UNION**
        ```sql
        SELECT a_id
        FROM a
        UNION
        SELECT b_id
        FROM b;
        -- Elimina los duplicado y devuelve: {4, 5}
        ```
    - **UNION ALL**
        ```sql
        SELECT a_id
        FROM a
        UNION ALL
        SELECT b_id
        FROM b;
        -- Devuelve tambien los duplicados: {1, 2, 3, 4, 5, 4, 5, 6, 7, 8}
        ```
    - **INTERSECT**
        ```sql
        SELECT a_id
        FROM a
        INTERSECT
        SELECT b_id
        FROM b;
        -- Devuelve todas las filas comunes a ambas tablas: {4, 5}
        ```
    - **MINUS**
        ```sql
        SELECT a_id
        FROM a
        MINUS
        SELECT b_id
        FROM b;
        -- Devuelve todas las filas en una tabla, pero no ne la otra: {1, 2, 3}
        ```
    - La forma más sencilla de seleccionar filas de las tablas que no tengan columnas en común es incluir uno o más valores **NULL** en la lista de selección
        ```sql
        SELECT hire_date, employee_id, job_id
        FROM employees
        UNION
        SELECT TO_DATE(NULL), employee_id, job_id
        FROM job_history;
        -- Esta consulta une los datos de empleados actuales con el historial de empleos, utilizando TO_DATE(NULL) para mantener la estructura de columnas igual en ambos SELECT
        ```
        - La palabra clave **NULL** se puede utilizar para que coincida con las columnas de una lista **SELECT**
        - Se incluye un valor **NULL** para cada columna que falte
    - **ORDER BY** en Operaciones SET
        - La cláusula ORDER BY solo se permite al final de toda la expresión combinada y ordena el resultado total, no cada subconsulta por separado
            ```sql
            SELECT hire_date, employee_id, job_id
            FROM employees
            UNION
            SELECT TO_DATE(NULL), employee_id, job_id
            FROM job_history
            ORDER BY employee_id;
            -- En esta consulta, el ORDER BY organiza el resultado final (ya unido por UNION) utilizando la columna employee_id
            ```

## 10 - Subconsultas

### **10-1 Conceptos Fundamentales de las Subconsultas**

- Subconsultas
    - Una subconsulta en SQL es una consulta SELECT anidada dentro de otra consulta principal
    - La subconsulta se ejecuta para buscar la información que no conoce
    - La consulta externa utiliza esa información para averiguar lo que debe saber
        ```sql
        SELECT select_list
        FROM table
        WHERE expression operator
        (SELECT select_list
        FROM table);
        ```
    - Tipos de Subconsultas
        1. Subconsultas de una sola fila que utilizan operadores de una sola fila (>, =, >=, <, <>, <=) y solo devuelven una fila de la consulta interna
        2. Subconsultas de varias filas que utilizan operadores de varias filas (EN, ANY, ALL) y devuelven más de una fila de la consulta interna

### **10-2 Subconsultas de Una Sola Fila**

- Hechos
    - Estas subconsultas:
        - Devuelven una sola fila
        - Utilizan operadores de comparación de una sola fila (>, =, >=, <, <>, <=)
    - Siempre:
        - Incluya la subconsulta entre paréntesis
        - Coloque la subconsulta a la derecha de la condición de comparación

- Subconsultas de Diferentes Tablas
    - Las consultas externas e internas pueden obtener datos de diferentes tablas
    ```sql
    SELECT last_name, job_id, department_id
    FROM employees
    WHERE department_id = 
        (SELECT department_id
        FROM departments
        WHERE department_name = 'Marketing')
    ORDER BY job_id;
    ```

- Funciones de Grupo en Subconsultas
    - Una función de grupo sin ninguna cláusula **GROUP BY** en la subconsulta devuelve una única fila
    ```sql
    SELECT last_name, salary
    FROM employees
    WHERE salary <
        (SELECT AVG(salary)
        FROM employees);
    ```

- Subconsultas en la Cláusulas **HAVING**
    - **HAVING** es similar a la cláusula **WHERE**, excepto por el hecho de que la cláusula **HAVING** se utiliza para restringir grupos y siempre incluye una función de grupo como, **MIN**, **MAX** o **AVG**
    ```sql
    SELECT department_id, MIN(salary)
    FROM employees
    GROUP BY department_id
    HAVING MIN(salary) >
        (SELECT MIN(salary)
        FROM employees
        WHERE department_id = 50);
    ```

### **10-3 Subconsultas de Varias Filas**

- Operadores de Varias Filas
    - **IN** se utiliza en la cláusula **WHERE** de la consulta externa para seleccionar solo las filas que están en la lista de valores devueltos de la consulta interna
        ```sql
        SELECT last_name, hire_date
        FROM employees
        WHERE EXTRACT(YEAR FROM hire_date) IN
            (SELECT EXTRACT(YEAR FROM hire_date)
            FROM employees
            WHERE department_id = 90);
        -- Esta consulta selecciona los empleados que fueron contratados en los mismos años en que algún empleado del departamento 90 fue contratado
        ```
    - **ANY** se utiliza cuando deseamos que la cláusula **WHERE** de la consulta externa selecciones las filas que coinciden con los criterios (<, >, =, etc) de al menos un valor en el juego de resultados de la subconsulta
        ```sql
        SELECT last_name, hire_date
        FROM employees
        WHERE EXTRACT(YEAR FROM hire_date) < ANY
            (SELECT EXTRACT(YEAR FROM hire_date)
            FROM employees
            WHERE department_id = 90);
        -- Esta consulta selecciona los empleados cuyo año de contratación es menor que cualquier año de contratación de los empleados del departamento 90
        ```
    - **ALL** se utiliza cuando deseamos que la cláusula **WHERE** de la consulta externa seleccione las filas que coinciden con los criterios (<, >, =, etc) de todos los valores en el juego de resultados de la subconsulta, comparando un valor con todos los valores devueltos por la consulta interna
        ```sql
        SELECT last_name, hire_date 
        FROM employees
        WHERE EXTRACT(YEAR FROM hire_date) < ALL
            (SELECT EXTRACT(YEAR FROM hire_date)
            FROM employees
            WHERE department_id=90);
        -- Esta consulta selecciona los empleados cuyo año de contratación es menor que todos los años de contratación de los empleados del departamento 90
        ```
    - Valores **NULL**: si se utiliza **IN** o **ANY**, la consulta externa devolverá filas que coinciden con los valores no nulos

- Las subconsultas pueden utilizar una o más columnas
- Si utilizan más de una columna, se denominan subconsultas de **varias columnas**
- Una subconsulta de varias columnas pueden ser comparaciones pareadas o no pareadas
    ```sql
    SELECT employee_id, manager_id, department_id
    FROM employees
    WHERE (manager_id, department_id) IN
        (SELECT manager_id, department_id
        FROM employees
        WHERE employee_id IN (149, 174))
        AND employee_id NOT IN (149, 174);
    -- Esta consulta selecciona los empleados (distintos de 149 y 174) cuyos valores de manager_id y department_id coinciden con los de los empleados cuyo employee_id es 149 o 174
    ```

### **10-4 Subconsultas Correlacionadas**

- Subconsultas Correlacionadas
    - El servidor de Oracle realiza una subconsulta correlacionada cuando la subconsulta hace referencia a una columna de una tabla a la que se hace referencia en la sentencia principal
    - Una subconsulta correlacionada se evalúa una vez para cada fila procesada por la sentencia principal
    - La sentencia principal puede ser una sentencia **SELECT**, **UPDATE** o **DELETE**
    ```sql
    SELECT o.first_name, o.last_name, o.salary
    FROM employees o
    WHERE o.salary >
        (SELECT AVG(i.salary)
        FROM employees i
        WHERE i.department_id = o.department_id);
    ```
    - Cada subconsulta se ejecuta una vez para cada fila de la consulta externa
    - Con una subconsulta normal, la consulta **SELECT** interna se ejecuta en primer lugar y una vez, devolviendo valores que utilizará la consulta externa
    - Una subconsulta correlacionada, sin embargo, se ejecuta una vez para cada fila considerada por la consulta externa

- EXISTS Y NOT EXISTS en Subconsultas
    - Son dos cláusulas que se pueden utilizar al comprobar las coincidencias de subconsultas
    - **EXISTS** comprueba un resultado **TRUE** o coincidente en la subconsulta
    ```sql
    SELECT last_name AS "Not a Manager"
    FROM employees emp
    WHERE NOT EXISTS
    (SELECT *
    FROM employees mgr
    WHERE mgr.manager_id = emp.employee_id);
    ```
    - La consulta con **NOT IN** suguiere que no hay ningún empleado que también sea jefe
        ```sql
        SELECT last_name AS "Not a Manager"
        FROM employees emp
        WHERE emp.employee_id NOT IN
            (SELECT mgr.manager_id
            FROM employees mgr);
        ```

- **WITH**
    - Te permite definir conjuntos de resultados temporales con nombre que pueden ser utilizados dentro de una consulta más grande
    - Recupera los resultados de uno o más bloques de consultas y almacena esos resultados para el usuario que ejecuta la consulta
    - Mejora el rendimiento y hace que la consulta se pueda leer fácilmente
    ```sql
    WITH managers AS (
        SELECT DISTINCT manager_id
        FROM employees
        WHERE manager_id IS NOT NULL
    )
    SELECT last_name AS "Not a manager"
    FROM employees
    WHERE employee_id NOT IN
        (SELECT * FROM managers);
    -- Esta consulta utiliza una CTE llamada managers para listar todos los IDs de manager y luego selecciona los empleados que no gestionan a nadie
    ```

## 11 - Garantia de Consultas de Calidad Parte 1

### **11-1 Garantia de Resultados de Consultas de Calidad**

## 12 - DML

### **12-1 Sentencias INSERT**

- **Crear una Copia de una Tabla**
```sql
CREATE TABLE copy_employee
    AS (SELECT * FROM employees);

DESCRIBE copy_employees;

SELECT * copy_employees;
```

- **INSERT**
    - Se utiliza **INSERT** para agregar filas a una tabla
        ```sql
        INSERT INTO copy_departments (department_id, department_name, manager_id, location_id)
        VALUES (200, 'Human Resources', 205, 1500);

        INSERT INTO copy_departments -- Es mejor utilizar los nombre de columna en una clausula INSERT
        VALUES (210, 'Estate Management', 102, 1700); 
        ```
    - Un intento implicito de agregar valores y no insertar un valor a una columna **NOT NULL** generara un error
    - **SYSDATE** colocara la fecha y hora actuales en una columna
    - **USER** insertara el nombre de usuario de la sesion actual
    - **TO_DATE** se utiliza para convertir el valor de fecha (cadena de caracteres) en una fecha y tambien permite la insercion de una hora del dia concreta

- **Subconsultas**
    - Todos los resultados de la subconsulta se insertan en la tabla
        ```sql
        INSERT INTO sales_reps(id, name, salary, commission_pct)
        SELECT employee_id, last_name, salary, commission_pct
        FROM employees
        WHERE job_id LIKE '%REP%'; -- selecciona aquellos empleados que tengan identificadores de trabajo como %REP%
        ```

### **12-2 Actualizacion de Valores de Columnas y Supresion de Filas**

- **UPDATE**
    - Se utiliza para modificar filas existentes de una tabla
        ```sql
        UPDATE copy_employees
        SET phone_number = '123456' last_name = 'Jones'
        WHERE employee_id = 303;
        ```

- **Subconsultas**
    - Podemos utilizar el resultado de una subconsulta de una sola fila para proporcionar el valor nuevo para una columna actualizada
        ```sql
        UPDATE copy_employees
        SET salary = (SELECT salary
                      FROM copy_employees
                      WHERE employee_id = 100)
        WHERE employee_id = 101;
        ```
    - Tambien es posible escribir varias subconsultas de una sola fila para actualizar varias columnas en una sentencia **UPDATE**
        ```sql
        UPDATE copy_employees
        SET salary = (SELECT salary
                    FROM copy_employees
                    WHERE employee_id = 205),
            job_id = (SELECT job_id
                    FROM copy_employees
                    WHERE employee_id = 205)
        WHERE employee_id = 206;
        ```

- Copias de columnas de una tabla a otra tabla distinta
    ```sql
    ALTER TABLE copy_employees
    ADD (department_name varchar2(30) NOT NULL);

    UPDATE copy_employees e
    SET e.department_name = (
        SELECT d.department_name
        FROM departments d
        WHERE e.department_id = d.department_id
    );
    ```

- **DELETE**
    - Se utiliza para eliminar filas existentes de una tabla
        ```sql
        DELETE FROM copy_employees
        WHERE employee_id = 303;
        ```
    - Las subconsultas tambien se pueden utilizar en sentencias **DELETE**
        ```sql
        DELETE FROM copy_employees
        WHERE department_id = (
            SELECT department_id
            FROM departments
            WHERE department_name = 'Shipping'
        );
        ``` 

- **FOR UPDATE**
    - Se utiliza en una consulta SQL para bloquear temporalmente las filas seleccionadas
        ```sql
        SELECT e.employee_id, e.salary, d.department_name
        FROM employees e JOIN departments d USING (department_id)
        WHERE job_id = 'ST_CLERK' AND location_id = 1500
            FOR UPDATE
        ORDER BY e.employee_id;
        ```

### **12-3 Valores DEFAULT, MERGE e Inserciones en Varias Tablas**

- **DEFAULT**
    - El uso de valores por defecto permite controlar donde y cuando se debe aplicar el valor por defecto, en el caso de que se inserte una fila nueva y no haya ningun valor asignado para la columna, se asignara el valor por defecto en lugar de un valor nulo
        ```sql
        CREATE TABLE my_employees (
            hire_date   DATE DEFAULT SYSDATE,
            first_name  VARCHAR2(15),
            last_name   VARCHAR2(15));
        ```
    - Se pueden utilizar valores por defecto explicitos en las sentencias **INSERT** y **UPDATE**
        ```sql
        INSERT INTO my_employees
            (hire_date, first_name, last_name)
        VALUES
            (DEFAULT, 'Angelina', 'Wright');

        INSERT INTO my_employees
            (first_name, last_name)
        VALUES
            ('Angelina', 'Wright');
        ```

- **MERGE**
    - Permite insertar, actualizar o borrar registros en una tabla destino comparando sus datos con otra tabla fuente en una sola operación
        ```sql
        MERGE INTO copy_emp c USING employees e
        ON (c.employee_id = e.employee_id)
        WHEN MATCHED THEN UPDATE
            SET c.last_name = e.last_name,
                c.department_id = e.department_id
        WHEN NOT MATCHED THEN INSERT
            VALUES (e.employee_id, e.last_name, e.department_id);
        ``` 

- Inserciones en Varias Tablas
    - Se utilizan cuando se deben insertar los mismo datos de origen en mas de una tabla de destino
    - Si especifica **ALL**, la base de datos evalua cada clausula **WHEN** independientemente de los resultados de la evaluacion de cualquier otra clausula **WHEN**
        ```sql
        INSERT ALL
            INTO my_employees VALUES (hire_date, first_name, last_name)
            INTO copy_my_employees VALUES (hire_date, first_name, last_name)
        SELECT hire_date, first_name, last_name
        FROM employees;
        ```

    - Si especifica **FIRST**, las base de datos evalua cada clausula **WHEN** en el orden en el que aparece en la sentencia
    - **ELSE**, para una fila determinada, si la clausula **WHEN** no se evalua como true, la base de datos ejecuta la lista de clausulas **INTO** asocuada con la clausula **ELSE**
    ```sql
    INSERT ALL
        WHEN call_format IN ('tlk', 'txt', 'pic') THEN
            INTO all_calls
            VALUES (caller_id, call_timestamp, call_duration, call_format)
        WHEN call_format IN ('tlk', 'txt') THEN
            INTO police_record_calls
            VALUES (caller_id, call_timestamp, recipient_caller)
        WHEN call_duration < 50 AND call_type = 'tlk' THEN
            INTO short_calls
            VALUES (caller_id, call_timestamp, call_duration)
        WHEN call_duration >= 50 AND call_type = 'tlk' THEN
            INTO long_calls
            VALUES (caller_id, call_timestamp, call_duration)
    SELECT caller_id, call_timestamp, call_duration, call_format, recipient_caller
    FROM calls
    WHERE TRUNC(call_timestamp) = TRUNC(SYSDATE);
    ``` 

## 13 - DDL

### **13-1 Creacion de Tablas**

- Objetos de Esquema de la BBDD
    - Una BBDD Oracle puede contener muchos tipos distintos de objetos
        - Tabla
        - Indice de
        - La restriccion
        - Ver
        - Secuencia
        - Sinonimo
    - Algunos de los tipos de objetos ocupan espacio, lo que se denomina almacenamiento, en la base de datos y otros no. Los que ocupan mucho espacio se denominan **segmentos**
        ```sql
        DESCRIBE jobs;
        ```

- **DDL**
    - La creacion de tablas forma parte del lenguaje de definicion de datos de SQL, las sentencias que se utilizan para configurar cambiar y eliminar estructuras de datos de tablas son:
        - **CREATE TABLE**, para crear una nueva tablas
            ```sql
            CREATE TABLE my_cd_collection (
                cd_number NUMBER(3),
                title VARCHAR2(20),
                artist VARCHAR2(20),
                purchase_date DATE DEFAULT SYSDATE
                );
            ```  

- Tablas Externas
    - En una **tabla externa**, las filas de datos no estan en los archivos de la BBDD, sino que en su lugar se enccuentran en un archivo plano, almacenado de forma externa a la base de datos
    - Se utiliza para almacenar datos migrados de version anteriores de las BBDD utilizadas por una compañia, por ejemplo cuando se pasa a una nueva aplicacion y BBDD
        - **ORGANIZATION EXTERNAL** indica a Oracle que cree una tabla externa
        - **TYPE ORACLE_LOADER** de tipo Oracle Loader
        - **DEFAULT DIRECTORY def_dir1** nombre del directorio para el archivo
        - **ACCESS PARAMETERS** como leer el archivo
        - **RECORDS DELIMITED BY NEWLINE** como identificar el principio de una nueva tabla
        - **FIELDS** especificaciones de nombre de campo y tipo de dato
        - **LOCATION** nombre der archivo real que contiene los datos
    ```sql
    CREATE TABLE emp_load (
        employee_number CHAR(5),
        employee_dob CHAR(20),
        employee_last_name CHAR(20),
        employee_first_name CHAR(15),
        employee_middle_name CHAR(15),
        employee_hire_date DATE)
    ORGANIZATION EXTERNAL (
        TYPE ORACLE_LOADER
        DEFAULT DIRECTORY def_dir1
        ACCESS PARAMETERS (
            RECORDS DELIMITED BY NEWLINE
            FIELDS (
            employee_number CHAR(2),
            employee_dob CHAR(20),
            employee_last_name CHAR(18),
            employee_first_name CHAR(11),
            employee_middle_name CHAR(11),
            employee_hire_date CHAR(10) date_format DATE mask "mm/dd/yyyy")
    )
    LOCATION ('info.dat'));
    ```

- Data Dictionary
    - Existen dos tipos de tablas en una BBDD Oracle:
        - Las tablas de usuario creadas por el usuario que contiene sus datos (empleados, departamentos, etc)
        - Tablas de diccionario de datos, son propiedad de un usuario de Oracle llamado **SYS** (DICTIONARY, USER_OBJECTS, etc)

### **13-2 Uso de Tipos de Dato**

- Tipos de Dato Comunes
    - **CHAR** tamaño fijo, maximo 2000 caracteres
    - **VARCHAR2** tamaño variable, maximo 32767 caracteres
    - **CLOB** tamaño variable, maximo 128 terabytes
    - **NUMBER** tamaño variable, precision maxima de 38 digitos
    - **DATE**
    - **TIMESTAMP** 
        - Permite fracciones de segundos
        - Zonas Horarias
            ```sql
            CREATE TABLE time_ex2 (
                time_with_offset TIMESTAMP WITH TIME ZONE
            );

            INSERT INTO time_ex2
            VALUES (SYSTIMESTAMP);

            INSERT INTO time_ex2
            VALUES ('10-Jun-2017 10:52:29.123456 AM +2:00');

            SELECT *        -- 16-JUL-15 08.49.47.126056 AM -07:00 
            FROM time_ex2;  -- 10-JUN-15 10.52.29.123456 AM +02:00
            ```  
    - **INTERVAL**
        - **INTERVAL YEAR TO MONTH** almacena un periodo de tiempo medido en años y meses
            ```sql
            INTERVAL YEAR [(year_precision)] TO MONTH
            ``` 
        - **INTERVAL DAY TO SECOND** almacena un periodo de tiempo medido en dias, horas, minuto y segundos
            ```sql
            INTERVAL DAY [day_precision] TO SECOND [(fractional_seconds_precision)]
            ```
    - **RAW** tamaño variable, maximo de 2000 bytes
    - **BLOB** tamaño variable, maximo de 128 terabytes

### **13-3 Modificacion de una Tabla**

- **ALTER TABLE** se utiliza para:
    - Agregar una nueva columna
        ```sql
        ALTER TABLE my_cd_collection
        ADD (release_date DATE DEFAULT SYSDATE);

        ALTER TABLE my_friends
        ADD (favorite_game VARCHAR2(30));
        ``` 
    - Modificar una columna existente
        ```sql
        ALTER TABLE mod_emp
            MODIFY (last_name VARCHAR2(30));

        ALTER TABLE mod_emp
            MODIFY (last_name VARCHAR2(10));

        ALTER TABLE mod_emp
            MODIFY (salary NUMBER(10,2));

        ALTER TABLE mod_emp
            MODIFY (salary NUMBER(8,2) DEFAULT 50);
        ``` 
    - Definir un valor **DEFAULT** para una columna
    - Borrar una columna
        ```sql
        ALTER TABLE my_cd_collection
        DROP COLUMN release_date;

        ALTER TABLE my_friends
        DROP COLUMN favorite_game;
        ```

- **SET UNUSED** se utiliza para borrar una columna de una tabla grande para ahorra tiempo, marcandola como no utilizable
    ```sql
    ALTER TABLE copy_employees
        SET UNUSED (email);
    ```

- **DROP UNUSED COLUMNS** elimina todas las columnas marcadas actualmente como no utilizadas
    ```sql
    ALTER TABLE copy_employees
        DROP UNUSED COLUMNS;
    ```

- **DROP TABLE** elimina la definicion de una tabla Oracle, perdiendo todos los datos de la tabla y los indices asociados a los mismos
    ```sql
    DROP TABLE copy_employees;
    ``` 

- **FLASHBACK TABLE** puede recuperar una tabla y sus datos borrados por error
    ```sql
    FLASHBACK TABLE copy_employees TO BEFORE DROP; 
    
    SELECT original_name, operation, droptime
    FROM user_recyclebin;
    ```

- **RENAME** es para cambiar el nobre de una tabla
    ```sql
    RENAME my_cd_collection TO my_music;    

- **TRUNCATE** se eliminar todas las filas de una tabla y se libera el espacio de almacenamiento utilizado por dicha tabla, es mas rapido que **DELETE** porque no genera informacion de rollback
    ```sql
    TRUCATE TABLE tablename;
    ```

- **COMMENT ON TABLE** puede agregar un comentario de hasta 2000 caracteres sobre una columna, tabla o vista mediante la sentencia **COMMENT**
    ```sql
    COMMENT ON TABLE employees
        IS 'Western Region only';
    
    SELECT table_name, comments
    FROM user_tab_comments;
    ```

- **FLASHBACK QUERY** permite ver los datos de fila en momentos concretos en el tiempo (tablas que se han modificado), por lo que puede comparar diferentes versiones de una fila a lo largo del tiempo
    ```sql
    SELECT employee_id, first_name || ' ' || last_name AS "NAME",
        versions_operation AS "OPERATION",
        versions_starttime AS "START_DATE",
        versions_endtime AS "END_DATE",
        salary
    FROM employees
        VERSIONS BETWEEN SCN MINVALUE AND MAXVALUE
    WHERE employee_id = 1;
    ```

## 14 - Restricciones

### **14-1 Introduccion a las Restricciones NOT NULL y UNIQUE**

- Restricciones
    - Evitan la supresion de una tabla si hay dependencias de otras tablas
    - Aplican reglas a los datos cuando se inserta, actualiza o suprime una fila de la tabla
    ```sql
    CREATE TABLE clients (
        client_number NUMBER(4) CONSTRAINT clients_client_num_pk PRIMARY KEY,
        first_name VARCHAR2(14) CONSTRAINT clients_last_name_nn NOT NULL,
        email VARCHAR2(80) CONSTRAINT clients_email_uk UNIQUE);
    ```
    - Existen 5 tipos de restricciones
        - **NOT NULL**
        - **UNIQUE**
        - **PRIMARY KEY**
        - **FOREIGN KEY**
        - **CHECK**

- **NOT NULL** necesita que para cada fila introducida en la tabla, debe existir un valor para dicha columna, es habitual utilizar el sufijo **_nn**

- **UNIQUE** necesita que todos los valores de una columna sean unicos, es decir, que dos filas de una tabla no pueden tener valores duplicados, se utiliza el sufijo **_uk**

### **14-2 Restricciones PRIMARY KEY, FOREIGN KEY y CHECK**

- **PRIMARY KEY** es una regla de que los valores de una columna o una combinacion de culumnas deben identificar de forma unica cada fila de una tabla, no pueden contener un valor nulo y solo debe de haber una clave primaria, sufijo **_pk**

- **FOREIGN KEY** designan una columna o una combinacion de columnas como una clave ajena, una clave ajena enlaza a la clave primaria de otra tabla, y este enlace es la base de la relacion entre tablas, sufijo **_fk**
    ```sql
    CREATE TABLE copy_employees (
        employee_id NUMBER(6,0) CONSTRAINT copy_emp_pk PRIMARY KEY,
        first_name VARCHAR2(20),
        last_name VARCHAR2(25),
        department_id NUMBER(4,0) CONSTRAINT c_emps_dept_id_fk
            REFERENCES departments(department_id),
        email VARCHAR2(25)
    );
    ```

- **ON DELETE CASCADE** permite la supresion de las filas dependientes en la tabla secundaria cuando se suprime una fila de la tabla principal, si la clave ajena no tiene una opcion **ON DELETE CASCADE**, las filas a las que se hace referencia de la tabla principal no se pueden suprimir

- **ON DELETE SET NULL** permite rellenar con valores nulos las filas secundarias 

- **CHECK** define explicitamente una condicion que se debe cumplir, y para cumplirla cada una de las filas de la tabla debe hacer que la condicion sea True o desconocida, sufijo **_ck**
    ```sql
    CREATE TABLE copy_job_history (
        employee_id NUMBER(6,0),
        start_date DATE,
        end_date DATE,
        job_id VARCHAR2(10),
        department_id NUMBER(4,0),
        CONSTRAINT cjhist_emp_id_st_date_pk
            PRIMARY KEY(employee_id, start_date),
        CONSTRAINT cjhist_end_ck CHECK (end_date > start_date)
    );
    ```

### **14-3 Gestion de Restricciones**

- Gestion de Restricciones
    - **ALTER TABLE** se utiliza para realizar cambios en las restricciones de tablas existentes
        ```sql
        ALTER TABLE employees
        ADD CONSTRAINT emp_id_pk PRIMARY KEY (employee_id);
        ```
    - Estos cambios pueden incluir agregar o borrar restricciones, activar o desactivar restricciones y agregar una restriccion **NOT NULL** a una columna
        ```sql
        ALTER TABLE employees -- Modificacion de restricciones
        MODIFY (email CONSTRAINT emp_email_nn NOT NULL);

        ALTER TABLE copy_departments -- Borrado de restricciones
        DROP CONSTRAINT c_dept_dept_id_pk CASCADE;

        ALTER TABLE copy_employees -- Desactivacion de restricciones
        DISABLE CONSTRAINT c_emp_dept_id_fk;

        ALTER TABLE copy_departments -- Desactiva las restricciones de integridad dependientes
        DISABLE CONSTRAINT c_dept_dept_id_pk CASCADE;

        ALTER TABLE copy_departments -- Activacion de restricciones
        ENABLE CONSTRAINT c_dept_dept_id_pk;
        ```

## 15 - Vistas

### **15-1 Creacion de Vistas**

- Una **Vista** es una representacion logica de tablas existentes o de otra vista y no contienen datos propios, se utilizan para reducir la complejidad de la ejecucion de las consultas basadas en sentencias **SELECT** complicadas
    ```sql
    CREATE VIEW view_employees
    AS SELECT employee_id, first_name, last_name, email
        FROM employees
        WHERE employee_id BETWEEN 100 and 124;
    ```

    |          Parámetro      | Descripción                                                                                           |
    |------------------------ |-------------------------------------------------------------------------------------------------------|
    | WITH CHECK OPTION       | Especifica que las filas siguen estando accesibles para la vista después de las operaciones de inserción o actualización. |
    | CONSTRAINT              | Es el nombre asignado a la restricción CHECK OPTION.                                                  |
    | WITH READ ONLY          | Garantiza que no se pueda realizar ninguna operación DML en esta vista.                               |
    | OR REPLACE              | Vuelve a crear la vista si ya existe.                                                                |
    | FORCE                   | Crea la vista independientemente de si existen o no las tablas base.                                  |
    | NOFORCE                 | Crea la vista solo si existe la tabla base (opción por defecto).                                      |
    | view_name               | Especifica el nombre de la vista.                                                                     |
    | alias                   | Especifica un nombre para cada expresión seleccionada por la consulta de la vista.                    |
    | subconsulta             | Es una sentencia SELECT completa. Puede utilizar alias para las columnas de la lista SELECT. La subconsulta puede contener la sintaxis compleja SELECT. |

    - Vista Simple (Uuna unica tabla)
        ```sql
        CREATE OR REPLACE VIEW view_euro_countries -- OR REPLACE sirve para modificar una vista
        AS SELECT country_id, region_id, country_name, capitol
            FROM wf_countries
            WHERE location LIKE '%Europe';
        ```
    - Vista Compleja (dos o mas tablas y pueden contener funciones de grupo)

### **15-2 Operaciones DML y Vistas**

- Sentencias **DML** y **Vistas**
    - Las operaciones **DML INSERT**, **UPDATE** Y **DELETE** se pueden realizar en vistas simples
    - Se pueden utilizar para cambiar los datos en las tablas base subyacentes
        ```sql
        CREATE VIEW view_dept50
        AS SELECT department_id,
                employee_id, first_name, last_name, salary
            FROM copy_employees
            WHERE department_id = 50;
        ```
    - Es posible insertar, actualizar y suprimir informacion de todas las filas de la vista
    - Para controlar el acceso a los datos, se pueden agregar dos opciones a la sentencia **CREATE VIEW**
        - **WITH CHECK OPTION** garantiza que las operaciones **DML** realizadas en la vista se mantengan en el dominio de la vista
            ```sql
            CREATE OR REPLACE VIEW view_dept50
            AS SELECT department_id, employee_id, first_name, last_name, salary
                FROM employees
                WHERE department_id = 50
            WITH CHECK OPTION CONSTRAINT view_dept50_check;
            ```
        - **WITH READ ONLY** garantiza que no se produzca ninguna operacion **DML** en la vista (INSERT, UPDATE o DELETE)
            ```sql
            CREATE OR REPLACE VIEW view_dept50
            AS SELECT department_id, employee_id, first_name, last_name, salary
                FROM employees
                WHERE department_id = 50
            WITH READ ONLY;
            ```

- Restricciones de DML
    - Para las vistas simples, las operaciones DML se pueden realizar en la vista
    - Para las vistas complejas, las operaciones DML NO siempre estan permitidas
    - Las tres reglas:
        1. No puede eliminar una fila desde una tabla base subyacente si la vista contiene algo de lo siguiente:
            - Funciones de grupo
            - Una clausula **GROUP BY**
            - La palabra clave **DISTINCT**
            - La palabra clave **ROWNUM** de pseudocolumna
        2. No puede modificar datos de una vista si la vista contiene:
            - Funciones de grupo
            - Una clausula **GROUP BY**
            - La palabra clave **DISTINCT**
            - La palabra clave **ROWNUM** de pseudocolumna
            - Columnas definidas por expresiones
        3. No puede agregar datos en una vista si esta incluye:
            - Funciones de grupo
            - Una clausula **GROUP BY**
            - La palabra clave **DISTINCT**
            - Palabra clave **ROWNUM** de pseudocolumna
            - Columnas definidas por expresiones
            - O no incluye columnas **NOT NULL** en las tablas base

### **15-3 Gestion de Vistas**

- Supresion de una Vista
    - Esta eliminacion no afecta a los datos de las tablas subyacentes ya que una vista no contiene datos propios
    - Si la vista se ha utilizado para insertar, actualizar o suprimir datos en el pasado, esos cambios en las tablas base se mantienen
    ```sql
    DROP VIEW viewname;
    ```

- Vistas en Linea se utilizan normalmente para simplificar las complejas consultas mediante la eliminacion de operaciones de union y la condensacion de varias consultas en una sola
    ```sql
    SELECT e.last_name, e.salary, e.department_id, d.maxsal
    FROM employees e,
        (SELECT department_id, max(salary) maxsal
            FROM employees
            GROUP BY department_id) d
    WHERE e.department_id = d.department_id
    AND e.salary = d.maxsal;
    ```

- El Analisis de N Principales es una operacion SQL utilizada para clasificar resultados, resulta util cuando desea recuperar los 5 resitros principales o los n registros principales de un juego de resultados devuelto por una consulta
    ```sql
    SELECT ROWNUM AS "Longest employed", last_name, hire_date
    FROM employees
    WHERE ROWNUM <= 5 -- ROWNUM: asigna un numero de fila al juego de resultados
    ORDER BY hire_date;
    ```

## 16 - Secuencias y Sinonimos

### **16-1 Trabajar con Secuencias**

- **SEQUENCE** es un objeto que se puede compartir utilizado para generar automaticamente numeros unicos, se utiliza para crear un valor de clave primaria
    - Ahorra tiempo porque reduce la cantidad de codigo que tiene que escribir
    ```sql
    CREATE SEQUENCE runner_id_seq
        INCREMENT BY 1
        START WITH 1
        MAXVALUE 50000
        NOCACHE -- Evita que los valores de SEQUENCE se almacenen en cache de memoria
        NOCYCLE; -- Evita que la numeracion vuelva a empezar en 1 si se excede el valor 50000
    ```
    - Para verificar que la secuencia se ha creado consulte el diccionario de datos **USER_OBJECTS**
    ```sql
    SELECT sequence_name, min_value, max_value, increment_by, last_number
    FROM user_sequences;
    ```
    - **SEQUENCE** tambien se puede cambiar mediante la sentencia **ALTER SEQUENCE**
        ```sql
        ALTER SEQUENCE runner_id_seq
            INCREMENT BY 1
            MAXVALUE 999999
            NOCACHE
            NOCYCLE;
        ```
    - Para eliminar una secuencia del diccionario de datos utilice la sentencia **DROP SEQUENCE**
        ```sql
        DROP SEQUENCE runner_id_seq;
        ```

- **NEXTVAL** se utiliza para extraer numeros de secuencia sucesivos de una secuencia especificada, al hacer referencia a sequence.NEXTVAL, se genera un nuevo numero de secuencia y el actual se sutituye en **CURRVAL**
```sql
INSERT INTO departments
    (department_id, department_name, location_id)
VALUES
    (departments_seq.NEXTVAL, 'Support', 2500);
```

- **CURRVAL** se utiliza para hacer referencia al numero de secuencia que acaba de generar el usuario actual
```sql
INSERT INTO employees
    (employee_id, department_id, ...)
VALUES
    (employees_seq.NEXTVAL, dept_deptid_seq.CURRVAL, ...);
```

### **16-2 Indices y Sinonimos**

- Un **Indice** es un objeto de esquema que puede acelerar la recuperacion de filas mediante un puntero, se pueden crear explicita o automaticamente, su finalidad es reducir la necesidad de Entrada/Salida de disco mediante una ruta de acceso indexada para buscar datos de forma rapida
    - Un **ROWID** es una representacion de cadena en base64 de la direccion de fila que contiene el identificador de bloque, la ubicacion de fila en el bloque y el identificador de archivo de la BBDD,
    los indices utilizan los **ROWID** porque son la forma mas rapida para acceder a cualquier fila concreta
    - Son logica y fisicamente independientes de la tabla que indexan, por lo que se pueden crear o borrar en cualquier momento, sin que afecten a las tablas base o a otros indices
    - Tipos de Indices
        - **Indice unico**, Oracle Server crea automaticamente este indice al definir una restriccion de clave **PRIMARY KEY** o **UNIQUE** en una columna de la tabla
        - **Indice no unico** este es un indice que un usuario puede crear para acelerar el acceso a las filas
    ```sql
    CREATE INDEX wf_cont_reg_id_idx
    ON wf_countries (region_id);
    ```
    - Un **Indice Compuesto** es un indice creado en varias columnas de una tabla y no incluye los valores nulos
    ```sql
    CREATE INDEX emps_name_idx
    ON employees (first_name, last_name);
    ```
    - Un **Indice basado en Funciones** almacena los valores indexados y utiliza el indice basado en una sentencia **SELECT** para recuperar los datos, es decir es un indice basado en expresiones y la expresion se genera a partir de las columnas de las tablas, restricciones, funciones SQL y funciones definidas por el usuario
        - Son utiles cuando no sabes en que caso los datos se han almacenado en la BBDD 
        ```sql
        CREATE INDEX upper_last_name_idx
        ON employees (UPPER(last_name));

        SELECT *
        FROM employees
        WHERE UPPER(last_name) = 'KING';
        ```
    - Para cambiar un indice, debe borrarlo y volver a crealo mediante **DROP INDEX**
        ```sql
        DROP INDEX upper_last_name_idx;
        ```

- **SYNONYM** es una palabra o expresion que es un sustituto aceptado de otra palabra, se utilizan para simplificar el acceso a objetos creando otro nombre para el objeto y pueden hacer referencia a una tabla propiedad de otro usuario de forma sencilla y reducir los nombres de objetos
    - El administrador puede crear un sinonimo accesible para todos los usuarios con **CREATE PUBLIC SYNONYM**
        ```sql
        CREATE SYNONYM amy_emps
        FOR amy_copy_employees;
        ```
    - Para eliminar un sinonimo ese **DROP SYNONYM**
        ```sql
        DROP SYNONYM amy_emps;
        ```
    - La existencia de sinonimos se puede confirmar consultando la vista del diccionarios de datos **USER_SYNONYMS**

## 17 - Privilegios y Expresiones Regulares

### **17-1 Control de Acceso de los Usuarios**

- En un entorno de varios usuarios, desea mantener la seguridad del uso y acceso a la BBDD
    - Puede realizar los siguiente
        1. Controlar el acceso a la base de datos
        2. Proporcionar acceso a objetos especificos en la base de datos
        3. Confirmar los privilegios asignados y recibidos en el diccionarios de datos de Oracle
        4. Crear sinonimos para objetos de BBDD

- La seguridad de la BBDD se puede clasificar en dos categorias:
    1. **Seguridad del sistema**, abarca el acceso a la base de datos en el nivel del sistema, como la creacion de usuarios, nombres de usuario y contraseñas, la asignacion de espacio en disco a los usuarios y la concesion d los provilegios del sistema que los usuarios pueden llevar a cabo, como crear tablas, vistas y secuencias (Existen mas de 100 privilegios del sistema distintos)
        ```sql
        CREATE USER scott -- Creacion de usuario por el DBA
        IDENTIFIED BY ur35scott;

        ALTER USER scott -- Modificar el usuario
        IDENTIFIED BY imscott35;

        GRANT create session, create table, create sequence, create view -- Asignar privilegios
        TO scott;
        ```
    2. **Seguridad de datos**, esta relacionada con los privilegios de objeto que abarca el acceso y el uso de los objetos de BBDD, asi como las acciones que los usuarios pueden realizar sobre los objetos (Estos privilegios incluyen poder ejecutar sentencias DML)

- **Privilegios y Esquemas**
    - Los **privilegios** son el derecho a ejecutar sentencias SQL determinadas
        - DBA es un usuario de alto nivel con capacidad para otorgar a los usuarios acceso a la BBDD y sus objetos
        - Los usuarios necesitan privilegios del sistema para obtener acceso a la BBDD
        - Necesitan privilegios de objeto para manipular el contenido de los objetos de la BBDD
    - Un **esquema** es una recopilacion de objetos, como tablas, vistas y secuencias
        - Es propiedad de un usuarios de la base de datos y tiene el mismo nombre que el usuario
    
- Seguridad de Objetos, este nivel de acceso y el uso de los objetos de la BBDD asi como las acciones que los usuarios puedan realizar en dichos objetos
    - Cada objetos tiene un juego determinado de privilegios que se pueden otorgar
    - Puede otorgar los privilegios **UPDATE**, **REFERENCES** e **INSERT** en columnas individuales de una tabla
        ```sql
        GRANT UPDATE (salary)
        ON employees TO steven_king;
        ```
        - Un privilegios otorgado en un sinonimo se convierte en un privilegio en la tabla base a la que hace referencia el sinonimo, es decir, es un nuevo nombre mas facil de utilizar

- Un propietario de una tabla puede otorgar acceso a todos los usuarios mediante la palabra clave **PUBLIC**
    ```sql
    GRANT SELECT
        ON alice.departments
    TO PUBLIC;
    ```

### **17-2 Creacion y Revocacion de Privilegios de Objeto**

- Funciones
    - Un rol es un grupo con nombres de privilegios relacionados que se pueden otorgar a un usuarios
    - Esto facilita la revocacion y el mantenimiento de los privilegios
    - Un usuario puede tener acceso a diferentes roles y el mismo rol se puede asignar a diferentes usuarios
    - El **DBA** puede asignar privilegios al rol y dicho rol a los usuarios
        ```sql
        CREATE ROLE manager;

        GRANT create table, create view TO manager;

        GRANT manager TO jennifer_cho;
        ```
    - Para otorgar privilegios en un objeto, el objeto debe estar en el propio esquema o debe otrogar el privilegio con **WITH GRAND OPTION**
        - El usuario con privilegios puede transferir un privilegio que se otorga con la clausula **WITH GRANT OPTION** a otros usuarios y roles
        ```sql
        GRANT SELECT, INSERT
        ON clients
        TO scott_king
        WITH GRANT OPTION;
        ```

    ```sql
    GRANT SELECT
    ON clients
    TO PUBLIC;

    GRANT UPDATE (first_name, last_name)
    ON clients
    TO jennifer_cho, manager;

    SELECT *
    FROM scott_king.clients;

    CREATE SYNONYM clients
    FOR scott_king.clients;

    SELECT *
    FROM clients;
    ```

- Un propietario de una tabla puede otorgar acceso a todos los usuarios mediante la palabra clave **PUBLIC**
    ```sql
    GRANT SELECT
    ON jason_tsang.clients
    TO PUBLIC;
    ```

- Puede eliminar los privilegios otorgados a otros usuarios mediante la sentencia **REVOKE**
    - **CASCADE CONSTRAINTS** es obligatorio para eliminar todas las restricciones de integridad referenciales realizadas sobre el objeto mediante el privilegio **REFERENCES**
    ```sql 
    REVOKE SELECT, INSERT
    ON clients
    FROM scott_king;
    ```

- Un sinonimo publico lo pueden crear los administradores de la BBDD o usuarios de BBDD a los que se haya dado los privilegios para hacerlo, pero no todo el mundo puede crear automaticamente sinonimo publicos

- Un **enlace de BBDD** es un puntero que define una ruta de acceso de comunicacion unidireccional de una BBDD Oracle a otra BBDD con **CREATE DATABASE LINK**

### **17-3 Expresiones regulares**

- El uso de expresiones regulares/normales se basa en el uso de **metacaracteres**
    - Los metacaracteres son caracteres, con un significado especial, como un caracter comodin, un caracter repetitivo, un caracter no coincidente o un rango de caracteres

    | Símbolo   | Descripción                                                                                                      |
    | --------- | ---------------------------------------------------------------------------------------------------------------- |
    | . (punto) | Coincide con cualquier carácter en el juego de caracteres soportados, excepto NULL.                              |
    | ?         | Coincide con ninguna o una incidencia.                                                                           |
    | *         | Coincide con cero o más incidencias.                                                                             |
    | +         | Coincide con una o más incidencias.                                                                              |
    | ()        | Expresión de agrupación, que se trata como una sola subexpresión.                                                |
    | \\        | Carácter de escape.                                                                                              |
    | \|        | Operador de alternancia para especificar coincidencias alternativas.                                             |
    | ^ / $     | Coincide con el principio de línea / final de línea.                                                             |
    | []        | Expresión de corchetes para una lista coincidente que coincide con cualquier expresión representada en la lista. |
    - Puede utilizar estas funcones en cualquier tipo de datos que contenga datos de caracteres como **CHAR**, **CLOB** y **VARCHAR2**, y una expresion regular debe ir entre comillas simples
        | Name           | Description                                                                                                                                                                                      |
        | -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
        | REGEXP_LIKE    | Similar al operador LIKE, pero realiza coincidencias usando expresiones regulares en lugar de una simple coincidencia de patrones.                                                                                       |
        | REGEXP_REPLACE | Busca un patrón de expresión regular y lo reemplaza por una cadena de sustitución.                                                                                                               |
        | REGEXP_INSTR   | Busca en una cadena un patrón de expresión regular y devuelve la posición donde se encuentra la coincidencia.                                                                                    |
        | REGEXP_SUBSTR  | Busca un patrón de expresión regular dentro de una cadena y devuelve la subcadena que coincide.                                                                                               |
        | REGEXP_COUNT   | Devuelve el número de veces que un patrón aparece en una cadena; se indica la cadena y el patrón, y opcionalmente la posición inicial y opciones de coincidencia (por ejemplo, c para distinguir mayúsculas y minúsculas). |
    
    ```sql
    SELECT first_name, last_name
    FROM employees
    WHERE REGEXP_LIKE(first_name, '^Ste(v|ph)en$');
    ```

    -  Con expresiones regulares, solo tiene que utilizar la función REGEXP_LIKE y la cadena de búsqueda: '^Ste(v|ph)en$'
        - "^" especifica el inicio de la cadena que se está buscando
        - "S" mayúscula, seguida de
        - "t" minúscula, seguida de
        - "e" minúscula, seguida de
        - "(" inicia una subexpresión
        - "v" minúscula
        - "|" especifica un O
        - "p" minúscula seguida de "h" mayúscula
        - ")" termina con el grupo de opciones,
        - "e" minúscula
        - "n" minúscula
        - "$" especifica el final de la cadena que se está buscando
        - ".+" significa uno o más caracteres
        - "@" un símbolo @
        - "\." a . (un punto) (aquí la barra invertida es un carácter de escape)

## 18 - Proyecto Final y Revision de Examen

### **18-1 Transacciones de Base de Datos**

- Las **Transacciones** permiten a los usuarios realizar cambios en los datos y decidir si desean guardar o desechar el trabajo
    - Las **transacciones de base** agrupan varios pasos en una unidad logica de trabajo
    - Una transaccion consiste en una de las siguientes opciones:
        - Sentencias DML que constituyen un cambio consistente de los datos
        - Las sentencias DML incluyen **INSERT**, **UPDATE**, **DELETE** y **MERGE**
        - Una sentencia DDL como **CREATE**, **ALTER**, **DROP**, **RENAME** o **TRUNCATE**
        - Una sentencia DCL como **GRANT** o **REVOKE**

    - Las transacciones se controlan mediante las siguientes sentencias:
        - **COMMIT**: representa el punto en el tiempo en el que el usuario ha realizado todos los cambios que queria para agruparlos logicamente y, puesto que no se ha cometido ningun error, el usuario esta listo para guardar el trabajo
        - **ROLLBACK**: permite al usuario desechar los cambios realizados en la Base de Datos
        - **SAVEPOINT**: crea un marcador en una transaccion, que divide la transaccion en varias partes mas pequeñas
        - **ROLLBACK TO SAVEPOINT**: permite al usuario realizar un rollback de la transaccion actual hasta un punto de grabacion especificado
        ```sql
        INSERT INTO copy_departments (department_id, department_name, manager_id, location_id)
        VALUES (130, 'Estate Management', 102, 1500);

        UPDATE copy_departments
        SET department_id = 140;   -- cláusula WHERE omitida

        ROLLBACK TO SAVEPOINT one;

        COMMIT;
        ```

- Para evitar que alguien mas este introduciendo informacion que entra en conflicto con tus cambios, los sistemas de BBDD utilizan una implantacion automatica denominada **consistencia de lectura**
    - La **consistencia de lectura** garantiza una vista consistente de los datos para todos los usuarios en todo momento y es una implementacion automatica
    - Antes de confirmar los cambios en la base de datos, solo el usuario que esta cambiando los datos ve los cambios; todos los demas ven la instantanea en el segmento de deshacer
    - Esto garantiza que los lectores de los datos vean datos consistentes en los que no se este realizando actualmente ningun cambio

- Cambios Visibles
    - Cuando se confirma una sentencia DML, cualquiera que ejecute la sentencia **SELECT** puede ver el cambio realizado
    - Si se realiza un rollback de la transaccion, los cambios se deshacen: 
        - La version original anterior de los datos del segmento de deshacer se vuelve a escribir en la tabla
        - Todos los usuarios ven la base de datos como existia antes de comenzar la transaccion

- **COMMIT** y **ROLLBACK** garantizan la consistencia de los datos, posibilitando obtener una vista previa de los cambios en los datos antes de hacer que los cambios sean permanentes y para agrupar logicamente operaciones relacionadas
- **SAVEPOINT** crea un punto en una transaccion al que puede realizar un rollback sin tener que deshacer toda la transaccion
- **COMMIT**, **ROLLBACK** y **SAVEPOINT** se denominan lenguaje de control de transacciones o TCL

## 19 - TCL

### **19-1 Pruebas**

- Si se prueban dos cosas a la vez y falla la prueba, es dificil o imposible averiguar que ha provocado el fallo, por lo que es importante probar solo una cosa a la vez, esto se conoce como **pruebas de unidades**
    - Al probar una base de datos, necesita probar gran variedad de elementos, por ejemplo:
        - Que las columnas contengan el tipo de dato correcto
        - Que las columnas pueden albergar la mayor cantidad de datos que se puedan introducir
        - Debe comprobarse que las restricciones solo restringen o limitan los datos que se supone que deben restringir, ni mas ni menos
    - Deben realizarse una serie de pruebas aleatorias, que comprueben algunas columnas y algunas restricciones

### **19-2 Creacion de la BBDD del Proyecto Final**

### **19-3 Revision del Examen Final**

- Mayúsculas/minúsculas
```sql
LOWER(column_name | expression)
UPPER(column_name | expression)
INITCAP(column_name | expression)
```

- Caracteres
```sql
CONCAT(column_name | expression, column_name | expression)
SUBSTR(column_name | expression, n, m)
LENGTH(column_name | expression)
INSTR(column_name | expression, string_literal)
LPAD(column_name | expression, n, character_literal)
RPAD(column_name | expression, n, character_literal)
TRIM([leading | trailing | both] char1 FROM char2)
REPLACE(column_name | expression, string_to_be_replaced, replacement_string)
```

- Funciones Numericas
    ```sql
    ROUND(column | expression, n)
    TRUNC(column | expression, n)
    MOD(column | expression, column | expression)
    ```

- Funciones de Fecha
    ```sql
    ROUND(column | expression, string)
    TRUNC(column | expression, string)

    MONTHS_BEWEEN(column | expression, column | expression)
    ADD_MONTHS(column | expression, n)
    NEXT_DAY(column | expression, 'day')
    LAST_DAY(column | expression)
    ```

- Funciones de Conversion
    ```sql
    TO_CHAR(number, 'format model')
    TO_CHAR(date,   'format model')
    TO_NUMBER(character_string, 'format model')
    TO_DATE(character_string,   'format model')
    ```

- Funciones NULL
    ```sql
    NVL(column | expression, value)

    NVL2(column | expression,
        column | expression,
        column | expression)

    NULLIF(column | expression, column | expression)

    COALESCE(column | expression,
            column | expression,
            column | expression, …,
            column | expression)
    ```

- Expresiones Condicionales
    ```sql
    -- Específico de Oracle
    DECODE(column | expression, search1, result1
                        [, search2, result2, ...]
                        [, default])

    -- ANSI
    CASE expr
        WHEN comparison_expr1 THEN return_expr1
        [WHEN comparison_expr2 THEN return_expr2
        WHEN comparison_exprN THEN return_exprN
        ELSE else_expr]
    END
    ```

- Sintaxis Estandar **ANSI SQL**
    ```sql
    -- Cross Join
    SELECT last_name, department_name
    FROM employees CROSS JOIN departments;

    -- Natural Join
    SELECT employee_id, last_name, department_name
    FROM employees NATURAL JOIN departments;

    -- Join .. ON
    SELECT e.employee_id, e.last_name, e.salary, j.grade_level
    FROM employees e JOIN job_grades j
    ON (e.salary BETWEEN j.lowest_sal AND j.highest_sal);

    -- Joins .. USING
    SELECT employee_id, last_name, department_name
    FROM employees JOIN departments
    USING (department_id);

    -- Join .. ON
    SELECT e.employee_id, e.last_name, d.department_id, d.location_id
    FROM employees e JOIN departments d
    ON (e.department_id = d.department_id);

    -- Uniones Externas

    -- Right Outer Join
    SELECT e.employee_id, e.last_name, e.department_id, d.department_name
    FROM employees e RIGHT OUTER JOIN departments d
    ON (e.department_id = d.department_id);

    -- Left Outer Join
    SELECT e.employee_id, e.last_name, e.department_id, d.department_name
    FROM employees e LEFT OUTER JOIN departments d
    ON (e.department_id = d.department_id);

    -- Full Outer Join
    SELECT e.employee_id, e.last_name, e.department_id, d.department_name
    FROM employees e FULL OUTER JOIN departments d
    ON (e.department_id = d.department_id);
    ```

- Funciones de Grupo
    ```sql
    AVG      (column | expression)
    COUNT    (column | expression)
    MIN      (column | expression)
    MAX      (column | expression)
    SUM      (column | expression)
    VARIANCE (column | expression)
    STDDEV   (column | expression)

    SELECT column1, AVG(column | expression)
    FROM table1
    GROUP BY [ROLLUP | CUBE] (column1 | GROUPING SETS)
    HAVING AVG(column | expression);
    ```

- Subconsultas de Una o Varias Filas
    ```sql
    SELECT column1 ..
    FROM table1
    WHERE column2 = (
        SELECT column2
        FROM table1
        WHERE column3 = expression
    );
    ```

- Operadores de Una Sola Fila: =, >, <, >=, <=, <>
- Operadores de Varias Filas: IN, ANY, ALL

- Subconsultas Pareadas y No Pareadas
    ```sql
    -- Pareadas
    SELECT column1..
    FROM table1
    WHERE (column2, column3) = (
        SELECT column2, column3
        FROM table1
        WHERE column4 = expression
    );

    -- No pareadas
    SELECT column1..
    FROM table1
    WHERE column2 = (
        SELECT column2
        FROM table1
        WHERE column4 = expression
    )
    AND column3 = (
        SELECT column3
        FROM table2
        WHERE column4 = expression
    );
    ```

- Subconsultas Correlacionadas
    ```sql
    SELECT o.column1..
    FROM table1 o
    WHERE o.column2 = 
        (SELECT i.column2
        FROM table2 i
        WHERE i.column1 = o.column1);
    ```

- Insercion, Actualizacion y Supresion de Datos
    ```sql
    -- INSERT explícito
    INSERT INTO table (column1, column2, ...)
    VALUES (value1, value2, ...);

    -- INSERT implícito
    INSERT INTO table
    VALUES (value1, value2, value3, value4);

    UPDATE table1
    SET column1 = value1,
        column2 = value2, ...
    WHERE column1 = value;

    DELETE FROM table1
    WHERE column1 = value;
    ```

- Valores por Defecto
    ```sql
    CREATE TABLE table1 (
        column1 DATE DEFAULT SYSDATE,
        ...
    );

    INSERT INTO table1 (column1, ...)
    VALUES (DEFAULT, ...);
    ```

- Sentencia Merge
    ```sql
    -- Insercion en varias tablas
    MERGE INTO destination_table USING source_table
    ON matching_condition
    WHEN MATCHED THEN
        UPDATE
        SET ...
    WHEN NOT MATCHED THEN
        INSERT
        VALUES (...);
    ```

- Creacion de Tablas
    ```sql
    CREATE TABLE table (
        column  data_type [DEFAULT expression],
        column  data_type [DEFAULT expression],
        ... [ ]
    );

    CREATE TABLE tablename
        [(column, column, ...)]
    AS subquery;
    ```

- Especificacion de Tipos de Dato
    ```sql
    NUMBER(p, s)
    CHAR
    VARCHAR2(n)
    DATE
    TIMESTAMP
    TIMESTAMP WITH TIME ZONE
    TIMESTAMP WITH LOCAL TIME ZONE
    INTERVAL YEAR TO MONTH
    INTERVAL DAY TO SECOND
    CLOB
    BLOB
    RAW
    ```

- Modificacion de una Tabla
    ```sql
    ALTER TABLE tablename
    ADD (column_name data_type [DEFAULT expression] ...);

    ALTER TABLE tablename
    MODIFY (column_name VARCHAR2(30));

    ALTER TABLE tablename
    DROP COLUMN column_name;

    ALTER TABLE tablename
    SET UNUSED (column_name);

    ALTER TABLE tablename
    DROP UNUSED COLUMNS;

    -- Insercion en varias tablas
    DROP TABLE tablename;

    FLASHBACK TABLE tablename TO BEFORE DROP;

    SELECT * FROM user_recyclebin;

    SELECT versions_starttime "START_DATE",
        versions_endtime   "END_DATE",
        column, column, ...
    FROM   table
        VERSIONS BETWEEN SCN MINVALUE AND MAXVALUE
    WHERE  column = value;
    ```

- Restricciones a Nivel de Columna
    ```sql
    CREATE TABLE table (
        col1 data_type CONSTRAINT tab_col1_pk PRIMARY KEY,
        col2 data_type CONSTRAINT tab_col2_nn NOT NULL,
        col3 data_type CONSTRAINT tab_col3_uk UNIQUE,
        col4 data_type CONSTRAINT tab_col4_ck CHECK (col4 > value),
        col5 data_type CONSTRAINT tab_col5 REFERENCES table2 (col1)
    );
    ```

- Restricciones a Nivel de Tabla
    ```sql
    CREATE TABLE table (
        col1 data_type,
        col2 data_type,
        col3 data_type,
        col4 data_type,
        col5 data_type,
        CONSTRAINT tab_col1_pk PRIMARY KEY (col1),
        CONSTRAINT tab_col3_uk UNIQUE (col2),
        CONSTRAINT tab_col4_ck CHECK (col4 > value),
        CONSTRAINT tab1_col5_fk FOREIGN KEY (col5) REFERENCES table2 (col1)
    );
    ```

- Creacion y Gestion de Vistass
    ```sql
    CREATE [OR REPLACE] [FORCE | NOFORCE] VIEW view
        [(alias [, alias]...)] AS subquery
        [WITH CHECK OPTION [CONSTRAINT constraint]]
        [WITH READ ONLY   [CONSTRAINT constraint]];

    DROP VIEW viewname;
    ```

- Analisis de N Principales
    ```sql
    SELECT ROWNUM AS RANK, col1, col2
    FROM (
        SELECT col1, col2
        FROM table1
        ORDER BY col1
    )
    WHERE ROWNUM <= n;
    ```

- Vistas en Linea
    ```sql
    SELECT t1.col1, t2.col2, ...
    FROM table1 t1,
        (SELECT col1, col2, ...
        FROM table2
        WHERE ...) t2
    WHERE ...;
    ```

- Creacion de Secuencias
    ```sql
    CREATE SEQUENCE sequence
        [INCREMENT BY n]
        [START WITH n]
        [{MAXVALUE n | NOMAXVALUE}]
        [{MINVALUE n | NOMINVALUE}]
        [{CYCLE | NOCYCLE}]
        [{CACHE n | NOCACHE}];

    DROP SEQUENCE sequence_name;
    ```

- Creacion de Indices y Sinonimos
    ```sql
    CREATE INDEX index_name
    ON table_name (column, ..., column);

    DROP INDEX index_name;

    CREATE [PUBLIC] SYNONYM synonym
    FOR object;

    DROP [PUBLIC] SYNONYM name_of_synonym;
    ```

- Creacion y Revocacion de Privilegios de Objeto
    ```sql
    CREATE USER user
    IDENTIFIED BY password;

    GRANT privilege [, privilege...]
    TO user [, user | role | PUBLIC...];

    ALTER USER user
    IDENTIFIED BY password;

    --
    CREATE ROLE role_name;

    GRANT object_priv [(column_list)]
    ON object_name
    TO {user | role | PUBLIC}
    [WITH GRANT OPTION];

    REVOKE {privilege [, privilege...] | ALL}
    ON object
    FROM {user [, user...] | role | PUBLIC}
    [CASCADE CONSTRAINTS];
    ```

## 20 - Garantia de Consultas de Calidad Parte 2

### **20-1 Garantia de Resultados de Consultas de Calidad - Tecnicas Avanzadas**