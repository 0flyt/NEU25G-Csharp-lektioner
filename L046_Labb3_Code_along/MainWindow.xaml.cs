using L046_Labb3_Code_along.ViewModels;
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

namespace L046_Labb3_Code_along;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var pack = new Models.QuestionPack("MyQuestionPack");
        DataContext = new QuestionPackViewModel(pack);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        QuestionPackViewModel viewModel = (DataContext as QuestionPackViewModel);
        viewModel.Name = "New name";
        viewModel.Questions.Add(new Models.Question("Vad är 1+1?", "2", "3", "4", "1"));
    }
}