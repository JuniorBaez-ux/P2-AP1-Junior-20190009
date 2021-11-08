﻿using P2_AP1_Junior_20190009.BLL;
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

namespace P2_AP1_Junior_20190009.UI.Registros
{
    /// <summary>
    /// Interaction logic for rProyectos.xaml
    /// </summary>
    public partial class rProyectos : Window
    {
        public rProyectos()
        {
            InitializeComponent();
            LlenarComboTipoDeTareas();
        }

        private void BuscarIDButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AgregarDetalleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoverFila_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LlenarComboTipoDeTareas()
        {
            this.tipoTareaComboBox.ItemsSource = TareasBLL.GetTareas();
            this.tipoTareaComboBox.SelectedValuePath = "TareaId";
            this.tipoTareaComboBox.DisplayMemberPath = "TipoTarea";

            if (tipoTareaComboBox.Items.Count > 0)
            {
                tipoTareaComboBox.SelectedIndex = 0;
            }
        }
    }
}
