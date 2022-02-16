using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDemo.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int Age { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
