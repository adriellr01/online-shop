using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Repositories
{
    public interface IPaymentRepository
    {

        List<Payment> GetAll();
        Payment GetByid(long id);
        Payment Insert(Payment Objeto);
        Payment Update(Payment Objeto);
        Payment Delete(long id);
       

    }
}
