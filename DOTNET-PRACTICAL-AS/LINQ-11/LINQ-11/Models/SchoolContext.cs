using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_11.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
            // Disable initializer if you want to handle DB creation manually
            Database.SetInitializer<SchoolContext>(null);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithRequired(c => c.Student)
                .HasForeignKey(c => c.StudentID);
        }
    }
}
