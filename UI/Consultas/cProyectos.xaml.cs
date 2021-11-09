using P2_AP1_CarlosLopez_20190720.BLL;
using P2_AP1_CarlosLopez_20190720.Entidades;
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

namespace P2_AP1_CarlosLopez_20190720.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cProyectos.xaml
    /// </summary>
    public partial class cProyectos : Window
    {
        public cProyectos()
        {
            InitializeComponent();
        }

        private void consultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Proyectos>();

            if(filtroTextBox.Text.Trim().Length > 0)
            {
                switch (filtroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = ProyectosBLL.GetList(e => e.ProyectoId == Utilidades.ToInt(filtroTextBox.Text));
                        break;
                    case 1:
                        listado = ProyectosBLL.GetList(e => e.Descripcion.ToLower().Contains(filtroTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = ProyectosBLL.GetList(c => true);
            }

            if (desdeDatePicker.SelectedDate != null)
                listado = ProyectosBLL.GetList(c => c.Fecha.Date >= desdeDatePicker.SelectedDate);

            if (hastaDatePicker.SelectedDate != null)
                listado = ProyectosBLL.GetList(c => c.Fecha.Date <= hastaDatePicker.SelectedDate);

            DatosDataDrid.ItemsSource = null;
            DatosDataDrid.ItemsSource = listado;


        }
    }
}
