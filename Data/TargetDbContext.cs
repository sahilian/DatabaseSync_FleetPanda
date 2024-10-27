using DatabaseSync.Models.Target;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSync.Data
{
    public class TargetDbContext : DbContext
    {
        public DbSet<TargetCustomer> Customers { get; set; }
        public DbSet<TargetLocation> Locations { get; set; }
        public DbSet<SyncLog> SyncLogs { get; set; }

        public TargetDbContext(DbContextOptions<TargetDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TargetCustomer>()
                .HasMany(c => c.Locations)
                .WithOne(l => l.Customer)
                .HasForeignKey(l => l.CustomerID)
                .OnDelete(DeleteBehavior.Cascade); 
        }

    }

   
}
