# Desktop, Systems & Database Programming (`visualbasic`)

This directory contains **Visual Basic .NET (VB.NET)** projects targeting the **.NET Framework** (up to v4.7.2). The coursework is divided into four main categories: multi-form application lifecycle (`Application`), object-oriented console programming (`Console`), database connectivity and system/network programming (`Databases`), and Windows Forms graphical desktop applications (`Forms`).

---

## Technologies and Tools

### Programming Languages
- **Visual Basic .NET (VB.NET)**
- **SQL** (executed against Microsoft Access databases via OLE DB)

### Frameworks, Libraries, and Namespaces
- **.NET Framework** (`v4.0` / `v4.7.2`)
- **Windows Forms (`System.Windows.Forms`)** — Graphical desktop user interfaces, dialogs (`OpenFileDialog`, `SaveFileDialog`), validation (`ErrorProvider`, `HelpProvider`), and custom UserControls (`WindowsControlLibrary`).
- **ADO.NET, OLE DB, ADOX & ADODB** (`System.Data.OleDb`, `ADOX.Catalog`, `ADODB.Connection`) — Dynamic creation, schema inspection, and querying of Microsoft Access databases.
- **System.Security.Cryptography** (`TripleDESCryptoServiceProvider`, `SHA1CryptoServiceProvider`, `CryptoStream`) — Symmetric 3DES data encryption and password file protection.
- **System.Net & System.Net.Sockets** (`TcpClient`, `TcpListener`, `Stream`) — Event-driven TCP client/server socket communication.
- **System.Net.Mail** (`SmtpClient`, `MailMessage`, `Attachment`) — Asynchronous and multi-threaded SMTP email dispatch with regex validation.
- **System.Threading** (`Thread`) — Multi-threaded execution and background worker threads.
- **System.IO** (`StreamReader`, `StreamWriter`, `MemoryStream`) — Text and binary file persistence.

### Databases
- **Microsoft Access** (`.accdb` and `.mdb` formats via `Microsoft.Jet.OLEDB.4.0` / ACE OLE DB providers).

### Development Tools
- **Microsoft Visual Studio** (`.sln`, `.vbproj`).

---

## Projects and Exercises

### 1. `Application` — Multi-Form Lifecycle & Startup Modules

#### `App01_EjecutarMain` & `App02_VariosForms`
- **Name:** `App01_EjecutarMain`, `App02_VariosForms`
- **Description:** Windows Forms projects demonstrating custom application entry points (`Sub Main` in `Module1.vb`), shared global state across modules (`ModuleVariables.vb`), and navigation between multiple forms (`Form1`, `Form2`).
- **Technologies:** VB.NET, .NET Framework 4.7.2, Windows Forms.
- **Key Features:**
  - Configures programmatic form instantiation and inter-form communication from a central module entry point.
- **Location:** [`./Application`](./Application)

---

### 2. `Console` — Core Language & Object-Oriented Programming (`Cls01` – `Cls21`)

- **Name:** `Cls01_ModoConsola` through `Cls21_Estructuras`
- **Description:** Progressive series of 21 VB.NET console applications covering procedural syntax, scope rules, object-oriented programming, inheritance, polymorphism, enumerations, structures, and a graded student/tuition management deliverable (`Cls17_Entrega1`).
- **Technologies:** VB.NET, .NET Framework 4.7.2 (`System.Console`).
- **Key Features:**
  - **Procedural Foundations (`Cls01` – `Cls08`):** Console I/O (`Cls01_ModoConsola`), data types and operators (`Cls02_Lenguaje`), subroutines and functions (`Cls03_FuncionesYProcedimientos`, `Cls04_Procedimientos`, `Cls07_Funciones`, `Cls08_Funciones`), control flow (`Cls05_Instrucciones`), and variable scope (`Cls06_ReglasDeAmbito`).
  - **Classes, Namespaces & Inheritance (`Cls09` – `Cls16`):** Class design and encapsulation (`Cls09_CreacionDeClases`, `Cls10_Clases`, `Cls11_ClaseEmpleado`), namespace organization (`Cls12_NameSpaces`), constructors and base/derived class inheritance (`Cls13_ConstructoresYHerencias`, `Cls14_HerenciaClaseBaseYDerivada`), method overriding (`Cls15_MetodosEnClaseBaseYDerivada`), and dynamic collection management (`Cls16_AnnadirElementos`).
  - **Graded Deliverable (`Cls17_Entrega1`):** Multi-class console system modeling students (`Alumno.vb`), academic grades (`Notas.vb`), and tuition receipts (`Recibo.vb`).
  - **Advanced Types (`Cls18` – `Cls21`):** `Shared` members and value types (`Cls18_ClasesSharedYStruct`), enumerations (`Cls19_TipoEnum`, `Cls20_MasEnum`), and custom `Structure` definitions (`Cls21_Estructuras`).
