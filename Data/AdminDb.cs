using Microsoft.EntityFrameworkCore;
using JobPortal.Model;

namespace JobPortal.Data
{
    public class AdminDb : DbContext
    {
        public AdminDb(DbContextOptions<AdminDb> options)
            : base(options)
        {
        }
        public DbSet<Model.Admin> Admins
        {
            get; set;
        }
    }
}
