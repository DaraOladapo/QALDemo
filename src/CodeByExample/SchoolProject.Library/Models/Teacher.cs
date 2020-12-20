using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Library.Models
{
    public class Teacher : Person
    {
        public virtual Course Course { get; set; }
    }
}
