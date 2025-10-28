using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ovn011_XAML.Tasks.WPF;

namespace Ovn011_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedChange(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (NavigationTree.SelectedItem is TreeViewItem item && item.Tag != null)
            {
                string tag = item.Tag.ToString();
                TitleText.Text = item.Header.ToString();

                switch (tag)
                {
                    // XAML
                    case "XAML01": ContentFrame.Navigate(new Task01()); break;
                    case "XAML02": ContentFrame.Navigate(new Task02()); break;
                    case "XAML03": ContentFrame.Navigate(new Task03()); break;
                    case "XAML04": ContentFrame.Navigate(new Task04()); break;
                    case "XAML05": ContentFrame.Navigate(new Task05()); break;
                    case "XAML06": ContentFrame.Navigate(new Task06()); break;
                    case "XAML07": ContentFrame.Navigate(new Task07()); break;
                    case "XAML08": ContentFrame.Navigate(new Task08()); break;

                    // WPF
                    case "WPF01": ContentFrame.Navigate(new Task09()); break;
                    case "WPF02": ContentFrame.Navigate(new Task10()); break;
                    case "WPF03": ContentFrame.Navigate(new Task11()); break;
                    case "WPF04": ContentFrame.Navigate(new Task12()); break;
                    case "WPF05": ContentFrame.Navigate(new Task13()); break;
                    case "WPF06": ContentFrame.Navigate(new Task14()); break;
                    case "WPF07": ContentFrame.Navigate(new Task15()); break;
                    case "WPF08": ContentFrame.Navigate(new Task16()); break;
                    case "WPF09": ContentFrame.Navigate(new Task17()); break;
                }
            }
        }
        
    }
}