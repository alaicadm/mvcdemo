using MVCDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MVCDemo.Models
{
    public class ContactsModel : ControllerBase
    {
        private int userId;
        private string firstName, middleName, lastName, gender, mobile;
        private DataTable dtcSave;
        private DataTable dtcUpdate; 

        public int UserId { get { return userId; } set { userId = value; OnPropertyChanged("UserId"); } }
        public string FirstName { get { return firstName; } set { firstName = value; OnPropertyChanged("FirstName"); } }
        public string MiddleName { get { return middleName; } set { middleName = value; OnPropertyChanged("MiddleName"); } }
        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged("LastName"); } }
        public string Mobile { get { return mobile; } set { mobile = value; OnPropertyChanged("Mobile"); } }
        public string Gender { get { return gender; } set { gender = value; OnPropertyChanged("Gender"); } }
        public DataTable dtContactsForSaving { get { return dtcSave; } set { dtcSave = value; OnPropertyChanged("dtContactsForSaving"); } }
        public DataTable dtContactsForUpdating { get { return dtcUpdate; } set { dtcUpdate = value; OnPropertyChanged("dtContactsForUpdating"); } }
        public DataTable dtContactsForDeleting { get; set; }
    }
}
