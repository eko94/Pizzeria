using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Models
{
    public class PedidoRealizado
    {
        public string Cliente { get; set; }
        public List<PedidoRealizadoDetalle> Detalles { get; set; }
        public decimal CostoEnvio { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
