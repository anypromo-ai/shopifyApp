using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using Newtonsoft.Json;
using ShopifyApp.Info;

namespace ShopifyApp.Dac
{
    public class ShopifyDac
    {
        private readonly string _connectionString = "<SQL SERVER CONNECTION STRING>"; // TODO: replace
        private readonly string _shopifyBaseUrl = "https://<shop>.myshopify.com";
        private readonly string _apiKey = "<API KEY>";
        private readonly string _password = "<PASSWORD>";

        private string GetAuthUrl(string endpoint) => $"{_shopifyBaseUrl}/admin/api/2023-01/{endpoint}.json";

        public List<ProductInfo> FetchProducts()
        {
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(_apiKey, _password);
                var json = client.DownloadString(GetAuthUrl("products"));
                return JsonConvert.DeserializeObject<ShopifyProductList>(json).Products;
            }
        }

        public List<OrderInfo> FetchOrders()
        {
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(_apiKey, _password);
                var json = client.DownloadString(GetAuthUrl("orders"));
                return JsonConvert.DeserializeObject<ShopifyOrderList>(json).Orders;
            }
        }

        public List<CustomerInfo> FetchCustomers()
        {
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(_apiKey, _password);
                var json = client.DownloadString(GetAuthUrl("customers"));
                return JsonConvert.DeserializeObject<ShopifyCustomerList>(json).Customers;
            }
        }

        public void SaveProducts(IEnumerable<ProductInfo> products)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (var p in products)
                {
                    var cmd = new SqlCommand("INSERT INTO Products(Id, Title, Price) VALUES(@Id, @Title, @Price)", conn);
                    cmd.Parameters.AddWithValue("@Id", p.Id);
                    cmd.Parameters.AddWithValue("@Title", p.Title);
                    cmd.Parameters.AddWithValue("@Price", p.Price);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaveOrders(IEnumerable<OrderInfo> orders)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (var o in orders)
                {
                    var cmd = new SqlCommand("INSERT INTO Orders(Id, CreatedAt, TotalPrice) VALUES(@Id, @CreatedAt, @TotalPrice)", conn);
                    cmd.Parameters.AddWithValue("@Id", o.Id);
                    cmd.Parameters.AddWithValue("@CreatedAt", o.CreatedAt);
                    cmd.Parameters.AddWithValue("@TotalPrice", o.TotalPrice);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaveCustomers(IEnumerable<CustomerInfo> customers)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (var c in customers)
                {
                    var cmd = new SqlCommand("INSERT INTO Customers(Id, Email, FirstName, LastName) VALUES(@Id, @Email, @FirstName, @LastName)", conn);
                    cmd.Parameters.AddWithValue("@Id", c.Id);
                    cmd.Parameters.AddWithValue("@Email", c.Email);
                    cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", c.LastName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private class ShopifyProductList { public List<ProductInfo> Products { get; set; } }
        private class ShopifyOrderList { public List<OrderInfo> Orders { get; set; } }
        private class ShopifyCustomerList { public List<CustomerInfo> Customers { get; set; } }
    }
}
