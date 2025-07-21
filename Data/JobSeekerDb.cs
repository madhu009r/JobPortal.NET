using Microsoft.EntityFrameworkCore;
using JobPortal.Model;

namespace JobPortal.Data
{
    public class JobSeekerDb : DbContext
    {
        public JobSeekerDb(DbContextOptions<JobSeekerDb> options)
            : base(options)
        {

        }

        public DbSet<Model.JobSeeker> JobSeekers { get; set; }

    }
}
