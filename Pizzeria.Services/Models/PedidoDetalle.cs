using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Models
{
    public class PedidoDetalle
    {
        public string PizzaNombre { get; set; }
        public List<Ingrediente>? Ingredientes { get; set; }
        public int Cantidad { get; set; }
    }
}
