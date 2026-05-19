using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Record_Shop_Frontend.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7121/") });


            await builder.Build().RunAsync();
        }
    }
}
