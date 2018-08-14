using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Study.Training.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args)
                                                                     .ConfigureAppConfiguration(ConfigureApp)
                                                                     .UseStartup<Startup>()
                                                                     .Build();

        private static void ConfigureApp(WebHostBuilderContext context, IConfigurationBuilder builder)
        {
            string envName = context.HostingEnvironment.EnvironmentName;

            builder.SetBasePath(context.HostingEnvironment.ContentRootPath)
                   .AddJsonFile($"appsettings\\appsettings.{envName}.json", true, true)
                   .AddJsonFile($"connectionstrings\\connectionstrings.{envName}.json", true)
                   .AddEnvironmentVariables();
        }
    }
}
