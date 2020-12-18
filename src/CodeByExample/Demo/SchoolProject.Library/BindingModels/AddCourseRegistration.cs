using SchoolProject.Library.Models;

namespace SchoolProject.Library.BindingModels
{
    public class AddCourseRegistration
    {
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}