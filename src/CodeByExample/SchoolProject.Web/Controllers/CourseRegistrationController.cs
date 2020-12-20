using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Library.BindingModels;
using SchoolProject.Library.Models;
using SchoolProject.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseRegistrationController : ControllerBase
    {
        private ApplicationDbContext DbContext;
        public CourseRegistrationController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        // GET: api/<CourseRegistrationController>
        [HttpGet]
        public ActionResult<IEnumerable<CourseRegistration>> Get()
        {
            var allCourseRegistrations = DbContext.CourseRegistrations.ToList();
            return allCourseRegistrations;
        }

        // GET api/<CourseRegistrationController>/5
        [HttpGet("{id}")]
        public ActionResult<CourseRegistration> Get(int id)
        {
            var courseRegistration = DbContext.CourseRegistrations.FirstOrDefault(c => c.ID == id);
            if (courseRegistration != null)
                return courseRegistration;
            else
                return NotFound("Sorry, no course registration was found with that ID.");
        }

        // POST api/<CourseRegistrationController>
        [HttpPost]
        public ActionResult<CourseRegistration> Post([FromBody] AddCourseRegistration addCourseRegistration)
        {
            var courseRegistration = DbContext.CourseRegistrations.FirstOrDefault(c => c.Course.ID == addCourseRegistration.CourseID && c.Student.ID == addCourseRegistration.StudentID);
            var courseFound = DbContext.Courses.FirstOrDefault(c => c.ID == addCourseRegistration.CourseID);
            var studentFound = DbContext.Students.FirstOrDefault(c => c.ID == addCourseRegistration.StudentID);
            if (courseRegistration != null)
                return BadRequest("There is already a course registration with that student in the records.");
            else
            {
                var courseRegistrationToAdd = new CourseRegistration
                {
                    Course = courseFound,
                    Student = studentFound,
                    RegistrationDate = DateTime.Now
                };
                var courseRegistrationAdded = DbContext.CourseRegistrations.Add(courseRegistrationToAdd).Entity;
                DbContext.SaveChanges();
                return courseRegistrationAdded;
            }

        }

        // PUT api/<CourseRegistrationController>/5
        //[HttpPut("{id}")]
        //public ActionResult<CourseRegistration> Put(int id, [FromBody] AddCourseRegistration updateCourseRegistration)
        //{
        //    var courseRegistration = DbContext.CourseRegistrations.FirstOrDefault(c => c.ID == id);
        //    if (courseRegistration == null)
        //        return NotFound("Sorry, no course registration was found with that ID.");
        //    else
        //    {
        //        courseRegistration.Course = updateCourseRegistration.Course;
        //        courseRegistration.Student = updateCourseRegistration.Student;
        //        DbContext.SaveChanges();
        //        return courseRegistration;
        //    }
        //}

        // DELETE api/<CourseRegistrationController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            var courseRegistration = DbContext.CourseRegistrations.FirstOrDefault(c => c.ID == id);
            if (courseRegistration == null)
                return NotFound("Sorry, no course registration was found with that ID.");
            else
            {
                DbContext.CourseRegistrations.Remove(courseRegistration);
                DbContext.SaveChanges();
                return $"{courseRegistration.Course.Title} has been removed for {courseRegistration.Student.FullName} from the database.";
            }
        }
    }
}

