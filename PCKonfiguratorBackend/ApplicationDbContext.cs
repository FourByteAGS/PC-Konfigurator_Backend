using Microsoft.EntityFrameworkCore;
using PCKonfiguratorBackend.Models;

namespace PCKonfiguratorBackend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<CPU> Cpus { get; set; }
        public DbSet<Mainboard> Mainboards { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<Fan> Fans { get; set; }
        public DbSet<CPUFan> CPUFans  { get; set; }
        public DbSet<PSU> PSUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Tower> Towers { get; set; }




    }
}
