using Microsoft.EntityFrameworkCore;

namespace Server_Side.Model
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void SeedUser()
        {
            PasswordHasher passwordHasher = new PasswordHasher();
            _modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Username = "admin",
                    FirstName = "Bryan",
                    LastName = "Rodriguez",
                    PasswordHash = passwordHasher.HashPassword("admin"),
                    PhoneNumber = "8126972996",
                    Role = "admin"
                },
                new User()
                {
                    Username = "user",
                    FirstName = "Bryan",
                    LastName = "Rodriguez",
                    PasswordHash = passwordHasher.HashPassword("user"),
                    PhoneNumber = "8126972996",
                    Role = "user"
                },
                new User()
                {
                    Username = "admin3",
                    FirstName = "Bryan",
                    LastName = "Rodriguez",
                    PasswordHash = passwordHasher.HashPassword("admin"),
                    PhoneNumber = "8126972996",
                    Role = "user"
                },
                new User()
                {
                    Username = "admin4",
                    FirstName = "Bryan",
                    LastName = "Rodriguez",
                    PasswordHash = passwordHasher.HashPassword("admin"),
                    PhoneNumber = "8126972996",
                    Role = "user"
                },
                new User()
                {
                    Username = "admin5",
                    FirstName = "Bryan",
                    LastName = "Rodriguez",
                    PasswordHash = passwordHasher.HashPassword("admin"),
                    PhoneNumber = "8126972996",
                    Role = "user"
                }
            );
            
            
        }
        public void SeedOrder()
        {
            _modelBuilder.Entity<Order>().HasData(
                new Order() { OrderId = Guid.NewGuid(), Type = Order.OrderType.Standard, CustomerName = "Kroger", CreatedDate = DateTime.Now, CreatedByUsername = "admin" },
                new Order() { OrderId = Guid.NewGuid(), Type = Order.OrderType.SaleOrder, CustomerName = "Taget", CreatedDate = DateTime.Now, CreatedByUsername = "user" },
                new Order() { OrderId = Guid.NewGuid(), Type = Order.OrderType.PurchaseOrder, CustomerName = "Apple", CreatedDate = DateTime.Now, CreatedByUsername = "admin3" },
                new Order() { OrderId = Guid.NewGuid(), Type = Order.OrderType.TransferOrder, CustomerName = "Microsoft", CreatedDate = DateTime.Now, CreatedByUsername = "admin4" },
                new Order() { OrderId = Guid.NewGuid(), Type = Order.OrderType.ReturnOrder, CustomerName = "Google", CreatedDate = DateTime.Now, CreatedByUsername = "admin5" }
                );
        }
    }
}
