using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class Student : Person
    {
        public virtual ICollection<CourseRegistration> CourseRegistrations { get; set; }
    }
}
