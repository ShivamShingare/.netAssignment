using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_11.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
