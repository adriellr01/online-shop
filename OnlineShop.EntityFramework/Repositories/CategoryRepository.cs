using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EntityFramework.Repositories
{
    public class CategoryRepository : ICategoryRepository

    {
        private readonly OnlineShopContext _db;

        public CategoryRepository(OnlineShopContext db)
        {
            _db = db;
        }




        public List<Category> GetAll()
        {
            return _db.Category.ToList();
        }

        public Category GetById(int id)
        {
            return _db.Category.FirstOrDefault(x => x.Id == id);
        }

        public Category Insert(Category entity)
        {
            _db.Category.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public Category Update(Category entity)
        {
            _db.Category.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var category = _db.Category.FirstOrDefault(x => x.Id == id);
            if (category != null)

                return;
            _db.Category.Remove(category);
            _db.SaveChanges();

        }
    }
}
