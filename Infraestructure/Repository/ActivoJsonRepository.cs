using Domain.Entities;
using Domain.Interfaces;
using Domain.SubModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ActivoJsonRepository : IActivoModel
    {
        private RAFContext context;
        private int SIZE = 1600;

        public ActivoJsonRepository()
        {
            context = new RAFContext("activoJson", SIZE);
        }
        public void Add(Activo t)
        {            
            t.Id = context.GetLastId() + 1;
            context.Create<ActivoSubModel>(ActivoSubModel.Convert(t));
        }

        public void Delete(Activo t)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Activo> Read()
        {
            List<ActivoSubModel> activoSubModels =  context.GetAll<ActivoSubModel>();
            return activoSubModels.Select(x => ActivoSubModel.Convert(x)).ToList();
        }
    }
}
