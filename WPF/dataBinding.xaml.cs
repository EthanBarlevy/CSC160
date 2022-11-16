using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for dataBinding.xaml
    /// </summary>
    public partial class dataBinding : Window
    {
        ObservableCollection<Student> students = new ObservableCollection<Student>();
        public dataBinding()
        {
            InitializeComponent();
            DataContext = this;

            // manual bind in c#
            Binding binding = new Binding("Text");
            binding.Source = txtvalue;
            txtData.SetBinding(TextBlock.TextProperty, binding);

            students.Add(new Student() { ID = 1, Name = "Carlos" });
            students.Add(new Student() { ID = 2, Name = "Mark" });
            students.Add(new Student() { ID = 3, Name = "Dan" });
            lbStudents.ItemsSource = students;
        }

        private void updateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = txtTitle.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int newID = students[students.Count - 1].ID + 1;
            students.Add(new Student() { ID = newID, Name = "Alph" });
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            { 
                students.Remove((Student)lbStudents.SelectedItem);
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                // changing the list box is not the same as binding because it doesnt update for you
                ((Student)lbStudents.SelectedItem).Name = "Sharpae";
                lbStudents.Items.Refresh();
            }
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string name = "";

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }


    }
}
