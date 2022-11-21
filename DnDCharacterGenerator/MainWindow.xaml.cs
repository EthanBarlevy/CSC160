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

namespace DnDCharacterGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Character c;
        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
            c = new Character(r);
            this.DataContext = c;
        }

        private void Randomize_Click(object sender, RoutedEventArgs e)
        {
            c.randomize();
        }
    }
}
