using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
