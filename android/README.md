# Mobile Application Development (`android`)

This directory contains native Android applications developed in **Kotlin** using **Jetpack Compose**. The projects progress from declarative UI layouts and navigation basics to full-featured applications integrating the **MVVM (Model-View-ViewModel)** pattern, reactive state flows (`StateFlow`), local SQLite persistence with **Room**, remote REST API consumption via **Retrofit**, and a custom **Flask + MongoDB** backend.

---

## Technologies and Tools

### Programming Languages
- **Kotlin** (JVM Target 11)
- **Python 3** (used for the custom backend server in `03_HiatoApp/server`)

### Frameworks and Libraries
- **Jetpack Compose & Material 3** (`androidx.compose.material3`, `material-icons-extended`) — Declarative UI toolkit.
- **Jetpack Navigation Compose** (`androidx.navigation:navigation-compose`) — Screen navigation, including Kotlin Serialization type-safe routes.
- **Android Architecture Components** (`ViewModel`, `SavedStateHandle`, `StateFlow`) — Lifecycle-aware state management.
- **Room Persistence Library** (`room-runtime`, `room-ktx`, `room-paging`, `room-compiler`) — Local SQLite database abstraction layer.
- **Retrofit 2 & OkHttp 3** (`retrofit`, `retrofit2-kotlinx-serialization-converter`, `converter-gson`, `logging-interceptor`) — Type-safe HTTP client for REST APIs.
- **Kotlinx Serialization & Coroutines** (`kotlinx-serialization-json`, `kotlinx-coroutines-android`) — Asynchronous programming and JSON deserialization.
- **Coil** (`io.coil-kt:coil-compose:2.7.0`) — Asynchronous image loading in Compose.
- **Flask, Flask-JWT-Extended, PyMongo, bcrypt, python-dotenv** — Python backend stack for `03_HiatoApp/server`.

### Databases
- **SQLite** (on-device database managed via Room in `03_HiatoApp` and `04_FilmBros`).
- **MongoDB Atlas** (`mongodb+srv` cluster used by `03_HiatoApp/server`).

### Build Systems and Development Tools
- **Gradle** (Kotlin DSL `build.gradle.kts` with `libs.versions.toml` version catalogs and Gradle Wrapper).
- **KSP (Kotlin Symbol Processing)** — Annotation processing for Room DAO and database generation.
- **Android Studio / Android SDK** (`compileSdk = 36`, `targetSdk = 36`, `minSdk = 24` / `29`).

---

## Projects and Exercises

### 1. `01_ListarContactos`
- **Name:** `01_ListarContactos` (`com.mrh.listarcontactos`)
- **Description:** Introductory Jetpack Compose contact directory app demonstrating list rendering, reusable UI cards, and parameterized route navigation.
- **Technologies:** Kotlin, Jetpack Compose, Material 3, Navigation Compose, Coil.
- **Key Features:**
  - Models contact records (`Contacto.kt`) with name, surname, email, phone number (`BigInteger`), and optional drawable avatar resource.
  - Renders a scrollable contact list (`ContactosList.kt`) using custom row cards (`ContactoRowCard.kt`).
  - Implements a `NavHost` (`AppNavigation.kt`) to navigate from the main `"lista"` route to `"detalle/{nombre}"` (`DetalleContacto.kt`).
- **Location:** [`./01_ListarContactos`](./01_ListarContactos)

### 2. `02_Tiempo`
- **Name:** `02_Tiempo` (`com.mrh.tiempodam`)
- **Description:** Weather dashboard and temperature unit converter application built as a practical reference for MVVM architecture, `StateFlow` state encapsulation, and type-safe navigation in Jetpack Compose.
- **Technologies:** Kotlin, Jetpack Compose, Material 3, ViewModel, `SavedStateHandle`, `StateFlow`, Kotlinx Serialization, Navigation Compose.
- **Key Features:**
  - Encapsulates mutable UI state (`MutableStateFlow`) inside ViewModels (`CityListWeatherViewModel`, `ClimaDetailViewModel`, `ConverterViewModel`) and exposes read-only `StateFlow` streams to Compose screens.
  - Uses `@Serializable` destination objects (such as `ClimaDetailDestination`) for type-safe navigation between `CityListWeatherScreen`, `CityDetailScreen`, and `ConverterScreen`.
  - Extracts navigation route arguments directly inside `ClimaDetailViewModel` using `savedStateHandle.toRoute<ClimaDetailDestination>()`.
