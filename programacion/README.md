# Python Programming & REST APIs (`programacion`)

This directory contains Python coursework, practical deliverables (`Entrega1` through `Entrega6`), examination scripts, and full-stack client-server applications. The curriculum progresses from core Python syntax, data structures, file I/O, and object-oriented programming to consuming and building RESTful APIs with **Flask**, **JWT authentication**, **MongoDB**, and **Flask-SQLAlchemy** with **MySQL**.

---

## Technologies and Tools

### Programming Languages
- **Python 3**
- **SQL** (MySQL schema and seed script in `11_LaLigaManagement/orm/PYBancoProyecto.sql`)

### Frameworks and Libraries
- **Flask 3.1.2** — Web microframework for building REST APIs (`10_Flask`, `11_LaLigaManagement`).
- **Flask-SQLAlchemy 3.1.1 & SQLAlchemy 2.0.44** — ORM integration for the relational backend of `11_LaLigaManagement/orm`.
- **Flask-Migrate 4.1.0 & Alembic 1.18.4** — Database schema migration support.
- **Flask-JWT-Extended 4.7.1 & PyJWT 2.11.0** — JWT authentication and role-based access control.
- **Flask-CORS 6.0.2** — Cross-Origin Resource Sharing middleware.
- **PyMongo 4.16.0** — MongoDB driver used in `11_LaLigaManagement/server`.
- **PyMySQL 1.1.2 & mysql-connector-python 9.5.0** — MySQL database drivers used in `11_LaLigaManagement/orm`.
- **requests 2.32.5** — HTTP client library used across API exercises, exams, and the CLI client.
- **bcrypt 5.0.0** — Password hashing library.
- **python-dotenv 1.2.1** — Environment variable loader.

### Databases
- **MongoDB** (`pybancodb` database with `users`, `presidentes`, `jugadores`, and `pagos` collections).
- **MySQL** (`PYBancoProyecto` database with `entrenadores`, `jugadores`, `pagos`, `presidentes`, and `users` tables).

### Development Tools and Environment Management
- **virtualenv** (`python -m virtualenv`) & **pip** (`requirements.txt`).

---

## Projects and Exercises

### 1. `00_Examen`
- **Name:** `00_Examen`
- **Description:** Practical examination script (`examen.py`) that authenticates against a local REST API (`http://127.0.0.1:5000/`) and cross-references users, posts, and comments.
- **Technologies:** Python, `requests`, `json`.
- **Key Features:**
  - Authenticates via `POST /login` and queries `/users`, `/comments`, and `/posts`.
  - `ejercicio1()` counts how many posts the user `alan_turing` has not commented on.
  - `ejercicio2()` finds a specific comment by author and keyword (`'locura'`) and filters users whose ID is less than or equal to that comment's ID.
- **Location:** [`./00_Examen`](./00_Examen)

### 2. `01_HelloWorld`
- **Name:** `01_HelloWorld`
- **Description:** Foundational Python exercises covering variables, primitive data types, string manipulation, user input, conditional branching, and the first graded deliverable (`Entrega1.py`).
- **Technologies:** Python 3.
- **Key Features:**
  - Includes `TiposDeDatos.py`, `Strings.py`, `SaludarUser.py`, `Condicionales.py`, and `Entrega1.py`.
- **Location:** [`./01_HelloWorld`](./01_HelloWorld)

### 3. `02_ListasYBucles`
- **Name:** `02_ListasYBucles`
- **Description:** Exercises on list manipulation, `for`/`while` loops, ASCII geometric shape rendering, and the second practical deliverable (`Entrega2.py`).
- **Technologies:** Python 3.
- **Key Features:**
  - Includes `Listas.py`, `Bucles.py`, `FormasGeometricas.py`, and `Entrega2.py`.
- **Location:** [`./02_ListasYBucles`](./02_ListasYBucles)

### 4. `03_Diccionarios`
- **Name:** `03_Diccionarios`
- **Description:** Exercises on key-value dictionary operations, nested structures, iteration, and the third practical deliverable (`Entrega3.py`).
- **Technologies:** Python 3.
- **Key Features:**
  - Includes `Diccionarios.py` and `Entrega3.py`.
- **Location:** [`./03_Diccionarios`](./03_Diccionarios)

### 5. `04_Funciones`
- **Name:** `04_Funciones`
- **Description:** Exercises on defining reusable functions, parameters, return values, and the fourth practical deliverable (`Entrega4.py`).
- **Technologies:** Python 3.
- **Key Features:**
  - Includes `Funciones.py` and `Entrega4.py`.
- **Location:** [`./04_Funciones`](./04_Funciones)

### 6. `05_FicherosYExcepciones`
- **Name:** `05_FicherosYExcepciones`
- **Description:** File reading/writing (`open`, context managers) and structured exception handling (`try`/`except`) exercises, including `Entrega5.py`.
- **Technologies:** Python 3.
- **Key Features:**
  - Includes `Ficheros.py`, `Excepciones.py`, and `Entrega5.py`.
