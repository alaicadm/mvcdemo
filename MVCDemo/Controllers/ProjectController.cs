using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDemo.Controllers
{
    public class ProjectController : ProjectModel
    {
        ProjectController projectObj = new ProjectController();
        private ProjectController Sample()
        {
            projectObj.PersonID = 1;
            projectObj.Description = "HYBRAIN";
            return projectObj;
        }
    }
}
