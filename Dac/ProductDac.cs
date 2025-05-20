using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Info;
using Newtonsoft.Json.Linq;

namespace Dac
{
    public class ProductDac
    {
        private readonly string _shopUrl = "https://your-shop-name.myshopify.com"; // TODO: replace
        private readonly string _accessToken = "YOUR_ACCESS_TOKEN"; // TODO: replace

        public async Task<List<ProductInfo>> GetProductsAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(_shopUrl);
                client.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _accessToken);

                var response = await client.GetAsync("/admin/api/2023-07/products.json");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var products = new List<ProductInfo>();
                var obj = JObject.Parse(json);
                foreach (var item in obj["products"])
                {
                    products.Add(new ProductInfo
                    {
                        Id = (long)item["id"],
                        Title = (string)item["title"],
                        Price = item["variants"]?[0]?["price"] != null ? decimal.Parse((string)item["variants"][0]["price"]) : 0
                    });
                }
                return products;
            }
        }
    }
}
