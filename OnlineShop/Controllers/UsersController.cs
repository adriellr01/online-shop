using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using OnlineShop.EntityFramework;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserShopRepository _userShopRepository;

        public UsersController(IUserShopRepository userShopRepository)
        {
            _userShopRepository = userShopRepository ;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var users = _userShopRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            var user = _userShopRepository.GetById(id);

            return Ok(user);    
        }

        [HttpPost]
        public ActionResult PostUser(User user)
        {
            _userShopRepository.Insert(user);

            return Ok();
            
        }

        [HttpPut]
        public ActionResult UpdateUser(User user)
        {
            var userUpdate=_userShopRepository.Update(user);
            return Ok(userUpdate);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(long id) {

            var userDelete = _userShopRepository.GetById(id);
            if (userDelete == null) {

                return Problem("El usuario no existe");
            }

            _userShopRepository.Delete(userDelete.id);
            return Ok(userDelete);
        }

    }
}
