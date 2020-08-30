using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Crowe.HelloWorld.Models.Response;

namespace Crowe.HelloWorld.Console
{
    class Program
    {
        public static IConfigurationRoot configuration;

        private static readonly HttpClient client = new HttpClient();

        private static void Main(string[] args)
        {
            LoadConfiguration();
            System.Console.WriteLine(GetHelloWorld());
        }

        private static string GetHelloWorld()
        {
            try
            {
                var url = configuration.GetSection("BaseUrl").Value + "/api/helloworld";

                var responseTask = client.GetStringAsync(url);
                var response = responseTask.Result;
                var options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };

                var helloWorldResponse = JsonSerializer.Deserialize<HelloWorldResponse>(response, options);

                return helloWorldResponse.Data.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
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
