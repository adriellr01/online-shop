using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core.Entities
{
    public class Customer
    {
        [Required]
        public long Id { get; set; }

        [MaxLength(256)]
        public string FullName { get; set; }

        [MaxLength(256)]
        public string DeviceId { get; set; }

        public long UserId { get; set; }

        [MaxLength(64)]
        public string Identification { get; set; }
       
        [Required, MaxLength(256)]
        public string EmailAdress { get; set; }

        [MaxLength(32)]
        public string PhoneNumber { get; set; }

    }
}
