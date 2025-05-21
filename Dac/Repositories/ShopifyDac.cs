using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Info.Models;
using Newtonsoft.Json.Linq;

namespace Dac.Repositories
{
    public class ShopifyDac
    {
        private readonly string _baseUrl;
        private readonly string _accessToken;

        public ShopifyDac(string baseUrl, string accessToken)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _accessToken = accessToken;
        }

        private HttpClient CreateClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _accessToken);
            return client;
        }

        public async Task<List<ProductInfo>> GetProductsAsync()
        {
            using (var client = CreateClient())
            {
                var json = await client.GetStringAsync($"{_baseUrl}/products.json");
                var products = new List<ProductInfo>();
                var array = JObject.Parse(json)["products"] as JArray;
                if (array != null)
                {
                    foreach (var item in array)
                    {
                        products.Add(new ProductInfo
                        {
                            Id = item["id"]?.ToString(),
                            Title = item["title"]?.ToString(),
                            Description = item["body_html"]?.ToString(),
                            Price = decimal.Parse(item["variants"]?[0]? ["price"]?.ToString() ?? "0")
                        });
                    }
                }
                return products;
            }
        }

        // TODO: similar methods for orders and customers
    }
}
