using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace OnlineShop.Entities
{
    public class Product
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ShopId { get; set; }
        [Required, MaxLength(256)] 
        public string Name { get; set; }        
        [Required, MaxLength(328)] 
        public string Description { get; set; }
        [Required, MaxLength(256)] 
        public string ImagePath { get; set; }
        [Required]
        public long Price { get; set; }
        [Required]
        public int SoldQuantity { get; set; }
        [Required]
        public bool IsActive { get; set; }

  
        

    }
}
