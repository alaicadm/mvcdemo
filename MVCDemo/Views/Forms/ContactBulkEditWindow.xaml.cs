using MVCDemo.Controllers;
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
using System.Windows.Shapes;

namespace MVCDemo.Views.Forms
{
    /// <summary>
    /// Interaction logic for ContactBulkCRUDWindow.xaml
    /// </summary>
    public partial class ContactBulkEditWindow : Window
    {
        ContactsController controllerObj = new ContactsController();
        DataTable dtContacts, dt;
        //private int selectedRec;
        public ContactBulkEditWindow()
        {
            InitializeComponent();
            //initialize datatable schema
            //dtContacts = controllerObj.InitializeDTContact();
            DisplayRecord();
            ContentsFromRecord();
            
        }
        /*private void DisplayRecord()
        {
            dgContacts.ItemsSource = dtContacts.DefaultView;
        }*/

        private void DisplayRecord()
        {
            dt = controllerObj.GetContacts("");
            dgContacts.ItemsSource = dt.DefaultView;
        }
        private void ContentsFromRecord()
        {
            /*txtFName.Text = (string)((DataRowView)dgContacts.SelectedItem).Row[1];
            txtMName.Text = (string)((DataRowView)dgContacts.SelectedItem).Row[2];
            txtLName.Text = (string)((DataRowView)dgContacts.SelectedItem).Row[3];
            txtContactNo.Text = (string)((DataRowView)dgContacts.SelectedItem).Row[4];*/

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*if (sender == btnAdd)
            {
                PrepareFields();
                dtContacts = controllerObj.AddToContactsDT(dtContacts, controllerObj);
                txtFName.Clear();
                txtMName.Clear();
                txtLName.Clear();
                txtContactNo.Clear();
                rdbFemale.IsChecked = false;
                rdbMale.IsChecked = false;
            }*/
            if (sender == btnSave)
            {
                controllerObj.dtContactsForSaving = dtContacts;
                if (controllerObj.BulkSave(controllerObj))
                {
                    MessageBox.Show("Succesfully Added!");
                    this.DialogResult = true;

                }
            }
            else if (sender == btnClose)
                this.Close();
        }

        private void PrepareFields()
        {
            /*controllerObj.FirstName = txtFName.Text;
            controllerObj.MiddleName = txtMName.Text;
            controllerObj.LastName = txtLName.Text;
            controllerObj.Gender = "N/A";
            if (Utils.Utils.ToBool(rdbMale.IsChecked.Value) == true) controllerObj.Gender = "Male";
            if (Utils.Utils.ToBool(rdbFemale.IsChecked.Value) == true) controllerObj.Gender = "Female";
            controllerObj.Mobile = txtContactNo.Text;*/
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

        private void rdoGender_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
