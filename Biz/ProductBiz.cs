using System.Collections.Generic;
using System.Threading.Tasks;
using Info;
using Dac;

namespace Biz
{
    public class ProductBiz
    {
        private readonly ProductDac _dac = new ProductDac();

        public Task<List<ProductInfo>> GetProductsAsync()
        {
            return _dac.GetProductsAsync();
        }
    }
}
