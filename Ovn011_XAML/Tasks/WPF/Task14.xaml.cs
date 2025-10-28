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
    /// Interaction logic for Task14.xaml
    /// </summary>
    public class Student
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public partial class Task14 : Page
    {
        
        public Task14()
        {
            InitializeComponent();
            var Students = new List<Student>() 
            {
                new Student{FirstName = "Kalle", LastName = "Johansson", Email = "kalle@gmail.com"},
                new Student{FirstName = "Palle", LastName = "Toansson", Email = "palle@gmail.com"},
                new Student{FirstName = "Skalle", LastName = "Konnysson", Email = "skalle@gmail.com"},
                new Student{FirstName = "Talla", LastName = "Sonnysson", Email = "talla@gmail.com"},
                new Student{FirstName = "Lala", LastName = "Hahasson", Email = "lala@gmail.com"},
                new Student{FirstName = "Sallad", LastName = "Fnisson", Email = "sallad@gmail.com"},
            };
            studentList.ItemsSource = Students;
        }

        private void studentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (studentList.SelectedItem is Student p)
            {
                firstName.Text = p.FirstName;
                lastName.Text = p.LastName;
                eMail.Text = p.Email;
            }
        }

        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (studentList.SelectedItem is Student s)
            {
                s.FirstName = firstName.Text;
                studentList.Items.Refresh();
            }
        }

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (studentList.SelectedItem is Student s)
            {
                s.LastName = lastName.Text;
                studentList.Items.Refresh();
            }
        }

        private void eMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (studentList.SelectedItem is Student s)
            {
                s.Email = eMail.Text;
                studentList.Items.Refresh();
            }
        }
    }
}
