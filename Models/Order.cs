namespace Online_Retail_Store_v0.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public Customer Customer { get; set; }
        public string ProductId { get; set; }

    }
}
