using Microsoft.AspNetCore.Mvc;
using SchoolProject.Library.BindingModels;
using SchoolProject.Library.Models;
using SchoolProject.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ApplicationDbContext DbContext;
        public CourseController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public ActionResult<IEnumerable<Course>> Get()
        {
            var allCourses = DbContext.Courses.ToList();
            return allCourses;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = DbContext.Courses.FirstOrDefault(c => c.ID == id);
            if (course != null)
                return course;
            else
                return NotFound("Sorry, no course was found with that ID.");
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult<Course> Post([FromBody] AddCourse addCourse)
        {
            var course = DbContext.Courses.FirstOrDefault(c => c.Code == addCourse.Code);
            if (course != null)
                return BadRequest("There is already a course with that code in the records.");
            else
            {
                var courseToAdd = new Course
                {
                    Title = addCourse.Title,
                    Code = addCourse.Code,
                    DateCreated = DateTime.Now,
                    LastUpdatedOn = DateTime.Now
                };
                var courseAdded = DbContext.Courses.Add(courseToAdd).Entity;
                DbContext.SaveChanges();
                return courseAdded;
            }
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult<Course> Put(int id, [FromBody] UpdateCourse updateCourse)
        {
            var course = DbContext.Courses.FirstOrDefault(c => c.ID == id);
            if (course == null)
                return NotFound("Sorry, no course was found with that ID.");
            else
            {
                course.Code = updateCourse.Code;
                course.Title = updateCourse.Title;
                course.LastUpdatedOn = DateTime.Now;
                DbContext.SaveChanges();
                return course;
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            var course = DbContext.Courses.FirstOrDefault(c => c.ID == id);
            if (course == null)
                return NotFound("Sorry, no course was found with that ID.");
            else
            {
                DbContext.Courses.Remove(course);
                DbContext.SaveChanges();
                return $"{course.Title} has been removed from the database.";
            }
        }
    }
}
