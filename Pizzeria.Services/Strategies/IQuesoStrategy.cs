using Pizzeria.Services.Builders;
using Pizzeria.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Strategies
{
    public interface IQuesoStrategy
    {
        Pizza AddQueso(string tipo, Pizza pizza);
    }
}
