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
        DataTable dtContacts, dt, cdt;
        string genderVal;
        public ContactBulkEditWindow(DataTable cdt)
        {
            InitializeComponent();
            //initialize datatable schema
            //dtContacts = controllerObj.InitializeDTContact();
            DisplayRecord(cdt);
            ContentsFromRecord();
            dtContacts = cdt;
            
        }
       

        private void DisplayRecord(DataTable cdt)
        {
            //dt = controllerObj.GetContacts("");
            if (cdt != null)
            {
                try
                {
                    dgContacts.ItemsSource = cdt.DefaultView;
                }
                catch
                {
                    MessageBox.Show("You were not bable to select some records.");
                }
            }
            
           
        }
        private void ContentsFromRecord()
        {
            

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            if (sender == btnSave)
            {

                controllerObj.dtContactsForUpdating = dtContacts;


                if (controllerObj.BulkUpdate(controllerObj))
                {
                    MessageBox.Show("Succesfully Updated!");
                    this.DialogResult = true;
                    
                }
            }
            else if (sender == btnClose)
                this.Close();
                dtContacts.Clear();


        }


        private void PrepareFields()
        {
            
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



        private void genderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string genderVal = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            DataRowView row = dgContacts.CurrentItem as DataRowView;
            row["Gender"] = genderVal;


        }



        private void rdoGender_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
