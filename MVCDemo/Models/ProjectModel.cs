using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDemo.Models
{
    public class ProjectModel : PersonModel
    {
        public int ProjectID { get; set; }
        public string Description { get; set; }
    }
}
