using System;
using System.Collections.Generic;

namespace InheritanceLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Ben = new Student
            {
                FirstName = "Ben",
                LastName = "Roger",
                CourseTitles = new List<string>()
                {
                    "C#", "SQL", "ASP.NET"
                }
            };
            Student Jane = new Student
            {
                FirstName = "Jane",
                LastName = "Smith",
                CourseTitles = new List<string>()
                {
                    "C#", "Python"
                }
            };
            Teacher Dara = new Teacher
            {
                FirstName = "Dara",
                LastName = "Oladapo",
                Students = new List<Student>()
                {
                    Ben, Jane
                }
            };
            Console.WriteLine($"Teacher {Dara.FullName} has {Dara.Students.Count} students");
        }
    }
}
