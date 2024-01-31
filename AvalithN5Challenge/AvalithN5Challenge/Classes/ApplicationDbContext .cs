using Microsoft.EntityFrameworkCore;

namespace AvalithN5Challenge.Classes
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PermissionType>().HasData(
                new PermissionType { Id = 1, Name = "Type1" });

            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 2, Name = "P1" });
        }

    }
}
