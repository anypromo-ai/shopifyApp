using System;
using ShopifyApp.Biz;

namespace ShopifyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var biz = new ProductBiz();
            var products = biz.GetAllProducts();

            Console.WriteLine("Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id}: {p.Name} - ${p.Price}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
