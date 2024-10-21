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

namespace ObserverDemo
{
    /// <summary>
    /// Логика взаимодействия для AvergeTemperature.xaml
    /// </summary>
    public partial class AvergeTemperature : Window, IWeatherObserver
    {
        private List<double> _temperatures = new List<double>();    
        public AvergeTemperature()
        {
            InitializeComponent();
        }

        public void Update(double temperature)
        {
            _temperatures.Add(temperature);
            temTB.Text = _temperatures.Average().ToString();
        }
    }
}
