# User Interface Development (`interfaces`)

This directory contains Windows desktop applications developed for the **User Interface Development** (*Desarrollo de Interfaces*) module using **C#**, **.NET 8 (`net8.0-windows`)**, and **WPF (Windows Presentation Foundation)** with **XAML**. The projects progress from basic layout containers and event handling to full **MVVM (Model-View-ViewModel)** applications incorporating custom control templates, XAML animations, asynchronous JSON file persistence, REST API consumption, and MySQL stored procedure execution.

---

## Technologies and Tools

### Programming Languages
- **C#** (.NET 8)
- **XAML** (eXtensible Application Markup Language)
- **SQL** (MySQL stored procedure invocation)

### Frameworks and Libraries
- **Windows Presentation Foundation (WPF)** (`net8.0-windows`, `<UseWPF>true</UseWPF>`) — Desktop UI framework.
- **MVVM Core Components** (`INotifyPropertyChanged`, `ICommand`, `RelayCommand`, `ObservableCollection<T>`) — Reactive data binding and command routing.
- **Microsoft.Xaml.Behaviors.Wpf 1.1.135** — XAML interactivity behaviors (used in `Wpf06_ProyectoLiga`).
- **MySql.Data 9.5.0** — ADO.NET MySQL connector (`MySqlConnection`, `MySqlCommand`, `MySqlDataAdapter`, `DataTable`, `DataSet`) used in `Wpf09_ConectarDB`.
- **System.Net.Http (`HttpClient`) & System.Text.Json** — Asynchronous HTTP requests and JSON serialization/deserialization (`Wpf06_ProyectoLiga`, `Wpf08_GestorObjetosPerdidos`).

### Databases and Storage
- **MySQL** (`sakila` database on `localhost:3306` in `Wpf09_ConectarDB`).
- **JSON Local File Storage** (`datos.json` managed asynchronously via `FileService` in `Wpf08_GestorObjetosPerdidos`).

### Build Systems and Development Tools
- **Visual Studio 2022 / .NET SDK (`dotnet`)** — Solution (`.sln`) and project (`.csproj`) management with MSBuild and NuGet.

---

## Projects and Exercises

### 1. `Wpf00_Examen` (`TaskManagerDAM`)
- **Name:** `Wpf00_Examen` (`TaskManagerDAM`)
- **Description:** First-term practical assessment project implementing a task manager desktop application with MVVM architecture.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM (`INotifyPropertyChanged`, `RelayCommand`, `ObservableCollection`).
- **Key Features:**
  - Models task items (`TaskModel.cs`) with title and completion status (`isCompleted`).
  - Manages an `ObservableCollection<TaskModel>` in `MainViewModel.cs` and binds `AddTaskCommand` to create new tasks and clear input fields.
  - Renders the task management view in `PaginaTarea.xaml` hosted inside `MainWindow.xaml`, accompanied by exam specifications (`Examen1Eval_DI2526.pdf`) and reference notes (`apuntes.md`).
- **Location:** [`./Wpf00_Examen`](./Wpf00_Examen)

### 2. `Wpf01_PrimerProyecto`
- **Name:** `Wpf01_PrimerProyecto`
- **Description:** Introductory WPF application demonstrating XAML `Grid` layout definitions, basic controls (`TextBox`, `Button`, `Label`), and code-behind event handling.
- **Technologies:** C#, .NET 8, WPF, XAML.
- **Key Features:**
  - Provides two numeric/text inputs (`txtN1`, `txtN2`) with automatic uppercase conversion on `TextChanged` (`TextBox_TextUpperCase`).
  - Implements click handlers to calculate the sum (`ButtonSumar`) and clear the form (`ButtonVaciar`).
- **Location:** [`./Wpf01_PrimerProyecto`](./Wpf01_PrimerProyecto)

### 3. `Wpf02_AplicacionPerfilConFoto`
- **Name:** `Wpf02_AplicacionPerfilConFoto`
- **Description:** User profile card layout exercise illustrating nested `Grid` rows/columns, `StackPanel` orientation, and embedded image resources.
- **Technologies:** C#, .NET 8, WPF, XAML.
- **Key Features:**
  - Displays a profile avatar (`perfil.jpg`), user name, and email using vertical and horizontal `StackPanel` containers inside a responsive `Grid`.
  - Includes action buttons (`Editar`, `Guardar`, `Cancelar`) and commented reference examples of proportional grid sizing (`*`, `2*`, `Auto`).
