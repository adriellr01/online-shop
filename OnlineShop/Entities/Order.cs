using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;


namespace OnlineShop.Entities
{
    public class Order
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public int ShopId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public decimal Subtotal { get; set; }
        [Required]
        public decimal DeliveryPrice { get; set; }
        [Required]
        public decimal Tax { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
    }
}
