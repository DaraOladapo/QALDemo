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
    public class TeacherController : ControllerBase
    {
        private ApplicationDbContext DbContext;
        public TeacherController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        // GET: api/<TeacherController>
        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> Get()
        {
            var allTeachers = DbContext.Teachers.ToList();
            return allTeachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            var teacher = DbContext.Teachers.FirstOrDefault(t => t.ID == id);
            if (teacher != null)
                return teacher;
            else
                return NotFound("Sorry, no teacher was found with that ID.");
        }

        // POST api/<TeacherController>
        [HttpPost]
        public ActionResult<Teacher> Post([FromBody] AddTeacher addTeacher)
        {
            var teacher = DbContext.Teachers.FirstOrDefault(t => t.EmailAddress == addTeacher.EmailAddress);
            if (teacher != null)
                return BadRequest("There is already a teacher with that email address in the records.");
            else
            {
                var teacherToAdd = new Teacher
                {
                    FirstName = addTeacher.FirstName,
                    LastName = addTeacher.LastName,
                    Salary = addTeacher.Salary,
                    DateCreated = DateTime.Now,
                    LastUpdatedOn = DateTime.Now,
                    DateOfEmployment = DateTime.Parse(addTeacher.DateOfEmployment),
                    EmailAddress = addTeacher.EmailAddress,
                };
                var teacherAdded = DbContext.Teachers.Add(teacherToAdd).Entity;
                DbContext.SaveChanges();
                return teacherAdded;
            }
        }
        [HttpPut("{id}/addcourse")]
        public ActionResult<Teacher> AddCourse(int id, [FromBody] int courseID)
        {
            var teacher = DbContext.Teachers.FirstOrDefault(t => t.ID == id);
            var course = DbContext.Courses.FirstOrDefault(c => c.ID == courseID);
            if (teacher != null && course != null)
            {
                teacher.Course = course;
                DbContext.SaveChanges();
                return teacher;
            }
            else
                return NotFound("Sorry, no teacher/course could be matched.");
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult<Teacher> Put(int id, [FromBody] UpdateTeacher updateTeacher)
        {
            var teacher = DbContext.Teachers.FirstOrDefault(c => c.ID == id);
            if (teacher == null)
                return NotFound("Sorry, no teacher was found with that ID.");
            else
            {
                teacher.FirstName = updateTeacher.FirstName;
                teacher.LastName = updateTeacher.LastName;
                teacher.Salary = updateTeacher.Salary;
                teacher.LastUpdatedOn = DateTime.Now;
                teacher.DateOfEmployment = DateTime.Parse(updateTeacher.DateOfEmployment);
                teacher.EmailAddress = updateTeacher.EmailAddress;
                DbContext.SaveChanges();
                return teacher;
            }
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            var teacher = DbContext.Teachers.FirstOrDefault(c => c.ID == id);
            if (teacher == null)
                return NotFound("Sorry, no teacher was found with that ID.");
            else
            {
                DbContext.Teachers.Remove(teacher);
                DbContext.SaveChanges();
                return $"{teacher.FullName} has been removed from the database.";
            }
        }
    }
}
