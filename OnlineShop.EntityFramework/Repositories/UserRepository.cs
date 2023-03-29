using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Core.Repositories;
using OnlineShop.Core.Entities;


namespace OnlineShop.EntityFramework.Repositories
{
    public class UserRepository : IUserShopRepository
    {   
        public readonly OnlineShopContext _context;
        public UserRepository(OnlineShopContext context)
        {
            _context = context;
        }

        public void Delete(long id)
        {
            var delete_user = _context.Users.Where(u => u.id == id).FirstOrDefault();
            _context.Remove(delete_user);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(long id)
        {
            return _context.Users.FirstOrDefault(u => u.id == id);
        }

        public User Insert(User user)
        {
            _context.Add(user);
            _context.SaveChanges();

            return user;
        }

        public User Update(User user)
        {
            _context.Update(user);
            _context.SaveChanges(true);

            return user;

        }
    }
}
