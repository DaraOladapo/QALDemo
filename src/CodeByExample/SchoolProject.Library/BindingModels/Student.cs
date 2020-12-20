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
        public string EmailAddress { get; set; }
    }
    public class UpdateStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
