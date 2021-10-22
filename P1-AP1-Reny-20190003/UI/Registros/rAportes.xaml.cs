using P1_AP1_Reny_20190003.BLL;
using P1_AP1_Reny_20190003.Entidades;
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

namespace P1_AP1_Reny_20190003.UI.Registro
{
    /// <summary>
    /// Interaction logic for rAportes.xaml
    /// </summary>
    public partial class rAportes : Window
    {
        private Aportes aportes = new Aportes();
        public rAportes()
        {
            InitializeComponent();
            this.DataContext = aportes;
        }

        private void Limpiar()
        {
            this.aportes = new Aportes();
            this.DataContext = this.aportes;
        }
        private bool Validar()
        {
            bool esValido = true;

            if (RegistroTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor de llenar todo los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            var encontrado = AportesBLL.Buscar(Utilidades.ToInt(RegistroTextBox.Text));

            if (encontrado != null)
            {
                this.aportes = encontrado;
            }

            else
            {
                this.aportes = new Aportes();
                MessageBox.Show("No se ha encontrado", "Error",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.aportes;
        }

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;


            bool paso = AportesBLL.Guardar(this.aportes);



            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (AportesBLL.Eliminar(Utilidades.ToInt(RegistroTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("No Fue Posible Eliminar el Registro! :(", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
