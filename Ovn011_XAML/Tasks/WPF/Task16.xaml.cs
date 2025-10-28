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
    /// Interaction logic for Task16.xaml
    /// </summary>
    public partial class Task16 : Page
    {
        public Task16()
        {
            InitializeComponent();
            MakeGrid(10, 10);
            FillGrid(10, 10);
        }
        public void MakeGrid(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                myGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            for (int i = 0; i < y; i++)
            {
                myGrid.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            }
        }
        public void FillGrid(int x, int y)
        {
            int count = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var label = new Label { Content = $"{count}", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center };
                    
                    Grid.SetColumn(label, j);
                    Grid.SetRow(label, i);
                    myGrid.Children.Add(label);
                    count++;
                }
            }
        }
    }
}
