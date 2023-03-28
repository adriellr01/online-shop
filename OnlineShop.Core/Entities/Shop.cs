using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Core.Entities
{
    public class Shop
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string BusinessName { get; set; }

        [StringLength(512)]
        public string Address { get; set; }

        [StringLength(64)]
        public string PhoneNumber { get; set; }

        public long? AdminUserId { get; set; }
        public bool IsActive { get; set; }
    }
}
