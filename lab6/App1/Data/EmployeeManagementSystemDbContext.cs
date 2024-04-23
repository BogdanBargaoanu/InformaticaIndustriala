using App1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace App1.Data
{
    public class EmployeeManagementSystemDbContext : DbContext
    {
        public EmployeeManagementSystemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
