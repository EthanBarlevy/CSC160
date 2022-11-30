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

        Names3 ds = new Names3(); // name of the .xsd file (dataset)
        Names3TableAdapters.NamesTableAdapter ad = new Names3TableAdapters.NamesTableAdapter();

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
            
            ht.Clear();
            ht.Add("@Name", "Johnny");
            ht.Add("@Title", "Master");
            //sql = "Insert into Names (Name, Title) Values(@Name, @Title)";
            //lngReturn = ExDB.ExecuteIt("CSC160", sql, ht);

            ht.Add("@ID", 3);
            //sql = "Updatate Names set Name=@Name, Title=@Title Where ID=@ID";
            //lngReturn = ExDB.ExecuteIt("CSC160", sql, ht);

            ht.Clear();
            ht.Add("@ID", 2);
            //sql = "Select ID, Name from Names where ID=@ID"; // and username=@unsername
            sql = "Select * from Names";
            dt = ExDB.GetDataTable("CSC160", ht, sql);

            /*if(dt.Rows.Count > 0 ) 
            { 
                DataRow dr;
                dr = dt.Rows[0];
                int intid = (int)dr["ID"];
                lblLabel.Content = intid;
            }*/


            dg.ItemsSource = dt.DefaultView;
        }
    }
}
