using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Server_Side.Model
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(p => p.User)
                .WithMany(b => b.Orders);
            DbInitializer dbInitializer = new DbInitializer(modelBuilder);
            dbInitializer.SeedUser();
            dbInitializer.SeedOrder();

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set;}
    }
}
