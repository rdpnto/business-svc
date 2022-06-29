using BusinessSvc.Domain.Constants;
using BusinessSvc.IoC.Extensions;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;

namespace BusinessSvc.Api
{
    public class Startup
    {
        readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration) => _configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMediatR(typeof(object));
            services.AddDbContext(_configuration);
            services.AddSwaggerGen(c => c.SwaggerDoc(ApiConstants.API_VERSION, BuildDocumentation()));
            services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public OpenApiInfo BuildDocumentation()
        {
            return new OpenApiInfo()
            {
                Title = ApiConstants.API_TITLE,
                Description = ApiConstants.API_DESCRIPTION,
                Contact = new OpenApiContact()
                {
                    Name = ApiConstants.DEV_NAME,
                    Email = ApiConstants.DEV_EMAIL
                }
            };
        }
    }
}
