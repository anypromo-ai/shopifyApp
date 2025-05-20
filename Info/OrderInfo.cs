using System;

namespace ShopifyApp.Info
{
    public class OrderInfo
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
