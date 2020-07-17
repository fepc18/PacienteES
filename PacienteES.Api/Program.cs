using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PacienteES.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((env,config)=>
            {
               
                var ambiente = env.HostingEnvironment.EnvironmentName;
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                config.AddJsonFile($"appsettings.{ambiente}.json", optional: true, reloadOnChange: true);
                
                config.AddEnvironmentVariables();

                if (args != null)
                {
                    config.AddCommandLine(args);
                }

                //var currentConfig = config.Build();

                // Estas configuraciones se deben guardar fuera del c�digo fuente del App.
                //config.AddAzureKeyVault(currentConfig["Vault"],
                //    currentConfig["ClientId"],
                //    currentConfig["ClientSecret"]);
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
