using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Repositories
{
    public interface ICategoryRepository
    {

        List<Category> GetAll();
        Category GetById(int id);
        Category Insert(Category entity);
        Category Update(Category entity);
        void Delete(int id);
    }
}
