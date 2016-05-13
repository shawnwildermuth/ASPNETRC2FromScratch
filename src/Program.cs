using System;
using Microsoft.AspNetCore.Hosting;

namespace ASPNETRC2FromScratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
           new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}
