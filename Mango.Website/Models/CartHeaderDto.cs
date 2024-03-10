namespace Mango.Website.Models 
{ 
    public class CartHeaderDto
    {
        public int CartHeaderId { get; set; }
        public string? UserId { get; set; }
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public double CartTotal { get; set; }
    }
}
