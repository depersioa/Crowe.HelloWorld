using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Crowe.HelloWorld.Console
{
    private class Program
    {
        public static IConfigurationRoot configuration;
        
        private static void Main(string[] args)
        {
            LoadConfiguration();
            System.Console.WriteLine(configuration.GetSection("BaseUrl").Value);
            System.Console.WriteLine("Hello World!");
        }

        private static void LoadConfiguration()
        {
            //Load appsettings.json
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
        }
    }
}
