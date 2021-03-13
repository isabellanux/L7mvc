//////////////////////////////////////////////////////////////////////////////////////////////////////////
// Date                  Developer                  Description
// 2021-03-03            bellatn                    --followed alongside video 22 and 23 and added components to the website
// 2021-03-12            bellatn                    --added comments to added elements, took screenshots, and submitted L7mvc

using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace ContosoUniversity
{
    // msbuild -v:n -t:rebuild -p:configuration=debug
    // @ (razortag) - this is C# code

    public class Program
    {

        //tinfo200:[2021-03-03-bellatn-dykstra1] - the code in the main method creates an access to the database
        // and uses a try catch loop to catch any exceptions when accessing. 
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // CreateDbIfNotExists(host);
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();

        }

        //tinfo200:[2021-03-03-bellatn-dykstra1] - this method creates the database with the specified host after checking if
        // a database exists. 
        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