- **Location:** [`./Console`](./Console)

---

### 3. `Databases` — Database Engineering, Cryptography, Networking, Threads & Custom Controls (`Db00` – `Db08`)

#### `Db00_PruebaFebrero`
- **Name:** `Db00_PruebaFebrero`
- **Description:** February practical assessment combining flat-file data processing (`Alumnos_2025-26_2B.Dat`) with a Microsoft Access database (`FP.accdb`) in a Windows Forms application (`CrearBBDD`).
- **Technologies:** VB.NET, Windows Forms, OLE DB / ADOX, MS Access (`FP.accdb`).
- **Key Features:**
  - Reads structured student records and persists/queries them against an Access database.
- **Location:** [`./Databases/Db00_PruebaFebrero`](./Databases/Db00_PruebaFebrero)

#### `Db01_CrearBBDD`
- **Name:** `Db01_CrearBBDD`
- **Description:** Windows Forms utility that programmatically creates a new Microsoft Access database (`Nuevo.accdb`), defines table schemas, and inspects database metadata.
- **Technologies:** VB.NET, Windows Forms, `System.Data.OleDb`, `ADOX.Catalog`, `ADODB.Connection`.
- **Key Features:**
  - Uses `ADOX.Catalog.Create` with `Provider=Microsoft.Jet.OLEDB.4.0` to generate `.accdb` files on disk.
  - Dynamically appends a table (`Datos`) with typed columns (`adInteger`, `adWChar`, `adDate`) and includes schema inspection scripts (`RecuperarEsquema.txt`, `RecuperaresquemaTabla.txt`, `RecuperaEsquemaColumnas.txt`).
- **Location:** [`./Databases/Db01_CrearBBDD`](./Databases/Db01_CrearBBDD)

#### `Db02_GeneradorConsultas`
- **Name:** `Db02_GeneradorConsultas`
- **Description:** Interactive SQL query builder and runner executing dynamic queries against a personal data Access database (`DatosPer.mdb`).
- **Technologies:** VB.NET, Windows Forms, OLE DB, MS Access (`DatosPer.mdb`).
- **Key Features:**
  - Connects to `DatosPer.mdb` and renders query results dynamically in a Windows Forms interface.
- **Location:** [`./Databases/Db02_GeneradorConsultas`](./Databases/Db02_GeneradorConsultas)

#### `Db03_PruebaBBDD`
- **Name:** `Db03_PruebaBBDD` (`PruebaBBDD`)
- **Description:** Multi-form database navigation and query suite featuring a main launcher (`FrmInicio`), record navigator (`FrmNaveBBDD`), and custom query view (`FrmConsultas`).
- **Technologies:** VB.NET, Windows Forms, ADO.NET / OLE DB.
- **Key Features:**
  - Separates record-by-record dataset navigation (`FrmNaveBBDD.vb`) from filtered SQL consultation (`FrmConsultas.vb`).
- **Location:** [`./Databases/Db03_PruebaBBDD`](./Databases/Db03_PruebaBBDD)

