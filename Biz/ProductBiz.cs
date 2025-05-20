using System.Collections.Generic;
using ShopifyApp.Dac;
using ShopifyApp.Info;

namespace ShopifyApp.Biz
{
    public class ProductBiz
    {
        private readonly ProductDac _productDac;

        public ProductBiz()
        {
            _productDac = new ProductDac();
        }

        public List<ProductInfo> GetProducts()
        {
            return _productDac.GetProducts();
        }
    }
}
