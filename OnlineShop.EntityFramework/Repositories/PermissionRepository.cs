using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EntityFramework.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly OnlineShopContext _db;

        public PermissionRepository(OnlineShopContext db)
        {
            _db = db;
        }

        public List<Permission>GetAll()
        {
            return _db.Permissions.ToList();
        }

        public Permission GetById(int id)
        {
            return _db.Permissions.FirstOrDefault(x => x.Id == id);
        }

        public Permission Insert(Permission entity)
        {
            _db.Permissions.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public Permission Update(Permission entity)
        {
            _db.Permissions.Update(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var permission = _db.Permissions.FirstOrDefault(x => x.Id == id);
            if (permission == null)
                return;

            _db.Permissions.Remove(permission);
            _db.SaveChanges();
        }

    }
}
