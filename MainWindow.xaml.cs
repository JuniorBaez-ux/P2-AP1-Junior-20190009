using P2_AP1_Junior_20190009.UI.Consultas;
using P2_AP1_Junior_20190009.UI.Registros;
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

namespace P2_AP1_Junior_20190009
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
            rProyectos proyectos = new rProyectos();
            proyectos.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            cProyectos consul = new cProyectos();
            consul.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            cTareas tareas = new cTareas();
            tareas.Show();
        }
    }
}