- **Location:** [`./Wpf02_AplicacionPerfilConFoto`](./Wpf02_AplicacionPerfilConFoto)

### 4. `Wpf03_AgendaPersonal`
- **Name:** `Wpf03_AgendaPersonal`
- **Description:** Multi-page personal organizer application featuring sidebar `Frame` navigation and MVVM modules for managing contacts and appointments.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM (`RelayCommand`).
- **Key Features:**
  - Uses a two-column `MainWindow.xaml` layout with a navigation sidebar (`Menu`, `Contactos`, `Citas`) and a central `Frame` (`MainFrame`).
  - Organizes domain models (`Cita.cs`, `Contacto.cs`), views (`Menu.xaml`, `Contactos.xaml`, `Citas.xaml`), and ViewModels (`CitasViewModel.cs`, `ContactosViewModel.cs`).
- **Location:** [`./Wpf03_AgendaPersonal`](./Wpf03_AgendaPersonal)

### 5. `Wpf04_MiniBiblioteca`
- **Name:** `Wpf04_MiniBiblioteca`
- **Description:** Digital book library manager implementing the MVVM pattern to browse books with cover images, filter distinct authors, and add new book entries.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM, LINQ.
- **Key Features:**
  - Models books (`Libro.cs`) and authors (`Autor.cs`) with cover artwork assets (`donquijote.jpg`, `elprincipito.jpg`, `lazarillo.jpg`, `vuelos.jpg`, `default.jpg`).
  - `LibrosViewModel.cs` exposes an `ObservableCollection<Libro>`, tracks `LibroSeleccionado`, computes unique author names via LINQ (`NombresAutoresUnicos`), and handles book creation through `AgregarLibroCommand`.
  - Separates UI into `Libros.xaml`, `Autores.xaml`, and `Agregar.xaml` views.
- **Location:** [`./Wpf04_MiniBiblioteca`](./Wpf04_MiniBiblioteca)

### 6. `Wpf05_Spotify`
- **Name:** `Wpf05_Spotify`
- **Description:** Music streaming desktop interface inspired by Spotify, modeling playlists, albums, artists, and tracks with master-detail selection bindings.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM.
- **Key Features:**
  - Defines domain models for `Playlist`, `Album`, `Artist`, and `Track`, plus a bundled sample audio file (`rojo.mp3`).
  - `AppViewModel.cs` seeds playlists and albums, synchronizes `SelectedAlbum`, `SelectedTrack`, and `SelectedArtist` properties via `INotifyPropertyChanged`, and binds `SelectAlbumCommand`.
- **Location:** [`./Wpf05_Spotify`](./Wpf05_Spotify)

### 7. `Wpf06_ProyectoLiga`
- **Name:** `Wpf06_ProyectoLiga`
- **Description:** Football league standings and match results viewer that consumes a live remote JSON endpoint asynchronously using `HttpClient` and MVVM.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM, `System.Net.Http.HttpClient`, `System.Text.Json`, `Microsoft.Xaml.Behaviors.Wpf`.
- **Key Features:**
  - `ApiService.cs` performs asynchronous HTTP `GET` requests against a remote sports server (`liga-tabla.php`) with a 15-second timeout and `CancellationToken` support, deserializing JSON payloads into `EquipoModel` and `ResultadoModel` lists.
  - Exposes data through `TablaLigaViewModel.cs` and `ResultadoViewModel.cs` to `ClasificacionView.xaml` (league table) and `ResultadosView.xaml` (match scores).
- **Location:** [`./Wpf06_ProyectoLiga`](./Wpf06_ProyectoLiga)

