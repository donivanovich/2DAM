using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TaskManagerDAM.MVVM.Model;

public class TaskModel : INotifyPropertyChanged
{
    private string Title;
    private bool IsCompleted;

    public string title
    {
        get => Title;
        set { Title = value; OnPropertyChanged(); }
    }

    public bool isCompleted
    {
        get => IsCompleted;
        set { IsCompleted = value; OnPropertyChanged(); }
    }

    public TaskModel(string title)
    {
        Title = title;
        IsCompleted = false;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string nombre = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
}