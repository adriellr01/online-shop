using OnlineShop.Application.User.Dto;
using OnlineShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.User
{
    public class UserAppService
    {
        private readonly IUserShopRepository _userShopRepository;

        public UserAppService(IUserShopRepository userShopRepository) { 
            _userShopRepository = userShopRepository;
        }

        public UserLoginDto LoginDto(string user, string password )
        {
            var loginUser = new UserLoginDto();
            var users = _userShopRepository.GetAll().Where(x=>(x.UserName==user && x.Password==password));
            
            loginUser.UserName = users.First().UserName;
            loginUser.Password = users.First().Password;
            loginUser.EmailAddress = users.First().EmailAddress;
            loginUser.Id = users.First().id;

            return loginUser;
        }
    }
}
