using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDelegateApp
{
    internal class Company
    {
        public delegate void NotifyManager(int days);
        public event NotifyManager InformManager;
        public void AssignFunction(Employee employee)
        {
           
            InformManager = new NotifyManager(employee.TakeLeave);
        }
        public void EmployeeOperation()
        {
            Console.WriteLine("Please enter the number of days you need leave");
            int count = Convert.ToInt32(Console.ReadLine());
            InformManager(count);
        }
    }
}
