using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
         var host =  CreateHostBuilder(args).Build();
         using (var scope = host.services.CreateScope())
         {
             var services = scope.ServiceProvider;
             try 
             {
               var context = services.GetRequiredService<DataContext>();
               context.DataContext.Migrate();
               Seed.SeedUsers(context);
             }
             catch (ex)
             {
               var logger = services.GetRequiredService<ILogger<Program>>();
               logger.LogError(ex, "An error occured during migration");
             }
         }
         
         host.Run();
        } 

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
 