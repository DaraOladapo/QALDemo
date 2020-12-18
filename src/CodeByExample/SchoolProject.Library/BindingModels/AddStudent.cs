using SchoolProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.BindingModels
{
    public class AddStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Grade { get; set; }
    }
}
