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
using Wpf08_GestorObjetosPerdidos.MVVM.View;

namespace Wpf08_GestorObjetosPerdidos
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

        private void Btn_ObjetosClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PaginaListadoObjetos());
        }
    }
}