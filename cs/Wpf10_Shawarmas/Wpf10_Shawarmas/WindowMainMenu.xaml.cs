using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Wpf10_Shawarmas.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para ViewMainMenu.xaml
    /// </summary>
    public partial class ViewMainMenu : Window
    {
        public ViewMainMenu()
        {
            InitializeComponent();
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e) // Boton para comprar
        {

        }

        private void BtnConfiguration_Click(object sender, RoutedEventArgs e) // Boton para configuracion
        {

        }

        private void BtnAbout_Click(object sender, RoutedEventArgs e) // Boton acerca de
        {

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e) // Boton para salir
        {
            this.Close();
        }
    }
}
