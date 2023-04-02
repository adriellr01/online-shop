using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.User.Dto
{
    public class UserLoginDto
    {
        public long Id { get; set; }    
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

    }
}
