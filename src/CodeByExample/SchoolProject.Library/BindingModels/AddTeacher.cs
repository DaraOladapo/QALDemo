using SchoolProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.BindingModels
{
    public class AddTeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string EmailAddress { get; set; }
        public string DateOfEmployment { get; set; }
        public decimal Salary { get; set; }
        public Course Course { get; set; }
    }
}
