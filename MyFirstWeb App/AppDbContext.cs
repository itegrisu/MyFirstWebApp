using Microsoft.EntityFrameworkCore;

namespace MyFirstWeb_App
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.ID); // Primary Key ayarlandı
        }
        public DbSet<User> User { get; set; }
    }
}
