using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class Character : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private string gender;
        private string classs;
        private string race;

        public string Name
        {
            get { return name; }
            set { name = value; PropertyHasChanged("Name"); }
        }

        public int Age
        {
            get { return age; }
            set { age = value; PropertyHasChanged("Age"); }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; PropertyHasChanged("Gender"); }
        }

        public string Class
        {
            get { return classs; }
            set { classs = value; PropertyHasChanged("Class"); }
        }

        public string Race
        {
            get { return race; }
            set { race = value; PropertyHasChanged("Race"); }
        }

        private string[] Names =
            {
                "Shadebone",
                "Roseshade",
                "Wheatfeather",
                "Wolfwatcher",
                "Shadowmane",
                "Frostbasher",
                "Darkswallow",
                "Noblemore",
                "Lightwater",
                "Burningarrow"
            };

        private string[] Genders =
            {
                "Cis-Gender Male",
                "Cis-Gender Female",
                "Non-Binary",
                "Transgender Male",
                "Transgender Female"
            };

        private string[] Classes =
            {
                "Barbarian",
                "Bard",
                "Cleric",
                "Druid",
                "Fighter",
                "Monk",
                "Paladin",
                "Ranger",
                "Sorcerer",
                "Warlock",
                "Wizard",

            };

        private string[] Races =
            {
                "Dragonborn",
                "Dwarf",
                "Elf",
                "Gnome",
                "Half-Elf",
                "Halfling",
                "Half-Orc",
                "Human",
                "Tiefling"
            };

        public Character(Random r)
        { 
            name = Names[r.Next(0, Names.Length)];
            age = r.Next(5, 70);
            gender = Genders[r.Next(0, Genders.Length)];
            classs = Classes[r.Next(0, Classes.Length)];
            race = Races[r.Next(0, Races.Length)];

        }

        public void randomize()
        {
            Random r = new Random();
            Name = Names[r.Next(0, Names.Length)];
            Age = r.Next(5, 70);
            Gender = Genders[r.Next(0, Genders.Length)];
            Class = Classes[r.Next(0, Classes.Length)];
            Race = Races[r.Next(0, Races.Length)];
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void PropertyHasChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

    }
}
