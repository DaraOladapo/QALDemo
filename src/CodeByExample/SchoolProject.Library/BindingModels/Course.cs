using SchoolProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.BindingModels
{
    public class AddCourse
    {
        public string Title { get; set; }
        public string Code { get; set; }
    }
    public class AddCourseRegistration
    {
        public int CourseID{ get; set; }
        public int StudentID { get; set; }
    }
    public class UpdateCourse
    {
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
