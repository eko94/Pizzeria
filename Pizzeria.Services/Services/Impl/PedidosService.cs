using Pizzeria.Services.Builders;
using Pizzeria.Services.Directors;
using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services.Impl
{
    public class PedidosService : IPedidosService
    {
        private readonly IPedidosDetalleService _pedidosDetalleService;
        private readonly IEnviosService _enviosService;
        public PedidosService(IPedidosDetalleService pedidosDetalleService, IEnviosService enviosService)
        {
            _pedidosDetalleService = pedidosDetalleService;
            _enviosService = enviosService;
        }

        public PedidoRealizado RealizarPedido(Pedido pedido)
        {
            decimal envio = _enviosService.CalcularEnvio(pedido);
            List<PedidoRealizadoDetalle> detalles = _pedidosDetalleService.PrepararPedidoDetalle(pedido);
            decimal total = CalcularCostoTotal(detalles, envio);
            var pedidoRealizado = new PedidoRealizado
            { 
                Cliente = pedido.Cliente,
                Detalles = detalles,
                CostoEnvio = envio,
                CostoTotal = total
            };            

            return pedidoRealizado;
        }

        private decimal CalcularCostoTotal(List<PedidoRealizadoDetalle> detalles, decimal envio)
        {
            return detalles.Sum(x => x.CostoTotal) + envio;
        }
    }
}
