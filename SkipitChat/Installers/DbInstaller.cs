using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SkipitChat.Data;
using SkipitChat.Services;

namespace SkipitChat.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                configuration
                .GetConnectionString("MyDbConnection"))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());

            services.AddScoped<IAccessibilityService, AccessibilityService>();
            services.AddScoped<ITicketService, TicketService>();
        }
    }
}
