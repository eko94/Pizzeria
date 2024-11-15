using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Services.Impl.PromocionesEnvios
{
    public class PromocionesEnviosJuevesGratis : IPromocionesEnvios
    {
        public decimal AplicarPromocion(decimal costoEnvio, DateTime fechaEnvio)
        {
            bool esJueves = fechaEnvio.DayOfWeek == DayOfWeek.Thursday;
            if (esJueves)
            {
                costoEnvio = 0;
            }
            return costoEnvio;
        }
    }
}
