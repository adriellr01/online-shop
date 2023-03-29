using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var shoppingCarts = await _shoppingCartRepository.GetAll();
            return Ok(shoppingCarts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var shoppingCart = await _shoppingCartRepository.GetById(id);
            return Ok(shoppingCart);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShoppingCart shoppingCart)
        {
            await _shoppingCartRepository.Create(shoppingCart);
            return Ok(shoppingCart);
            
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShoppingCart shoppingCart)
        {
           var result = await _shoppingCartRepository.Update(shoppingCart);
            return Ok(result);

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
           var result = await _shoppingCartRepository.Delete(id);
            return Ok(result);
        }

    }
}
