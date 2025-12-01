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

namespace WpfPrimerProyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //lblResultado.Content = ""; //Para vaciar el label

            InitializeComponent();

            // Comentario de una sola linea
            int numero = 5;
            int numero2 = 10;
            int resultado = numero + numero2;

            /*
             * 
             * comentario de multiples lineas
             * 
             */

            string texto = "Bienvenida a la Calculadora Simple";

            MessageBox.Show(caption: "Hola", messageBoxText: texto);

            double numeroDecimal = 5.5;
            double numeroDecimal2 = 10.5;

            double resultDecimales = numeroDecimal / numeroDecimal2;

            double resto = numeroDecimal % numeroDecimal2;
        }

        private void ButtonSumar(object sender, RoutedEventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            int total = n1 + n2;
            MessageBox.Show(messageBoxText: total.ToString());
            lblResultado.Content = "Total: " + total.ToString();
        }

        private void TextBox_TextUpperCase(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox) // si pones textBox al final te ahorras la linea comentada de abajo
            {

                //TextBoX textBox = (TextBox)sender; 
                
                textBox.Text = new string(textBox.Text.Where(c => char.IsDigit(c)).ToArray()); //Controlar que sean NUMEROS
                textBox.Text = textBox.Text.ToUpper();
                textBox.SelectionStart = textBox.Text.Length; //Para escribir de izq a drch
            }
        }

        private void ButtonVaciar(object sender, RoutedEventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
        }
    }
}