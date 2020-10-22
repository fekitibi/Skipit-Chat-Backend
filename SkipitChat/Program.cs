using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SkipitChat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            /*var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings1.json")
                .AddJsonFile("appsettings2.json")
                .Build();

            Console.WriteLine("Application Name: " + config["ApplicationName"]);
            Console.WriteLine("Timeout:          " + config["Timeout"]);
            Console.WriteLine("Connection String " + config["ConnectionString"]);

            Console.ReadLine();*/
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
