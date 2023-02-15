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
            ht.Add("@Username", UsernameLogin.Text);
            ht.Add("@Password", PasswordLogin.Text);

            sql = "SELECT * FROM USERS WHERE Username = @Username AND Password = @Password";
            dt = ExDB.GetDataTable("AwesomeDB", ht, sql);
            if (dt.Rows.Count > 0) 
            {
                MessageBox.Show("You have been logged in");
                UsernameLogin.Text = "";
                PasswordLogin.Text = "";
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
            ht.Add("@Name", NameCreate.Text);
            ht.Add("@Username", UsernameCreate.Text);
            ht.Add("@Password", PasswordCreate.Text);
            ht.Add("@Email", EmailCreate.Text);

            sql = "SELECT * FROM USERS WHERE Username = @Username or Email = @Email";
            dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

            if (dt.Rows.Count == 0 && NameCreate.Text != "" && UsernameCreate.Text != "" && PasswordCreate.Text != "" && EmailCreate.Text != "")
            {
                sql = "INSERT INTO USERS (Name, Username, Password, Email) Values(@Name, @Username, @Password, @Email)";
                lngReturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("User already exists with that username or email or a field was left blank");
            }
        }
    }
}
