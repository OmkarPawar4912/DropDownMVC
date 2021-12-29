using Microsoft.EntityFrameworkCore;
using EFCodeFirstApproch.Entity;

namespace EFCodeFirstApproch.Database
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions contextOptions) : base(contextOptions) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
