using System;
using ShopifyApp.Biz;

namespace ShopifyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var biz = new ProductBiz();
            try
            {
                var products = biz.GetProducts();
                foreach (var p in products)
                {
                    Console.WriteLine($"{p.Id}: {p.Title} - ${p.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to fetch products: " + ex.Message);
            }
        }
    }
}
