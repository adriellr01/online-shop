using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.ShoppingCarts.Dto;
using OnlineShop.Application.ShoppingCarts.Interfaces;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartAppServices _shoppingCartAppServices;

        public ShoppingCartController(IShoppingCartAppServices shoppingCartAppServices)
        {
            _shoppingCartAppServices = shoppingCartAppServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var shoppingCartsDtos = await _shoppingCartAppServices.GetAll();
            return Ok(shoppingCartsDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var shoppingCartDto = await _shoppingCartAppServices.GetById(id);
            return Ok(shoppingCartDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShoppingCartDto shoppingCartDto)
        {
            await _shoppingCartAppServices.Create(shoppingCartDto);
            return Ok(shoppingCartDto);
            
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShoppingCartDto shoppingCartDto)
        {
           var result = await _shoppingCartAppServices.Update(shoppingCartDto);
            return Ok(result);

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
           var result = await _shoppingCartAppServices.Delete(id);
            return Ok(result);
        }

    }
}
