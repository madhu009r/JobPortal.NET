using Microsoft.EntityFrameworkCore;
using JobPortal.Model;
namespace JobPortal.Data
{
    public class EmployeeDb : DbContext
    {
        public EmployeeDb(DbContextOptions<EmployeeDb> options)
            : base(options)
        {
        }
        public DbSet<Model.Employee> Employees { get; set; }
    }
    
}
