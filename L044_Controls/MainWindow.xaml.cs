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

namespace L044_Controls
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (copyButton is null) return;
            copyButton.IsEnabled = textBox.Text.Length > 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonB.IsChecked == true)
            {
                textBoxen.Text += Environment.NewLine + textBox.Text;
            }
            else
            {
                textBoxen.Text = textBox.Text;

            }

            comboBox.Items.Add(textBox.Text);
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            copyButton.Visibility = checkBox.IsChecked == true ? Visibility.Hidden : Visibility.Visible;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            label.Content = (comboBox.SelectedItem as ComboBoxItem)?.Content;
        }


    }
}