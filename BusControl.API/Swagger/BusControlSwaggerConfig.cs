using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BusControl.API.Swagger
{
    public static class BusControlSwaggerConfig
    {
        public static void Register(IApplicationBuilder app)
        {
            // Configure the Swagger documentation.
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bus Control.API v1");
                c.RoutePrefix = "swagger";
                c.DocumentTitle = "Bus Control";
            });
        }

        public static void ConfigureSwaggerGen(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Bus Control",
                    Description = "Sistema que controla horários e passageiros em viagens realizadas de ônibus urbanos.",
                    Version = "1.0.0"
                });
            });
        }
    }
}

