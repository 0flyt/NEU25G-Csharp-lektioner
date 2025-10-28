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
    /// Interaction logic for Task13.xaml
    /// </summary>
    public partial class Task13 : Page
    {
        int posX = 0;
        int posXLocked = 0;
        int posY = 0;
        int posYLocked = 0;
        
        public Task13()
        {
            InitializeComponent();
            sliderValue.Content = 0;
        }

        private void positionSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int tempValue = (int)e.NewValue;
            sliderValue.Content = tempValue;
            if (checkBoxX.IsChecked == false)
            {
                checkBoxX.Content = $"Lock X-value: {tempValue}";
                posX = tempValue;
            }
            if (checkBoxY.IsChecked == false)
            {
                checkBoxY.Content = $"Lock Y-value: {tempValue}";
                posY = tempValue;
            }
        }

        private void checkBoxX_Click(object sender, RoutedEventArgs e)
        {
            posXLocked = posX;
            labelText.Content = $"X: {posXLocked}, Y: {posYLocked}";
            if (checkBoxX.IsChecked == true)
            {
                Canvas.SetLeft(labelText, posXLocked);
            }
        }

        private void checkBoxY_Click(object sender, RoutedEventArgs e)
        {
            posYLocked = posY;
            labelText.Content = $"X: {posXLocked}, Y: {posYLocked}";
            if (checkBoxY.IsChecked == true)
            {
                Canvas.SetTop(labelText, posYLocked);
            }
        }
    }
}
