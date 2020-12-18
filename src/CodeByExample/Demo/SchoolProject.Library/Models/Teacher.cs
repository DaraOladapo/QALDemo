using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class Teacher : Person
    {
        public DateTime DateOfEmployment { get; set; }
        public decimal Salary { get; set; }
        public Course Course { get; set; }
    }
}
