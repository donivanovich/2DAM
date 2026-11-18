# Data Access (`accesodatos`)

This directory contains coursework and projects for the **Data Access** (*Acceso a Datos*) module. It covers relational database querying, user and privilege administration (DCL), Python database connectivity, Object-Relational Mapping (ORM) with SQLAlchemy using a layered Repository architecture, and a containerized RESTful API using Flask and MongoDB.

---

## Technologies and Tools

### Programming Languages
- **Python 3**
- **SQL** (MySQL and Oracle SQL dialects)

### Frameworks and Libraries
- **SQLAlchemy** (`declarative_base`, `Session`, `relationship`) — Object-Relational Mapping for MySQL.
- **Flask 3.1.0** — Microframework used to expose REST API endpoints.
- **Flask-JWT-Extended 4.7.1 & PyJWT 2.10.1** — JSON Web Token (JWT) authentication and route protection.
- **Flasgger 0.9.7.1** — Interactive OpenAPI / Swagger UI v3 documentation.
- **Flask-CORS 5.0.1** — Cross-Origin Resource Sharing configuration.
- **PyMongo 4.11.1** — Official MongoDB driver for Python.
- **mysql-connector-python** — Official MySQL driver used both directly and as the SQLAlchemy engine dialect (`mysql+mysqlconnector`).
- **bcrypt 4.2.1** — Password hashing and verification.

### Databases
- **MySQL** (specifically targeting the `sakila` sample database).
- **MongoDB** (used for the `Clinica` database in project `07_ApiCitasFlask`).
- **Oracle Database / Oracle APEX** (covered in the SQL reference curriculum).

### Development Tools, Build Systems, and Infrastructure
- **Docker & Docker Compose** — Multi-container orchestration.
- **Nginx** — Reverse proxy server routing external traffic on port `5001` to the Flask application.
- **Gunicorn 23.0.0** — Production WSGI HTTP server.
- **pip** (`requirements.txt`) — Python dependency management.

---

## Projects and Exercises

### 1. `01_Consulta1Repaso`
- **Name:** `01_Consulta1Repaso`
- **Description:** Collection of analytical SQL queries reviewing relational joins, aggregations, grouping, subqueries, and date/time arithmetic on a film rental schema (`sakila`).
- **Technologies:** SQL (MySQL).
- **Key Features:**
  - Retrieves top 10 longest films and the actors starring in the longest film using subqueries and multi-table `JOIN` clauses.
  - Computes most rented films overall, per staff member, and per store.
  - Identifies stores with the highest customer count and most pending returns (`return_date IS NULL`).
  - Calculates the longest rental duration in minutes via `TIMESTAMPDIFF(MINUTE, rental_date, return_date)` and filters films with even duration (`length % 2 = 0`).
- **Location:** [`./01_Consulta1Repaso`](./01_Consulta1Repaso)

### 2. `02_UsuariosPermisosSakila`
- **Name:** `02_UsuariosPermisosSakila`
- **Description:** SQL Data Control Language (DCL) script implementing role-based database users, views, and granular table/column privileges on the `sakila` database.
- **Technologies:** SQL (MySQL DCL & Views).
- **Key Features:**
  - Creates four restricted database accounts (`usr_personal`, `usr_alquileres`, `usr_inventario`, `usr_admin`).
  - Defines a security view `v_staff_seguro` to expose non-sensitive staff columns while hiding personal data such as photos.
  - Assigns table-level and column-level permissions (`GRANT SELECT`, `INSERT`, `UPDATE (email, active)`, `DELETE`, and `ALL PRIVILEGES ... WITH GRANT OPTION`).
  - Queries `mysql.db`, `mysql.tables_priv`, and `mysql.columns_priv` system tables to audit granted privileges.
- **Location:** [`./02_UsuariosPermisosSakila`](./02_UsuariosPermisosSakila)

### 3. `03_ConsultasUsuariosSakila`
- **Name:** `03_ConsultasUsuariosSakila`
- **Description:** Role-based access verification suite combining a MySQL user-provisioning script with three Python client scripts that test permitted and forbidden queries for each user profile.
- **Technologies:** Python, `mysql-connector-python`, SQL (MySQL).
- **Key Features:**
  - `usuariosPermisosSakila.sql` provisions three MySQL users (`usuario_estandar`, `trabajador_videoclub`, `trabajador_encargado`) with distinct `SELECT` grants on `sakila` tables.
  - `usuarioEstandar.py` verifies that standard users cannot query `staff` or `payment`, while calculating the top 5 actors by total film length and the film category with the most distinct actors.
  - `trabajadorVideoclub.py` verifies denial of access to `staff` and `customer`, while querying the most/least profitable films and most/least rented films.
  - `usuarioEncargado.py` verifies denial of access to `category` and `actor`, while computing customers with the highest/lowest rental counts and total spending.
- **Location:** [`./03_ConsultasUsuariosSakila`](./03_ConsultasUsuariosSakila)

### 4. `04_UsoBasicoORM`
- **Name:** `04_UsoBasicoORM`
- **Description:** Introductory SQLAlchemy ORM scripts demonstrating declarative entity mapping, one-to-many and many-to-many relationships, and interactive CRUD operations on the `sakila` database.
- **Technologies:** Python, SQLAlchemy, MySQL (`mysql+mysqlconnector`).
- **Key Features:**
  - `orm.py` maps `Film`, `Actor`, `Language`, and the association table `FilmActor`, creating a sample film and actor and querying their bidirectional relationships.
  - `usoBasicoOrm.py` adds `Customer`, `Inventory`, and `Rental` models, providing a CLI prompt to look up or create a customer, list their past film rentals, and register a new rental transaction.
