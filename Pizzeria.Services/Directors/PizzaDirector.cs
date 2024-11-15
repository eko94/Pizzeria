using Pizzeria.Services.Builders;
using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Directors
{
    public class PizzaDirector
    {
        private IPizzaBuilder _builder;
        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public Pizza CocinarPizzaMargarita()
        {
            return _builder
                .Reset(Constants.PizzasConstants.Margarita)
                .SetMasa()
                .SetSalsaTomate()
                .SetQueso(Constants.IngredientesConstants.Tipos.Quesos.Mozzarella)
                .SetTomate()
                .SetAlbahaca()
                .GetResult();
        }

        public Pizza CocinarPizzaPepperoni()
        {
            return _builder
                .Reset(Constants.PizzasConstants.Pepperoni)
                .SetMasa()
                .SetSalsaTomate()
                .SetQueso(Constants.IngredientesConstants.Tipos.Quesos.Mozzarella)
                .SetPepperoni()
                .GetResult();
        }

        public Pizza CocinarPizzaCuatroQuesos()
        {
            return _builder
                .Reset(Constants.PizzasConstants.CuatroQuesos)
                .SetMasa()
                .SetSalsaTomate()
                .SetQueso(Constants.IngredientesConstants.Tipos.Quesos.Mozzarella)
                .SetQueso(Constants.IngredientesConstants.Tipos.Quesos.Parmesano)
                .SetQueso(Constants.IngredientesConstants.Tipos.Quesos.Gorgonzola)
                .SetQueso(Constants.IngredientesConstants.Tipos.Quesos.Fontina)
                .GetResult();
        }

        public Pizza CocinarPizzaPersonalizada(List<Ingrediente> ingredientes)
        {
            if (ingredientes == null) return null;

            var pizzaBase = _builder
                .Reset(Constants.PizzasConstants.Personalizada)
                .SetMasa();
            foreach (var ing in ingredientes)
            {
                AgregarIngredientePersonalizado(ing, pizzaBase);
            }
            return pizzaBase.GetResult();
        }

        private void AgregarIngredientePersonalizado(Ingrediente ing, IPizzaBuilder pizzaBase)
        {
            switch (ing.Nombre)
            {
                case Constants.IngredientesConstants.SalsaTomate:
                    pizzaBase.SetSalsaTomate();
                    break;
                case Constants.IngredientesConstants.Queso:
                    pizzaBase.SetQueso(ing.Tipo);
                    break;
                case Constants.IngredientesConstants.Albahaca:
                    pizzaBase.SetAlbahaca();
                    break;
                case Constants.IngredientesConstants.Tomate:
                    pizzaBase.SetTomate();
                    break;
                case Constants.IngredientesConstants.Pepperoni:
                    pizzaBase.SetPepperoni();
                    break;
                default:
                    break;
            }
        }
    }
}
