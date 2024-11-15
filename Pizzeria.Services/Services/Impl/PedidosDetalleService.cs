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
    public class PedidosDetalleService : IPedidosDetalleService
    {
        private const string delimiter = "¬¬";

        private readonly PizzaDirector _pizzaDirector;
        private readonly IEnumerable<IPromocionesPedidoDetalle> _promocionesPedidoDetalle;

        public PedidosDetalleService(IPizzaBuilder pizzaBuilder, IEnumerable<IPromocionesPedidoDetalle> promocionesPedidoDetalle)
        {
            _pizzaDirector = new PizzaDirector(pizzaBuilder);
            _promocionesPedidoDetalle = promocionesPedidoDetalle;
        }

        public List<PedidoRealizadoDetalle> PrepararPedidoDetalle(Pedido pedido)
        {
            //Se preparan las pizzas
            var pizzasPreparadas = new List<Pizza>();
            foreach (var detalle in pedido.Detalles)
            {
                for (int i = 0; i < detalle.Cantidad; i++)
                {
                    var pizzaPrepada = PrepararPizzaPedidoDetalle(detalle);
                    if (pizzaPrepada != null ) pizzasPreparadas.Add(pizzaPrepada);
                }
            }

            //Se agrupan las pizzas para el detallado del pedido y calcular los precios
            var detallePedidoRealizado = DetallarPizzasPreparadas(pizzasPreparadas, pedido.FechaPedido);

            return detallePedidoRealizado;
        }

        private List<PedidoRealizadoDetalle> DetallarPizzasPreparadas(List<Pizza> pizzas, DateTime fechaPedido)
        {
            return pizzas
                .GroupBy(x => new { x.Nombre, Ingredientes = string.Join(delimiter, x.Ingredientes), x.Precio })
                .Select(x => new PedidoRealizadoDetalle
                {
                    PizzaNombre = x.Key.Nombre,
                    Cantidad = x.Count(),
                    Ingredientes = x.Key.Ingredientes.Split(delimiter).ToList(),
                    CostoTotal = CalcularPedidoDetalleCosto(x.Key.Nombre, x.Key.Precio, x.Count(), fechaPedido)
                    
                })
                .ToList();
        }

        private decimal CalcularPedidoDetalleCosto(string nombre, decimal precioUnitario, int cantidad, DateTime fechaPedido)
        {
            decimal precioTotalConPromociones = precioUnitario * cantidad;

            foreach(var promocion in _promocionesPedidoDetalle)
            {
                precioTotalConPromociones = promocion.AplicarPromocion(nombre, precioTotalConPromociones, precioUnitario, cantidad, fechaPedido);
            }

            //Para no retornar un valor negativo
            precioTotalConPromociones = Math.Max(0, precioTotalConPromociones);

            return precioTotalConPromociones;
        }

        private Pizza PrepararPizzaPedidoDetalle(PedidoDetalle detalle)
        {
            switch (detalle.PizzaNombre)
            {
                case Constants.PizzasConstants.Margarita:
                    return _pizzaDirector.CocinarPizzaMargarita();
                case Constants.PizzasConstants.Pepperoni:
                    return _pizzaDirector.CocinarPizzaPepperoni();
                case Constants.PizzasConstants.CuatroQuesos:
                    return _pizzaDirector.CocinarPizzaCuatroQuesos();
                case Constants.PizzasConstants.Personalizada:
                    return _pizzaDirector.CocinarPizzaPersonalizada(detalle.Ingredientes);
                default:
                    return null;
            }
        }

    }
}
