using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Repositories
{
    public interface IUserShopRepository
    {
        List<User> GetAll();
        User GetById(long id);
        User Insert(User user);
        User Update(User user);
        void Delete(long id);
    }
}
