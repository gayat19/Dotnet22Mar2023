using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingGenericsApp
{
    internal interface IRepo<T>
    {
        T Add(T item);
        List<T> GetAll();
    }
}
