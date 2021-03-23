using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EmployeeManagement.Data
{
    public class EMSContext : DbContext
    {
        // public EMSContext()
        // {

        // }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Department> Departments { get; set;}

    }
}