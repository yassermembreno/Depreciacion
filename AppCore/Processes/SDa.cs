using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class SDA : IDepreciacionModel
    {
        public List<double> Depreciacion(Activo activo)
        {
           List<double> depreciaciones = new List<double>();
           double TotalVidaUtil= (activo.VidaUtil*(1 + activo.VidaUtil))/2;
             
           for(int i = 1; i < activo.VidaUtil+1; i++)
           {
                double depreciacion = (i*(activo.Valor-activo.ValorResidual)) / TotalVidaUtil;
                depreciaciones.Add(depreciacion);
           }
           return depreciaciones;
        }
    }
}
