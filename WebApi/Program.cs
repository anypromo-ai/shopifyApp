using System;
using System.Web.Http;
using Microsoft.Owin.Hosting;

namespace WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Listening on {baseAddress}. Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
