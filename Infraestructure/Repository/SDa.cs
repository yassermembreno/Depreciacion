using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class SDA : IDepreciacionModel
    {
        public List<double> Depreciacion(Activo activo)
        {
            List<double> depreciaciones = new List<double>();
            double TotalVidaUtil=0;
            for(int i=1; i < activo.vidaUtil+1; i++)
            {
                TotalVidaUtil += i;
            }
           for(int i = 1; i < activo.vidaUtil+1; i++)
            {
                double depreciacion = (i*(activo.valor-activo.valorResidual)) / TotalVidaUtil;
                depreciaciones.Add(depreciacion);
            }
            return depreciaciones;
        }
    }
}
