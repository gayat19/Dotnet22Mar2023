using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApp
{
    internal interface IProjectWorking
    {
        void AssignEmployee(Employee employee);
        void ScheduleProject();
        void CompleteProject();
        void StartProject();
    }
}
