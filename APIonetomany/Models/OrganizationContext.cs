using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace APIonetomany.Models
{
    public class OrganizationContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public OrganizationContext(DbContextOptions<OrganizationContext> options):base(options)
        {
           
        }
    }
}
