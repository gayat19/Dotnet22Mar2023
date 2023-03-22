using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Employee
    {
        //private float salary;
        //public float Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}
       // public float Salary { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Employee()
        {
            
        }

    }
}
