using Business;
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

namespace semana07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private BCustomer bCustomer;
        public MainWindow()
        {
            InitializeComponent();
            var resultados = new BCustomer();

            // Asignar los resultados al DataGrid
            pordefinir.ItemsSource = resultados.Get();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombreBuscado = NombreBuscarTextBox.Text;

            var resultados = new BCustomer();

            // Asignar los resultados al DataGrid
            pordefinir.ItemsSource = resultados.Get(nombreBuscado);
        }
    }
}