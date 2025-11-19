using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMiniBiblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_LibrosClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Libros());
        }

        private void Btn_AutoresClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Autores());
        }

        private void Btn_AgregarClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Agregar());
        }
    }
}