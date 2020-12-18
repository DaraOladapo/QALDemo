using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Library.Models
{
    public class CourseRegistration
    {
        public int ID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}