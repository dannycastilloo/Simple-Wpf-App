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

namespace Simple_Wpf_App
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            Ingresos ingresos = new Ingresos();
            ingresos.Show();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores contadores = new Conductores();
            contadores.Show();
        }

        private void ListaIngresos_Click(object sender, RoutedEventArgs e)
        {
            ListaIngresos listaIngresos = new ListaIngresos();
            listaIngresos.Show();
        }
    }
}
