using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Repositories
{
    public interface IShoppingCartRepository
    {
        Task<IEnumerable<ShoppingCart>> GetAll();
        Task<ShoppingCart> GetById(long id);
        Task Create(ShoppingCart shoppingCart);
        Task<bool> Update(ShoppingCart shoppingCart);
        Task<bool> Delete(long id);
        
    }
}