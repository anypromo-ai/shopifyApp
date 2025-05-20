using ShopifyApp.Models;
using System.Collections.Generic;

namespace ShopifyApp.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Product A", Price = 19.99m },
            new Product { Id = 2, Name = "Product B", Price = 29.99m },
            new Product { Id = 3, Name = "Product C", Price = 39.99m }
        };

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}
