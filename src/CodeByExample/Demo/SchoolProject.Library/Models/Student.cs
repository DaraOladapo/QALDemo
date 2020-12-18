using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class Student: Person
    {
        public List<CourseRegistration> CourseRegistrations { get; set; }
    }
}
