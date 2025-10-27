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
    /// Interaction logic for Task10.xaml
    /// </summary>
    public partial class Task10 : Page
    {
        public int Counter = 0;
        public Task10()
        {
            InitializeComponent();
            UpdateCounterLabel();
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
        }
        private void UpdateCounterLabel()
        {
            CounterLabel.Content = Counter.ToString();
            IncreaseButton.IsEnabled = Counter < 9;
            DecreaseButton.IsEnabled = Counter > 0;
        }
    }
}
