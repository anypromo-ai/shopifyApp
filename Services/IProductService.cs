using ShopifyApp.Models;
using System.Collections.Generic;

namespace ShopifyApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
