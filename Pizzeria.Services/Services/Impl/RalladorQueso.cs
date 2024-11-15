using Pizzeria.Services.Models;
using Pizzeria.Services.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services.Impl
{
    public class RalladorQueso
    {
        private IQuesoStrategy _queso;

        public void AsignQueso(IQuesoStrategy queso)
        {
            this._queso = queso;
        }

        public Pizza AddQueso(string tipo, Pizza pizza)
        {
            return _queso.AddQueso(tipo, pizza);
        }
    }
}
