using System.Collections.Generic;
using ShopifyApp.Dac;
using ShopifyApp.Info;

namespace ShopifyApp.Biz
{
    public class ProductBiz
    {
        private readonly ProductDac _dac = new ProductDac();

        public List<ProductInfo> GetAllProducts()
        {
            return _dac.GetProducts();
        }
    }
}
