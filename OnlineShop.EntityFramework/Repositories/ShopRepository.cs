using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EntityFramework.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly OnlineShopContext _db;

        public ShopRepository(OnlineShopContext db)
        {
            _db = db;
        }

        public List<Shop> GetAll()
        {
            return _db.Shops.ToList();
        }

        public Shop GetById(int id)
        {
            return _db.Shops.FirstOrDefault(x => x.Id == id);
        }

        public Shop Insert(Shop entity)
        {
            _db.Shops.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public Shop Update(Shop entity)
        {
            _db.Shops.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var shop = _db.Shops.FirstOrDefault(x => x.Id == id);
            if (shop == null)
                return;

            _db.Shops.Remove(shop);
            _db.SaveChanges();
        }
    }
}
