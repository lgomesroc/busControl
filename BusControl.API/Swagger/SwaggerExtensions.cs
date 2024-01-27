using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace BusControl.API.Swagger
{
    public static class SwaggerExtensions
    {
        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app, Action<SwaggerUIOptions> setupAction = null)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Bus Control.API v1");
                setupAction?.Invoke(options);
            });

            return app;
        }
    }
}
