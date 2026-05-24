using Microsoft.EntityFrameworkCore;

namespace BTVN5.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cuộc sống" },
                new Category { Id = 2, Name = "Lập trình" },
                new Category { Id = 3, Name = "Sức Khỏe" }
            );
        }
    }
}
