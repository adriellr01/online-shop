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

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryrepository;
        public CategoryController(ICategoryRepository category)
        {
            _categoryrepository = category;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryrepository.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _categoryrepository.GetById(id);
            return Ok(category);
        }

        [HttpPost]
        public ActionResult Insert(Category category)
        {
            _categoryrepository.Insert(category);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(Category category)
        {
            var result = _categoryrepository.Update(category);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _categoryrepository.GetById(id);
            if (result == null)
            {
                return Problem("Dato no existe");
            }
            return Ok(result);

        }

    }
}