### 8. `Wpf07_PracticaEstilos`
- **Name:** `Wpf07_PracticaEstilos`
- **Description:** XAML styling, control templating, and storyboard animation exercise defined in application-wide resources.
- **Technologies:** C#, .NET 8, WPF, XAML (`ControlTemplate`, `Style.Triggers`, `Storyboard`, `DoubleAnimation`).
- **Key Features:**
  - Defines reusable styles in `App.xaml`:
    - `StyleTextBox`: Custom `ControlTemplate` with a rounded `Border` (`CornerRadius="20"`).
    - `StyleButton`: Hover trigger (`IsMouseOver`) that executes a `DoubleAnimation` rotating the button 180 degrees over 0.3 seconds via `RotateTransform`.
    - `StyleEllipse`: Hover trigger that dynamically changes the fill color from blue to red and switches the cursor to a hand pointer.
- **Location:** [`./Wpf07_PracticaEstilos`](./Wpf07_PracticaEstilos)

### 9. `Wpf08_GestorObjetosPerdidos`
- **Name:** `Wpf08_GestorObjetosPerdidos`
- **Description:** Lost-and-found inventory management desktop application featuring asynchronous JSON file persistence, item filtering, image attachments, and multi-page navigation.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM, `System.Text.Json`, Async/Await File I/O.
- **Key Features:**
  - Persists and loads lost item records (`ObjetoPerdido.cs`) asynchronously from `datos.json` via `FileService.cs`, bundling item photos (`cartera.jpg`, `gafas.jpg`, `llaves.jpg`, `mochila.jpg`).
  - `ObjetoPerdidoViewModel.cs` and `EditarObjetoViewModel.cs` manage item listing (`PaginaListadoObjetos.xaml`), item creation/editing (`PaginaEditarObjeto.xaml`), returned-item filtering (`ObjetosDevueltos`), and marking items as returned (`MarcarDevueltoCommand`).
  - Includes comprehensive C# and WPF study notes in `apuntes_csharp_wpf.md`.
- **Location:** [`./Wpf08_GestorObjetosPerdidos`](./Wpf08_GestorObjetosPerdidos)

### 10. `Wpf09_ConectarDB`
- **Name:** `Wpf09_ConectarDB`
- **Description:** Database connectivity layer and WPF front-end for executing MySQL stored procedures on the `sakila` database using `MySql.Data`.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM, ADO.NET (`MySql.Data 9.5.0`), MySQL.
- **Key Features:**
  - `AccesoDatos.cs` provides three overloaded `EjecutarProcedimiento` methods supporting:
    1. Parameterless stored procedures returning a `DataTable`.
    2. Input-parameterized stored procedures (`@param`) returning a `DataSet`.
    3. Stored procedures with both input and `ParameterDirection.Output` parameters returning a `List<Object>`.
- **Location:** [`./Wpf09_ConectarDB`](./Wpf09_ConectarDB)

### 11. `Wpf10_Shawarmas`
- **Name:** `Wpf10_Shawarmas`
- **Description:** Collaborative multi-window WPF desktop application for a restaurant/shawarma brand featuring login, registration, main dashboard navigation, shopping view, configuration settings, and an about screen.
- **Technologies:** C#, .NET 8, WPF, XAML, MVVM.
- **Key Features:**
  - Implements authentication and onboarding windows (`WindowLogin.xaml`, `WindowSignUp.xaml`) with developer/guest mode access and navigation to `WindowMainMenu.xaml`.
  - Organizes domain models (`ModelClient.cs`, `ModelProduct.cs`) and modular views (`ViewShopping.xaml`, `ViewConfiguration.xaml`, `ViewAbout.xaml`) alongside custom branding assets (`res/`) and a milestone tracker (`progressControlVersions.md`).
- **Location:** [`./Wpf10_Shawarmas`](./Wpf10_Shawarmas)

---

## Additional Notes

### Building and Running the WPF Projects

> [!IMPORTANT]
> Because these projects target `net8.0-windows` with `<UseWPF>true</UseWPF>`, they require a **Windows** environment with the **.NET 8.0 Desktop SDK** installed.

You can open any `.sln` file in **Visual Studio 2022** or build and launch a project from the command line using the .NET CLI:

```powershell
cd interfaces/Wpf08_GestorObjetosPerdidos
dotnet build
dotnet run
```

For `Wpf09_ConectarDB`, ensure a local MySQL instance is running on `localhost:3306` with the `sakila` schema loaded before invoking stored procedures.
