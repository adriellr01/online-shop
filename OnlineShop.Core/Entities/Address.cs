using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Core.Entities
{
    public class Address
    {

        [Required]
        public long Id { get; set; }
        [Required, MaxLength(328)]
        public string FullAddress { get; set; }
        [Required, MaxLength(128)]
        public string Country { get; set; }
        [Required, MaxLength(128)]
        public string State { get; set; }
        [MaxLength(128)]
        public string City { get; set; }
        [MaxLength(256)]
        public string Street { get; set; }
        public int Number { get; set; }
       
    }
}
