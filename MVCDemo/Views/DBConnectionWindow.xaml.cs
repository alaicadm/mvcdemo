using MVCDemo.Controllers;
using MVCDemo.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVCDemo.Views
{
    /// <summary>
    /// Interaction logic for DBConnectionWindow.xaml
    /// </summary>
    public partial class DBConnectionWindow : Window
    {
        DBConnectionController dbConn = new DBConnectionController();
        public DBConnectionWindow()
        {
            InitializeComponent();
           
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnConnect)
            {
               // dialogHost2.IsOpen = true;
                dbConn.Server = txtServer.Text;
                dbConn.UserName = txtUserName.Text;
                dbConn.PassWord = txtPassword.Password;
                dbConn.DataBase = txtDBName.Text;
                dbConn.Integratedsecurity = chkIntegrated.IsChecked.Value;
                dbConn.Encrypt = chkEncrypted.IsChecked.Value;
                dbConn.Trustservercertificate = chkTrustServerCertificate.IsChecked.Value;
                Globals.DBName = txtDBName.Text;
                bool res = dbConn.ConnectToDB(dbConn);
                if (res)
                {
                    
                    MainWindow main = new MainWindow();
                    main.Show();
                    //this.Visibility = Visibility.Hidden;
                    this.Close();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.DBConnServer.ToString();
            txtUserName.Text = Properties.Settings.Default.DBConnUsername.ToString();
            txtPassword.Password = Properties.Settings.Default.DBConnPassword.ToString();
            txtDBName.Text = Properties.Settings.Default.DBConnDatabase.ToString();
            chkIntegrated.IsChecked = Properties.Settings.Default.DBIntegratedSecurity;
            chkEncrypted.IsChecked = Properties.Settings.Default.DBEncrypt;
            chkTrustServerCertificate.IsChecked = Properties.Settings.Default.DBTrustServerCertificate;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ServerErrorClickEvent(object sender, RoutedEventArgs e)
        {

        }
    }
}
