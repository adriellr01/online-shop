using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Entities
{
    public class User
    {
        
        public long id { get; set; }
        
        [Required,MaxLength(128)]
        public string Name { get; set; }

        [Required, MaxLength(128)]
        public string SureName { get; set; }

        [Required, MaxLength(256)]
        public string EmailAddress { get; set; }

        [Required, MaxLength(256)]
        public string UserName { get; set; }

        [Required, MaxLength(128)]
        public string Password { get; set; }
    
        [MaxLength(32)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(328)]
        public string EmailConfirmation { get; set; }

        [Required]
        public int AccessFailedCount { get; set; }
    }
}
