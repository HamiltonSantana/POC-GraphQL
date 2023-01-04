using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GraphQL_Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var graph = new GraphQLClient();
            var result = await graph.QLRequestAsync();
            // foreach (var note in result)
            // {
                Console.WriteLine($"Id: {result.Id}, Message:{result.Message}");
            // }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
