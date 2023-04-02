using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace OnlineShop.Entities
{
    public class Product
    {
        public long Id { get; set; }        
        public int CategoryId { get; set; }        
        public int ShopId { get; set; }
        [Required, MaxLength(256)] 
        public string Name { get; set; }        
        [MaxLength(512)] 
        public string Description { get; set; }
        [Required, MaxLength(256)] 
        public string ImagePath { get; set; }
        public long Price { get; set; }
        public int SoldQuantity { get; set; }
        public bool IsActive { get; set; }
 
    }
}
