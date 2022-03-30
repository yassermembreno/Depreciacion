using Domain.Entities;
using Domain.Interfaces;
using Domain.SubModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class JsonActivoRepository : IActivoModel
    {
        private RAFContext context;
        private int SIZE = 1600;

        public JsonActivoRepository()
        {
            context = new RAFContext("activoSubModel", SIZE);
        }

        public void Add(Activo t)
        {
            try
            {
                t.Id = context.GetLastId() + 1;
                ActivoSubModel activoSubModel = ActivoSubModel.Convert(t);
                context.Create<ActivoSubModel>(activoSubModel);
            }
            catch (Exception)
            {
                throw;
            }
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
            List<ActivoSubModel> activoSubModels = context.GetAll<ActivoSubModel>();
            return activoSubModels.Count == 0 ? new List<Activo>() :
                   activoSubModels.Select(x => ActivoSubModel.Convert(x)).ToList();
        }
    }
}
