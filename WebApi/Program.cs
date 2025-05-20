using System;
using Microsoft.Owin.Hosting;

namespace ShopifyApp.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("API running at " + baseAddress);
                Console.ReadLine();
            }
        }
    }
}
