using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public abstract class BaseRepositoy<T> : IModel<T>
    {
        public List<T> data;
        protected BaseRepositoy()
        {
            data = new List<T>();
        }
        public void Add(T t)
        {
            data.Add(t);
        }

        public void Delete(T t)
        {
            data.Remove(t);
        }

        public List<T> Read()
        {
            return data;
        }
    }
}