- **Location:** [`./04_UsoBasicoORM`](./04_UsoBasicoORM)

### 5. `05_ORMv2`
- **Name:** `05_ORMv2`
- **Description:** Refactored SQLAlchemy ORM application structured into dedicated `Models/` and `Repositories/` packages to separate persistence logic from the command-line workflow.
- **Technologies:** Python, SQLAlchemy, MySQL.
- **Key Features:**
  - Defines modular SQLAlchemy entity classes in `Models/` (`Addresses`, `Base`, `Customers`, `Films`, `Inventories`, `Rentals`, `Stores`).
  - Encapsulates database queries and transactions in `Repositories/` (`CustomerRepository`, `FilmRepository`, `InventoryRepository`, `RentalRepository`).
  - `main.py` parses full customer names (supporting compound first names), retrieves or creates the customer record, displays existing rentals, and processes new film rentals by searching inventory availability.
- **Location:** [`./05_ORMv2`](./05_ORMv2)

### 6. `06_ORMv3`
- **Name:** `06_ORMv3`
- **Description:** Interactive menu-driven video store management system extending the layered SQLAlchemy Repository architecture from `05_ORMv2` with full lifecycle operations.
- **Technologies:** Python, SQLAlchemy, MySQL.
- **Key Features:**
  - Provides a 6-option loop menu in `main.py`:
    1. Register a new customer (`altaNuevoUsuario`).
    2. Rent a film by title (`alquilarPelicula`).
    3. Return/delete a rental by `rental_id` (`devolverPelicula`).
    4. Create a new film record (`crearNuevaPelicula`).
    5. Add a new inventory copy for an existing `film_id` (`darAltaNuevaUnidadPelicula`).
    6. Exit the application.
- **Location:** [`./06_ORMv3`](./06_ORMv3)

### 7. `07_ApiCitasFlask`
- **Name:** `07_ApiCitasFlask`
- **Description:** Production-ready REST API for managing medical clinic users, health centers, and patient appointments, backed by MongoDB and deployed via Docker Compose behind an Nginx reverse proxy.
- **Technologies:** Python, Flask, PyMongo, MongoDB, Flask-JWT-Extended, bcrypt, Flasgger (Swagger UI), Gunicorn, Nginx, Docker, Docker Compose.
- **Key Features:**
  - User registration (`POST /register`) with `bcrypt` password hashing and `DD/MM/YYYY` birth date validation, plus JWT login (`POST /login`).
  - Authenticated endpoints (`@jwt_required()`) to view user profiles (`GET /profile`), list health centers (`GET /centers`), schedule hourly appointments (`POST /date/create`), list active appointments (`GET /dates`, `GET /date/getByUser`, `POST /date/getByDay`), and soft-cancel appointments (`POST /date/delete` setting `cancel: 1`).
  - Database initialization endpoint (`GET /migracion`) and migration script (`migrations/001_init_clinica.py`) that seed collections (`usuarios`, `centros`, `citas`) and initial health centers.
  - Built-in interactive Swagger UI documentation exposed at `/apidocs/`.
- **Location:** [`./07_ApiCitasFlask`](./07_ApiCitasFlask)

---

## Additional Notes

### SQL Reference Curriculum Summary
In addition to the practical projects above, this module covers the 20-unit Oracle Academy SQL curriculum:
1. **Relational Database Concepts & SQL Anatomy** (`SELECT`, projection, selection, arithmetic expressions, `NULL`, column aliases).
2. **Filtering & Sorting** (`WHERE`, `BETWEEN`, `IN`, `LIKE`, `IS NULL`, logical precedence, `ORDER BY`, `NULLS FIRST/LAST`).
3. **Single-Row Functions** (Case/character manipulation, `ROUND`, `TRUNC`, `MOD`, date arithmetic, `SYSDATE`, `MONTHS_BETWEEN`, `ADD_MONTHS`).
4. **Conversion & Conditional Expressions** (`TO_CHAR`, `TO_NUMBER`, `TO_DATE`, `NVL`, `NVL2`, `NULLIF`, `COALESCE`, `CASE`, `DECODE`).
5. **Joins & Aggregations** (`INNER JOIN`, `LEFT/RIGHT/FULL OUTER JOIN`, self-joins, hierarchical queries, `GROUP BY`, `HAVING`, `ROLLUP`, `CUBE`, `GROUPING SETS`, set operators).
6. **Subqueries, DML, DDL, Constraints, and Database Objects** (Single/multi-row and correlated subqueries, `INSERT/UPDATE/DELETE/MERGE`, table creation, constraints, Views, Sequences, Indexes, Synonyms, DCL privileges, Regular Expressions, and TCL transactions).

### Database & Execution Setup

> [!IMPORTANT]
> Scripts in `03_ConsultasUsuariosSakila`, `04_UsoBasicoORM`, `05_ORMv2`, and `06_ORMv3` connect to a local MySQL instance on port **`3309`** (`localhost:3309/sakila`) by default. Update `DB_PORT` or the SQLAlchemy connection URI if your local MySQL server runs on port `3306`.

#### Running `07_ApiCitasFlask` with Docker Compose

```bash
cd accesodatos/07_ApiCitasFlask
docker-compose up --build
```

Once the containers are running, the API is accessible through Nginx at `http://localhost:5001` and the Swagger UI documentation is available at `http://localhost:5001/apidocs/`.

#### Running `07_ApiCitasFlask` Locally

```bash
cd accesodatos/07_ApiCitasFlask
pip install -r requirements.txt
python migrations/001_init_clinica.py
python application.py
```
