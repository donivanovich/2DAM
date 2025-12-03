using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf04_MiniBiblioteca.MVVM.Model;

namespace Wpf04_MiniBiblioteca.MVVM.ViewModel
{
    public class LibrosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Libro> Libros { get; set; }

        private Libro _libroSeleccionado;

        public LibrosViewModel()
        {
            Libros = new ObservableCollection<Libro>()
            {
                new Libro { Titulo = "Lazarillo de Tormes", Autor = new Autor { Nombre = "Anónimo" }, Publicacion = DateTime.Now, Descripcion = "Super especial este libro", Imagen = "imagenes/lazarillo.jpg"},
                new Libro { Titulo = "Don Quijote de La Mancha", Autor = new Autor { Nombre = "Miguel de Cervantes" }, Publicacion = DateTime.Now, Descripcion = "En un lugar de La Mancha", Imagen = "imagenes/donquijote.jpg"},
                new Libro { Titulo = "El Principito", Autor = new Autor { Nombre = "Antoine de Saint-Exupéry" }, Publicacion = DateTime.Now, Descripcion = "Con las acuarelas originales", Imagen = "imagenes/elprincipito.jpg"},
                new Libro { Titulo = "Vuelos", Autor = new Autor { Nombre = "Antoine de Saint-Exupéry" }, Publicacion = DateTime.Now, Descripcion = "Otra obra famosa", Imagen = "imagenes/vuelos.jpg" }
            };

            // Asignamos el comando al método AgregarLibro
            AgregarLibroCommand = new RelayCommand(AgregarLibro);
        }

        public IEnumerable<string> NombresAutoresUnicos
        {
            get
            {
                return Libros.Select(l => l.Autor.Nombre).Distinct();
            }
        }

        //CREAR UN GETTER Y SETTER PARA LIBRO SELECCIONADA
        public Libro LibroSeleccionado
        {
            get => _libroSeleccionado;
            set
            {
                _libroSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarLibroCommand { get; }

        private string _nuevoTitulo;
        private string _nuevoAutor;

        public string NuevoTitulo
        {
            get => _nuevoTitulo;
            set
            {
                _nuevoTitulo = value;
                OnPropertyChanged();
            }
        }

        public string NuevoAutor
        {
            get => _nuevoAutor;
            set
            {
                _nuevoAutor = value;
                OnPropertyChanged();
            }
        }

        private void AgregarLibro(object parameter)
        {
            Libros.Add(
                new Libro
                {
                    Titulo = "NuevoTitulo",
                    Autor = new Autor { Nombre = "NuevoAutor" },
                    Publicacion = DateTime.Now,
                    Descripcion = "NuevaDescripcion",
                    Imagen = "NuevaPath"
                });
            NuevoTitulo = string.Empty;
            NuevoAutor = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string titulo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(titulo));
        }
    }
}
