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
    /// Interaction logic for Task12.xaml
    /// </summary>
    public partial class Task12 : Page
    {
        int xPos = 0;
        int yPos = 0;
        public Task12()
        {
            InitializeComponent();
            UpdateText();
            positionText.Content = $"X: {xPos + 50}, Y: {yPos + 50}";
        }

        private void xSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var intValue = (int)e.NewValue;
            xPos = intValue;
            UpdateText();
        }

        private void ySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var intValue = (int)e.NewValue;
            yPos = intValue;
            UpdateText();
        }
        private void UpdateText()
        {
            xSlider.Value = xPos;
            ySlider.Value = yPos;
            positionText.Content = $"X: {xPos + 50}, Y: {yPos + 50}";
            Canvas.SetLeft(positionText, xPos);
            Canvas.SetBottom(positionText, yPos);
        }
    }
}
