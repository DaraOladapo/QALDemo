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
    public class StudentController : ControllerBase
    {
        private ApplicationDbContext DbContext;
        public StudentController(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var allStudents = DbContext.Students.ToList();
            return allStudents;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var student = DbContext.Students.FirstOrDefault(s => s.ID == id);
            if (student != null)
                return student;
            else
                return NotFound("Sorry, no student was found with that ID.");
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult<Student> Post([FromBody] AddStudent addStudent)
        {
            var student = DbContext.Students.FirstOrDefault(
                s => s.FullName == addStudent.FullName && s.Grade == addStudent.Grade && s.Courses == addStudent.Courses);
            if (student != null)
                return BadRequest("There is already a student with those details in the records.");
            else
            {
                var studentToAdd = new Student
                {
                    FirstName = addStudent.FirstName,
                    LastName = addStudent.LastName,
                    Courses = addStudent.Courses,
                    Grade = addStudent.Grade,
                    DateCreated = DateTime.Now,
                    LastUpdatedOn = DateTime.Now
                };
                var studentAdded = DbContext.Students.Add(studentToAdd).Entity;
                DbContext.SaveChanges();
                return studentAdded;
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult<Student> Put(int id, [FromBody] UpdateStudent updateStudent)
        {
            var student = DbContext.Students.FirstOrDefault(s => s.ID == id);
            if (student == null)
                return NotFound("Sorry, no student was found with that ID.");
            else
            {
                student.FirstName = updateStudent.FirstName;
                student.LastName = updateStudent.LastName;
                student.Courses = updateStudent.Courses;
                student.Grade = updateStudent.Grade;
                student.LastUpdatedOn = DateTime.Now;
                DbContext.SaveChanges();
                return student;
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            var student = DbContext.Students.FirstOrDefault(s => s.ID == id);
            if (student == null)
                return NotFound("Sorry, no student was found with that ID.");
            else
            {
                DbContext.Students.Remove(student);
                DbContext.SaveChanges();
                return $"{student.FullName} has been removed from the database.";
            }
        }
    }
}