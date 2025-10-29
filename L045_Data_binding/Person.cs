using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L045_Data_binding
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName 
        { 
            get => _firstName;
            set 
            {
                _firstName = value;
                RaisePropertyChange("FirstName");
            } 
        }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                RaisePropertyChange("LastName");
            }
        }
        public int Age { get; set; }

        // ObservableCollection är en List som meddelar om den uppdaterats.
        public ObservableCollection<Person> Children { get; set; } = new ObservableCollection<Person>();

        // Meddelar om en prop har ändrats.
        public event PropertyChangedEventHandler? PropertyChanged;

        // Använder CallerMemberName för att om den är null så tar den och använder prop-namnet
        private void RaisePropertyChange([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
