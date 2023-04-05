using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDelegateApp
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void TakeLeave(int noOfDays)
        {
            Console.WriteLine($"The employee {Name} is taking a leave of "+noOfDays);
        }
    }
}
