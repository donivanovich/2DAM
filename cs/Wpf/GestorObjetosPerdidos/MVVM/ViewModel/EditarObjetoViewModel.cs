using GestorObjetosPerdidos.MVVM.Model;
using GestorObjetosPerdidos.MVVM.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace GestorObjetosPerdidos.MVVM.ViewModel
{
    public class EditarObjetoViewModel : INotifyPropertyChanged
    {
        private readonly FileService _fileService = new FileService();
        private readonly bool _esNuevo;

        public EditarObjetoViewModel() { }

        public EditarObjetoViewModel(ObjetoPerdido objeto)
        {
            _esNuevo = objeto == null;

            Objeto = objeto ?? new ObjetoPerdido
            {
                FechaHallazgo = DateTime.Now
            };

            Categorias = new ObservableCollection<string>
            {
                "Accesorios","Ropa","Documentos","Electrónica","Otros"
            };

            GuardarCommand = new RelayCommand(Guardar);
            VolverCommand = new RelayCommand(Volver);
        }

        private ObjetoPerdido _objeto;
        public ObjetoPerdido Objeto
        {
            get => _objeto;
            set { _objeto = value; OnPropertyChanged(); }
        }

        public ObservableCollection<string> Categorias { get; }

        public ICommand GuardarCommand { get; }
        public ICommand VolverCommand { get; }

        private async void Guardar()
        {
            var lista = new ObservableCollection<ObjetoPerdido>(
                await _fileService.CargarObjetosAsync());

            if (_esNuevo)
            {
                lista.Add(Objeto);
            }
            else
            {
                var existente = lista.FirstOrDefault(o => o.Nombre == Objeto.Nombre);
                if (existente != null)
                {
                    existente.Categoria = Objeto.Categoria;
                    existente.FechaHallazgo = Objeto.FechaHallazgo;
                    existente.UbicacionHallazgo = Objeto.UbicacionHallazgo;
                    existente.Descripcion = Objeto.Descripcion;
                    existente.ImagenPath = Objeto.ImagenPath;
                    existente.Devuelto = Objeto.Devuelto;
                }
            }

            await _fileService.GuardarObjetosAsync(lista.ToList());

            Volver();
        }

        private void Volver()
        {
            var main = Application.Current.MainWindow as MainWindow;
            if (main?.MainFrame != null)
            {
                main.MainFrame.Navigate(new PaginaListadoObjetos());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string n = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
    }
}
