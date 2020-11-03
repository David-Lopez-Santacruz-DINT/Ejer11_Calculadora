using System.Windows;
using System.Windows.Controls;

namespace Ejer11_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonButton_Click(object sender, RoutedEventArgs e)
        {
            Button botonPulsado = (Button)sender;
            pantallaTextBox.Text += botonPulsado.Tag.ToString();
        }
    }
}
