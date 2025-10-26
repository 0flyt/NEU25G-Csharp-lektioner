using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using System.Windows.Shapes;

namespace Ovn011_XAML
{
    /// <summary>
    /// Interaction logic for Task08.xaml
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public partial class Task08 : Page
    {
        public Task08()
        {
            InitializeComponent();

            var people = new List<Person>()
            {
                new Person {FirstName="Kalle", LastName="Andersson", Email="kalle@gmail.com"},
                new Person {FirstName="Anders", LastName="Karlsson", Email="anders@gmail.com"},
                new Person {FirstName="Camilla", LastName="Johansson", Email="camilla@gmail.com"},
                new Person {FirstName="Johan", LastName="Svensson", Email="johan@gmail.com"},
                new Person {FirstName="Mia", LastName="Karlsson", Email="mia@gmail.com"},
            };

            MyList.ItemsSource = people;
        }
        private void MyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyList.SelectedItem is Person p)
            {
                firstname.Text = p.FirstName;
                lastname.Text = p.LastName;
                email.Text = p.Email;
            }
        }
    }
}
