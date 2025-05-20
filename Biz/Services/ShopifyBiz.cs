using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using ShopifyApp.Info.Models;
using ShopifyApp.Dac.Repositories;

namespace ShopifyApp.Biz.Services
{
    public class ShopifyBiz
    {
        private readonly ProductDac _productDac;
        private readonly OrderDac _orderDac;
        private readonly CustomerDac _customerDac;
        private readonly string _shopifyBaseUrl = "https://your-store.myshopify.com/admin/api/2023-10"; // TODO: update
        private readonly string _token = "YOUR_TOKEN";

        public ShopifyBiz(string connectionString)
        {
            _productDac = new ProductDac(connectionString);
            _orderDac = new OrderDac(connectionString);
            _customerDac = new CustomerDac(connectionString);
        }

        public void SyncProducts()
        {
            using (var client = CreateClient())
            {
                var response = client.GetAsync($"{_shopifyBaseUrl}/products.json").Result;
                var json = response.Content.ReadAsStringAsync().Result;
                var arr = JObject.Parse(json)["products"];
                var products = new List<ProductInfo>();
                foreach (var item in arr)
                {
                    products.Add(new ProductInfo
                    {
                        Id = (long)item["id"],
                        Title = (string)item["title"],
                        Price = (decimal)item["variants"][0]["price"]
                    });
                }
                _productDac.SaveProducts(products);
            }
        }

        // TODO: implement SyncOrders and SyncCustomers similarly

        private HttpClient CreateClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _token);
            return client;
        }
    }
}
