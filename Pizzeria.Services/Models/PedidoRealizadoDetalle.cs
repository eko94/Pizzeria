using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Models
{
    public class PedidoRealizadoDetalle
    {
        public string PizzaNombre { get; set; }
        public List<string> Ingredientes { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
