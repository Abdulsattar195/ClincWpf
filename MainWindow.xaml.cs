using System;
using System.Collections.Generic;
using System.IO;
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
using System.Drawing;

using Dapper;
using Microsoft.Data.SqlClient;

namespace CLINICwpv0
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

       
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
       
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            
        }

        private void btnl_Click(object sender, RoutedEventArgs e)
        {
            //var sql = "SELECT * FROM USER_TBL";

            //var ConnectionString = "Server=ABDULSATTAR-PC\\ABDULSATAR95;Database=CLINIC_DB;Trusted_Connection=True;MultipleActiveResultSets=true";
            //using (var  con = new SqlConnection(ConnectionString) )
            //{
            //    var user = con.Query(sql).ToList();

            //}
                Connect c = new Connect();
            
           Dashboard s = new Dashboard();

                if (c.check(txtUsername.Text, txtPassword.Password) == true)
                {
                    this.Hide();
                
                    s.Show();
                }
                else
                    
                    MessageBox.Show("Username Or Password is Wrong", "", MessageBoxButton.OK, MessageBoxImage.Information);
            
            



        }
    }
}
