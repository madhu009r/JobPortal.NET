using Microsoft.EntityFrameworkCore;
using static JobPortal.Data.LoginDb;
using JobPortal.Model;

namespace JobPortal.Data
{
        public class LoginDb : DbContext
        {

            public LoginDb(DbContextOptions<LoginDb> options)
                : base(options)
            {
            }

            public DbSet<Login> login { get; set; }
        public object JobSeekers { get; internal set; }
    }
    }

