using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Core.Entities;
using OnlineShop.EntityFramework;

namespace OnlineShop.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {

        private readonly OnlineShopContext _dbContext;
         public PaymentController(OnlineShopContext dbContext)
        {
            _dbContext = dbContext;
        }
     }
}


