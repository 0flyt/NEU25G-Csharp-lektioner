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
    /// Interaction logic for Task17.xaml
    /// </summary>
    public partial class Task17 : Page
    {
        public Task17()
        {
            InitializeComponent();
            CreateGrid(1);
            FillGrid(1);
        }
        public void CreateGrid(int x)
        {
            myGrid.Children.Clear();
            myGrid.ColumnDefinitions.Clear();
            myGrid.RowDefinitions.Clear();

            for (int i = 0; i < x; i++)
            {
                myGrid.ColumnDefinitions.Add(new ColumnDefinition 
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            for (int j = 0; j < x; j++)
            {
                myGrid.RowDefinitions.Add(new RowDefinition 
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            }
        }

        public void FillGrid(int x)
        {
            int count = 0;
            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < x; j++)
                {

                    var label = new Label { Content = count, VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center };
                    Grid.SetColumn(label, j);
                    Grid.SetRow(label, i);
                    myGrid.Children.Add(label);
                    count++;
                }
            }
        }

        private void gridSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!IsLoaded) return;
            gridSliderValueLabel.Content = gridSlider.Value;
            int tempValue = (int)gridSlider.Value;
            CreateGrid(tempValue);
            FillGrid(tempValue);
        }
    }
}
