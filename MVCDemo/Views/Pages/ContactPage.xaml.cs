using MVCDemo.Controllers;
using MVCDemo.Models;
using MVCDemo.Views.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVCDemo.Views.Pages
{
    /// <summary>
    /// Interaction logic for ContactPage.xaml
    /// </summary>
    public partial class ContactPage : Page
    {
        ContactsController controllerObj = new ContactsController();
        DataTable dt;
        public ContactPage()
        {
            InitializeComponent();
            Search();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool reload = false;
            if (sender == btnNew)
            {
                ContactCRUDWindow crudNew = new ContactCRUDWindow();
                crudNew.ShowDialog();
                if (crudNew.DialogResult == true)
                    reload = true;

            }
            else if (sender == btnEdit)
            {
                ContactCRUDWindow crudNew = new ContactCRUDWindow(controllerObj, true);
                crudNew.ShowDialog();
                if (crudNew.DialogResult == true)
                    reload = true;
            }
            
            else if (sender == btnView)
            {
                ContactCRUDWindow crudNew = new ContactCRUDWindow(controllerObj);
                crudNew.ShowDialog();
            }
            else if (sender == btnDelete)
            {
                try
                {
                    int selectedId = (int)((DataRowView)dgContacts.SelectedItem).Row[0];
                    controllerObj.User_ID = selectedId;

                    bool res = controllerObj.Delete(controllerObj);
                    if (res)
                    {
                        MessageBox.Show("Successfully deleted!");
                        reload = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please select from the list!");
                }
                
            }
            else if (sender == btnSearch)
                Search();
            
            if (reload)
                Search();
        }

        private void Search()
        {
            dt = controllerObj.GetContacts(txtSearch.Text);
            dgContacts.ItemsSource = dt.DefaultView;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Search();
        }

        private void dgContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView drv = dgContacts.SelectedItem as DataRowView;
            if (drv != null)
            {
                controllerObj.User_ID = Utils.Utils.ToInt(drv["User_ID"]);
                controllerObj.FirstName = drv["FirstName"].ToString();
                controllerObj.MiddleName = drv["MiddleName"].ToString();
                controllerObj.LastName = drv["LastName"].ToString();
                controllerObj.Gender = drv["Gender"].ToString();
                controllerObj.Mobile = drv["Mobile"].ToString();
            }
        }
    }
}
