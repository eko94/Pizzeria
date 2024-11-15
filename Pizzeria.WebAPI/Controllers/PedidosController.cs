using Microsoft.AspNetCore.Mvc;
using Pizzeria.Services.Models;
using Pizzeria.Services.Services;

namespace Pizzeria.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidosService _pedidosService;

        public PedidosController(IPedidosService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        [HttpPost("RealizarPedido")]
        public PedidoRealizado RealizarPedido(Pedido pedido)
        {
            return _pedidosService.RealizarPedido(pedido);
        }
    }
}
