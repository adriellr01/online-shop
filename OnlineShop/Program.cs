
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.ShoppingCarts;
using OnlineShop.Application.ShoppingCarts.Interfaces;
using OnlineShop.Application.Shops;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;
using OnlineShop.EntityFramework.Repositories;

namespace OnlineShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<OnlineShopContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });

            builder.Services.AddTransient<IShopRepository, ShopRepository>();
            builder.Services.AddTransient<IShoppingCartRepository, ShoppingCartRepository>();
            builder.Services.AddTransient<ShopAppService, ShopAppService>();

            builder.Services.AddTransient<IShoppingCartAppServices, ShoppingCartAppServices>();

            builder.Services.AddTransient<IOrderRepository, OrderRepository>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}