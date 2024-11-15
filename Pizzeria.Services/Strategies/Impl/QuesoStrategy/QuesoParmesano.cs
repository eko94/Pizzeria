using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Strategies.Impl.QuesoStrategy
{
    public class QuesoParmesano : IQuesoStrategy
    {
        public Pizza AddQueso(string tipo, Pizza pizza)
        {
            pizza.Ingredientes.Add(Constants.IngredientesConstants.Queso + " " + Constants.IngredientesConstants.Tipos.Quesos.Parmesano);
            return pizza;
        }
    }
}
