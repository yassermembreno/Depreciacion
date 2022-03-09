using Domain.Enum;
using Domain.Interfaces;
using AppCore.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Factories
{
    public static class FactoryDeducciones
    {
        public static IDepreciacionModel FactoryDepreciacion(Depreciacion depreciacion)
        {
            if (depreciacion == Depreciacion.LineaRecta)
            {
                return new LineaRecta();
            }
            else
            {
                return new SDA();
            }
        }
    }
}
