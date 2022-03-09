using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Activo
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public double valor { get; set; }

        public double vidaUtil { get; set; }

        public double valorResidual { get; set; }

       

    }
}
