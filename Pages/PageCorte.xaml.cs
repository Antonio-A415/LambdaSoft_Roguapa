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
using System.Windows.Threading;

namespace LambdaSoft_RoGuapa.Pages
{
    /// <summary>
    /// Lógica de interacción para PageCorte.xaml
    /// </summary>
    public partial class PageCorte : Page
    {
        private DispatcherTimer _timer;

        public PageCorte()
        {

            InitializeComponent();
            StartClock();
        }

        private void StartClock()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Hora_Fecha.Text=DateTime.Now.ToString("dd-HH:mm:ss");
        }


    }
}
