using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Models
{
    public class Pedido
    {
        /// <summary>
        /// Clase para realizar un pedido.
        /// </summary>
        public string Cliente { get; set; }
        public List<PedidoDetalle> Detalles { get; set; }
        public DateTime FechaPedido { get; set; }
        
    }
}
