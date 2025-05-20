using System;

namespace ShopifyApp.Info.Models
{
    public class OrderInfo
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
