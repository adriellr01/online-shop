using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.Shops;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;
using OnlineShop.EntityFramework.Repositories;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopsController : ControllerBase
    {
        private readonly ShopAppService _shopAppService;

        public ShopsController(ShopAppService shopAppService)
        {
            _shopAppService = shopAppService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var shops = _shopAppService.GetAll();
            return Ok(shops);
        }
    }
}
