using back.Models.TestDir;
using Microsoft.EntityFrameworkCore;


namespace WEBBACK2.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
