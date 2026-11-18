# Enterprise Resource Planning — Microsoft Dynamics 365 Business Central (`businesscentral`)

This directory contains extensions, exercises, and study documentation for **Microsoft Dynamics 365 Business Central** developed in the **AL (Application Language)**. The coursework covers custom ERP data models (Tables, Enums, Table Extensions), user interface objects (Card Pages, List Pages, Document Pages), business logic triggers, and custom Word-layout reports running on containerized Business Central environments.

---

## Technologies and Tools

### Programming Languages
- **AL (Application Language)** — Language for developing extensions in Microsoft Dynamics 365 Business Central (Runtime `16.0`, Application `24.0.0.0` / `27.0.0.0`).
- **Markdown** — Technical notes on AL project creation, Business Central object definitions, and AL data types.

### ERP Platform & Object Types
- **Microsoft Dynamics 365 Business Central**
  - **Tables & Table Extensions** (`table`, `tableextension`)
  - **Pages & Page Extensions** (`page` — `Card`, `List`, `ListPart`, `Document`)
  - **Enumerations** (`enum`)
  - **Reports** (`report` with `.docx` Word layouts)

### Development Tools and Infrastructure
- **Visual Studio Code** with the **AL Language Extension for Microsoft Dynamics 365 Business Central**.
- **Docker** — Local on-premises Business Central container instances configured via `.vscode/launch.json`.
- **Microsoft Word** (`.docx`) — Report layout templates linked to AL report datasets.

---

## Projects and Exercises

### 1. `00_Examen` (`ExamenDiciembre2025`)
- **Name:** `00_Examen` (`ExamenDiciembre2025`)
- **Description:** Practical assessment extension (Object ID range `50500..50549`) implementing a bookstore management module to track books, authors, sales transactions, and sales reports.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central (App v27.0), Word Report Layouts (`.docx`).
- **Key Features:**
  - **Data Model:** Defines `table 50500 Libro` (books), `table 50501 Autor` (authors), `table 50502 Venta` (sales), and `enum 50500 GeneroLibro` (book genres).
  - **User Interface:** Provides Card and List pages for books (`page 50500 Libro Card`, `page 50501 Libro List`), authors (`page 50502 Autor Card`, `page 50503 Autor List`), and sales (`page 50504 Venta Card`, `page 50505 Venta List`).
  - **Reporting:** Includes `report 50500 Listado Ventas` (with `Listado Ventas.docx` layout) and `report 50501 Promedio Ventas`.
- **Location:** [`./00_Examen`](./00_Examen)

### 2. `01_HelloWorld`
- **Name:** `01_HelloWorld`
- **Description:** Minimal AL starter extension extending the `Customer List` page to display a "Hello World" message on open.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central.
- **Key Features:**
  - Demonstrates the default `CustomerListExt` page extension trigger `OnOpenPage()` and `app.json` manifest structure.
- **Location:** [`./01_HelloWorld`](./01_HelloWorld)

### 3. `02_PrimerAL`
- **Name:** `02_PrimerAL`
- **Description:** Initial AL project workspace and compiled package (`Default Publisher_ALProject2_1.0.0.0.app`) validating symbol downloads and extension compilation.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central.
- **Key Features:**
  - Configures symbol references in `.alpackages` and packages the base extension into an installable `.app` artifact.
- **Location:** [`./02_PrimerAL`](./02_PrimerAL)

### 4. `03_PruebaDocker`
- **Name:** `03_PruebaDocker`
- **Description:** Test extension created to verify connectivity and deployment against a local Docker-hosted Business Central instance.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central, Docker.
- **Key Features:**
  - Configures `.vscode/launch.json` for local container authentication and publishing.
- **Location:** [`./03_PruebaDocker`](./03_PruebaDocker)

### 5. `04_Docker`
- **Name:** `04_Docker` (`BCconDocker`)
- **Description:** Docker-targeted Business Central extension (`Default Publisher_BCconDocker_1.0.0.0.app`) validating on-premises container deployment and symbol synchronization.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central, Docker.
- **Key Features:**
  - Includes compiled `.app` package and `.alpackages` symbol dependencies for container environments.
- **Location:** [`./04_Docker`](./04_Docker)

