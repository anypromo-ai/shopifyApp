using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using ShopifyApp.Info;

namespace ShopifyApp.Dac
{
    public class ProductDac
    {
        private readonly string _shopDomain = "your-store.myshopify.com"; // TODO: change
        private readonly string _accessToken = "shpat_your_token"; // TODO: change

        private class ProductRoot { public List<Product> products { get; set; } }
        private class Product { public long id { get; set; } public string title { get; set; } public Variant[] variants { get; set; } }
        private class Variant { public decimal price { get; set; } }

        public List<ProductInfo> GetProducts()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("X-Shopify-Access-Token", _accessToken);
                var url = $"https://{_shopDomain}/admin/api/2023-04/products.json";
                var json = client.DownloadString(url);
                var data = JsonConvert.DeserializeObject<ProductRoot>(json);
                return data.products.Select(p => new ProductInfo
                {
                    Id = p.id,
                    Title = p.title,
                    Price = p.variants != null && p.variants.Length > 0 ? p.variants[0].price : 0m
                }).ToList();
            }
        }
    }
}
