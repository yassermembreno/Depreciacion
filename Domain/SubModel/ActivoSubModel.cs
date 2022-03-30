using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SubModel
{
    public class ActivoSubModel
    {
        public int Id { get; set; }
        public string Json { get; set; }

        public static ActivoSubModel Convert(Activo activo)
        {
            ActivoSubModel activoSubModel = new ActivoSubModel();
            activoSubModel.Id = 0;
            activoSubModel.Json = JsonConvert.SerializeObject(activo);

            return activoSubModel;
        }

        public static Activo Convert(ActivoSubModel activoSubModel)
        {
            return JsonConvert.DeserializeObject<Activo>(activoSubModel.Json);            
        }
    }
}
