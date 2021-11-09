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

namespace P2_AP1_CarlosLopez_20190720.UI.Registros
{
    /// <summary>
    /// Interaction logic for rProyectos.xaml
    /// </summary>
    public partial class rProyectos : Window
    {
        private Proyectos proyecto = new Proyectos();
        public rProyectos()
        {
            
            InitializeComponent();
            this.DataContext = proyecto;

            TipotareasComboBox.ItemsSource = TiposTareasBLL.GetTiposTareas();
            TipotareasComboBox.SelectedValuePath = "TipoId";
            TipotareasComboBox.DisplayMemberPath = "TipoTarea";
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyecto;
        }

        private void Limpiar()
        {
            this.proyecto = new Proyectos();
            this.DataContext = proyecto;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectosBLL.Buscar(Utilidades.ToInt(ProyectoIdTextBox.Text));

            if(encontrado != null)
            {
                proyecto = encontrado;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("El proyecto no existe", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            proyecto.Detalle.Add(new ProyectoDetalle
            {
                ProyectoId = proyecto.ProyectoId,
                TiposTareas = (TiposTareas)TipotareasComboBox.SelectedItem
                
            });

            Cargar();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            if(DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                proyecto.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            var paso = ProyectosBLL.Guardar(proyecto);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProyectosBLL.Eliminar(Utilidades.ToInt(ProyectoIdTextBox.Text)))
            {
                MessageBox.Show("Se elimino con exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
