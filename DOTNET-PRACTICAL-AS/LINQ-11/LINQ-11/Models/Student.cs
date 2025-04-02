using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_11.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public List<Course> Courses { get; set; }
    }
}
