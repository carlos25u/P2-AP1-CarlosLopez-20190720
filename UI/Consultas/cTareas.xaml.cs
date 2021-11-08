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
    /// Interaction logic for cTareas.xaml
    /// </summary>
    public partial class cTareas : Window
    {
        public cTareas()
        {
            InitializeComponent();
        }

        private void consultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<TiposTareas>();

            if (filtroTextBox.Text.Trim().Length > 0)
            {
                switch (filtroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = TiposTareasBLL.GetList(e => e.TipoId == Utilidades.ToInt(filtroTextBox.Text));
                        break;

                    case 1:
                        listado = TiposTareasBLL.GetList(e => e.TipoTarea.ToLower().Contains(filtroTextBox.Text.ToLower()));
                        break;

                    case 2:
                        listado = TiposTareasBLL.GetList(e => e.Requerimiento.ToLower().Contains(filtroTextBox.Text.ToLower()));
                        break;

                    case 3:
                        listado = TiposTareasBLL.GetList(e => e.Tiempo == Utilidades.ToInt(filtroTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = TiposTareasBLL.GetList(c => true);
            }

            DatosDataDrid.ItemsSource = null;
            DatosDataDrid.ItemsSource = listado;
        }
    }
}
