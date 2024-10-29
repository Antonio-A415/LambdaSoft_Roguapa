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
using LambdaSoft_RoGuapa.Views.Apartados;

namespace LambdaSoft_RoGuapa.Pages
{
    /// <summary>
    /// Lógica de interacción para PageApartados.xaml
    /// </summary>
    public partial class PageApartados : Page
    {
        public PageApartados()
        {
            InitializeComponent();
        }

        private void btn_Clic_Apartados(object sender, RoutedEventArgs e)
        {
            WindowBusquedaApartados _busqueda = new WindowBusquedaApartados();
            _busqueda.ShowInTaskbar = true;
            _busqueda.ShowDialog();
        }
    }
}
