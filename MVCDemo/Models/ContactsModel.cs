using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDemo.Models
{
    public class ContactsModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
    }
}
