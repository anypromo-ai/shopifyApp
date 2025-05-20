using System.Collections.Generic;
using ShopifyApp.Info;

namespace ShopifyApp.Dac
{
    public static class ProductDac
    {
        public static List<ProductInfo> GetProducts()
        {
            return new List<ProductInfo>
            {
                new ProductInfo { Id = 1, Name = "Product A", Price = 19.99m },
                new ProductInfo { Id = 2, Name = "Product B", Price = 29.99m },
                new ProductInfo { Id = 3, Name = "Product C", Price = 39.99m }
            };
        }
    }
}
