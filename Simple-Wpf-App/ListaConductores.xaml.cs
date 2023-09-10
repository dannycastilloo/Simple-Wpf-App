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
    /// Interaction logic for ListaConductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {

        public class Conductor
        {
            public string Nombre { get; set; }
            public string Licencia { get; set; }
            public string Transporte { get; set; }
        }

        public ListaConductores()
        {
            InitializeComponent();

            // Crear una lista de conductores (esto es solo un ejemplo)
            List<Conductor> conductores = new List<Conductor>
            {
                new Conductor { Nombre = "Conductor 1", Licencia = "Licencia 1", Transporte = "Transporte 1" },
                new Conductor { Nombre = "Conductor 2", Licencia = "Licencia 2", Transporte = "Transporte 2" },
                new Conductor { Nombre = "Conductor 3", Licencia = "Licencia 3", Transporte = "Transporte 3" }
            };

            // Mostrar la lista de conductores en el DataGrid
            dgConductores.ItemsSource = conductores;
        }
    }
}
