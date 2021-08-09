using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using sqstr.Extensions;

namespace sqstr.Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) => 
                {
                    if (context.HostingEnvironment.IsProduction())
                        config.ConfigureKeyVault();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

// Azure Key Vault credentialing
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Azure.Identity;
// using Azure.Security.KeyVault.Keys;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Hosting;
// using Microsoft.Extensions.Logging;

// namespace sqstr.Solution
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             CreateHostBuilder(args).Build().Run();
//         }

//         public static IHostBuilder CreateHostBuilder(string[] args) =>
//             Host.CreateDefaultBuilder(args)
//                 .ConfigureWebHostDefaults(webBuilder =>
//                     webBuilder.ConfigureAppConfiguration((hostingContext, config) => 
//                     {
//                         var settings = config.Build();
//                         config.AddAzureAppConfiguration(options =>
//                         {
//                             options.Connect(settings["ConnectionStrings:AppConfig"])
//                                 .ConfigureKeyVault(kv => 
//                                 {
//                                     kv.SetCredential(new DefaultAzureCredential());
//                                 });
//                         });
//                     })
//                     .UseStartup<Startup>());
//     }
// }
