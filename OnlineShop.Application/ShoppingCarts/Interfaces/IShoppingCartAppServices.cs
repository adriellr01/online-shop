using OnlineShop.Application.ShoppingCarts.Dto;
using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.ShoppingCarts.Interfaces
{
    public interface IShoppingCartAppServices
    {
        Task<IEnumerable<ShoppingCartDto>> GetAll();
        Task<ShoppingCartDto> GetById(long id);
        Task Create(ShoppingCartDto shoppingCart);
        Task<bool> Update(ShoppingCartDto shoppingCart);
        Task<bool> Delete(long id);
    }
}
