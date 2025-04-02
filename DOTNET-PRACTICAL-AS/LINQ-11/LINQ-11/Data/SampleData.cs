using LINQ_11.Models;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Xml.Linq;

namespace LINQ_11.Data
{
    public static class SampleData
    {
        public static Student[] GetStudentArray()
        {
            return new Student[]
            {
                new Student { StudentID = 1, Name = "John", Age = 20, Major = "Computer Science" },
                new Student { StudentID = 2, Name = "Emily", Age = 21, Major = "Mathematics" },
                new Student { StudentID = 3, Name = "Mike", Age = 19, Major = "Physics" },
                new Student { StudentID = 4, Name = "Sarah", Age = 22, Major = "Computer Science" },
                new Student { StudentID = 5, Name = "David", Age = 20, Major = "Biology" }
            };
        }

        public static List<Student> GetStudentCollection()
        {
            return new List<Student>
            {
                new Student { StudentID = 6, Name = "Anna", Age = 23, Major = "Chemistry" },
                new Student { StudentID = 7, Name = "Brian", Age = 20, Major = "Computer Science" },
                new Student { StudentID = 8, Name = "Olivia", Age = 21, Major = "Mathematics" },
                new Student { StudentID = 9, Name = "James", Age = 22, Major = "Physics" },
                new Student { StudentID = 10, Name = "Sophia", Age = 19, Major = "Biology" }
            };
        }

        public static XDocument GetStudentXml()
        {
            return new XDocument(
                new XElement("Students",
                    new XElement("Student",
                        new XAttribute("ID", "101"),
                        new XElement("Name", "Alex"),
                        new XElement("Age", "24"),
                        new XElement("Major", "Engineering")),
                    new XElement("Student",
                        new XAttribute("ID", "102"),
                        new XElement("Name", "Beth"),
                        new XElement("Age", "22"),
                        new XElement("Major", "Computer Science")),
                    new XElement("Student",
                        new XAttribute("ID", "103"),
                        new XElement("Name", "Chris"),
                        new XElement("Age", "23"),
                        new XElement("Major", "Mathematics"))
                )
            );
        }

        public static void InitializeDatabase(SchoolContext context)
        {
            // Create database if not exists
            context.Database.CreateIfNotExists();

            if (!context.Students.Any())
            {
                var students = new List<Student>
                {
                    new Student{Name="Carson", Age=18, Major="History"},
                    new Student{Name="Meredith", Age=19, Major="Engineering"},
                    new Student{Name="Arturo", Age=20, Major="Computer Science"}
                };

                context.Students.AddRange(students);
                context.SaveChanges();

                var courses = new List<Course>
                {
                    new Course{Title="Calculus", StudentID=1},
                    new Course{Title="Physics", StudentID=1},
                    new Course{Title="Literature", StudentID=2},
                    new Course{Title="Chemistry", StudentID=3}
                };

                context.Courses.AddRange(courses);
                context.SaveChanges();
            }
        }
    }
}