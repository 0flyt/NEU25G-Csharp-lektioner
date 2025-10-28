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
    /// Interaction logic for Task15.xaml
    /// </summary>
    public class Elev
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public partial class Task15 : Page
    {
        public List<Elev> elever;
        public Task15()
        {
            InitializeComponent();

            elever = new List<Elev>() 
            { 
                new Elev{FirstName = "Kalle", LastName = "Johansson", Email = "kalle@gmail.com"},
                new Elev{FirstName = "Tor", LastName = "Torson", Email = "tor@gmail.com"},
                new Elev{FirstName = "Per", LastName = "Persson", Email = "per@gmail.com"},
                new Elev{FirstName = "Pelle", LastName = "Pelsson", Email = "pelle@gmail.com"},
                new Elev{FirstName = "Björn", LastName = "Bjorsson", Email = "bjorn@gmail.com"},
                new Elev{FirstName = "Anna", LastName = "Annsdotter", Email = "anna@gmail.com"},
            };
            elevLista.ItemsSource = elever;
            laggTill_Button.IsEnabled = true;
            taBort_Button.IsEnabled = false;
            menuRemove.IsEnabled = false;
            contextRemove.IsEnabled = false;
        }

        private void elevLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (elevLista.SelectedItem is Elev l)
            {
                firstName.Text = l.FirstName;
                lastName.Text = l.LastName;
                eMail.Text = l.Email;
                taBort_Button.IsEnabled = true;
                menuRemove.IsEnabled = true;
                contextRemove.IsEnabled = true;
            }
        }

        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (elevLista.SelectedItem is Elev l)
            {
                l.FirstName = firstName.Text;
                elevLista.Items.Refresh();  
            }
        }

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (elevLista.SelectedItem is Elev l)
            {
                l.LastName = lastName.Text;
                elevLista.Items.Refresh();
            }
        }

        private void eMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (elevLista.SelectedItem is Elev l)
            {
                l.Email = eMail.Text;
                elevLista.Items.Refresh();
            }
        }

        private void taBort_Button_Click(object sender, RoutedEventArgs e)
        {
            if (elevLista.SelectedItem is Elev l)
            {
                firstName.Text = "";
                lastName.Text = "";
                eMail.Text = "";
                elever.Remove(l);
                taBort_Button.IsEnabled = false;
                menuRemove.IsEnabled = false;
                contextRemove.IsEnabled = false;
            }
            elevLista.Items.Refresh();
        }

        private void laggTill_Button_Click(object sender, RoutedEventArgs e)
        {
            elever.Add(new Elev { FirstName = "New", LastName = "", Email = "" });
            elevLista.Items.Refresh();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
