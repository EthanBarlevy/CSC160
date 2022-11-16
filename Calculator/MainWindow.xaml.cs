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
        double gSecondDouble = double.MinValue;
        char gOperation = ' ';

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
                        if (gFirstDouble == double.MinValue || gSecondDouble == double.MinValue)
                        { 
                            gFirstDouble = double.MinValue;
                            gSecondDouble = double.MinValue;
                        }
                        if (gOperation != ' ')
                        {
                            gOperation = ' ';
                        }
                        break;
                    case "x2":
                        SetFirstDouble();
                        content = "";
                        gOperation = 'x';

                        break;
                    case "mod":
                        SetFirstDouble();
                        content = "";
                        gOperation = '%';

                        break;
                    case "dev":
                        SetFirstDouble();
                        content = "";
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
                        content = "";
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
                        content = "";
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
                        content = "";
                        gOperation = '+';

                        break;
                    case "dot":
                        if (content == "") content += "0.";
                        if(!CharExists(content, '.')) content += ".";
                        
                        break;
                    case "zer":
                        if(CharExists(content, '.')) content += "0";
                        else if (!content.StartsWith('0')) content += "0";
                        
                        break;
                    case "swp":
                        if (content.Length > 0)
                        { 
                            if(double.Parse(content) != 0)
                            {
                                content = (double.Parse(content) * -1).ToString();
                            }
                        }

                        break;
                    case "equ":
                        if (gFirstDouble != double.MinValue)
                        {
                            gSecondDouble = double.Parse(content);
                        }
                            if (gOperation != ' ')
                        {
                            if (gFirstDouble != double.MinValue)
                            { 
                                switch (gOperation) 
                                {
                                    case 'x':
                                        content = Math.Pow(gFirstDouble, gSecondDouble).ToString();
                                        break;
                                    case '*':
                                        content = (gFirstDouble * gSecondDouble).ToString();
                                        break;
                                    case '/':
                                        content = (gFirstDouble / gSecondDouble).ToString();
                                        break;
                                    case '+':
                                        content = (gFirstDouble + gSecondDouble).ToString();
                                        break;
                                    case '-':
                                        content = (gFirstDouble - gSecondDouble).ToString();
                                        break;
                                    case '%':
                                        content = (gFirstDouble % gSecondDouble).ToString();
                                        break;
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
            Output.Content = "";
        }
    }
}
