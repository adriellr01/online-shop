using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;
using OnlineShop.EntityFramework.Repositories;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopsController : ControllerBase
    {
        private readonly IShopRepository _shopRepository;

        public ShopsController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var shops = _shopRepository.GetAll();
            return Ok(shops);
        }
    }
}
