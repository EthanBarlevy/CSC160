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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for db.xaml
    /// </summary>
    public partial class db : Window
    {
        public db()
        {
            InitializeComponent();
        }

        private void doit_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            sql = "Select ID, Name from Names";
            dt = ExDB.GetDataTable("CSC160", ht, sql);
            dg.ItemsSource = dt.DefaultView;
        }
    }
}
