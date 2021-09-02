using System.Data.Entity;

namespace WebApplication2
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContextt() : base("name = MovieDbContext")
        {
        }

        public DbSet<Employee> Employee { get; set; }

    }
}