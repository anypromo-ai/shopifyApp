using System.Collections.Generic;
using System.Threading.Tasks;
using Info.Models;
using Dac.Repositories;

namespace Biz
{
    public class ShopifyBiz
    {
        private readonly ShopifyDac _shopify;
        private readonly SqlServerDac _db;

        public ShopifyBiz(ShopifyDac shopify, SqlServerDac db)
        {
            _shopify = shopify;
            _db = db;
        }

        public async Task<List<ProductInfo>> SyncProductsAsync()
        {
            var products = await _shopify.GetProductsAsync();
            await _db.SaveProductsAsync(products);
            return products;
        }

        // TODO: Sync orders and customers
    }
}
