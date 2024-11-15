using Pizzeria.Services.Builders;
using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Constants
{
    public class PizzasConstants
    {
        public const string Margarita = "Margarita";
        public const string Pepperoni = "Pepperoni";
        public const string CuatroQuesos = "CuatroQuesos";
        public const string Personalizada = "Personalizada";

        public static Dictionary<string, decimal> Precios = new Dictionary<string, decimal>()
        {
            { Margarita, 40 },
            { Pepperoni, 45 },
            { CuatroQuesos, 50 },
            { Personalizada, 60 }
        };
    }
}
