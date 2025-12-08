using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using GestorObjetosPerdidos.MVVM.Model;
using GestorObjetosPerdidos.MVVM.View;

namespace GestorObjetosPerdidos.MVVM.ViewModel
{
    public class ObjetosPerdidosViewModel : INotifyPropertyChanged
    {
        private readonly FileService _fileService;
        private ObservableCollection<ObjetoPerdido> _objetos;
        private ObjetoPerdido _objetoSeleccionado;

        public ObjetosPerdidosViewModel()
        {
            _fileService = new FileService();
            _objetos = new ObservableCollection<ObjetoPerdido>();

            CargarObjetosCommand = new RelayCommand(async () => await CargarObjetosAsync());
            AgregarObjetoCommand = new RelayCommand(AgregarObjeto);
            MarcarDevueltoCommand = new RelayCommand(MarcarDevuelto, CanMarcarDevuelto);

            _ = CargarObjetosAsync();
        }
        public ObservableCollection<ObjetoPerdido> Objetos
        {
            get => _objetos;
            set
            {
                _objetos = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ObjetosDevueltos));
            }
        }

        public ObservableCollection<ObjetoPerdido> ObjetosDevueltos =>
            new ObservableCollection<ObjetoPerdido>(_objetos.Where(o => o.Devuelto));

        public ObjetoPerdido ObjetoSeleccionado
        {
            get => _objetoSeleccionado;
            set
            {
                _objetoSeleccionado = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public ICommand CargarObjetosCommand { get; }
        public ICommand AgregarObjetoCommand { get; }
        public ICommand MarcarDevueltoCommand { get; }

        private async Task CargarObjetosAsync()
        {
            try
            {
                var objetos = await _fileService.CargarObjetosAsync();
                Objetos = new ObservableCollection<ObjetoPerdido>(objetos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        // Abrir página de edición para crear un nuevo objeto
        private void AgregarObjeto()
        {
            // La MainWindow debe tener un Frame como Content:
            // <Frame x:Name="MainFrame" .../>
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow?.MainFrame != null)
            {
                mainWindow.MainFrame.Navigate(new PaginaEditarObjeto(null));
            }
        }

        private async void MarcarDevuelto()
        {
            if (ObjetoSeleccionado == null)
                return;

            ObjetoSeleccionado.Devuelto = true;
            OnPropertyChanged(nameof(ObjetoSeleccionado));
            OnPropertyChanged(nameof(ObjetosDevueltos));

            await _fileService.GuardarObjetosAsync(Objetos.ToList());
        }

        private bool CanMarcarDevuelto()
        {
            return ObjetoSeleccionado != null && !ObjetoSeleccionado.Devuelto;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string nombrePropiedad = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;

        public void Execute(object parameter) => _execute();
    }
}
