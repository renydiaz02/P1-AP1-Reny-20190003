﻿using P1_AP1_Reny_20190003.UI.Consulta;
using P1_AP1_Reny_20190003.UI.Registro;
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

namespace P1_AP1_Reny_20190003
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rAportes r = new rAportes();
            r.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            cConsulta c = new cConsulta();
            c.Show();
        }
    }
}
