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
    /// Interaction logic for Task18.xaml
    /// </summary>

    public partial class Task18 : Page
    {
        public Task18()
        {
            InitializeComponent();
            CreateGrid(10);
            FillGrid(10);
        }

        public void CreateGrid(int x)
        {
            for (int i = 0; i < x; i++)
            {
                myButtonGrid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            for (int i = 0; i < x; i++)
            {
                myButtonGrid.RowDefinitions.Add(new RowDefinition
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

                    var button = new Button { Tag = count, Content = count++ };
                    button.Click += Button_Click;
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    myButtonGrid.Children.Add(button);
                    
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            int highestValue = (int)button.Tag;
            int currentValue = (int)button.Content;

            if (currentValue != 0)
            {
                button.Content = currentValue - 1;
            }
            else
            {
                button.Content = highestValue;
            }
        }
    }
}
