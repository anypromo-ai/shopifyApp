using System;
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
                Console.WriteLine("Web API started at " + baseAddress);
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
