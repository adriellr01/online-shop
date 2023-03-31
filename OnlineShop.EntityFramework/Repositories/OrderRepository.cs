using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;

namespace OnlineShop.EntityFramework.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OnlineShopContext _db;

        public OrderRepository(OnlineShopContext db)
        {
            _db = db;
        }

        public List<Order> GetAll()
        {
            return _db.Order.ToList();
        }

        public Order GetById(int id)
        {
            return _db.Order.FirstOrDefault(x => x.Id == id);
        }

        public Order Insert(Order entity)
        {
            _db.Order.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public Order Update(Order entity)
        {
            _db.Order.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var order = _db.Order.FirstOrDefault(x => x.Id == id);
            if (order == null)
                return;

            _db.Order.Remove(order);
            _db.SaveChanges();
        }



    }
}
