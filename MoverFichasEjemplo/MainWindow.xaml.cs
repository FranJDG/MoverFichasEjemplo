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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoverFichasEjemplo
{
    public partial class MainWindow : Window
    {
        private Random random;
        private int numeroDado;
        private int numeroCasilla = 0;
        private Button[] casillas;

        public MainWindow()
        {
            InitializeComponent();

            random = new Random();
            casillas = new Button[] { casilla1, casilla2, casilla3, casilla4, casilla5, casilla6, casilla7, casilla8, casilla9, casilla10
            , casilla11, casilla12, casilla13, casilla14, casilla15, casilla16, casilla17, casilla18};
        }

        private void btnLanzar_Click(object sender, RoutedEventArgs e)
        {
            numeroDado = random.Next(1, 7);
            numeroCasilla += numeroDado;
            txtResultado.Text = $"Número del dado: {numeroDado}";

            MoverFicha(numeroCasilla);
        }

        private void Casilla_Click(object sender, RoutedEventArgs e)
        {
            Button casilla = (Button)sender;
            int numero = int.Parse(casilla.Content.ToString());

            MoverFicha(numero);
        }

        private void MoverFicha(int numero)
        {
            // Restablecer el color de todas las casillas
            foreach (var casilla in casillas)
            {
                casilla.Background = System.Windows.Media.Brushes.Gray;
            }

            // Cambiar el color de la casilla correspondiente al número
            casillas[numero - 1].Background = System.Windows.Media.Brushes.Red;
        }
    }

}
