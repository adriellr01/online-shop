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
using System.Net;

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
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetAll()
        {
            var shoppingCartsDtos = await _shoppingCartAppServices.GetAll();
            return Ok(shoppingCartsDtos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public async Task<ActionResult> GetById(long id)
        {
            try
            {
                var shoppingCartDto = await _shoppingCartAppServices.GetById(id);
                return Ok(shoppingCartDto);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> Create(ShoppingCartDto shoppingCartDto)
        {
            await _shoppingCartAppServices.Create(shoppingCartDto);
            return Ok(shoppingCartDto);
            
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> Update(ShoppingCartDto shoppingCartDto)
        {
            try
            {
                var result = await _shoppingCartAppServices.Update(shoppingCartDto);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> Delete(long id)
        {
            try
            {
                var result = await _shoppingCartAppServices.Delete(id);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

    }
}
