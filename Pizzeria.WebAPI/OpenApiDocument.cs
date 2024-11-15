using NSwag;

namespace Pizzeria.WebAPI
{
    public static class OpenApiDocument
    {
        public static IServiceCollection AddOpenApiDocumentPizzeria(this IServiceCollection services)
        {
            services.AddOpenApiDocument(options => {
                options.PostProcess = document =>
                {
                    document.Info = new OpenApiInfo
                    {
                        Version = "v1",
                        Title = "Pizzeria API",
                        Description = "Módulo 1 - Pizzeria",
                    };
                };
            });

            return services;
        }
    }
}
