using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MVCDemo.Models
{
    public class ContactsModel
    {
        public int User_ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DataTable dtContactsForSaving { get; set; }
        public DataTable dtContactsForDeleting { get; set; }
        public DataTable dtContactsForUpdating { get; set; }
    }
}
