using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;


namespace OnlineShop.EntityFramework
{
    public class OnlineShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<User > Users { get; set; }

        public OnlineShopContext(DbContextOptions<OnlineShopContext> context)
            : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}