using Microsoft.EntityFrameworkCore;
using SchoolProject.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
