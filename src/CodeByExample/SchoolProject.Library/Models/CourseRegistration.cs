using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class CourseRegistration
    {
        public int ID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
