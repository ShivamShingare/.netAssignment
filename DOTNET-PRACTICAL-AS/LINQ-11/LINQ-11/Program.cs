using LINQ_11.Data;
using LINQ_11.Models;

using System;
using System.Linq;
using System.Xml.Linq;

namespace LINQ_11.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Demonstration Project\n");

            // LINQ to Array
            DemonstrateLinqToArray();

            // LINQ to Collection
            DemonstrateLinqToCollection();

            // LINQ to XML
            DemonstrateLinqToXml();

            // LINQ to SQL
            DemonstrateLinqToSql();

            Console.WriteLine("\nAll demonstrations completed.");
            Console.ReadKey();
        }

        static void DemonstrateLinqToArray()
        {
            Console.WriteLine("\n=== LINQ to Array ===");

            var students = SampleData.GetStudentArray();

            // Query syntax
            var csStudents = from student in students
                             where student.Major == "Computer Science"
                             select student;

            Console.WriteLine("\nComputer Science Students (Query Syntax):");
            foreach (var student in csStudents)
            {
                Console.WriteLine($"{student.Name} ({student.Age} years)");
            }

            // Method syntax
            var youngStudents = students.Where(s => s.Age < 21)
                                     .OrderBy(s => s.Name);

            Console.WriteLine("\nStudents younger than 21 (Method Syntax):");
            foreach (var student in youngStudents)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }
        }

        static void DemonstrateLinqToCollection()
        {
            Console.WriteLine("\n=== LINQ to Collection ===");

            var students = SampleData.GetStudentCollection();

            // Group by major
            var studentsByMajor = from student in students
                                  group student by student.Major into majorGroup
                                  orderby majorGroup.Key
                                  select majorGroup;

            Console.WriteLine("\nStudents grouped by Major:");
            foreach (var majorGroup in studentsByMajor)
            {
                Console.WriteLine($"\nMajor: {majorGroup.Key}");
                foreach (var student in majorGroup)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }

            // Aggregation
            var averageAge = students.Average(s => s.Age);
            Console.WriteLine($"\nAverage age of students: {averageAge:F1}");
        }

        static void DemonstrateLinqToXml()
        {
            Console.WriteLine("\n=== LINQ to XML ===");

            // From code
            var xmlFromCode = SampleData.GetStudentXml();
            Console.WriteLine("\nStudents from generated XML:");
            var studentsFromCode = from student in xmlFromCode.Descendants("Student")
                                   select new
                                   {
                                       ID = student.Attribute("ID").Value,
                                       Name = student.Element("Name").Value,
                                       Major = student.Element("Major").Value
                                   };

            foreach (var student in studentsFromCode)
            {
                Console.WriteLine($"{student.ID}: {student.Name} studies {student.Major}");
            }

            // From file
            try
            {
                var xmlFromFile = XDocument.Load("XmlFiles/Students.xml");
                Console.WriteLine("\nStudents from XML file:");
                var studentsFromFile = from student in xmlFromFile.Descendants("Student")
                                       select new
                                       {
                                           ID = student.Attribute("ID").Value,
                                           Name = student.Element("Name").Value,
                                           Age = student.Element("Age").Value
                                       };

                foreach (var student in studentsFromFile)
                {
                    Console.WriteLine($"{student.ID}: {student.Name}, age {student.Age}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError loading XML file: {ex.Message}");
            }
        }

        static void DemonstrateLinqToSql()
        {
            Console.WriteLine("\n=== LINQ to SQL ===");

            using (var context = new SchoolContext())
            {
                SampleData.InitializeDatabase(context);

                // Query all students
                var allStudents = from student in context.Students
                                  orderby student.Name
                                  select student;

                Console.WriteLine("\nAll Students in Database:");
                foreach (var student in allStudents)
                {
                    Console.WriteLine($"{student.StudentID}: {student.Name}, {student.Major}");
                }

                // Query with navigation property
                var studentCourses = from student in context.Students
                                     where student.Courses.Any()
                                     select new
                                     {
                                         student.Name,
                                         Courses = student.Courses.Select(c => c.Title)
                                     };

                Console.WriteLine("\nStudents and Their Courses:");
                foreach (var item in studentCourses)
                {
                    Console.WriteLine($"{item.Name} takes: {string.Join(", ", item.Courses)}");
                }

                // Method syntax with conditions
                var csStudents = context.Students
                                      .Where(s => s.Major == "Computer Science")
                                      .OrderByDescending(s => s.Age);

                Console.WriteLine("\nComputer Science Students (Method Syntax):");
                foreach (var student in csStudents)
                {
                    Console.WriteLine($"{student.Name}, age {student.Age}");
                }
            }
        }
    }
}