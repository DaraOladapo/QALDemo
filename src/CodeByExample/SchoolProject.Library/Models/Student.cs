using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class Student: Person
    {
        public int Grade { get; set; }
        //public List<Course> Courses { get; set; }
        public virtual  ICollection<CourseRegistration> CourseRegistrations { get; set; }

    }
}
