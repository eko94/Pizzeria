using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Builders
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder Reset(string nombre);
        IPizzaBuilder SetMasa();
        IPizzaBuilder SetSalsaTomate();
        IPizzaBuilder SetQueso(string tipo);
        IPizzaBuilder SetAlbahaca();
        IPizzaBuilder SetTomate();
        IPizzaBuilder SetPepperoni();       
        Pizza GetResult();
    }
}
