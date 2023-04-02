using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Repositories
{
    public interface IPermissionRepository
    {
        List<Permission> GetAll();
        Permission GetById(int id);
        Permission Insert(Permission entity);
        Permission Update(Permission entity);
        void Delete(int id);


    }
}
