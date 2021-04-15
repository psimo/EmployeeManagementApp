using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Data.Models
{
    public partial class EmployeeManagementDbContext : DbContext
    {
        public EmployeeManagementDbContext()
        {
        }

        public EmployeeManagementDbContext(DbContextOptions<EmployeeManagementDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }
    }
}
