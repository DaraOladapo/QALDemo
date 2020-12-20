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
        public string EmailAddress { get; set; }
        public Course Course { get; set; }
    }
    public class UpdateTeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
