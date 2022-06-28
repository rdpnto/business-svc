using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace BusinessSvc.IoC.Extensions
{
    public static class DependencyInjection
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {

        }

        public static void AddDbConnection(this IServiceCollection services)
        {
            services.AddSingleton<IDbConnection>();
        }
    }
}
