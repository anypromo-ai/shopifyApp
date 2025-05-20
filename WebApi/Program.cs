using System;
using Microsoft.Owin.Hosting;

namespace ShopifyApp.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Service running at {baseAddress}. Press Enter to stop.");
                Console.ReadLine();
            }
        }
    }
}
