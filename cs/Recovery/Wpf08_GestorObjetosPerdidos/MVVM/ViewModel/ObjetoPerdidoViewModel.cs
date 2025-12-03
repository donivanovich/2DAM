using Wpf08_GestorObjetosPerdidos.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;


namespace Wpf08_GestorObjetosPerdidos.MVVM.ViewModel
{
    public class ObjetosPerdidosViewModel : INotifyPropertyChanged
    {
        private readonly FileService _fileService;
        private ObservableCollection<ObjetoPerdido> _objetos;

        public ObjetosPerdidosViewModel()
        {
            _fileService = new FileService();
            _objetos = new ObservableCollection<ObjetoPerdido>();
            CargarObjetosCommand = new RelayCommand(async () => await CargarObjetosAsync());

            // Cargar datos al inicializar
            _ = CargarObjetosAsync();
        }

        public ObservableCollection<ObjetoPerdido> Objetos
        {
            get => _objetos;
            set
            {
                _objetos = value;
                OnPropertyChanged();
            }
        }

        // Solo comando de cargar
        public ICommand CargarObjetosCommand { get; }

        private async Task CargarObjetosAsync()
        {
            var objetos = await _fileService.CargarObjetosAsync();
            Objetos = new ObservableCollection<ObjetoPerdido>(objetos);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // Clase auxiliar para comandos (RelayCommand simple)
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;

        public RelayCommand(Action execute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => _execute();
    }
}