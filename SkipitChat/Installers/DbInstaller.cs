using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SkipitChat.Data;
using SkipitChat.Services;

namespace SkipitChat.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddDbContext<Data.ApplicationDbContext>(options =>
                options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection")));*/

            //string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("MyDbConnection")));

            /*  *-    services.AddDefaultIdentity<IdentityUser>()
          .AddEntityFrameworkStores<ApplicationDbContext>();*/

            //services.AddScoped<IPostService, PostService>();
            services.AddScoped<IAccessibilityService, AccessibilityService>();
            services.AddScoped<ITicketService, TicketService>();

            /*

            if (environment != null)
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile($"appsettings.{environment}.json")
                    .Build();



                /*services.AddDbContextPool<ApplicationDbContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(
                        configuration.GetConnectionString("DefaultConnection"),
                        // Replace with your server version and type.
                        mySqlOptions => mySqlOptions
                            .ServerVersion(new Version(8, 0, 20), ServerType.MySql)
                            .CharSetBehavior(CharSetBehavior.NeverAppend))
                    // Everything from this point on is optional but helps with debugging.
                    .UseLoggerFactory(
                        LoggerFactory.Create(
                            logging => logging
                                .AddConsole()
                                .AddFilter(level => level >= LogLevel.Information)))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors());*/



            /* }
             else
             {
                 Console.WriteLine("Fatal error: environment not found!");
                 Environment.Exit(-1);
             }*/
        }
    }
}
