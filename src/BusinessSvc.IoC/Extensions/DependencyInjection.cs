using BusinessSvc.Domain.Constants;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace BusinessSvc.IoC.Extensions
{
    public static class DependencyInjection
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IDbConnection>(s => new SqliteConnection(config.GetConnectionString(ApiConstants.CONNECTION_STRING)));
        }
    }
}
