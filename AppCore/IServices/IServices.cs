using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {

        void Add(T t);
        void Delete(T t);
        List<T> Read();
    }
}
