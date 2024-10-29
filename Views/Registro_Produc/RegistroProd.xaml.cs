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

namespace LambdaSoft_RoGuapa.Views.Registro_Produc
{
    /// <summary>
    /// Lógica de interacción para RegistroProd.xaml
    /// </summary>
    public partial class RegistroProd : Window
    {
        public RegistroProd()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
