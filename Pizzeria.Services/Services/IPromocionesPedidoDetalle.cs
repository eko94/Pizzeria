using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services
{
    public interface IPromocionesPedidoDetalle
    {
        decimal AplicarPromocion(string nombre, decimal precioTotal, decimal precioUnitario, int cantidad, DateTime fechaPedido);
    }
}
