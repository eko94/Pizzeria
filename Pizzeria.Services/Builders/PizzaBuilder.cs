using Pizzeria.Services.Models;
using Pizzeria.Services.Services.Impl;
using Pizzeria.Services.Strategies;
using Pizzeria.Services.Strategies.Impl.QuesoStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Builders
{
    public class PizzaBuilder : IPizzaBuilder
    { 
        private Pizza _pizza = new Pizza();

        public IPizzaBuilder Reset(string nombre)
        {
            decimal precio = Constants.PizzasConstants.Precios[nombre];
            this._pizza = new Pizza
            {
                Nombre = nombre,
                Precio = precio,
                Ingredientes = new List<string>()
            };
            return this;
        }

        public IPizzaBuilder SetNombreYPrecio(string nombre)
        {

            return this;
        }

        public IPizzaBuilder SetMasa()
        {
            this._pizza.Ingredientes.Add(Constants.IngredientesConstants.Masa);
            return this;
        }

        public IPizzaBuilder SetSalsaTomate()
        {
            this._pizza.Ingredientes.Add(Constants.IngredientesConstants.SalsaTomate);
            return this;
        }

        public IPizzaBuilder SetQueso(string tipo)
        {
            RalladorQueso ralladorQueso = new RalladorQueso();

            if (tipo.ToLower() == Constants.IngredientesConstants.Tipos.Quesos.Mozzarella.ToLower())
            {
                ralladorQueso.AsignQueso(new QuesoMozzarella());
                ralladorQueso.AddQueso(Constants.IngredientesConstants.Tipos.Quesos.Mozzarella, _pizza);
            }
            else if (tipo.ToLower() == Constants.IngredientesConstants.Tipos.Quesos.Parmesano.ToLower())
            {
                ralladorQueso.AsignQueso(new QuesoParmesano());
                ralladorQueso.AddQueso(Constants.IngredientesConstants.Tipos.Quesos.Parmesano, _pizza);
            }
            else if (tipo.ToLower() == Constants.IngredientesConstants.Tipos.Quesos.Gorgonzola.ToLower())
            {
                ralladorQueso.AsignQueso(new QuesoGorgonzola());
                ralladorQueso.AddQueso(Constants.IngredientesConstants.Tipos.Quesos.Gorgonzola, _pizza);
            }
            else if (tipo.ToLower() == Constants.IngredientesConstants.Tipos.Quesos.Fontina.ToLower())
            {
                ralladorQueso.AsignQueso(new QuesoFontina());
                ralladorQueso.AddQueso(Constants.IngredientesConstants.Tipos.Quesos.Fontina, _pizza);
            }

            return this;
        }

        public IPizzaBuilder SetAlbahaca()
        {
            this._pizza.Ingredientes.Add(Constants.IngredientesConstants.Albahaca);
            return this;
        }

        public IPizzaBuilder SetTomate()
        {
            this._pizza.Ingredientes.Add(Constants.IngredientesConstants.Tomate);
            return this;
        }

        public IPizzaBuilder SetPepperoni()
        {
            this._pizza.Ingredientes.Add(Constants.IngredientesConstants.Pepperoni);
            return this;
        }

        public Pizza GetResult()
        {
            return this._pizza;
        }
    }
}
