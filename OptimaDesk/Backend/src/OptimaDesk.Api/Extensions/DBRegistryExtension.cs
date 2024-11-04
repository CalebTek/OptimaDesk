using Microsoft.EntityFrameworkCore;
using OptimaDesk.Domain.Context;

namespace OptimaDesk.Api.Extensions
{
    public static class DBRegistryExtension
    {
        public static void AddDbContextAndConfigurations(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContextPool<ApplicationContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
