using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf04_MiniBiblioteca.MVVM.Model;

namespace Wpf04_MiniBiblioteca.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para Libros.xaml
    /// </summary>
    public partial class Libros : Page
    {
        ObservableCollection<Libro> ListaLibros;
        public Libros()
        {
            InitializeComponent();
        }
    }
}
