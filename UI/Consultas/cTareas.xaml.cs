using P2_AP1_Junior_20190009.BLL;
using P2_AP1_Junior_20190009.Entidades;
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

namespace P2_AP1_Junior_20190009.UI.Consultas
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

        private void BuscarCriterioButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Tareas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //TareasId
                        int.TryParse(CriterioTextBox.Text, out int TareasId);
                        listado = TareasBLL.GetList(a => a.TareaId == TareasId);
                        break;

                    case 1: //TipoTareas
                        listado = TareasBLL.GetList(a => a.TipoTarea.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = TareasBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = listado.Where(c => c.FechaTarea.Date >= DesdeDatePicker.SelectedDate).ToList();

            if (HastaDatePicker.SelectedDate != null)
                listado = listado.Where(c => c.FechaTarea.Date <= HastaDatePicker.SelectedDate).ToList();

            DetalleDataGrid.ItemsSource = null;
            DetalleDataGrid.ItemsSource = listado;
        }
    }
}
