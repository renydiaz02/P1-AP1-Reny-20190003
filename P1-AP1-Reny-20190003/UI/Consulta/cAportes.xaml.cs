﻿using P1_AP1_Reny_20190003.BLL;
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

namespace P1_AP1_Reny_20190003.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cConsulta.xaml
    /// </summary>
    public partial class cConsulta : Window
    {
        public cConsulta()
        {
            InitializeComponent();
        }

        public static string Cantidad = "";

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Persona
                        listado = AportesBLL.GetList(e => e.Persona.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 1: //Concepto
                        listado = AportesBLL.GetList(e => e.Concepto.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(e => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date >= DesdeDataPicker.SelectedDate);

            if (HastaDataPicker.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date <= HastaDataPicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            Cantidad = listado.Count().ToString();
            CantidadTextBlock.Text = Cantidad;
        }
    }
}
