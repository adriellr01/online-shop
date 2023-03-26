using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Entities;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopsController : ControllerBase
    {
        private readonly OnlineShopContext _dbContext;

        public ShopsController(OnlineShopContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
