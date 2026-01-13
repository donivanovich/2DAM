using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TaskManagerDAM.MVVM.Model;

namespace TaskManagerDAM.MVVM.ViewModel;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<TaskModel> Tasks { get; set; }

    // ERROR: Estas propiedades no notifican cambios (necesitan el OnPropertyChanged)
    public string NewTaskTitle { get; set; }

    public ICommand AddTaskCommand { get; }

    public MainViewModel()
    {
        // Datos de prueba iniciales
        Tasks = new ObservableCollection<TaskModel>
        {
            new TaskModel("Aprender MVVM"),
            new TaskModel("Corregir el examen de diseño"),
            new TaskModel("Comprar café") { isCompleted = true }
        };

        // El comando está declarado pero no hace nada útil
        AddTaskCommand = new RelayCommand(ExecuteAddTask);
    }

    private void ExecuteAddTask(object obj) 
    {
        // TAREA 5: Implementar lógica: crear tarea, añadir a lista, limpiar input.
        TaskModel nuevatask = new TaskModel(NewTaskTitle);
        Tasks.Add(nuevatask);

        NewTaskTitle = string.Empty;
    }

    // Implementación básica de INPC
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}