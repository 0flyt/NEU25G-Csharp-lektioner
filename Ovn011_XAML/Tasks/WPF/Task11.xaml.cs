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

namespace Ovn011_XAML.Tasks.WPF
{
    /// <summary>
    /// Interaction logic for Task11.xaml
    /// </summary>
    public partial class Task11 : Page
    {
        public int Counter = 0;
        public Task11()
        {
            InitializeComponent();
            UpdateCounterLabel();
            UpdateCounterSlider();
        }

        private void Button_Click_Increase(object sender, RoutedEventArgs e)
        {
            IncreaseDecreseCounter('+');
        }

        private void Button_Click_Decrease(object sender, RoutedEventArgs e)
        {
            IncreaseDecreseCounter('-');

        }
        private void IncreaseDecreseCounter(char c)
        {
            if (c == '+' && Counter < 9)
            {
                Counter++;
            }
            else if (c == '-' && Counter > 0)
            {
                Counter--;
            }
            UpdateCounterLabel();
            UpdateCounterSlider();
        }
        private void UpdateCounterLabel()
        {
            CounterLabel.Content = Counter.ToString();
            IncreaseButton.IsEnabled = Counter < 9;
            DecreaseButton.IsEnabled = Counter > 0;
        }
        private void UpdateCounterSlider()
        {
            CounterSlider.Value = Counter;
        }

        private void CounterSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var intValue = (int)e.NewValue;
            Counter = intValue;
            UpdateCounterLabel();
        }
    }
}
