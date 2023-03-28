using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;

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
