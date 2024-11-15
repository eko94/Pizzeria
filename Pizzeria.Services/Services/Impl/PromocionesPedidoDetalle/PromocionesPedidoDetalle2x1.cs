using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services.Impl.PromocionesPedidoDetalle
{
    public class PromocionesPedidoDetalle2x1 : IPromocionesPedidoDetalle
    {
        public decimal AplicarPromocion(string nombre, decimal precioTotalConPromociones, decimal precioUnitario, int cantidad, DateTime fechaPedido)
        {
            bool esMartes = fechaPedido.DayOfWeek == DayOfWeek.Tuesday;
            bool esMiercoles = fechaPedido.DayOfWeek == DayOfWeek.Wednesday;

            if (esMartes || esMiercoles)
            {
                int cantidadPromociones = cantidad / 2;

                decimal restarPorPromocion = precioUnitario * cantidadPromociones;

                precioTotalConPromociones = precioTotalConPromociones - restarPorPromocion;
            }

            return precioTotalConPromociones;
        }
    }
}
