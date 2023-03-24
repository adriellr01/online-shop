using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Entities
{
    public class ShoppingCart
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public decimal Subtotal { get; set; }
        [Required]
        public decimal DeliveryPrice { get; set; }
        [Required]
        public decimal Tax { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]  
        public int PaymentMethod { get; set; }

    }
}