### 6. `05_WDTU-DAM2B-25-26`
- **Name:** `05_WDTU-DAM2B-25-26`
- **Description:** Comprehensive radio station management ERP module (Object ID range `50100..50249`) modeling radio shows, playlists, broadcast entries, listenership metrics, publishers, and item rate cards.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central (App v24.0), Word Report Layouts (`RadioShows.docx`).
- **Key Features:**
  - **Tables & Extensions:** Implements `Radio Show` (`50100`), `Radio Show Type` (`50101`), `Playlist Header` (`50102`), `Playlist Line` (`50103`), `Playlist Item Rate` (`50104`), `Radio Show Entry` (`50105`), `Listenership Entry` (`50106`), `Publisher` (`50107`), `Date Formula` (`50140`), and `tableextension 50100 Item`.
  - **Pages:** Provides list and card pages for radio shows, types, playlist documents, item rates, broadcast entries, listenership entries, publishers, and date formula testing.
  - **Reporting & Notes:** Includes `report 50100 Radio Shows` with its Word layout (`RadioShows.docx`) and documentation on field properties (`table 50199 Propiedades de Campos.md`).
- **Location:** [`./05_WDTU-DAM2B-25-26`](./05_WDTU-DAM2B-25-26)

### 7. `06_AprendeBusinessCentral`
- **Name:** `06_AprendeBusinessCentral`
- **Description:** Academic high school management extension (Object ID range `50200..50249`) managing students, teachers, subjects, grades, and school configuration settings.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central.
- **Key Features:**
  - **Tables & Enums:** Implements `table 50200 Estudiante`, `table 50201 Asignatura`, `table 50202 Calificacion`, `table 50203 Profesor`, `table 50204 Conf. Instituto`, and `enum 50200 curso` (1st–4th ESO levels).
  - **Pages:** Includes List and Card pages for grades (`50200`, `50201`), teachers (`50202`, `50203`), students (`50204`, `50205`), subjects (`50206`, `50207`), and institute configuration (`50208`).
  - **Relational Lookups & Calculated Fields:** Links tutors and teachers to the standard `Customer` table, tracks student remedial status (`Refuerzo`) and tutor flags (`Profesor tutor`), and computes course grade averages.
- **Location:** [`./06_AprendeBusinessCentral`](./06_AprendeBusinessCentral)

### 8. `07_TiendaInformatica`
- **Name:** `07_TiendaInformatica` (`TiendaInformaticaV01`)
- **Description:** Computer store inventory and pricing extension (Object ID range `50300..50399`) with product categorization and stock valuation reporting.
- **Technologies:** AL, Microsoft Dynamics 365 Business Central (App v27.0), Word Report Layouts (`Report Precio Stock Productos.docx`).
- **Key Features:**
  - Models store inventory via `table 50300 Productos` and `enum 50300 Categoria Productos`.
  - Provides product management interfaces (`page 50300 Productos Card` and `page 50301 Productos List`).
  - Generates a formatted product price and stock report via `report 50300 Precio Stock Productos` using `Report Precio Stock Productos.docx`.
- **Location:** [`./07_TiendaInformatica`](./07_TiendaInformatica)

### 9. Root Study Guides
- **Files:**
  - [`00_ApuntesMarkDown.md`](./00_ApuntesMarkDown.md) — Markdown syntax reference guide.
  - [`01_HacerProyectoAL.md`](./01_HacerProyectoAL.md) — Step-by-step guide on configuring `launch.json` and `app.json`, downloading symbols, and organizing `src/` folders (`pages`, `reports`, `tables`) in VS Code.
  - [`02_DefinicionesDeBC.md`](./02_DefinicionesDeBC.md) — Overview of Business Central core objects (`Tables`, `Codeunits`) and VS Code shortcuts.
  - [`03_TiposDeDatos.md`](./03_TiposDeDatos.md) — Reference on AL data types (numeric, string, `Date`, `Time`, `DateTime`, `Duration`, and `DateFormula` expressions).

---

## Additional Notes

### Building and Publishing an AL Extension

> [!TIP]
> Ensure the **AL Language extension for Microsoft Dynamics 365 Business Central** is installed in Visual Studio Code and that your target Business Central Docker container or sandbox instance is running before downloading symbols.

1. Open the desired project directory (for example, `businesscentral/05_WDTU-DAM2B-25-26`) in Visual Studio Code.
2. Update `.vscode/launch.json` to match your Business Central server URL and instance name.
3. Open the Command Palette (`Ctrl+Shift+P`) and run **`AL: Download Symbols`**.
4. Run **`AL: Publish without debugging`** (`Ctrl+F5`) or **`AL: Publish with debugging`** (`F5`) to compile the `.app` package and deploy it to Business Central.