#### `Db04_Encriptacion`
- **Name:** `Db04_Encriptacion` (`CrearFichero`)
- **Description:** User credential and file encryption utility implementing symmetric TripleDES (3DES) encryption with SHA-1 key derivation.
- **Technologies:** VB.NET, Windows Forms, `System.Security.Cryptography` (`TripleDESCryptoServiceProvider`, `SHA1CryptoServiceProvider`, `CryptoStream`).
- **Key Features:**
  - `Simple3Des.vb` hashes user keys via SHA-1, truncates/pads the hash to match the 3DES block and key sizes, and provides `EncryptData` and `DecryptData` methods converting byte streams to Base64 strings.
  - `FrmUsu.vb` manages encrypted credential files (`.cla` files in `Ficheros/`).
- **Location:** [`./Databases/Db04_Encriptacion`](./Databases/Db04_Encriptacion)

#### `Db05_Mail`
- **Name:** `Db05_Mail` (`Mail_VB2005`)
- **Description:** Multi-threaded Windows Forms SMTP email client with file attachments, regex email validation, contextual F1 help, and cancellation support.
- **Technologies:** VB.NET, Windows Forms, `System.Net.Mail` (`SmtpClient`, `MailMessage`, `Attachment`), `System.Threading.Thread`, `System.Text.RegularExpressions.Regex`, `ErrorProvider`, `HelpProvider`.
- **Key Features:**
  - Validates sender and recipient addresses via regular expressions (`ValidateEmail`) with visual `ErrorProvider` feedback and F1 `HelpProvider` tooltips.
  - Supports multiple file attachments via `OpenFileDialog` and dispatches emails over SSL (`smtp.gmail.com:587`) on a background `Thread` with a `ProgressBar` and async cancellation (`SendAsyncCancel`).
- **Location:** [`./Databases/Db05_Mail`](./Databases/Db05_Mail)

#### `Db06_Socket`
- **Name:** `Db06_Socket`
- **Description:** Four-solution TCP socket communications suite implementing custom event-driven TCP client and server classes and graphical sender/receiver applications.
- **Technologies:** VB.NET, Windows Forms, `System.Net.Sockets` (`TcpClient`, `TcpListener`), `System.Threading.Thread`, `System.IO.Stream`.
- **Key Features:**
  - Includes four subprojects: `Cliente` (reusable `Cliente.vb` wrapper with background listener thread and `DatosRecibidos` / `ConexionTerminada` events), `Servidor` (`Servidor.vb` TCP listener), `Envio` (GUI message sender), and `Recepcion1` (GUI message receiver), plus reference documentation (`Socket de Internet.docx`, `Utilizando Sockets en VB.docx`).
- **Location:** [`./Databases/Db06_Socket`](./Databases/Db06_Socket)

#### `Db07_Hilos`
- **Name:** `Db07_Hilos` (`Hebras`, `Hebras1` – `hebras5`)
- **Description:** Six progressive multi-threading laboratory solutions exploring concurrent execution, UI thread marshaling, thread lifecycle control, and multi-form background processing.
- **Technologies:** VB.NET, Windows Forms, `System.Threading.Thread`.
- **Key Features:**
  - Contains six standalone Visual Studio solutions (`Hebras`, `Hebras1`, `Hebras2`, `Hebras3`, `Hebras4`, `hebras5`), each paired with its technical specification document (`Hilos.docx`, `hilos1.docx` – `Hilos5.docx`).
- **Location:** [`./Databases/Db07_Hilos`](./Databases/Db07_Hilos)

#### `Db08_TextBoxNumerico`
- **Name:** `Db08_TextBoxNumerico` (`TxtNumerico`)
- **Description:** Custom Windows Forms Control Library (`WindowsControlLibrary1`) providing a reusable numeric-only `TextBox` component (`TextboxNumerico.vb`).
- **Technologies:** VB.NET, Windows Forms Control Library (`UserControl`).
- **Key Features:**
  - Encapsulates key-press filtering and numeric input validation into a reusable `.dll` control for Windows Forms designers.
- **Location:** [`./Databases/Db08_TextBoxNumerico`](./Databases/Db08_TextBoxNumerico)

---

### 4. `Forms` — Windows Forms Desktop Applications (`Frm00` – `Frm05`)

