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
    /// Interaction logic for ListaIngresos.xaml
    /// </summary>
    public partial class ListaIngresos : Window
    {
        public class Ingreso
        {
            public DateTime Fecha { get; set; }
            public string Placa { get; set; }
            public string Turno { get; set; }
            public string Conductor { get; set; }
            public string Producto { get; set; }
            public double Peso { get; set; }
            public string Transporte { get; set; }
        }

        public ListaIngresos()
        {
            InitializeComponent();

            // Crear una lista de ingresos (esto es solo un ejemplo)
            List<Ingreso> ingresos = new List<Ingreso>
            {
                new Ingreso { Fecha = DateTime.Now, Placa = "ABC123", Turno = "Turno 1", Conductor = "Conductor 1", Producto = "Producto 1", Peso = 1000.0, Transporte = "Transporte 1" },
                new Ingreso { Fecha = DateTime.Now, Placa = "DEF456", Turno = "Turno 2", Conductor = "Conductor 2", Producto = "Producto 2", Peso = 1500.0, Transporte = "Transporte 2" },
                new Ingreso { Fecha = DateTime.Now, Placa = "GHI789", Turno = "Turno 3", Conductor = "Conductor 3", Producto = "Producto 3", Peso = 800.0, Transporte = "Transporte 3" }
            };

            // Mostrar la lista de ingresos en el DataGrid
            dgIngresos.ItemsSource = ingresos;
        }
    }
}
