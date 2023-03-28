using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.EntityFramework;

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

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var shops = await _dbContext.Shops.ToListAsync();
            return Ok(shops);
        }
    }
}
