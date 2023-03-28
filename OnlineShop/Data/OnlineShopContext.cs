using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Data
{
    public class OnlineShopContext : DbContext
    {
       
        public DbSet<Product> Products { get; set; }
       
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Payment> Payments { get; set; }


        public OnlineShopContext()
        {

        }

        public OnlineShopContext(DbContextOptions<OnlineShopContext> context)
            : base(context)
        {

        }
    }
}
