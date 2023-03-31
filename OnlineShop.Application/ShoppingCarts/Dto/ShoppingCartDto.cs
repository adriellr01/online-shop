namespace OnlineShop.Application.ShoppingCarts.Dto
{
    public class ShoppingCartDto
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