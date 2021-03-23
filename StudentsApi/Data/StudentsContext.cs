using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;
namespace StudentsApi.Data
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options):base(options)
        {

        }

        public DbSet<Student> Student { get; set; }


    }
    
}