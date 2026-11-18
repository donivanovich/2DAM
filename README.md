# 2DAM — Multiplatform Application Development Coursework

This repository contains the academic coursework, practical exercises, laboratory assignments, and full-stack projects completed during the second year of the **Multiplatform Application Development** (*Desarrollo de Aplicaciones Multiplataforma* — **2DAM**) higher vocational degree.

The codebase spans relational and NoSQL database access, native Android mobile development, ERP customization with Microsoft Dynamics 365 Business Central, Windows desktop user interface development (WPF and Windows Forms), business intelligence data modeling with Power BI, and backend REST API engineering with Python.

> [!NOTE]
> Each subject directory is organized sequentially by module or project type and contains its own `README.md` with detailed technical documentation, architecture notes, and setup instructions.

---

## Repository Structure

```text
2DAM/
├── accesodatos/                        # Data Access (SQL, MySQL, SQLAlchemy ORM, Flask + MongoDB)
│   ├── 01_Consulta1Repaso/
│   ├── 02_UsuariosPermisosSakila/
│   ├── 03_ConsultasUsuariosSakila/
│   ├── 04_UsoBasicoORM/
│   ├── 05_ORMv2/
│   ├── 06_ORMv3/
│   ├── 07_ApiCitasFlask/
│   └── README.md
├── android/                            # Mobile Application Development (Kotlin, Jetpack Compose)
│   ├── 01_ListarContactos/
│   ├── 02_Tiempo/
│   ├── 03_HiatoApp/
│   ├── 04_FilmBros/
│   └── README.md
├── businesscentral/                    # ERP Management Systems (Microsoft Dynamics 365 BC, AL)
│   ├── 00_Examen/
│   ├── 01_HelloWorld/
│   ├── 02_PrimerAL/
│   ├── 03_PruebaDocker/
│   ├── 04_Docker/
│   ├── 05_WDTU-DAM2B-25-26/
│   ├── 06_AprendeBusinessCentral/
│   ├── 07_TiendaInformatica/
│   └── README.md
├── interfaces/                         # User Interface Development (C#, .NET 8, WPF, XAML, MVVM)
│   ├── Wpf00_Examen/
│   ├── Wpf01_PrimerProyecto/
│   ├── Wpf02_AplicacionPerfilConFoto/
│   ├── Wpf03_AgendaPersonal/
│   ├── Wpf04_MiniBiblioteca/
│   ├── Wpf05_Spotify/
│   ├── Wpf06_ProyectoLiga/
│   ├── Wpf07_PracticaEstilos/
│   ├── Wpf08_GestorObjetosPerdidos/
│   ├── Wpf09_ConectarDB/
│   ├── Wpf10_Shawarmas/
│   └── README.md
├── powerbi/                            # Business Intelligence & Data Analytics (Power BI, Star Schema)
│   ├── 00_Examen/
│   ├── 01_RetailModaSA/
│   ├── 02_StreamVibes/
│   ├── 03_AppolDatos/
│   ├── 04_Zaro/
│   ├── 05_ModeloEnEstrella/
│   ├── 06_Shawarmas/
│   └── README.md
├── programacion/                       # Python Programming & REST APIs (Python, Flask, SQLAlchemy, MongoDB)
│   ├── 00_Examen/
│   ├── 01_HelloWorld/
│   ├── 02_ListasYBucles/
│   ├── 03_Diccionarios/
│   ├── 04_Funciones/
│   ├── 05_FicherosYExcepciones/
│   ├── 06_FuncionesPropias/
│   ├── 07_PeticionesYAPI/
│   ├── 08_EntornosVirtuales/
│   ├── 09_ClasesYObjetos/
│   ├── 10_Flask/
│   ├── 11_LaLigaManagement/
│   └── README.md
├── visualbasic/                        # Desktop, Systems & Database Programming (VB.NET, .NET Framework)
│   ├── Application/
│   ├── Console/
│   ├── Databases/
│   ├── Forms/
│   └── README.md
├── .gitignore
└── README.md
```

