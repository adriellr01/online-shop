using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Core.Entities
{
    public class Category
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Type { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }
        [Required, MaxLength(256)]
        public string ImagePath { get; set; }
        [Required]
        public bool IsActive { get; set; }



    }
}
