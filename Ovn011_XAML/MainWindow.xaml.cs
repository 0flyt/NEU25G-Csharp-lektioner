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
        private void OpenTask1(object sender, RoutedEventArgs e)
        {
            
            ContentFrame.Navigate(new Task01());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask2(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task02());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask3(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task03());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask4(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task04());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask5(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task05());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask6(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task06());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask7(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task07());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
        private void OpenTask8(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Task08());
            if (sender is Button button)
            {
                TitleText.Text = button.Content.ToString();
            }
        }
    }
}