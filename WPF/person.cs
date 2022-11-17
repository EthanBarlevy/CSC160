using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace WPF
{
    internal class Person : INotifyPropertyChanged
    {
        private string ln;
        public List<string> lastNames = new List<string>
        {
            "Barlevy",
            "Carter",
            "Small",
            "Peterson"
        };

        public Person() { }

        public Person(string ln)
        { this.ln = ln; }

        public string Last 
        { 
            get { return ln; } 
            set { ln = value; PropertyHasChanged("Last"); } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void PropertyHasChanged(string s)
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

        public void randomize()
        {
            Random r = new Random();
            this.Last =lastNames.ElementAt(r.Next(lastNames.Count));
        }
    }
}
