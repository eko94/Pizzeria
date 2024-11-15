using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services
{
    public interface IPedidosDetalleService
    {
        List<PedidoRealizadoDetalle> PrepararPedidoDetalle(Pedido pedido);

    }
}
