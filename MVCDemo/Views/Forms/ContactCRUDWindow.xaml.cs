using MVCDemo.Controllers;
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

namespace MVCDemo.Views.Forms
{
    /// <summary>
    /// Interaction logic for ContactCRUDWindow.xaml
    /// </summary>
    public partial class ContactCRUDWindow : Window
    {
        ContactsController controllerObj = new ContactsController();
        bool isEdit;
        public ContactCRUDWindow()
        {
            InitializeComponent();
        }

        public ContactCRUDWindow(ContactsController controllerObj,  bool isEdit = false)
        {
            InitializeComponent();
            this.controllerObj = controllerObj;
            this.isEdit = isEdit;
            InitFields();
           
        }

        private void InitFields()
        {
            if (!isEdit)
            {
                btnSave.Visibility = Visibility.Collapsed;
                txtContactNo.IsHitTestVisible = false;
                txtFName.IsHitTestVisible = false;
                txtMName.IsHitTestVisible = false;
                txtLName.IsHitTestVisible = false;
                txtGender.IsHitTestVisible = false;
                //isActiveBox.IsHitTestVisible = false;
                //rdbFemale.IsHitTestVisible = false;
                //rdbMale.IsHitTestVisible = false;
            }
            else
                btnSave.Content = "Edit"; 

            txtFName.Text =  controllerObj.FirstName;
            txtMName.Text = controllerObj.MiddleName;
            txtLName.Text =  controllerObj.LastName;
            txtGender.Text = controllerObj.Gender;
            //rdbMale.IsChecked = string.IsNullOrWhiteSpace(controllerObj.Gender) == true ? false : controllerObj.Gender == "Male" ? true : false;
            //rdbFemale.IsChecked = string.IsNullOrWhiteSpace(controllerObj.Gender) == true ? false : controllerObj.Gender == "Female" ? true : false;
            isActiveBox.IsEnabled = true;
            //insert checkbox state here

            //------------------review this line------------------
            //if (controllerObj.IsActive == 1) { isActiveBox.IsChecked = true; }
            //else if (controllerObj.IsActive == 0) { isActiveBox.IsChecked = false; }



            //controllerObj.IsActive = Utils.Utils.ToBool(isActiveBox.IsChecked.Value) == true ? 1 : 0;
            //MessageBox.Show("controllerobj.isactive: "+controllerObj.IsActive.ToString());

            //------------------review this line------------------
            //if (isActiveBox.IsChecked == true) { controllerObj.IsActive = 1; }
            //not working
            //isActiveBox.IsChecked = controllerObj.IsActive == 1 ? true : false;
            //MessageBox.Show("isactivebox.ischecked: " + isActiveBox.IsChecked.ToString());

            txtContactNo.Text = controllerObj.Mobile;
               
        }

        private void rdoGender_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender == btnSave)
            {
                bool res = false;
              
                PrepareFields();

                if (isEdit == false)
                    res = controllerObj.Save(controllerObj);
                else
                    res = controllerObj.Edit(controllerObj);

                if (res)
                {
                    //MessageBox.Show("Successfully Saved!");
                    //this.DialogResult = true;
                    if (controllerObj.closeD == true)
                    {
                        this.DialogResult = true;
                    }
                    
                }
            }
            
            

            else if (sender == btnClose)
            {
                this.DialogResult = false;
            }
        }
        /// <summary>
        /// ADD VALIDATIONS HERE.. 
        /// MUCH BETTER IF VALIDATIONS ADDED IN CONTROLLER
        /// </summary>
        private void PrepareFields()
        {
            controllerObj.FirstName = txtFName.Text;
            controllerObj.MiddleName = txtMName.Text;
            controllerObj.LastName = txtLName.Text;
            controllerObj.Gender = txtGender.Text;
            //if (Utils.Utils.ToBool(rdbMale.IsChecked.Value) == true) controllerObj.Gender = "Male";
            //if (Utils.Utils.ToBool(rdbFemale.IsChecked.Value) == true) controllerObj.Gender = "Female";
            //if (Utils.Utils.ToBool(isActiveBox.IsChecked.Value) == false) controllerObj.IsActive = 0;
          
            controllerObj.IsActive = Utils.Utils.ToBool(isActiveBox.IsChecked.Value) == true ? 1 : 0;
            //MessageBox.Show(controllerObj.IsActive.ToString());

            //controllerObj.IsActive = 1;
            controllerObj.Mobile = txtContactNo.Text;
        }
        
    }
}
