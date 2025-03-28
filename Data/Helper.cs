using System.Collections.Generic;
using registrar_hima0013.Models;

namespace registrar_hima0013.Data
{
    public static class Helper
    {
        
        private static List<Student> _students = new List<Student>
        {
            new Student
            {
                Id = 314486,
                FirstName = "John",
                LastName = "Smith",
                Type = "Full Time",
                Courses = new List<Course>()
            },
            new Student
            {
                Id = 286072,
                FirstName = "Martha",
                LastName = "Jones",
                Type = "Part Time",
                Courses = new List<Course>()
            },
            new Student
            {
                Id = 791864,
                FirstName = "Rose",
                LastName = "Tyler",
                Type = "Coop",
                Courses = new List<Course>()
            }
        };

        
        public static List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course
                {
                    Code = "CST8282",
                    Title = "Introduction to Database Systems",
                    WeeklyHours = 4
                },
                new Course
                {
                    Code = "CST8253",
                    Title = "Web Programming II",
                    WeeklyHours = 2
                },
                new Course
                {
                    Code = "CST8256",
                    Title = "Web Programming Language I",
                    WeeklyHours = 5
                },
                new Course
                {
                    Code = "CST8255",
                    Title = "Web Imaging and Animations",
                    WeeklyHours = 2
                },
                new Course
                {
                    Code = "CST8254",
                    Title = "Network Operating System",
                    WeeklyHours = 1
                },
                new Course
                {
                    Code = "CST2200",
                    Title = "Data Warehouse Design",
                    WeeklyHours = 3
                },
                new Course
                {
                    Code = "CST2240",
                    Title = "Advance Database topics",
                    WeeklyHours = 1
                }
            };
        }

        
        public static List<string> GetStudentTypes()
        {
            return new List<string> { "Full Time", "Part Time", "Coop" };
        }

        
        public static List<Student> GetStudents()
        {
            return _students;
        }

        
        public static void AddStudent(Student student)
        {
            
            student.Id = new System.Random().Next(100000, 999999);

            if (student.Courses == null)
                student.Courses = new List<Course>();

            _students.Add(student);
        }
    }
}
