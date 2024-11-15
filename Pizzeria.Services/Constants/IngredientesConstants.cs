using Pizzeria.Services.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Constants
{
    public static class IngredientesConstants
    {
        public const string Masa = "Masa";
        public const string SalsaTomate = "Salsa de tomate";
        public const string Queso = "Queso";
        public const string Albahaca = "Albahaca";
        public const string Tomate = "Tomate";
        public const string Pepperoni = "Pepperoni";

        public static class Tipos
        {
            public static class Quesos
            {
                public const string Mozzarella = "Mozzarella";
                public const string Parmesano = "Parmesano";
                public const string Gorgonzola = "Gorgonzola";
                public const string Fontina = "Fontina";
            }
        }
    }
}
