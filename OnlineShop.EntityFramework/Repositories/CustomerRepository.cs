using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EntityFramework.Repositories
{
    public class CustomerRepository : ICustomerRepository

    {
        private readonly OnlineShopContext _db;

        public CustomerRepository(OnlineShopContext db)
        {
            _db = db;
        }

        public List<Customer> GetAll()
        {
            return _db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _db.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Customer Insert(Customer entity)
        {
            _db.Customers.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public Customer Update(Customer entity)
        {
            _db.Customers.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
                return;

            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }
    }
}
