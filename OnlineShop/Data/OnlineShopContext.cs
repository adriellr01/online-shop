using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Data
{
    public class OnlineShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public OnlineShopContext(DbContextOptions<OnlineShopContext> context)
            : base(context)
        {

        }
    }
}
