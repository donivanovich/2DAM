using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgendaPersonal
{
    public class CitasViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Cita> Citas { get; set; }

        private Cita _citaSeleccionada;


        public CitasViewModel()
        {
            Citas = new ObservableCollection<Cita>()
            {
                new Cita { Titulo = "Reunion", Fecha = DateTime.Now, Descripcion = "En Clase"},
                new Cita { Titulo = "Conferencia", Fecha = DateTime.Now, Descripcion = "Classroom"}
            };

            // Asignamos el comando al método AgregaCita
            AgregarCitaCommand = new RelayCommand(AgregarCita);
        }


        //CREAR UN GETTER Y SETTER PARA CITA SELECCIONADA
        public Cita CitaSeleccionada
        {
            get => _citaSeleccionada;
            set
            {
                _citaSeleccionada = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarCitaCommand { get; }

        private void AgregarCita(object parameter)
        {
            Citas.Add(
                new Cita
                {
                    Titulo = "NuevoTitulo",
                    Fecha = DateTime.Now,
                    Descripcion = "NuevaDescripcion"
                });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string titulo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(titulo));
        }
    }
}
