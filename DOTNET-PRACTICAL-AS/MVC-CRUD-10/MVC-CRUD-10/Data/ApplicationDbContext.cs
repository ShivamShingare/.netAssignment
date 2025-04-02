using Microsoft.EntityFrameworkCore;
using MVC_CRUD_10.Models.Entities;

namespace MVC_CRUD_10.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        
    }
}
