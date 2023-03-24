using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApp
{
    internal class Employee
    {
        internal int something;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public Employee()//Default constructor
        {
            
        }
        public Employee(int id, string name, int age) //Parameterized constructor
        {
            Id = id;
            Name = name;
            Age = age;
        }
        internal void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee id : {0} Employee name : {1} Employee Age {2}",Id,Name,Age);
        }
        internal void UpdateAge(ref int age)
        {
            age++;
            Age = age;
            
            Console.WriteLine("Age updated");
        }
        internal bool CheckAge(out string message)
        {
            //if (Age > 18)
            //    return true;
            //else return false;
            if (Age < 18)
            {
                message = "Too young to work";
                return false;
            }
            else if(Age>56)
            {
                message = "Too old to work";
                return false;
            }
            else
            {
                message = "Right age to work";
                return true;
            }
           // return Age > 18 ? true : false;
        }
        internal void ChangeName(string name="XYZ")
        {
            Name = name;
        }
        internal void SendRandaomMessage(params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        internal void ChangeEmployeeAge(int age,int diff)
        {
            Age = age;
            Age += diff;
        }
        internal void ChangeEmployeeAge(int age)
        {
            Age = age;
            Age++;
        }
        ~Employee()
        {
            
        }
    }
}
