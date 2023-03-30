using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework.Migrations;

namespace OnlineShop.EntityFramework.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly OnlineShopContext _db;

        public PaymentRepository(OnlineShopContext db) 
        {
            _db = db;
        }


        public List<Payment> GetAll()
        {
            return _db.Payments.ToList();
            
        }
        public Payment GetByid(long id)
        {
            return  _db.Payments.FirstOrDefault(x => x.Id == id);
            //if (payment != null)
                //return payment;
                                
        }

        public Payment Insert( Payment Objeto)
        {

            _db.Add(Objeto);
            _db.SaveChanges();
            return Objeto;

        }

        public Payment Update(Payment objeto)
        {
            _db.Update(objeto);
            _db.SaveChanges();
            return objeto;

        }
        public void Delete(long id)
        {
           var payment = _db.Payments.FirstOrDefault(p => p.Id == id);
            if (payment != null)
            {
                _db.Remove(payment);
                _db.SaveChanges();
            }
            return;            
           
        }
       
    }
}
