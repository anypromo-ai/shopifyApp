using System.Collections.Generic;
using ShopifyApp.Info;
using ShopifyApp.Dac;

namespace ShopifyApp.Biz
{
    public class ProductBiz
    {
        public List<ProductInfo> GetAllProducts()
        {
            return ProductDac.GetProducts();
        }
    }
}
