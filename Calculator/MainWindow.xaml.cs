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

namespace Calculator
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

        double gFirstDouble = double.MinValue;
        char gOperation = ' ';
        bool addedOperation = false;

        private void Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            if (name == null)
            { 
                e.Handled= true;
            }
            else
            {
                string content = (string)Output.Content;
                //MessageBox.Show(content);
                switch (name) 
                {
                    case "ce":
                        content = "";
                        break;
                    case "x2":
                        SetFirstDouble();
                        gOperation = 'x';

                        break;
                    case "mod":
                        SetFirstDouble();
                        gOperation = '%';

                        break;
                    case "dev":
                        SetFirstDouble();
                        gOperation = '/';

                        break;
                    case "sev":
                        content += "7";

                        break;
                    case "eig":
                        content += "8";

                        break;
                    case "nin":
                        content += "9";

                        break;
                    case "mul":
                        SetFirstDouble();
                        gOperation = '*';

                        break;
                    case "fou":
                        content += "4";

                        break;
                    case "fiv":
                        content += "5";

                        break;
                    case "six":
                        content += "6";

                        break;
                    case "sub":
                        SetFirstDouble();
                        gOperation = '-';

                        break;
                    case "one":
                        content += "1";
                        
                        break;
                    case "two":
                        content += "2";
                        
                        break;
                    case "thr":
                        content += "3";
                        
                        break;
                    case "add":
                        SetFirstDouble();
                        gOperation = '+';

                        break;
                    case "dot":
                        if (content == "") content += "0.";
                        if(!CharExists(content, '.')) content += ".";
                        
                        break;
                    case "zer":
                        content += "0";
                        
                        break;
                    case "swp":
                        if(!CharExists(content, '-')) content = "-" + content;
                        else if (CharExists(content, '-')) content = content.Replace('-', ' ');

                        break;
                    case "equ":
                        if (gOperation != ' ')
                        {
                            if (gFirstDouble != double.MinValue)
                            { 
                                switch (gOperation) 
                                { 
                                    
                                }
                            }
                        }
                        break;
                }
                Output.Content = content;
            }
        }

        private bool CharExists(string input, char ch)
        {
            foreach (char c in input)
            { 
                if(c == ch) return true;
            }
            return false;
        }

        private void SetFirstDouble()
        { 
            gFirstDouble = double.Parse((string)Output.Content);
        }
    }
}
