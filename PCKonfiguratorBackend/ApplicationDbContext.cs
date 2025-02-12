using Microsoft.EntityFrameworkCore;

namespace PCKonfiguratorBackend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DB-Sets definieren
        //public DbSet<User> Users { get; set; }
    }
}
