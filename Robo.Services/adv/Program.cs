using Microsoft.Owin.Hosting;
using System;

namespace Qyon.AdventureServices
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.WriteLine("WebServer is running.");
            }
        }
    }
}
