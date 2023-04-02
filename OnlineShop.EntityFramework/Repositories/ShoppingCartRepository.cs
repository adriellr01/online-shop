using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EntityFramework.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly OnlineShopContext _context;
        public ShoppingCartRepository(OnlineShopContext context)
        {
            _context = context;
        }

       
        public async Task<IEnumerable<ShoppingCart>> GetAll()
        {
            var shoppingCarts = await _context.ShoppingCarts.ToListAsync();
            return shoppingCarts;
        }

        public async Task<ShoppingCart> GetById(long id)
        {
                var currentShoppingCart = await _context.ShoppingCarts.FirstOrDefaultAsync(x => x.Id == id);
                if (currentShoppingCart is null)
                {
                    throw new Exception("No existe la Shopping Cart a la que hace referencia!!!!");
                }
                return currentShoppingCart;

        }

        public async Task Create(ShoppingCart shoppingCart)
        {
            _context.ShoppingCarts.Add(shoppingCart);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(ShoppingCart shoppingCart)
        {
            var currentShoppingCart =await GetById(shoppingCart.Id);
        
            currentShoppingCart.UserId = shoppingCart.UserId;
            currentShoppingCart.Subtotal = shoppingCart.Subtotal;
            currentShoppingCart.DeliveryPrice = shoppingCart.DeliveryPrice;
            currentShoppingCart.Tax = shoppingCart.Tax;
            currentShoppingCart.TotalPrice = shoppingCart.TotalPrice;
            currentShoppingCart.PaymentMethod = shoppingCart.PaymentMethod;

            int result = await _context.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> Delete(long id)
        {
            var currentShoppingCart = await GetById(id);
          
            _context.ShoppingCarts.Remove(currentShoppingCart);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