---

## Subjects

- [`accesodatos`](./accesodatos/README.md) — Relational database querying, role-based access control (DCL) on the MySQL Sakila database, object-relational mapping with SQLAlchemy using the Repository pattern, and a containerized Flask + MongoDB medical appointment REST API.
- [`android`](./android/README.md) — Native Android applications built with Kotlin and Jetpack Compose, implementing MVVM architecture, reactive state management (`StateFlow`), Room local persistence, Retrofit REST integration, and a Flask/MongoDB backend for shared expense tracking.
- [`businesscentral`](./businesscentral/README.md) — Extensions and ERP solutions developed in the AL language for Microsoft Dynamics 365 Business Central, including custom tables, card and list pages, enums, table extensions, and Word-layout reports.
- [`interfaces`](./interfaces/README.md) — Windows desktop applications built with C#, .NET 8, and WPF (XAML), focusing on the MVVM pattern, data binding, custom control templates, animations, JSON file persistence, REST API consumption, and MySQL stored procedure execution.
- [`powerbi`](./powerbi/README.md) — Business intelligence dashboards and analytical reports created in Microsoft Power BI Desktop (`.pbix`), covering star-schema dimensional modeling across retail, streaming, healthcare, banking, logistics, and hospitality datasets.
- [`programacion`](./programacion/README.md) — Python programming progression from core data structures, file I/O, and HTTP client requests to full-stack client-server applications using Flask, JWT authentication, MongoDB, and Flask-SQLAlchemy with MySQL.
- [`visualbasic`](./visualbasic/README.md) — Visual Basic .NET (`.NET Framework`) console and Windows Forms applications covering object-oriented programming, MS Access database creation via ADOX/ADODB and OLE DB, 3DES cryptography, multi-threaded SMTP email dispatch, TCP sockets, thread synchronization, and custom user controls.

---

## Technologies Overview

| Category | Technologies Used |
| :--- | :--- |
| **Programming Languages** | Python, Kotlin, C#, Visual Basic .NET (VB.NET), AL (Application Language), SQL, XAML |
| **Mobile & Desktop UI** | Android SDK, Jetpack Compose, Material 3, WPF (.NET 8), Windows Forms (.NET Framework) |
| **Backend & Web Frameworks** | Flask, Flask-JWT-Extended, Flask-CORS, Flasgger (Swagger UI v3), Gunicorn |
| **ORM & Data Access** | SQLAlchemy, Flask-SQLAlchemy, Flask-Migrate (Alembic), Room Persistence Library, PyMongo, `mysql-connector-python`, `MySql.Data`, ADO.NET / OLE DB / ADOX / ADODB |
| **Databases** | MySQL (Sakila & custom schemas), MongoDB, SQLite (via Android Room), Microsoft Access (`.accdb`, `.mdb`), Oracle SQL |
| **Networking & Serialization** | Retrofit 2, OkHttp, Kotlinx Serialization, Gson, `HttpClient` (.NET), `requests` (Python), `System.Net.Sockets` (TCP), `System.Net.Mail` (SMTP) |
| **ERP & Business Intelligence** | Microsoft Dynamics 365 Business Central, Microsoft Power BI Desktop |
| **DevOps, Build & Tooling** | Docker, Docker Compose, Nginx, Gradle (Kotlin DSL & Version Catalogs), KSP, MSBuild / Visual Studio, VS Code, `virtualenv` / `pip`, Git |

---

## Additional Information

- **Naming Conventions:** Projects inside each subject directory follow a numeric prefix convention (e.g., `01_`, `Wpf01_`, `Cls01_`, `Db01_`, `Frm01_`) to reflect the chronological progression of topics and assessments (`00_Examen`).
- **Environment Configuration:** Several full-stack and database-backed projects rely on local services (MySQL on port `3306` or `3309`, MongoDB on port `27017`, or Docker containers) and environment variable templates (`.env.example`). Refer to each subject's `README.md` for specific port and connection requirements.
