using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingGenericsApp
{
    internal class EmployeeRepository : IRepo<Employee>
    {
        public Employee Add(Employee item)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
