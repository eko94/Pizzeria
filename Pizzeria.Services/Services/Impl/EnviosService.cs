using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services.Impl
{
    public class EnviosService : IEnviosService
    {
        private readonly IEnumerable<IPromocionesEnvios> _promocionesEnvios;

        public EnviosService(IEnumerable<IPromocionesEnvios> promocionesEnvios)
        {
            _promocionesEnvios = promocionesEnvios;
        }

        public decimal CalcularEnvio(Pedido pedido)
        {
            var precioEnvio = Constants.EnviosConstants.PrecioFijo;

            foreach (var promocion in _promocionesEnvios) 
            { 
                precioEnvio = promocion.AplicarPromocion(precioEnvio, pedido.FechaPedido);
            }

            return precioEnvio;
        }
    }
}
