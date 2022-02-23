using MVCDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MVCDemo.Models
{
    public class ContactsModel : ControllerBase
    {
        
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set;  }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public int IsActive { get; set; }

        public DataTable dtContactsForSaving { get; set; }
        public DataTable dtContactsForUpdating { get; set; }
        public DataTable dtContactsForDeleting { get; set; }


        public int isChecked { get; set; }
    }
}
