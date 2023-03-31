using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingGenericsApp
{
    internal class DeparmentRepository : IRepo<Department>
    {
        public Department Add(Department item)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
