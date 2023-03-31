using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingGenericsApp
{
    internal class Employee:IComparable<Employee>,IEquatable<Employee>
    {
        public int Id{ get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Employee()
        {
            
        }
        public Employee(int id, string name, int age)
        {
            Id = id;
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return "Employee Id : " + Id +
                "\nEmployee Name : " + Name +
                "\nEmployee Age : " + Age;
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee e1, e2;
        //    e1 = this;
        //    e2 = (Employee)obj;
        //   if(e1.Id==e2.Id && e1.Name==e2.Name)
        //    {
        //        return true;
        //    }
        //   return false;
        //}
        public int CompareTo(Employee? other)
        {
            Employee e1, e2;
            e1 = this;
            e2 = other;
            return 0-(e1.Age.CompareTo(e2.Age));
        }

        public bool Equals(Employee? other)
        {
            Employee e1, e2;
            e1 = this;
            e2 = other;
            if (e1.Id == e2.Id && e1.Name == e2.Name)
            {
                return true;
            }
            return false;
        }
    }
    class SortByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
