using Pizzeria.Services.Builders;
using Pizzeria.Services.Services;
using Pizzeria.Services.Services.Impl;
using Pizzeria.Services.Services.Impl.PromocionesEnvios;
using Pizzeria.Services.Services.Impl.PromocionesPedidoDetalle;

namespace Pizzeria.WebAPI
{
    public static class DependecyInjections
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPizzaBuilder, PizzaBuilder>();

            services.AddSingleton<IPromocionesEnvios, PromocionesEnviosJuevesGratis>();
            services.AddSingleton<IPromocionesPedidoDetalle, PromocionesPedidoDetalle2x1>();

            services.AddTransient<IPedidosDetalleService, PedidosDetalleService>();
            services.AddTransient<IPedidosService, PedidosService>();
            services.AddTransient<IEnviosService, EnviosService>();

            return services;
        }
    }
}
