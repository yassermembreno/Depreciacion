using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ListActivoRepository : BaseRepositoy<Activo>, IActivoModel
    {
        public Activo GetById(int id)
        {
            foreach(Activo activo in data)
            {
                if (activo.id == id)
                {
                    return activo;
                   
                }
               
            }
            return null;
        }
    }
}
