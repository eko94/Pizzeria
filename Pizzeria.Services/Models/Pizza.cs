using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Models
{
    public class Pizza
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public List<string> Ingredientes { get; set; }
    }
}