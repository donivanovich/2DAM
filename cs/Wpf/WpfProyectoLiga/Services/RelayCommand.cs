using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfProyectoLiga
{
    public class RelayCommand : ICommand
    {
        /* Acción que se ejecutará cuando el comando sea invocado.
        private readonly Action<object> _execute;

        // Función que define si el comando puede ejecutarse o no
        private readonly Predicate<object> _canExecute;

        // Constructor: recibir la acción y opcionalmente la condición de ejecución
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        // Determina si el comando puede ejecutarse (si no hay _canExecute, siempre puede)
        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }
            else
            {
                return true;
            }
        }

        // Acción que se ejecuta al disparar el comando
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        // Evento que WPF usa para actualizar el estado del botón (habilitado/deshabilitado)
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }*/

        private readonly Func<object, Task> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Func<object, Task> execute, Predicate<object> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);

        public async void Execute(object parameter) => await _execute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
