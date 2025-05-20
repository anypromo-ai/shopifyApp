using System.Collections.Generic;
using ShopifyApp.Info;

namespace ShopifyApp.Dac
{
    public class ProductDac
    {
        public List<ProductInfo> GetProducts()
        {
            // In a real app, replace with Shopify API calls or database access
            return new List<ProductInfo>
            {
                new ProductInfo { Id = 1, Name = "Sample Product", Price = 9.99m },
                new ProductInfo { Id = 2, Name = "Another Product", Price = 19.99m }
            };
        }
    }
}
