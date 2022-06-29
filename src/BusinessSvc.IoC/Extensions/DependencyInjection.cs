using BusinessSvc.Domain.Constants;
using BusinessSvc.Domain.Contracts;
using BusinessSvc.Repository.Persistence;
using BusinessSvc.Repository.Persistence.SQL;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace BusinessSvc.IoC.Extensions
{
    public static class DependencyInjection
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IBusinessRepository, BusinessRepository>();
        }

        public static void AddDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IDbConnection>(s =>
            {
                var connStr = config.GetConnectionString(ApiConstants.CONNECTION_STRING);
                var connection = new SqliteConnection(connStr);

                connection.Open();
                
                var cmd = connection.CreateCommand();
                cmd.CommandText = EnvironmentSQL.CREATE_CUSTOMERS;
                cmd.ExecuteNonQuery();

                cmd.CommandText = EnvironmentSQL.CREATE_ORDERS;
                cmd.ExecuteNonQuery();

                return connection;
            });
        }
    }
}
