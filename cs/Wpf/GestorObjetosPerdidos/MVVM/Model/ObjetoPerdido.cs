using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestorObjetosPerdidos.MVVM.Model
{
    public class ObjetoPerdido : INotifyPropertyChanged
    {
        private string _nombre;
        private string _categoria;
        private DateTime _fechaHallazgo;
        private string _ubicacionHallazgo;
        private string _descripcion;
        private string _imagenPath;
        private bool _devuelto;

        public string Nombre
        {
            get => _nombre;
            set { _nombre = value; OnPropertyChanged(); }
        }

        public string Categoria
        {
            get => _categoria;
            set { _categoria = value; OnPropertyChanged(); }
        }

        public DateTime FechaHallazgo
        {
            get => _fechaHallazgo;
            set { _fechaHallazgo = value; OnPropertyChanged(); }
        }

        public string UbicacionHallazgo
        {
            get => _ubicacionHallazgo;
            set { _ubicacionHallazgo = value; OnPropertyChanged(); }
        }

        public string Descripcion
        {
            get => _descripcion;
            set { _descripcion = value; OnPropertyChanged(); }
        }

        public string ImagenPath
        {
            get => _imagenPath;
            set { _imagenPath = value; OnPropertyChanged(); }
        }

        public bool Devuelto
        {
            get => _devuelto;
            set { _devuelto = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string nombre = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }
}
