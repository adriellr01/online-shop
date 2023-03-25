using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Data
{
    public class OnlineShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Address> Address { get; set; }
        public OnlineShopContext(DbContextOptions<OnlineShopContext> context)
            : base(context)
        {

        }
        
    }
}
