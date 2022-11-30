using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

namespace Login
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

        private void login_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();
            ht.Add("@Username", "Master");
            ht.Add("@Password", "Password");

            sql = "SELECT * FROM USERS WHERE Username = @Username AND Password = @Password";
            dt = ExDB.GetDataTable("AwesomeDB", ht, sql);
            if (dt != null) 
            {
                MessageBox.Show("You have been logged in");
            }
            else 
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void NewUser_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();
            ht.Add("@Name", "Johnny");
            ht.Add("@Username", "Master");
            ht.Add("@Password", "Password");
            ht.Add("@Email", "Email");

            sql = "SELECT * FROM USERS WHERE Username = @Username or Email = @Email";
            dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

            if(dt == null) 
            { 
                sql = "INSERT INTO USERS (Name, Username, Password, Email) Values(@Name, @Username, @Password, @Email)";
                lngReturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
            }
        }
    }
}
