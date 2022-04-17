using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainCoffeeShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Vinh Comment Check Conflit Vinh Change From Local a line
            CreateHostBuilder(args).Build().Run();
            //Test conflit from local
        }

        public static IHostBuilder CreateHostBuilder(string[] argss) =>
            Host.CreateDefaultBuilder(argss)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
