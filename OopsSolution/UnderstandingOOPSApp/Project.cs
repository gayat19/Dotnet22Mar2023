using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApp
{
    internal abstract class Project : IProjectWorking,IManageProject
    {
        public void AssignEmployee(Employee employee)
        {
            Console.WriteLine("The employee is assigned to the project");
            employee.PrintEmployeeDetails();

        }
        public abstract void ChangeScope();
        
        public void CheckStatus()
        {
            Console.WriteLine("The current status of tehproject is blah blah blah");
        }

        public void CompleteProject()
        {
            Console.WriteLine("The project is compelted on "+DateTime.Today);
        }
        public void ScheduleProject()
        {
            Console.WriteLine("The project is schedules and we will be late for sure  ;-)");
        }
        public void StartProject()
        {
            Console.WriteLine("Yayyyy we have started the project");
        }
        public void StopProject()
        {
            Console.WriteLine("Hard stopping the project");
        }
    }
    class ProjectChange:Project
    {
        public override void ChangeScope()
        {
            Console.WriteLine("Changed teh scope of the project");
        }
    }
}
