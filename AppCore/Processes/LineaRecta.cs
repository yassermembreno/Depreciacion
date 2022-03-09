using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class LineaRecta : IDepreciacionModel
    {
        public List<double> Depreciacion(Activo activo)
        {   
            double depreciacion = (activo.Valor - activo.ValorResidual) / activo.VidaUtil;
            return Enumerable.Repeat<double>(depreciacion, activo.VidaUtil).ToList();                        
        }
    }
}
