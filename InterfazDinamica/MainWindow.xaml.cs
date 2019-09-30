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

namespace InterfazDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            grdParametros.Visibility = Visibility.Hidden;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            grdParametros.Visibility = Visibility.Hidden;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            btnGuardar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            grdParametros.Visibility = Visibility.Visible;
            switch (cbPersona.SelectedIndex)
            {
                case 0:
                    grdParametros.Children.Add(new ParametrosAlumno());
                    break;
                case 1:
                    grdParametros.Children.Add(new ParametrosMaestro());
                    break;
            }
        }

        
    }
}
