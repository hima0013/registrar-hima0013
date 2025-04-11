using System.Collections.Generic;
using registrar_hima0013.Models;

namespace registrar_hima0013.Data
{
    public static class Helper
    {
        public static List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course
                {
                    Code = "CST8282",
                    Name = "Introduction to Database Systems",
                    WeeklyHours = 4
                },
                new Course
                {
                    Code = "CST8253",
                    Name = "Web Programming II",
                    WeeklyHours = 2
                },
                new Course
                {
                    Code = "CST8256",
                    Name = "Web Programming Language I",
                    WeeklyHours = 5
                },
                new Course
                {
                    Code = "CST8255",
                    Name = "Web Imaging and Animations",
                    WeeklyHours = 2
                },
                new Course
                {
                    Code = "CST8254",
                    Name = "Network Operating System",
                    WeeklyHours = 1
                },
                new Course
                {
                    Code = "CST2200",
                    Name = "Data Warehouse Design",
                    WeeklyHours = 3
                },
                new Course
                {
                    Code = "CST2240",
                    Name = "Advanced Database Topics",
                    WeeklyHours = 1
                }
            };
        }
    }
}
