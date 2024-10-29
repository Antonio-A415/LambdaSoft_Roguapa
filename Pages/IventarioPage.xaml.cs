using LambdaSoft_RoGuapa.Views.Categorias;
using LambdaSoft_RoGuapa.Views.Registro_Produc;
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

namespace LambdaSoft_RoGuapa.Pages
{
    /// <summary>
    /// Lógica de interacción para IventarioPage.xaml
    /// </summary>
    public partial class IventarioPage : Page
    {
        public IventarioPage()
        {
            InitializeComponent();
        }

        private void btn_openRegistroPro(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            RegistroProd modal = new RegistroProd
            {
                Owner = Window.GetWindow(this)
            };
            modal.ShowDialog();
            this.Opacity = 1.0;
            // Asignar la lista como el ItemsSource del ListView

        }

        private void click_opencategorias(object sender, MouseButtonEventArgs e)
        {
            this.Opacity = 0.5;
            Categorias modal = new Categorias
            {
                Owner = Window.GetWindow(this)
            };
            modal.ShowDialog();
            this.Opacity = 1.0;
            
        }
    }
}