- **Location:** [`./02_Tiempo`](./02_Tiempo)

### 3. `03_HiatoApp`
- **Name:** `03_HiatoApp` (`com.example.hiato`)
- **Description:** Full-stack group expense management application consisting of an Android Jetpack Compose client and a Python Flask + MongoDB REST API server.
- **Technologies:**
  - **Android Client:** Kotlin, Jetpack Compose, Material 3, Navigation Compose, ViewModel, Retrofit 2, OkHttp, Kotlinx Serialization, Gson, Room, Coil, Coroutines.
  - **Backend Server (`server/`):** Python, Flask, Flask-JWT-Extended, PyMongo (MongoDB Atlas), `python-dotenv`, `bcrypt`.
- **Key Features:**
  - **MVVM Client Architecture:** Organizes models (`User`, `Grupo`, `Gasto`, `GastoUser`), views (`LoginView`, `MainView`, `GruposView`, `GastosView`, `AmigosView`, `IntegrantesView`, `CuentaView`), and corresponding ViewModels with a `BottomNavigationBar`.
  - **Remote API Integration:** Communicates with the backend via `ApiService.kt` and `Repository.kt` to authenticate users and manage expense groups, shared expenses, and group participants.
  - **Flask Backend (`server/application.py`):** Exposes REST endpoints for authentication (`POST /login`, `POST /signup`), user management (`GET /users`, `PUT /users/<user_id>`), group creation (`GET /grupos`, `POST /grupos`), expenses (`GET /gastos`, `POST /gastos`), and user-expense assignments (`GET /gastos_users`, `POST /gastos_users`).
- **Location:** [`./03_HiatoApp`](./03_HiatoApp)

### 4. `04_FilmBros`
- **Name:** `04_FilmBros` (`com.example.filmbrosproject`)
- **Description:** Movie discovery, review, and watchlist management Android application combining remote movie catalog data from The Movie Database (TMDB) REST API with local user accounts, reviews, and custom watchlists stored in a Room SQLite database.
- **Technologies:** Kotlin, Jetpack Compose, Material 3, Navigation Compose, Room (with KSP), Retrofit 2, Kotlinx Serialization, Coil.
- **Key Features:**
  - **Remote Movie Catalog:** Fetches popular movies (`GET movie/popular` with `es-ES` localization) using `MovieApiService.kt` and Retrofit.
  - **Local Persistence with Room:** Stores users (`User`), local movie reviews (`ReviewEntity`), and custom watchlists (`WatchlistEntity`) via `AppDatabase.kt` and `UserDao.kt`.
  - **Multi-Screen Navigation (`AppNavigation.kt`):** Supports user login and password updates (`LoginScreen`), featured home catalog (`HomeScreen`), full movie browsing (`AllMoviesScreen`), movie details combining API and local reviews (`MovieDetailScreen`), personal review management with edit/delete actions (`UserReviewsScreen`), and custom watchlist management (`WatchlistScreen`, `WatchlistMoviesScreen`).
- **Location:** [`./04_FilmBros`](./04_FilmBros)

---

## Additional Notes

### Building the Android Projects
Each Android project includes the Gradle Wrapper (`gradlew` and `gradlew.bat`) and can be opened directly in Android Studio or built from the terminal:

```bash
cd android/04_FilmBros
./gradlew assembleDebug
```

### Running the `03_HiatoApp` Flask Backend
To run the backend server for `03_HiatoApp`, configure a `.env` file based on `android/03_HiatoApp/server/.env.example` with your MongoDB credentials (`MONGO_USER`, `MONGO_PASS`, `MONGO_HOST`, `JWT_SECRET_KEY`) and execute:

```bash
cd android/03_HiatoApp/server
pip install -r requirements.txt
python application.py
```

> [!NOTE]
> The `03_HiatoApp` backend listens on port **`8000`** (`app.run(debug=True, port=8000)`).