- **Location:** [`./05_FicherosYExcepciones`](./05_FicherosYExcepciones)

### 7. `06_FuncionesPropias`
- **Name:** `06_FuncionesPropias`
- **Description:** Modular programming exercise demonstrating custom Python modules and imports across files.
- **Technologies:** Python 3.
- **Key Features:**
  - Defines arithmetic functions in `calculadora.py` and imports them into `UsoDeFunciones.py`.
- **Location:** [`./06_FuncionesPropias`](./06_FuncionesPropias)

### 8. `07_PeticionesYAPI`
- **Name:** `07_PeticionesYAPI`
- **Description:** HTTP client exercises interacting with the `JSONPlaceholder` REST API (`https://jsonplaceholder.typicode.com/`) to perform CRUD operations, data aggregation, and JSON backup/restore routines.
- **Technologies:** Python 3, `requests`, `json`.
- **Key Features:**
  - `Api.py` implements 12 functions querying and mutating `/users`, `/posts`, `/comments`, and `/photos`, including exporting posts with nested comments to `archivo.json` and restoring them via `POST` requests.
  - Also includes `Peticiones.py` and `Entrega6.py`.
- **Location:** [`./07_PeticionesYAPI`](./07_PeticionesYAPI)

### 9. `08_EntornosVirtuales`
- **Name:** `08_EntornosVirtuales`
- **Description:** Practical workspace and documentation (`README.md`) for creating, activating, exporting (`pip freeze`), and managing isolated Python virtual environments (`00_venv`, `01_venv`).
- **Technologies:** Python 3, `virtualenv`, `pip`.
- **Key Features:**
  - Documents cross-platform virtual environment workflows for Windows PowerShell (`Set-ExecutionPolicy`) and macOS/Linux.
- **Location:** [`./08_EntornosVirtuales`](./08_EntornosVirtuales)

### 10. `09_ClasesYObjetos`
- **Name:** `09_ClasesYObjetos`
- **Description:** Object-Oriented Programming (OOP) exercises in Python covering class definitions, constructors (`__init__`), instance attributes, and methods.
- **Technologies:** Python 3.
- **Key Features:**
  - Implemented in `ClasesYObjetos.py`.
- **Location:** [`./09_ClasesYObjetos`](./09_ClasesYObjetos)

### 11. `10_Flask`
- **Name:** `10_Flask`
- **Description:** Minimal Flask web server starter project (`application.py`) exposing a root `"/"` endpoint returning `"<p>Hello, World!</p>"`.
- **Technologies:** Python 3, Flask.
- **Key Features:**
  - Introduces Flask application instantiation and `@application.route("/")` decorator routing.
- **Location:** [`./10_Flask`](./10_Flask)

### 12. `11_LaLigaManagement`
- **Name:** `11_LaLigaManagement`
- **Description:** Full-stack football league financial and club management system featuring an interactive CLI client (`client/`), a MongoDB + JWT REST API server (`server/`), and a relational Flask-SQLAlchemy + MySQL backend (`orm/`) using Blueprints, Repositories, and Services.
- **Technologies:** Python 3, Flask, Flask-JWT-Extended, Flask-CORS, PyMongo (MongoDB), Flask-SQLAlchemy, Flask-Migrate, PyMySQL (MySQL), `bcrypt`, `requests`, `python-dotenv`.
- **Key Features:**
  - **MongoDB REST Server (`server/application.py`):** Provides JWT authentication (`login`/`register`), role-based access (`admin`/`user`), and CRUD operations for club presidents (`presidentes`), players (`jugadores`), and player payments (`pagos`) in the `pybancodb` database.
  - **Relational ORM Server (`orm/app.py`):** Implements an application-factory Flask backend backed by MySQL (`PYBancoProyecto.sql`) with SQLAlchemy models (`entrenador`, `jugador`, `pago`, `presidente`, `user`), repository classes (`repositories/`), service layer (`services/entrenador_service.py`), and modular Flask Blueprints (`routes/`).
  - **Interactive Console Client (`client/main.py`):** Consumes the REST API via `requests` and renders formatted ASCII tables in the terminal.
- **Location:** [`./11_LaLigaManagement`](./11_LaLigaManagement)

---

## Additional Notes

### Running `11_LaLigaManagement`

```bash
# 1. Start the MongoDB REST Server
cd programacion/11_LaLigaManagement/server
pip install -r requirements.txt
python application.py

# 2. (Alternative) Start the MySQL ORM Server
cd programacion/11_LaLigaManagement/orm
pip install -r requirements.txt
python app.py

# 3. Run the Interactive Console Client
cd programacion/11_LaLigaManagement/client
pip install -r requirements.txt
python main.py
```

> [!NOTE]
> For the `11_LaLigaManagement/orm` backend, execute `PYBancoProyecto.sql` on your local MySQL server (`localhost/PYBancoProyecto`) to create and seed the `entrenadores`, `jugadores`, `pagos`, `presidentes`, and `users` tables with the 20 LaLiga clubs.
