using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfProyectoLiga
{
    public class ResultadoViewModel : INotifyPropertyChanged
    {
        private readonly ApiService _api;
        public ObservableCollection<ResultadoModel> listaResultados { get; set; }
        private bool _estaCargando;
        public ICommand CargarTablaCommand { get; }

        public ResultadoViewModel()
        {
            _api = new ApiService();
            listaResultados = new ObservableCollection<ResultadoModel>();
            CargarTablaCommand = new RelayCommand(async obj => await CargarResultados());

        }

        public bool EstaCargando
        {
            get => _estaCargando;
            set
            {
                if (_estaCargando != value)
                {
                    _estaCargando = value;
                    OnPropertyChanged();
                }
            }
        }

        private async Task CargarResultados()
        {
            EstaCargando = true;
            listaResultados.Clear();

            var lista = await _api.ObtenerResultadosPartidos();

            // Agregamos los resultados directamente al ObservableCollection
            foreach (var resultado in lista)
            {
                listaResultados.Add(resultado);
            }

            EstaCargando = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nombre = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}

