using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Repositories
{
    public interface IShopRepository
    {
        List<Shop> GetAll();
        Shop GetById(int id);
        Shop Insert(Shop entity);
        Shop Update(Shop entity);
        void Delete(int id);
    }
}
