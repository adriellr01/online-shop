using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Entities;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly OnlineShopContext _context;

        public ShoppingCartController(OnlineShopContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<ShoppingCart>>> GetAll()
        {
            return await _context.ShoppingCarts.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingCart>> GetById(long id)
        {
            var item = await _context.ShoppingCarts.FirstOrDefaultAsync(x => x.Id == id);
            if (item is null)
            {
               return NotFound(); 
            }
            return item;
        }


        [HttpPost]
        public async Task<ActionResult> Create(ShoppingCart shoppingCart)
        { 
            await _context.ShoppingCarts.AddAsync(shoppingCart);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:long}")]
        public async Task<ActionResult> Update(long id, ShoppingCart shoppingCart)
        {
            var item = await _context.ShoppingCarts.FindAsync(id);
            if (item is null)
            {
                return NotFound();
            }
            item.UserId = shoppingCart.UserId;
            item.Subtotal = shoppingCart.Subtotal;
            item.DeliveryPrice = shoppingCart.DeliveryPrice;
            item.Tax = shoppingCart.Tax;
            item.TotalPrice = shoppingCart.TotalPrice;
            item.PaymentMethod = shoppingCart.PaymentMethod;
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("{id:long}")]
        public async Task<ActionResult> Delete(long id)
        {
            var itemToDelete = await _context.ShoppingCarts.FindAsync(id);
            if (itemToDelete != null)
            {
                _context.ShoppingCarts.Remove(itemToDelete);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            return NotFound();
        }
    }
}
