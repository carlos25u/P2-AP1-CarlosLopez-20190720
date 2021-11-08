using P2_AP1_CarlosLopez_20190720.UI.Consultas;
using P2_AP1_CarlosLopez_20190720.UI.Registros;
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

namespace P2_AP1_CarlosLopez_20190720
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

        private void RegistrosProyectos_Click(object sender, RoutedEventArgs e)
        {
            rProyectos registros = new rProyectos();
            registros.Show();
        }

        private void ConsultasProyectos_Click(object sender, RoutedEventArgs e)
        {
            cProyectos proyectos = new cProyectos();
            proyectos.Show();
        }

        private void ConsultasTareas_Click(object sender, RoutedEventArgs e)
        {
            cTareas tarea = new cTareas();
            tarea.Show();
        }
    }
}
