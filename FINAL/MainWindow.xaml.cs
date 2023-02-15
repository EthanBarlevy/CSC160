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

namespace FINAL
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

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();
            sql = "SELECT * FROM USERS";
            dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

            if (dt.Rows.Count > 0)
            {
                sql = "UPDATE Users SET Name='OwO' WHERE ID > 0";
                lngReturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
                UpdateResult.Content = "Database Ruined";
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Loop.Content += "apple";
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
