using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Core.Entities
{
    public class ShoppingCart
    {
        public long Id { get; set; }
        public long UserId { get; set; }      
        public decimal Subtotal { get; set; }      
        public decimal DeliveryPrice { get; set; }    
        public decimal Tax { get; set; }      
        public decimal TotalPrice { get; set; }  
        public int PaymentMethod { get; set; }

    }
}