#### `Frm00_Examen`
- **Name:** `Frm00_Examen`
- **Description:** Comprehensive December practical assessment implementing a multi-window student academic and banking records manager with built-in utility tools and automatic text file export on exit.
- **Technologies:** VB.NET, .NET Framework, Windows Forms, `System.IO.StreamWriter`, `SaveFileDialog`.
- **Key Features:**
  - **Student Data Entry (`Forms/Add/`):** Dedicated forms for entering personal details (`FrmIntroducirDatosPersonales`), subjects (`FrmIntroducirAsignaturas`), bank IBAN data (`FrmIntroducirDatosBancarios`), and grades (`FrmIntroducirNotas`).
  - **Reporting Lists (`Forms/Lists/`):** Dedicated list views for students (`FrmListadoAlumnos`), subjects (`FrmListadoAsignaturas`), bank accounts (`FrmListadoDatosBancarios`), and grades (`FrmListadoNotas`), plus a quick subject counter summary (`ButtonContador`).
  - **Built-in Utilities (`Forms/Tools/`):** Includes a calculator (`FrmCalculadora`) and a numeric-to-qualitative grade converter (`FrmConversorNotas`).
  - **File Export on Close:** Prompts via `SaveFileDialog` when closing the application to serialize all students, subjects, grades, and IBAN records into a structured text file (`alumnos.txt`).
- **Location:** [`./Forms/Frm00_Examen`](./Forms/Frm00_Examen)

#### `Frm01_ProyectoCalculadora`, `Frm02_Calculadora` & `Frm05_CalculadoraV2`
- **Name:** `Frm01_ProyectoCalculadora`, `Frm02_Calculadora`, `Frm05_CalculadoraV2`
- **Description:** Three iterations of Windows Forms desktop calculators demonstrating arithmetic operations, state management, custom icons (`Calc.ico`), and UI event handling.
- **Technologies:** VB.NET, Windows Forms.
- **Key Features:**
  - Progresses from basic two-operand arithmetic (`Frm01_ProyectoCalculadora`) to full keypad calculator interfaces (`Frm02_Calculadora` and `Frm05_CalculadoraV2`).
- **Location:** [`./Forms/Frm01_ProyectoCalculadora`](./Forms/Frm01_ProyectoCalculadora), [`./Forms/Frm02_Calculadora`](./Forms/Frm02_Calculadora), [`./Forms/Frm05_CalculadoraV2`](./Forms/Frm05_CalculadoraV2)

#### `Frm03_Menu`
- **Name:** `Frm03_Menu`
- **Description:** Windows Forms application demonstrating `MenuStrip` navigation and child form launching (`Form1.vb` and `FrmCalculadora.vb`).
- **Technologies:** VB.NET, Windows Forms.
- **Key Features:**
  - Integrates a top-level menu bar with secondary tool windows.
- **Location:** [`./Forms/Frm03_Menu`](./Forms/Frm03_Menu)

#### `Frm04_Ficheros`
- **Name:** `Frm04_Ficheros`
- **Description:** Windows Forms file I/O application demonstrating reading and writing text files (`contra3.txt`) from a graphical interface.
- **Technologies:** VB.NET, Windows Forms, `System.IO`.
- **Key Features:**
  - Performs sequential file read/write operations triggered by form controls.
- **Location:** [`./Forms/Frm04_Ficheros`](./Forms/Frm04_Ficheros)

---

## Additional Notes

> [!WARNING]
> In `Databases/Db01_CrearBBDD/CrearBBDD/Form1.vb`, the OLE DB connection string contains an absolute local path (`Data Source=C:\Users\kosoi\Documents\GitHub\2DAM\vb\Databases\Db01_CrearBBDD\Nuevo.accdb`). Update this path to match your local directory or use `Application.StartupPath` before running the database creation routine.

> [!NOTE]
> The `Microsoft.Jet.OLEDB.4.0` provider used in `Db01_CrearBBDD` and `Db02_GeneradorConsultas` requires running the compiled executable in **32-bit (`x86`)** mode on Windows, or installing the 64-bit Microsoft Access Database Engine (`Microsoft.ACE.OLEDB.12.0`).
