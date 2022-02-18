using MVCDemo.Controllers;
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
    /// Interaction logic for BulkInsertPage.xaml
    /// </summary>
    public partial class BulkInsertPage : Page
    {
        ContactsController controllerObj = new ContactsController();
        DataTable dtContacts, dt, cdt;
       


        public BulkInsertPage()
        {
            InitializeComponent();
            DisplayRecord();
            

        }

        private void dgContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selection changed here...
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            ///add logic here for removing of row in datatable
            DataRowView row = dgContacts.SelectedItem as DataRowView;
            dtContacts.Rows.Remove(row.Row);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender == btnNew)
            {
                ContactBulkCRUDWindow crudNew = new ContactBulkCRUDWindow();
                crudNew.ShowDialog();
                if (crudNew.DialogResult == true)
                {
                    DisplayRecord();
                }
            }
            else if (sender == btnUpdate)
            {
                
                ContactBulkEditWindow crudEdit = new ContactBulkEditWindow(cdt);
                crudEdit.ShowDialog();
                if (crudEdit.DialogResult == true)
                {
                    DisplayRecord();
                }
            }
            /* else if(sender == btnSave)
             {
                 controllerObj.dtContactsForSaving = dtContacts;
                 if (controllerObj.BulkSave(controllerObj))
                 {
                     MessageBox.Show("", "Succesfully Added!");
                     DisplayRecord();

                 }
             }*/
        }

        private void DisplayRecord()
        {
            dt = controllerObj.GetContacts("");
            dgContacts.ItemsSource = dt.DefaultView;
        }

        private void checkBoxClicked(object sender, EventArgs e)
        {
            cdt = new DataTable();
            cdt.Columns.Add("UserId", typeof(int));
            cdt.Columns.Add("FirstName", typeof(string));
            cdt.Columns.Add("MiddleName", typeof(string));
            cdt.Columns.Add("LastName", typeof(string));
            cdt.Columns.Add("Mobile", typeof(string));
            cdt.Columns.Add("Gender", typeof(string));

            DataRowView row = dgContacts.SelectedItem as DataRowView;
            cdt.Rows.Add(row.Row.ItemArray);   

        }

        public DataTable selectedDontacts()
        {
            return cdt;
        }

       

    }
}
