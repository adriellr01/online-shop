
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.ShoppingCarts.Dto;
using OnlineShop.Application.ShoppingCarts.Interfaces;
using OnlineShop.Application.Shops;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;

namespace OnlineShop.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderrepository;

        public OrderController(IOrderRepository orders)
        {
            _orderrepository = orders;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var order = _orderrepository.GetAll();
            return Ok(order);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var order = _orderrepository.GetById(id);
            return Ok(order);
        }



        [HttpPost]
        public ActionResult Insert(Order oder)
        {
            _orderrepository.Insert(oder);
            return Ok();

        }

        [HttpPut]
        public ActionResult Update(Order order)
        {
            var result = _orderrepository.Update(order);
            return Ok(result);

        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _orderrepository.GetById(id);
            if (result == null)
            {
                return Problem("Dato no existe");
            }
            return Ok(result);
        }

    }


    }
