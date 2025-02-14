using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DB-Sets definieren
        public DbSet<ProductCollection> ProductCollection { get; set; }
    }
}
